using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe.Model
{
    public class Menu
    {
        private string name;
        private int count;
        private float price;
        private float totalPrice;

        public string Name { get => name; set => name = value; }
        public int Count { get => count; set => count = value; }
        public float Price { get => price; set => price = value; }
        public float TotalPrice { get => totalPrice; set => totalPrice = value; }
    }

    public class BillDetail
    {
        private int id;
        private string tableName;
        private DateTime? dateCheckIn;
        private DateTime? dateCheckOut;
        private float? totalPrice;

        public int Id { get => id; set => id = value; }
        public string TableName { get => tableName; set => tableName = value; }
        public DateTime? DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
        public DateTime? DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }
        public float? TotalPrice { get => totalPrice; set => totalPrice = value; }
    }


    public class BillModel
    {
        public void InsertBill(int idTable)
        {
            using (DataClasses2DataContext db = new DataClasses2DataContext())
            {
                Bill newBill = new Bill()
                {
                    DateCheckIn = DateTime.Now,
                    DateCheckOut = null,
                    idTableFood = idTable,
                    status = false 
                };

                db.Bills.InsertOnSubmit(newBill);
                db.SubmitChanges();
            }
        }

        public int GetUnCheckBillIDByTableId(int tableId)
        {
            using (DataClasses2DataContext db = new DataClasses2DataContext())
            {
                var bill = db.Bills.FirstOrDefault(b => b.idTableFood == tableId && b.status.Equals(0));
                if (bill != null)
                {
                    return bill.id;
                }
                else
                {
                    return -1;
                }
            }
        }


        public int GetMaxIDBill()
        {
            using (DataClasses2DataContext db = new DataClasses2DataContext())
            {
                int maxId = db.Bills.Max(b => b.id);
                return maxId;
            }
        }

        public List<Menu> GetListMenuTable(int id)
        {
            using (DataClasses2DataContext db = new DataClasses2DataContext())
            {
                var menuItems = from bi in db.BillInfos
                                join b in db.Bills on bi.idBill equals b.id
                                join f in db.Foods on bi.idFood equals f.id
                                where b.status.Equals(0) && b.idTableFood == id
                                select new Menu
                                {
                                    Name = f.name,
                                    Count = bi.count,
                                    Price = (float)f.price,
                                    TotalPrice = (float)(f.price * bi.count)
                                };

                return menuItems.ToList();
            }
        }


        public List<Menu> GetListMenuBill(int idBill)
        {
            using (DataClasses2DataContext db = new DataClasses2DataContext())
            {
                var menuItems = from bi in db.BillInfos
                                join b in db.Bills on bi.idBill equals b.id
                                join f in db.Foods on bi.idFood equals f.id
                                where b.id == idBill
                                select new Menu
                                {
                                    Name = f.name,
                                    Count = bi.count,
                                    Price = (float)f.price,
                                    TotalPrice = (float)(f.price * bi.count)
                                };

                return menuItems.ToList();
            }
        }


        public void CheckOut(int id)
        {
            using (DataClasses2DataContext db = new DataClasses2DataContext())
            {
                var bill = db.Bills.FirstOrDefault(b => b.id == id);
                if (bill != null)
                {
                    bill.status = true;
                    db.SubmitChanges();
                }
            }
        }

        public List<BillDetail> GetAllBillCheckoutOfDate(DateTime selectedDateStart, DateTime? selectedDateEnd)
        {
            if(selectedDateStart != DateTime.Now)
            {
                using (DataClasses2DataContext db = new DataClasses2DataContext())
                {
                    var billDetails = from b in db.Bills
                                      join tf in db.TableFoods on b.idTableFood equals tf.id
                                      where b.status.Equals(1) && b.DateCheckIn >= selectedDateStart && b.DateCheckIn <= selectedDateEnd
                                      select new BillDetail
                                      {
                                          Id = b.id,
                                          TableName = tf.name,
                                          DateCheckIn = b.DateCheckIn,
                                          DateCheckOut = b.DateCheckOut,
                                          TotalPrice = (float?)(b.BillInfos.Sum(bi => bi.count * (float)(bi.Food.price))) ?? 0
                                      };
                    return billDetails.ToList();
                }
            }
            else
            {
                using (DataClasses2DataContext db = new DataClasses2DataContext())
                {
                    var billDetails = from b in db.Bills
                                      join tf in db.TableFoods on b.idTableFood equals tf.id
                                      where b.status.Equals(1) && b.DateCheckIn == selectedDateStart 
                                      select new BillDetail
                                      {
                                          Id = b.id,
                                          TableName = tf.name,
                                          DateCheckIn = b.DateCheckIn,
                                          DateCheckOut = b.DateCheckOut,
                                          TotalPrice = (float?)(b.BillInfos.Sum(bi => bi.count * (float)(bi.Food.price))) ?? 0
                                      };
                    return billDetails.ToList();
                }
            }
        }
        public void DeleteTakeAwayBill(int idFB)
        {
            using (DataClasses2DataContext data = new DataClasses2DataContext())
            {
                try
                {
                    var billInForToDelete = data.BillInfos.SingleOrDefault(b => b.idBill == idFB);
                    if (billInForToDelete != null)
                    {
                        data.BillInfos.DeleteOnSubmit(billInForToDelete);
                        data.SubmitChanges();
                    }
                    //
                    var billToDelete = data.Bills.SingleOrDefault(b => b.id == idFB);
                    if (billToDelete != null)
                    {
                        data.Bills.DeleteOnSubmit(billToDelete);
                        data.SubmitChanges();
                        MessageBox.Show("Xóa bill thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (ChangeConflictException ex)
                {
                    MessageBox.Show("Xóa bill không thành công: " + ex.Message);
                }
            }

        }
        //xóa 1 đơn mang về (Công)

    }
}

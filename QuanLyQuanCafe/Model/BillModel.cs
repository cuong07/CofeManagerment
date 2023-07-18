using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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



    }
}

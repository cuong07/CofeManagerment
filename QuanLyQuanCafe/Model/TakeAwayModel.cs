using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.Model
{
    public class BillDetailsCTL     //đối tượng chi tiết bill
    {
        public int BillId { get; set; }
        public int FoodID { get; set; }
        public string FoodName { get; set; }
        public int Quantity { get; set; }
        public BillDetailsCTL(int billID, int foodID, string foodName, int quantity)
        {
            BillId = billID;
            FoodID = foodID;
            FoodName = foodName;
            Quantity = quantity;
        }
        public BillDetailsCTL()
        {
            BillId = 0;
            FoodID = 0;
            FoodName = string.Empty;
            Quantity = 0;
        }
    }
    internal class TakeAwayModel
    {
        //private BillDetailsCTL billDetailsCTL = new BillDetailsCTL();
        public List<Bill> GetListBillofTakeAway()
        {
            List<Bill> listFood;
            using (DataClasses2DataContext db = new DataClasses2DataContext())
            {
                listFood = (from bill in db.Bills
                            where bill.idTableFood == 1 && bill.status == false
                            select bill).ToList();
            }
            return listFood;
        }
        //lấy bill mang v
        public List<BillDetailsCTL> GetBillDetail(int idB)
        {
            List<BillDetailsCTL> listBillDetails = new List<BillDetailsCTL>();
            using (DataClasses2DataContext db = new DataClasses2DataContext())
            {
                var varbillDetails = from bi in db.BillInfos
                                     join f in db.Foods on bi.idFood equals f.id
                                     join b in db.Bills on bi.idBill equals b.id
                                     where b.idTableFood == 1 && b.status == false && b.id == idB
                                     group new { bi, f } by new { bi.idBill, f.id, f.name, bi.count } into g
                                     select new
                                     {
                                         idBill = g.Key.idBill,
                                         FoodID = g.Key.id,
                                         name = g.Key.name,
                                         count = g.Key.count
                                     };
                foreach (var b in varbillDetails)
                {
                    BillDetailsCTL billDetailsCTL = new BillDetailsCTL(b.idBill, b.FoodID, b.name, b.count);
                    listBillDetails.Add(billDetailsCTL);
                }
            }
            return listBillDetails;
        }
        //lấy danh sách chi tiết bill
    }
}
using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return instance; }
            private set => instance = value;
        }
        public BillDAO() { }

        // Lấy bill chưa thanh toán
        public int getUnCheckBillIDByTableId(int id) 
        {
            string query = $"SELECT * FROM dbo.Bill WHERE idTableFood = {id} AND status = 0";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }
            return -1;
        }
        // Them bill
        public void InsertBill(int id)
        {
            string query = $"EXEC USP_InsertBill @idTable";
            DataProvider.Instance.ExcuteNonQuery(query, new object[] { id });
        }

        // Lay bill them sau cung
        public int GetMaxIDBill()
        {
            try
            {
                string query = $"SELECT MAX(id) FROM dbo.Bill";
                return (int)DataProvider.Instance.ExcuteScalar(query);
            }
            catch (Exception)
            {
                return 1;
                throw;
            }
        }
        public void CheckOut(int id)
        {
            string query = $"UPDATE dbo.Bill SET status = 1 WHERE id = {id}";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
    }
}

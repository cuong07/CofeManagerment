using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;

        public static BillInfoDAO Instance
        {
            get { if (instance == null) instance = new BillInfoDAO(); return instance; }
            private set => instance = value;
        }

        public BillInfoDAO() { }

        public List<BillInfo> GetListBillInfo(int id)
        {

            List<BillInfo> listBillInfo = new List<BillInfo>();

            string query = $"SELECT * FROM dbo.BillInfo WHERE idBill = {id}";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                BillInfo billInfo = new BillInfo(item);
                listBillInfo.Add(billInfo);
            }

            return listBillInfo;
        }

        public void InsertBillInfo(int idBill, int idFood, int count)
        {
            string query = $"EXEC USP_InsertBillInfo @idBill , @idFood , @count ";
            DataProvider.Instance.ExcuteNonQuery(query, new object[] { idBill, idFood, count });
        }
    }
}

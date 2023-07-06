using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class BillInfo
    {
        private int iD;
        private int idBill;
        private int idFood;
        private int count;

        public int ID { get => iD; set => iD = value; }
        public int IdBill { get => idBill; set => idBill = value; }
        public int IdFood { get => idFood; set => idFood = value; }
        public int Count { get => count; set => count = value; }

        public BillInfo(int id, int idFood, int idBill, int count)
        {
            this.ID = id;
            this.IdBill = idBill;
            this.IdFood = idFood;
            this.Count = count;
        }

        public BillInfo(DataRow row)
        {
            this.ID = (int)row["id"];
            this.IdFood = (int)row["idFood"];
            this.IdBill = (int)row["idBill"];
            this.Count = (int)row["count"];
        }
    }
}

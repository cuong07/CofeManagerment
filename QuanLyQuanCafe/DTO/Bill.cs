using QuanLyQuanCafe.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class Bill
    {
        private int iD;
        private int iDTable;
        private DateTime? dateCheckIn;
        private DateTime? dateCheckOut;
        private bool status;

        public int ID { get => iD; set => iD = value; }
        public int IDTable { get => iDTable; set => iDTable = value; }
       
        public bool Status { get => status; set => status = value; }
        public DateTime? DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
        public DateTime? DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }

        public Bill(int id, DateTime? dateCheckIn, DateTime? dateCheckOut, bool status)
        {
            this.ID = id;
            this.DateCheckIn = dateCheckIn;
            this.DateCheckOut = dateCheckOut;
            this.Status = status;
        }

        public Bill(DataRow row)
        {
            this.ID = (int)row["id"];
            this.DateCheckIn = (DateTime?)row["DateCheckIn"];
            var dateCheckOutTmp = row["DateCheckOut"];
            if (dateCheckOutTmp.ToString() != "")
            {
                this.DateCheckOut = (DateTime?)dateCheckOutTmp;
            }
            this.Status = (bool)row["status"];
        }

       

    }
}

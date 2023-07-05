using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class Table
    {
        private int iD;
        private string name;
        private bool status;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public bool Status { get => status; set => status = value; }

        public Table( int id, string name, bool status) {
            this.ID = id;
            this.Name = name;
            this.Status = status;
        }

        public Table( DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = (string)row["name"];
            this.Status = (bool)row["status"];
        }
    }
}

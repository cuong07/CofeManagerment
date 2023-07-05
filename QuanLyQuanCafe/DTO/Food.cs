using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class Food
    {
        private int iD;
        private int iDCategory;
        private string name;
        private float price;

        public int ID { get => iD; set => iD = value; }
        public int IDCategory { get => iDCategory; set => iDCategory = value; }
        public string Name { get => name; set => name = value; }
        public float Price { get => price; set => price = value; }


        public Food(int id, int idcategory, float price, string name)
        {
            this.ID = id;
            this.IDCategory = idcategory;
            this.Name = name;
            this.Price = price;
        }


        public Food(DataRow row)
        {
            this.ID = (int)row["id"];
            this.IDCategory = (int)row["idCategory"];
            this.Name = (string)row["name"];
            this.Price = (float)Convert.ToDouble((row["price"]).ToString());
        }
    }
}

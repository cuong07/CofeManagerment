using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace QuanLyQuanCafe.DTO
{
    internal class MenuFood
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int Price { get; set; }
        public MenuFood(int id, string name,string image,int prince) 
        { 
            this.ID = id;
            this.Name = name;
            this.Image = image;
            this.Price = prince;
        }
        public MenuFood(DataRow row) 
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.Image = row["image"].ToString(); ;
            this.Price = (int)row["prince"];
        }


    }
}

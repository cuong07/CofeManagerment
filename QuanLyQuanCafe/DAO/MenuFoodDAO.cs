using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    internal class MenuFoodDAO
    {
        public static MenuFoodDAO instance;
        public static MenuFoodDAO Instance
        {
            get { if (instance == null) instance = new MenuFoodDAO(); return MenuFoodDAO.instance; }
            private set {MenuFoodDAO.instance = value; }
        }
        private MenuFoodDAO() { }
        public DataTable GetMenuFoodByCategoryID(int id)
        {
            string query;
            if (id == 9)
            {
                query = "select * from Food";
            }
            else
            {
                query = "select * from Food where idCategory = " + id;
            }
            
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        //truy vấn dữ liệu bằng Category Id.
    }
}

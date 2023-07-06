using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                query = "select * from Food";       //query toàn bộ bảng Food
            }
            else
            {
                query = "select * from Food where idCategory = " + id;      //query dựa theo idCategory truyền vào
            }
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        //truy vấn dữ liệu bằng Category Id, trả về kiểu dữ liệu Datatable.
        public List<ListViewItem> GetListItemsMenuFood(int id)
        {
            List<ListViewItem> listViewItems = new List<ListViewItem>();
            DataTable dataFood = GetMenuFoodByCategoryID(id);      //query bảng MenuFood
            foreach (DataRow row in dataFood.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < dataFood.Columns.Count - 1; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                listViewItems.Add(item);
            }
            return listViewItems;
        }
        // Get lisFoodbyid của cường
        public List<MenuFood> getListFoodByCategory(int id = 0)
        {
            List<MenuFood> listMenuFood = new List<MenuFood>();
            string query = "";

            if(id == 0)
            {
                query = $"SELECT * FROM Food";
            }
            else
            {
                query = $"SELECT * FROM Food WHERE idCategory = {id}";
            }

            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                MenuFood food = new MenuFood(row);
                listMenuFood.Add(food);
            }
            return listMenuFood;
        }
        
        //truy vấn dữ liệu bằng Category Id, trả về kiểu dữ liệu List<ListViewItem>.
        public int GetQuantityItemOfTable(string query)
        {
            int quantity = (int)DataProvider.Instance.ExcuteScalar(query);
            return quantity;
        }
        //lấy số lượng dòng của 1 bảng.
    }
}

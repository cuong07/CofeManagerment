using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    internal class CategoryDAO
    {
        public static CategoryDAO instance;
        public static CategoryDAO Instance
        {
            get { if (instance == null) instance = new CategoryDAO(); return CategoryDAO.instance; }
            private set { CategoryDAO.instance = value; }
        }
        public CategoryDAO() { }
        public List<Category> GetListCategory()
        {
            List<Category> list = new List<Category>();

            string query = "select * from FoodCategory" ;
            DataTable dataCategory = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in dataCategory.Rows)
            {
                Category cate = new Category(item);
                list.Add(cate);
            }    
            return list;
        }
    }
}

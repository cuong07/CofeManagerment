using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.Model
{
    public class CategoryModel
    {
        public List<FoodCategory> GetListCategory()
        {
            List<FoodCategory> listCategory = GetListCategoryFromDatabase();
            return listCategory;
        }

        #region Method
        private List<FoodCategory> GetListCategoryFromDatabase()
        {
            List<FoodCategory> listCategory;
            using (DataClasses2DataContext db = new DataClasses2DataContext())
            {
                listCategory = db.FoodCategories.ToList();
            }
            return listCategory;
        }




        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.Model
{
    public class FoodModel
    {
       public List<Food> GetListFoodByCategory(int id)
        {
            List<Food> listFood = GetListFoodByCategoryFromDatabase(id);
            return listFood;
        }

        public List<Food> GetListFoodByCategoryFromDatabase(int id)
        {
            List<Food> listFood;
            using (DataClasses2DataContext db = new DataClasses2DataContext())
            {
                listFood = (from food in db.Foods where food.idCateGory == id select food).ToList();
            }
            return listFood;
        }
    }
}

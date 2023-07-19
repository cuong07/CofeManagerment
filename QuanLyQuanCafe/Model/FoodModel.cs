using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                if(id!=9)
                {
                    listFood = (from food in db.Foods where food.idCateGory == id select food).ToList();
                }
                else //load tất cả món ăn với id là 9(Công thêm)
                {
                    listFood = (from food in db.Foods where food.idCateGory < id select food).ToList();
                }    
            }
            return listFood;
        }
        public List<ListViewItem> GetListViewItemOfListFood(int id)
        {
            List<ListViewItem> listViewItems = new List<ListViewItem>();
            List<Food> listFood = GetListFoodByCategoryFromDatabase(id);
            foreach (Food food in listFood)
            {
                ListViewItem item = new ListViewItem(food.id.ToString());
                item.SubItems.Add(food.name.ToString());
                item.SubItems.Add("Updating");
                item.SubItems.Add(food.price.ToString());
                listViewItems.Add(item);
            }
            return listViewItems;
        }
        //lấy ra danh sách dạng ListViewItem (Công).
        
    }
}

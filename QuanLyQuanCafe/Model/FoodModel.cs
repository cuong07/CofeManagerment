using System;
using System.Collections.Generic;
using System.Data.Linq;
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
                item.SubItems.Add(food.idCateGory.ToString());
                listViewItems.Add(item);
            }
            return listViewItems;
        }
        //lấy ra danh sách dạng ListViewItem (Công).
        public void InsertFood(string nameFood, string imageFood, double priceFood,int idCategory)
        {
            Food food = new Food() {
                name = nameFood,
                images = imageFood,
                price = priceFood,
                idCateGory = idCategory
            };
            using(DataClasses2DataContext data = new DataClasses2DataContext())
            {
                try
                {
                    data.Foods.InsertOnSubmit(food);
                    data.SubmitChanges();
                    MessageBox.Show("Thêm món thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (ChangeConflictException ex)
                {
                    MessageBox.Show("Thêm món không thành công: " + ex.Message);
                }
            }
        }
        //Chèn thêm 1 food
        public void UpdateFood(int idFood, string nameFood,double priceFood, int idCategory)
        {
            using (DataClasses2DataContext data = new DataClasses2DataContext())
            {
                try
                {
                    var foodToUpdate = data.Foods.SingleOrDefault(f => f.id == idFood);
                    if (foodToUpdate != null)
                    {
                        foodToUpdate.id = idFood;
                        foodToUpdate.name = nameFood; // thay tên mới của món ăn
                        foodToUpdate.images = string.Empty;
                        foodToUpdate.price = priceFood; // thay giá mới của món ăn
                        foodToUpdate.idCateGory = idCategory;
                        data.SubmitChanges();
                        MessageBox.Show("Update món thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (ChangeConflictException ex)
                {
                    MessageBox.Show("Update món không thành công: " + ex.Message);
                }
            }    
                
        }
        //update 1 món ăn dựa trên id món
        public void DeleteFood(int idFood)
        {
            using (DataClasses2DataContext data = new DataClasses2DataContext())
            {
                try
                {
                    var foodToDelete = data.Foods.SingleOrDefault(f => f.id == idFood);
                    if (foodToDelete != null)
                    {
                        data.Foods.DeleteOnSubmit(foodToDelete);
                        data.SubmitChanges();
                        MessageBox.Show("Xóa món thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (ChangeConflictException ex)
                {
                    MessageBox.Show("Xóa món không thành công: " + ex.Message);
                }
            }
            
        }
        
    }
}

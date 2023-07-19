using QuanLyQuanCafe.Model;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe.Controller
{
    
    public class FoodController
    {
        private fTable _fTable;
        private FoodModel _foodModel;

        public FoodController()
        {
            _fTable = new fTable();
            _foodModel = new FoodModel();
        }

        public FoodController(fTable fTable)
        {
            _fTable = fTable;
            _foodModel = new FoodModel();
        }

        public void GetListFoodByCategory(int id)
        {
            List<Food> listFood = _foodModel.GetListFoodByCategory(id);
            _fTable.LoadFoodByCategory(listFood);
        }

        public void InsertFood(string nameFood, string imageFood, double priceFood, int idCategory)
        {
            _foodModel.InsertFood(nameFood, imageFood, priceFood, idCategory);
        }
        //
        public void UpdateFood(int idFood, string nameFood, double priceFood, int idCategory)
        {
            _foodModel.UpdateFood(idFood, nameFood, priceFood, idCategory);
        }
        //
        public void DeleteFood(int idFood)
        {
            _foodModel.DeleteFood(idFood);
        }
    }
}

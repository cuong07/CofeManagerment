using QuanLyQuanCafe.Model;
using System;
using System.Collections.Generic;
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


    }
}


using QuanLyQuanCafe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.Controller
{
    public class CategoryController
    {
        private fTable _fTable;
        private CategoryModel _categoryModel;

        public CategoryController(fTable fTable)
        {
            _fTable = fTable;
            _categoryModel = new CategoryModel();
        }

        public void LoadCategory()
        {
            List<FoodCategory> listCategory = _categoryModel.GetListCategory();
            _fTable.LoadListCategory(listCategory);
        }
    }
}

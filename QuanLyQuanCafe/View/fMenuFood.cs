﻿
using QuanLyQuanCafe.Controller;
using QuanLyQuanCafe.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;

namespace QuanLyQuanCafe
{
    public partial class fMenuFood : Form
    {
        private CategoryModel categoryModel = new CategoryModel();
        private FoodModel foodModel = new FoodModel();
        private FoodController foodController = new FoodController();
        public fMenuFood()
        {
            InitializeComponent();
        }
        private void fMenuFood_Load(object sender, EventArgs e)
        {
            LoadFindFoddName();
            Loadcategory();
            cbFilterDishes.Text = "All";
            
        }
        //form load
        
        
        public void Loadcategory()
        {
            cbFilterDishes.DataSource = categoryModel.GetListCategory();
            cbFilterDishes.DisplayMember = "Name";
        }
        //Load danh sách foodcategory
        public void LoadLsvMenuFood(int id)
        {
            lsvFood.Items.Clear();      //reset lại data của lsv trước khi load loại mới tránh bị đè dữ liệu cũ.
            List<ListViewItem> listViewItems = foodModel.GetListViewItemOfListFood(id);
            foreach (ListViewItem item in listViewItems)
            {
                lsvFood.Items.Add(item);
            }
            cbFindFoodName.Text = string.Empty;
        }
        //Load menufood dựa vào id category
        public void LoadFindFoddName()
        {
            cbFindFoodName.DataSource = foodModel.GetListFoodByCategoryFromDatabase(9);
            cbFindFoodName.DisplayMember = "Name";
            cbFindFoodName.Text = "All";
        }
        private void lsvFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lsvFood.SelectedItems.Count == 1)
            {
                grbEditFood.Visible = true;     //hiện form chỉnh sửa.
                txtEditId.Text = lsvFood.SelectedItems[0].SubItems[0].Text;
                txtEditFoodName.Text = lsvFood.SelectedItems[0].SubItems[1].Text;
                txtEditImageName.Text = lsvFood.SelectedItems[0].SubItems[2].Text;
                txtEditPrice.Text = lsvFood.SelectedItems[0].SubItems[3].Text;
                txtEditIdCategory.Text = lsvFood.SelectedItems[0].SubItems[4].Text;
            }
        }
        //Load item của SelectedItems vào form "chỉnh sửa"

        private void btnEditExit_Click(object sender, EventArgs e)
        {
            grbEditFood.Visible = false;     //ẩn form chỉnh sửa.
        }
        private void btnCloseFormMenuFood_Click(object sender, EventArgs e)
        {
            this.Close();        //Đóng form
        }
        
        private void cbFilterDishes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 9;
            ComboBox cb = (ComboBox)sender;
            FoodCategory cate = (FoodCategory)cb.SelectedItem;
            id = cate.id;       //lấy Id của item hiện tại của cbFillerDishes
            LoadLsvMenuFood(id);    //Load items của lsvMenuFood
        }

        private void cbFindFoodName_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsvFood.Items.Clear();
            List<Food> listFood = foodModel.GetListFoodByCategoryFromDatabase(9);
            foreach (Food food in listFood)
            {
                if (food.name.Equals(cbFindFoodName.Text))
                {
                    ListViewItem item = new ListViewItem(food.id.ToString());
                    item.SubItems.Add(food.name.ToString());
                    item.SubItems.Add("Updating");
                    item.SubItems.Add(food.price.ToString());
                    lsvFood.Items.Add(item);
                }
            }
            cbFilterDishes.Text = string.Empty;
        }
        //Tìm kiếm món ăn theo tên
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string nameFood = txtNewFoodName.Text;
                string imageFood = string.Empty;
                double priceFood = Convert.ToDouble(txtNewPrice.Text);
                int idCategory = Convert.ToInt32(txtNewIdCategory.Text);
                foodController.InsertFood(nameFood, imageFood, priceFood, idCategory);
                //
                txtNewFoodName.Text = string.Empty;
                txtNewPrice.Text = string.Empty;
                txtNewIdCategory.Text = string.Empty;
                Loadcategory();     
                cbFilterDishes.Text = "All";        //Load lại form chính
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Lấy thông tin món ăn mới đc nhập.

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            try
            {
                System.Windows.Forms.Button bt = sender as System.Windows.Forms.Button;
                switch (bt.Text)
                {
                    case "Update":
                        int idFood = Convert.ToInt32(txtEditId.Text);
                        string nameFood = txtEditFoodName.Text;
                        string imageFood = string.Empty;
                        double priceFood = Convert.ToDouble(txtEditPrice.Text);
                        int idCategory = Convert.ToInt32(txtEditIdCategory.Text);
                        foodController.UpdateFood(idFood, nameFood, priceFood, idCategory);
                        //
                        txtEditFoodName.Text = string.Empty;
                        txtEditPrice.Text = string.Empty;
                        txtEditIdCategory.Text = string.Empty;
                        grbEditFood.Visible = false;
                        Loadcategory();
                        cbFilterDishes.Text = "All";
                        break;
                    case "Xóa món":
                        int idDeleteFood = Convert.ToInt32(txtEditId.Text);
                        foodController.DeleteFood(idDeleteFood);
                        grbEditFood.Visible = false;
                        Loadcategory();
                        cbFilterDishes.Text = "All";
                        break;

                }

                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //
        
    }
}

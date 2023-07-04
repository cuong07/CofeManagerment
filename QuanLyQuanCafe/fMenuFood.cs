using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class fMenuFood : Form
    {
        public fMenuFood()
        {
            InitializeComponent();
        }

        private void btnCloseFormMenuFood_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Đóng form
        void LoadMenuFood(int id)
        {
            lsvFood.Items.Clear();      //reset lại data của lsv trước khi load loại mới tránh bị đè dữ liệu cũ.
            DataTable dataFood = MenuFoodDAO.Instance.GetMenuFoodByCategoryID(id);      //query bảng MenuFood
            foreach (DataRow row in dataFood.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < dataFood.Columns.Count - 1; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                lsvFood.Items.Add(item);
            }
        }
        //Load data vào lsvFood
        
        private void fMenuFood_Load(object sender, EventArgs e)
        {     
            cbFilterDishes.DataSource = CategoryDAO.Instance.GetListCategory();     //set data cho cbFilterDishes bằng cách gọi hàm query bảng Category.
            cbFilterDishes.DisplayMember = "name";      //hiển thị cột name của Category
            cbFilterDishes.Text = "All";    //hiển thị Category 9 (all) chạy lúc mở form.
        }
        //Form load

        private void cbFilterDishes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 9;
            ComboBox cb = (ComboBox)sender;
            Category cate = (Category)cb.SelectedItem;
            id = cate.Id;
            LoadMenuFood(id);
        }
        //Load lại lsvFood theo category đã chọn.

        private void lsvFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lsvFood.SelectedItems.Count == 1)
            {
                grbEditFood.Visible = true;     //hiện form chỉnh sửa.
                txtId.Text = lsvFood.SelectedItems[0].SubItems[0].Text;
                txtFoodName.Text = lsvFood.SelectedItems[0].SubItems[1].Text;
                txtImageName.Text = lsvFood.SelectedItems[0].SubItems[2].Text;
                txtPrice.Text = lsvFood.SelectedItems[0].SubItems[3].Text;
            }

        }
        //Load item của SelectedItems vào form "chỉnh sửa"

        private void btnEditExit_Click(object sender, EventArgs e)
        {
            grbEditFood.Visible = false;     //ẩn form chỉnh sửa.

        }

    }
}

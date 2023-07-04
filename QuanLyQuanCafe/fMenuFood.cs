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
        
        void LoadLsvMenuFood(int id)
        {
            lsvFood.Items.Clear();      //reset lại data của lsv trước khi load loại mới tránh bị đè dữ liệu cũ.
            List<ListViewItem> listViewItems = MenuFoodDAO.Instance.GetListItemsMenuFood(id);
            foreach (ListViewItem item in listViewItems)    
            {
                lsvFood.Items.Add(item);
            }    
        }
        //Load items của lsvMenuFood
        private void fMenuFood_Load(object sender, EventArgs e)
        {     
            cbFilterDishes.DataSource = CategoryDAO.Instance.GetListCategory();     //set data cho cbFilterDishes bằng cách gọi hàm query bảng Category.
            cbFilterDishes.DisplayMember = "name";      //hiển thị cột name của Category
            cbFilterDishes.Text = "All";    //hiển thị Category 9 (all) chạy lúc mở form.

            int nextFoodId = MenuFoodDAO.Instance.GetQuantityItemOfTable("SELECT id FROM Food WHERE id=(SELECT max(id) FROM Food)")+1;  //set trước cho id món ăn chuẩn bị thêm vào thực đơn
            txtNewId.Text = nextFoodId.ToString();
        }
        //Form load

        private void cbFilterDishes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 9;
            ComboBox cb = (ComboBox)sender;
            Category cate = (Category)cb.SelectedItem;
            id = cate.Id;       //lấy Id của item hiện tại của cbFillerDishes
            LoadLsvMenuFood(id);    //Load items của lsvMenuFood
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

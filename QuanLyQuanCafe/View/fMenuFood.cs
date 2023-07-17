
using QuanLyQuanCafe.Controller;
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

namespace QuanLyQuanCafe
{
    public partial class fMenuFood : Form
    {
        public fMenuFood()
        {
            InitializeComponent();
            LoadFood();
        }

        private void btnCloseFormMenuFood_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Đóng form
        
        void LoadFood()
        {
           
        }
      

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

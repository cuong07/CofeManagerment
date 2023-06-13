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
    public partial class fTableManager : Form
    {
        bool sidebarExpand;

        public fTableManager()
        {
            InitializeComponent();
        }

        #region Sidebar
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {

            // SET The minimum and Maximum

            if(sidebarExpand) 
            {
                flpSidebar.Width -= 10;
                if(flpSidebar.Width == flpSidebar.MinimumSize.Width ) 
                {
                    sidebarExpand= false;
                    sidebarTimer.Stop();
                }
            }
            else 
            {
                flpSidebar.Width += 10;
                if (flpSidebar.Width == flpSidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        #endregion

        
        private void btnSidebar_Enter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Red;
        }
        private void btnSidebar_Leave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Transparent; // Phục hồi màu nền mặc định của button khi mất kích hoạt
        }

        private Form currentChildForm; // Biến để lưu trữ form con hiện tại

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close(); // Đóng form con hiện tại nếu đã tồn tại
            }

            fTable formTable = new fTable();
            formTable.MdiParent = this;
            formTable.Show();
            formTable.Location = new Point(0, 0);
            formTable.Width = 988;
            formTable.Height = 632;
            formTable.StartPosition = FormStartPosition.Manual;
            currentChildForm = formTable; // Lưu trữ form con mới là form hiện tại
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close(); // Đóng form con hiện tại nếu đã tồn tại
            }
            fBill formBill = new fBill();
            formBill.MdiParent = this;
            formBill.Show();
            formBill.Location = new Point(0, 0);
            formBill.Width = 988;
            formBill.Height = 632;
            formBill.StartPosition = FormStartPosition.Manual;
            currentChildForm = formBill;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close(); // Đóng form con hiện tại nếu đã tồn tại
            }
            fMenuFood formMenuFood = new fMenuFood();
            formMenuFood.MdiParent = this;
            formMenuFood.Show();
            formMenuFood.Location = new Point(0, 0);
            formMenuFood.Width = 988;
            formMenuFood.Height = 632;
            formMenuFood.StartPosition = FormStartPosition.Manual;
            currentChildForm = formMenuFood;
        }

        private void btnTakeaway_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close(); // Đóng form con hiện tại nếu đã tồn tại
            }
            fTakeaway formTakeaway = new fTakeaway();
            formTakeaway.MdiParent = this;
            formTakeaway.Show();
            formTakeaway.Location = new Point(0, 0);
            formTakeaway.Width = 988;
            formTakeaway.Height = 632;
            formTakeaway.StartPosition = FormStartPosition.Manual;
            currentChildForm = formTakeaway;
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close(); // Đóng form con hiện tại nếu đã tồn tại
            }
            fRevenue formRevenue = new fRevenue();
            formRevenue.MdiParent = this;
            formRevenue.Show();
            formRevenue.Location = new Point(0, 0);
            formRevenue.Width = 988;
            formRevenue.Height = 632;
            formRevenue.StartPosition = FormStartPosition.Manual;
            currentChildForm = formRevenue;
        }

        private void fTableManager_Load(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close(); // Đóng form con hiện tại nếu đã tồn tại
            }
            fBackground formBackground = new fBackground();
            formBackground.MdiParent = this;
            formBackground.Show();
            formBackground.Location = new Point(0, 0);
            formBackground.Width = 988;
            formBackground.Height = 632;
            formBackground.StartPosition = FormStartPosition.Manual;
            currentChildForm = formBackground;
        }
    }
}

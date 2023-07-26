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
    public partial class fSetting : Form
    {
        public fSetting()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            switch (bt.Text.Trim())
            {
                case "X":
                    this.Close();
                    break;
                case "Đăng xuất":
                    DialogResult result = MessageBox.Show("Xác nhận đăng xuất", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Application.Restart();
                    }
                    break;
                case "Thoát":
                    DialogResult exitResult = MessageBox.Show("Xác nhận Thoát", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (exitResult == DialogResult.Yes)
                    {
                        Application.Exit();
                    }
                    break;
            }    
        }

        private void fSetting_Load(object sender, EventArgs e)
        {
            lbAcccountName.Text = fHome.accountName;
        }
    }
}

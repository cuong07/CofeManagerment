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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyQuanCafe
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var userName = txtUsername.Text.Trim();
            var password = txtPassword.Text.Trim();

            LoginModel loginModel = new LoginModel();
            LoginController loginController = new LoginController(loginModel);
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Hãy nhập tên đăng nhập và mật khẩu");
                return;
            }
            if (loginController.LoginSuccess(userName, password))
            {
                fHome.isSucces = true;
                fHome.accountName = userName;
                fHome.currentEmployees = loginController.currentEmployees;
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai");
            }
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!fHome.isSucces)    //nếu thoát form trực tiếp => thoát chương trình
            {
                Application.Exit();
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}

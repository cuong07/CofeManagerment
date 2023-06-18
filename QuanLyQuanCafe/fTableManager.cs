﻿using System;
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
        //
        private Form currentChildForm; // Biến để lưu trữ form con hiện tại

        private void OpenChildForm(Form childForm)       //hàm mở form con.
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close(); // Đóng form con hiện tại nếu đã tồn tại
            }
            currentChildForm = childForm;       //gán form con hiện tại bằng form truyền vào
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;       //bỏ phần tittle của form
            childForm.Dock = DockStyle.Fill;        //căn giữa
            pnBody.Controls.Add(childForm);
            pnBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //
        }
        // hàm đổi màu button khi nhấn.
        private void ChangeColorBtn(Button b1, Button b2, Button b3, Button b4, Button b5,Button b6)
        {
            b1.BackColor = Color.SaddleBrown;
            b2.BackColor = Color.Transparent;
            b3.BackColor = Color.Transparent;
            b4.BackColor = Color.Transparent;
            b5.BackColor = Color.Transparent;
            b6.BackColor = Color.Transparent;
        }
        private void btnHome_Click(object sender, EventArgs e)      //nhấn vào button "tại quán"
        {
            OpenChildForm(new fTable());
            ChangeColorBtn(btnHome, btnBill, btnMenu, btnRevenua, btnTakeAway, btnSetting);
            lbFormName.Text = "Phục vụ tại quán";
        }

        private void btnBill_Click(object sender, EventArgs e)      //click vào button "Hóa đơn"
        {
            OpenChildForm(new fBill());
            ChangeColorBtn(btnBill, btnHome, btnMenu, btnRevenua, btnTakeAway, btnSetting);
            lbFormName.Text = "Hóa đơn đã xuất";
        }

        private void btnMenu_Click(object sender, EventArgs e)      //click vào button "Thực đơn"
        {
            OpenChildForm(new fMenuFood());
            ChangeColorBtn(btnMenu, btnBill, btnHome,  btnRevenua, btnTakeAway, btnSetting);
            lbFormName.Text = "Thực đơn";
        }

        private void btnTakeaway_Click(object sender, EventArgs e)      //click vào button "Bán mang đi"
        {
            OpenChildForm(new fTakeaway());
            ChangeColorBtn(btnTakeAway, btnBill, btnHome, btnMenu, btnRevenua,  btnSetting);
            lbFormName.Text = "Phục vụ mang về";
        }

        private void btnRevenue_Click(object sender, EventArgs e)       //click vào button "doanh thu"
        {
            OpenChildForm(new fRevenue());
            ChangeColorBtn(btnRevenua, btnBill, btnHome, btnMenu,  btnTakeAway, btnSetting);
            lbFormName.Text = "Doanh thu";
        }

        private void fTableManager_Load(object sender, EventArgs e)     //load data khi chạy app
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

        //hàm mở rộng và thu nhỏ thanh menu (bên trái)
        bool pnLeft_miniSize = true;
        private void ptbMenu_Click(object sender, EventArgs e)
        {
            if(pnLeft_miniSize)
            {
                pnLeft.Size = new Size(199, pnLeft.Size.Height);
                pnLeft_miniSize = false;
            }
            else
            {
                pnLeft.Size = new Size(60, pnLeft.Size.Height);
                pnLeft_miniSize = true;
            }    
        }
    }
}

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
    public partial class fRevenue : Form
    {
        public fRevenue()
        {
            InitializeComponent();
        }

        private void btnCloseFormRevenue_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rbtMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void fRevenue_Load(object sender, EventArgs e)
        {
            cbPosition.Items.AddRange(new string[] { "Thu ngân", "Pha chế", "Phục vụ", "Quản lý" });
        }
    }
}

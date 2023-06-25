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
    public partial class fBill : Form
    {
        public fBill()
        {
            InitializeComponent();
        }

        private void btnCloseFormBill_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = new ComboBox();
            cb = (ComboBox)sender;
            switch (cb.Text)
            {
                case "Xem một ngày":
                    dateTimePicker1.Visible = true;
                    dateTimePicker2.Visible = false;
                    lbDayBegin.Visible = false;
                    lbDayEnd.Visible = false;
                    break;
                case "Xem nhiều ngày":
                    dateTimePicker1.Visible = true;
                    dateTimePicker2.Visible = true;
                    lbDayBegin.Visible = true;
                    lbDayEnd.Visible = true;
                    break;                   
            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

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

        private void cbFilterDishes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

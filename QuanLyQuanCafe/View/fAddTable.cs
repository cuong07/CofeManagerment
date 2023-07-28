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

namespace QuanLyQuanCafe.View
{
    public partial class fAddTable : Form
    {
        private TableController _tableController;
        public fAddTable()
        {
            InitializeComponent();
            _tableController = new TableController(this);
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            string nameTable = txtAddTableName.Text;
            _tableController.addTable(nameTable);
        }
    }
}

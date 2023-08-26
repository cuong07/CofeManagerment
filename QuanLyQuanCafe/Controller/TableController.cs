using QuanLyQuanCafe.Model;
using QuanLyQuanCafe.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe.Controller
{
    public class TableController
    {
        private fTable _fTable;
        private fAddTable _fAddTable;
        private TableModel _tableModel;

        public TableController(Form form)
        {
            if (form is fTable)
            {
                _fTable = (fTable)form;
                _fAddTable = null;
            }
            else if (form is fAddTable)
            {
                _fTable = null;
                _fAddTable = (fAddTable)form;
            }
            else
            {
                throw new ArgumentException("Invalid form type. The form must be either fTable or fBill.");
            }
            _tableModel = new TableModel();
        }
        public void LoadTable()
        {
            List<TableFood> listTable = _tableModel.GetListTable();
            _fTable.LoadTable(listTable);
        }

        public void addTable(string tableName)
        {
            if (_tableModel.AddTable(tableName))
            {
                MessageBox.Show("Thêm bàn thành công!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Thêm bàn thất bại. Vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}

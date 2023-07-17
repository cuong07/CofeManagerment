using QuanLyQuanCafe.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.Controller
{
    public class TableController
    {
        private fTable _fTable;
        private TableModel _tableModel;

        public TableController(fTable fTable)
        {
            _fTable = fTable;
            _tableModel = new TableModel();
        }
        public void LoadTable()
        {
            List<TableFood> listTable = _tableModel.GetListTable();
            _fTable.LoadTable(listTable);
        }


    }
}

using QuanLyQuanCafe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.Controller
{
    public class BillController
    {
        private fTable _fTable;
        private BillModel _billModel;

        public BillController(fTable fTable)
        {
            _fTable = fTable;
            _billModel = new BillModel();
        }

        public int getUnCheckBill(int id)
        {
            return _billModel.GetUnCheckBillIDByTableId(id);
        }

        public int getMaxIdBill()
        {
            return _billModel.GetMaxIDBill();
        }

        public void insertBill(int idTable)
        {
            _billModel.InsertBill(idTable);
        }

        public List<Menu> getListMenuTable(int id)
        {
            return _billModel.GetListMenuTable(id);
        }

        public void checkOut(int id)
        {
            _billModel.CheckOut(id);
        }

    }
}

using QuanLyQuanCafe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe.Controller
{
    public class BillController
    {
        private fTable _fTable;
        private fBill _fBill;
        private BillModel _billModel;

        public BillController(Form form)
        {
            if (form is fTable)
            {
                _fTable = (fTable)form;
                _fBill = null;
            }
            else if (form is fBill)
            {
                _fTable = null;
                _fBill = (fBill)form;
            }
            else
            {
                throw new ArgumentException("Invalid form type. The form must be either fTable or fBill.");
            }
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

        public List<QuanLyQuanCafe.Model.Menu> getListMenuTable(int id)
        {
            return _billModel.GetListMenuTable(id);
        }

        public List<QuanLyQuanCafe.Model.Menu> getListMenuBill(int idBill)
        {
            return _billModel.GetListMenuBill(idBill);
        }

        public void checkOut(int id)
        {
            _billModel.CheckOut(id);
        }

        public void getListBillOfDate(DateTime selectedDateStart, DateTime selectedDateEnd )
        {
            List<BillDetail> listBill =  _billModel.GetAllBillCheckoutOfDate(selectedDateStart.Date, selectedDateEnd.Date);

            if (listBill != null && listBill.Count > 0)
            {
                _fBill.LoadBillOfDateSelect(listBill);
            }
            else
            {
                MessageBox.Show("Không có hóa đơn nào");
            }

            
        }

    }
}

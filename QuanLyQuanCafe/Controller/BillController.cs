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
        private List<BillDetail> listBill;
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
        public BillController()
        {
            _billModel = new BillModel();
        }
        //hàm khởi tạo (Công)
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

        public List<BillDetail> getListBillOfDate(DateTime selectedDateStart, DateTime selectedDateEnd )
        {
            return _billModel.GetAllBillCheckoutOfDate(selectedDateStart.Date, selectedDateEnd.Date);
        }
        public void DeleteTakeAwayBill(int idB)
        {
            _billModel.DeleteTakeAwayBill(idB);
        }
        //xóa 1 đơn mang về (Công)

    }
}


using QuanLyQuanCafe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.Controller
{
    public class BillInfoController 
    { 

        private BillInfoModel _billInfoModel;

        public BillInfoController()
        {
            _billInfoModel = new BillInfoModel();
        }

        public void insertBillInfo(int idBill, int idFood, int count)
        {
            _billInfoModel.InsertOrUpdateBillInfo(idBill, idFood, count);
        }
    }
}

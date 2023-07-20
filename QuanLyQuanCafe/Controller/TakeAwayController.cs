﻿using QuanLyQuanCafe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.Controller
{
    internal class TakeAwayController
    {
        private TakeAwayModel takeAwayModel = new TakeAwayModel();
        
        public List<Bill> GetListTakeAwaysBills()
        {
            return takeAwayModel.GetListBillofTakeAway();
        }
        //lấy danh sach bill của takeAway
        public List<BillDetailsCTL> GetListBillDetails(int idB)
        {
            return takeAwayModel.GetBillDetail(idB);
        }
        //Lấy thông tin chi tiết của 1 đơn hàng dựa vào mã bill
    }
}
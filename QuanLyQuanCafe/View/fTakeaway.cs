using QuanLyQuanCafe.Controller;
using QuanLyQuanCafe.Model;
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
    public partial class fTakeaway : Form
    {
        private TakeAwayController takeAwayController = new TakeAwayController();
        private BillController billController = new BillController();
        public fTakeaway()
        {
            InitializeComponent();
        }
        #region load
        
        public void LoadLsvTABill_Waitting()
        {
            lsvTABill.Items.Clear();
            List<Bill> listTABill = takeAwayController.GetListTakeAwaysBills_Waitting();
            foreach (Bill bill in listTABill)
            {
                ListViewItem item = new ListViewItem(bill.id.ToString());
                item.SubItems.Add(bill.idTableFood.ToString());
                item.SubItems.Add(bill.DateCheckIn.ToString());
                item.SubItems.Add(bill.DateCheckOut.ToString());
                item.SubItems.Add(bill.status.ToString());
                item.SubItems.Add(bill.employeeId.ToString());
                lsvTABill.Items.Add(item);      
            }
        }       //Load danh sach hóa đơn mang về đang chờ

        public void LoadLsvTABill_Finished()
        {
            lsvTADone.Items.Clear();
            List<Bill> listTABill = takeAwayController.GetListTakeAwaysBills_Finished();
            foreach (Bill bill in listTABill)
            {
                ListViewItem item = new ListViewItem(bill.id.ToString());
                item.SubItems.Add(bill.idTableFood.ToString());
                item.SubItems.Add(bill.DateCheckIn.ToString());
                item.SubItems.Add(bill.DateCheckOut.ToString());
                item.SubItems.Add(bill.status.ToString());
                item.SubItems.Add(bill.employeeId.ToString());
                lsvTADone.Items.Add(item);
            }
        }       //Load danh sach hóa đơn mang về đã hoàn thành.

        public void LoadPermissionByIdJob()
        {
            int jobId = (int)fHome.currentEmployees.jobId;
            if (jobId == 1)  //nhân viên
            {
                btnDeleteOrder.Enabled = false;
            }   
        }
        private void fTakeaway_Load(object sender, EventArgs e)
        {
            try
            {
                LoadLsvTABill_Waitting();
                LoadPermissionByIdJob();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void btnDone_Click(object sender, EventArgs e)
        {
            try
            {
                Button bt = (Button)sender;
                int idBillSelected = Convert.ToInt32(lsvTABill.SelectedItems[0].SubItems[0].Text);
                if (lsvTABill.SelectedItems.Count == 1)
                {
                    switch(bt.Text)
                    {
                        case "Hoàn thành":
                            takeAwayController.CheckOutTABill(idBillSelected);
                            MessageBox.Show("Đã hoàn thành đơn hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        case "Hủy đơn":
                            billController.DeleteTakeAwayBill(idBillSelected);
                            MessageBox.Show("Đã hủy đơn hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                    }    
                    lsvBillDetail.Items.Clear();
                    lsvTABill.Items.Clear();
                    LoadLsvTABill_Waitting();
                }    
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        
        //
        #region Selected changed
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (tabControl1.SelectedIndex == 0)
                {
                    LoadLsvTABill_Waitting();
                    pnRight.Visible = true;
                }
                else
                {
                    LoadLsvTABill_Finished();
                    pnRight.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }   //Chuyển tabControl
        private void lsvTABill_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lsvTABill.SelectedItems.Count > 0)
                {
                    int idBillSelected = Convert.ToInt32(lsvTABill.SelectedItems[0].SubItems[0].Text);
                    List<BillDetailsCTL> listBillDetails = takeAwayController.GetListBillDetails(idBillSelected);

                    lsvBillDetail.Items.Clear();
                    foreach (BillDetailsCTL details in listBillDetails)
                    {
                        ListViewItem item = new ListViewItem(details.BillId.ToString());
                        item.SubItems.Add(details.FoodID.ToString());
                        item.SubItems.Add(details.FoodName.ToString());
                        item.SubItems.Add(details.Quantity.ToString());
                        lsvBillDetail.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }   //click vào lsvTABill
        #endregion
        private void btnCloseFormTakeaway_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

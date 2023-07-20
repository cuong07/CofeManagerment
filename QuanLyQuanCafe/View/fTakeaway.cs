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
        public fTakeaway()
        {
            InitializeComponent();
        }

        private void btnCloseFormTakeaway_Click(object sender, EventArgs e)
        {
            this.Close();   
        }


        private void fTakeaway_Load(object sender, EventArgs e)
        {
            List<Bill> listTABill = takeAwayController.GetListTakeAwaysBills();
            cbIdTABill.DataSource = listTABill;     //load cb tìm kiếm theo id
            cbIdTABill.DisplayMember = "id";
            foreach (Bill bill in listTABill)
            {
                ListViewItem item = new ListViewItem(bill.id.ToString());
                item.SubItems.Add(bill.idTableFood.ToString());
                item.SubItems.Add(bill.DateCheckIn.ToString());
                item.SubItems.Add(bill.DateCheckOut.ToString());
                item.SubItems.Add(bill.status.ToString());
                item.SubItems.Add(bill.employeeId.ToString());
                lsvTABill.Items.Add(item);      //Load danh sach hóa đơn mang về
            } 
        }

        private void lsvTABill_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lsvTABill.SelectedItems.Count == 1)
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
    }
}

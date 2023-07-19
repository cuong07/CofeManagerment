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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyQuanCafe
{
    public partial class fBill : Form
    {
        private BillController _billController;
        public fBill()
        {
            InitializeComponent();
            _billController = new BillController(this);
        }

        private void btnCloseFormBill_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadBillOfDateSelect(List<BillDetail> listBill)
        {
            lsvBill.Items.Clear();
            float total = 0;
            foreach (BillDetail billDetail in listBill)
            {
                total += (float)billDetail.TotalPrice;
                ListViewItem lsvItem = new ListViewItem(billDetail.Id.ToString());
                lsvItem.SubItems.Add(billDetail.TableName.ToString());
                lsvItem.SubItems.Add(String.Format("{0:MM/dd/yyyy}", billDetail.DateCheckIn));
                lsvItem.SubItems.Add(billDetail.TotalPrice?.ToString("c"));
                lsvBill.Items.Add(lsvItem);
            }
            txtTotal.Text = total.ToString("c");
        }

        private void btnShow_Click_2(object sender, EventArgs e)
        {
            DateTime selectedDateStart = dtpStart.Value.Date;
            DateTime selectedDateEnd = dtpEnd.Value.Date;
            _billController.getListBillOfDate(selectedDateStart, selectedDateEnd);
        }

        private void lsvBill_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lsvBill.SelectedItems.Count > 0)
            {
                lsvBillDetail.Items.Clear();
                ListViewItem selectedItem = lsvBill.SelectedItems[0];
                string id = selectedItem.SubItems[0].Text;
                List<QuanLyQuanCafe.Model.Menu> listBillInfo = _billController.getListMenuBill(int.Parse(id));
                foreach (QuanLyQuanCafe.Model.Menu item in listBillInfo)
                {
                    ListViewItem lsvItem = new ListViewItem(item.Name.ToString());
                    lsvItem.SubItems.Add(item.Count.ToString());
                    lsvItem.SubItems.Add(item.Price.ToString("c"));
                    lsvItem.SubItems.Add(item.TotalPrice.ToString("c"));
                    lsvBillDetail.Items.Add(lsvItem);
                }
            }
        }
    }
}

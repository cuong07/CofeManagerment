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
        public fTakeaway()
        {
            InitializeComponent();
        }
        int numberOfOrder;      //so luong don hang.
        int numberOfDishes;    //so lượng loại món ăn trong id.
        private void btnCloseFormTakeaway_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void fTakeaway_Load(object sender, EventArgs e)
        {
            numberOfOrder = 4;
            string order = string.Empty;
            for(int i = 1; i <= numberOfOrder; i++)
            {
                order = "Dữ liệu từ Database "+i;
                lsbIDOrder.Items.Add(order);
            }
        }

        private void lsbIDOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbIDOrder.SelectedItems.Count > 0)
            {
                btnDone.Visible = true;     //hiện nút hoàn thành lên khi đã chọn 1 hóa đơn.
                btnDeleteOrder.Visible = true;
                
                lbIdAddress.Text = lsbIDOrder.SelectedItem.ToString();
                lsbDetail.Items.Clear();
                numberOfDishes = 5;
                //dữ liệu load về từ database vào listbox "ID đang chờ"
                string orderDetail = string.Empty;
                string foodName = string.Empty;
                int quantity = 0;
                string note = "ghi chú từ database";

                rtbNote.Text = "Ghi chú: " + note;
                for(int i = 1;i <= numberOfDishes;i++)
                {
                    foodName = "Load từ data " + i;
                    quantity = i;
                    orderDetail = i + ". " + foodName + "\t" + quantity;
                    lsbDetail.Items.Add(orderDetail);
                }
            }    
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            switch (bt.Text)
            {
                case "Hoàn thành":
                    lsbIDOrder.Items.Remove(lsbIDOrder.SelectedItem);   //xóa item đã chọn
                    numberOfOrder--;                                                   //load lại list
                    lsbIDOrder.Items.Clear();
                    string order = string.Empty;
                    for (int i = 1; i <= numberOfOrder; i++)
                    {
                        order = "Dữ liệu từ Database "+i;
                        lsbIDOrder.Items.Add(order);
                    }
                    break;
                case "Hủy đơn":
                    lsbIDOrder.Items.Remove(lsbIDOrder.SelectedItem);   //xóa item đã chọn
                    numberOfOrder--;                                                   //load lại list
                    lsbIDOrder.Items.Clear();
                    for (int i = 1; i <= numberOfOrder; i++)
                    {
                        order = i + ". Dữ liệu từ Database";
                        lsbIDOrder.Items.Add(order);
                    }
                    break;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

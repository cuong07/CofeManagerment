using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace QuanLyQuanCafe
{
    public partial class fTable : Form
    {
        public fTable()
        {
            InitializeComponent();
            LoadTable();
            LoadCategory();
        }

        #region Các biến dùng chung
        int tableCount = 0;
        int tableActive = 0;
        int tableEmpty = 0;
        #endregion


        #region Các phương thức DET PUT POST DELETE data
        void LoadTable()
        {
            flpTable.Controls.Clear();
            List<Table> listTable = TableDAO.Instance.GetTableList();
            tableCount = listTable.Count;
            foreach (Table table in listTable)
            {
                Button button = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                button.Text = table.Name + Environment.NewLine + (table.Status ? "Có khách" : "Trống");
                button.Font = new Font("Arial", 10, FontStyle.Regular);
                button.Tag = table;
                button.Click += table_Click;
                flpTable.Controls.Add(button);
                if (table.Status)
                {
                    button.BackColor = Color.Green;
                    button.ForeColor = Color.White;
                }
                else
                {
                    button.BackColor = Color.White;
                }
                if(table.Status)
                {
                    tableActive++;
                }
                else
                {
                    tableEmpty++;
                }
            }
        }

        void LoadCategory()
        {
            List<Category> listCategories = CategoryDAO.Instance.GetListCategory();
            cbCategory.DataSource = listCategories;
            cbCategory.DisplayMember= "Name";
        }
        void LoadFoodByCateGory(int id)
        {
            List<MenuFood> listMenuFood = MenuFoodDAO.Instance.getListFoodByCategory(id);
            cbFood.DataSource = listMenuFood;
            cbFood.DisplayMember= "Name";
        }

        void ShowBill(int id)
        {
            lsvBill.Items.Clear();
            float totalPrice = 0;
            List<QuanLyQuanCafe.DTO.Menu> listBillInfo = MenuDAO.Instance.getListMenuTable(id);
            foreach  (QuanLyQuanCafe.DTO.Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString("c"));
                lsvItem.SubItems.Add(item.TotalPrice.ToString("c"));
                lsvBill.Items.Add(lsvItem);
                totalPrice += item.TotalPrice;
            }
            LoadTable();
            txtTotalPrice.Text = totalPrice.ToString("c");

        }


        #endregion


        #region Các Sự kiện 
        private void btnCloseFormTable_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = (ComboBox)sender;
            if(cb.SelectedItem == null)
            {
                return;
            }
            Category selected = cb.SelectedItem as Category;
            id = selected.Id;
            LoadFoodByCateGory(id);
        }

        void table_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            lsvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            if (table != null)
            {
                int idBill = BillDAO.Instance.getUnCheckBillIDByTableId(table.ID);
                int idFood = (cbFood.SelectedItem as MenuFood).ID;
                int count = (int)nmFoodCount.Value;

                int newIdBill = BillDAO.Instance.GetMaxIDBill();

                if (idBill == -1)
                {
                    BillDAO.Instance.InsertBill(table.ID);
                    BillInfoDAO.Instance.InsertBillInfo(newIdBill, idFood, count);
                }
                else
                {
                    BillInfoDAO.Instance.InsertBillInfo(idBill, idFood, count);
                }
                ShowBill(table.ID);
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn bàn nào!");
            }
        }

        private void fTable_Load(object sender, EventArgs e)
        {
            txtTableCount.Text = tableCount.ToString();
            txtTableActive.Text = tableActive.ToString();
            txtTableEmpty.Text = tableEmpty.ToString();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            if(table != null)
            {
                int idBill = BillDAO.Instance.getUnCheckBillIDByTableId((int)table.ID);

                float totalPrice = float.Parse(txtTotalPrice.Text.Split(',')[0]);
                float finalTotalPrice = totalPrice;
                if (idBill != -1)
                {
                    if (MessageBox.Show($"Bạn có chắc thanh toán hóa đơn cho bàn {table.Name}. \n Tổng tiền cần thanh toán là {finalTotalPrice}  ", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    {
                        BillDAO.Instance.CheckOut(idBill);
                        ShowBill(table.ID);
                    }
                }
            }
            else
            {
                MessageBox.Show("Bàn không có hóa đơn nào cần thanh toán!");
            }
        }


        #endregion


    }
}

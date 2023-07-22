
using QuanLyQuanCafe.Controller;
using QuanLyQuanCafe.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
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
        private TableController _tableController;
        private CategoryController _categoryController;
        private FoodController _foodController;
        private BillController _billController;
        private readonly BillInfoController _billInfoController;

        #region Các biến dùng chung
        int tableCount = 0;
        int tableActive = 0;
        int tableEmpty = 0;
        #endregion

        public fTable()
        {
            InitializeComponent();
            _tableController = new TableController(this);
            _categoryController= new CategoryController(this);
            _foodController = new FoodController(this);
            _billController = new BillController(this);
            _billInfoController = new BillInfoController();

            _tableController.LoadTable();
            _categoryController.LoadCategory();
        }
        public void LoadTable(List<TableFood> listTable)
        {
            flpTable.Controls.Clear();
            tableCount = listTable.Count;
            foreach (TableFood table in listTable)
            {
                Button button = new Button() { Width = 100, Height = 100 };
                button.Text = table.name + Environment.NewLine + (table.status.HasValue ? (table.status.Value ? "Có khách" : "Trống") : "Không rõ");
                button.Font = new Font("Arial", 10, FontStyle.Regular);
                button.Tag = table;
                button.Margin = new Padding(10);
                button.Click += table_Click;
                flpTable.Controls.Add(button);
                if (table.status.HasValue)
                {
                    bool status = table.status.Value;
                    if (status)
                    {
                        button.BackColor = Color.Green;
                        button.ForeColor = Color.White;
                        tableActive++;
                    }
                    else
                    {
                        button.BackColor = Color.White;
                        tableEmpty++;
                    }
                }
            }
        }

        public void LoadListCategory(List<FoodCategory> listCategory)
        {
            cbCategory.DataSource = listCategory;
            cbCategory.DisplayMember = "Name";
        }

        public void LoadFoodByCategory(List<Food> listFood)
        {
            cbFood.DataSource = listFood;
            cbFood.DisplayMember = "Name";
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = (ComboBox)sender;
            if (cb.SelectedItem == null)
            {
                return;
            }
            FoodCategory selected = cb.SelectedItem as FoodCategory;
            id = selected.id;
            _foodController.GetListFoodByCategory(id);
        }

        void table_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as TableFood).id;
            lsvBill.Tag = (sender as Button).Tag;
            txtNameTable.Text = ((sender as Button).Tag as TableFood).name;
            if(tableID != 1)
            {
                ShowBill(tableID);
            }
        }

        void ShowBill(int id)
        {
            lsvBill.Items.Clear();
            float totalPrice = 0;
            List<QuanLyQuanCafe.Model.Menu> listBillInfo = _billController.getListMenuTable(id);
            foreach (QuanLyQuanCafe.Model.Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.Name.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString("c"));
                lsvItem.SubItems.Add(item.TotalPrice.ToString("c"));
                lsvBill.Items.Add(lsvItem);
                totalPrice += item.TotalPrice;
            }
            _tableController.LoadTable();
            txtTotalPrice.Text = totalPrice.ToString("c");
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            TableFood table = lsvBill.Tag as TableFood;
            if (table != null)
            {
                int idBill = _billController.getUnCheckBill(table.id);
                int idFood = (cbFood.SelectedItem as Food).id;
                int count = (int)nmFoodCount.Value;
                MessageBox.Show(idBill.ToString());
                if(table.id == 1)
                {
                    _billController.insertBill(table.id);
                    _billInfoController.insertBillInfo(_billController.getMaxIdBill(), idFood, count);
                }
                else
                {
                    if (idBill == -1 && table.id != 1)
                    {
                        _billController.insertBill(table.id);
                        _billInfoController.insertBillInfo(_billController.getMaxIdBill(), idFood, count);
                    }
                    else
                    {
                        _billInfoController.insertBillInfo(idBill, idFood, count);
                    }
                    ShowBill(table.id);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn bàn nào!");
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            TableFood table = lsvBill.Tag as TableFood;
            if(table != null)
            {
                int idBill = _billController.getUnCheckBill((int)table.id);
                float totalPrice = float.Parse(txtTotalPrice.Text.Split(',')[0]);
                float finalTotalPrice = totalPrice;
                if (idBill != -1)
                {
                    if (MessageBox.Show($"Bạn có chắc thanh toán hóa đơn cho bàn {table.name}. \n Tổng tiền cần thanh toán là {finalTotalPrice}  ", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    {
                        _billController.checkOut(idBill);
                        ShowBill(table.id);
                    }
                }
            }
            else
            {
                MessageBox.Show("Bàn không có hóa đơn nào cần thanh toán!");
            }
        }

        private void fTable_Load(object sender, EventArgs e)
        {
            txtTableActive.Text = (tableCount - tableEmpty).ToString();
            txtTableEmpty.Text = tableEmpty.ToString();
            txtTableCount.Text = tableCount.ToString();
        }
    }
}

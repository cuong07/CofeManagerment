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

        #region Các phương thức DET PUT POST DELETE data
        void LoadTable()
        {
            flpTable.Controls.Clear();
            List<Table> listTable = TableDAO.Instance.GetTableList();

            foreach (Table table in listTable)
            {
                Button button = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                button.Text = table.Name + Environment.NewLine + (table.Status ? "Có Khách" : "Trống");
                button.Font = new Font("Arial", 10, FontStyle.Regular);
                button.Tag = table;

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

            }
        }

        void LoadCategory()
        {
            List<Category> listCateGory = CategoryDAO.instance.GetListCategory();
            cbCategory.DataSource = listCateGory;
            cbCategory.DisplayMember= "Name";
        }
        void LoadFoodByCateGory(int id)
        {
            List<Food> listFood = MenuFoodDAO.instance.GetMenuFoodByCategoryID(id);
            cbFood.DataSource = listFood;
            cbFood.DisplayMember = "Name";
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

        #endregion

    }
}

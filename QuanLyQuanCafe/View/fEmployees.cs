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
    public partial class fEmployees : Form
    {
        private JobController _jobController;
        private EmployeesController _employeesController;
        private ListViewItem selectedListViewItem;
        public fEmployees()
        {
            InitializeComponent();
            _jobController = new JobController(this);
            _employeesController = new EmployeesController(this);
            _jobController.LoadListJob();
            _employeesController.loadListEmployees();
        }

        private void btnCloseFormRevenue_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadJob(List<Job> listJob)
        {
            cbJobPosition.DataSource = listJob;
            cbJobPosition.DisplayMember = "Name";
            cbJobPosition.ValueMember = "Id";
        }

        public void LoadEmployees(List<EmployeeDetail> listEmployees)
        {
            lsvEmployees.Items.Clear();
            foreach (EmployeeDetail item in listEmployees)
            {
                ListViewItem lsvItem = new ListViewItem(item.Id.ToString());
                lsvItem.SubItems.Add($"{item.FirstName}");
                lsvItem.SubItems.Add($"{item.LastName}");
                lsvItem.SubItems.Add(item.Email.ToString());
                lsvItem.SubItems.Add(item.PhoneNumber);
                lsvItem.SubItems.Add(item.Job);
                lsvItem.SubItems.Add(item.DateStartWork.ToString());
                lsvItem.SubItems.Add(item.UserName);
                lsvItem.SubItems.Add(item.Password);

                lsvEmployees.Items.Add(lsvItem);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Employee newEmployees = new Employee
            {
                firstName = txtFirstName.Text,
                lastName = txtLastName.Text,
                email = txtEmail.Text,
                phoneNumber = txtPhoneNumber.Text,
                dateStartWork = dtpDataStartWork.Value.Date,
                jobId = (int)cbJobPosition.SelectedValue,
                userName = txtUserName.Text,
                password = txtPassword.Text,
            };
            _employeesController.addEmployees(newEmployees);
            _employeesController.loadListEmployees();
        }

        private void lsvEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvEmployees.SelectedItems.Count > 0)
            {
                selectedListViewItem = lsvEmployees.SelectedItems[0];
                txtId.Text = selectedListViewItem.SubItems[0].Text;
                txtFirstName.Text = selectedListViewItem.SubItems[1].Text; 
                txtLastName.Text = selectedListViewItem.SubItems[2].Text;
                txtEmail.Text = selectedListViewItem.SubItems[3].Text;
                txtPhoneNumber.Text = selectedListViewItem.SubItems[4].Text;
                cbJobPosition.Text = selectedListViewItem.SubItems[5].Text;
                dtpDataStartWork.Text = selectedListViewItem.SubItems[6].Text;
                txtUserName.Text = selectedListViewItem.SubItems[7].Text;
                txtPassword.Text = selectedListViewItem.SubItems[8].Text;
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            int jobiIdNew = _jobController.getJobByName(cbJobPosition.Text).id;
            MessageBox.Show(jobiIdNew.ToString());
            Employee newEmployees = new Employee
            {
                id = int.Parse(txtId.Text),
                firstName = txtFirstName.Text,
                lastName = txtLastName.Text,
                email = txtEmail.Text,
                phoneNumber = txtPhoneNumber.Text,
                dateStartWork = dtpDataStartWork.Value,
                jobId = jobiIdNew,
                userName = txtUserName.Text,
                password = txtPassword.Text,
            };
            _employeesController.updateEmployees(newEmployees);
            _employeesController.loadListEmployees();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                if (lsvEmployees.SelectedItems.Count > 0)
                {
                    int idEmployees = int.Parse(lsvEmployees.SelectedItems[0].SubItems[0].Text);
                    _employeesController.removeEmployees(idEmployees);
                    _employeesController.loadListEmployees();
                }
            }
        }

    }
}

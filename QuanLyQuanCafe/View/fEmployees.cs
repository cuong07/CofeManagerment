using QuanLyQuanCafe.Controller;
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
    public partial class fEmployees : Form
    {
        private JobController _jobController;
        private EmployeesController _employeesController;
        public fEmployees()
        {
            InitializeComponent();
            _jobController = new JobController(this);
            _employeesController = new EmployeesController();
            _jobController.LoadListJob();
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

        private void button1_Click(object sender, EventArgs e)
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
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

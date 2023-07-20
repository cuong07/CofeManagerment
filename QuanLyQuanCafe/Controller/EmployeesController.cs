using QuanLyQuanCafe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe.Controller
{
    public class EmployeesController
    {
        private EmployeesModel _employeesModel;
        public EmployeesController()
        {
            _employeesModel = new EmployeesModel();
        }

        public void addEmployees(Employee newEmployee)
        {
            Employee exitsEmployees = _employeesModel.GetExistEmployees(newEmployee.email);
            if (exitsEmployees != null)
            {
                MessageBox.Show($"Email {exitsEmployees.email} đã tồn tại vui long chọn một email khác");
            }
            else
            {
                _employeesModel.AddEmployees(newEmployee);
            }

        }
    }
}

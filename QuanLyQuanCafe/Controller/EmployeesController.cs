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
        private fEmployees _fEmployees;
        public EmployeesController(fEmployees fEmployees)
        {
            _employeesModel = new EmployeesModel();
            _fEmployees = fEmployees;
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

        public void loadListEmployees()
        {
            List<EmployeeDetail> listEmployees = _employeesModel.GetListEmployees();
            _fEmployees.LoadEmployees(listEmployees);
        }

        public void updateEmployees(Employee newEmployees)
        {
            _employeesModel.UpdateEmployees(newEmployees);
        }

        public void removeEmployees(int idEmployees)
        {
            _employeesModel.RemoveEmployee(idEmployees);
        }

    }
}

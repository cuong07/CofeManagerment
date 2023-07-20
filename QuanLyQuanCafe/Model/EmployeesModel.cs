using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe.Model
{
    public class EmployeesModel
    {
        public EmployeesModel() { }
        public void AddEmployees(Employee newEmployee)
        {
            using (DataClasses2DataContext db = new DataClasses2DataContext())
            {
                try
                {
                    db.Employees.InsertOnSubmit(newEmployee);
                    db.SubmitChanges();
                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi thêm nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public Employee GetExistEmployees(string email)
        {
            using (DataClasses2DataContext db = new DataClasses2DataContext())
            {
                var existEmployees = (from e in db.Employees
                                     where e.email == email
                                     select e).FirstOrDefault();
                return existEmployees;
            }
        }
    }
}

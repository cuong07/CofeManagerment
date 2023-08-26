using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe.Model
{
    public class EmployeeDetail
    {
        private int id;
        private string firstName;
        private string lastName;
        private string email;
        private string phoneNumber;
        private string job;
        private int idJob;
        private DateTime? dateStartWork;
        private string userName;
        private string password;

        public int Id { get => id; set => id = value; }
        public string Email { get => email; set => email = value; }
        public string Job { get => job; set => job = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public DateTime? DateStartWork { get => dateStartWork; set => dateStartWork = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public int IdJob { get => idJob; set => idJob = value; }
    }
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

        public void UpdateEmployees(Employee newEmployee)
        {
            using (DataClasses2DataContext db = new DataClasses2DataContext())
            {
                try
                {
                    Employee existEmployee = db.Employees.SingleOrDefault(e => e.id == newEmployee.id);
                    if (existEmployee != null)
                    {
                        existEmployee.firstName = newEmployee.firstName;
                        existEmployee.lastName = newEmployee.lastName;
                        existEmployee.email = newEmployee.email;
                        existEmployee.phoneNumber = newEmployee.phoneNumber;
                        existEmployee.jobId = newEmployee.jobId;
                        existEmployee.dateStartWork = newEmployee.dateStartWork;
                        existEmployee.userName = newEmployee.userName;
                        existEmployee.password = newEmployee.password;
                        db.SubmitChanges();
                        MessageBox.Show("Update nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra khi update nhân viên: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        public void RemoveEmployee(int id)
        {
            using (DataClasses2DataContext db = new DataClasses2DataContext())
            {
                try
                {
                    Employee employee = db.Employees.FirstOrDefault(e => e.id == id);
                    if (employee != null)
                    {
                        db.Employees.DeleteOnSubmit(employee);
                        db.SubmitChanges();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi xóa nhân viên" + ex.Message);
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

        public List<EmployeeDetail> GetListEmployees()
        {
            using (DataClasses2DataContext db = new DataClasses2DataContext())
            {
                var listEmployees = from e in db.Employees
                                    join j in db.Jobs on e.jobId equals j.id
                                    select new EmployeeDetail
                                    { 
                                        Id = e.id,
                                        FirstName= e.firstName,
                                        LastName= e.lastName,
                                        Email= e.email,
                                        PhoneNumber=e.phoneNumber,
                                        Job = j.name,
                                        IdJob = j.id,
                                        DateStartWork = e.dateStartWork,
                                        UserName=e.userName,
                                        Password = e.password,
                                    };
                return listEmployees.ToList();
            }
        }

    }
}

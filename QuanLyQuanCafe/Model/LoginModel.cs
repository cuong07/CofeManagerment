using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.Model
{
    public class LoginModel
    {
        public Employee LoginSuccess(string userName, string password)
        {
            using (DataClasses2DataContext db = new DataClasses2DataContext())
            {
                return db.Employees.Where(e => e.userName == userName && e.password == password).FirstOrDefault();
            }
        }
    }
}


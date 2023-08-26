using QuanLyQuanCafe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.Controller
{
    public class LoginController
    {
        private LoginModel _LoginModel;
        public Employee currentEmployees;

        public LoginController (LoginModel loginModel)
        {
            _LoginModel = new LoginModel();
        }
        public bool LoginSuccess(string username, string password)
        {
            Employee user = _LoginModel.LoginSuccess(username, password);
            currentEmployees = user;
            if (user != null)
            {
                return true;
            }

            return false;
        }

    }
}


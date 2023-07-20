using QuanLyQuanCafe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.Controller
{
    public class JobController
    {
        private JobModel _jobModel;
        private fEmployees _fEmployees;
        public JobController(fEmployees fRevenue)
        {
            _jobModel = new JobModel();
            _fEmployees = fRevenue;
        }

        public void LoadListJob()
        {
            List<Job> list = _jobModel.GetListJob();
            _fEmployees.LoadJob(list);
        }

    }
}

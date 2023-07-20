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
        private fRevenue _fRevenue;
        public JobController(fRevenue fRevenue)
        {
            _jobModel = new JobModel();
            _fRevenue = fRevenue;
        }

        public void LoadListJob()
        {
            List<Job> list = _jobModel.GetListJob();
            _fRevenue.LoadJob(list);
        }

    }
}

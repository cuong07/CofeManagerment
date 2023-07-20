using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.Model
{
    public class JobModel
    {
        public List<Job> GetListJob()
        {
            using (DataClasses2DataContext db = new DataClasses2DataContext())
            {
                var listJob = db.Jobs.ToList();
                return listJob;
            }
        }
    }
}

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

        public Job GetJobById(int id)
        {
            using ( DataClasses2DataContext db = new DataClasses2DataContext())
            {
                var job = from j in db.Jobs
                          where j.id == id 
                          select j;
                return job.FirstOrDefault();
            }
        }

        public Job GetJobByName(string name)
        {
            using (DataClasses2DataContext db = new DataClasses2DataContext())
            {
                var job = from j in db.Jobs
                          where j.name == name
                          select j;
                return job.FirstOrDefault();
            }
        }

    }
}

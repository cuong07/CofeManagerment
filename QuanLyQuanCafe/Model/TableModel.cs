using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.Model
{
    public class TableModel
    {
        private List<TableFood> listTable;
        public List<TableFood> GetListTable()
        {
            listTable = GetListTableFromDatabase();
            return listTable;
        }

        private List<TableFood> GetListTableFromDatabase()
        {
            List<TableFood> listTable;
            using (DataClasses2DataContext db = new DataClasses2DataContext())
            {
                listTable = db.TableFoods.ToList();
            }
            return listTable;
        }
    }

}

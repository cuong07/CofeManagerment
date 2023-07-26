using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public List<TableFood> GetListTableFromDatabase()
        {
            List<TableFood> listTable;
            using (DataClasses2DataContext db = new DataClasses2DataContext())
            {
                listTable = db.TableFoods.ToList();
            }
            return listTable;
        }

        public bool AddTable(string nameTable)
        {
            try
            {
                using (DataClasses2DataContext db = new DataClasses2DataContext())
                {
                    TableFood table = new TableFood
                    {
                        name = nameTable,
                        status = false
                    };
                    db.TableFoods.InsertOnSubmit(table);
                    db.SubmitChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi thêm bàn" + ex);
                return false;
            }

        }



    }

}

using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyQuanCafe.Model
{
    public class TableModel
    {
        public List<TableFood> GetListTable()
        {
            try
            {
                using (DataClasses2DataContext db = new DataClasses2DataContext())
                {
                    List<TableFood> listTable = db.TableFoods.ToList();
                    return listTable;
                }
            }
            catch (Exception ex )
            {
                MessageBox.Show("Có lỗi khi lấy danh sách bàn" + ex);
                throw;
            }
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

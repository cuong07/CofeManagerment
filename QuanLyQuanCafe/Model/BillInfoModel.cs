using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.Model
{
    public class BillInfoModel
    {
        public void InsertOrUpdateBillInfo(int idBill, int idFood, int count)
        {
            using (DataClasses2DataContext db = new DataClasses2DataContext())
            {
                var existingBillInfo = db.BillInfos.FirstOrDefault(bi => bi.idBill == idBill && bi.idFood == idFood);

                if (existingBillInfo != null)
                {
                    existingBillInfo.count += count;
                    if (existingBillInfo.count <= 0)
                    {
                        db.BillInfos.DeleteOnSubmit(existingBillInfo);
                    }
                }
                else
                {
                    BillInfo newBillInfo = new BillInfo()
                    {
                        idBill = idBill,
                        idFood = idFood,
                        count = count
                    };
                    db.BillInfos.InsertOnSubmit(newBillInfo);
                }

                db.SubmitChanges();
            }
        }



    }
}

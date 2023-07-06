﻿using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    internal class MenuDAO
    {
        private static MenuDAO instance;

        internal static MenuDAO Instance
        {
            get { if (instance == null) instance = new MenuDAO(); return instance; }
            private set => instance = value;
        }

        public MenuDAO() { }
        public List<Menu> getListMenuTable(int id)
        {
            string query =$"" +
                $"SELECT f.name, bi.count, f.price, f.price*bi.count AS totalPrice " +
                $"FROM dbo.BillInfo AS bi, dbo.Bill AS b, dbo.Food AS f \r\n" +
                $"WHERE bi.idBill = b.id " +
                $"AND bi.idFood = f.id AND b.status = 0 " +
                $"AND b.idTableFood = {id}";
            List<Menu> listMenu = new List<Menu>();
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }
            return listMenu;

        }
    }
}

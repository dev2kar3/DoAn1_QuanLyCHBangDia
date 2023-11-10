using QuanLyCHChoThueBangDia.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCHChoThueBangDia.DAO
{
    internal class billMenuDAO
    {
        private static billMenuDAO instance;

        internal static billMenuDAO Instance 
        { 
            get
            {
                if (instance == null)
                    instance = new billMenuDAO();
                return instance;
            }
            set => instance = value; 
        }

        private billMenuDAO() { }

        public List<billMenu> getListBillMenuByCustomer(int id)
        {
            List<billMenu> listBillMenu = new List<billMenu>();

            string query = "EXEC dbo.USP_getBillMenuList @idcustomer";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] {id});

            //Add từng cái row trong biến data vào listBillMenu
            foreach (DataRow item in data.Rows)
            {
                billMenu menu = new billMenu(item);

                listBillMenu.Add(menu);
            }

            return listBillMenu;
        }
    }
}

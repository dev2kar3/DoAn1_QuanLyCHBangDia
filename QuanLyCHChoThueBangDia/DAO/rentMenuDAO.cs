using QuanLyCHChoThueBangDia.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCHChoThueBangDia.DAO
{
    internal class rentMenuDAO
    {

        private static rentMenuDAO instance;

        internal static rentMenuDAO Instance 
        { 
            get
            {
                if (instance == null)
                    instance = new rentMenuDAO();
                return instance;    
            }
            set => instance = value;
        }

        private rentMenuDAO() { }

        public List<RentMenu> getListRentMenuByCustomer(int id)
        {
            List<RentMenu> listRentMenu = new List<RentMenu>();

            string query = "EXEC dbo.USP_getRentMenuList @idcustomer";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] {id});

            foreach (DataRow row in data.Rows) 
            {
                RentMenu menu = new RentMenu(row);

                listRentMenu.Add(menu);
            }

            return listRentMenu;
        }
    }
}

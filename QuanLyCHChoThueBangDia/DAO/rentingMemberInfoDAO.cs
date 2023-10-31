using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCHChoThueBangDia.DAO
{
    internal class rentingMemberInfoDAO
    {
        private static rentingMemberInfoDAO instance;

        internal static rentingMemberInfoDAO Instance 
        { 
            get
            {
                if (instance == null)
                    instance = new rentingMemberInfoDAO();
                return instance;
            }
            set => instance = value; 
        }

        private rentingMemberInfoDAO() { }

        public DataTable loadRentingMemberInfoList()
        {
            string query = "USP_getRentingMemberInfo";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
    }
}

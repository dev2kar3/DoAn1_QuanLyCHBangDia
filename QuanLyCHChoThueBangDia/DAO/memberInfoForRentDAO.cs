using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCHChoThueBangDia.DAO
{
    internal class memberInfoForRentDAO
    {
        private static memberInfoForRentDAO instance;

        internal static memberInfoForRentDAO Instance 
        { 
            get
            {
                if (instance == null)
                    instance = new memberInfoForRentDAO();
                return instance;
            }
            set => instance = value;
        }

        private memberInfoForRentDAO() { }

        public DataTable getMemberInfoForRent()
        {
            string query = "EXEC USP_getMemberInfoForRent";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }
    }
}

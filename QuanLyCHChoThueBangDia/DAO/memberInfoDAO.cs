using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCHChoThueBangDia.DAO
{
    internal class memberInfoDAO
    {
        private static memberInfoDAO instance;

        internal static memberInfoDAO Instance 
        { 
            get
            {
                if (instance == null)
                    instance = new memberInfoDAO();
                return instance;
            }
            private set => instance = value; 
        }

        private memberInfoDAO() { }

        public DataTable loadMemberInfoList()
        {
            string query = "EXEC dbo.USP_getMemberInfo";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
    }
}

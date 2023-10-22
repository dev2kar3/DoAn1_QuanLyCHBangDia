using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCHChoThueBangDia.DAO
{
    internal class cdInfoDAO
    {
        private static cdInfoDAO instance;

        internal static cdInfoDAO Instance 
        { 
            get
            {
                if (instance == null)
                    instance = new cdInfoDAO();
                return instance;
            } 
            private set => instance = value; 
        }

        private cdInfoDAO() { }

        public DataTable loadCdInfo()
        {
            string query = "EXEC dbo.USP_getCdInfo";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
    }
}

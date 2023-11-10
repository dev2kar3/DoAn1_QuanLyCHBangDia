using QuanLyCHChoThueBangDia.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCHChoThueBangDia.DAO
{
    internal class compactDiscDAO
    {
        private static compactDiscDAO instance;

        internal static compactDiscDAO Instance 
        {
            get
            {
                if (instance == null)
                    instance = new compactDiscDAO();
                return instance;
            }
            private set => instance = value;
        
        }

        public compactDiscDAO() { }

        public List<compactDisc> getCompactDiscByCategoryID(int id)
        {
            List<compactDisc> list = new List<compactDisc>();

            string query = "SELECT * FROM dbo.CompactDisc WHERE idCategory = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows) 
            {
                compactDisc cd = new compactDisc(row);  
                list.Add(cd);
            }

            return list;
        }
    }
}

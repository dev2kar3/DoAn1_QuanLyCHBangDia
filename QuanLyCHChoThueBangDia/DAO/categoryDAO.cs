using QuanLyCHChoThueBangDia.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCHChoThueBangDia.DAO
{
    internal class categoryDAO
    {
        private static categoryDAO instance;

        internal static categoryDAO Instance 
        { 
            get
            {
                if (instance == null)
                    instance = new categoryDAO();
                return instance;
            }
            private set => instance = value;
        }

        private categoryDAO() { }

        public List<category> getListCategory()
        {
            List<category> list = new List<category>();

            string query = "SELECT * FROM dbo.CompactDiscCategory";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                category cate = new category(item);
                list.Add(cate);
            }

            return list;
        }
    }
}

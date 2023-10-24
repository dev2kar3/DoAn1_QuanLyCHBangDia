using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCHChoThueBangDia.DAO
{
    internal class billInfoDAO
    {
        private static billInfoDAO instance;

        internal static billInfoDAO Instance 
        {
            get 
            {
                if (instance == null)
                    instance = new billInfoDAO();
                return instance;
            } 
            private set => instance = value; 
        }

        private billInfoDAO() { }
    }
}

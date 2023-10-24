using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCHChoThueBangDia.DAO
{
    internal class billDAO
    {
        private static billDAO instance;

        internal static billDAO Instance 
        { 
            get
            {
                if (instance == null)
                    instance = new billDAO();
                return instance;
            } 
            private set => instance = value; 
        }

        private billDAO() { }
    }
}

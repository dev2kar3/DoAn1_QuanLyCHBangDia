using QuanLyCHChoThueBangDia.DTO;
using System;
using System.Collections.Generic;
using System.Data;
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

        public int getBillIDByCustomerID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Bill WHERE idCustomer = " + id);
            
            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]); //query này trả về 1 kết quả duy nhất, nên chọn Rows[0]
                return bill.Id;
            }

            //Chạy query và kết quả được lưu vào biến data
            //Khỏi tạo Bill mới lấy từ rows của biến data

            //Thành công : Bill ID
            //Thất bại : -1

            return -1;
        }
    }
}

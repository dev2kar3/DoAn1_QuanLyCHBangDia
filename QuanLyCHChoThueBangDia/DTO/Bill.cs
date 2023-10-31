using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCHChoThueBangDia.DTO
{
    internal class Bill
    {
        public Bill(int id, DateTime? dateCheckIn, DateTime? dateCheckOut)
        {
            this.Id = id;
            this.DateCheckIn = dateCheckIn;
            this.DateCheckOut = dateCheckOut;
        }

        public Bill(DataRow row)
        {
            //Các biến ghi vào ở row cần giống tên trong bảng kết quả truy vấn trong SQL
            //Kiểu dữ liệu trả ra mặc định là object, cần ép kiểu

            this.Id = (int)row["id"];
            var dateCheckInTemp = row["dateCheckIn"];
            if (dateCheckInTemp.ToString() != "")
                this.DateCheckIn = (DateTime)row["dateCheckIn"];

            var dateCheckOutTemp = row["dateCheckOut"];
            if (dateCheckOutTemp.ToString() != "")
                this.DateCheckOut = (DateTime)row["dateCheckOut"];
        }
        //Với trường hợp đặt là null cần kiểm tra

        public int Id { get => id; set => id = value; }
        public DateTime? DateCheckIn 
        { 
            get { return dateCheckIn;  }
            set { dateCheckIn = value; }
        }
        //Riêng kiểu Date phải viết như này, không Ctrl + R + E được
        public DateTime? DateCheckOut 
        { 
            get { return dateCheckOut; }
            set { dateCheckOut = value; }
        }

        private DateTime? dateCheckIn;

        private DateTime? dateCheckOut;

        private int id;
    }
}

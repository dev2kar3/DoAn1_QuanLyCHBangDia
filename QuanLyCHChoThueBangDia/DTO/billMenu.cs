using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCHChoThueBangDia.DTO
{
    internal class billMenu
    {
        public billMenu(string cdname, int quantity, 
            float rentalprice, string category, string note,
            DateTime datecheckin, DateTime datecheckout, float totalprice = 0) 
        {
            this.CdName = cdname;
            this.Quantity = quantity;
            this.Category = category;
            this.Note = note;
            this.RentalPrice = rentalprice;
            this.TotalPrice = totalprice;
            this.DateCheckIn = datecheckin;
            this.DateCheckOut = datecheckout;
        }

        public billMenu(DataRow row)
        {
            //Các biến ghi vào ở row cần giống tên trong bảng kết quả truy vấn trong SQL
            //Kiểu dữ liệu trả ra mặc định là object, cần ép kiểu

            this.CdName = row["Tên Đĩa"].ToString();
            this.Quantity = (int)row["Số Lượng"];
            this.Category = row["Thể Loại"].ToString();
            this.Note = row["Tình Trạng"].ToString();
            this.RentalPrice = (float)Convert.ToDouble(row["Giá Thuê"].ToString());
            this.TotalPrice = (float)Convert.ToDouble(row["Thành Tiền"].ToString());
            this.DateCheckOut = (DateTime)row["Ngày Trả"];
            this.dateCheckIn = (DateTime)row["Ngày Mượn"];
        }

        private string cdName;

        private int quantity;

        private float rentalPrice;

        private float totalPrice;

        private string category;

        private DateTime dateCheckIn;

        private DateTime dateCheckOut;

        private string note;

        public string CdName { get => cdName; set => cdName = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public float RentalPrice { get => rentalPrice; set => rentalPrice = value; }
        public float TotalPrice { get => totalPrice; set => totalPrice = value; }
        public string Category { get => category; set => category = value; }
        public string Note { get => note; set => note = value; }
        public DateTime DateCheckIn 
        {
            get
            {
                return dateCheckIn;
            }
            set
            {
                dateCheckIn = value;
            }
        }
        public DateTime DateCheckOut 
        { 
            get
            {
                return dateCheckOut;
            }
            set
            {
                dateCheckOut = value;
            }
        }
    }
}

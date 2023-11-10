using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace QuanLyCHChoThueBangDia.DTO
{
    internal class RentMenu
    {
        public RentMenu(string cdname, string category, string note, float rentalprice,
            int quantity, DateTime datecheckin, DateTime datecheckout, float depositprice= 0)
        {
            this.CdName = cdname;
            this.Category = category;
            this.Note = note;
            this.RentalPrice = rentalprice;
            this.Quantity = quantity;
            this.DateCheckIn = datecheckin;
            this.DateCheckOut = datecheckout;
            this.DepositPrice = depositprice;
        }

        public RentMenu(DataRow row)
        {
            //Các biến ghi vào ở row cần giống tên trong bảng kết quả truy vấn trong SQL
            //Kiểu dữ liệu trả ra mặc định là object, cần ép kiểu

            this.CdName = row["Tên Đĩa"].ToString();
            this.Category = row["Thể Loại"].ToString();
            this.Note = row["Tình Trạng"].ToString();
            this.RentalPrice = (float)Convert.ToDouble(row["Giá Thuê"]);
            this.Quantity = (int)row["Số Lượng"];

            var dateCheckInTemp = row["Ngày Mượn"];
            if (dateCheckInTemp.ToString() != "")
                this.DateCheckIn = (DateTime)row["Ngày Mượn"];

            var dateCheckOutTemp = row["Ngày Trả"];
            if (dateCheckOutTemp.ToString() != "")
                this.DateCheckOut = (DateTime)row["Ngày Trả"];

            this.DepositPrice = (float)Convert.ToDouble(row["Giá Cọc"]);
        }

        private string cdName;

        private string category;

        private string note;

        private float rentalPrice;

        private int quantity;

        private float depositPrice;

        private DateTime dateCheckIn;

        private DateTime dateCheckOut;

        public string CdName { get => cdName; set => cdName = value; }
        public string Category { get => category; set => category = value; }
        public string Note { get => note; set => note = value; }
        public float RentalPrice { get => rentalPrice; set => rentalPrice = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public float DepositPrice { get => depositPrice; set => depositPrice = value; }
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

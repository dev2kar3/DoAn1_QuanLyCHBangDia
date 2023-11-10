using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCHChoThueBangDia.DTO
{
    internal class memberInfo
    {
        private int id;
        private string accountName;
        private string gender;
        private BigInteger phoneNumber;
        private string userAddress;
        private BigInteger identify;
        private int status;

        public memberInfo(int id, string accountname, string gender, BigInteger phonenumber, 
            string useraddress, BigInteger identify, int status)
        {
            this.Id = id;
            this.AccountName = accountname;
            this.Gender = gender;
            this.PhoneNumber = phonenumber;
            this.UserAddress = useraddress;
            this.Identify = identify;
            this.Status = status;
        }

        public memberInfo(DataRow row)
        {
            this.Id = (int)row["ID"];
            this.AccountName = row["Thành Viên"].ToString();
            this.Gender = row["Giới Tính"].ToString();
            this.PhoneNumber = (BigInteger)row["Số Phone"];
            this.UserAddress = row["Địa Chỉ"].ToString();
            this.Identify = (BigInteger)row["Số CCCD"];
            this.Status = (int)row["Trạng Thái"];
        }

        public int Id { get => id; set => id = value; }
        public string AccountName { get => accountName; set => accountName = value; }
        public string Gender { get => gender; set => gender = value; }
        public BigInteger PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string UserAddress { get => userAddress; set => userAddress = value; }
        public BigInteger Identify { get => identify; set => identify = value; }
        public int Status { get => status; set => status = value; }
    }
}

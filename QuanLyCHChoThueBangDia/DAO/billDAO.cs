﻿using QuanLyCHChoThueBangDia.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Hiện chưa dùng lớp này, ban đầu tạo nhưng sau đó dùng billMenu

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

        public void insertBill(int idCustomer)
        {
            DataProvider.Instance.ExecuteQuery("EXEC USP_insertBill @idCustomer", new object[] {idCustomer});
        }

        public int getMaxIdBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(id) FROM dbo.Bill");
            }
            catch
            {
                return 1;
            }
        }

        public int getIdBillByIdCustomer(int id)
        {
            return (int)DataProvider.Instance.ExecuteScalar("EXEC dbo.USP_getBillIdByCustomerId @idCustomer = " + id);
        }

        public void deleteAllBillInfoByIdBill(int idBill)
        {
            DataProvider.Instance.ExecuteQuery("EXEC USP_deleteAllBillInfoByBillId @idBill",
                new object[] { idBill });
        }


        public void checkOut(int idBill, int idCustomer, float revenue, int discount) //idBill
        {
            DataTable data = 
                DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Bill WHERE id = " + idBill);

            Bill bill = new Bill(data.Rows[0]);

            data = DataProvider.Instance.ExecuteQuery("SELECT id AS ID, accountName AS \"Thành Viên\"," +
                "gender AS \"Giới Tính\", phoneNumber AS \"Số Phone\",userAddress AS \"Địa Chỉ\"," +
                " identify AS \"Số CCCD\", status AS \"Trạng Thái\" FROM dbo.memberInfo" + 
                " WHERE id = " + idCustomer);

            memberInfo mem = new memberInfo(data.Rows[0]);

            DataProvider.Instance.ExecuteQuery("EXEC USP_insertRevenue @name , @revenue , @in , @out , @discount",
                new object[] { mem.AccountName, revenue, bill.DateCheckIn, bill.DateCheckOut, discount});


            DataProvider.Instance.ExecuteQuery("EXEC USP_deleteAllBillInfoByBillId @idBill = " + idBill);

            DataProvider.Instance.ExecuteQuery("EXEC USP_changeStatusToNoRent @idCustomer = " + idCustomer);

            DataProvider.Instance.ExecuteQuery("DELETE dbo.Bill WHERE id = " + idBill);
        }

        public DataTable getRevenueByDate(DateTime dateCheckIn, DateTime dateCheckOut)
        {
            return DataProvider.Instance.ExecuteQuery("EXEC USP_getRevenueByDate @In , @Out", 
                new object[] { dateCheckIn, dateCheckOut });
        }
    }
}

using QuanLyCHChoThueBangDia.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Hiện chưa dùng lớp này, ban đầu tạo nhưng sau đó dùng billMenu


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

        public List<BillInfo> getListBillInfo(int id)
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();

            DataTable data = 
                DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.BillInfo WHERE dbo.BillInfo.idBill = " + id);

            foreach (DataRow item in  data.Rows) 
            //Kiểu dữ liệu datarow là kiểu của từng biến trong mảng Datatable data 
            {
                BillInfo billinfo = new BillInfo(item);
                listBillInfo.Add(billinfo);

            }

            //Biến data chứ dữ liệu của tất cả billInfo được truy vấn

            //Tương tự cách lấy bill, câu truy vấn trên trả về kết quả 1 danh sách billInfo
            //Sau đó các billInfo được add vào listBillInfo

            return listBillInfo;
        }

        public void insertBillInfo(int idBill, int idCd, int quantity)
        {
            DataProvider.Instance.ExecuteQuery("EXEC USP_insertBillInfo @idBill , @idCd , @quantity",
                new object[] {idBill, idCd, quantity}) ;
        }

        public int getCurrentQuantity(int id) // id CD
        {
            return (int)DataProvider.Instance.ExecuteScalar("EXEC USP_getCurrentRemainQuantity @idCd",
                new object[] { id });
        }
    }
}

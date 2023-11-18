using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCHChoThueBangDia.DTO
{
    internal class BillInfo
    {
        //Những lớp như này là giả lập đối tượng để nhận thông tin khi lấy kết quả query từ sql
        //Gọi là model

        public BillInfo(int id, int billid, int cdid, int quantity)
        {
            this.Id = id;
            this.BillId = billid;
            this.CdId = cdid;
            this.Quantity = quantity;
        }

        public BillInfo(DataRow row)
        {
            this.Id = (int)row["id"];
            this.BillId = (int)row["idBill"];
            this.CdId = (int)row["idCd"];
            this.Quantity = (int)row["quantity"];
        }

        private int id;

        private int billId;

        private int cdId;

        private int quantity;

        public int Id { get => id; set => id = value; }
        public int BillId { get => billId; set => billId = value; }
        public int CdId { get => cdId; set => cdId = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }
}

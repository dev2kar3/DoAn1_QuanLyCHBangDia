using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace QuanLyCHChoThueBangDia.DTO
{
    internal class compactDisc
    {
        public compactDisc(int id, string cdname, float rentalprice, int quantity, int remaincd,
            string productioncomp, string note, int idcategory)
        {
            this.Id = id;
            this.CdName = cdname;
            this.RentalPrice = rentalprice;
            this.Quantity = quantity;
            this.RemainCd = remaincd;
            this.ProductionComp = productioncomp;
            this.Note = note;
            this.IdCategory = idcategory;
        }

        public compactDisc(DataRow row)
        {
            this.Id = (int)row["ID"];
            this.CdName = row["cdName"].ToString();
            this.RentalPrice = (float)Convert.ToDouble(row["rentalPrice"]);
            this.Quantity = (int)row["quantity"];
            this.RemainCd = (int)row["remainCD"];
            this.ProductionComp = row["productionComp"].ToString();
            this.Note = row["note"].ToString();
            this.IdCategory = (int)row["idCategory"];
        }

        private int id;
        private string cdName;
        private float rentalPrice;
        private int quantity;
        private int remainCd;
        private string productionComp;
        private string note;
        private int idCategory;

        public int Id { get => id; set => id = value; }
        public string CdName { get => cdName; set => cdName = value; }
        public float RentalPrice { get => rentalPrice; set => rentalPrice = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int RemainCd { get => remainCd; set => remainCd = value; }
        public string ProductionComp { get => productionComp; set => productionComp = value; }
        public string Note { get => note; set => note = value; }
        public int IdCategory { get => idCategory; set => idCategory = value; }
    }
}

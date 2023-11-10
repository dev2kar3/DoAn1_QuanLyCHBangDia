using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCHChoThueBangDia.DTO
{
    internal class category
    {
        public category(int id, string name)
        {
            this.Id = id;
            this.CateName = name;
        }

        public category(DataRow row)
        {
            this.Id = (int)row["id"];
            this.CateName = row["cateName"].ToString();
        }

        private int id;

        private string cateName;

        public int Id { get => id; set => id = value; }
        public string CateName { get => cateName; set => cateName = value; }
    }
}

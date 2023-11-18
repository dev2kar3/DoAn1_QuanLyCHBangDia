using QuanLyCHChoThueBangDia.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCHChoThueBangDia
{
    public partial class fRevenue : Form
    {
        public fRevenue()
        {
            InitializeComponent();
            loadRevenue(dtpkFromDate.Value, dtpkToDate.Value);
        }

        public void loadRevenue(DateTime dateCheckIn, DateTime dateCheckOut)
        {
            dtgvRevenue.DataSource = billDAO.Instance.getRevenueByDate(dateCheckIn, dateCheckOut);
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            loadRevenue(dtpkFromDate.Value, dtpkToDate.Value);
        }
    }
}

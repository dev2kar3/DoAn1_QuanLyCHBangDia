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
    public partial class fCDManager : Form
    {
        public fCDManager()
        {
            InitializeComponent();

            loadCdInfo();
        }

        void loadCdInfo()
        {
            dtgv_cdView.DataSource = cdInfoDAO.Instance.loadCdInfo();
        }

        private void dtgv_cdView_Click(object sender, EventArgs e)
        {

        }
    }
}

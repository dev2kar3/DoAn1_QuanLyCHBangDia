using QuanLyCHChoThueBangDia.DAO;
using QuanLyCHChoThueBangDia.DTO;
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
    public partial class fBill : Form
    {
        public fBill()
        {
            InitializeComponent();
            showRentingMember();
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {

        }

        private void showRentingMember()
        {
            dtgv_showAccount.DataSource = rentingMemberInfoDAO.Instance.loadRentingMemberInfoList();
        }

        private void dtgv_showAccount_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            object id = dtgv_showAccount.CurrentRow.Cells[0].Value;
            int idCustomer = Convert.ToInt32(id);

            showBill(idCustomer);
        }

        public void showBill(int id) //ID ở đây của Customer
        {
            liv_listCD.Items.Clear();

            List<billMenu> listBillMenuInfo = billMenuDAO.Instance.getListBillMenuByCustomer(id);

            foreach (billMenu item in listBillMenuInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.CdName.ToString());
                lsvItem.SubItems.Add(item.Category.ToString());
                lsvItem.SubItems.Add(item.Note.ToString());
                lsvItem.SubItems.Add(item.RentalPrice.ToString());
                lsvItem.SubItems.Add(item.Quantity.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());

                liv_listCD.Items.Add(lsvItem);
            }
        }
    }
}

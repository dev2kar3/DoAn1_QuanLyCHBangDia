using QuanLyCHChoThueBangDia.DAO;
using QuanLyCHChoThueBangDia.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCHChoThueBangDia
{
    public partial class fRent : Form
    {
        //Set quốc gia để hiển thị đơn vị tiền
        private CultureInfo culture = new CultureInfo("vi-VN");

        public fRent()
        {
            InitializeComponent();
            loadMemberInfoForRent();
            loadCategory();
        }

        public void loadMemberInfoForRent()
        {
            dtgv_showMemberInfo.DataSource = memberInfoForRentDAO.Instance.getMemberInfoForRent();
        }

        private void dtgv_showMemberInfo_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            object id = dtgv_showMemberInfo.CurrentRow.Cells[0].Value;
            int idCustomer = Convert.ToInt32(id);

            currentIDCustomer = idCustomer;
            showRent(idCustomer);
        }
        private int currentIDCustomer = 0;

        public void showRent(int id)
        {
            liv_listRentCD.Items.Clear();

            List<RentMenu> listRentMenu = rentMenuDAO.Instance.getListRentMenuByCustomer(id);
            float totalDeposit = 0;
            int countCdTotalQuantity = 0;

            foreach (RentMenu item in listRentMenu)
            {
                ListViewItem lsvItem = new ListViewItem(item.CdName.ToString());
                lsvItem.SubItems.Add(item.Category.ToString());
                lsvItem.SubItems.Add(item.Note.ToString());
                lsvItem.SubItems.Add(item.RentalPrice.ToString());
                lsvItem.SubItems.Add(item.Quantity.ToString());
                lsvItem.SubItems.Add(item.DateCheckIn.ToString());
                lsvItem.SubItems.Add(item.DateCheckOut.ToString());
                lsvItem.SubItems.Add(item.DepositPrice.ToString());

                totalDeposit += item.DepositPrice;
                countCdTotalQuantity += item.Quantity;

                liv_listRentCD.Items.Add(lsvItem);
            }
        }

        public void loadCategory()
        {
            List<category> listCategory = categoryDAO.Instance.getListCategory();
            cb_category.DataSource = listCategory;
            cb_category.DisplayMember = "cateName";
        }

        public void loadCdListByCategoryID(int id)
        {
            List<compactDisc> listCD = compactDiscDAO.Instance.getCompactDiscByCategoryID(id);
            cb_nameCD.DataSource = listCD;
            cb_nameCD.DisplayMember = "cdName";

            if (listCD.Count == 0)
            {
                cb_nameCD.Text = string.Empty;
            }
        }

        private void cb_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            category selected = cb.SelectedItem as category;
            id = selected.Id;

            loadCdListByCategoryID(id);
        }

        private void btn_addCD_Click(object sender, EventArgs e)
        {

            int idBill = billDAO.Instance.getBillIDByCustomerID(currentIDCustomer);
            int idCd = (cb_nameCD.SelectedItem as compactDisc).Id;
            int quantity = (int)nud_quantity.Value;

            if (idBill == -1)
            {
                billDAO.Instance.insertBill(currentIDCustomer);
                billInfoDAO.Instance.insertBillInfo(billDAO.Instance.getMaxIdBill(), idCd, quantity);
            }
            else
            {
                billInfoDAO.Instance.insertBillInfo(billDAO.Instance.getMaxIdBill(), idCd, quantity);
            }

            showRent(currentIDCustomer);
        }

        private void btn_rent_Click(object sender, EventArgs e)
        {

        }
    }
}

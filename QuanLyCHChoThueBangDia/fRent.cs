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
        private int currentIDCustomer = 0;
        List<compactDisc> listCD_canChange = compactDiscDAO.Instance.getAllCompactDisc();
        List<compactDisc> listCD_origin = compactDiscDAO.Instance.getAllCompactDisc();
        List<int> listIdCustomerForClean = new List<int>();

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
                item.DateCheckIn = dp_fromDate.Value;
                lsvItem.SubItems.Add(item.DateCheckIn.ToString("MM/dd/yyyy"));
                item.DateCheckOut = dp_toDate.Value;
                lsvItem.SubItems.Add(item.DateCheckOut.ToString("MM/dd/yyyy"));
                lsvItem.SubItems.Add(item.DepositPrice.ToString());

                totalDeposit += item.DepositPrice;
                countCdTotalQuantity += item.Quantity;

                txb_totalDeposit.Text = totalDeposit.ToString();

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
            int quantity = (int)nud_quantity.Value;

            if (quantity == 0)
                return;

            int idBill = billDAO.Instance.getBillIDByCustomerID(currentIDCustomer);
            int idCd = (cb_nameCD.SelectedItem as compactDisc).Id;

            for (int i = 0; i <= listIdCustomerForClean.Count; i++)
            {
                if (listIdCustomerForClean.Count == 0)
                {
                    listIdCustomerForClean.Add(currentIDCustomer);
                    break;
                }

                if (listIdCustomerForClean.Exists(item => item == currentIDCustomer))
                {
                    continue;
                }
                else
                {
                    listIdCustomerForClean.Add(currentIDCustomer);
                    break;
                }

            }

            int? cdRemaind = null;

            foreach (compactDisc cd in listCD_canChange)
            {
                if (cd.Id == idCd)
                    cdRemaind = cd.RemainCd;
            }

            if (idBill == -1)
                billDAO.Instance.insertBill(currentIDCustomer);


            if ((cdRemaind - quantity) >= 0 && quantity > 0)
            {
                billInfoDAO.Instance.insertBillInfo(billDAO.Instance.getBillIDByCustomerID(currentIDCustomer),
                    idCd, quantity);

                foreach (compactDisc cd in listCD_canChange)
                {
                    if (cd.Id == idCd)
                    {
                        cd.RemainCd = (int)cdRemaind - quantity;
                        break;
                    }
                }
            }
            else if (quantity < 0)
            {
                int originRemaindCd = 0;

                foreach (compactDisc cd in listCD_origin)
                {
                    if (idCd == cd.Id)
                        originRemaindCd = cd.RemainCd;
                }

                if (cdRemaind - quantity > originRemaindCd)
                {
                    MessageBox.Show("Không thể Giảm Đĩa!", "Thông Báo");
                }
                else
                {
                    billInfoDAO.Instance.insertBillInfo(billDAO.Instance.getBillIDByCustomerID(currentIDCustomer),
                        idCd, quantity);

                    foreach (compactDisc cd in listCD_canChange)
                    {
                        if (cd.Id == idCd)
                            cd.RemainCd = (int)cdRemaind - quantity;
                    }
                }
            }
            else
            {
                MessageBox.Show("Không thể thêm vì không còn đủ đĩa!", "Thông Báo");
            }

            showRent(currentIDCustomer);
        }

        private void dp_fromDate_ValueChanged(object sender, EventArgs e)
        {
            showRent(currentIDCustomer);
        }

        private void dp_toDate_ValueChanged(object sender, EventArgs e)
        {
            showRent(currentIDCustomer);
        }

        private void fRent_FormClosed(object sender, FormClosedEventArgs e)
        {
            List<int> listIdBill = new List<int>();

            foreach (int item in listIdCustomerForClean)
            {
                listIdBill.Add(billDAO.Instance.getIdBillByIdCustomer(item));
            }

            foreach (int item in listIdBill)
            {
                billDAO.Instance.deleteAllBillInfoByIdBill(item);
            }

            foreach (int item in listIdBill)
            {
                DataProvider.Instance.ExecuteQuery("DELETE FROM dbo.Bill WHERE id = " + item);
            }
        }

        private void btn_rent_Click(object sender, EventArgs e)
        {
            if (currentIDCustomer == 0)
            {
                return;
            }

            List<int> idxToRemove = new List<int>();

            //Check xem người dùng đã thực sự thêm đĩa nào chưa
            int count = 
                (int)DataProvider.Instance.ExecuteScalar("SELECT COUNT(*) FROM dbo.Bill WHERE idCustomer = " + currentIDCustomer);
            bool isBillExist = count > 0 ? true : false;

            if (!isBillExist)
            {
                MessageBox.Show("Khách Hàng Chưa Chọn Đĩa Nào!", "Thông Báo!");
                return; 
            }

            foreach (int item in listIdCustomerForClean)
            {
                if (listIdCustomerForClean.Exists(item => item == currentIDCustomer))
                {
                    idxToRemove.Add(item);
                }
            }

            foreach (int item in idxToRemove)
            {
                if (listIdCustomerForClean.Exists(item => item == currentIDCustomer))
                {
                    listIdCustomerForClean.Remove(item);
                }
            }

            DataProvider.Instance.ExecuteQuery("EXEC USP_changeStatusToRent @idCustomer", 
                new object[] { currentIDCustomer });

            DataProvider.Instance.ExecuteQuery("EXEC USP_updateRentDay @idCustomer , @date",
                new object[] { currentIDCustomer, dp_toDate.Value});

            int idBill = billDAO.Instance.getIdBillByIdCustomer(currentIDCustomer);

            List<BillInfo> billinfo = billInfoDAO.Instance.getListBillInfo(idBill);

            List<compactDisc> cd = compactDiscDAO.Instance.getAllCompactDisc();

            foreach (BillInfo billin4 in billinfo)
            {
                foreach (compactDisc disc in cd)
                {
                    if (disc.Id == billin4.CdId)
                    {
                        DataProvider.Instance.ExecuteQuery("EXEC USP_updateQuantityForRent @idCd , @quantity",
                            new object[] {disc.Id, billin4.Quantity});
                        break;
                    }
                }
            }

            MessageBox.Show("Thuê Thành Công!", "Thông Báo");

            loadMemberInfoForRent();
        }
    }
}

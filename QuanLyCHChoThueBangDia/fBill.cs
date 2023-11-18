using QuanLyCHChoThueBangDia.DAO;
using QuanLyCHChoThueBangDia.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace QuanLyCHChoThueBangDia
{
    public partial class fBill : Form
    {
        //Set quốc gia để hiển thị đơn vị tiền
        private CultureInfo culture = new CultureInfo("vi-VN");
        private int currentIdCustomer = 0;


        public fBill()
        {
            InitializeComponent();
            showRentingMember();
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            if (currentIdCustomer == 0)
            {
                return;
            }

            int idBill = billDAO.Instance.getIdBillByIdCustomer(currentIdCustomer);

            memberInfo currentMem = memberInfoDAO.Instance.getMemberInfoById(currentIdCustomer);

            if (idBill != -1)
            {
                if (MessageBox.Show("Bạn có muốn thanh toán cho tài khoản " + currentMem.AccountName + " ?",
                    "Thông Báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    float revenue = 0;
                    string totalPriceFormated = txb_totalPrice.Text.Replace(" ₫", "");
                    totalPriceFormated = totalPriceFormated.Replace(".", "");

                    string receiveFormated = txb_receive.Text.Replace(" ₫", "");
                    receiveFormated = receiveFormated.Replace(".", "");

                    if (txb_receive.Text.ToString().Equals("0"))
                    {
                        revenue = (float)Convert.ToDouble(totalPriceFormated);
                    }
                    else if (txb_payback.Text.ToString().Equals("0"))
                    {
                        revenue = (float)Convert.ToDouble(receiveFormated);
                    }

                    List<compactDisc> cd = compactDiscDAO.Instance.getAllCompactDisc();
                    List<BillInfo> billinfo = billInfoDAO.Instance.getListBillInfo(idBill);

                    foreach (BillInfo billin4 in billinfo)
                    {
                        foreach (compactDisc disc in cd)
                        {
                            if (disc.Id == billin4.CdId)
                            {
                                DataProvider.Instance.ExecuteQuery("EXEC USP_updateRemainCdAfterPay @idCd , @sl",
                                    new object[] {disc.Id, billin4.Quantity});
                                break;
                            }
                        }
                    }

                    billDAO.Instance.checkOut(idBill, currentMem.Id, revenue, (int)nmud_discount.Value);
                    showRentingMember();
                    currentIdCustomer = 0;
                    MessageBox.Show("Thanh toán thành công!", "Thông báo");
                }
            }
        }

        private void showRentingMember()
        {
            dtgv_showAccount.DataSource = rentingMemberInfoDAO.Instance.loadRentingMemberInfoList();
        }

        private void dtgv_showAccount_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dtgv_showAccount.CurrentRow == null)
            {
                return;
            }

            object id = dtgv_showAccount.CurrentRow.Cells[0].Value;
            currentIdCustomer = Convert.ToInt32(id);

            showBill(currentIdCustomer);
        }

        private float lastTotalPrice = 0; // on clicked
        private float lastDeposit = 0; // on clicked

        public void showBill(int id) //ID ở đây của Customer
        {
            liv_listCD.Items.Clear();
            while (nmud_discount.Value > 0)
            {
                nmud_discount.DownButton();
            }

            List<billMenu> listBillMenuInfo = billMenuDAO.Instance.getListBillMenuByCustomer(id);
            float totalPrice = 0;
            float countCdTotalQuantity = 0;

            foreach (billMenu item in listBillMenuInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.CdName.ToString());
                lsvItem.SubItems.Add(item.Category.ToString());
                lsvItem.SubItems.Add(item.Note.ToString());
                lsvItem.SubItems.Add(item.RentalPrice.ToString("c", culture));
                lsvItem.SubItems.Add(item.Quantity.ToString());
                lsvItem.SubItems.Add(item.DateCheckIn.ToString());
                lsvItem.SubItems.Add(item.DateCheckOut.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString("c", culture));

                totalPrice += item.TotalPrice;
                countCdTotalQuantity += item.Quantity;

                liv_listCD.Items.Add(lsvItem);
            }

            float deposit = countCdTotalQuantity * 50000;

            txb_totalPrice.Text = totalPrice.ToString("c", culture);
            txb_deposit.Text = deposit.ToString("c", culture);

            lastTotalPrice = totalPrice;
            lastDeposit = countCdTotalQuantity * 50000;

            calculatePaymentForBill();
        }

        public void calculatePaymentForBill()
        {
            float tempTotalPrice = lastTotalPrice;  //Tong Tien thue dia
            float discount = 0;                     // So tien giam gia

            if (nmud_discount.Value > 0)
            {
                discount = ((tempTotalPrice / 100) * (float)nmud_discount.Value);
            }


            if (tempTotalPrice > lastDeposit)
            {
                txb_receive.Text = (tempTotalPrice - lastDeposit - discount).ToString("c", culture);
                txb_payback.Text = "0";
                txb_totalPrice.Text = (tempTotalPrice - discount).ToString("c", culture);

                if (tempTotalPrice - lastDeposit - discount < 0)
                {
                    txb_receive.Text = "0";
                    txb_payback.Text = ((tempTotalPrice - lastDeposit - discount) * (-1)).ToString("c", culture);
                    txb_totalPrice.Text = (tempTotalPrice - discount).ToString("c", culture);
                }
            }
            else if (tempTotalPrice < lastDeposit)
            {
                txb_receive.Text = "0";
                txb_payback.Text = ((lastDeposit - tempTotalPrice) + discount).ToString("c", culture);
                txb_totalPrice.Text = (tempTotalPrice - discount).ToString("c", culture);
            }
        }

        private void nmud_discount_ValueChanged(object sender, EventArgs e)
        {
            calculatePaymentForBill();
        }
    }
}

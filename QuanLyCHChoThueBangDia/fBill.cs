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
            float tempTotalPrice = lastTotalPrice;
            float discount = 0;

            if (nmud_discount.Value > 0)
            {
                discount = ((tempTotalPrice / 100) * (float)nmud_discount.Value);
            }


            if (tempTotalPrice > lastDeposit)
            {
                txb_receive.Text = (tempTotalPrice - lastDeposit - discount).ToString("c", culture);
                txb_payback.Text = "0";

                if (tempTotalPrice - lastDeposit - discount < 0)
                {
                    txb_receive.Text = "0";
                    txb_payback.Text = ((tempTotalPrice - lastDeposit - discount) * (-1)).ToString("c", culture);
                }
            }
            else if (tempTotalPrice < lastDeposit)
            {
                txb_receive.Text = "0";
                txb_payback.Text = ((lastDeposit - tempTotalPrice) + discount).ToString("c", culture);
            }
        }

        private void nmud_discount_ValueChanged(object sender, EventArgs e)
        {
            calculatePaymentForBill();
        }
    }
}

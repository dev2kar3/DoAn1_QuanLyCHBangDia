using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCHChoThueBangDia
{
    public partial class fTableManager : Form
    {
        public fTableManager()
        {
            InitializeComponent();
        }

        private void fTableManager_Load(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void customizeDesign()
        {
            panel_accountSubMenu.Visible = false;
            panel_cdSubMenu.Visible = false;
            panel_rentalSubMenu.Visible = false;
            panel_paymentSubMenu.Visible = false;
        }

        private void hideSubmenu()
        {
            if (panel_accountSubMenu.Visible == true)
                panel_accountSubMenu.Visible = false;
            if (panel_cdSubMenu.Visible == true)
                panel_cdSubMenu.Visible = false;
            if (panel_rentalSubMenu.Visible == true)
                panel_rentalSubMenu.Visible = false;
            if (panel_paymentSubMenu.Visible == true)
                panel_paymentSubMenu.Visible = false;
        }

        private void showSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubmenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void button_account_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_accountSubMenu);
        }

        #region accountSubmenu
        private void button_accountRegistration_Click(object sender, EventArgs e)
        {
            fRegister f = new fRegister();
            f.ShowDialog();
            hideSubmenu();
        }

        private void button_accountManagement_Click(object sender, EventArgs e)
        {
            fAccountManager f = new fAccountManager();
            f.ShowDialog();
            hideSubmenu();
        }

        private void button_accountPrint_Click(object sender, EventArgs e)
        {
            //...
            //Code
            //...
            hideSubmenu();
        }

        #endregion accountSubmenu

        private void button_cd_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_cdSubMenu);
        }

        #region cdSubmenu

        private void button_cdImport_Click(object sender, EventArgs e)
        {
            fImportDisc f = new fImportDisc();
            f.ShowDialog();
            hideSubmenu();
        }

        private void button_cdManagement_Click(object sender, EventArgs e)
        {
            fCDManager f = new fCDManager();
            f.ShowDialog();
            hideSubmenu();
        }

        private void button_cdPrint_Click(object sender, EventArgs e)
        {
            //...
            //Code
            //...
            hideSubmenu();
        }

        #endregion cdSubmenu

        private void button_rental_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_rentalSubMenu);
        }

        #region rentalSubmenu

        private void button_accountCheck_Click(object sender, EventArgs e)
        {
            fCheckAccount f = new fCheckAccount();
            f.ShowDialog();
            hideSubmenu();
        }

        private void button_forRental_Click(object sender, EventArgs e)
        {
            fCDManager fCDManager = new fCDManager();
            fRent f = new fRent();
            f.Show();
            fCDManager.Show();
            f.Location = new Point(1200, 400);
            fCDManager.Location = new Point(0, 10); 
            hideSubmenu();
        }

        private void button_rentalPrint_Click(object sender, EventArgs e)
        {
            //...
            //Code
            //...
            hideSubmenu();
        }

        #endregion rentalSubmenu

        private void button_payment_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_paymentSubMenu);
        }

        #region paymentSubmenu

        private void button_paymentCheckCD_Click(object sender, EventArgs e)
        {
            //...
            //Code
            //...
            hideSubmenu();
        }

        private void button_paymentBill_Click(object sender, EventArgs e)
        {
            fBill f = new fBill();
            f.ShowDialog();
            hideSubmenu();
        }

        private void button_paymentPrint_Click(object sender, EventArgs e)
        {
            fRevenue f = new fRevenue();
            f.ShowDialog();
            hideSubmenu();
        }

        #endregion paymentSubmenu

        private void btn_sales_Click(object sender, EventArgs e)
        {
            fSales f = new fSales();
            f.ShowDialog();
            hideSubmenu();
        }

        private void button_exitTableManager_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region contactInteraction

        private void linkLabel_contactInstagram_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var parameter = new ProcessStartInfo
            {
                Verb = "open",
                FileName = "explorer",
                Arguments = "https://www.instagram.com/crkey.me/"
            };
            Process.Start(parameter);
        }

        private void linkLabel_contactFB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var parameter = new ProcessStartInfo
            {
                Verb = "open",
                FileName = "explorer",
                Arguments = "https://www.facebook.com/"
            };
            Process.Start(parameter);
        }

        #endregion contacInteraction
    }
}

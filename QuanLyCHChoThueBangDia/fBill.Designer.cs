namespace QuanLyCHChoThueBangDia
{
    partial class fBill
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fBill));
            panel1 = new Panel();
            panel3 = new Panel();
            dtgv_showAccount = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            nmud_discount = new NumericUpDown();
            label10 = new Label();
            txb_payback = new TextBox();
            label9 = new Label();
            txb_receive = new TextBox();
            label8 = new Label();
            txb_deposit = new TextBox();
            label7 = new Label();
            txb_totalPrice = new TextBox();
            label_totalPrice = new Label();
            btn_pay = new Button();
            liv_listCD = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            label5 = new Label();
            label6 = new Label();
            btn_search = new Button();
            textBox1 = new TextBox();
            label4 = new Label();
            txb_searchName = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_showAccount).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmud_discount).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(810, 903);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(dtgv_showAccount);
            panel3.Location = new Point(3, 69);
            panel3.Name = "panel3";
            panel3.Size = new Size(804, 830);
            panel3.TabIndex = 2;
            // 
            // dtgv_showAccount
            // 
            dtgv_showAccount.AllowUserToAddRows = false;
            dtgv_showAccount.AllowUserToDeleteRows = false;
            dtgv_showAccount.BackgroundColor = SystemColors.ControlLight;
            dtgv_showAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_showAccount.Location = new Point(3, 3);
            dtgv_showAccount.Name = "dtgv_showAccount";
            dtgv_showAccount.RowHeadersWidth = 62;
            dtgv_showAccount.RowTemplate.Height = 33;
            dtgv_showAccount.Size = new Size(798, 824);
            dtgv_showAccount.TabIndex = 0;
            dtgv_showAccount.CellMouseClick += dtgv_showAccount_CellMouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(14, 15);
            label1.Name = "label1";
            label1.Size = new Size(385, 28);
            label1.TabIndex = 0;
            label1.Text = "Danh Sách Tài Khoản Đang Thuê";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(11, 22);
            label2.Name = "label2";
            label2.Size = new Size(594, 32);
            label2.TabIndex = 1;
            label2.Text = "__________________________________________________________";
            // 
            // panel2
            // 
            panel2.Controls.Add(nmud_discount);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(txb_payback);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txb_receive);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txb_deposit);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txb_totalPrice);
            panel2.Controls.Add(label_totalPrice);
            panel2.Controls.Add(btn_pay);
            panel2.Controls.Add(liv_listCD);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(btn_search);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txb_searchName);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(828, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(990, 899);
            panel2.TabIndex = 1;
            // 
            // nmud_discount
            // 
            nmud_discount.Location = new Point(841, 696);
            nmud_discount.Name = "nmud_discount";
            nmud_discount.Size = new Size(129, 31);
            nmud_discount.TabIndex = 18;
            nmud_discount.TextAlign = HorizontalAlignment.Center;
            nmud_discount.ValueChanged += nmud_discount_ValueChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(721, 700);
            label10.Name = "label10";
            label10.Size = new Size(109, 23);
            label10.TabIndex = 17;
            label10.Text = "Giảm Giá :";
            // 
            // txb_payback
            // 
            txb_payback.Location = new Point(507, 750);
            txb_payback.Name = "txb_payback";
            txb_payback.ReadOnly = true;
            txb_payback.Size = new Size(161, 31);
            txb_payback.TabIndex = 16;
            txb_payback.Text = "0";
            txb_payback.TextAlign = HorizontalAlignment.Right;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(379, 754);
            label9.Name = "label9";
            label9.Size = new Size(113, 23);
            label9.TabIndex = 15;
            label9.Text = "Trả Khách :";
            // 
            // txb_receive
            // 
            txb_receive.Location = new Point(507, 696);
            txb_receive.Name = "txb_receive";
            txb_receive.ReadOnly = true;
            txb_receive.Size = new Size(161, 31);
            txb_receive.TabIndex = 14;
            txb_receive.Text = "0";
            txb_receive.TextAlign = HorizontalAlignment.Right;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(379, 700);
            label8.Name = "label8";
            label8.Size = new Size(122, 23);
            label8.TabIndex = 13;
            label8.Text = "Thu Khách :";
            // 
            // txb_deposit
            // 
            txb_deposit.Location = new Point(164, 746);
            txb_deposit.Name = "txb_deposit";
            txb_deposit.ReadOnly = true;
            txb_deposit.Size = new Size(161, 31);
            txb_deposit.TabIndex = 12;
            txb_deposit.Text = "0";
            txb_deposit.TextAlign = HorizontalAlignment.Right;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(27, 750);
            label7.Name = "label7";
            label7.Size = new Size(128, 23);
            label7.TabIndex = 11;
            label7.Text = "Khách Cọc :";
            // 
            // txb_totalPrice
            // 
            txb_totalPrice.Location = new Point(164, 692);
            txb_totalPrice.Name = "txb_totalPrice";
            txb_totalPrice.ReadOnly = true;
            txb_totalPrice.Size = new Size(161, 31);
            txb_totalPrice.TabIndex = 10;
            txb_totalPrice.Text = "0";
            txb_totalPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // label_totalPrice
            // 
            label_totalPrice.AutoSize = true;
            label_totalPrice.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_totalPrice.Location = new Point(54, 696);
            label_totalPrice.Name = "label_totalPrice";
            label_totalPrice.Size = new Size(101, 23);
            label_totalPrice.TabIndex = 9;
            label_totalPrice.Text = "Tổng Tiền :";
            // 
            // btn_pay
            // 
            btn_pay.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_pay.Location = new Point(757, 754);
            btn_pay.Name = "btn_pay";
            btn_pay.Size = new Size(178, 63);
            btn_pay.TabIndex = 8;
            btn_pay.Text = "Thanh Toán";
            btn_pay.UseVisualStyleBackColor = true;
            btn_pay.Click += btn_pay_Click;
            // 
            // liv_listCD
            // 
            liv_listCD.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            liv_listCD.GridLines = true;
            liv_listCD.Location = new Point(6, 219);
            liv_listCD.Name = "liv_listCD";
            liv_listCD.Size = new Size(981, 443);
            liv_listCD.TabIndex = 7;
            liv_listCD.UseCompatibleStateImageBehavior = false;
            liv_listCD.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên Đĩa";
            columnHeader1.Width = 210;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Thể Loại";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Tình Trạng";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 95;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Giá Thuê";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Số Lượng";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 90;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Ngày Mượn";
            columnHeader6.TextAlign = HorizontalAlignment.Center;
            columnHeader6.Width = 126;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Ngày Trả";
            columnHeader7.TextAlign = HorizontalAlignment.Center;
            columnHeader7.Width = 126;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Thành Tiền";
            columnHeader8.TextAlign = HorizontalAlignment.Center;
            columnHeader8.Width = 104;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(32, 157);
            label5.Name = "label5";
            label5.Size = new Size(310, 28);
            label5.TabIndex = 5;
            label5.Text = "Danh Sách Đĩa Được Thuê";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(29, 164);
            label6.Name = "label6";
            label6.Size = new Size(634, 32);
            label6.TabIndex = 6;
            label6.Text = "______________________________________________________________";
            // 
            // btn_search
            // 
            btn_search.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_search.Location = new Point(712, 40);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(178, 63);
            btn_search.TabIndex = 4;
            btn_search.Text = "Tìm";
            btn_search.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(393, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(174, 31);
            textBox1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(278, 80);
            label4.Name = "label4";
            label4.Size = new Size(109, 23);
            label4.TabIndex = 2;
            label4.Text = "Số CCCD :";
            // 
            // txb_searchName
            // 
            txb_searchName.Location = new Point(392, 23);
            txb_searchName.Name = "txb_searchName";
            txb_searchName.Size = new Size(174, 31);
            txb_searchName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(303, 25);
            label3.Name = "label3";
            label3.Size = new Size(83, 23);
            label3.TabIndex = 0;
            label3.Text = "Họ Tên :";
            // 
            // fBill
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1830, 928);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1852, 984);
            MinimumSize = new Size(1852, 984);
            Name = "fBill";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thanh Toán";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgv_showAccount).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmud_discount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private DataGridView dtgv_showAccount;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private Button btn_search;
        private TextBox textBox1;
        private Label label4;
        private TextBox txb_searchName;
        private Label label3;
        private Button btn_pay;
        private ListView liv_listCD;
        private Label label5;
        private Label label6;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private TextBox txb_totalPrice;
        private Label label_totalPrice;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private TextBox txb_receive;
        private Label label8;
        private TextBox txb_deposit;
        private Label label7;
        private TextBox txb_payback;
        private Label label9;
        private NumericUpDown nmud_discount;
        private Label label10;
    }
}
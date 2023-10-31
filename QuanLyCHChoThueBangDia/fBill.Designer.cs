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
            btn_pay = new Button();
            liv_listCD = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
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
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(807, 701);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(dtgv_showAccount);
            panel3.Location = new Point(3, 69);
            panel3.Name = "panel3";
            panel3.Size = new Size(801, 629);
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
            dtgv_showAccount.Size = new Size(795, 623);
            dtgv_showAccount.TabIndex = 0;
            dtgv_showAccount.CellMouseClick += dtgv_showAccount_CellMouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(11, 15);
            label1.Name = "label1";
            label1.Size = new Size(385, 28);
            label1.TabIndex = 0;
            label1.Text = "Danh Sách Tài Khoản Đang Thuê";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(8, 22);
            label2.Name = "label2";
            label2.Size = new Size(444, 32);
            label2.TabIndex = 1;
            label2.Text = "___________________________________________";
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_pay);
            panel2.Controls.Add(liv_listCD);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(btn_search);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txb_searchName);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(825, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(737, 701);
            panel2.TabIndex = 1;
            // 
            // btn_pay
            // 
            btn_pay.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_pay.Location = new Point(521, 604);
            btn_pay.Name = "btn_pay";
            btn_pay.Size = new Size(178, 63);
            btn_pay.TabIndex = 8;
            btn_pay.Text = "Thanh Toán";
            btn_pay.UseVisualStyleBackColor = true;
            btn_pay.Click += btn_pay_Click;
            // 
            // liv_listCD
            // 
            liv_listCD.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            liv_listCD.GridLines = true;
            liv_listCD.Location = new Point(3, 219);
            liv_listCD.Name = "liv_listCD";
            liv_listCD.Size = new Size(727, 352);
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
            columnHeader6.Text = "Thành Tiền";
            columnHeader6.TextAlign = HorizontalAlignment.Center;
            columnHeader6.Width = 97;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(29, 157);
            label5.Name = "label5";
            label5.Size = new Size(244, 28);
            label5.TabIndex = 5;
            label5.Text = "Danh Sách Đĩa Thuê";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(26, 164);
            label6.Name = "label6";
            label6.Size = new Size(364, 32);
            label6.TabIndex = 6;
            label6.Text = "___________________________________";
            // 
            // btn_search
            // 
            btn_search.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_search.Location = new Point(521, 30);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(178, 63);
            btn_search.TabIndex = 4;
            btn_search.Text = "Tìm";
            btn_search.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(259, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(174, 31);
            textBox1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(144, 80);
            label4.Name = "label4";
            label4.Size = new Size(109, 23);
            label4.TabIndex = 2;
            label4.Text = "Số CCCD :";
            // 
            // txb_searchName
            // 
            txb_searchName.Location = new Point(258, 23);
            txb_searchName.Name = "txb_searchName";
            txb_searchName.Size = new Size(174, 31);
            txb_searchName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(169, 25);
            label3.Name = "label3";
            label3.Size = new Size(83, 23);
            label3.TabIndex = 0;
            label3.Text = "Họ Tên :";
            // 
            // fBill
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1574, 725);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fBill";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thanh Toán";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgv_showAccount).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
    }
}
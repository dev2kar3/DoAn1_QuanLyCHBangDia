namespace QuanLyCHChoThueBangDia
{
    partial class fRent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fRent));
            btn_rent = new Button();
            cb_category = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            cb_nameCD = new ComboBox();
            btn_addCD = new Button();
            nud_quantity = new NumericUpDown();
            liv_listRentCD = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label6 = new Label();
            txb_nameSearch = new TextBox();
            txb_identitySearch = new TextBox();
            dtgv_showMemberInfo = new DataGridView();
            btn_search = new Button();
            dp_fromDate = new DateTimePicker();
            dp_toDate = new DateTimePicker();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txb_totalDeposit = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nud_quantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgv_showMemberInfo).BeginInit();
            SuspendLayout();
            // 
            // btn_rent
            // 
            btn_rent.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_rent.Location = new Point(1659, 810);
            btn_rent.Name = "btn_rent";
            btn_rent.Size = new Size(179, 66);
            btn_rent.TabIndex = 22;
            btn_rent.Text = "Thuê";
            btn_rent.UseVisualStyleBackColor = true;
            btn_rent.Click += btn_rent_Click;
            // 
            // cb_category
            // 
            cb_category.FormattingEnabled = true;
            cb_category.Location = new Point(1326, 35);
            cb_category.Name = "cb_category";
            cb_category.Size = new Size(226, 33);
            cb_category.TabIndex = 24;
            cb_category.SelectedIndexChanged += cb_category_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(1230, 39);
            label4.Name = "label4";
            label4.Size = new Size(79, 23);
            label4.TabIndex = 25;
            label4.Text = "Thể Loại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(1230, 102);
            label5.Name = "label5";
            label5.Size = new Size(84, 23);
            label5.TabIndex = 27;
            label5.Text = "Tên Đĩa";
            // 
            // cb_nameCD
            // 
            cb_nameCD.FormattingEnabled = true;
            cb_nameCD.Location = new Point(1326, 98);
            cb_nameCD.Name = "cb_nameCD";
            cb_nameCD.Size = new Size(226, 33);
            cb_nameCD.TabIndex = 26;
            // 
            // btn_addCD
            // 
            btn_addCD.Location = new Point(1597, 48);
            btn_addCD.Name = "btn_addCD";
            btn_addCD.Size = new Size(159, 61);
            btn_addCD.TabIndex = 28;
            btn_addCD.Text = "Thêm Đĩa";
            btn_addCD.UseVisualStyleBackColor = true;
            btn_addCD.Click += btn_addCD_Click;
            // 
            // nud_quantity
            // 
            nud_quantity.Location = new Point(1781, 64);
            nud_quantity.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nud_quantity.Minimum = new decimal(new int[] { 10, 0, 0, int.MinValue });
            nud_quantity.Name = "nud_quantity";
            nud_quantity.Size = new Size(78, 31);
            nud_quantity.TabIndex = 29;
            nud_quantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // liv_listRentCD
            // 
            liv_listRentCD.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            liv_listRentCD.GridLines = true;
            liv_listRentCD.Location = new Point(878, 169);
            liv_listRentCD.Name = "liv_listRentCD";
            liv_listRentCD.Size = new Size(981, 518);
            liv_listRentCD.TabIndex = 30;
            liv_listRentCD.UseCompatibleStateImageBehavior = false;
            liv_listRentCD.View = View.Details;
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
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Tình Trạng";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Giá Thuê";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Số Lượng";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 95;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Ngày Mượn";
            columnHeader6.TextAlign = HorizontalAlignment.Center;
            columnHeader6.Width = 140;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Ngày Trả ";
            columnHeader7.TextAlign = HorizontalAlignment.Center;
            columnHeader7.Width = 142;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Giá Cọc";
            columnHeader8.TextAlign = HorizontalAlignment.Center;
            columnHeader8.Width = 100;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(11, 34);
            label1.Name = "label1";
            label1.Size = new Size(168, 28);
            label1.TabIndex = 31;
            label1.Text = "Tìm Tài Khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(11, 48);
            label2.Name = "label2";
            label2.Size = new Size(370, 23);
            label2.TabIndex = 32;
            label2.Text = "____________________________________";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(30, 157);
            label3.Name = "label3";
            label3.Size = new Size(109, 23);
            label3.TabIndex = 34;
            label3.Text = "Số CCCD :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(33, 108);
            label6.Name = "label6";
            label6.Size = new Size(83, 23);
            label6.TabIndex = 33;
            label6.Text = "Họ Tên :";
            // 
            // txb_nameSearch
            // 
            txb_nameSearch.Location = new Point(149, 108);
            txb_nameSearch.Name = "txb_nameSearch";
            txb_nameSearch.Size = new Size(173, 31);
            txb_nameSearch.TabIndex = 35;
            // 
            // txb_identitySearch
            // 
            txb_identitySearch.Location = new Point(149, 157);
            txb_identitySearch.Name = "txb_identitySearch";
            txb_identitySearch.Size = new Size(173, 31);
            txb_identitySearch.TabIndex = 36;
            // 
            // dtgv_showMemberInfo
            // 
            dtgv_showMemberInfo.BackgroundColor = SystemColors.ControlLight;
            dtgv_showMemberInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_showMemberInfo.Location = new Point(11, 217);
            dtgv_showMemberInfo.Name = "dtgv_showMemberInfo";
            dtgv_showMemberInfo.RowHeadersWidth = 62;
            dtgv_showMemberInfo.RowTemplate.Height = 33;
            dtgv_showMemberInfo.Size = new Size(829, 699);
            dtgv_showMemberInfo.TabIndex = 37;
            dtgv_showMemberInfo.CellMouseClick += dtgv_showMemberInfo_CellMouseClick;
            // 
            // btn_search
            // 
            btn_search.Location = new Point(403, 124);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(159, 46);
            btn_search.TabIndex = 38;
            btn_search.Text = "Tìm";
            btn_search.UseVisualStyleBackColor = true;
            // 
            // dp_fromDate
            // 
            dp_fromDate.Location = new Point(1066, 751);
            dp_fromDate.Name = "dp_fromDate";
            dp_fromDate.Size = new Size(300, 31);
            dp_fromDate.TabIndex = 39;
            dp_fromDate.ValueChanged += dp_fromDate_ValueChanged;
            // 
            // dp_toDate
            // 
            dp_toDate.Location = new Point(1066, 810);
            dp_toDate.Name = "dp_toDate";
            dp_toDate.Size = new Size(300, 31);
            dp_toDate.TabIndex = 40;
            dp_toDate.ValueChanged += dp_toDate_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(958, 814);
            label7.Name = "label7";
            label7.Size = new Size(103, 23);
            label7.TabIndex = 42;
            label7.Text = "Ngày Trả :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(934, 751);
            label8.Name = "label8";
            label8.Size = new Size(127, 23);
            label8.TabIndex = 41;
            label8.Text = "Ngày Mượn :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(1460, 731);
            label9.Name = "label9";
            label9.Size = new Size(107, 23);
            label9.TabIndex = 43;
            label9.Text = "Tổng Cọc :";
            // 
            // txb_totalDeposit
            // 
            txb_totalDeposit.Location = new Point(1573, 727);
            txb_totalDeposit.Name = "txb_totalDeposit";
            txb_totalDeposit.ReadOnly = true;
            txb_totalDeposit.Size = new Size(174, 31);
            txb_totalDeposit.TabIndex = 44;
            // 
            // fRent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1871, 928);
            Controls.Add(txb_totalDeposit);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(dp_toDate);
            Controls.Add(dp_fromDate);
            Controls.Add(btn_search);
            Controls.Add(dtgv_showMemberInfo);
            Controls.Add(txb_identitySearch);
            Controls.Add(txb_nameSearch);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(liv_listRentCD);
            Controls.Add(nud_quantity);
            Controls.Add(btn_addCD);
            Controls.Add(label5);
            Controls.Add(cb_nameCD);
            Controls.Add(label4);
            Controls.Add(cb_category);
            Controls.Add(btn_rent);
            Controls.Add(label2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fRent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thuê Đĩa";
            FormClosed += fRent_FormClosed;
            ((System.ComponentModel.ISupportInitialize)nud_quantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgv_showMemberInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_rent;
        private ComboBox cb_category;
        private Label label4;
        private Label label5;
        private ComboBox cb_nameCD;
        private Button btn_addCD;
        private NumericUpDown nud_quantity;
        private ListView liv_listRentCD;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label6;
        private TextBox txb_nameSearch;
        private TextBox txb_identitySearch;
        private DataGridView dtgv_showMemberInfo;
        private Button btn_search;
        private DateTimePicker dp_fromDate;
        private DateTimePicker dp_toDate;
        private Label label7;
        private Label label8;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private Label label9;
        private TextBox txb_totalDeposit;
    }
}
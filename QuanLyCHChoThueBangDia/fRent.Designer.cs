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
            label_memberName = new Label();
            txb_memberName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txb_memberPhone = new TextBox();
            label_memberPhone = new Label();
            txb_memberIdentity = new TextBox();
            label_memberIdentify = new Label();
            btn_rent = new Button();
            label1 = new Label();
            cb_category = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            cb_nameCD = new ComboBox();
            btn_addCD = new Button();
            nud_quantity = new NumericUpDown();
            liv_listRentCD = new ListView();
            ((System.ComponentModel.ISupportInitialize)nud_quantity).BeginInit();
            SuspendLayout();
            // 
            // label_memberName
            // 
            label_memberName.AutoSize = true;
            label_memberName.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_memberName.Location = new Point(30, 106);
            label_memberName.Name = "label_memberName";
            label_memberName.Size = new Size(72, 23);
            label_memberName.TabIndex = 0;
            label_memberName.Text = "Họ Tên";
            // 
            // txb_memberName
            // 
            txb_memberName.Location = new Point(162, 98);
            txb_memberName.Name = "txb_memberName";
            txb_memberName.Size = new Size(184, 31);
            txb_memberName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(30, 34);
            label2.Name = "label2";
            label2.Size = new Size(229, 28);
            label2.TabIndex = 2;
            label2.Text = "Thông Tin Cá Nhân";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 53);
            label3.Name = "label3";
            label3.Size = new Size(600, 25);
            label3.TabIndex = 3;
            label3.Text = "____________________________________________________________________________________";
            // 
            // txb_memberPhone
            // 
            txb_memberPhone.Location = new Point(162, 155);
            txb_memberPhone.Name = "txb_memberPhone";
            txb_memberPhone.Size = new Size(184, 31);
            txb_memberPhone.TabIndex = 5;
            // 
            // label_memberPhone
            // 
            label_memberPhone.AutoSize = true;
            label_memberPhone.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_memberPhone.Location = new Point(30, 159);
            label_memberPhone.Name = "label_memberPhone";
            label_memberPhone.Size = new Size(126, 23);
            label_memberPhone.TabIndex = 4;
            label_memberPhone.Text = "Số Điện Thoại";
            // 
            // txb_memberIdentity
            // 
            txb_memberIdentity.Location = new Point(399, 155);
            txb_memberIdentity.Name = "txb_memberIdentity";
            txb_memberIdentity.Size = new Size(210, 31);
            txb_memberIdentity.TabIndex = 7;
            // 
            // label_memberIdentify
            // 
            label_memberIdentify.AutoSize = true;
            label_memberIdentify.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_memberIdentify.Location = new Point(399, 102);
            label_memberIdentify.Name = "label_memberIdentify";
            label_memberIdentify.Size = new Size(109, 23);
            label_memberIdentify.TabIndex = 6;
            label_memberIdentify.Text = "Số CCCD :";
            // 
            // btn_rent
            // 
            btn_rent.Location = new Point(489, 737);
            btn_rent.Name = "btn_rent";
            btn_rent.Size = new Size(159, 46);
            btn_rent.TabIndex = 22;
            btn_rent.Text = "Thuê";
            btn_rent.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 203);
            label1.Name = "label1";
            label1.Size = new Size(600, 25);
            label1.TabIndex = 23;
            label1.Text = "____________________________________________________________________________________";
            // 
            // cb_category
            // 
            cb_category.FormattingEnabled = true;
            cb_category.Location = new Point(137, 269);
            cb_category.Name = "cb_category";
            cb_category.Size = new Size(226, 33);
            cb_category.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(30, 273);
            label4.Name = "label4";
            label4.Size = new Size(83, 23);
            label4.TabIndex = 25;
            label4.Text = "Thể Loại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(30, 336);
            label5.Name = "label5";
            label5.Size = new Size(82, 23);
            label5.TabIndex = 27;
            label5.Text = "Tên Đĩa";
            // 
            // cb_nameCD
            // 
            cb_nameCD.FormattingEnabled = true;
            cb_nameCD.Location = new Point(137, 332);
            cb_nameCD.Name = "cb_nameCD";
            cb_nameCD.Size = new Size(226, 33);
            cb_nameCD.TabIndex = 26;
            // 
            // btn_addCD
            // 
            btn_addCD.Location = new Point(378, 287);
            btn_addCD.Name = "btn_addCD";
            btn_addCD.Size = new Size(159, 61);
            btn_addCD.TabIndex = 28;
            btn_addCD.Text = "Thêm Đĩa";
            btn_addCD.UseVisualStyleBackColor = true;
            // 
            // nud_quantity
            // 
            nud_quantity.Location = new Point(552, 303);
            nud_quantity.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            nud_quantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nud_quantity.Name = "nud_quantity";
            nud_quantity.Size = new Size(78, 31);
            nud_quantity.TabIndex = 29;
            nud_quantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // liv_listRentCD
            // 
            liv_listRentCD.Location = new Point(30, 405);
            liv_listRentCD.Name = "liv_listRentCD";
            liv_listRentCD.Size = new Size(600, 307);
            liv_listRentCD.TabIndex = 30;
            liv_listRentCD.UseCompatibleStateImageBehavior = false;
            // 
            // fRent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 795);
            Controls.Add(liv_listRentCD);
            Controls.Add(nud_quantity);
            Controls.Add(btn_addCD);
            Controls.Add(label5);
            Controls.Add(cb_nameCD);
            Controls.Add(label4);
            Controls.Add(cb_category);
            Controls.Add(label1);
            Controls.Add(btn_rent);
            Controls.Add(txb_memberIdentity);
            Controls.Add(label_memberIdentify);
            Controls.Add(txb_memberPhone);
            Controls.Add(label_memberPhone);
            Controls.Add(label2);
            Controls.Add(txb_memberName);
            Controls.Add(label_memberName);
            Controls.Add(label3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fRent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thuê Đĩa";
            ((System.ComponentModel.ISupportInitialize)nud_quantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_memberName;
        private TextBox txb_memberName;
        private Label label2;
        private Label label3;
        private TextBox txb_memberPhone;
        private Label label_memberPhone;
        private TextBox txb_memberIdentity;
        private Label label_memberIdentify;
        private Button btn_rent;
        private Label label1;
        private ComboBox cb_category;
        private Label label4;
        private Label label5;
        private ComboBox cb_nameCD;
        private Button btn_addCD;
        private NumericUpDown nud_quantity;
        private ListView liv_listRentCD;
    }
}
namespace QuanLyCHChoThueBangDia
{
    partial class fCheckAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCheckAccount));
            panel1 = new Panel();
            btn_check = new Button();
            cb_gender = new ComboBox();
            label_gender = new Label();
            txb_phoneNumber = new TextBox();
            label_phoneNumber = new Label();
            txb_address = new TextBox();
            label_address = new Label();
            txb_identify = new TextBox();
            label_identify = new Label();
            txb_name = new TextBox();
            label_name = new Label();
            panel2 = new Panel();
            dtgv_accountChecker = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_accountChecker).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_check);
            panel1.Controls.Add(cb_gender);
            panel1.Controls.Add(label_gender);
            panel1.Controls.Add(txb_phoneNumber);
            panel1.Controls.Add(label_phoneNumber);
            panel1.Controls.Add(txb_address);
            panel1.Controls.Add(label_address);
            panel1.Controls.Add(txb_identify);
            panel1.Controls.Add(label_identify);
            panel1.Controls.Add(txb_name);
            panel1.Controls.Add(label_name);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1089, 140);
            panel1.TabIndex = 11;
            // 
            // btn_check
            // 
            btn_check.ForeColor = SystemColors.ActiveCaptionText;
            btn_check.Location = new Point(825, 64);
            btn_check.Name = "btn_check";
            btn_check.Size = new Size(194, 48);
            btn_check.TabIndex = 21;
            btn_check.Text = "Kiểm Tra";
            btn_check.UseVisualStyleBackColor = true;
            // 
            // cb_gender
            // 
            cb_gender.FormattingEnabled = true;
            cb_gender.Items.AddRange(new object[] { "Nam", "Nữ" });
            cb_gender.Location = new Point(514, 73);
            cb_gender.Name = "cb_gender";
            cb_gender.Size = new Size(182, 33);
            cb_gender.TabIndex = 20;
            // 
            // label_gender
            // 
            label_gender.AutoSize = true;
            label_gender.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_gender.Location = new Point(423, 81);
            label_gender.Name = "label_gender";
            label_gender.Size = new Size(85, 23);
            label_gender.TabIndex = 19;
            label_gender.Text = "Giới Tính";
            // 
            // txb_phoneNumber
            // 
            txb_phoneNumber.Location = new Point(152, 73);
            txb_phoneNumber.Name = "txb_phoneNumber";
            txb_phoneNumber.Size = new Size(223, 31);
            txb_phoneNumber.TabIndex = 18;
            // 
            // label_phoneNumber
            // 
            label_phoneNumber.AutoSize = true;
            label_phoneNumber.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_phoneNumber.Location = new Point(18, 77);
            label_phoneNumber.Name = "label_phoneNumber";
            label_phoneNumber.Size = new Size(126, 23);
            label_phoneNumber.TabIndex = 17;
            label_phoneNumber.Text = "Số Điện Thoại";
            // 
            // txb_address
            // 
            txb_address.Location = new Point(795, 15);
            txb_address.Name = "txb_address";
            txb_address.Size = new Size(256, 31);
            txb_address.TabIndex = 16;
            // 
            // label_address
            // 
            label_address.AutoSize = true;
            label_address.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_address.Location = new Point(707, 23);
            label_address.Name = "label_address";
            label_address.Size = new Size(82, 23);
            label_address.TabIndex = 15;
            label_address.Text = "Địa Chỉ";
            // 
            // txb_identify
            // 
            txb_identify.Location = new Point(438, 19);
            txb_identify.Name = "txb_identify";
            txb_identify.Size = new Size(223, 31);
            txb_identify.TabIndex = 14;
            // 
            // label_identify
            // 
            label_identify.AutoSize = true;
            label_identify.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_identify.Location = new Point(334, 23);
            label_identify.Name = "label_identify";
            label_identify.Size = new Size(98, 23);
            label_identify.TabIndex = 13;
            label_identify.Text = "Số CCCD";
            // 
            // txb_name
            // 
            txb_name.Location = new Point(67, 19);
            txb_name.Name = "txb_name";
            txb_name.Size = new Size(223, 31);
            txb_name.TabIndex = 12;
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_name.Location = new Point(18, 23);
            label_name.Name = "label_name";
            label_name.Size = new Size(43, 23);
            label_name.TabIndex = 11;
            label_name.Text = "Tên";
            // 
            // panel2
            // 
            panel2.Controls.Add(dtgv_accountChecker);
            panel2.Location = new Point(12, 158);
            panel2.Name = "panel2";
            panel2.Size = new Size(1089, 455);
            panel2.TabIndex = 12;
            // 
            // dtgv_accountChecker
            // 
            dtgv_accountChecker.BackgroundColor = SystemColors.ControlLight;
            dtgv_accountChecker.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_accountChecker.Location = new Point(0, 0);
            dtgv_accountChecker.Name = "dtgv_accountChecker";
            dtgv_accountChecker.RowHeadersWidth = 62;
            dtgv_accountChecker.RowTemplate.Height = 33;
            dtgv_accountChecker.Size = new Size(1086, 452);
            dtgv_accountChecker.TabIndex = 0;
            // 
            // fCheckAccount
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1113, 625);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fCheckAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fCheckAccount";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgv_accountChecker).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_check;
        private ComboBox cb_gender;
        private Label label_gender;
        private TextBox txb_phoneNumber;
        private Label label_phoneNumber;
        private TextBox txb_address;
        private Label label_address;
        private TextBox txb_identify;
        private Label label_identify;
        private TextBox txb_name;
        private Label label_name;
        private Panel panel2;
        private DataGridView dtgv_accountChecker;
    }
}
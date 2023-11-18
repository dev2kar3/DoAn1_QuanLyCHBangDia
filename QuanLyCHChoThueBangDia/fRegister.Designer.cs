namespace QuanLyCHChoThueBangDia
{
    partial class fRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fRegister));
            panel_register = new Panel();
            cb_gender = new ComboBox();
            btn_register = new Button();
            txb_identify = new TextBox();
            label_identify = new Label();
            label_gender = new Label();
            txb_address = new TextBox();
            label_address = new Label();
            txb_phoneNumber = new TextBox();
            label_phoneNumber = new Label();
            txb_name = new TextBox();
            label1 = new Label();
            label_name = new Label();
            label2 = new Label();
            panel_register.SuspendLayout();
            SuspendLayout();
            // 
            // panel_register
            // 
            panel_register.BackColor = SystemColors.ControlLight;
            panel_register.Controls.Add(cb_gender);
            panel_register.Controls.Add(btn_register);
            panel_register.Controls.Add(txb_identify);
            panel_register.Controls.Add(label_identify);
            panel_register.Controls.Add(label_gender);
            panel_register.Controls.Add(txb_address);
            panel_register.Controls.Add(label_address);
            panel_register.Controls.Add(txb_phoneNumber);
            panel_register.Controls.Add(label_phoneNumber);
            panel_register.Controls.Add(txb_name);
            panel_register.Controls.Add(label1);
            panel_register.Controls.Add(label_name);
            panel_register.Controls.Add(label2);
            panel_register.Location = new Point(12, 12);
            panel_register.Name = "panel_register";
            panel_register.Size = new Size(795, 418);
            panel_register.TabIndex = 0;
            // 
            // cb_gender
            // 
            cb_gender.FormattingEnabled = true;
            cb_gender.Items.AddRange(new object[] { "Nam ", "Nữ" });
            cb_gender.Location = new Point(425, 237);
            cb_gender.Name = "cb_gender";
            cb_gender.Size = new Size(272, 33);
            cb_gender.TabIndex = 13;
            // 
            // btn_register
            // 
            btn_register.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_register.Location = new Point(425, 323);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(182, 49);
            btn_register.TabIndex = 12;
            btn_register.Text = "Đăng Ký";
            btn_register.UseVisualStyleBackColor = true;
            // 
            // txb_identify
            // 
            txb_identify.Location = new Point(27, 341);
            txb_identify.Name = "txb_identify";
            txb_identify.Size = new Size(272, 31);
            txb_identify.TabIndex = 11;
            // 
            // label_identify
            // 
            label_identify.AutoSize = true;
            label_identify.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_identify.Location = new Point(27, 300);
            label_identify.Name = "label_identify";
            label_identify.Size = new Size(124, 30);
            label_identify.TabIndex = 10;
            label_identify.Text = "Số CCCD";
            // 
            // label_gender
            // 
            label_gender.AutoSize = true;
            label_gender.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_gender.Location = new Point(425, 198);
            label_gender.Name = "label_gender";
            label_gender.Size = new Size(114, 30);
            label_gender.TabIndex = 8;
            label_gender.Text = "Giới Tính";
            // 
            // txb_address
            // 
            txb_address.Location = new Point(425, 138);
            txb_address.Name = "txb_address";
            txb_address.Size = new Size(272, 31);
            txb_address.TabIndex = 7;
            // 
            // label_address
            // 
            label_address.AutoSize = true;
            label_address.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_address.Location = new Point(425, 97);
            label_address.Name = "label_address";
            label_address.Size = new Size(102, 30);
            label_address.TabIndex = 6;
            label_address.Text = "Địa Chỉ";
            // 
            // txb_phoneNumber
            // 
            txb_phoneNumber.Location = new Point(27, 239);
            txb_phoneNumber.Name = "txb_phoneNumber";
            txb_phoneNumber.Size = new Size(272, 31);
            txb_phoneNumber.TabIndex = 5;
            // 
            // label_phoneNumber
            // 
            label_phoneNumber.AutoSize = true;
            label_phoneNumber.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_phoneNumber.Location = new Point(27, 198);
            label_phoneNumber.Name = "label_phoneNumber";
            label_phoneNumber.Size = new Size(168, 30);
            label_phoneNumber.TabIndex = 4;
            label_phoneNumber.Text = "Số Điện Thoại";
            // 
            // txb_name
            // 
            txb_name.Location = new Point(27, 138);
            txb_name.Name = "txb_name";
            txb_name.Size = new Size(272, 31);
            txb_name.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(21, 23);
            label1.Name = "label1";
            label1.Size = new Size(150, 38);
            label1.TabIndex = 1;
            label1.Text = "Đăng Ký";
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_name.Location = new Point(21, 97);
            label_name.Name = "label_name";
            label_name.Size = new Size(92, 30);
            label_name.TabIndex = 0;
            label_name.Text = "Họ Tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(21, 23);
            label2.Name = "label2";
            label2.Size = new Size(312, 54);
            label2.TabIndex = 2;
            label2.Text = "_________________";
            // 
            // fRegister
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(819, 443);
            Controls.Add(panel_register);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(841, 499);
            MinimumSize = new Size(841, 499);
            Name = "fRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Ký Thành Viên";
            panel_register.ResumeLayout(false);
            panel_register.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_register;
        private Label label1;
        private Label label_name;
        private Label label2;
        private TextBox txb_phoneNumber;
        private Label label_phoneNumber;
        private TextBox txb_name;
        private TextBox txb_address;
        private Label label_address;
        private Label label_gender;
        private TextBox txb_identify;
        private Label label_identify;
        private Button btn_register;
        private ComboBox cb_gender;
    }
}
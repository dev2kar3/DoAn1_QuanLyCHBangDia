namespace QuanLyCHChoThueBangDia
{
    partial class fLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            panel1 = new Panel();
            btnExit = new Button();
            btnLogin = new Button();
            panel3 = new Panel();
            txbPassWord = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            txbUserName = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(6, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(397, 219);
            panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(49, 176);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 3;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(232, 176);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 34);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Đăng Nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(txbPassWord);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(3, 96);
            panel3.Name = "panel3";
            panel3.Size = new Size(391, 67);
            panel3.TabIndex = 1;
            // 
            // txbPassWord
            // 
            txbPassWord.Location = new Point(12, 32);
            txbPassWord.Name = "txbPassWord";
            txbPassWord.Size = new Size(368, 31);
            txbPassWord.TabIndex = 1;
            txbPassWord.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 0);
            label2.Name = "label2";
            label2.Size = new Size(136, 29);
            label2.TabIndex = 0;
            label2.Text = "Mật Khẩu :";
            // 
            // panel2
            // 
            panel2.Controls.Add(txbUserName);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(391, 77);
            panel2.TabIndex = 0;
            // 
            // txbUserName
            // 
            txbUserName.Location = new Point(12, 44);
            txbUserName.Name = "txbUserName";
            txbUserName.Size = new Size(368, 31);
            txbUserName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(204, 29);
            label1.TabIndex = 0;
            label1.Text = "Tên Đăng Nhập :";
            // 
            // fLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 229);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(432, 285);
            MinimumSize = new Size(432, 285);
            Name = "fLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Đăng Nhập";
            FormClosing += fLogin_FormClosing;
            Load += fLogin_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private TextBox txbUserName;
        private Panel panel3;
        private TextBox txbPassWord;
        private Label label2;
        private Button btnLogin;
        private Button btnExit;
    }
}
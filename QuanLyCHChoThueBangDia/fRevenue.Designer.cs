namespace QuanLyCHChoThueBangDia
{
    partial class fRevenue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fRevenue));
            panel1 = new Panel();
            panel3 = new Panel();
            btnView = new Button();
            dtpkToDate = new DateTimePicker();
            dtpkFromDate = new DateTimePicker();
            panel2 = new Panel();
            dtgvRevenue = new DataGridView();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvRevenue).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(820, 601);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnView);
            panel3.Controls.Add(dtpkToDate);
            panel3.Controls.Add(dtpkFromDate);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(816, 70);
            panel3.TabIndex = 1;
            // 
            // btnView
            // 
            btnView.Location = new Point(354, 13);
            btnView.Name = "btnView";
            btnView.Size = new Size(116, 48);
            btnView.TabIndex = 2;
            btnView.Text = "Thống Kê";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // dtpkToDate
            // 
            dtpkToDate.Location = new Point(516, 20);
            dtpkToDate.Name = "dtpkToDate";
            dtpkToDate.Size = new Size(300, 31);
            dtpkToDate.TabIndex = 1;
            // 
            // dtpkFromDate
            // 
            dtpkFromDate.Location = new Point(3, 20);
            dtpkFromDate.Name = "dtpkFromDate";
            dtpkFromDate.Size = new Size(300, 31);
            dtpkFromDate.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(dtgvRevenue);
            panel2.Location = new Point(3, 79);
            panel2.Name = "panel2";
            panel2.Size = new Size(816, 519);
            panel2.TabIndex = 0;
            // 
            // dtgvRevenue
            // 
            dtgvRevenue.AllowUserToAddRows = false;
            dtgvRevenue.AllowUserToDeleteRows = false;
            dtgvRevenue.AllowUserToResizeColumns = false;
            dtgvRevenue.AllowUserToResizeRows = false;
            dtgvRevenue.BackgroundColor = SystemColors.ControlLight;
            dtgvRevenue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvRevenue.Location = new Point(3, 3);
            dtgvRevenue.Name = "dtgvRevenue";
            dtgvRevenue.RowHeadersWidth = 62;
            dtgvRevenue.RowTemplate.Height = 33;
            dtgvRevenue.Size = new Size(810, 513);
            dtgvRevenue.TabIndex = 0;
            // 
            // fRevenue
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 625);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fRevenue";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Doanh Thu";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvRevenue).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Button btnView;
        private DateTimePicker dtpkToDate;
        private DateTimePicker dtpkFromDate;
        private Panel panel2;
        private DataGridView dtgvRevenue;
    }
}
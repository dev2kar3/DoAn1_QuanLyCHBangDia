namespace QuanLyCHChoThueBangDia
{
    partial class fSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSales));
            pb_sales = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pb_sales).BeginInit();
            SuspendLayout();
            // 
            // pb_sales
            // 
            pb_sales.Image = (Image)resources.GetObject("pb_sales.Image");
            pb_sales.Location = new Point(-2, 0);
            pb_sales.Name = "pb_sales";
            pb_sales.Size = new Size(918, 538);
            pb_sales.TabIndex = 0;
            pb_sales.TabStop = false;
            // 
            // fSales
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 538);
            Controls.Add(pb_sales);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(938, 594);
            MinimumSize = new Size(938, 594);
            Name = "fSales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fSales";
            ((System.ComponentModel.ISupportInitialize)pb_sales).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pb_sales;
    }
}
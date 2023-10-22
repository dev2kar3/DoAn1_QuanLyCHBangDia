namespace QuanLyCHChoThueBangDia
{
    partial class fImportDisc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fImportDisc));
            label_name = new Label();
            txb_name = new TextBox();
            txb_category = new TextBox();
            label_category = new Label();
            txb_status = new TextBox();
            label_status = new Label();
            txb_price = new TextBox();
            label_price = new Label();
            txb_quantity = new TextBox();
            label_quantity = new Label();
            txb_comp = new TextBox();
            label_comp = new Label();
            btn_addDisc = new Button();
            SuspendLayout();
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_name.Location = new Point(60, 28);
            label_name.Name = "label_name";
            label_name.Size = new Size(84, 23);
            label_name.TabIndex = 0;
            label_name.Text = "Tên Đĩa";
            // 
            // txb_name
            // 
            txb_name.Location = new Point(60, 68);
            txb_name.Name = "txb_name";
            txb_name.Size = new Size(221, 31);
            txb_name.TabIndex = 1;
            // 
            // txb_category
            // 
            txb_category.Location = new Point(60, 163);
            txb_category.Name = "txb_category";
            txb_category.Size = new Size(221, 31);
            txb_category.TabIndex = 3;
            // 
            // label_category
            // 
            label_category.AutoSize = true;
            label_category.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_category.Location = new Point(60, 123);
            label_category.Name = "label_category";
            label_category.Size = new Size(79, 23);
            label_category.TabIndex = 2;
            label_category.Text = "Thể Loại";
            // 
            // txb_status
            // 
            txb_status.Location = new Point(384, 68);
            txb_status.Name = "txb_status";
            txb_status.Size = new Size(221, 31);
            txb_status.TabIndex = 5;
            // 
            // label_status
            // 
            label_status.AutoSize = true;
            label_status.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_status.Location = new Point(384, 28);
            label_status.Name = "label_status";
            label_status.Size = new Size(101, 23);
            label_status.TabIndex = 4;
            label_status.Text = "Tình Trạng";
            // 
            // txb_price
            // 
            txb_price.Location = new Point(384, 163);
            txb_price.Name = "txb_price";
            txb_price.Size = new Size(221, 31);
            txb_price.TabIndex = 7;
            // 
            // label_price
            // 
            label_price.AutoSize = true;
            label_price.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_price.Location = new Point(384, 123);
            label_price.Name = "label_price";
            label_price.Size = new Size(44, 23);
            label_price.TabIndex = 6;
            label_price.Text = "Giá";
            // 
            // txb_quantity
            // 
            txb_quantity.Location = new Point(60, 260);
            txb_quantity.Name = "txb_quantity";
            txb_quantity.Size = new Size(221, 31);
            txb_quantity.TabIndex = 9;
            // 
            // label_quantity
            // 
            label_quantity.AutoSize = true;
            label_quantity.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_quantity.Location = new Point(60, 220);
            label_quantity.Name = "label_quantity";
            label_quantity.Size = new Size(87, 23);
            label_quantity.TabIndex = 8;
            label_quantity.Text = "Số Lượng";
            // 
            // txb_comp
            // 
            txb_comp.Location = new Point(384, 260);
            txb_comp.Name = "txb_comp";
            txb_comp.Size = new Size(221, 31);
            txb_comp.TabIndex = 11;
            // 
            // label_comp
            // 
            label_comp.AutoSize = true;
            label_comp.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_comp.Location = new Point(384, 220);
            label_comp.Name = "label_comp";
            label_comp.Size = new Size(146, 23);
            label_comp.TabIndex = 10;
            label_comp.Text = "Hãng Sản Xuất";
            // 
            // btn_addDisc
            // 
            btn_addDisc.Location = new Point(456, 317);
            btn_addDisc.Name = "btn_addDisc";
            btn_addDisc.Size = new Size(135, 46);
            btn_addDisc.TabIndex = 12;
            btn_addDisc.Text = "Thêm Đĩa";
            btn_addDisc.UseVisualStyleBackColor = true;
            // 
            // fImportDisc
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 404);
            Controls.Add(btn_addDisc);
            Controls.Add(txb_comp);
            Controls.Add(label_comp);
            Controls.Add(txb_quantity);
            Controls.Add(label_quantity);
            Controls.Add(txb_price);
            Controls.Add(label_price);
            Controls.Add(txb_status);
            Controls.Add(label_status);
            Controls.Add(txb_category);
            Controls.Add(label_category);
            Controls.Add(txb_name);
            Controls.Add(label_name);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(690, 460);
            MinimumSize = new Size(690, 460);
            Name = "fImportDisc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhập Đĩa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_name;
        private TextBox txb_name;
        private TextBox txb_category;
        private Label label_category;
        private TextBox txb_status;
        private Label label_status;
        private TextBox txb_price;
        private Label label_price;
        private TextBox txb_quantity;
        private Label label_quantity;
        private TextBox txb_comp;
        private Label label_comp;
        private Button btn_addDisc;
    }
}
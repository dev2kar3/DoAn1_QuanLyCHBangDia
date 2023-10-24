namespace QuanLyCHChoThueBangDia
{
    partial class fCDManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCDManager));
            tc_manager = new TabControl();
            tp_viewCD = new TabPage();
            panel_searchSlice = new Panel();
            txb_price = new TextBox();
            label_price = new Label();
            txb_categery = new TextBox();
            label_category = new Label();
            txb_cdName = new TextBox();
            label_nameCD = new Label();
            txb_id = new TextBox();
            label_idCategory = new Label();
            txb_search = new TextBox();
            button_search = new Button();
            panel1 = new Panel();
            dtgv_cdView = new DataGridView();
            tp_edit = new TabPage();
            tp_delete = new TabPage();
            tc_manager.SuspendLayout();
            tp_viewCD.SuspendLayout();
            panel_searchSlice.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_cdView).BeginInit();
            SuspendLayout();
            // 
            // tc_manager
            // 
            tc_manager.Controls.Add(tp_viewCD);
            tc_manager.Controls.Add(tp_edit);
            tc_manager.Controls.Add(tp_delete);
            tc_manager.Location = new Point(9, 12);
            tc_manager.Margin = new Padding(0);
            tc_manager.Name = "tc_manager";
            tc_manager.Padding = new Point(0, 0);
            tc_manager.SelectedIndex = 0;
            tc_manager.Size = new Size(1292, 840);
            tc_manager.TabIndex = 0;
            // 
            // tp_viewCD
            // 
            tp_viewCD.BackColor = Color.Transparent;
            tp_viewCD.Controls.Add(panel_searchSlice);
            tp_viewCD.Controls.Add(panel1);
            tp_viewCD.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tp_viewCD.Location = new Point(4, 34);
            tp_viewCD.Margin = new Padding(0);
            tp_viewCD.Name = "tp_viewCD";
            tp_viewCD.Size = new Size(1284, 802);
            tp_viewCD.TabIndex = 0;
            tp_viewCD.Text = "Xem ";
            // 
            // panel_searchSlice
            // 
            panel_searchSlice.BackColor = Color.Gainsboro;
            panel_searchSlice.Controls.Add(txb_price);
            panel_searchSlice.Controls.Add(label_price);
            panel_searchSlice.Controls.Add(txb_categery);
            panel_searchSlice.Controls.Add(label_category);
            panel_searchSlice.Controls.Add(txb_cdName);
            panel_searchSlice.Controls.Add(label_nameCD);
            panel_searchSlice.Controls.Add(txb_id);
            panel_searchSlice.Controls.Add(label_idCategory);
            panel_searchSlice.Controls.Add(txb_search);
            panel_searchSlice.Controls.Add(button_search);
            panel_searchSlice.Location = new Point(979, 3);
            panel_searchSlice.Name = "panel_searchSlice";
            panel_searchSlice.Size = new Size(300, 796);
            panel_searchSlice.TabIndex = 1;
            // 
            // txb_price
            // 
            txb_price.Location = new Point(104, 218);
            txb_price.Name = "txb_price";
            txb_price.Size = new Size(189, 30);
            txb_price.TabIndex = 9;
            // 
            // label_price
            // 
            label_price.AutoSize = true;
            label_price.Location = new Point(10, 221);
            label_price.Name = "label_price";
            label_price.Size = new Size(88, 21);
            label_price.TabIndex = 8;
            label_price.Text = "Giá Thuê";
            // 
            // txb_categery
            // 
            txb_categery.Location = new Point(114, 167);
            txb_categery.Name = "txb_categery";
            txb_categery.Size = new Size(179, 30);
            txb_categery.TabIndex = 7;
            // 
            // label_category
            // 
            label_category.AutoSize = true;
            label_category.Location = new Point(10, 170);
            label_category.Name = "label_category";
            label_category.Size = new Size(98, 21);
            label_category.TabIndex = 6;
            label_category.Text = "Danh Mục";
            // 
            // txb_cdName
            // 
            txb_cdName.Location = new Point(91, 117);
            txb_cdName.Name = "txb_cdName";
            txb_cdName.Size = new Size(202, 30);
            txb_cdName.TabIndex = 5;
            // 
            // label_nameCD
            // 
            label_nameCD.AutoSize = true;
            label_nameCD.Location = new Point(10, 120);
            label_nameCD.Name = "label_nameCD";
            label_nameCD.Size = new Size(75, 21);
            label_nameCD.TabIndex = 4;
            label_nameCD.Text = "Tên Đĩa";
            // 
            // txb_id
            // 
            txb_id.Location = new Point(44, 66);
            txb_id.Name = "txb_id";
            txb_id.ReadOnly = true;
            txb_id.Size = new Size(249, 30);
            txb_id.TabIndex = 3;
            // 
            // label_idCategory
            // 
            label_idCategory.AutoSize = true;
            label_idCategory.Location = new Point(10, 69);
            label_idCategory.Name = "label_idCategory";
            label_idCategory.Size = new Size(28, 21);
            label_idCategory.TabIndex = 2;
            label_idCategory.Text = "ID";
            // 
            // txb_search
            // 
            txb_search.Location = new Point(8, 17);
            txb_search.Name = "txb_search";
            txb_search.Size = new Size(167, 30);
            txb_search.TabIndex = 1;
            // 
            // button_search
            // 
            button_search.Location = new Point(181, 13);
            button_search.Name = "button_search";
            button_search.Size = new Size(112, 34);
            button_search.TabIndex = 0;
            button_search.Text = "Tìm";
            button_search.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(dtgv_cdView);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(970, 796);
            panel1.TabIndex = 0;
            // 
            // dtgv_cdView
            // 
            dtgv_cdView.AllowUserToAddRows = false;
            dtgv_cdView.AllowUserToDeleteRows = false;
            dtgv_cdView.BackgroundColor = SystemColors.ControlLight;
            dtgv_cdView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_cdView.Location = new Point(3, 3);
            dtgv_cdView.Name = "dtgv_cdView";
            dtgv_cdView.RowHeadersWidth = 62;
            dtgv_cdView.RowTemplate.Height = 33;
            dtgv_cdView.Size = new Size(963, 790);
            dtgv_cdView.TabIndex = 0;
            dtgv_cdView.Click += dtgv_cdView_Click;
            // 
            // tp_edit
            // 
            tp_edit.Location = new Point(4, 34);
            tp_edit.Name = "tp_edit";
            tp_edit.Padding = new Padding(3);
            tp_edit.Size = new Size(1284, 802);
            tp_edit.TabIndex = 1;
            tp_edit.Text = "Sửa";
            tp_edit.UseVisualStyleBackColor = true;
            // 
            // tp_delete
            // 
            tp_delete.BackColor = Color.Transparent;
            tp_delete.BackgroundImageLayout = ImageLayout.None;
            tp_delete.Location = new Point(4, 34);
            tp_delete.Name = "tp_delete";
            tp_delete.Padding = new Padding(3);
            tp_delete.Size = new Size(1284, 802);
            tp_delete.TabIndex = 2;
            tp_delete.Text = "Xóa";
            // 
            // fCDManager
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1312, 861);
            Controls.Add(tc_manager);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fCDManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Đĩa";
            tc_manager.ResumeLayout(false);
            tp_viewCD.ResumeLayout(false);
            panel_searchSlice.ResumeLayout(false);
            panel_searchSlice.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgv_cdView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tc_manager;
        private TabPage tp_viewCD;
        private TabPage tp_edit;
        private TabPage tp_delete;
        private Panel panel_searchSlice;
        private Panel panel1;
        private TextBox txb_id;
        private Label label_idCategory;
        private TextBox txb_search;
        private Button button_search;
        private TextBox txb_price;
        private Label label_price;
        private TextBox txb_categery;
        private Label label_category;
        private TextBox txb_cdName;
        private Label label_nameCD;
        private DataGridView dtgv_cdView;
    }
}
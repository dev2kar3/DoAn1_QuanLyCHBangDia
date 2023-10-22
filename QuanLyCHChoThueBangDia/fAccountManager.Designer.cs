namespace QuanLyCHChoThueBangDia
{
    partial class fAccountManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAccountManager));
            tp_delete = new TabPage();
            panel_viewControl = new Panel();
            dtgv_member = new DataGridView();
            tp_edit = new TabPage();
            txb_identifyNumber = new TextBox();
            label_price = new Label();
            txb_phoneNumber = new TextBox();
            label_category = new Label();
            txb_memberName = new TextBox();
            tp_viewCD = new TabPage();
            panel_searchSlice = new Panel();
            label_memberName = new Label();
            txb_id = new TextBox();
            label_idMember = new Label();
            txb_search = new TextBox();
            button_search = new Button();
            tc_manager = new TabControl();
            panel_viewControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_member).BeginInit();
            tp_viewCD.SuspendLayout();
            panel_searchSlice.SuspendLayout();
            tc_manager.SuspendLayout();
            SuspendLayout();
            // 
            // tp_delete
            // 
            tp_delete.BackColor = Color.Transparent;
            tp_delete.BackgroundImageLayout = ImageLayout.None;
            tp_delete.Location = new Point(4, 34);
            tp_delete.Name = "tp_delete";
            tp_delete.Padding = new Padding(3);
            tp_delete.Size = new Size(1290, 705);
            tp_delete.TabIndex = 2;
            tp_delete.Text = "Xóa";
            // 
            // panel_viewControl
            // 
            panel_viewControl.BackColor = SystemColors.ControlLight;
            panel_viewControl.Controls.Add(dtgv_member);
            panel_viewControl.Location = new Point(3, 3);
            panel_viewControl.Name = "panel_viewControl";
            panel_viewControl.Size = new Size(974, 699);
            panel_viewControl.TabIndex = 0;
            // 
            // dtgv_member
            // 
            dtgv_member.AllowUserToAddRows = false;
            dtgv_member.AllowUserToDeleteRows = false;
            dtgv_member.BackgroundColor = SystemColors.ControlLight;
            dtgv_member.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_member.Location = new Point(3, 3);
            dtgv_member.Name = "dtgv_member";
            dtgv_member.RowHeadersWidth = 62;
            dtgv_member.RowTemplate.Height = 33;
            dtgv_member.Size = new Size(968, 693);
            dtgv_member.TabIndex = 0;
            // 
            // tp_edit
            // 
            tp_edit.Location = new Point(4, 34);
            tp_edit.Name = "tp_edit";
            tp_edit.Padding = new Padding(3);
            tp_edit.Size = new Size(1290, 705);
            tp_edit.TabIndex = 1;
            tp_edit.Text = "Sửa";
            tp_edit.UseVisualStyleBackColor = true;
            // 
            // txb_identifyNumber
            // 
            txb_identifyNumber.Location = new Point(10, 346);
            txb_identifyNumber.Name = "txb_identifyNumber";
            txb_identifyNumber.Size = new Size(179, 30);
            txb_identifyNumber.TabIndex = 9;
            // 
            // label_price
            // 
            label_price.AutoSize = true;
            label_price.Location = new Point(10, 313);
            label_price.Name = "label_price";
            label_price.Size = new Size(90, 21);
            label_price.TabIndex = 8;
            label_price.Text = "Số CCCD";
            // 
            // txb_phoneNumber
            // 
            txb_phoneNumber.Location = new Point(10, 267);
            txb_phoneNumber.Name = "txb_phoneNumber";
            txb_phoneNumber.Size = new Size(179, 30);
            txb_phoneNumber.TabIndex = 7;
            // 
            // label_category
            // 
            label_category.AutoSize = true;
            label_category.Location = new Point(10, 229);
            label_category.Name = "label_category";
            label_category.Size = new Size(112, 21);
            label_category.TabIndex = 6;
            label_category.Text = "Số điện thoại";
            // 
            // txb_memberName
            // 
            txb_memberName.Location = new Point(10, 183);
            txb_memberName.Name = "txb_memberName";
            txb_memberName.Size = new Size(269, 30);
            txb_memberName.TabIndex = 5;
            // 
            // tp_viewCD
            // 
            tp_viewCD.BackColor = Color.Transparent;
            tp_viewCD.Controls.Add(panel_searchSlice);
            tp_viewCD.Controls.Add(panel_viewControl);
            tp_viewCD.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tp_viewCD.Location = new Point(4, 34);
            tp_viewCD.Margin = new Padding(0);
            tp_viewCD.Name = "tp_viewCD";
            tp_viewCD.Size = new Size(1290, 705);
            tp_viewCD.TabIndex = 0;
            tp_viewCD.Text = "Xem ";
            // 
            // panel_searchSlice
            // 
            panel_searchSlice.BackColor = Color.Gainsboro;
            panel_searchSlice.Controls.Add(txb_identifyNumber);
            panel_searchSlice.Controls.Add(label_price);
            panel_searchSlice.Controls.Add(txb_phoneNumber);
            panel_searchSlice.Controls.Add(label_category);
            panel_searchSlice.Controls.Add(txb_memberName);
            panel_searchSlice.Controls.Add(label_memberName);
            panel_searchSlice.Controls.Add(txb_id);
            panel_searchSlice.Controls.Add(label_idMember);
            panel_searchSlice.Controls.Add(txb_search);
            panel_searchSlice.Controls.Add(button_search);
            panel_searchSlice.Location = new Point(983, 3);
            panel_searchSlice.Name = "panel_searchSlice";
            panel_searchSlice.Size = new Size(304, 696);
            panel_searchSlice.TabIndex = 1;
            // 
            // label_memberName
            // 
            label_memberName.AutoSize = true;
            label_memberName.Location = new Point(8, 147);
            label_memberName.Name = "label_memberName";
            label_memberName.Size = new Size(145, 21);
            label_memberName.TabIndex = 4;
            label_memberName.Text = "Tên Thành Viên";
            // 
            // txb_id
            // 
            txb_id.Location = new Point(10, 102);
            txb_id.Name = "txb_id";
            txb_id.ReadOnly = true;
            txb_id.Size = new Size(283, 30);
            txb_id.TabIndex = 3;
            // 
            // label_idMember
            // 
            label_idMember.AutoSize = true;
            label_idMember.Location = new Point(10, 64);
            label_idMember.Name = "label_idMember";
            label_idMember.Size = new Size(28, 21);
            label_idMember.TabIndex = 2;
            label_idMember.Text = "ID";
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
            // tc_manager
            // 
            tc_manager.Controls.Add(tp_viewCD);
            tc_manager.Controls.Add(tp_edit);
            tc_manager.Controls.Add(tp_delete);
            tc_manager.Location = new Point(12, 12);
            tc_manager.Margin = new Padding(0);
            tc_manager.Name = "tc_manager";
            tc_manager.Padding = new Point(0, 0);
            tc_manager.SelectedIndex = 0;
            tc_manager.Size = new Size(1298, 743);
            tc_manager.TabIndex = 1;
            // 
            // fAccountManager
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1319, 764);
            Controls.Add(tc_manager);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fAccountManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Thành Viên";
            panel_viewControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgv_member).EndInit();
            tp_viewCD.ResumeLayout(false);
            panel_searchSlice.ResumeLayout(false);
            panel_searchSlice.PerformLayout();
            tc_manager.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tp_delete;
        private Panel panel_viewControl;
        private TabPage tp_edit;
        private TextBox txb_identifyNumber;
        private Label label_price;
        private TextBox txb_phoneNumber;
        private Label label_category;
        private TextBox txb_memberName;
        private TabPage tp_viewCD;
        private Panel panel_searchSlice;
        private Label label_memberName;
        private TextBox txb_id;
        private Label label_idMember;
        private TextBox txb_search;
        private Button button_search;
        private TabControl tc_manager;
        private DataGridView dtgv_member;
    }
}
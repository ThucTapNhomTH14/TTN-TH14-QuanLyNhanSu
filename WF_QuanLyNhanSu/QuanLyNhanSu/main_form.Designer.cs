namespace WindowsFormsApplication1
{
    partial class main_form
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
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_cmnd = new System.Windows.Forms.Label();
            this.lb_phone = new System.Windows.Forms.Label();
            this.lb_address = new System.Windows.Forms.Label();
            this.lb_department = new System.Windows.Forms.Label();
            this.lb_diploma = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbDiploma = new System.Windows.Forms.ComboBox();
            this.cb_department = new System.Windows.Forms.ComboBox();
            this.dgv_nhansu = new System.Windows.Forms.DataGridView();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matdhv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.help_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnSửDụngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lastupdate_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusUpdateLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhansu)).BeginInit();
            this.menuBar.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(11, 72);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(57, 13);
            this.lb_name.TabIndex = 0;
            this.lb_name.Text = "Họ và tên:";
            // 
            // lb_cmnd
            // 
            this.lb_cmnd.AutoSize = true;
            this.lb_cmnd.Location = new System.Drawing.Point(12, 124);
            this.lb_cmnd.Name = "lb_cmnd";
            this.lb_cmnd.Size = new System.Drawing.Size(42, 13);
            this.lb_cmnd.TabIndex = 3;
            this.lb_cmnd.Text = "CMND:";
            // 
            // lb_phone
            // 
            this.lb_phone.AutoSize = true;
            this.lb_phone.Location = new System.Drawing.Point(363, 72);
            this.lb_phone.Name = "lb_phone";
            this.lb_phone.Size = new System.Drawing.Size(32, 13);
            this.lb_phone.TabIndex = 4;
            this.lb_phone.Text = "SĐT:";
            // 
            // lb_address
            // 
            this.lb_address.AutoSize = true;
            this.lb_address.Location = new System.Drawing.Point(11, 178);
            this.lb_address.Name = "lb_address";
            this.lb_address.Size = new System.Drawing.Size(43, 13);
            this.lb_address.TabIndex = 6;
            this.lb_address.Text = "Địa chỉ:";
            // 
            // lb_department
            // 
            this.lb_department.AutoSize = true;
            this.lb_department.Location = new System.Drawing.Point(362, 126);
            this.lb_department.Name = "lb_department";
            this.lb_department.Size = new System.Drawing.Size(71, 13);
            this.lb_department.TabIndex = 7;
            this.lb_department.Text = "Nơi công tác:";
            // 
            // lb_diploma
            // 
            this.lb_diploma.AutoSize = true;
            this.lb_diploma.Location = new System.Drawing.Point(362, 178);
            this.lb_diploma.Name = "lb_diploma";
            this.lb_diploma.Size = new System.Drawing.Size(92, 13);
            this.lb_diploma.TabIndex = 8;
            this.lb_diploma.Text = "Trình độ học vấn:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(111, 175);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(195, 20);
            this.txtAddress.TabIndex = 17;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(462, 69);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(195, 20);
            this.txtSDT.TabIndex = 16;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(111, 121);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(195, 20);
            this.txtCMND.TabIndex = 15;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(111, 69);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(195, 20);
            this.txtName.TabIndex = 11;
            // 
            // cbDiploma
            // 
            this.cbDiploma.FormattingEnabled = true;
            this.cbDiploma.Location = new System.Drawing.Point(462, 175);
            this.cbDiploma.Name = "cbDiploma";
            this.cbDiploma.Size = new System.Drawing.Size(195, 21);
            this.cbDiploma.TabIndex = 19;
            // 
            // cb_department
            // 
            this.cb_department.FormattingEnabled = true;
            this.cb_department.Location = new System.Drawing.Point(462, 123);
            this.cb_department.Name = "cb_department";
            this.cb_department.Size = new System.Drawing.Size(195, 21);
            this.cb_department.TabIndex = 28;
            // 
            // dgv_nhansu
            // 
            this.dgv_nhansu.AllowUserToAddRows = false;
            this.dgv_nhansu.AllowUserToResizeRows = false;
            this.dgv_nhansu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_nhansu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_nhansu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nhansu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manv,
            this.tennv,
            this.cmnd,
            this.sdt,
            this.diachi,
            this.ngaysinh,
            this.maphong,
            this.matdhv});
            this.dgv_nhansu.Location = new System.Drawing.Point(12, 258);
            this.dgv_nhansu.Name = "dgv_nhansu";
            this.dgv_nhansu.ReadOnly = true;
            this.dgv_nhansu.RowHeadersVisible = false;
            this.dgv_nhansu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_nhansu.Size = new System.Drawing.Size(967, 605);
            this.dgv_nhansu.TabIndex = 0;
            // 
            // manv
            // 
            this.manv.DataPropertyName = "manv";
            this.manv.HeaderText = "Mã nhân viên";
            this.manv.Name = "manv";
            this.manv.ReadOnly = true;
            // 
            // tennv
            // 
            this.tennv.DataPropertyName = "tennv";
            this.tennv.HeaderText = "Tên nhân viên";
            this.tennv.Name = "tennv";
            this.tennv.ReadOnly = true;
            // 
            // cmnd
            // 
            this.cmnd.DataPropertyName = "cmnd";
            this.cmnd.HeaderText = "CMND";
            this.cmnd.Name = "cmnd";
            this.cmnd.ReadOnly = true;
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "sdt";
            this.sdt.HeaderText = "Số điện thoại";
            this.sdt.Name = "sdt";
            this.sdt.ReadOnly = true;
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.Name = "diachi";
            this.diachi.ReadOnly = true;
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "ngaysinh";
            this.ngaysinh.HeaderText = "Ngày sinh";
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.ReadOnly = true;
            // 
            // maphong
            // 
            this.maphong.DataPropertyName = "tenphong";
            this.maphong.HeaderText = "Phòng";
            this.maphong.Name = "maphong";
            this.maphong.ReadOnly = true;
            // 
            // matdhv
            // 
            this.matdhv.DataPropertyName = "tentdhv";
            this.matdhv.HeaderText = "Trình độ học vấn";
            this.matdhv.Name = "matdhv";
            this.matdhv.ReadOnly = true;
            // 
            // menuBar
            // 
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.help_menu});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(991, 24);
            this.menuBar.TabIndex = 1;
            this.menuBar.Text = "MenuBar";
            // 
            // help_menu
            // 
            this.help_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hướngDẫnSửDụngToolStripMenuItem});
            this.help_menu.Name = "help_menu";
            this.help_menu.ShortcutKeyDisplayString = "F1";
            this.help_menu.ShowShortcutKeys = false;
            this.help_menu.Size = new System.Drawing.Size(53, 20);
            this.help_menu.Text = "Hỗ trợ";
            // 
            // hướngDẫnSửDụngToolStripMenuItem
            // 
            this.hướngDẫnSửDụngToolStripMenuItem.Name = "hướngDẫnSửDụngToolStripMenuItem";
            this.hướngDẫnSửDụngToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hướngDẫnSửDụngToolStripMenuItem.Text = "Hướng dẫn sử dụng";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(527, 938);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(779, 938);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(656, 938);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lastupdate_status,
            this.toolStripStatusUpdateLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 978);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(991, 22);
            this.statusStrip.TabIndex = 6;
            // 
            // lastupdate_status
            // 
            this.lastupdate_status.Name = "lastupdate_status";
            this.lastupdate_status.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusUpdateLabel
            // 
            this.toolStripStatusUpdateLabel.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
            this.toolStripStatusUpdateLabel.Name = "toolStripStatusUpdateLabel";
            this.toolStripStatusUpdateLabel.Size = new System.Drawing.Size(139, 17);
            this.toolStripStatusUpdateLabel.Text = "Dòng trạng thái cập nhật";
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Location = new System.Drawing.Point(904, 938);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapnhat.TabIndex = 7;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.UseVisualStyleBackColor = true;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(728, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 1000);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_department);
            this.Controls.Add(this.cbDiploma);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lb_diploma);
            this.Controls.Add(this.lb_department);
            this.Controls.Add(this.lb_address);
            this.Controls.Add(this.lb_phone);
            this.Controls.Add(this.lb_cmnd);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgv_nhansu);
            this.Controls.Add(this.menuBar);
            this.Name = "main_form";
            this.Text = "Phần mềm quản lý nhân sự";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhansu)).EndInit();
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lb_name;
        public System.Windows.Forms.Label lb_cmnd;
        public System.Windows.Forms.Label lb_phone;
        public System.Windows.Forms.Label lb_address;
        public System.Windows.Forms.Label lb_department;
        public System.Windows.Forms.Label lb_diploma;
        public System.Windows.Forms.TextBox txtAddress;
        public System.Windows.Forms.TextBox txtSDT;
        public System.Windows.Forms.TextBox txtCMND;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.ComboBox cbDiploma;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.ComboBox cb_department;
        private System.Windows.Forms.DataGridView dgv_nhansu;
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem help_menu;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnSửDụngToolStripMenuItem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lastupdate_status;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennv;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn matdhv;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusUpdateLabel;
        private System.Windows.Forms.Button button1;
    }
}


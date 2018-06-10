namespace WindowsFormsApplication1
{
    partial class create_form
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
            this.label1 = new System.Windows.Forms.Label();
            this.lb_cmnd = new System.Windows.Forms.Label();
            this.lb_phone = new System.Windows.Forms.Label();
            this.lb_birth = new System.Windows.Forms.Label();
            this.lb_address = new System.Windows.Forms.Label();
            this.lb_department = new System.Windows.Forms.Label();
            this.lb_diploma = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbDiploma = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cb_department = new System.Windows.Forms.ComboBox();
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
            this.lb_phone.Location = new System.Drawing.Point(12, 150);
            this.lb_phone.Name = "lb_phone";
            this.lb_phone.Size = new System.Drawing.Size(32, 13);
            this.lb_phone.TabIndex = 4;
            this.lb_phone.Text = "SĐT:";
            // 
            // lb_birth
            // 
            this.lb_birth.AutoSize = true;
            this.lb_birth.Location = new System.Drawing.Point(12, 98);
            this.lb_birth.Name = "lb_birth";
            this.lb_birth.Size = new System.Drawing.Size(57, 13);
            this.lb_birth.TabIndex = 5;
            this.lb_birth.Text = "Ngày sinh:";
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
            this.lb_department.Location = new System.Drawing.Point(11, 204);
            this.lb_department.Name = "lb_department";
            this.lb_department.Size = new System.Drawing.Size(71, 13);
            this.lb_department.TabIndex = 7;
            this.lb_department.Text = "Nơi công tác:";
            // 
            // lb_diploma
            // 
            this.lb_diploma.AutoSize = true;
            this.lb_diploma.Location = new System.Drawing.Point(11, 230);
            this.lb_diploma.Name = "lb_diploma";
            this.lb_diploma.Size = new System.Drawing.Size(92, 13);
            this.lb_diploma.TabIndex = 8;
            this.lb_diploma.Text = "Trình độ học vấn:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(111, 175);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(250, 20);
            this.txtAddress.TabIndex = 17;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(111, 147);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(250, 20);
            this.txtSDT.TabIndex = 16;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(111, 121);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(250, 20);
            this.txtCMND.TabIndex = 15;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(111, 69);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 20);
            this.txtName.TabIndex = 11;
            // 
            // cbDiploma
            // 
            this.cbDiploma.FormattingEnabled = true;
            this.cbDiploma.Location = new System.Drawing.Point(111, 227);
            this.cbDiploma.Name = "cbDiploma";
            this.cbDiploma.Size = new System.Drawing.Size(250, 21);
            this.cbDiploma.TabIndex = 19;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "                  dd / MM / yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(111, 95);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 20);
            this.dateTimePicker1.TabIndex = 25;
            this.dateTimePicker1.Value = new System.DateTime(2018, 4, 9, 0, 0, 0, 0);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(286, 330);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(205, 330);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cb_department
            // 
            this.cb_department.FormattingEnabled = true;
            this.cb_department.Location = new System.Drawing.Point(111, 201);
            this.cb_department.Name = "cb_department";
            this.cb_department.Size = new System.Drawing.Size(250, 21);
            this.cb_department.TabIndex = 28;
            // 
            // create_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 395);
            this.Controls.Add(this.cb_department);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cbDiploma);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lb_diploma);
            this.Controls.Add(this.lb_department);
            this.Controls.Add(this.lb_address);
            this.Controls.Add(this.lb_birth);
            this.Controls.Add(this.lb_phone);
            this.Controls.Add(this.lb_cmnd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_name);
            this.Name = "create_form";
            this.Text = "Thêm thông tin cá nhân";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lb_name;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lb_cmnd;
        public System.Windows.Forms.Label lb_phone;
        public System.Windows.Forms.Label lb_birth;
        public System.Windows.Forms.Label lb_address;
        public System.Windows.Forms.Label lb_department;
        public System.Windows.Forms.Label lb_diploma;
        public System.Windows.Forms.TextBox txtAddress;
        public System.Windows.Forms.TextBox txtSDT;
        public System.Windows.Forms.TextBox txtCMND;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.ComboBox cbDiploma;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.ComboBox cb_department;
    }
}
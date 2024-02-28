namespace QuanLyNhanSu
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hejjToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUser = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDepartment = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnShow = new System.Windows.Forms.ToolStripButton();
            this.btnAddNew = new System.Windows.Forms.ToolStripLabel();
            this.btnEdit = new System.Windows.Forms.ToolStripLabel();
            this.btnDelete = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.gbTimKiem = new System.Windows.Forms.GroupBox();
            this.txbMaNV = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txbGioiTInh = new System.Windows.Forms.TextBox();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.lbGioiTinh = new System.Windows.Forms.Label();
            this.lbNgaysinh = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txbName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgvEmployee = new System.Windows.Forms.DataGridView();
            this.colEmployeeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBirtDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContract = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.gbTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmployee)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hejjToolStripMenuItem,
            this.quảnLýToolStripMenuItem,
            this.thốngKêToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hejjToolStripMenuItem
            // 
            this.hejjToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUser,
            this.đăngNhậpToolStripMenuItem});
            this.hejjToolStripMenuItem.Name = "hejjToolStripMenuItem";
            this.hejjToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.hejjToolStripMenuItem.Text = "Hệ thống";
            this.hejjToolStripMenuItem.Click += new System.EventHandler(this.hejjToolStripMenuItem_Click);
            // 
            // tsmiUser
            // 
            this.tsmiUser.Name = "tsmiUser";
            this.tsmiUser.Size = new System.Drawing.Size(207, 26);
            this.tsmiUser.Text = "Quản lý tài khoản";
            this.tsmiUser.Click += new System.EventHandler(this.tsmiUser_Click);
            // 
            // đăngNhậpToolStripMenuItem
            // 
            this.đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            this.đăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.đăngNhậpToolStripMenuItem.Text = "Đăng nhập ";
            this.đăngNhậpToolStripMenuItem.Click += new System.EventHandler(this.đăngNhậpToolStripMenuItem_Click);
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEmployee,
            this.tsmiDepartment});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.quảnLýToolStripMenuItem.Text = "Quản lý ";
            // 
            // tsmiEmployee
            // 
            this.tsmiEmployee.Name = "tsmiEmployee";
            this.tsmiEmployee.Size = new System.Drawing.Size(167, 26);
            this.tsmiEmployee.Text = "Nhân viên";
            this.tsmiEmployee.Click += new System.EventHandler(this.tsmiEmployee_Click);
            // 
            // tsmiDepartment
            // 
            this.tsmiDepartment.Name = "tsmiDepartment";
            this.tsmiDepartment.Size = new System.Drawing.Size(167, 26);
            this.tsmiDepartment.Text = "Phòng ban ";
            this.tsmiDepartment.Click += new System.EventHandler(this.tsmiDepartment_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            this.thốngKêToolStripMenuItem.Click += new System.EventHandler(this.thốngKêToolStripMenuItem_Click);
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp ";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnShow,
            this.btnAddNew,
            this.btnEdit,
            this.btnDelete,
            this.toolStripLabel4,
            this.toolStripLabel5,
            this.toolStripLabel6,
            this.toolStripButton7});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnShow
            // 
            this.btnShow.Image = global::QuanLyNhanSu.Properties.Resources.IMG_E2772__1_;
            this.btnShow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(63, 24);
            this.btnShow.Text = "Xem";
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Image = global::QuanLyNhanSu.Properties.Resources.android_logo_PNG27;
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(66, 24);
            this.btnAddNew.Text = "Thêm";
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::QuanLyNhanSu.Properties.Resources.android_logo_PNG27;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(58, 24);
            this.btnEdit.Text = "Sửa ";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::QuanLyNhanSu.Properties.Resources.android_logo_PNG27;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(55, 24);
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Image = global::QuanLyNhanSu.Properties.Resources.android_logo_PNG27;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(53, 24);
            this.toolStripLabel4.Text = "Lưu";
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Image = global::QuanLyNhanSu.Properties.Resources.android_logo_PNG27;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(55, 24);
            this.toolStripLabel5.Text = "Hủy";
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Image = global::QuanLyNhanSu.Properties.Resources.android_logo_PNG27;
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(88, 24);
            this.toolStripLabel6.Text = "Cập nhật";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.Image = global::QuanLyNhanSu.Properties.Resources.android_logo_PNG27;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(45, 24);
            this.toolStripButton7.Text = "In";
            // 
            // gbTimKiem
            // 
            this.gbTimKiem.Controls.Add(this.txbMaNV);
            this.gbTimKiem.Controls.Add(this.dateTimePicker1);
            this.gbTimKiem.Controls.Add(this.txbGioiTInh);
            this.gbTimKiem.Controls.Add(this.lbMaNV);
            this.gbTimKiem.Controls.Add(this.lbGioiTinh);
            this.gbTimKiem.Controls.Add(this.lbNgaysinh);
            this.gbTimKiem.Controls.Add(this.btnTimKiem);
            this.gbTimKiem.Controls.Add(this.txbName);
            this.gbTimKiem.Controls.Add(this.lbName);
            this.gbTimKiem.Location = new System.Drawing.Point(12, 68);
            this.gbTimKiem.Name = "gbTimKiem";
            this.gbTimKiem.Size = new System.Drawing.Size(776, 140);
            this.gbTimKiem.TabIndex = 2;
            this.gbTimKiem.TabStop = false;
            this.gbTimKiem.Text = "Tìm kiếm";
            this.gbTimKiem.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txbMaNV
            // 
            this.txbMaNV.Location = new System.Drawing.Point(349, 81);
            this.txbMaNV.Name = "txbMaNV";
            this.txbMaNV.Size = new System.Drawing.Size(100, 22);
            this.txbMaNV.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Matura MT Script Capitals", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(97, 82);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(122, 24);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Value = new System.DateTime(2024, 2, 15, 0, 0, 0, 0);
            // 
            // txbGioiTInh
            // 
            this.txbGioiTInh.HideSelection = false;
            this.txbGioiTInh.Location = new System.Drawing.Point(349, 31);
            this.txbGioiTInh.Name = "txbGioiTInh";
            this.txbGioiTInh.Size = new System.Drawing.Size(100, 22);
            this.txbGioiTInh.TabIndex = 7;
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Location = new System.Drawing.Point(260, 84);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(86, 16);
            this.lbMaNV.TabIndex = 5;
            this.lbMaNV.Text = "Mã nhân viên";
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.AutoSize = true;
            this.lbGioiTinh.Location = new System.Drawing.Point(260, 37);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(54, 16);
            this.lbGioiTinh.TabIndex = 4;
            this.lbGioiTinh.Text = "Giới tính";
            this.lbGioiTinh.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbNgaysinh
            // 
            this.lbNgaysinh.AutoSize = true;
            this.lbNgaysinh.Location = new System.Drawing.Point(19, 87);
            this.lbNgaysinh.Name = "lbNgaysinh";
            this.lbNgaysinh.Size = new System.Drawing.Size(67, 16);
            this.lbNgaysinh.TabIndex = 3;
            this.lbNgaysinh.Text = "Ngày sinh";
            this.lbNgaysinh.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(584, 77);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(97, 37);
            this.txbName.Multiline = true;
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(122, 22);
            this.txbName.TabIndex = 1;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(19, 37);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(46, 16);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Họ tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(345, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Danh Sách Nhân Viên";
            // 
            // dtgvEmployee
            // 
            this.dtgvEmployee.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dtgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEmployeeCode,
            this.colName,
            this.colBirtDay,
            this.colSex,
            this.colDepartment,
            this.colPosition,
            this.colContract});
            this.dtgvEmployee.Location = new System.Drawing.Point(12, 257);
            this.dtgvEmployee.Name = "dtgvEmployee";
            this.dtgvEmployee.RowHeadersWidth = 51;
            this.dtgvEmployee.RowTemplate.Height = 24;
            this.dtgvEmployee.Size = new System.Drawing.Size(776, 182);
            this.dtgvEmployee.TabIndex = 4;
            this.dtgvEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvEmployee_CellClick);
            // 
            // colEmployeeCode
            // 
            this.colEmployeeCode.DataPropertyName = "EmployeeCode11";
            this.colEmployeeCode.HeaderText = "Ma nhan vien";
            this.colEmployeeCode.MinimumWidth = 6;
            this.colEmployeeCode.Name = "colEmployeeCode";
            this.colEmployeeCode.Width = 125;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Ho ten";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.Width = 125;
            // 
            // colBirtDay
            // 
            this.colBirtDay.DataPropertyName = "Sex";
            this.colBirtDay.HeaderText = "Ngay sinh";
            this.colBirtDay.MinimumWidth = 6;
            this.colBirtDay.Name = "colBirtDay";
            this.colBirtDay.Width = 125;
            // 
            // colSex
            // 
            this.colSex.DataPropertyName = "BirtDay";
            this.colSex.HeaderText = "Gioi tinh";
            this.colSex.MinimumWidth = 6;
            this.colSex.Name = "colSex";
            this.colSex.Width = 125;
            // 
            // colDepartment
            // 
            this.colDepartment.DataPropertyName = "Department";
            this.colDepartment.HeaderText = "Phong ban";
            this.colDepartment.MinimumWidth = 6;
            this.colDepartment.Name = "colDepartment";
            this.colDepartment.Width = 125;
            // 
            // colPosition
            // 
            this.colPosition.DataPropertyName = "Position";
            this.colPosition.HeaderText = "Vi tri";
            this.colPosition.MinimumWidth = 6;
            this.colPosition.Name = "colPosition";
            this.colPosition.Width = 125;
            // 
            // colContract
            // 
            this.colContract.DataPropertyName = "Contract";
            this.colContract.HeaderText = "Trang thai";
            this.colContract.MinimumWidth = 6;
            this.colContract.Name = "colContract";
            this.colContract.Width = 125;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 451);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 26);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dtgvEmployee);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gbTimKiem);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbTimKiem.ResumeLayout(false);
            this.gbTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmployee)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hejjToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiUser;
        private System.Windows.Forms.ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiEmployee;
        private System.Windows.Forms.ToolStripMenuItem tsmiDepartment;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel btnAddNew;
        private System.Windows.Forms.ToolStripLabel btnEdit;
        private System.Windows.Forms.ToolStripLabel btnDelete;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.GroupBox gbTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txbMaNV;
        private System.Windows.Forms.TextBox txbGioiTInh;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.Label lbGioiTinh;
        private System.Windows.Forms.Label lbNgaysinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgvEmployee;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripButton btnShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmployeeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBirtDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContract;
    }
}
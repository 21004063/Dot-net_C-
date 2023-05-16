namespace PhanMemQuanLiThiTracNghiem
{
    partial class frm_GiangVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_GiangVien));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ChucVu = new System.Windows.Forms.Label();
            this.NgaySinh_GV = new System.Windows.Forms.Label();
            this.GioiTinh = new System.Windows.Forms.Label();
            this.MaGiangVien = new System.Windows.Forms.Label();
            this.TenGiangVien = new System.Windows.Forms.Label();
            this.tb_enable = new PhanMemQuanLiThiTracNghiem.RJToggleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_timkiem = new PhanMemQuanLiThiTracNghiem.RJButton();
            this.btn_lammoi = new PhanMemQuanLiThiTracNghiem.RJButton();
            this.txt_passwd = new PhanMemQuanLiThiTracNghiem.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_chucvu = new PhanMemQuanLiThiTracNghiem.RJTextBox();
            this.txt_tenGV = new PhanMemQuanLiThiTracNghiem.RJTextBox();
            this.rdb_nu = new PhanMemQuanLiThiTracNghiem.RJRadioButton();
            this.txt_mGV = new PhanMemQuanLiThiTracNghiem.RJTextBox();
            this.rdb_nam = new PhanMemQuanLiThiTracNghiem.RJRadioButton();
            this.dtp_nsGV = new System.Windows.Forms.DateTimePicker();
            this.cbb_mK = new System.Windows.Forms.ComboBox();
            this.MaKhoa = new System.Windows.Forms.Label();
            this.panelbtn = new System.Windows.Forms.Panel();
            this.btn_sua = new PhanMemQuanLiThiTracNghiem.RJButton();
            this.btn_xoa = new PhanMemQuanLiThiTracNghiem.RJButton();
            this.btn_them = new PhanMemQuanLiThiTracNghiem.RJButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgw_GV = new System.Windows.Forms.DataGridView();
            this.panelbtn.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_GV)).BeginInit();
            this.SuspendLayout();
            // 
            // ChucVu
            // 
            this.ChucVu.AutoSize = true;
            this.ChucVu.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChucVu.Location = new System.Drawing.Point(79, 334);
            this.ChucVu.Name = "ChucVu";
            this.ChucVu.Size = new System.Drawing.Size(89, 25);
            this.ChucVu.TabIndex = 22;
            this.ChucVu.Text = "Chức vụ:";
            // 
            // NgaySinh_GV
            // 
            this.NgaySinh_GV.AutoSize = true;
            this.NgaySinh_GV.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgaySinh_GV.Location = new System.Drawing.Point(63, 280);
            this.NgaySinh_GV.Name = "NgaySinh_GV";
            this.NgaySinh_GV.Size = new System.Drawing.Size(105, 25);
            this.NgaySinh_GV.TabIndex = 7;
            this.NgaySinh_GV.Text = "Ngày sinh:";
            // 
            // GioiTinh
            // 
            this.GioiTinh.AutoSize = true;
            this.GioiTinh.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GioiTinh.Location = new System.Drawing.Point(75, 226);
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Size = new System.Drawing.Size(93, 25);
            this.GioiTinh.TabIndex = 20;
            this.GioiTinh.Text = "Giới tính:";
            // 
            // MaGiangVien
            // 
            this.MaGiangVien.AutoSize = true;
            this.MaGiangVien.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaGiangVien.Location = new System.Drawing.Point(25, 64);
            this.MaGiangVien.Name = "MaGiangVien";
            this.MaGiangVien.Size = new System.Drawing.Size(143, 25);
            this.MaGiangVien.TabIndex = 1;
            this.MaGiangVien.Text = "Mã giảng viên:";
            // 
            // TenGiangVien
            // 
            this.TenGiangVien.AutoSize = true;
            this.TenGiangVien.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenGiangVien.Location = new System.Drawing.Point(22, 118);
            this.TenGiangVien.Name = "TenGiangVien";
            this.TenGiangVien.Size = new System.Drawing.Size(146, 25);
            this.TenGiangVien.TabIndex = 2;
            this.TenGiangVien.Text = "Tên giảng viên:";
            // 
            // tb_enable
            // 
            this.tb_enable.BackColor = System.Drawing.Color.RoyalBlue;
            this.tb_enable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb_enable.Location = new System.Drawing.Point(218, 455);
            this.tb_enable.MinimumSize = new System.Drawing.Size(45, 22);
            this.tb_enable.Name = "tb_enable";
            this.tb_enable.OffBackColor = System.Drawing.Color.Gray;
            this.tb_enable.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tb_enable.OnBackColor = System.Drawing.Color.Gold;
            this.tb_enable.OnToggleColor = System.Drawing.Color.Red;
            this.tb_enable.Size = new System.Drawing.Size(53, 25);
            this.tb_enable.TabIndex = 8;
            this.tb_enable.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 454);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 25);
            this.label3.TabIndex = 27;
            this.label3.Text = "Kích hoạt tài khoản:";
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_timkiem.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.btn_timkiem.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_timkiem.BorderRadius = 19;
            this.btn_timkiem.BorderSize = 0;
            this.btn_timkiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_timkiem.FlatAppearance.BorderSize = 0;
            this.btn_timkiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_timkiem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_timkiem.Image = ((System.Drawing.Image)(resources.GetObject("btn_timkiem.Image")));
            this.btn_timkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_timkiem.Location = new System.Drawing.Point(103, 526);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(133, 40);
            this.btn_timkiem.TabIndex = 9;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_timkiem.TextColor = System.Drawing.SystemColors.Desktop;
            this.btn_timkiem.UseVisualStyleBackColor = false;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.BackColor = System.Drawing.Color.Khaki;
            this.btn_lammoi.BackgroundColor = System.Drawing.Color.Khaki;
            this.btn_lammoi.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_lammoi.BorderRadius = 20;
            this.btn_lammoi.BorderSize = 0;
            this.btn_lammoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_lammoi.FlatAppearance.BorderSize = 0;
            this.btn_lammoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lammoi.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_lammoi.Image = ((System.Drawing.Image)(resources.GetObject("btn_lammoi.Image")));
            this.btn_lammoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_lammoi.Location = new System.Drawing.Point(257, 526);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(133, 40);
            this.btn_lammoi.TabIndex = 10;
            this.btn_lammoi.Text = "Làm mới";
            this.btn_lammoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_lammoi.TextColor = System.Drawing.SystemColors.Desktop;
            this.btn_lammoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_lammoi.UseVisualStyleBackColor = false;
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // txt_passwd
            // 
            this.txt_passwd.BackColor = System.Drawing.Color.White;
            this.txt_passwd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(57)))));
            this.txt_passwd.BorderFocusColor = System.Drawing.Color.OrangeRed;
            this.txt_passwd.BorderSize = 2;
            this.txt_passwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_passwd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_passwd.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txt_passwd.Location = new System.Drawing.Point(168, 387);
            this.txt_passwd.Margin = new System.Windows.Forms.Padding(0);
            this.txt_passwd.Multiline = false;
            this.txt_passwd.Name = "txt_passwd";
            this.txt_passwd.Padding = new System.Windows.Forms.Padding(7);
            this.txt_passwd.PasswordChar = false;
            this.txt_passwd.Size = new System.Drawing.Size(281, 40);
            this.txt_passwd.TabIndex = 7;
            this.txt_passwd.Texts = "";
            this.txt_passwd.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Mật Khẩu:";
            // 
            // txt_chucvu
            // 
            this.txt_chucvu.BackColor = System.Drawing.Color.White;
            this.txt_chucvu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(57)))));
            this.txt_chucvu.BorderFocusColor = System.Drawing.Color.OrangeRed;
            this.txt_chucvu.BorderSize = 2;
            this.txt_chucvu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_chucvu.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_chucvu.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txt_chucvu.Location = new System.Drawing.Point(168, 326);
            this.txt_chucvu.Margin = new System.Windows.Forms.Padding(0);
            this.txt_chucvu.Multiline = false;
            this.txt_chucvu.Name = "txt_chucvu";
            this.txt_chucvu.Padding = new System.Windows.Forms.Padding(7);
            this.txt_chucvu.PasswordChar = false;
            this.txt_chucvu.Size = new System.Drawing.Size(281, 40);
            this.txt_chucvu.TabIndex = 6;
            this.txt_chucvu.Texts = "";
            this.txt_chucvu.UnderlinedStyle = false;
            // 
            // txt_tenGV
            // 
            this.txt_tenGV.BackColor = System.Drawing.Color.White;
            this.txt_tenGV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(57)))));
            this.txt_tenGV.BorderFocusColor = System.Drawing.Color.OrangeRed;
            this.txt_tenGV.BorderSize = 2;
            this.txt_tenGV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tenGV.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenGV.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txt_tenGV.Location = new System.Drawing.Point(168, 110);
            this.txt_tenGV.Margin = new System.Windows.Forms.Padding(0);
            this.txt_tenGV.Multiline = false;
            this.txt_tenGV.Name = "txt_tenGV";
            this.txt_tenGV.Padding = new System.Windows.Forms.Padding(7);
            this.txt_tenGV.PasswordChar = false;
            this.txt_tenGV.Size = new System.Drawing.Size(281, 40);
            this.txt_tenGV.TabIndex = 2;
            this.txt_tenGV.Texts = "";
            this.txt_tenGV.UnderlinedStyle = false;
            // 
            // rdb_nu
            // 
            this.rdb_nu.AutoSize = true;
            this.rdb_nu.CheckedColor = System.Drawing.Color.Yellow;
            this.rdb_nu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_nu.Location = new System.Drawing.Point(268, 222);
            this.rdb_nu.MinimumSize = new System.Drawing.Size(0, 21);
            this.rdb_nu.Name = "rdb_nu";
            this.rdb_nu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rdb_nu.Size = new System.Drawing.Size(68, 29);
            this.rdb_nu.TabIndex = 3;
            this.rdb_nu.Tag = "4";
            this.rdb_nu.Text = "Nữ";
            this.rdb_nu.UnCheckedColor = System.Drawing.Color.White;
            this.rdb_nu.UseVisualStyleBackColor = true;
            // 
            // txt_mGV
            // 
            this.txt_mGV.BackColor = System.Drawing.Color.White;
            this.txt_mGV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(57)))));
            this.txt_mGV.BorderFocusColor = System.Drawing.Color.OrangeRed;
            this.txt_mGV.BorderSize = 2;
            this.txt_mGV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_mGV.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mGV.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txt_mGV.Location = new System.Drawing.Point(168, 56);
            this.txt_mGV.Margin = new System.Windows.Forms.Padding(0);
            this.txt_mGV.Multiline = false;
            this.txt_mGV.Name = "txt_mGV";
            this.txt_mGV.Padding = new System.Windows.Forms.Padding(7);
            this.txt_mGV.PasswordChar = false;
            this.txt_mGV.Size = new System.Drawing.Size(281, 40);
            this.txt_mGV.TabIndex = 1;
            this.txt_mGV.Tag = "1";
            this.txt_mGV.Texts = "";
            this.txt_mGV.UnderlinedStyle = false;
            // 
            // rdb_nam
            // 
            this.rdb_nam.AutoSize = true;
            this.rdb_nam.CheckedColor = System.Drawing.Color.Yellow;
            this.rdb_nam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_nam.Location = new System.Drawing.Point(180, 222);
            this.rdb_nam.MinimumSize = new System.Drawing.Size(0, 21);
            this.rdb_nam.Name = "rdb_nam";
            this.rdb_nam.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rdb_nam.Size = new System.Drawing.Size(82, 29);
            this.rdb_nam.TabIndex = 3;
            this.rdb_nam.Tag = "4";
            this.rdb_nam.Text = "Nam";
            this.rdb_nam.UnCheckedColor = System.Drawing.Color.White;
            this.rdb_nam.UseVisualStyleBackColor = true;
            // 
            // dtp_nsGV
            // 
            this.dtp_nsGV.CalendarFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_nsGV.CalendarTrailingForeColor = System.Drawing.Color.Yellow;
            this.dtp_nsGV.Checked = false;
            this.dtp_nsGV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dtp_nsGV.CustomFormat = "";
            this.dtp_nsGV.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_nsGV.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_nsGV.Location = new System.Drawing.Point(168, 276);
            this.dtp_nsGV.Name = "dtp_nsGV";
            this.dtp_nsGV.Size = new System.Drawing.Size(174, 33);
            this.dtp_nsGV.TabIndex = 5;
            // 
            // cbb_mK
            // 
            this.cbb_mK.BackColor = System.Drawing.Color.White;
            this.cbb_mK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_mK.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_mK.FormattingEnabled = true;
            this.cbb_mK.ItemHeight = 25;
            this.cbb_mK.Items.AddRange(new object[] {
            "Chọn khoa"});
            this.cbb_mK.Location = new System.Drawing.Point(168, 168);
            this.cbb_mK.MaxDropDownItems = 20;
            this.cbb_mK.MaxLength = 100;
            this.cbb_mK.Name = "cbb_mK";
            this.cbb_mK.Size = new System.Drawing.Size(281, 33);
            this.cbb_mK.TabIndex = 3;
            // 
            // MaKhoa
            // 
            this.MaKhoa.AutoSize = true;
            this.MaKhoa.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaKhoa.Location = new System.Drawing.Point(73, 172);
            this.MaKhoa.Name = "MaKhoa";
            this.MaKhoa.Size = new System.Drawing.Size(95, 25);
            this.MaKhoa.TabIndex = 8;
            this.MaKhoa.Text = "Mã Khoa:";
            // 
            // panelbtn
            // 
            this.panelbtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelbtn.Controls.Add(this.btn_sua);
            this.panelbtn.Controls.Add(this.btn_xoa);
            this.panelbtn.Controls.Add(this.btn_them);
            this.panelbtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelbtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelbtn.Location = new System.Drawing.Point(0, 635);
            this.panelbtn.Name = "panelbtn";
            this.panelbtn.Size = new System.Drawing.Size(479, 130);
            this.panelbtn.TabIndex = 22;
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.Khaki;
            this.btn_sua.BackgroundColor = System.Drawing.Color.Khaki;
            this.btn_sua.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_sua.BorderRadius = 20;
            this.btn_sua.BorderSize = 0;
            this.btn_sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sua.FlatAppearance.BorderSize = 0;
            this.btn_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sua.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_sua.Location = new System.Drawing.Point(168, 29);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(150, 50);
            this.btn_sua.TabIndex = 12;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextColor = System.Drawing.SystemColors.Desktop;
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.Red;
            this.btn_xoa.BackgroundColor = System.Drawing.Color.Red;
            this.btn_xoa.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_xoa.BorderRadius = 20;
            this.btn_xoa.BorderSize = 0;
            this.btn_xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_xoa.FlatAppearance.BorderSize = 0;
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoa.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_xoa.Location = new System.Drawing.Point(320, 29);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(150, 50);
            this.btn_xoa.TabIndex = 13;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextColor = System.Drawing.SystemColors.Desktop;
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.Lime;
            this.btn_them.BackgroundColor = System.Drawing.Color.Lime;
            this.btn_them.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_them.BorderRadius = 20;
            this.btn_them.BorderSize = 0;
            this.btn_them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_them.FlatAppearance.BorderSize = 0;
            this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_them.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_them.Location = new System.Drawing.Point(12, 29);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(150, 50);
            this.btn_them.TabIndex = 11;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextColor = System.Drawing.SystemColors.Desktop;
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panelbtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(579, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 765);
            this.panel1.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_enable);
            this.groupBox1.Controls.Add(this.btn_timkiem);
            this.groupBox1.Controls.Add(this.btn_lammoi);
            this.groupBox1.Controls.Add(this.MaGiangVien);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TenGiangVien);
            this.groupBox1.Controls.Add(this.MaKhoa);
            this.groupBox1.Controls.Add(this.GioiTinh);
            this.groupBox1.Controls.Add(this.txt_passwd);
            this.groupBox1.Controls.Add(this.NgaySinh_GV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ChucVu);
            this.groupBox1.Controls.Add(this.txt_chucvu);
            this.groupBox1.Controls.Add(this.cbb_mK);
            this.groupBox1.Controls.Add(this.txt_tenGV);
            this.groupBox1.Controls.Add(this.dtp_nsGV);
            this.groupBox1.Controls.Add(this.rdb_nu);
            this.groupBox1.Controls.Add(this.rdb_nam);
            this.groupBox1.Controls.Add(this.txt_mGV);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 601);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin giảng viên";
            // 
            // dgw_GV
            // 
            this.dgw_GV.AllowUserToAddRows = false;
            this.dgw_GV.AllowUserToDeleteRows = false;
            this.dgw_GV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw_GV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgw_GV.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgw_GV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_GV.Location = new System.Drawing.Point(0, 0);
            this.dgw_GV.Name = "dgw_GV";
            this.dgw_GV.ReadOnly = true;
            this.dgw_GV.Size = new System.Drawing.Size(579, 765);
            this.dgw_GV.TabIndex = 20;
            this.dgw_GV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_GV_CellClick);
            // 
            // frm_GiangVien
            // 
            this.AcceptButton = this.btn_them;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 765);
            this.Controls.Add(this.dgw_GV);
            this.Controls.Add(this.panel1);
            this.Name = "frm_GiangVien";
            this.Text = "Quản lý Giảng viên";
            this.Load += new System.EventHandler(this.frm_GiangVien_Load);
            this.panelbtn.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_GV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label ChucVu;
        private System.Windows.Forms.Label NgaySinh_GV;
        private System.Windows.Forms.Label GioiTinh;
        private System.Windows.Forms.Label MaGiangVien;
        private System.Windows.Forms.Label TenGiangVien;
        private System.Windows.Forms.Label MaKhoa;
        private System.Windows.Forms.Panel panelbtn;
        private System.Windows.Forms.ComboBox cbb_mK;
        private System.Windows.Forms.DateTimePicker dtp_nsGV;
        private System.Windows.Forms.Panel panel1;
        private RJButton btn_them;
        private RJButton btn_sua;
        private RJButton btn_xoa;
        private RJTextBox txt_mGV;
        private RJRadioButton rdb_nam;
        private RJRadioButton rdb_nu;
        private RJTextBox txt_chucvu;
        private RJTextBox txt_tenGV;
        private System.Windows.Forms.DataGridView dgw_GV;
        private System.Windows.Forms.Label label3;
        private RJTextBox txt_passwd;
        private System.Windows.Forms.Label label2;
        private RJToggleButton tb_enable;
        private RJButton btn_lammoi;
        private RJButton btn_timkiem;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
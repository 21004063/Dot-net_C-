namespace PhanMemQuanLiThiTracNghiem
{
    partial class frm_Lop
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelbtn = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textMaLop = new System.Windows.Forms.TextBox();
            this.SoLuongSV = new System.Windows.Forms.Label();
            this.NamNhapHoc = new System.Windows.Forms.Label();
            this.TenLop = new System.Windows.Forms.Label();
            this.MaKhoa = new System.Windows.Forms.Label();
            this.MaLop = new System.Windows.Forms.Label();
            this.cbb_ML = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panelbtn.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.panelbtn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 438);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 200);
            this.panel1.TabIndex = 0;
            // 
            // panelbtn
            // 
            this.panelbtn.Controls.Add(this.btnThem);
            this.panelbtn.Controls.Add(this.btnXoa);
            this.panelbtn.Controls.Add(this.btnSua);
            this.panelbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelbtn.Location = new System.Drawing.Point(1374, 0);
            this.panelbtn.Name = "panelbtn";
            this.panelbtn.Size = new System.Drawing.Size(550, 200);
            this.panelbtn.TabIndex = 22;
            // 
            // btnThem
            // 
            this.btnThem.AutoSize = true;
            this.btnThem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThem.Location = new System.Drawing.Point(26, 76);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(120, 50);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSize = true;
            this.btnXoa.Location = new System.Drawing.Point(172, 76);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(120, 50);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.AutoSize = true;
            this.btnSua.Location = new System.Drawing.Point(318, 76);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(120, 50);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbb_ML);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.textMaLop);
            this.panel2.Controls.Add(this.SoLuongSV);
            this.panel2.Controls.Add(this.NamNhapHoc);
            this.panel2.Controls.Add(this.TenLop);
            this.panel2.Controls.Add(this.MaKhoa);
            this.panel2.Controls.Add(this.MaLop);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1119, 200);
            this.panel2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(694, 110);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(300, 26);
            this.textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(191, 138);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(300, 26);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(191, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 26);
            this.textBox1.TabIndex = 2;
            // 
            // textMaLop
            // 
            this.textMaLop.Location = new System.Drawing.Point(191, 22);
            this.textMaLop.Name = "textMaLop";
            this.textMaLop.Size = new System.Drawing.Size(300, 26);
            this.textMaLop.TabIndex = 1;
            // 
            // SoLuongSV
            // 
            this.SoLuongSV.AutoSize = true;
            this.SoLuongSV.Location = new System.Drawing.Point(12, 141);
            this.SoLuongSV.Name = "SoLuongSV";
            this.SoLuongSV.Size = new System.Drawing.Size(173, 20);
            this.SoLuongSV.TabIndex = 4;
            this.SoLuongSV.Text = "Số Lượng Sinh Viên:";
            // 
            // NamNhapHoc
            // 
            this.NamNhapHoc.AutoSize = true;
            this.NamNhapHoc.Location = new System.Drawing.Point(554, 113);
            this.NamNhapHoc.Name = "NamNhapHoc";
            this.NamNhapHoc.Size = new System.Drawing.Size(134, 20);
            this.NamNhapHoc.TabIndex = 3;
            this.NamNhapHoc.Text = "Năm Nhập Học:";
            // 
            // TenLop
            // 
            this.TenLop.AutoSize = true;
            this.TenLop.Location = new System.Drawing.Point(106, 84);
            this.TenLop.Name = "TenLop";
            this.TenLop.Size = new System.Drawing.Size(79, 20);
            this.TenLop.TabIndex = 2;
            this.TenLop.Text = "Tên Lớp:";
            // 
            // MaKhoa
            // 
            this.MaKhoa.AutoSize = true;
            this.MaKhoa.Location = new System.Drawing.Point(604, 54);
            this.MaKhoa.Name = "MaKhoa";
            this.MaKhoa.Size = new System.Drawing.Size(84, 20);
            this.MaKhoa.TabIndex = 1;
            this.MaKhoa.Text = "Mã Khoa:";
            // 
            // MaLop
            // 
            this.MaLop.AutoSize = true;
            this.MaLop.Location = new System.Drawing.Point(112, 25);
            this.MaLop.Name = "MaLop";
            this.MaLop.Size = new System.Drawing.Size(73, 20);
            this.MaLop.TabIndex = 0;
            this.MaLop.Text = "Mã Lớp:";
            // 
            // cbb_ML
            // 
            this.cbb_ML.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbb_ML.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbb_ML.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_ML.FormattingEnabled = true;
            this.cbb_ML.ItemHeight = 21;
            this.cbb_ML.Items.AddRange(new object[] {
            "CNOT",
            "CNSH",
            "CNTT",
            "KT-L",
            "KHMT"});
            this.cbb_ML.Location = new System.Drawing.Point(694, 50);
            this.cbb_ML.MaxDropDownItems = 20;
            this.cbb_ML.MaxLength = 10;
            this.cbb_ML.Name = "cbb_ML";
            this.cbb_ML.Size = new System.Drawing.Size(300, 29);
            this.cbb_ML.TabIndex = 28;
            // 
            // frm_Lop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 638);
            this.Controls.Add(this.panel1);
            this.Name = "frm_Lop";
            this.Text = "frm_Lop";
            this.panel1.ResumeLayout(false);
            this.panelbtn.ResumeLayout(false);
            this.panelbtn.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label SoLuongSV;
        private System.Windows.Forms.Label NamNhapHoc;
        private System.Windows.Forms.Label TenLop;
        private System.Windows.Forms.Label MaKhoa;
        private System.Windows.Forms.Label MaLop;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textMaLop;
        private System.Windows.Forms.Panel panelbtn;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ComboBox cbb_ML;
    }
}
namespace PhanMemQuanLiThiTracNghiem
{
    partial class frm_QuanLiKhoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QuanLiKhoa));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pic_SapXep = new System.Windows.Forms.PictureBox();
            this.pic_TimKiem = new System.Windows.Forms.PictureBox();
            this.txt_TimKiem = new PhanMemQuanLiThiTracNghiem.RJTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Them = new PhanMemQuanLiThiTracNghiem.RJButton();
            this.rjButton1 = new PhanMemQuanLiThiTracNghiem.RJButton();
            this.btn_Sua = new PhanMemQuanLiThiTracNghiem.RJButton();
            this.btn_Xoa = new PhanMemQuanLiThiTracNghiem.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dat_ThongTinKhoa = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_TenKhoa = new PhanMemQuanLiThiTracNghiem.RJTextBox();
            this.txt_MaKhoa = new PhanMemQuanLiThiTracNghiem.RJTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SapXep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_TimKiem)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dat_ThongTinKhoa)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pic_SapXep);
            this.panel1.Controls.Add(this.pic_TimKiem);
            this.panel1.Controls.Add(this.txt_TimKiem);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 433);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 102);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 8);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 3);
            this.label3.Size = new System.Drawing.Size(71, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tìm kiếm";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pic_SapXep
            // 
            this.pic_SapXep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_SapXep.Image = ((System.Drawing.Image)(resources.GetObject("pic_SapXep.Image")));
            this.pic_SapXep.Location = new System.Drawing.Point(301, 34);
            this.pic_SapXep.Name = "pic_SapXep";
            this.pic_SapXep.Size = new System.Drawing.Size(43, 40);
            this.pic_SapXep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_SapXep.TabIndex = 6;
            this.pic_SapXep.TabStop = false;
            this.pic_SapXep.Click += new System.EventHandler(this.pic_SapXep_Click);
            // 
            // pic_TimKiem
            // 
            this.pic_TimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_TimKiem.Image = ((System.Drawing.Image)(resources.GetObject("pic_TimKiem.Image")));
            this.pic_TimKiem.Location = new System.Drawing.Point(244, 34);
            this.pic_TimKiem.Name = "pic_TimKiem";
            this.pic_TimKiem.Size = new System.Drawing.Size(43, 40);
            this.pic_TimKiem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_TimKiem.TabIndex = 5;
            this.pic_TimKiem.TabStop = false;
            this.pic_TimKiem.Click += new System.EventHandler(this.pic_TimKiem_Click);
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.BackColor = System.Drawing.SystemColors.Window;
            this.txt_TimKiem.BorderColor = System.Drawing.Color.Blue;
            this.txt_TimKiem.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_TimKiem.BorderSize = 2;
            this.txt_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimKiem.Location = new System.Drawing.Point(12, 39);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_TimKiem.Multiline = false;
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Padding = new System.Windows.Forms.Padding(7);
            this.txt_TimKiem.PasswordChar = false;
            this.txt_TimKiem.Size = new System.Drawing.Size(218, 30);
            this.txt_TimKiem.TabIndex = 4;
            this.txt_TimKiem.Texts = "";
            this.txt_TimKiem.UnderlinedStyle = false;
            this.txt_TimKiem._TextChanged += new System.EventHandler(this.txt_TimKiem__TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Them);
            this.panel2.Controls.Add(this.rjButton1);
            this.panel2.Controls.Add(this.btn_Sua);
            this.panel2.Controls.Add(this.btn_Xoa);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(638, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(246, 102);
            this.panel2.TabIndex = 3;
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.Green;
            this.btn_Them.BackgroundColor = System.Drawing.Color.Green;
            this.btn_Them.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Them.BorderRadius = 20;
            this.btn_Them.BorderSize = 0;
            this.btn_Them.FlatAppearance.BorderSize = 0;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Location = new System.Drawing.Point(18, 5);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(88, 40);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextColor = System.Drawing.Color.White;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.rjButton1.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 20;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(143, 56);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(88, 40);
            this.rjButton1.TabIndex = 2;
            this.rjButton1.Text = "Xuất tệp";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Sua.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Sua.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Sua.BorderRadius = 20;
            this.btn_Sua.BorderSize = 0;
            this.btn_Sua.FlatAppearance.BorderSize = 0;
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.White;
            this.btn_Sua.Location = new System.Drawing.Point(143, 5);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(88, 40);
            this.btn_Sua.TabIndex = 2;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.TextColor = System.Drawing.Color.White;
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Xoa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Xoa.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Xoa.BorderRadius = 20;
            this.btn_Xoa.BorderSize = 0;
            this.btn_Xoa.FlatAppearance.BorderSize = 0;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Location = new System.Drawing.Point(18, 56);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(88, 40);
            this.btn_Xoa.TabIndex = 1;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.TextColor = System.Drawing.Color.White;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 37);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 3);
            this.label1.Size = new System.Drawing.Size(70, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 95);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 3);
            this.label2.Size = new System.Drawing.Size(75, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khoa";
            // 
            // dat_ThongTinKhoa
            // 
            this.dat_ThongTinKhoa.AllowDrop = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dat_ThongTinKhoa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dat_ThongTinKhoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dat_ThongTinKhoa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dat_ThongTinKhoa.DefaultCellStyle = dataGridViewCellStyle3;
            this.dat_ThongTinKhoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dat_ThongTinKhoa.Location = new System.Drawing.Point(0, 0);
            this.dat_ThongTinKhoa.Name = "dat_ThongTinKhoa";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dat_ThongTinKhoa.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dat_ThongTinKhoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dat_ThongTinKhoa.Size = new System.Drawing.Size(638, 433);
            this.dat_ThongTinKhoa.TabIndex = 2;
            this.dat_ThongTinKhoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dat_ThongTinKhoa_CellClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txt_TenKhoa);
            this.panel3.Controls.Add(this.txt_MaKhoa);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(638, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(246, 433);
            this.panel3.TabIndex = 3;
            // 
            // txt_TenKhoa
            // 
            this.txt_TenKhoa.BackColor = System.Drawing.SystemColors.Window;
            this.txt_TenKhoa.BorderColor = System.Drawing.Color.Gold;
            this.txt_TenKhoa.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_TenKhoa.BorderSize = 2;
            this.txt_TenKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenKhoa.Location = new System.Drawing.Point(13, 123);
            this.txt_TenKhoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_TenKhoa.Multiline = false;
            this.txt_TenKhoa.Name = "txt_TenKhoa";
            this.txt_TenKhoa.Padding = new System.Windows.Forms.Padding(7);
            this.txt_TenKhoa.PasswordChar = false;
            this.txt_TenKhoa.Size = new System.Drawing.Size(218, 30);
            this.txt_TenKhoa.TabIndex = 2;
            this.txt_TenKhoa.Texts = "";
            this.txt_TenKhoa.UnderlinedStyle = false;
            // 
            // txt_MaKhoa
            // 
            this.txt_MaKhoa.BackColor = System.Drawing.SystemColors.Window;
            this.txt_MaKhoa.BorderColor = System.Drawing.Color.Gold;
            this.txt_MaKhoa.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_MaKhoa.BorderSize = 2;
            this.txt_MaKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaKhoa.Location = new System.Drawing.Point(13, 65);
            this.txt_MaKhoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_MaKhoa.Multiline = false;
            this.txt_MaKhoa.Name = "txt_MaKhoa";
            this.txt_MaKhoa.Padding = new System.Windows.Forms.Padding(7);
            this.txt_MaKhoa.PasswordChar = false;
            this.txt_MaKhoa.Size = new System.Drawing.Size(218, 30);
            this.txt_MaKhoa.TabIndex = 0;
            this.txt_MaKhoa.Texts = "";
            this.txt_MaKhoa.UnderlinedStyle = false;
            // 
            // frm_QuanLiKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 535);
            this.Controls.Add(this.dat_ThongTinKhoa);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_QuanLiKhoa";
            this.Text = "frm_QuanLiKhoa";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SapXep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_TimKiem)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dat_ThongTinKhoa)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private RJButton btn_Sua;
        private RJButton btn_Xoa;
        private RJButton btn_Them;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private RJTextBox txt_MaKhoa;
        private System.Windows.Forms.DataGridView dat_ThongTinKhoa;
        private RJTextBox txt_TenKhoa;
        private System.Windows.Forms.Panel panel3;
        private RJButton rjButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pic_SapXep;
        private System.Windows.Forms.PictureBox pic_TimKiem;
        private RJTextBox txt_TimKiem;
    }
}
namespace PhanMemQuanLiThiTracNghiem
{
    partial class frm_QuanLiAdmin
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
            this.panelinfo = new System.Windows.Forms.Panel();
            this.panelbtn = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.panelTTGV = new System.Windows.Forms.Panel();
            this.textTenGV = new System.Windows.Forms.TextBox();
            this.textMaGV = new System.Windows.Forms.TextBox();
            this.GioiTinh = new System.Windows.Forms.Label();
            this.MaAdmin = new System.Windows.Forms.Label();
            this.TenGiangVien = new System.Windows.Forms.Label();
            this.RB_Nu = new System.Windows.Forms.RadioButton();
            this.RB_Nam = new System.Windows.Forms.RadioButton();
            this.panelinfo.SuspendLayout();
            this.panelbtn.SuspendLayout();
            this.panelTTGV.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelinfo
            // 
            this.panelinfo.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelinfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelinfo.Controls.Add(this.panelbtn);
            this.panelinfo.Controls.Add(this.panelTTGV);
            this.panelinfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelinfo.Location = new System.Drawing.Point(0, 250);
            this.panelinfo.Name = "panelinfo";
            this.panelinfo.Size = new System.Drawing.Size(1924, 200);
            this.panelinfo.TabIndex = 22;
            // 
            // panelbtn
            // 
            this.panelbtn.Controls.Add(this.btnThem);
            this.panelbtn.Controls.Add(this.btnXoa);
            this.panelbtn.Controls.Add(this.btnSua);
            this.panelbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelbtn.Location = new System.Drawing.Point(1372, 0);
            this.panelbtn.Name = "panelbtn";
            this.panelbtn.Size = new System.Drawing.Size(550, 198);
            this.panelbtn.TabIndex = 22;
            // 
            // btnThem
            // 
            this.btnThem.AutoSize = true;
            this.btnThem.Location = new System.Drawing.Point(26, 76);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(120, 50);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
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
            // panelTTGV
            // 
            this.panelTTGV.Controls.Add(this.RB_Nu);
            this.panelTTGV.Controls.Add(this.RB_Nam);
            this.panelTTGV.Controls.Add(this.textTenGV);
            this.panelTTGV.Controls.Add(this.textMaGV);
            this.panelTTGV.Controls.Add(this.GioiTinh);
            this.panelTTGV.Controls.Add(this.MaAdmin);
            this.panelTTGV.Controls.Add(this.TenGiangVien);
            this.panelTTGV.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTTGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTTGV.ForeColor = System.Drawing.SystemColors.Control;
            this.panelTTGV.Location = new System.Drawing.Point(0, 0);
            this.panelTTGV.Name = "panelTTGV";
            this.panelTTGV.Size = new System.Drawing.Size(894, 198);
            this.panelTTGV.TabIndex = 21;
            // 
            // textTenGV
            // 
            this.textTenGV.Location = new System.Drawing.Point(274, 84);
            this.textTenGV.Name = "textTenGV";
            this.textTenGV.Size = new System.Drawing.Size(300, 26);
            this.textTenGV.TabIndex = 2;
            // 
            // textMaGV
            // 
            this.textMaGV.Location = new System.Drawing.Point(274, 25);
            this.textMaGV.Name = "textMaGV";
            this.textMaGV.Size = new System.Drawing.Size(300, 26);
            this.textMaGV.TabIndex = 1;
            // 
            // GioiTinh
            // 
            this.GioiTinh.AutoSize = true;
            this.GioiTinh.Location = new System.Drawing.Point(183, 144);
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Size = new System.Drawing.Size(81, 20);
            this.GioiTinh.TabIndex = 20;
            this.GioiTinh.Text = "Giới tính:";
            // 
            // MaAdmin
            // 
            this.MaAdmin.AutoSize = true;
            this.MaAdmin.Location = new System.Drawing.Point(175, 28);
            this.MaAdmin.Name = "MaAdmin";
            this.MaAdmin.Size = new System.Drawing.Size(93, 20);
            this.MaAdmin.TabIndex = 1;
            this.MaAdmin.Text = "Mã Admin:";
            // 
            // TenGiangVien
            // 
            this.TenGiangVien.AutoSize = true;
            this.TenGiangVien.Location = new System.Drawing.Point(169, 87);
            this.TenGiangVien.Name = "TenGiangVien";
            this.TenGiangVien.Size = new System.Drawing.Size(99, 20);
            this.TenGiangVien.TabIndex = 2;
            this.TenGiangVien.Text = "Tên Admin:";
            // 
            // RB_Nu
            // 
            this.RB_Nu.AutoSize = true;
            this.RB_Nu.Location = new System.Drawing.Point(345, 141);
            this.RB_Nu.Name = "RB_Nu";
            this.RB_Nu.Size = new System.Drawing.Size(49, 24);
            this.RB_Nu.TabIndex = 26;
            this.RB_Nu.TabStop = true;
            this.RB_Nu.Text = "Nữ";
            this.RB_Nu.UseVisualStyleBackColor = true;
            // 
            // RB_Nam
            // 
            this.RB_Nam.AutoSize = true;
            this.RB_Nam.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.RB_Nam.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.RB_Nam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.RB_Nam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.RB_Nam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Nam.Location = new System.Drawing.Point(274, 141);
            this.RB_Nam.Name = "RB_Nam";
            this.RB_Nam.Size = new System.Drawing.Size(65, 25);
            this.RB_Nam.TabIndex = 25;
            this.RB_Nam.TabStop = true;
            this.RB_Nam.Text = "Nam";
            this.RB_Nam.UseVisualStyleBackColor = true;
            // 
            // frm_QuanLiAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 450);
            this.Controls.Add(this.panelinfo);
            this.Name = "frm_QuanLiAdmin";
            this.Text = "frm_QuanLiAdmin";
            this.panelinfo.ResumeLayout(false);
            this.panelbtn.ResumeLayout(false);
            this.panelbtn.PerformLayout();
            this.panelTTGV.ResumeLayout(false);
            this.panelTTGV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelinfo;
        private System.Windows.Forms.Panel panelTTGV;
        private System.Windows.Forms.TextBox textTenGV;
        private System.Windows.Forms.TextBox textMaGV;
        private System.Windows.Forms.Label GioiTinh;
        private System.Windows.Forms.Label MaAdmin;
        private System.Windows.Forms.Label TenGiangVien;
        private System.Windows.Forms.Panel panelbtn;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.RadioButton RB_Nu;
        private System.Windows.Forms.RadioButton RB_Nam;
    }
}
namespace PhanMemQuanLiThiTracNghiem
{
    partial class frm_KetNoiDatabase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_KetNoiDatabase));
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_MayChu = new System.Windows.Forms.ComboBox();
            this.cbx_CSDL = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.psb_TienTrinh = new System.Windows.Forms.ProgressBar();
            this.pnl_TienTrinh = new System.Windows.Forms.Panel();
            this.txt_TienTrinh = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_KetNoi = new PhanMemQuanLiThiTracNghiem.RJButton();
            this.btn_KiemTra = new PhanMemQuanLiThiTracNghiem.RJButton();
            this.pnl_TienTrinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(263, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "KẾT NỐI CƠ SỞ DỮ LIỆU";
            // 
            // cbx_MayChu
            // 
            this.cbx_MayChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_MayChu.FormattingEnabled = true;
            this.cbx_MayChu.Location = new System.Drawing.Point(310, 211);
            this.cbx_MayChu.Name = "cbx_MayChu";
            this.cbx_MayChu.Size = new System.Drawing.Size(240, 32);
            this.cbx_MayChu.TabIndex = 2;
            this.cbx_MayChu.SelectedIndexChanged += new System.EventHandler(this.cbx_MayChu_SelectedIndexChanged);
            // 
            // cbx_CSDL
            // 
            this.cbx_CSDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_CSDL.FormattingEnabled = true;
            this.cbx_CSDL.Location = new System.Drawing.Point(310, 314);
            this.cbx_CSDL.Name = "cbx_CSDL";
            this.cbx_CSDL.Size = new System.Drawing.Size(240, 32);
            this.cbx_CSDL.TabIndex = 3;
            this.cbx_CSDL.SelectedIndexChanged += new System.EventHandler(this.cbx_CSDL_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.RoyalBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(253, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Máy chủ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.RoyalBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(253, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cơ sở dữ liệu";
            // 
            // psb_TienTrinh
            // 
            this.psb_TienTrinh.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.psb_TienTrinh.Location = new System.Drawing.Point(0, 17);
            this.psb_TienTrinh.Name = "psb_TienTrinh";
            this.psb_TienTrinh.Size = new System.Drawing.Size(828, 15);
            this.psb_TienTrinh.TabIndex = 10;
            this.psb_TienTrinh.Click += new System.EventHandler(this.psb_TienTrinh_Click);
            // 
            // pnl_TienTrinh
            // 
            this.pnl_TienTrinh.Controls.Add(this.txt_TienTrinh);
            this.pnl_TienTrinh.Controls.Add(this.psb_TienTrinh);
            this.pnl_TienTrinh.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_TienTrinh.Location = new System.Drawing.Point(0, 473);
            this.pnl_TienTrinh.Name = "pnl_TienTrinh";
            this.pnl_TienTrinh.Size = new System.Drawing.Size(828, 32);
            this.pnl_TienTrinh.TabIndex = 11;
            // 
            // txt_TienTrinh
            // 
            this.txt_TienTrinh.AutoSize = true;
            this.txt_TienTrinh.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txt_TienTrinh.ForeColor = System.Drawing.Color.White;
            this.txt_TienTrinh.Location = new System.Drawing.Point(0, 4);
            this.txt_TienTrinh.Name = "txt_TienTrinh";
            this.txt_TienTrinh.Size = new System.Drawing.Size(54, 13);
            this.txt_TienTrinh.TabIndex = 11;
            this.txt_TienTrinh.Text = "Loading...";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(257, 310);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(46, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(257, 207);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PhanMemQuanLiThiTracNghiem.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(356, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_KetNoi
            // 
            this.btn_KetNoi.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_KetNoi.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btn_KetNoi.BorderColor = System.Drawing.Color.Gold;
            this.btn_KetNoi.BorderRadius = 20;
            this.btn_KetNoi.BorderSize = 2;
            this.btn_KetNoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_KetNoi.FlatAppearance.BorderSize = 0;
            this.btn_KetNoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_KetNoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KetNoi.ForeColor = System.Drawing.Color.White;
            this.btn_KetNoi.Location = new System.Drawing.Point(435, 413);
            this.btn_KetNoi.Name = "btn_KetNoi";
            this.btn_KetNoi.Size = new System.Drawing.Size(115, 43);
            this.btn_KetNoi.TabIndex = 13;
            this.btn_KetNoi.Text = "Kết nối";
            this.btn_KetNoi.TextColor = System.Drawing.Color.White;
            this.btn_KetNoi.UseVisualStyleBackColor = false;
            this.btn_KetNoi.Click += new System.EventHandler(this.btn_KetNoi_Click_1);
            // 
            // btn_KiemTra
            // 
            this.btn_KiemTra.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_KiemTra.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btn_KiemTra.BorderColor = System.Drawing.Color.Gold;
            this.btn_KiemTra.BorderRadius = 20;
            this.btn_KiemTra.BorderSize = 2;
            this.btn_KiemTra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_KiemTra.FlatAppearance.BorderSize = 0;
            this.btn_KiemTra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_KiemTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KiemTra.ForeColor = System.Drawing.Color.White;
            this.btn_KiemTra.Location = new System.Drawing.Point(257, 413);
            this.btn_KiemTra.Name = "btn_KiemTra";
            this.btn_KiemTra.Size = new System.Drawing.Size(115, 43);
            this.btn_KiemTra.TabIndex = 12;
            this.btn_KiemTra.Text = "Kiểm tra";
            this.btn_KiemTra.TextColor = System.Drawing.Color.White;
            this.btn_KiemTra.UseVisualStyleBackColor = false;
            this.btn_KiemTra.Click += new System.EventHandler(this.btn_KiemTra_Click_1);
            // 
            // frm_KetNoiDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(828, 505);
            this.Controls.Add(this.btn_KetNoi);
            this.Controls.Add(this.btn_KiemTra);
            this.Controls.Add(this.pnl_TienTrinh);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbx_CSDL);
            this.Controls.Add(this.cbx_MayChu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frm_KetNoiDatabase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kết nối cơ sở dữ liệu";
            this.Load += new System.EventHandler(this.frm_KetNoiDatabase_Load);
            this.pnl_TienTrinh.ResumeLayout(false);
            this.pnl_TienTrinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_MayChu;
        private System.Windows.Forms.ComboBox cbx_CSDL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ProgressBar psb_TienTrinh;
        private System.Windows.Forms.Panel pnl_TienTrinh;
        private System.Windows.Forms.Label txt_TienTrinh;
        private System.Windows.Forms.Timer timer1;
        private RJButton btn_KiemTra;
        private RJButton btn_KetNoi;
    }
}


namespace PhanMemQuanLiThiTracNghiem
{
    partial class frm_Messagebox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Messagebox));
            this.lab_caption = new System.Windows.Forms.Label();
            this.pnl_mess = new System.Windows.Forms.Panel();
            this.pic_icon = new System.Windows.Forms.PictureBox();
            this.lab_message = new System.Windows.Forms.Label();
            this.pnl_button = new System.Windows.Forms.Panel();
            this.pnl_title = new System.Windows.Forms.Panel();
            this.pic_close = new System.Windows.Forms.PictureBox();
            this.btn_2 = new PhanMemQuanLiThiTracNghiem.RJButton();
            this.btn_3 = new PhanMemQuanLiThiTracNghiem.RJButton();
            this.btn_1 = new PhanMemQuanLiThiTracNghiem.RJButton();
            this.pnl_mess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_icon)).BeginInit();
            this.pnl_button.SuspendLayout();
            this.pnl_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_caption
            // 
            this.lab_caption.AutoSize = true;
            this.lab_caption.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_caption.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lab_caption.Location = new System.Drawing.Point(12, 7);
            this.lab_caption.Name = "lab_caption";
            this.lab_caption.Size = new System.Drawing.Size(61, 19);
            this.lab_caption.TabIndex = 0;
            this.lab_caption.Text = "Caption";
            // 
            // pnl_mess
            // 
            this.pnl_mess.AutoSize = true;
            this.pnl_mess.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnl_mess.Controls.Add(this.pic_icon);
            this.pnl_mess.Controls.Add(this.lab_message);
            this.pnl_mess.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_mess.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_mess.Location = new System.Drawing.Point(0, 45);
            this.pnl_mess.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.pnl_mess.Name = "pnl_mess";
            this.pnl_mess.Size = new System.Drawing.Size(447, 56);
            this.pnl_mess.TabIndex = 2;
            // 
            // pic_icon
            // 
            this.pic_icon.Image = ((System.Drawing.Image)(resources.GetObject("pic_icon.Image")));
            this.pic_icon.Location = new System.Drawing.Point(14, 9);
            this.pic_icon.Name = "pic_icon";
            this.pic_icon.Size = new System.Drawing.Size(46, 44);
            this.pic_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_icon.TabIndex = 1;
            this.pic_icon.TabStop = false;
            // 
            // lab_message
            // 
            this.lab_message.AutoSize = true;
            this.lab_message.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_message.Location = new System.Drawing.Point(76, 9);
            this.lab_message.Name = "lab_message";
            this.lab_message.Size = new System.Drawing.Size(71, 21);
            this.lab_message.TabIndex = 3;
            this.lab_message.Text = "Message";
            // 
            // pnl_button
            // 
            this.pnl_button.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_button.Controls.Add(this.btn_2);
            this.pnl_button.Controls.Add(this.btn_3);
            this.pnl_button.Controls.Add(this.btn_1);
            this.pnl_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_button.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_button.Location = new System.Drawing.Point(0, 101);
            this.pnl_button.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.pnl_button.Name = "pnl_button";
            this.pnl_button.Size = new System.Drawing.Size(447, 56);
            this.pnl_button.TabIndex = 4;
            // 
            // pnl_title
            // 
            this.pnl_title.Controls.Add(this.lab_caption);
            this.pnl_title.Controls.Add(this.pic_close);
            this.pnl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_title.Location = new System.Drawing.Point(0, 0);
            this.pnl_title.Name = "pnl_title";
            this.pnl_title.Size = new System.Drawing.Size(447, 37);
            this.pnl_title.TabIndex = 4;
            this.pnl_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_title_MouseDown);
            // 
            // pic_close
            // 
            this.pic_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.pic_close.Image = ((System.Drawing.Image)(resources.GetObject("pic_close.Image")));
            this.pic_close.Location = new System.Drawing.Point(412, 0);
            this.pic_close.Name = "pic_close";
            this.pic_close.Size = new System.Drawing.Size(35, 37);
            this.pic_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_close.TabIndex = 4;
            this.pic_close.TabStop = false;
            this.pic_close.Click += new System.EventHandler(this.pic_close_Click);
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_2.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_2.BorderRadius = 20;
            this.btn_2.BorderSize = 0;
            this.btn_2.FlatAppearance.BorderSize = 0;
            this.btn_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_2.ForeColor = System.Drawing.Color.White;
            this.btn_2.Location = new System.Drawing.Point(165, 6);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(120, 40);
            this.btn_2.TabIndex = 2;
            this.btn_2.Text = "OK";
            this.btn_2.TextColor = System.Drawing.Color.White;
            this.btn_2.UseVisualStyleBackColor = false;
            // 
            // btn_3
            // 
            this.btn_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(204)))), ((int)(((byte)(110)))));
            this.btn_3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(204)))), ((int)(((byte)(110)))));
            this.btn_3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_3.BorderRadius = 20;
            this.btn_3.BorderSize = 0;
            this.btn_3.FlatAppearance.BorderSize = 0;
            this.btn_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_3.ForeColor = System.Drawing.Color.White;
            this.btn_3.Location = new System.Drawing.Point(306, 6);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(120, 40);
            this.btn_3.TabIndex = 1;
            this.btn_3.Text = "No";
            this.btn_3.TextColor = System.Drawing.Color.White;
            this.btn_3.UseVisualStyleBackColor = false;
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_1.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_1.BorderRadius = 20;
            this.btn_1.BorderSize = 0;
            this.btn_1.FlatAppearance.BorderSize = 0;
            this.btn_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_1.ForeColor = System.Drawing.Color.White;
            this.btn_1.Location = new System.Drawing.Point(24, 6);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(120, 40);
            this.btn_1.TabIndex = 0;
            this.btn_1.Text = "Yes";
            this.btn_1.TextColor = System.Drawing.Color.White;
            this.btn_1.UseVisualStyleBackColor = false;
            // 
            // frm_Messagebox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(447, 157);
            this.Controls.Add(this.pnl_mess);
            this.Controls.Add(this.pnl_title);
            this.Controls.Add(this.pnl_button);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "frm_Messagebox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Messagebox";
            this.pnl_mess.ResumeLayout(false);
            this.pnl_mess.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_icon)).EndInit();
            this.pnl_button.ResumeLayout(false);
            this.pnl_title.ResumeLayout(false);
            this.pnl_title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_caption;
        private System.Windows.Forms.PictureBox pic_icon;
        private System.Windows.Forms.Panel pnl_mess;
        private System.Windows.Forms.Label lab_message;
        private System.Windows.Forms.Panel pnl_button;
        private RJButton btn_1;
        private RJButton btn_2;
        private RJButton btn_3;
        private System.Windows.Forms.Panel pnl_title;
        private System.Windows.Forms.PictureBox pic_close;
    }
}
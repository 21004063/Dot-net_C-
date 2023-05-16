using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLiThiTracNghiem
{
    public partial class frm_Messagebox : Form
    {
        //Fields
        private Color primaryColor = Color.DeepSkyBlue;
        private int borderSize = 2;

        //Properties
        public Color PrimaryColor
        {
            get { return primaryColor; }
            set
            {
                primaryColor = value;
                this.BackColor = primaryColor;//Form Border Color
                this.pnl_title.BackColor = PrimaryColor;//Title Bar Back Color
            }
        }

        //Constructors
        public frm_Messagebox(string text)
        {
            InitializeComponent();
            InitializeItems();
            this.PrimaryColor = primaryColor;
            this.lab_message.Text = text;
            this.lab_caption.Text = "";
            SetFormSize();
            SetButtons(MessageBoxButtons.OK, MessageBoxDefaultButton.Button1);//Set Default Buttons
        }
        public frm_Messagebox(string text, string caption)
        {
            InitializeComponent();
            InitializeItems();
            this.PrimaryColor = primaryColor;
            this.lab_message.Text = text;
            this.lab_caption.Text = caption;
            SetFormSize();
            SetButtons(MessageBoxButtons.OK, MessageBoxDefaultButton.Button1);//Set Default Buttons
        }
        public frm_Messagebox(string text, string caption, MessageBoxButtons buttons)
        {
            InitializeComponent();
            InitializeItems();
            this.PrimaryColor = primaryColor;
            this.lab_message.Text = text;
            this.lab_caption.Text = caption;
            SetFormSize();
            SetButtons(buttons, MessageBoxDefaultButton.Button1);//Set [Default Button 1]
        }
        public frm_Messagebox(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            InitializeComponent();
            InitializeItems();
            this.PrimaryColor = primaryColor;
            this.lab_message.Text = text;
            this.lab_caption.Text = caption;
            SetFormSize();
            SetButtons(buttons, MessageBoxDefaultButton.Button1);//Set [Default Button 1]
            SetIcon(icon);
        }
        public frm_Messagebox(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
        {
            InitializeComponent();
            InitializeItems();
            this.PrimaryColor = primaryColor;
            this.lab_message.Text = text;
            this.lab_caption.Text = caption;
            SetFormSize();
            SetButtons(buttons, defaultButton);
            SetIcon(icon);
        }

        //-> Private Methods
        private void InitializeItems()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);//Set border size
            this.lab_message.MaximumSize = new Size(550, 0);
            //this.pic_close.DialogResult = DialogResult.Cancel;
            this.btn_1.DialogResult = DialogResult.OK;
            this.btn_1.Visible = false;
            this.btn_2.Visible = false;
            this.btn_3.Visible = false;
        }
        private void SetFormSize()
        {

            /*int widht = this.lab_message.Width + this.pic_icon.Width + this.pnl_button.Padding.Left;
            int height = this.pnl_title.Height + this.lab_message.Height + this.pnl_mess.Height + this.pnl_button.Padding.Top;
            this.Size = new Size(widht, height);*/

            int widht = this.pic_icon.Width + this.lab_message.Width + 50 + this.pic_close.Width;
            int height = this.pnl_title.Height + this.pnl_mess.Height + this.pnl_button.Height + this.pnl_mess.Margin.Top ;
            this.Size = new Size(widht, height);
        }
        private void SetButtons(MessageBoxButtons buttons, MessageBoxDefaultButton defaultButton)
        {
            int xCenter = (this.pnl_button.Width - btn_1.Width) / 2;
            int yCenter = (this.pnl_button.Height - btn_1.Height) / 2;

            switch (buttons)
            {
                case MessageBoxButtons.OK:
                    //OK Button
                    btn_1.Visible = true;
                    btn_1.Location = new Point(xCenter, yCenter);
                    btn_1.Text = "OK";
                    btn_1.DialogResult = DialogResult.OK;//Set DialogResult

                    //Set Default Button
                    SetDefaultButton(defaultButton);
                    break;
                /*case MessageBoxButtons.OKCancel:
                    //OK Button
                    btn_1.Visible = true;
                    btn_1.Location = new Point(xCenter - (btn_1.Width / 2) - 5, yCenter);
                    btn_1.Text = "Ok";
                    btn_1.DialogResult = DialogResult.OK;//Set DialogResult

                    //Cancel Button
                    btn_2.Visible = true;
                    btn_2.Location = new Point(xCenter + (btn_2.Width / 2) + 5, yCenter);
                    btn_2.Text = "Cancel";
                    btn_2.DialogResult = DialogResult.Cancel;//Set DialogResult
                    btn_2.BackColor = Color.DimGray;

                    //Set Default Button
                    if (defaultButton != MessageBoxDefaultButton.Button3)//There are only 2 buttons, so the Default Button cannot be Button3
                        SetDefaultButton(defaultButton);
                    else SetDefaultButton(MessageBoxDefaultButton.Button1);
                    break;*/

               /* case MessageBoxButtons.RetryCancel:
                    //Retry Button
                    btn_1.Visible = true;
                    btn_1.Location = new Point(xCenter - (btn_1.Width / 2) - 5, yCenter);
                    btn_1.Text = "Retry";
                    btn_1.DialogResult = DialogResult.Retry;//Set DialogResult

                    //Cancel Button
                    btn_2.Visible = true;
                    btn_2.Location = new Point(xCenter + (btn_2.Width / 2) + 5, yCenter);
                    btn_2.Text = "Cancel";
                    btn_2.DialogResult = DialogResult.Cancel;//Set DialogResult
                    btn_2.BackColor = Color.DimGray;

                    //Set Default Button
                    if (defaultButton != MessageBoxDefaultButton.Button3)//There are only 2 buttons, so the Default Button cannot be Button3
                        SetDefaultButton(defaultButton);
                    else SetDefaultButton(MessageBoxDefaultButton.Button1);
                    break;*/

                case MessageBoxButtons.YesNo:
                    //Yes Button
                    btn_1.Visible = true;
                    btn_1.Location = new Point(xCenter - (btn_1.Width / 2) - 5, yCenter);
                    btn_1.Text = "Yes";
                    btn_1.DialogResult = DialogResult.Yes;//Set DialogResult

                    //No Button
                    btn_2.Visible = true;
                    btn_2.Location = new Point(xCenter + (btn_2.Width / 2) + 5, yCenter);
                    btn_2.Text = "No";
                    btn_2.DialogResult = DialogResult.No;//Set DialogResult
                    btn_2.BackColor = Color.IndianRed;

                    //Set Default Button
                    if (defaultButton != MessageBoxDefaultButton.Button3)//There are only 2 buttons, so the Default Button cannot be Button3
                        SetDefaultButton(defaultButton);
                    else SetDefaultButton(MessageBoxDefaultButton.Button1);
                    break;
                /*case MessageBoxButtons.YesNoCancel:
                    //Yes Button
                    btn_1.Visible = true;
                    btn_1.Location = new Point(xCenter - btn_1.Width - 5, yCenter);
                    btn_1.Text = "Yes";
                    btn_1.DialogResult = DialogResult.Yes;//Set DialogResult

                    //No Button
                    btn_2.Visible = true;
                    btn_2.Location = new Point(xCenter, yCenter);
                    btn_2.Text = "No";
                    btn_2.DialogResult = DialogResult.No;//Set DialogResult
                    btn_2.BackColor = Color.IndianRed;

                    //Cancel Button
                    btn_3.Visible = true;
                    btn_3.Location = new Point(xCenter + btn_2.Width + 5, yCenter);
                    btn_3.Text = "Cancel";
                    btn_3.DialogResult = DialogResult.Cancel;//Set DialogResult
                    btn_3.BackColor = Color.DimGray;

                    //Set Default Button
                    SetDefaultButton(defaultButton);
                    break;*/

                /*case MessageBoxButtons.AbortRetryIgnore:
                    //Abort Button
                    btn_1.Visible = true;
                    btn_1.Location = new Point(xCenter - btn_1.Width - 5, yCenter);
                    btn_1.Text = "Abort";
                    btn_1.DialogResult = DialogResult.Abort;//Set DialogResult
                    btn_1.BackColor = Color.Goldenrod;

                    //Retry Button
                    btn_2.Visible = true;
                    btn_2.Location = new Point(xCenter, yCenter);
                    btn_2.Text = "Retry";
                    btn_2.DialogResult = DialogResult.Retry;//Set DialogResult                    

                    //Ignore Button
                    btn_3.Visible = true;
                    btn_3.Location = new Point(xCenter + btn_2.Width + 5, yCenter);
                    btn_3.Text = "Ignore";
                    btn_3.DialogResult = DialogResult.Ignore;//Set DialogResult
                    btn_3.BackColor = Color.IndianRed;

                    //Set Default Button
                    SetDefaultButton(defaultButton);
                    break;*/
            }
        }
        private void SetDefaultButton(MessageBoxDefaultButton defaultButton)
        {
            switch (defaultButton)
            {
                case MessageBoxDefaultButton.Button1://Focus button 1
                    btn_1.Select();
                    btn_1.ForeColor = Color.White;
                    btn_1.Font = new Font(btn_1.Font, FontStyle.Underline);
                    break;
                case MessageBoxDefaultButton.Button2://Focus button 2
                    btn_2.Select();
                    btn_2.ForeColor = Color.White;
                    btn_2.Font = new Font(btn_2.Font, FontStyle.Underline);
                    break;
                case MessageBoxDefaultButton.Button3://Focus button 3
                    btn_3.Select();
                    btn_3.ForeColor = Color.White;
                    btn_3.Font = new Font(btn_3.Font, FontStyle.Underline);
                    break;
            }
        }
        private void SetIcon(MessageBoxIcon icon)
        {
            switch (icon)
            {
                case MessageBoxIcon.Error: //Error
                    this.pic_icon.Image = Properties.Resources.error;
                    PrimaryColor = Color.FromArgb(224, 79, 95);
                    //this.pic_close.FlatAppearance.MouseOverBackColor = Color.Crimson;
                    break;
                case MessageBoxIcon.Information: //Information
                    this.pic_icon.Image = Properties.Resources.info;
                    PrimaryColor = Color.DeepSkyBlue;    //.FromArgb(38, 191, 166);
                    break;
                case MessageBoxIcon.Question://Question
                    this.pic_icon.Image = Properties.Resources.question;
                    PrimaryColor = Color.FromArgb(10, 119, 232);
                    break;
                case MessageBoxIcon.Warning://Exclamation
                    this.pic_icon.Image = Properties.Resources.warning;
                    PrimaryColor = Color.FromArgb(255, 140, 0);
                    break;
                /*case MessageBoxIcon.None: //None
                    this.pic_icon.Image = Properties.Resources.chat;
                    PrimaryColor = Color.CornflowerBlue;
                    break;*/
            }
        }


        //-> Events Methods
        

        private void pic_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region -> Drag Form
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        #endregion
        

        private void pnl_title_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        
    }


    
}


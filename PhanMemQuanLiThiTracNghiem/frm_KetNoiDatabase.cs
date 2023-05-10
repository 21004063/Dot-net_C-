using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PhanMemQuanLiThiTracNghiem
{
    public partial class frm_KetNoiDatabase : Form
    {
        public static List<string> listserver = new List<string>();
        public frm_KetNoiDatabase()
        {
            InitializeComponent();
            psb_TienTrinh.Value = 30;
            txt_TienTrinh.Text = "Loading... " + psb_TienTrinh.Value + "%";
        }

        private void cbx_MayChu_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbx_CSDL.DataSource = GetInfo.GetDatabase(cbx_MayChu.Text);
        }

        private void cbx_CSDL_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (psb_TienTrinh.Value < 100)
            {
                psb_TienTrinh.Value += 5;
                txt_TienTrinh.Text = "Loading... " + psb_TienTrinh.Value + "%";
                if (listserver.Count == 0)
                {
                    foreach (String item in GetInfo.GetSqlInstances())
                    {
                        if (GetInfo.TryServerName(item) == true)
                        {
                            listserver.Add(item);
                            break;
                        }
                    }
                    cbx_MayChu.DataSource = listserver;
                }
            }
            else
            {
                pnl_TienTrinh.Hide();
                timer1.Stop();
            }
        }

        private void psb_TienTrinh_Click(object sender, EventArgs e)
        {

        }

        private void frm_KetNoiDatabase_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btn_KiemTra_Click_1(object sender, EventArgs e)
        {
            GetInfo.TestSqlConnection(cbx_MayChu.Text, cbx_CSDL.Text);
        }

        private void btn_KetNoi_Click_1(object sender, EventArgs e)
        {
            GetInfo.ApplySqlConnection(cbx_MayChu.Text, cbx_CSDL.Text);
            frm_DangNhap form_DangNhap = new frm_DangNhap();
            //Ẩn form hiện tại (kết nối CSDL)
            this.Hide();
            form_DangNhap.ShowDialog();
            //Mở sang form đăng nhập
            this.Close();
        }
    }
}

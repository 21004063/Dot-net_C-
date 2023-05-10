using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLiThiTracNghiem
{
    public partial class frm_QuanTri : Form
    {
        public frm_QuanTri()
        {
            InitializeComponent();
            TrangThaiMacDinh();
        }

        //Mở form con
        private Form currentFormChild;

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
                currentFormChild.Close();
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnl_HienThi.Controls.Add(childForm);
            pnl_HienThi.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
        }
        //

        public void LayTinNguoiDung(string tentaikhoan)
        {
            txt_TenNguoiDung.Text = tentaikhoan;
        }
       

        private void TrangThaiMacDinh()
        {
            pnl_QuanLiChung.Visible = false;
            pnl_QuanLiNguoiDung.Visible = false;
            //điền vào nếu cần thêm
        }

        private void AnHienDanhSach()
        {
            if (pnl_DanhSach.Visible == true)
                pnl_DanhSach.Visible = false;
            else
                pnl_DanhSach.Visible = true;
        }

        private void AnMenuCon()
        {
            if (pnl_QuanLiChung.Visible == true)
                pnl_QuanLiChung.Visible = false;
            if (pnl_QuanLiNguoiDung.Visible == true)
                pnl_QuanLiNguoiDung.Visible = false;
        }

        private void HienMenuCon(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                AnMenuCon();
                subMenu.Visible = true;
;            }
            else
                subMenu.Visible = false;
        }

        private void btn_QuanLiChung_Click(object sender, EventArgs e)
        {
            HienMenuCon(pnl_QuanLiChung);
        }

        private void DoiMaubtn(Button active)
        {
            btn_QLKhoa.BackColor = Color.RoyalBlue;
            btn_QLLop.BackColor = Color.RoyalBlue;
            btn_QLHocKi.BackColor = Color.RoyalBlue;
            btn_QLQuanTriVien.BackColor = Color.RoyalBlue;
            btn_QLGiaoVien.BackColor = Color.RoyalBlue;
            btn_QLSinhVien.BackColor = Color.RoyalBlue;
            btn_QLMonHoc.BackColor = Color.Navy;
            btn_QLCauHoi.BackColor = Color.Navy;
            btn_QLDeThi.BackColor = Color.Navy;
            btn_QLKetQuaThi.BackColor = Color.Navy;
            active.BackColor = Color.Crimson;
        }

        private void btn_QLKhoa_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_QuanLiKhoa());
            //Code chức năng cho QL Khoa
            btn_QLKhoa.BackColor = Color.Crimson;
            
            btn_QLLop.BackColor = Color.RoyalBlue;
            btn_QLHocKi.BackColor = Color.RoyalBlue;
            btn_QLQuanTriVien.BackColor = Color.RoyalBlue;
            btn_QLGiaoVien.BackColor = Color.RoyalBlue;
            btn_QLSinhVien.BackColor = Color.RoyalBlue;
            btn_QLMonHoc.BackColor = Color.Navy;
            btn_QLCauHoi.BackColor = Color.Navy;
            btn_QLDeThi.BackColor = Color.Navy;
            btn_QLKetQuaThi.BackColor = Color.Navy;
        }

        private void btn_QuanLiNguoiDung_Click(object sender, EventArgs e)
        {
            HienMenuCon(pnl_QuanLiNguoiDung);
        }

        private void pic_DanhSach_Click(object sender, EventArgs e)
        {
            AnHienDanhSach();
        }

        private void tim_NgayGio_Tick(object sender, EventArgs e)
        {
            txt_NgayGio.Text = DateTime.Now.ToString("dddd - dd/MM/yyyy HH:mm:ss");
        }

        private void frm_QuanTri_Load(object sender, EventArgs e)
        {
            tim_NgayGio.Start();
        }

        private void btn_QLLop_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Lop());

            DoiMaubtn(btn_QLLop);

        }

        private void btn_QLHocKi_Click(object sender, EventArgs e)
        {
            DoiMaubtn(btn_QLHocKi);
        }
        private void btn_QLQuanTriVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_QuanLiAdmin());

            DoiMaubtn(btn_QLQuanTriVien);
        }
        private void btn_QLGiaoVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_GiangVien());
            DoiMaubtn(btn_QLGiaoVien);
            
        }

        private void btn_QLSinhVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_SinhVien());
            DoiMaubtn(btn_QLSinhVien);
        }
        
        private void btn_QLMonHoc_Click(object sender, EventArgs e)
        {
            DoiMaubtn(btn_QLMonHoc);
        }

        private void btn_QLCauHoi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_CauHoi());

            DoiMaubtn(btn_QLCauHoi);
        }
        private void btn_QLKetQuaThi_Click(object sender, EventArgs e)
        {
            DoiMaubtn(btn_QLDeThi);
        }

        private void btn_QLKetQuaThi_Click_1(object sender, EventArgs e)
        {
            DoiMaubtn(btn_QLKetQuaThi);
        }
        private void pnl_HienThi_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

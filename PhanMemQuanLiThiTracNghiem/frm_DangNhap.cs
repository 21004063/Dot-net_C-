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
    public partial class frm_DangNhap : Form
    {
        public frm_DangNhap()
        {
            InitializeComponent();
        }

        Modify modify = new Modify();
        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void rjTextBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_HienMK.Checked)
                txt_MatKhau.PasswordChar = false;
            else
                txt_MatKhau.PasswordChar = true;
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string username_input = txt_TenTK.Texts;
            string password_input = txt_MatKhau.Texts;

            //Kiểm tra điều kiện đầu vào
            if (username_input.Trim() == "")
            {
                Notification.Noti_Empty("tên tài khoản");
                return;
            }
            else
                if (password_input.Trim() == "")
            {
                Notification.Noti_Empty("mật khẩu");
                return;
            }
            else
                    if (Check.Chu_HoaThuongSo(username_input) == false || Check.Chu_HoaThuongSo(password_input) == false)
            {
                Notification.Noti_Info("Tên tài khoản và mật khẩu không được chứa kí tự đặc biệt, chiều dài phải từ 2-49!");
                return;
            }
            else
            {
                //query truy vấn tìm user và password hợp lệ
                string queryad = "SELECT * from ADMINACCOUNTS  where UIDAD  = '" + username_input + "' and PASSWORDAD  = '" + password_input + "'";
                string querygv = "SELECT * from GVACCOUNTS  where UIDGV  = '" + username_input + "' and PASSWORDGV  = '" + password_input + "'";
                string querysv = "SELECT * from SVACCOUNTS  where UIDSV  = '" + username_input + "' and PASSWORDSV  = '" + password_input + "'";

                if (Check.UserGroup(username_input) == "admin")
                {
                    //
                    if (modify.Accounts(queryad).Count != 0)
                    {
                        if (modify.Accounts(queryad)[0].Status == false)
                        {
                            Notification.Noti_Info("Tài khoản đã bị khóa, Vui lòng liên hệ quản trị viên!");
                            return;
                        }
                        else
                        {
                            //Thành công và là Administrator
                            frm_QuanTri form_QuanTri = new frm_QuanTri();
                            this.Hide();
                            Notification.Noti_Info("Chào Administrator, Đăng nhập thành công!");
                            form_QuanTri.LayTinNguoiDung(modify.Accounts(queryad)[0].Username);
                            form_QuanTri.ShowDialog();
                            this.Show();
                        }
                    }
                    else
                    {
                        Notification.Noti_Info("Tên tài khoản hoặc mật khẩu không đúng!");
                    }
                }
                else
                    if (Check.UserGroup(username_input) == "giangvien")
                {
                    //
                    if (modify.Accounts(querygv).Count != 0)
                    {
                        if (modify.Accounts(querygv)[0].Status == false)
                        {
                            Notification.Noti_Info("Tài khoản đã bị khóa, Vui lòng liên hệ quản trị viên!");
                            return;
                        }
                        else
                        {
                            //Thành công và là Giảng Viên
                            Notification.Noti_Info("Chào Giảng Viên, Đăng nhập thành công!");
                        }
                    }
                    else
                    {
                        Notification.Noti_Info("Tên tài khoản hoặc mật khẩu không đúng!");
                    }
                }
                else
                        if (Check.UserGroup(username_input) == "sinhvien")
                {
                    //
                    if (modify.Accounts(querysv).Count != 0)
                    {
                        if (modify.Accounts(querysv)[0].Status == false)
                        {
                            Notification.Noti_Info("Tài khoản đã bị khóa, Vui lòng liên hệ quản trị viên!");
                            return;
                        }
                        else
                        {
                            //Thành công và là Sinh Viên
                            Notification.Noti_Info("Chào Sinh Viên, Đăng nhập thành công!");
                        }
                    }
                    else
                    {
                        Notification.Noti_Info("Tên tài khoản hoặc mật khẩu không đúng!");
                    }
                }
                else
                    Notification.Noti_Info("Tên tài khoản hoặc mật khẩu không đúng!");
            }
        }
    }
}

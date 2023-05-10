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
    public partial class frm_QuanLiKhoa : Form
    {
        Modify modify = new Modify();
        List<Khoa> khoas = new List<Khoa>();
        public frm_QuanLiKhoa()
        {
            InitializeComponent();
            HienThiKhoa();
        }
        
        string querykhoa = "SELECT * from KHOA ORDER BY MAKHOA ASC";
        private void HienThiKhoa()
        {
            khoas = modify.ThongTinKhoa(querykhoa);
            dat_ThongTinKhoa.DataSource = khoas;
            dat_ThongTinKhoa.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void dat_ThongTinKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            DataGridViewRow row = dat_ThongTinKhoa.Rows[e.RowIndex];
            txt_MaKhoa.Texts = row.Cells[0].Value.ToString();
            txt_TenKhoa.Texts = row.Cells[1].Value.ToString();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                string makhoa = txt_MaKhoa.Texts.Trim();
                string tenkhoa = txt_TenKhoa.Texts.Trim();
                if (Check.MaKhoa(makhoa) == true)
                {
                    string insertkhoa = "INSERT INTO KHOA VALUES ('" + makhoa + "','" + tenkhoa + "')";
                    foreach(Khoa item in khoas)
                    {
                        if (makhoa == item.MaKhoa)
                        {
                            Notification.Noti_Info("Đã tồn tại mã khoa này!");
                            return;
                        }
                    }
                    modify.ChinhSuaDuLieu(insertkhoa);
                    Notification.Noti_Info("Thêm thành công!");
                    HienThiKhoa();
                }
                else
                    Notification.Noti_Info("Dữ liệu nhập không hợp lệ!");
            }
            catch
            {
                Notification.Noti_Info("Thêm không thành công!");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                string makhoa = txt_MaKhoa.Texts.Trim();
                string tenkhoa = txt_TenKhoa.Texts.Trim();
                bool flag = false;
                if (Check.Chu_HoaThuongSo(makhoa) == true)
                {
                    string updatekhoa = "UPDATE KHOA SET MAKHOA = '"+makhoa+"', TENKHOA = '"+tenkhoa+"' WHERE MAKHOA = '"+makhoa+"'; ";
                    foreach (Khoa item in khoas)
                    {
                        if (makhoa == item.MaKhoa && tenkhoa == item.TenKhoa)
                        {
                            return;
                        }
                        if (makhoa == item.MaKhoa)
                        {
                            flag = true;
                            break;
                        }
                            
                    }
                    if (flag == true)
                    {
                        modify.ChinhSuaDuLieu(updatekhoa);
                        Notification.Noti_Info("Sửa thành công!");
                        HienThiKhoa();
                    }
                    else
                        Notification.Noti_Info("Không tồn tại mã khoa này!");
                }
                else
                    Notification.Noti_Info("Dữ liệu nhập không hợp lệ!");
            }
            catch
            {
                Notification.Noti_Info("Sửa không thành công!");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                string makhoa = txt_MaKhoa.Texts.Trim();
                string tenkhoa = txt_TenKhoa.Texts.Trim();
                bool flag = false;
                if (Check.Chu_HoaThuongSo(makhoa) == true)
                {
                    string deletekhoa = "DELETE FROM KHOA WHERE MAKHOA = '"+makhoa+"'";
                    foreach (Khoa item in khoas)
                    {
                        if (makhoa == item.MaKhoa)
                        {
                            flag = true;
                            break;
                        }
                    }
                    if (flag == true)
                    {
                        string thongbao = "Bạn có chắc chắn xóa khoa có mã '"+makhoa+"' không?";
                        if (Notification.Noti_YesNo(thongbao) == true)
                        {
                            modify.ChinhSuaDuLieu(deletekhoa);
                            txt_MaKhoa.Texts = "";
                            txt_TenKhoa.Texts = "";
                            Notification.Noti_Info("Xóa thành công!");
                            HienThiKhoa();
                        }
                        else
                            return;
                    }
                    else
                        Notification.Noti_Info("Không tồn tại mã khoa này!");
                }
                else
                    Notification.Noti_Info("Dữ liệu nhập không hợp lệ!");
            }
            catch
            {
                Notification.Noti_Info("Xóa không thành công!");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pic_TimKiem_Click(object sender, EventArgs e)
        {
            if (Check.TimMaKhoa(txt_TimKiem.Texts.Trim()))
            {
                querykhoa = "SELECT * from KHOA WHERE MAKHOA LIKE '%" + txt_TimKiem.Texts.Trim() + "%' OR TENKHOA LIKE '%" + txt_TimKiem.Texts.Trim() + "%' ORDER BY MAKHOA ASC";
                HienThiKhoa();
            }
            else
                Notification.Noti_Info("Dữ liệu tìm kiếm chưa hợp lệ!");
        }

        bool tangdan = true;
        private void pic_SapXep_Click(object sender, EventArgs e)
        {
            if (txt_TimKiem.Texts.Trim() == "")
            {
                if (tangdan == true)
                {
                    querykhoa = "SELECT * from KHOA ORDER BY MAKHOA DESC";
                    HienThiKhoa();
                    tangdan = false;
                }
                else
                {
                    querykhoa = "SELECT * from KHOA ORDER BY MAKHOA ASC";
                    HienThiKhoa();
                    tangdan = true;
                }
            }
            else
            {
                if (Check.TimMaKhoa(txt_TimKiem.Texts.Trim()))
                {
                    if (tangdan == true)
                    {
                        querykhoa = "SELECT * from KHOA WHERE MAKHOA LIKE '%" + txt_TimKiem.Texts.Trim() + "%' OR TENKHOA LIKE '%" + txt_TimKiem.Texts.Trim() + "%' ORDER BY MAKHOA DESC";
                        HienThiKhoa();
                        tangdan = false;
                    }
                    else
                    {
                        querykhoa = "SELECT * from KHOA WHERE MAKHOA LIKE '%" + txt_TimKiem.Texts.Trim() + "%' OR TENKHOA LIKE '%" + txt_TimKiem.Texts.Trim() + "%' ORDER BY MAKHOA ASC";
                        HienThiKhoa();
                        tangdan = true;
                    }
                }
                else
                    Notification.Noti_Info("Dữ liệu tìm kiếm chưa hợp lệ!");
            }
            
        }

        private void txt_TimKiem__TextChanged(object sender, EventArgs e)
        {
            if (Check.TimMaKhoa(txt_MaKhoa.Texts.Trim()))
            {
                querykhoa = "SELECT * from KHOA WHERE MAKHOA LIKE '%" + txt_TimKiem.Texts.Trim() + "%' OR TENKHOA LIKE '%" + txt_TimKiem.Texts.Trim() + "%' ORDER BY MAKHOA ASC";
                HienThiKhoa();
            }
            else
                return;
        }
    }
}

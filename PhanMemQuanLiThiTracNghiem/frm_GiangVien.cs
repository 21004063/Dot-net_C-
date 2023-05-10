using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Data.Common;


namespace PhanMemQuanLiThiTracNghiem
{


    public partial class frm_GiangVien : Form
    {
        public frm_GiangVien()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = ConnectionData.GetSqlConnection();
        private void frm_GiangVien_Load(object sender, EventArgs e)
        {
            HienThiGiangVien(query);

            ComboBox_Khoa();

        }
        

        Modify modify = new Modify();
        List<Giangvien> Giangviens = new List<Giangvien>();
        string query = "SELECT GIANGVIEN.MSGV,HOTENGV,GIANGVIEN.MAKHOA,TENKHOA,GIOITINHGV,NGAYSINHGV,CHUCVU,PASSWORDGV,ENABLEGV FROM GIANGVIEN INNER JOIN GVACCOUNTS ON GIANGVIEN.MSGV = GVACCOUNTS.MSGV INNER JOIN KHOA ON KHOA.MAKHOA = GIANGVIEN.MAKHOA";
        public void HienThiGiangVien(string Q)
        {
            Giangviens = modify.ThongTinGiangVien(Q);
            DataTable dataGiangviens = new DataTable();
            dataGiangviens.Columns.Add("Mã số giảng viên");
            dataGiangviens.Columns.Add("Họ tên giảng viên");
            dataGiangviens.Columns.Add("Mã khoa");
            dataGiangviens.Columns.Add("Tên Khoa");
            dataGiangviens.Columns.Add("Giới tính");
            dataGiangviens.Columns.Add("Ngày sinh",typeof(DateTime));
            dataGiangviens.Columns.Add("Chức vụ");
            dataGiangviens.Columns.Add("Mật khẩu");
            dataGiangviens.Columns.Add("Kích hoạt tài khoản",typeof(Boolean));
            foreach (Giangvien item in Giangviens)
            {
                DataRow row = dataGiangviens.NewRow();
                row["Mã số giảng viên"] = item.Msgv;
                row["Họ tên giảng viên"] = item.Tengv;
                row["Mã khoa"] = item.Mk;
                row["Tên Khoa"] = item.Tenkhoa;
                if (item.Gt == true)
                    row["Giới tính"] = "Nam";
                else
                    row["Giới tính"] = "Nữ";
                row["Ngày sinh"] = item.Ns;
                row["Chức vụ"] = item.Cv;
                row["Mật khẩu"] = item.Passwd;
                row["Kích hoạt tài khoản"] = item.Enable;
                dataGiangviens.Rows.Add(row);
            }

            dgw_GV.DataSource = dataGiangviens;
            dgw_GV.ColumnHeadersHeight = 50;
            dgw_GV.RowHeadersWidth = 50;
            dgw_GV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        public void ComboBox_Khoa()
        {
            // hiển thị ComboBox_Khoa

            // Tạo đối tượng SqlDataAdapter để thực thi câu lệnh truy vấn và lấy dữ liệu từ database.
            SqlDataAdapter adapter = new SqlDataAdapter("select MAKHOA,TENKHOA from KHOA", sqlConnection);
            DataTable dt = new DataTable();
            // đổ dữ liệu vào datatable
            adapter.Fill(dt);
            // xét vị trí đầu tiên 
            DataRow item = dt.NewRow();
            item[0] = "";
            dt.Rows.InsertAt(item, 0);
            cbb_mK.DataSource = dt;
            cbb_mK.ValueMember = "MAKHOA"; // gán giá trị tương ứng với mỗi mục trong ComboBox là giá trị của cột "MaKhoa" trong DataTable
            // cbb_mK.DisplayMember = "TENKHOA"; // Hiển thị tên của các mục trong ComboBox là giá trị của cột "TenKhoa" trong DataTable
            cbb_mK.DisplayMember = "MAKHOA";

        }

        private void dgw_GV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Hiện thị thông tin chi tiết lên khung điền thông tin
            if (e.RowIndex == -1)
                return;
            DataGridViewRow row = dgw_GV.Rows[e.RowIndex];
            txt_mGV.Texts = row.Cells[0].Value.ToString();
            txt_tenGV.Texts = row.Cells[1].Value.ToString();
            cbb_mK.Text = row.Cells[2].Value.ToString();
            if (row.Cells[4].Value.ToString() == "Nam")
            {
                rdb_nam.Checked = true;
            }
            else
            {
                rdb_nu.Checked = true;
            }
            dtp_nsGV.Value = DateTime.Parse(row.Cells[5].Value.ToString());
            txt_chucvu.Texts = row.Cells[6].Value.ToString();
            txt_passwd.Texts = row.Cells[7].Value.ToString();
            if (bool.Parse(row.Cells[8].Value.ToString()) == true)
            {
                tb_enable.Checked = true;
            }
            else
            {
                tb_enable.Checked = false;
            }

        }

        

        private async void btn_them_Click(object sender, EventArgs e)
        {
            btn_them.BackColor = Color.Orange;
            await Task.Delay(100);
            btn_them.BackColor = Color.Lime;
            txt_mGV.Focus();

            try
            {
                string tenTaiKhoan = txt_mGV.Texts.Trim();
                string hoTen = txt_tenGV.Texts.Trim();
                string maK = cbb_mK.Text;
                string gioiTinh;
                if (rdb_nam.Checked == true)
                    gioiTinh = "1";
                else
                    gioiTinh = "0";
                string ngaySinh = dtp_nsGV.Value.Year.ToString() + "-" + dtp_nsGV.Value.Month.ToString() + "-" + dtp_nsGV.Value.Day.ToString();
                string chucvu = txt_chucvu.Texts.Trim();
                string matKhau = txt_passwd.Texts.Trim();
                string trangThai;
                if (tb_enable.Checked == true)
                    trangThai = "1";
                else
                    trangThai = "0";

                if (Check.TenTaiKhoanGV(tenTaiKhoan) && Check.MatKhau(matKhau))
                {
                    string insertGiangvien = "insert into GIANGVIEN values ('"+tenTaiKhoan+"','"+maK+ "','"+hoTen+"',"+gioiTinh+",'"+ngaySinh+"','"+chucvu+"'); insert into GVACCOUNTS values ('"+tenTaiKhoan+"','"+tenTaiKhoan+"','"+matKhau+"',"+trangThai+")";
                    foreach (Giangvien item in Giangviens)
                    {
                        if (tenTaiKhoan == item.Msgv)
                        {
                            Notification.Noti_Info("Đã tồn tại tên tài khoản '" + tenTaiKhoan + "'!");
                            return;
                        }
                    }
                    modify.ChinhSuaDuLieu(insertGiangvien);
                    Notification.Noti_Info("Thêm tài khoản thành công!");
                    btn_lammoi_Click(sender, e);
                }
                else
                    Notification.Noti_Info("Dữ liệu nhập không hợp lệ!");
            }
            catch
            {
                Notification.Noti_Info("Thêm không thành công!");
            }

        }


        private async void btn_sua_Click(object sender, EventArgs e)
        {
            // code trang trí
            btn_sua.BackColor = Color.Orange;
            await Task.Delay(100);
            btn_sua.BackColor = Color.Khaki;

            // code dữ liệu
            try
            {
                string ms = txt_mGV.Texts.Trim();
                string hoten = txt_tenGV.Texts.Trim();
                string maK = cbb_mK.Text;
                string gioitinh;
                if (rdb_nam.Checked == true)
                    gioitinh = "1";
                else
                    gioitinh = "0";
                string ngaysinh = dtp_nsGV.Value.Year.ToString() + "-" + dtp_nsGV.Value.Month.ToString() + "-" + dtp_nsGV.Value.Day.ToString();
                string chucvu = txt_chucvu.Texts.Trim();
                string matkhau = txt_passwd.Texts.Trim();
                string enable;
                if (tb_enable.Checked == true)
                    enable = "1";
                else
                    enable = "0";

                bool flag = false;
                if (Check.TenTaiKhoanGV(ms) && Check.MatKhau(matkhau))
                {
                    string updateGV = "UPDATE GIANGVIEN SET MAKHOA = '"+maK+"', HOTENGV = '"+hoten+"', GIOITINHGV = "+gioitinh+", NGAYSINHGV = '"+ngaysinh+"' WHERE MSGV = '"+ms+"'; UPDATE GVACCOUNTS SET PASSWORDGV = '"+matkhau+"', ENABLEGV = '"+enable+"' WHERE UIDGV = '"+ms+"'";
                    foreach (Giangvien item in Giangviens)
                    {
                        if (ms == item.Msgv)
                        {
                            flag = true;
                            break;
                        }
                    }
                    if (flag == true)
                    {
                        modify.ChinhSuaDuLieu(updateGV);
                        Notification.Noti_Info("Sửa thành công!");
                        btn_lammoi_Click(sender,e);
                    }
                    else
                        Notification.Noti_Info("Không tồn tại tên tài khoản '" + ms + "'!");
                }
                else
                    Notification.Noti_Info("Dữ liệu nhập không hợp lệ!");
            }
            catch
            {
                Notification.Noti_Info("Sửa không thành công!");

            }
        }
            

        private async void btn_xoa_Click(object sender, EventArgs e)
        {
            btn_xoa.BackColor = Color.Orange;
            await Task.Delay(100);
            btn_xoa.BackColor = Color.Red;

            try
            {
                string tenTaiKhoan = txt_mGV.Texts.Trim();
                bool flag = false;
                
                if (Check.TenTaiKhoanGV(tenTaiKhoan) )
                {
                    string deletequantrivien = "DELETE FROM GVACCOUNTS WHERE UIDGV = '" + tenTaiKhoan + "'; DELETE FROM GIANGVIEN WHERE MSGV = '" + tenTaiKhoan + "'";
                    foreach (Giangvien item in Giangviens)
                    {
                        if (tenTaiKhoan == item.Msgv)
                        {
                            flag = true;
                            break;
                        }
                    }
                    if (flag == true)
                    {
                        string thongbao = "Bạn có chắc chắn xóa tài khoản có tên '" + tenTaiKhoan + "' không?";
                        if (Notification.Noti_YesNo(thongbao) == true)
                        {
                            modify.ChinhSuaDuLieu(deletequantrivien);
                            txt_mGV.Texts = "";
                            txt_tenGV.Texts = "";
                            cbb_mK.Text = "";
                            rdb_nam.Checked = false;
                            rdb_nu.Checked = false;
                            dtp_nsGV.Value = DateTime.Now;
                            txt_chucvu.Texts = "";
                            txt_passwd.Texts = "";
                            tb_enable.Checked = false;
                            Notification.Noti_Info("Xóa thành công!");
                            btn_lammoi_Click(sender, e);
                        }
                        else
                            return;
                    }
                    else
                        Notification.Noti_Info("Không tồn tại tài khoản có tên '" + tenTaiKhoan + "'!");
                }
                else
                    Notification.Noti_Info("Dữ liệu nhập không hợp lệ!");
            }
            catch
            {
                Notification.Noti_Info("Xóa không thành công!");
                
            }

        }


        
        private async void btn_timkiem_Click(object sender, EventArgs e)
        {
            btn_timkiem.BackColor = Color.Orange;
            await Task.Delay(100);
            btn_timkiem.BackColor = Color.SkyBlue;


            string ms = txt_mGV.Texts.Trim();
            string hoten = txt_tenGV.Texts.Trim();
            string maK = cbb_mK.Text;

            // 1 = nam , 2 = nu
            string gioitinh = "";
            if (rdb_nam.Checked == true)
                gioitinh = "AND GIOITINHGV = 1";
            if (rdb_nu.Checked == true)
                gioitinh = "AND GIOITINHGV = 0";

            string ngaysinh = "";
            if (dtp_nsGV.Value != DateTime.Now)
            {
                ngaysinh = "and  NGAYSINHGV = '"+ dtp_nsGV.Value.Year.ToString() + "-" + dtp_nsGV.Value.Month.ToString() + "-" + dtp_nsGV.Value.Day.ToString()+"'";
            }

            string chucvu = txt_chucvu.Texts.Trim();
            string matkhau = txt_passwd.Texts.Trim();
            string enable;
            if (tb_enable.Checked == true)
                enable = "and GVACCOUNTS.ENABLEGV = 1";
            else
                enable = "and GVACCOUNTS.ENABLEGV = 0";

            try
            {
                string queryS = "SELECT GIANGVIEN.MSGV,HOTENGV,GIANGVIEN.MAKHOA,TENKHOA,GIOITINHGV,NGAYSINHGV,CHUCVU,PASSWORDGV,ENABLEGV FROM GIANGVIEN INNER JOIN GVACCOUNTS ON GIANGVIEN.MSGV = GVACCOUNTS.MSGV INNER JOIN KHOA ON KHOA.MAKHOA = GIANGVIEN.MAKHOA where GIANGVIEN.MSGV LIKE '%" + ms + "%' and HOTENGV like '%" + hoten + "%' and KHOA.MAKHOA like '%" + maK + "%' " + gioitinh + " and CHUCVU like '%"+chucvu+"%'      "; 
                HienThiGiangVien(queryS);
            }
            catch (Exception)
            {

                Notification.Noti_Info("Dữ liệu tìm kiếm chưa hợp lệ!");
            }
            
        }

        private async void btn_lammoi_Click(object sender, EventArgs e)
        {
            btn_lammoi.BackColor = Color.Orange;
            await Task.Delay(100);
            btn_lammoi.BackColor = Color.Khaki;

            query = "SELECT GIANGVIEN.MSGV,HOTENGV,GIANGVIEN.MAKHOA,TENKHOA,GIOITINHGV,NGAYSINHGV,CHUCVU,PASSWORDGV,ENABLEGV FROM GIANGVIEN INNER JOIN GVACCOUNTS ON GIANGVIEN.MSGV = GVACCOUNTS.MSGV INNER JOIN KHOA ON KHOA.MAKHOA = GIANGVIEN.MAKHOA";
            HienThiGiangVien(query);
            txt_mGV.Texts="";
            txt_tenGV.Texts = "";
            txt_chucvu.Texts = "";
            txt_passwd.Texts = "";
            ComboBox_Khoa();
            rdb_nam.Checked = false;
            rdb_nu.Checked = false;
            dtp_nsGV.Value = DateTime.Now;
            tb_enable.Checked = false;

            
        }
    }
}

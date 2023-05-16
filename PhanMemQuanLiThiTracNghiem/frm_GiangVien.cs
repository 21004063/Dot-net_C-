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
        private void frm_GiangVien_Load(object sender, EventArgs e)
        {
            HienThiGiangVien(query);

            ComboBox_Khoa();
            

        }
        

        Modify modify = new Modify();
        List<Giangvien> Giangviens = new List<Giangvien>();
        string query = "SELECT GIANGVIEN.MSGV,HOTENGV,GIANGVIEN.MAKHOA,TENKHOA,GIOITINHGV,NGAYSINHGV,CHUCVU,PASSWORDGV,ENABLEGV FROM GIANGVIEN INNER JOIN GVACCOUNTS ON GIANGVIEN.MSGV = GVACCOUNTS.MSGV INNER JOIN KHOA ON KHOA.MAKHOA = GIANGVIEN.MAKHOA ORDER BY MSGV ASC";
        public void HienThiGiangVien(string Q)
        {
            Giangviens = modify.ThongTinGiangVien(Q);
            DataTable dataGiangviens = new DataTable();
            dataGiangviens.Columns.Add("Mã số giảng viên");
            dataGiangviens.Columns.Add("Họ tên");
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
                row["Họ tên"] = item.Tengv;
                
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
            txt_mGV.Enabled = true;
        }
        public void ComboBox_Khoa()
        {
            // hiển thị ComboBox_Khoa

            // Tạo đối tượng SqlDataAdapter để thực thi câu lệnh truy vấn và lấy dữ liệu từ database.
            SqlDataAdapter adapter = new SqlDataAdapter("select MAKHOA,TENKHOA from KHOA", ConnectionData.GetSqlConnection());
            DataTable dt = new DataTable();
            // đổ dữ liệu vào datatable
            adapter.Fill(dt);

            // xét vị trí đầu tiên 
            
            DataRow item = dt.NewRow();
            item["MAKHOA"] = "";
            item["TENKHOA"] = "Chọn khoa";
            /*item[0] = "";
            item[1] = "Chọn khoa";*/
            dt.Rows.InsertAt(item, 0);

            // Tạo một cột ảo để lưu trữ giá trị "MAKHOA - TENKHOA"
            DataColumn dc = new DataColumn();
            dc.ColumnName = "MA_TEN_KHOA";
            dc.DataType = typeof(string); // Thiết lập kiểu dữ liệu của cột là kiểu chuỗi (string).
            dc.Expression = "MAKHOA + ' - ' + TENKHOA"; // Thiết lập biểu thức của cột mới 
            dt.Columns.Add(dc); // thêm cột mới vào table
            
            // Gán DataTable cho DataSource của ComboBox
            cbb_mK.DataSource = dt;
            // gán giá trị tương ứng với mỗi mục trong ComboBox là giá trị của cột "MaKhoa" trong DataTable
            cbb_mK.ValueMember = "MAKHOA";
            // cbb_mK.DisplayMember = "TENKHOA"; // Hiển thị tên của các mục trong ComboBox là giá trị của cột "TenKhoa" trong DataTable
            cbb_mK.DisplayMember = "MA_TEN_KHOA"; // chỉ nhận tên cột

        }

        private void dgw_GV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Hiện thị thông tin chi tiết lên khung điền thông tin
            if (e.RowIndex == -1)
                return;
            DataGridViewRow row = dgw_GV.Rows[e.RowIndex];
            txt_mGV.Texts = row.Cells[0].Value.ToString();
            txt_tenGV.Texts = row.Cells[1].Value.ToString();
            cbb_mK.Text = row.Cells[2].Value.ToString()+ " - " + row.Cells[3].Value.ToString();
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

            txt_mGV.Enabled = false;

        }



        private async void btn_them_Click(object sender, EventArgs e)
        {
            btn_them.BackColor = Color.Orange;
            await Task.Delay(100);
            btn_them.BackColor = Color.Lime;
            txt_mGV.Focus();

            try
            {
                string Msgv = txt_mGV.Texts.Trim();
                string hoTen = txt_tenGV.Texts.Trim();
                
                string maK = cbb_mK.SelectedValue.ToString();

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

                if (Check.TenTaiKhoanGV(Msgv) && Check.MatKhau(matKhau))
                {
                    string insertGiangvien = "insert into GIANGVIEN values ('"+Msgv+"','"+maK+ "','"+hoTen+"',"+gioiTinh+",'"+ngaySinh+"','"+chucvu+"'); insert into GVACCOUNTS values ('"+Msgv+"','"+Msgv+"','"+matKhau+"',"+trangThai+")";
                    foreach (Giangvien item in Giangviens)
                    {
                        if (Msgv == item.Msgv)
                        {
                            RJMessageBox.Show("Đã tồn tại giảng viên '" + Msgv + "'!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    modify.ChinhSuaDuLieu(insertGiangvien);
                    RJMessageBox.Show("Thêm giảng viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_lammoi_Click(sender, e);
                }
                else
                    RJMessageBox.Show("Dữ liệu nhập không hợp lệ !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch
            {
                RJMessageBox.Show("Thêm không thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string Msgv = txt_mGV.Texts.Trim();
                string hoten = txt_tenGV.Texts.Trim();
                
                string maK = cbb_mK.SelectedValue.ToString();

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
                if (Check.TenTaiKhoanGV(Msgv) && Check.MatKhau(matkhau))
                {
                    string updateGV = "UPDATE GIANGVIEN SET MAKHOA = '"+maK+"', HOTENGV = '"+hoten+"', GIOITINHGV = "+gioitinh+", NGAYSINHGV = '"+ngaysinh+"' WHERE MSGV = '"+Msgv+"'; UPDATE GVACCOUNTS SET PASSWORDGV = '"+matkhau+"', ENABLEGV = '"+enable+"' WHERE UIDGV = '"+Msgv+"'";
                    foreach (Giangvien item in Giangviens)
                    {
                        if (Msgv == item.Msgv)
                        {
                            flag = true;
                            break;
                        }
                    }
                    if (flag == true)
                    {
                        modify.ChinhSuaDuLieu(updateGV);
                        RJMessageBox.Show("Sửa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btn_lammoi_Click(sender,e);
                    }
                    else
                        RJMessageBox.Show("Đã tồn tại giảng viên có mã số giảng viên là '" + Msgv + "'!", "Lỗi !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    RJMessageBox.Show("Mã số giảng viên không hợp lệ !", "Lỗi !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch
            {
                RJMessageBox.Show("Sửa không thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
            

        private async void btn_xoa_Click(object sender, EventArgs e)
        {
            btn_xoa.BackColor = Color.Orange;
            await Task.Delay(100);
            btn_xoa.BackColor = Color.Red;

            try
            {
                string Msgv = txt_mGV.Texts.Trim();
                string hoten = txt_tenGV.Texts.Trim();
                string maK = cbb_mK.Text;
                string ngaysinh = dtp_nsGV.Value.ToString();
                bool flag = false;
                
                if (Check.TenTaiKhoanGV(Msgv) )
                {
                    string deleteGV = "DELETE FROM GVACCOUNTS WHERE UIDGV = '" + Msgv + "'; DELETE FROM GIANGVIEN WHERE MSGV = '" + Msgv + "'";
                    foreach (Giangvien item in Giangviens)
                    {
                        if (Msgv == item.Msgv)
                        {
                            flag = true;
                            break;
                        }
                    }
                    if (flag == true)
                    {
                        DialogResult result = RJMessageBox.Show("Bạn có chắc chắn xóa giảng viên có: \n\t Mã số giảng viên: " + Msgv + "\n\t Họ tên: "+hoten+" \n\t Mã khoa: "+maK+" \n\t sinh ngày: "+ngaysinh+" \n  ", "Lưu ý !!!",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            modify.ChinhSuaDuLieu(deleteGV);
                            txt_mGV.Texts = "";
                            txt_tenGV.Texts = "";
                            cbb_mK.Text = "";
                            rdb_nam.Checked = false;
                            rdb_nu.Checked = false;
                            dtp_nsGV.Value = DateTime.Now;
                            txt_chucvu.Texts = "";
                            txt_passwd.Texts = "";
                            tb_enable.Checked = false;
                            RJMessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btn_lammoi_Click(sender, e);
                        }
                        else
                            return;
                    }
                    else
                        RJMessageBox.Show("Không tồn tại giảng viên có mã số giảng viên là '" + Msgv + "'!", "Lỗi !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    RJMessageBox.Show("Mã số giảng viên không hợp lệ !", "Lỗi !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                RJMessageBox.Show("Xóa không thành công!", "Lỗi !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        
        private async void btn_timkiem_Click(object sender, EventArgs e)
        {
            btn_timkiem.BackColor = Color.Orange;
            await Task.Delay(100);
            btn_timkiem.BackColor = Color.SkyBlue;

            string ms = txt_mGV.Texts.Trim();
            string hoten = txt_tenGV.Texts.Trim();
            string maK = cbb_mK.SelectedValue.ToString();
            // 1 = nam , 2 = nu
            string gioitinh = "";
            if (rdb_nam.Checked == true)
                gioitinh = "AND GIOITINHGV = 1";
            if (rdb_nu.Checked == true)
                gioitinh = "AND GIOITINHGV = 0";

            /*string ngaysinh = "";
            if (dtp_nsGV.Value != DateTime.Now)
            {
                ngaysinh = "and  NGAYSINHGV = '" + dtp_nsGV.Value.Year.ToString() + "-" + dtp_nsGV.Value.Month.ToString() + "-" + dtp_nsGV.Value.Day.ToString() + "'";
            }

            string chucvu = txt_chucvu.Texts.Trim();
            string matkhau = txt_passwd.Texts.Trim();
            string enable;
            if (tb_enable.Checked == true)
                enable = "and GVACCOUNTS.ENABLEGV = 1";
            else
                enable = "and GVACCOUNTS.ENABLEGV = 0";*/

            try
            {
                if (maK.CompareTo("Chọn khoa") == 0)
                {
                    maK = "";
                }
                string queryS = "SELECT GIANGVIEN.MSGV,HOTENGV,GIANGVIEN.MAKHOA,TENKHOA,GIOITINHGV,NGAYSINHGV,CHUCVU,PASSWORDGV,ENABLEGV FROM GIANGVIEN INNER JOIN GVACCOUNTS ON GIANGVIEN.MSGV = GVACCOUNTS.MSGV INNER JOIN KHOA ON KHOA.MAKHOA = GIANGVIEN.MAKHOA where GIANGVIEN.MSGV LIKE '%" + ms + "%' and HOTENGV like '%" + hoten + "%' and KHOA.MAKHOA like '%" + maK + "%' " + gioitinh + " ORDER BY MSGV ASC  "; 
                HienThiGiangVien(queryS);
                RJMessageBox.Show("Hoàn thành tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                RJMessageBox.Show("Dữ liệu tìm kiếm chưa hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

        }

        private async void btn_lammoi_Click(object sender, EventArgs e)
        {
            btn_lammoi.BackColor = Color.Orange;
            await Task.Delay(100);
            btn_lammoi.BackColor = Color.Khaki;

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

            RJMessageBox.Show("Bạn đã làm mới","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);

            
        }
    }
}

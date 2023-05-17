using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLiThiTracNghiem
{
    public partial class frm_SinhVien : Form
    {
        public frm_SinhVien()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        List<Sinhvien> Sinhviens = new List<Sinhvien>();
        string query = "select SINHVIEN.MSSV,HOTENSV,SINHVIEN.MALOP,LOP.MAKHOA,KHOA.TENKHOA,GIOITINHSV,NGAYSINHSV,PASSWORDSV,ENABLESV FROM SINHVIEN INNER JOIN SVACCOUNTS ON SINHVIEN.MSSV = SVACCOUNTS.MSSV INNER JOIN LOP ON LOP.MALOP = SINHVIEN.MALOP INNER JOIN KHOA ON KHOA.MAKHOA = SINHVIEN.MAKHOA ORDER BY MSSV ASC";
        private void frm_SinhVien_Load(object sender, EventArgs e)
        {
            HienThiSinhVien(query);
            ComboBox_mL();
            ComboBox_mK();
            txt_mSV.Focus();
        }
        
        public void HienThiSinhVien(string q)
        {
            Sinhviens = modify.ThongTinSinhVien(q);
            DataTable dataSinhviens = new System.Data.DataTable();
            dataSinhviens.Columns.Add("Mã số sinh viên");
            dataSinhviens.Columns.Add("Họ tên");
            dataSinhviens.Columns.Add("Mã khoa");
            dataSinhviens.Columns.Add("Tên khoa");
            dataSinhviens.Columns.Add("Mã lớp");
            dataSinhviens.Columns.Add("Giới tính");
            dataSinhviens.Columns.Add("Ngày sinh",typeof(DateTime));
            dataSinhviens.Columns.Add("Mật khẩu");
            dataSinhviens.Columns.Add("Kích hoạt tài khoản",typeof(Boolean));

            foreach (Sinhvien item in Sinhviens)
            {
                DataRow row = dataSinhviens.NewRow();
                row["Mã số sinh viên"] = item.Mssv;
                row["Họ tên"] = item.Tensv;
                row["Mã khoa"] = item.Mak;
                row["Tên khoa"] = item.Tenk;
                row["Mã lớp"] = item.Mal;
                row["Giới tính"] = item.Gt;
                if (item.Gt == true)
                    row["Giới tính"] = "Nam";
                else
                    row["Giới tính"] = "Nữ";
                row["Ngày sinh"] = item.Ns;
                row["Mật khẩu"] = item.Passwd;
                row["Kích hoạt tài khoản"] = item.Enable;
                dataSinhviens.Rows.Add(row);

            }
            dgw_SV.DataSource = dataSinhviens;
            dgw_SV.ColumnHeadersHeight = 50;
            dgw_SV.RowHeadersWidth = 50;
            dgw_SV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            txt_mSV.Enabled = true;
        }

        private void dgw_SV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Hiện thị thông tin chi tiết
            if (e.RowIndex == -1)
                return;
            DataGridViewRow row = dgw_SV.Rows[e.RowIndex];

            txt_mSV.Texts = row.Cells[0].Value.ToString();
            txt_tenSV.Texts = row.Cells[1].Value.ToString();
            
            cbb_mK.Text = row.Cells[2].Value.ToString()+" - " + row.Cells[3].Value.ToString();
            cbb_mL.Text = row.Cells[4].Value.ToString();


            if (row.Cells[5].Value.ToString() == "Nam")
            {
                rad_nam.Checked = true;
            }
            else
            {
                rad_nu.Checked = true;
            }
            dtp_nsSV.Value = DateTime.Parse(row.Cells[6].Value.ToString());
            txt_passwd.Texts = row.Cells[7].Value.ToString();
            if (bool.Parse(row.Cells[8].Value.ToString()) == true)
            {
                rad_enable.Checked = true;
            }
            else
            {
                rad_enable.Checked = false;
            }

            txt_mSV.Enabled = false;
        }
        public void ComboBox_mK()
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
            dt.Rows.InsertAt(item, 0);

            // Tạo một cột ảo để lưu trữ giá trị "MAKHOA - TENKHOA"
            DataColumn dc = new DataColumn();
            dc.ColumnName = "MA_TEN_KHOA";
            dc.DataType = typeof(string); // Thiết lập kiểu dữ liệu của cột là kiểu chuỗi (string).
            dc.Expression = "MAKHOA + ' - ' + TENKHOA"; // Thiết lập biểu thức của cột mới 
            dt.Columns.Add(dc); // thêm cột mới vào table

            cbb_mK.DataSource = dt;
            cbb_mK.ValueMember = "MAKHOA"; // gán giá trị tương ứng với mỗi mục trong ComboBox là giá trị của cột "MaKhoa" trong DataTable
            // cbb_mK.DisplayMember = "TENKHOA"; // Hiển thị tên của các mục trong ComboBox là giá trị của cột "TenKhoa" trong DataTable
            cbb_mK.DisplayMember = "MA_TEN_KHOA";
        }
        public void ComboBox_mL()
        {
            // hiển thị combobox lớp
            // Tạo đối tượng SqlDataAdapter để thực thi câu lệnh truy vấn và lấy dữ liệu từ database.
            string lop = "select MALOP,TENLOP from LOP";
            SqlDataAdapter adapter = new SqlDataAdapter(lop, ConnectionData.GetSqlConnection());
            DataTable dt = new DataTable();
            // đổ dữ liệu vào datatable
            adapter.Fill(dt);
            // xét vị trí đầu tiên 
            DataRow item = dt.NewRow();
            item[0] = "Chọn lớp";
            dt.Rows.InsertAt(item, 0);


            cbb_mL.DataSource = dt;
            cbb_mL.ValueMember = "MALOP"; // gán giá trị tương ứng với mỗi mục trong ComboBox là giá trị của cột "MaLOP" trong DataTable
            
            cbb_mL.DisplayMember = "MALOP";
        }
        
        // ràng buộc lớp với khoa
        private void cbb_mK_SelectedIndexChanged(object sender, EventArgs e)
        {
            // hiển thị combobox lớp
            // Tạo đối tượng SqlDataAdapter để thực thi câu lệnh truy vấn và lấy dữ liệu từ database.
            string lop = "select MALOP,TENLOP from LOP";
            string[] khoa = cbb_mK.Text.Split('-');
            if (cbb_mK.Text.CompareTo("Chọn khoa") != 0)
            {
                lop = "select MALOP,TENLOP from LOP where MAKHOA = '" + khoa[0] + "' ";
            }
            SqlDataAdapter adapter = new SqlDataAdapter(lop, ConnectionData.GetSqlConnection());
            DataTable dt = new DataTable();
            // đổ dữ liệu vào datatable
            adapter.Fill(dt);
            // xét vị trí đầu tiên 
            DataRow item = dt.NewRow();
            item[0] = "Chọn lớp";
            dt.Rows.InsertAt(item, 0);
            cbb_mL.DataSource = dt;
            cbb_mL.ValueMember = "MALOP"; // gán giá trị tương ứng với mỗi mục trong ComboBox là giá trị của cột "MaLOP" trong DataTable

            cbb_mL.DisplayMember = "MALOP";
        }

        private async void btn_them_Click(object sender, EventArgs e)
        {
            btn_them.BackColor = Color.Orange;
            await Task.Delay(100);
            btn_them.BackColor = Color.Lime;
            txt_mSV.Focus();

            try
            {
                string Mssv = txt_mSV.Texts.Trim();
                string hoTen = txt_tenSV.Texts.Trim();
                string maL = cbb_mL.Text;
                string maK = cbb_mK.SelectedValue.ToString();
                string gioiTinh;
                if (rad_nam.Checked == true)
                    gioiTinh = "1";
                else
                    gioiTinh = "0";
                string ngaySinh = dtp_nsSV.Value.Year.ToString() + "-" + dtp_nsSV.Value.Month.ToString() + "-" + dtp_nsSV.Value.Day.ToString();
                string matKhau = txt_passwd.Texts.Trim();
                string trangThai;
                if (rad_enable.Checked == true)
                    trangThai = "1";
                else
                    trangThai = "0";

                if (Check.TenTaiKhoanSV(Mssv) && Check.MatKhau(matKhau))
                {
                    string insertSinhvien = "INSERT INTO SINHVIEN VALUES ('"+Mssv+"','"+maL+"','"+hoTen+"',"+gioiTinh+",'"+ngaySinh+"','"+maK+"'); INSERT INTO SVACCOUNTS VALUES ('"+Mssv+"','"+Mssv+"','"+matKhau+"',"+trangThai+")";
                    foreach (Sinhvien item in Sinhviens)
                    {
                        if (Mssv == item.Mssv)
                        {
                            RJMessageBox.Show("Đã tồn tại sinh viên '" + Mssv + "'!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    modify.ChinhSuaDuLieu(insertSinhvien);
                    RJMessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            btn_sua.BackColor = Color.Orange;
            await Task.Delay(100);
            btn_sua.BackColor = Color.Khaki;
            // code dữ liệu
            try
            {
                string Mssv = txt_mSV.Texts.Trim();
                string hoTen = txt_tenSV.Texts.Trim();
                string maL = cbb_mL.Text;
                string maK = cbb_mK.SelectedValue.ToString();
                string gioiTinh;
                if (rad_nam.Checked == true)
                    gioiTinh = "1";
                else
                    gioiTinh = "0";
                string ngaySinh = dtp_nsSV.Value.Year.ToString() + "-" + dtp_nsSV.Value.Month.ToString() + "-" + dtp_nsSV.Value.Day.ToString();
                string matKhau = txt_passwd.Texts.Trim();
                string trangThai;
                if (rad_enable.Checked == true)
                    trangThai = "1";
                else
                    trangThai = "0";

                bool flag = false;
                if (Check.TenTaiKhoanSV(Mssv) && Check.MatKhau(matKhau))
                {
                    string updateSV = "UPDATE SINHVIEN SET MALOP = '"+maL+"', HOTENSV = '"+hoTen+"', GIOITINHSV = "+gioiTinh+", NGAYSINHSV = '"+ngaySinh+"', MAKHOA = '"+maK+ "' WHERE MSSV = '"+Mssv+"'; UPDATE SVACCOUNTS SET PASSWORDSV = '"+matKhau+"', ENABLESV = "+trangThai+" WHERE UIDSV = '"+Mssv+"' ";
                    foreach (Sinhvien item in Sinhviens)
                    {
                        if (Mssv == item.Mssv)
                        {
                            flag = true;
                            break;
                        }
                    }

                    if (flag == true)
                    {
                        modify.ChinhSuaDuLieu(updateSV);
                        RJMessageBox.Show("Sửa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btn_lammoi_Click(sender, e);
                    }
                    else
                        RJMessageBox.Show("Đã tồn tại sinh viên có mã số sinh viên là '" + Mssv + "'!", "Lỗi !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    RJMessageBox.Show("Mã số sinh viên không hợp lệ !", "Lỗi !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
                string Mssv = txt_mSV.Texts.Trim();
                string hoten = txt_tenSV.Texts.Trim();
                string maL = cbb_mL.Text;
                string maK = cbb_mK.SelectedValue.ToString();
                string ngaysinh = dtp_nsSV.Value.ToString();
                bool flag = false;

                if (Check.TenTaiKhoanSV(Mssv))
                {
                    string deleteGV = "DELETE FROM SVACCOUNTS WHERE UIDSV = '" + Mssv + "'; DELETE FROM SINHVIEN WHERE MSSV = '" + Mssv + "'";
                    foreach (Sinhvien item in Sinhviens)
                    {
                        if (Mssv == item.Mssv)
                        {
                            flag = true;
                            break;
                        }
                    }
                    if (flag == true)
                    {
                        DialogResult result = RJMessageBox.Show("Bạn có chắc chắn xóa sinh viên có: \n\t Mã số sinh viên: " + Mssv + "\n\t Họ tên: " + hoten + " \n\t Mã lớp: "+maL+" \n\t Mã khoa: "+maK+" \n\t Sinh ngày: "+ngaysinh+" \n   ", "Lưu ý !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            modify.ChinhSuaDuLieu(deleteGV);
                            txt_mSV.Texts = "";
                            txt_tenSV.Texts = "";
                            cbb_mK.Text = "";
                            cbb_mL.Text = "";
                            rad_nam.Checked = false;
                            rad_nu.Checked = false;
                            dtp_nsSV.Value = DateTime.Now;
                            txt_passwd.Texts = "";
                            rad_enable.Checked = false;
                            RJMessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btn_lammoi_Click(sender, e);
                        }
                        else
                            return;
                    }
                    else
                        RJMessageBox.Show("Không tồn tại giảng viên có mã số sinh viên là '" + Mssv + "'!", "Lỗi !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    RJMessageBox.Show("Mã số sinh viên không hợp lệ !", "Lỗi !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                RJMessageBox.Show("Xóa không thành công!", "Lỗi !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private async void btn_lammoi_Click(object sender, EventArgs e)
        {
            btn_lammoi.BackColor = Color.Orange;
            await Task.Delay(100);
            btn_lammoi.BackColor = Color.Khaki;

            HienThiSinhVien(query);
            txt_mSV.Texts = "";
            txt_tenSV.Texts = "";
            txt_passwd.Texts = "";
            ComboBox_mL();
            ComboBox_mK();
            rad_nam.Checked = false;
            rad_nu.Checked = false;
            dtp_nsSV.Value = DateTime.Now;
            rad_enable.Checked = false;


        }

        private async void btn_timkiem_Click(object sender, EventArgs e)
        {
            btn_timkiem.BackColor = Color.Orange;
            await Task.Delay(100);
            btn_timkiem.BackColor = Color.SkyBlue;

            string ms = txt_mSV.Texts.Trim();
            string hoten = txt_tenSV.Texts.Trim();
            string maL = cbb_mL.Text;
            string maK = cbb_mK.SelectedValue.ToString();
            // 1 = nam , 2 = nu
            string gioitinh = "";
            if (rad_nam.Checked == true)
                gioitinh = "AND GIOITINHSV = 1";
            if (rad_nu.Checked == true)
                gioitinh = "AND GIOITINHSV = 0";

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
                if (maL.CompareTo("Chọn lớp") == 0)
                {
                    maL = "";
                }
                string queryS = "SELECT SINHVIEN.MSSV,HOTENSV,SINHVIEN.MALOP,LOP.MAKHOA,KHOA.TENKHOA,GIOITINHSV,NGAYSINHSV,PASSWORDSV,ENABLESV FROM SINHVIEN INNER JOIN SVACCOUNTS ON SINHVIEN.MSSV = SVACCOUNTS.MSSV INNER JOIN LOP ON LOP.MALOP = SINHVIEN.MALOP INNER JOIN KHOA ON KHOA.MAKHOA = SINHVIEN.MAKHOA where SINHVIEN.MSSV LIKE '%" + ms + "%' and HOTENSV like '%" + hoten + "%' and LOP.MALOP like '%"+maL+"%' and LOP.MAKHOA like '%" + maK + "%' " + gioitinh + " ORDER BY MSSV ASC  ";
                HienThiSinhVien(queryS);
                RJMessageBox.Show("Hoàn thành tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                RJMessageBox.Show("Dữ liệu tìm kiếm chưa hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        
        /*private void txt_passwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) // nếu nhập có phím enter 
            {
                btn_them.PerformClick(); // kích hoạt chức năng click
                //e.Handled = true; // ngăn ko cho ký tự enter vào textbox
            }
            
        }

        private void rad_enable_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_enable.Checked == true)
                txt_passwd.Focus();
            
        }*/
    }
}

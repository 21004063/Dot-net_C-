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
    public partial class frm_SinhVien : Form
    {
        public frm_SinhVien()
        {
            InitializeComponent();
        }

        
        private void frm_SinhVien_Load(object sender, EventArgs e)
        {

        }

        Modify modify = new Modify();
        List<Sinhvien> Sinhviens = new List<Sinhvien>();
        string query = "select SINHVIEN.MSSV,HOTENSV,SINHVIEN.MALOP,GIOITINHSV,NGAYSINHSV,PASSWORDSV,ENABLESV FROM SINHVIEN INNER JOIN SVACCOUNTS ON SINHVIEN.MSSV = SVACCOUNTS.MSSV INNER JOIN LOP ON LOP.MALOP = SINHVIEN.MALOP";

        public void HienThiSinhVien()
        {
            Sinhviens = modify.ThongTinSinhVien(query);
            System.Data.DataTable dataSinhviens = new System.Data.DataTable();
            dataSinhviens.Columns.Add("Mã số giảng viên");
            

            foreach (Sinhvien item in Sinhviens)
            {
                DataRow row = dataSinhviens.NewRow();
                row["Mã số sinh viên"] = item.Mssv;
                row["Họ tên sinh viên"] = item.Tensv;
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
        }

        private void dgw_SV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Hiện thị thông tin chi tiết
            if (e.RowIndex == -1)
                return;
            DataGridViewRow row = dgw_SV.Rows[e.RowIndex];
            txt_mSV.Texts = row.Cells[0].Value.ToString();
            txt_tenSV.Texts = row.Cells[1].Value.ToString();
            cbb_mL.Text = row.Cells[2].Value.ToString();
            if (row.Cells[3].Value.ToString() == "Nam")
            {
                rdb_nam.Checked = true;
            }
            else
            {
                rdb_nu.Checked = true;
            }
            dtp_nsSV.Value = DateTime.Parse(row.Cells[4].Value.ToString());
            txt_passwd.Texts = row.Cells[6].Value.ToString();
            if (bool.Parse(row.Cells[7].Value.ToString()) == true)
            {
                rad_enable.Checked = true;
            }
            else
            {
                rad_enable.Checked = false;
            }


        }









        private async void btnThem_Click(object sender, EventArgs e)
        {
            btn_them.BackColor = Color.Orange;
            await Task.Delay(100);
            btn_them.BackColor = Color.White;
            
                
        }

        private async void btnXoa_Click(object sender, EventArgs e)
        {
            btn_xoa.BackColor = Color.Orange;
            await Task.Delay(100);
            btn_xoa.BackColor = Color.White;
        }

        private async void btnSua_Click(object sender, EventArgs e)
        {
            btn_sua.BackColor = Color.Orange;
            await Task.Delay(100);
            btn_sua.BackColor = Color.White;
        }

        private void txt_mSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}

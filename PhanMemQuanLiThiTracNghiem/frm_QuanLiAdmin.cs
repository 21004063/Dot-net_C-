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
    public partial class frm_QuanLiAdmin : Form
    {
        public frm_QuanLiAdmin()
        {
            InitializeComponent();
        }
        

        private async void btnThem_Click_1(object sender, EventArgs e)
        {
            btnThem.BackColor = Color.Orange;
            await Task.Delay(100);
            btnThem.BackColor = Color.White;
        }

        private async void btnXoa_Click(object sender, EventArgs e)
        {
            btnXoa.BackColor = Color.Orange;
            await Task.Delay(100);
            btnXoa.BackColor = Color.White;
        }

        private async void btnSua_Click(object sender, EventArgs e)
        {
            btnSua.BackColor = Color.Orange;
            await Task.Delay(100);
            btnSua.BackColor = Color.White;
        }
    }
}

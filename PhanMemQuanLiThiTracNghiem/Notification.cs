using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLiThiTracNghiem
{
    class Notification
    {
        public static void Noti_Empty(string action)
        {
            MessageBox.Show("Vui lòng nhập " + action + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void Noti_Info(string action)
        {
            MessageBox.Show(action, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static bool Noti_YesNo(string action)
        {
            DialogResult result;
            result = MessageBox.Show(action, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                return true;
            else
                return false;

        }





    }
}

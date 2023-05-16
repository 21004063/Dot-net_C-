using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace PhanMemQuanLiThiTracNghiem
{
    class Check
    {
        //Kiểm tra chữ cái thường, hoa, số, chiều dài từ 2-49 kí tự
        public static bool Chu_HoaThuongSo(string name)
        {
            return Regex.IsMatch(name, "^[a-zA-Z0-9]{2,49}$");
        }

        public static bool MaKhoa(string makhoa)
        {
            return Regex.IsMatch(makhoa, "^[0-9]{3}$");
        }

        public static bool TimMaKhoa(string input)
        {
            return Regex.IsMatch(input, "^[a-zA-Z0-9_ ]*$");
        }

        public static bool TenTaiKhoanGV(string query)
        {
            if (query.Trim().ToLower().Substring(0, 2) == "gv" && Regex.IsMatch(query, "^[a-zA-Z0-9]{2,5}$"))
                return true;
            else
                return false;
        }
        public static bool TenTaiKhoanSV(string query)
        {
            return Regex.IsMatch(query, "^[0-9]{8}$");
        }
        public static bool MatKhau(string matkhau)
        {
            return Regex.IsMatch(matkhau, "^[a-zA-Z0-9_@#$*!]{4,49}$");
        }

        public static string UserGroup(string name)
        {
            string group = "";
            if (name.Trim().ToLower().Substring(0, 2) == "ad")
                group = "admin";
            else
                if (name.Trim().ToLower().Substring(0, 2) == "gv")
                    group = "giangvien";
                else
                    group = "sinhvien";
            return group;
        }

        



    }
}

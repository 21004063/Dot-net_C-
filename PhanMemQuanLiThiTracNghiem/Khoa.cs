using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLiThiTracNghiem
{
    class Khoa
    {
        private string maKhoa;
        private string tenKhoa;

        public Khoa()
        {

        }
        public Khoa(string makhoa, string tenkhoa)
        {
            this.maKhoa = makhoa;
            this.tenKhoa = tenkhoa;
        }

        public string MaKhoa
        {
            get { return maKhoa; }    // phương thức get --> trả về
            set { maKhoa = value; }   // phương thức set --> gán vào
        }

        public string TenKhoa
        {
            get { return tenKhoa; }    // phương thức get --> trả về
            set { tenKhoa = value; }   // phương thức set --> gán vào    
        }
    }
}

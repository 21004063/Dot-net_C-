using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLiThiTracNghiem
{
    internal class Sinhvien
    {
        private string _mssv;
        private string _mal;
        private string _tensv;
        private bool _gt;
        private bool _ns;
        private string _passwd;
        private bool _enable;

        public Sinhvien(string mssv, string tensv, string mal,  bool gt, bool ns, string passwd, bool enable)
        {
            _mssv = mssv;
            _mal = mal;
            _tensv = tensv;
            _gt = gt;
            _ns = ns;
            _passwd = passwd;
            _enable = enable;
        }

        public Sinhvien() { }

        public string Mssv { get => _mssv; set => _mssv = value; }
        public string Mal { get => _mal; set => _mal = value; }
        public string Tensv { get => _tensv; set => _tensv = value; }
        public bool Gt { get => _gt; set => _gt = value; }
        public bool Ns { get => _ns; set => _ns = value; }
        public string Passwd { get => _passwd; set => _passwd = value; }
        public bool Enable { get => _enable; set => _enable = value; }
    }
}

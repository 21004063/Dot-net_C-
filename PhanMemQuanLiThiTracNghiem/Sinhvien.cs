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
        private string _tensv;
        private string _mal;
        private string _mak;
        private string _tenk;
        private bool _gt;
        private DateTime _ns;
        private string _passwd;
        private bool _enable;

        public Sinhvien(string mssv, string tensv, string mal, string mak, string tenk, bool gt, DateTime ns, string passwd, bool enable)
        {
            _mssv = mssv;
            _mal = mal;
            _mak = mak;
            _tensv = tensv;
            _gt = gt;
            _ns = ns;
            _passwd = passwd;
            _enable = enable;
            _tenk = tenk;
        }

        public Sinhvien() { }

        public string Mssv { get => _mssv; set => _mssv = value; }
        public string Mal { get => _mal; set => _mal = value; }
        public string Tensv { get => _tensv; set => _tensv = value; }
        public bool Gt { get => _gt; set => _gt = value; }
        public DateTime Ns { get => _ns; set => _ns = value; }
        public string Passwd { get => _passwd; set => _passwd = value; }
        public bool Enable { get => _enable; set => _enable = value; }
        public string Mak { get => _mak; set => _mak = value; }
        public string Tenk { get => _tenk; set => _tenk = value; }
    }
}

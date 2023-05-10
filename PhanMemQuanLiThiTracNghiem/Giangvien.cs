using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLiThiTracNghiem
{
    internal class Giangvien
    {
        private string _msgv;
        private string _tengv;
        private string _mk;
        private string _tenkhoa;
        private bool _gt;
        private DateTime _ns;
        private string _cv;
        private string _passwd;
        private bool _enable;

        public string Tengv { get => _tengv; set => _tengv = value; }
        public string Mk { get => _mk; set => _mk = value; }
        public bool Gt { get => _gt; set => _gt = value; }
        public DateTime Ns { get => _ns; set => _ns = value; }
        public string Cv { get => _cv; set => _cv = value; }
        public string Msgv { get => _msgv; set => _msgv = value; }
        public string Tenkhoa { get => _tenkhoa; set => _tenkhoa = value; }
        public string Passwd { get => _passwd; set => _passwd = value; }
        public bool Enable { get => _enable; set => _enable = value; }

        public Giangvien(string msgv, string tengv, string mk, string tenkhoa, bool gt, DateTime ns, string cv, string passwd, bool enable)
        {
            _msgv = msgv;
            _tengv = tengv;
            _mk = mk;
            _tenkhoa = tenkhoa;
            _gt = gt;
            _ns = ns;
            _cv = cv;
            _passwd = passwd;
            _enable = enable;
        }
        public Giangvien() { }







    }
}

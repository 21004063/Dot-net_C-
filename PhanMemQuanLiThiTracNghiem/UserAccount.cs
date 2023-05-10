using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLiThiTracNghiem
{
    //Đối tượng đại diện cho user --> group --> phân quyền trên group
    class UserAccount
    {
        private string uid;
        private string subid;
        private string password;
        private bool status;

        public UserAccount()
        {
        }

        public UserAccount(string uid, string subid, string password, bool status)
        {
            this.uid = uid;
            this.subid = subid;
            this.password = password;
            this.status = status;
        }

        public string Username {
            get { return uid; }    // phương thức get --> trả về
            set { uid = value; }   // phương thức set --> gán vào
        }

        public string GivenName {
            get { return subid; }    // phương thức get --> trả về
            set { subid = value; }   // phương thức set --> gán vào    
        }

        public string Password
        {
            get { return password; }    // phương thức get --> trả về
            set { password = value; }   // phương thức set --> gán vào    
        }

        public bool Status
        {
            get { return status; }    // phương thức get --> trả về
            set { status = value; }   // phương thức set --> gán vào    
        }
    }
}

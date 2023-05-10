using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PhanMemQuanLiThiTracNghiem
{
    class ConnectionData
    {
        //Chuỗi khởi tạo kết nối đến SQL
        private static string stringConnection = @"Data Source=HCN\SQLEXPRESS;Initial Catalog=demo2;Integrated Security=True";
        //private static string stringConnection = @"Data Source=.\SQLEXPRESS;Integrated Security=True";

        public static void Update_stringConnection(string new_stringConnection)
        {
            stringConnection = new_stringConnection;
        }

        //Hàm trả về kết nối dựa trên biến @stringConnection
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}

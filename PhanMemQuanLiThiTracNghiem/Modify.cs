using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PhanMemQuanLiThiTracNghiem
{
    class Modify
    {
        public Modify()
        {
        }
        SqlCommand sqlCommand;      //Dùng để truy vấn
        SqlDataReader dataReader;   //Dùng để đọc dữ liệu trong bảng

        //Hàm truy vấn theo câu query truyền vào và trả về 1 List các đối tượng là UserAccount
        public List<UserAccount> Accounts(string query)
        {
            //string query: là câu truy vấn (SELECT ...)
            List<UserAccount> accounts = new List<UserAccount>();
            //Khởi tạo kết nối -- dùng xong sẽ bị xóa
            using (SqlConnection sqlConnection = ConnectionData.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    accounts.Add(new UserAccount(dataReader.GetString(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetBoolean(3)));
                }
                sqlConnection.Close();
            }
            return accounts;
        }

        public List<Khoa> ThongTinKhoa(string query)
        {
            List<Khoa> khoas = new List<Khoa>();
            //Khởi tạo kết nối -- dùng xong sẽ bị xóa
            using (SqlConnection sqlConnection = ConnectionData.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    khoas.Add(new Khoa(dataReader.GetString(0), dataReader.GetString(1)));
                }
                sqlConnection.Close();
            }
            return khoas;
        }

        public List<Giangvien> ThongTinGiangVien(string query)
        {
            List<Giangvien> giangviens = new List<Giangvien>();
            //Khởi tạo kết nối -- dùng xong sẽ bị xóa
            using (SqlConnection sqlConnection = ConnectionData.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    giangviens.Add(new Giangvien(dataReader.GetString(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetBoolean(4), dataReader.GetDateTime(5), dataReader.GetString(6), dataReader.GetString(7), dataReader.GetBoolean(8)));
                }
                sqlConnection.Close();
            }

            return giangviens;
        }

        public List<Sinhvien> ThongTinSinhVien(string query)
        {
            List<Sinhvien> sinhviens = new List<Sinhvien>();
            //Khởi tạo kết nối -- dùng xong sẽ bị xóa
            using (SqlConnection sqlConnection = ConnectionData.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    sinhviens.Add(new Sinhvien(dataReader.GetString(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetBoolean(3), dataReader.GetBoolean(4), dataReader.GetString(5), dataReader.GetBoolean(6)));
                }
                sqlConnection.Close();
            }

            return sinhviens;
        }


        public void ChinhSuaDuLieu(string query)
        {
            using (SqlConnection sqlConnection = ConnectionData.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteReader();
                sqlConnection.Close();
            }
        }

        




    }
}
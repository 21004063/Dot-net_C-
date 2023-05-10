using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;
using System.Configuration;
using Microsoft.Win32;

namespace PhanMemQuanLiThiTracNghiem
{
    class GetInfo
    {

        public static bool TryServerName(string ServerName)
        {
            string connectionString = @"Data Source=" + ServerName + "; Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    connection.Close();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            
        }

        //Hiển thị các database của server đã chọn
        public static List<string> GetDatabase(string ServerName)
        {
            List<string> listdatabase = new List<string>();
            string connectionString = @"Data Source="+ServerName+"; Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT name from sys.databases", connection))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                listdatabase.Add(dr[0].ToString());
                            }
                        }
                    }
                    connection.Close();
                } catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối!"+ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return listdatabase;
        }

        //Hàm trả về kết nối dựa trên kết nối dựa trên hai combobox đã chọn
        public static SqlConnection GetSqlConnection(string ServerName, string Database)
        {
            string stringConnection = @"Data Source=" + ServerName + ";Initial Catalog=" + Database + ";Integrated Security=True";
            return new SqlConnection(stringConnection);
        }

        //Hàm kiểm tra kết nối dựa trên kết nối dựa trên hai combobox đã chọn
        public static void TestSqlConnection(string ServerName, string Database="")
        {
            //Khởi tạo kết nối -- dùng xong sẽ bị xóa
            try
            {
                using (SqlConnection sqlConnection = GetSqlConnection(ServerName, Database))
                {
                    sqlConnection.Open();
                    sqlConnection.Close();
                }
                MessageBox.Show("Kết nối thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối!\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Hàm trả về kết nối dựa trên stringConnection
        public static SqlConnection GetSqlConnection(string stringConnection)
        {
            return new SqlConnection(stringConnection);
        }

        //Hàm kiểm tra kết nối dựa trên stringConnection
        public static bool TestSqlConnection(string stringConnection)
        {
            //Khởi tạo kết nối -- dùng xong sẽ bị xóa
            try
            {
                using (SqlConnection sqlConnection = GetSqlConnection(stringConnection))
                {
                    sqlConnection.Open();
                    sqlConnection.Close();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //Hàm tạo chuỗi stringConnection từ hai combobox value
        public static string Get_stringConnection(string ServerName, string Database)
        {
            string stringConnection = @"Data Source=" + ServerName + ";Initial Catalog=" + Database + ";Integrated Security=True";
            return stringConnection;
        }

        //Hàm áp dụng stringConnection từ hai combobox value, lưu cấu hình lâu dài
        public static void ApplySqlConnection(string ServerName, string Database)
        {
            TestSqlConnection(ServerName, Database);
            //Cập nhật giá trị stringConnection trong class ConnectionData
            ConnectionData.Update_stringConnection(Get_stringConnection(ServerName, Database));
            
            //Cập nhật giá trị cho App.config
            /*
             * Vào References --> Chuột phải chọn "Add References" --> tìm "System.Configuration" --> Thêm vào
             */
            // Tạo một đối tượng ConnectionStringSettings mới
            //ConnectionStringSettings connectionString = new ConnectionStringSettings();
            //connectionString.Name = "MyConnectionString";
            //connectionString.ConnectionString = Get_stringConnection(ServerName, Database);
            //connectionString.ProviderName = "System.Data.SqlClient";

            // Lấy đối tượng Configuration mới cho ứng dụng
            //Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            // Thêm chuỗi kết nối vào phần connectionStrings của file cấu hình
            //config.ConnectionStrings.ConnectionStrings.Add(connectionString);

            // Lưu thay đổi vào file cấu hình
            //config.Save(ConfigurationSaveMode.Modified);

            // Load lại file cấu hình
            //ConfigurationManager.RefreshSection("connectionStrings");

            // Lưu chuỗi kết nối vào Registry
            //Registry.SetValue(@"HKEY_CURRENT_USER\Software\MyAppName", "MyConnectionString", ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\MyAppName", "MyConnectionString", Get_stringConnection(ServerName, Database));
            // Đọc chuỗi kết nối từ Registry
            //string temp = Registry.GetValue(@"HKEY_CURRENT_USER\Software\MyAppName", "MyConnectionString", "").ToString();
        }

        //Hàm lấy các server SQL có thể kết nối được
        public static List<string> GetSqlInstances()
        {
            List<string> listserver = new List<string>();
            string ServerName = Environment.MachineName;
            listserver.Add(ServerName);
            RegistryView registryView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;
            using (RegistryKey hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryView))
            {
                RegistryKey instanceKey = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", false);
                if (instanceKey != null)
                {
                    foreach (var instanceName in instanceKey.GetValueNames())
                    {
                        listserver.Add(ServerName + "\\" + instanceName);
                        listserver.Add(@"localhost\" + instanceName);
                        listserver.Add(@".\" + instanceName);
                    }
                }
            }
            return listserver;
        }

    }
}

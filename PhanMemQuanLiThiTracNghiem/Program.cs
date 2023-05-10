using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLiThiTracNghiem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                string connectionString = Registry.GetValue(@"HKEY_CURRENT_USER\Software\MyAppName", "MyConnectionString", "").ToString();
                if (GetInfo.TestSqlConnection(connectionString) == true)
                {
                    ConnectionData.Update_stringConnection(connectionString);
                    Application.Run(new frm_QuanTri());
                }
                else
                {
                    Application.Run(new frm_KetNoiDatabase());
                }
            }
            catch (Exception)
            {
                Application.Run(new frm_KetNoiDatabase());
            }
        }
    }
}

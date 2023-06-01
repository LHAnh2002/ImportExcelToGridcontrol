using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImportExcelToGridcontrol
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            FirestoreDb firestoreDb;
            try
            {
                string path = AppDomain.CurrentDomain.BaseDirectory + @"rokboard.json";
                Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

                firestoreDb = FirestoreDb.Create("rokboard-84336");
                MessageBox.Show("Kết Nối Thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết Nối Thất Bại" + ex);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmImportExcelToGridcontrol());
        }
    }
}

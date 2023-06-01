using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImportExcelToGridcontrol
{
    public partial class frmFileExect : DevExpress.XtraEditors.XtraForm
    {
        FirestoreDb firestoreDb;
        public frmFileExect()
        {
            InitializeComponent();
        }

        private async void frmFileExect_Load(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"rokboard.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            firestoreDb = FirestoreDb.Create("rok-board-aef6a");
            var collection = firestoreDb.Collection("users");
            var query = collection.OrderBy("server");

            var documents = await query.GetSnapshotAsync();
            cbbserver.Properties.Items.Clear();
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            foreach (var document in documents)
            {
                var data = document.ToDictionary();
                var value = data["server"].ToString();
                cbbserver.Properties.Items.Add(value);
            }
            SplashScreenManager.CloseForm();
            if (cbbserver.Properties.Items.Count > 0)
            {
                cbbserver.SelectedIndex = 0;
            }
        }

        private async void simpleButton1_Click(object sender, EventArgs e)
        {
            string link = txtKpi.Text.Trim();
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            string kingdom = cbbserver.Text;
            if (kingdom == "")
            {
                MessageBox.Show("Email không thể trống");
                return;
            }
            try
            {
                DocumentReference docRef = firestoreDb.Collection("users").Document(kingdom);
                Dictionary<string, object> keys = new Dictionary<string, object>()
                 {
                     {"kpi",link},
                 };
                await docRef.UpdateAsync(keys);
                SplashScreenManager.CloseForm();
                MessageBox.Show("Update Kpi Thành Công?", "Thông báo", MessageBoxButtons.OKCancel);
            }
            catch (Exception ex) 
            { 
                MessageBox.Show("Erorr" + ex); 
            }
        }

        private async void comboBoxEdit1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
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
    public partial class Deo : DevExpress.XtraEditors.XtraForm
    {
        FirestoreDb firestoreDb;
        public Deo()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string kpi = txtKpi.Text.Trim();
            string server = txtServer.Text.Trim();
            int dien50 = int.Parse(txtdien50.Text.Trim());
            int dieh50 = int.Parse(txtdieh50.Text.Trim());
            int killt4 = int.Parse(txtkt4.Text.Trim());
            int killt5 = int.Parse(txtServer.Text.Trim());
            int pow = int.Parse(txtpow.Text.Trim());
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            WriteBatch batch = firestoreDb.StartBatch();
            if (server == "")
            {
                MessageBox.Show("Sever không thể trống");
                return;
            }
            DateTime currentTime = DateTime.UtcNow;
            Timestamp timestamp = Timestamp.FromDateTime(currentTime);
            try
            {
                DocumentReference docRef = firestoreDb.Collection("users").Document(server);
                Dictionary<string, object> keys = new Dictionary<string, object>()
                 {
                     {"kpi",kpi},
                     {"killt4",  killt4 },
                     {"killt5",killt5 },
                     {"server",server },
                     {"dien50",dien50},
                     {"dieh50",dieh50},
                     {"date",timestamp },
                     {"pow",pow }
                 };
                batch.Set(docRef, keys);
                batch.CommitAsync();
                SplashScreenManager.CloseForm();
                MessageBox.Show("Tạo tài khoản Thành Công?", "Thông báo", MessageBoxButtons.OKCancel);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erorr" + ex);
            }

        }

        private void Deo_Load(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"rokboard.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            firestoreDb = FirestoreDb.Create("rok-board-aef6a");
        }
    }
}
using DevExpress.DataAccess.Excel;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraSplashScreen;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Linq;


namespace ImportExcelToGridcontrol
{
    public partial class frmImportExcelToGridcontrol : DevExpress.XtraEditors.XtraForm
    {
        FirestoreDb firestoreDb;
        
        public frmImportExcelToGridcontrol()
        {

            InitializeComponent();
            loadrokboard();
           
           
        }
        private async void frmImportExcelToGridcontrol_Load(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"rokboard.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            firestoreDb = FirestoreDb.Create("rok-board-aef6a");
            var collection = firestoreDb.Collection("users");
            var query = collection.OrderBy("server");

            var documents = await query.GetSnapshotAsync();
            txtServer.Properties.Items.Clear();
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            foreach (var document in documents)
            {
                var data = document.ToDictionary();
                var value = data["server"].ToString();
                txtServer.Properties.Items.Add(value);
            }
            SplashScreenManager.CloseForm();
            if (txtServer.Properties.Items.Count > 0)
            {
                txtServer.SelectedIndex = 0;
            }


        }
        private List<Rokboard> lstRok;
        private List<Product> lstrank;
        private void loadrokboard()
        {
            lstRok = new List<Rokboard>();
            lstrank = new List<Product>();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select File";
            openFileDialog.Filter = "Excel (*.xls) | *.xls";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Browse.Text = openFileDialog.FileName;
                ExcelDataSource excelDataSource = new ExcelDataSource();
                excelDataSource.FileName = Browse.Text;
                ExcelWorksheetSettings excelWorksheetSettings = new ExcelWorksheetSettings("Mydata", "A1:O500");
                excelDataSource.SourceOptions = new ExcelSourceOptions(excelWorksheetSettings);
                excelDataSource.SourceOptions = new CsvSourceOptions() { CellRange = "A1:O500" };
                excelDataSource.SourceOptions.SkipEmptyRows = false;
                excelDataSource.SourceOptions.UseFirstRowAsHeader = true;
                excelDataSource.Fill();
                gcData.DataSource = excelDataSource;
            }
        }

        private async void btnLuu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là tạo mới dữ liệu?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                loaddata();

                string kingdom = txtServer.Text;
                if (kingdom == "")
                {
                    MessageBox.Show("KingDom không thể trống");
                    gvData.PopulateColumns();
                    gvData.Columns.Clear();

                    // Xóa tất cả dữ liệu khỏi Grid Control
                    gcData.DataSource = null;
                    return;
                }
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                foreach (var rok in lstRok)
                {
                    int rank = rok.rank;
                    int id = rok.id;
                    string name = rok.name;
                    int pow = rok.pow;
                    int deads = rok.deads;
                    int kill_t4 = rok.kill_t4;
                    int kill_t5 = rok.kill_t5;

                    DateTime currentTime = DateTime.UtcNow;
                    Timestamp timestamp = Timestamp.FromDateTime(currentTime);
                    DocumentReference docRef = firestoreDb.Collection(txtServer.Text).Document(id.ToString());
                    Dictionary<string, object> keys = new Dictionary<string, object>()
            {
                {"name",name },
                {"top",rank},
                {"id",  id },
                {"top_pow",pow },
                {"top_die",deads},
                {"top_killt4",kill_t4 },
                {"top_killt5",kill_t5 },
                {"point",0 },
                {"ban", false}
            };
                    await docRef.SetAsync(keys);
                    DocumentReference docReff = firestoreDb.Collection(txtServer.Text).Document(id.ToString()).Collection("data").Document();
                    Dictionary<string, object> keyss = new Dictionary<string, object>()
            {
                {"name",name },
                {"pow_later",pow},
                {"die_later",deads},
                {"killt4_later",kill_t4},
                {"killt5_later",kill_t5},
                {"date",timestamp },
            };
                    await docReff.SetAsync(keyss);
                }
                SplashScreenManager.CloseForm();

                // Xóa tất cả các cột khỏi Grid Control
                gvData.PopulateColumns();
                gvData.Columns.Clear();
                Browse.Text = string.Empty;
                // Xóa tất cả dữ liệu khỏi Grid Control
                gcData.DataSource = null;
                MessageBox.Show("Tạo Dữ Liệu Thành Công", "Thông báo", MessageBoxButtons.OK);
            }
        }


        void loaddata()
        {
            for (int i = 0; i < gvData.RowCount; i++)
            {
                Rokboard rok = new Rokboard();
                for (int j = 0; j < gvData.Columns.Count; j++)
                {
                    var value = gvData.GetRowCellValue(i, gvData.Columns[j]);
                    switch (j)
                    {
                        case 0:
                            if (int.TryParse(value.ToString(), out int rank))
                                rok.rank = rank;
                            break;
                        case 1:
                            rok.name = value.ToString();

                            break;
                        case 2:
                            if (int.TryParse(value.ToString(), out int id))
                                rok.id = id;
                            break;
                        case 3:
                            if (int.TryParse(value.ToString(), out int pow))
                                rok.pow = pow;
                            break;
                        case 4:
                            if (int.TryParse(value.ToString(), out int deads))
                                rok.deads = deads;
                            break;
                        case 5:
                            if (int.TryParse(value.ToString(), out int kill_t4))
                                rok.kill_t4 = kill_t4;
                            break;
                        case 6:
                            if (int.TryParse(value.ToString(), out int kill_t5))
                                rok.kill_t5 = kill_t5;
                            break;
                    }
                }
                lstRok.Add(rok);
            }
            gcData.DataSource = null;
            gcData.DataSource = lstRok;
        }

        private async void simpleButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có chắc là thêm mới dữ liệu?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                loaddata();

                string kingdom = txtServer.Text;
                if (kingdom == "")
                {
                    MessageBox.Show("KingDom không thể trống");
                    gvData.PopulateColumns();
                    gvData.Columns.Clear();

                    // Xóa tất cả dữ liệu khỏi Grid Control
                    gcData.DataSource = null;
                    return;
                }
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                WriteBatch batch = firestoreDb.StartBatch();

                foreach (var rok in lstRok)
                {
                    int id = rok.id;
                    int rank = rok.rank;
                    string name = rok.name;
                    int pow = rok.pow;
                    int deads = rok.deads;
                    int kill_t4 = rok.kill_t4;
                    int kill_t5 = rok.kill_t5;

                    DateTime currentTime = DateTime.UtcNow;
                    Timestamp timestamp = Timestamp.FromDateTime(currentTime);
                    DocumentReference docRef = firestoreDb.Collection(txtServer.Text).Document(id.ToString());
                    DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();
                    if (snapshot.Exists)
                    {
                        Dictionary<string, object> keys = new Dictionary<string, object>()
                        {
                            {"name",name },
                        };
                        await docRef.UpdateAsync(keys);
                        DocumentReference docReff = firestoreDb.Collection(txtServer.Text).Document(id.ToString()).Collection("data").Document();
                        Dictionary<string, object> keyss = new Dictionary<string, object>()
                        {
                            {"name",name },
                            {"pow_later",pow},
                            {"die_later",deads},
                            {"killt4_later",kill_t4},
                            {"killt5_later",kill_t5},
                            {"date",timestamp },
                        };
                        await docReff.SetAsync(keyss);
                    }
                    else
                    {
                        Dictionary<string, object> keys = new Dictionary<string, object>()
                        {
                            {"name",name },
                            {"top",rank},
                            {"id",  id },
                            {"top_pow",pow },
                            {"top_die",deads},
                            {"top_killt4",kill_t4 },
                            {"top_killt5",kill_t5 },
                            {"point",0 },
                            {"ban", false}
                        };

                        await docRef.SetAsync(keys);
                        
                        DocumentReference docReff = firestoreDb.Collection(txtServer.Text).Document(id.ToString()).Collection("data").Document();
                        Dictionary<string, object> keyss = new Dictionary<string, object>()
                        {   
                            {"name",name },
                            {"pow_later",pow},
                            {"die_later",deads},
                            {"killt4_later",kill_t4},
                            {"killt5_later",kill_t5},
                            {"date",timestamp },
                        };
                        await docReff.SetAsync(keyss);
                    };

                        // Lưu id vào file text
                        string filePath = "/update.txt";
                        using (StreamWriter sw = File.AppendText(filePath))
                        {
                            sw.WriteLine(id.ToString());
                        }
                    }


                }

                SplashScreenManager.CloseForm();
                
                // Xóa tất cả các cột khỏi Grid Control
                gvData.PopulateColumns();
                gvData.Columns.Clear();

                // Xóa tất cả dữ liệu khỏi Grid Control
                gcData.DataSource = null;
                Browse.Text= string.Empty;
                MessageBox.Show("Thêm Dữ Liệu Thành Công?", "Thông báo", MessageBoxButtons.OKCancel);

            }

        

        private void btnDatadeodich_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Deo f = new Deo();
            f.Show();

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmFileExect f = new frmFileExect();
            f.Show();
        }

        private async void btnXapXep_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Tải data và xắp xếp?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string kingdom = txtServer.Text;
                if (kingdom == "")
                {
                    MessageBox.Show("KingDom không thể trống");
                    gvData.PopulateColumns();
                    gvData.Columns.Clear();

                    // Xóa tất cả dữ liệu khỏi Grid Control
                    gcData.DataSource = null;
                    return;
                }
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                WriteBatch batch = firestoreDb.StartBatch();

                // Lấy collection "products"
                CollectionReference collectionRef = firestoreDb.Collection(txtServer.Text);
                Query query = collectionRef.WhereEqualTo("ban", false);
                QuerySnapshot querySnapshot = await query.GetSnapshotAsync();

                // Tính toán và sắp xếp danh sách sản phẩm
                List<Product> productList = new List<Product>();
                int stt = 1;
                foreach (DocumentSnapshot documentSnapshot in querySnapshot.Documents)
                {
                    // Lấy dữ liệu từ collection cha
                    int productId = int.Parse(documentSnapshot.Id);
                    string productName = documentSnapshot.GetValue<string>("name");
                    int top_pow = documentSnapshot.GetValue<int>("top_pow");
                    int top_killt4 = documentSnapshot.GetValue<int>("top_killt4");
                    int top_killt5 = documentSnapshot.GetValue<int>("top_killt5");
                    int top_die = documentSnapshot.GetValue<int>("top_die");

                    // Truy cập vào collection con của mỗi document
                    CollectionReference subCollectionRef = documentSnapshot.Reference.Collection("data");
                    QuerySnapshot subQuerySnapshot = await subCollectionRef.GetSnapshotAsync();

                    // Tìm document con có ngày gần nhất
                    DateTime closestDate = DateTime.MinValue;
                    DocumentSnapshot closestDocument = null;

                    foreach (DocumentSnapshot subDocumentSnapshot in subQuerySnapshot.Documents)
                    {
                        DateTime documentDate = subDocumentSnapshot.GetValue<DateTime>("date");

                        if (documentDate > closestDate && documentDate < DateTime.Now)
                        {
                            closestDate = documentDate;
                            closestDocument = subDocumentSnapshot;
                        }
                    }

                    if (closestDocument != null)
                    {
                        // Lấy dữ liệu từ document con gần nhất
                        int killt4_later = closestDocument.GetValue<int>("killt4_later");
                        int killt5_later = closestDocument.GetValue<int>("killt5_later");
                        int pow = closestDocument.GetValue<int>("pow_later");
                        int die_later = closestDocument.GetValue<int>("die_later");

                        // Tính toán dữ liệu
                        int killt4 = killt4_later - top_killt4;
                        int killt5 = killt5_later - top_killt5;
                        int die = die_later - top_die;
                        int point = 0;

                        if (top_pow < int.Parse(txtpow.Text.Trim()))
                        {
                            point = die * int.Parse(txtdien50.Text.Trim()) + killt4 * int.Parse(txtkt4.Text.Trim()) + killt5 * int.Parse(txtkillt5.Text.Trim());
                        }
                        else
                        {
                            point = die * int.Parse(txtdieh50.Text.Trim()) + killt4 * int.Parse(txtkt4.Text.Trim()) + killt5 * int.Parse(txtkillt5.Text.Trim());
                        }

                        // Tạo đối tượng Product
                        Product product = new Product(productId, productName, pow, killt4, killt5, die, point);
                        product.STT = stt; // Thiết lập giá trị cho cột STT
                        productList.Add(product);
                        stt++;
                    }
                }

                productList.Sort((p1, p2) => p2.Point.CompareTo(p1.Point));

                for (int i = 0; i < productList.Count; i++)
                {
                    productList[i].STT = i + 1;
                }

                // Hiển thị danh sách sản phẩm trong GridView
                gcData.DataSource = productList;
                gcData.RefreshDataSource();

                SplashScreenManager.CloseForm();
                MessageBox.Show("Xắp xếp Dữ Liệu Thành Công?", "Thông báo", MessageBoxButtons.OKCancel);
                btnluustt.Visible = true;
            }
        }
            void loaddataRank()
        {
            for (int i = 0; i < gvData.RowCount; i++)
            {
                Product rok = new Product(0,0,"",0,0,0,0,0);
                for (int j = 0; j < gvData.Columns.Count; j++)
                {
                    var value = gvData.GetRowCellValue(i, gvData.Columns[j]);
                    switch (j)
                    {
                        case 0:
                            if (int.TryParse(value.ToString(), out int stt))
                                rok.STT = stt;
                            break;
                        case 1:
                            if (int.TryParse(value.ToString(), out int id))
                                rok.Id = id;
                            break;
                        case 2:
                            rok.Name = value.ToString();

                            break;
                        case 3:
                            if (int.TryParse(value.ToString(), out int pow))
                                rok.Pow = pow;
                            break;
                        case 4:
                            if (int.TryParse(value.ToString(), out int deads))
                                rok.Die = deads;
                            break;
                        case 5:
                            if (int.TryParse(value.ToString(), out int kill_t4))
                                rok.Killt4 = kill_t4;
                            break;
                        case 6:
                            if (int.TryParse(value.ToString(), out int kill_t5))
                                rok.Killt4 = kill_t5;
                            break;
                        case 7:
                            if (int.TryParse(value.ToString(), out int point))
                                rok.Point = point;
                            break;
                    }
                }
                lstrank.Add(rok);
            }
            gcData.DataSource = null;
            gcData.DataSource = lstRok;
        }
            
        private async void btnluustt_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có chắc là Lưu số thứ tự mới?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                loaddataRank();

                string kingdom = txtServer.Text;
                if (kingdom == "")
                {
                    MessageBox.Show("KingDom không thể trống");
                    gvData.PopulateColumns();
                    gvData.Columns.Clear();

                    // Xóa tất cả dữ liệu khỏi Grid Control
                    gcData.DataSource = null;
                    return;
                }
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                WriteBatch batch = firestoreDb.StartBatch();

                foreach (var rok in lstrank)
                {
                    int id = rok.Id;
                    int stt = rok.STT;
                    int point = rok.Point;

                    DocumentReference docRef = firestoreDb.Collection(txtServer.Text).Document(id.ToString());
             
                        Dictionary<string, object> updates = new Dictionary<string, object>()
                        {
                            {"top", stt },
                            {"point",point }
                        };
                        await docRef.UpdateAsync(updates);
                    
                    
                }

                SplashScreenManager.CloseForm();
                MessageBox.Show("Thay đổi số thứ tự thành công", "Thông báo", MessageBoxButtons.OKCancel);
                // Xóa tất cả các cột khỏi Grid Control
                gvData.PopulateColumns();
                gvData.Columns.Clear();

                // Xóa tất cả dữ liệu khỏi Grid Control
                gcData.DataSource = null;

            }
        }

        private async void rdoTaomoidata_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedRadioButton = groupBox1.Controls.OfType<RadioButton>()
                                                           .FirstOrDefault(r => r.Checked);
            if (selectedRadioButton == rdoTaomoidata)
            {
                // Hiển thị button 1, ẩn button 2 và 3
                btnLuu.Visible = true;
                simpleButton1.Visible = false;
                btnXapXep.Visible = false;
            }
            else if (selectedRadioButton == rdoThemmoidata)
            {
                // Hiển thị button 2, ẩn button 1 và 3
                btnLuu.Visible = false;
                simpleButton1.Visible = true;
                btnXapXep.Visible = false;
            }
            else if (selectedRadioButton == rdoXapxep)
            {
                // Hiển thị button 3, ẩn button 1 và 2
                btnLuu.Visible = false;
                simpleButton1.Visible = false;
                btnXapXep.Visible = true;
                CollectionReference collectionRef = firestoreDb.Collection("users");
                DocumentReference documentRef = collectionRef.Document(txtServer.Text.Trim());

                // Lấy dữ liệu từ Firestore
                DocumentSnapshot snapshot = await documentRef.GetSnapshotAsync();
                if (snapshot.Exists)
                {
                    Dictionary<string, object> data = snapshot.ToDictionary();
                    if (data.ContainsKey("dien50"))
                    {
                        string dien50 = data["dien50"].ToString();
                        txtdien50.Text = dien50;
                    }
                    if (data.ContainsKey("dieh50"))
                    {
                        string dieh50 = data["dieh50"].ToString();
                        txtdieh50.Text = dieh50;
                    }
                    if (data.ContainsKey("killt4"))
                    {
                        string killt4 = data["killt4"].ToString();
                        txtkt4.Text = killt4;
                    }
                    if (data.ContainsKey("killt5"))
                    {
                        string killt5 = data["killt5"].ToString();
                        txtkillt5.Text = killt5;
                    }
                    if (data.ContainsKey("pow"))
                    {
                        string pow = data["pow"].ToString();
                        txtpow.Text = pow;
                    }
                }
                gvData.PopulateColumns();
                gvData.Columns.Clear();

                // Xóa tất cả dữ liệu khỏi Grid Control
                gcData.DataSource = null;
            }
            else
            {
                // Không có radio button nào được chọn, ẩn tất cả các button
                btnLuu.Visible = false;
                simpleButton1.Visible = false;
                btnXapXep.Visible = false;
            }
            if (Browse == null || string.IsNullOrEmpty(Browse.Text))
            {
                btnLuu.Enabled = false;
                simpleButton1.Enabled = false;
            }
            else
            {
                btnLuu.Enabled = true;
                simpleButton1.Enabled = true;
            }
        }

        private void Browse_TextChanged(object sender, EventArgs e)
        {
            if (Browse == null || string.IsNullOrEmpty(Browse.Text))
            {
                btnLuu.Enabled = false;
                simpleButton1.Enabled = false;
            }
            else
            {
                btnLuu.Enabled = true;
                simpleButton1.Enabled = true;
            }
        }


    }


}
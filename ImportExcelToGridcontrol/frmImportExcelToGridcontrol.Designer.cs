
namespace ImportExcelToGridcontrol
{
    partial class frmImportExcelToGridcontrol
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImportExcelToGridcontrol));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnBrowse = new DevExpress.XtraEditors.SimpleButton();
            this.gcData = new DevExpress.XtraGrid.GridControl();
            this.gvData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Browse = new DevExpress.XtraEditors.TextEdit();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnTaotaikhoan = new DevExpress.XtraBars.BarButtonItem();
            this.btnUpdateKpi = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnXapXep = new DevExpress.XtraEditors.SimpleButton();
            this.btnluustt = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoXapxep = new System.Windows.Forms.RadioButton();
            this.rdoThemmoidata = new System.Windows.Forms.RadioButton();
            this.rdoTaomoidata = new System.Windows.Forms.RadioButton();
            this.txtServer = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtdien50 = new DevExpress.XtraEditors.TextEdit();
            this.txtkt4 = new DevExpress.XtraEditors.TextEdit();
            this.txtdieh50 = new DevExpress.XtraEditors.TextEdit();
            this.txtkillt5 = new DevExpress.XtraEditors.TextEdit();
            this.Die = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtpow = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Browse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtServer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdien50.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtkt4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdieh50.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtkillt5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpow.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(508, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(34, 22);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Path";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Appearance.Options.UseFont = true;
            this.btnBrowse.Location = new System.Drawing.Point(885, 35);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(94, 29);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // gcData
            // 
            this.gcData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcData.Location = new System.Drawing.Point(12, 161);
            this.gcData.MainView = this.gvData;
            this.gcData.Name = "gcData";
            this.gcData.Size = new System.Drawing.Size(967, 433);
            this.gcData.TabIndex = 3;
            this.gcData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvData});
            // 
            // gvData
            // 
            this.gvData.GridControl = this.gcData;
            this.gvData.Name = "gvData";
            this.gvData.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            // 
            // Browse
            // 
            this.Browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Browse.Enabled = false;
            this.Browse.Location = new System.Drawing.Point(558, 39);
            this.Browse.Name = "Browse";
            this.Browse.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Browse.Properties.Appearance.Options.UseFont = true;
            this.Browse.Size = new System.Drawing.Size(303, 26);
            this.Browse.TabIndex = 4;
            this.Browse.TextChanged += new System.EventHandler(this.Browse_TextChanged);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Location = new System.Drawing.Point(448, 614);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(94, 29);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Tạo Mới";
            this.btnLuu.Visible = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(49, 39);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(59, 22);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Server:";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(448, 614);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(94, 29);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "Thêm mới";
            this.simpleButton1.Visible = false;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnTaotaikhoan,
            this.btnUpdateKpi});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 2;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(68, 309);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnTaotaikhoan),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnUpdateKpi)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnTaotaikhoan
            // 
            this.btnTaotaikhoan.Caption = "Tạo Tài Khoản";
            this.btnTaotaikhoan.Id = 0;
            this.btnTaotaikhoan.Name = "btnTaotaikhoan";
            this.btnTaotaikhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDatadeodich_ItemClick);
            // 
            // btnUpdateKpi
            // 
            this.btnUpdateKpi.Caption = "Update Kpi";
            this.btnUpdateKpi.Id = 1;
            this.btnUpdateKpi.Name = "btnUpdateKpi";
            this.btnUpdateKpi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(991, 26);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 635);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(991, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 26);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 609);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(991, 26);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 609);
            // 
            // btnXapXep
            // 
            this.btnXapXep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXapXep.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXapXep.Appearance.Options.UseFont = true;
            this.btnXapXep.Location = new System.Drawing.Point(448, 614);
            this.btnXapXep.Name = "btnXapXep";
            this.btnXapXep.Size = new System.Drawing.Size(94, 29);
            this.btnXapXep.TabIndex = 13;
            this.btnXapXep.Text = "Xắp xếp";
            this.btnXapXep.Visible = false;
            this.btnXapXep.Click += new System.EventHandler(this.btnXapXep_Click);
            // 
            // btnluustt
            // 
            this.btnluustt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnluustt.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluustt.Appearance.Options.UseFont = true;
            this.btnluustt.Location = new System.Drawing.Point(558, 614);
            this.btnluustt.Name = "btnluustt";
            this.btnluustt.Size = new System.Drawing.Size(94, 29);
            this.btnluustt.TabIndex = 14;
            this.btnluustt.Text = "Lưu";
            this.btnluustt.Visible = false;
            this.btnluustt.Click += new System.EventHandler(this.btnluustt_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoXapxep);
            this.groupBox1.Controls.Add(this.rdoThemmoidata);
            this.groupBox1.Controls.Add(this.rdoTaomoidata);
            this.groupBox1.Location = new System.Drawing.Point(61, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 84);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // rdoXapxep
            // 
            this.rdoXapxep.AutoSize = true;
            this.rdoXapxep.Location = new System.Drawing.Point(155, 30);
            this.rdoXapxep.Name = "rdoXapxep";
            this.rdoXapxep.Size = new System.Drawing.Size(110, 21);
            this.rdoXapxep.TabIndex = 36;
            this.rdoXapxep.TabStop = true;
            this.rdoXapxep.Text = "Xắp xếp data";
            this.rdoXapxep.UseVisualStyleBackColor = true;
            this.rdoXapxep.CheckedChanged += new System.EventHandler(this.rdoTaomoidata_CheckedChanged);
            // 
            // rdoThemmoidata
            // 
            this.rdoThemmoidata.AutoSize = true;
            this.rdoThemmoidata.Location = new System.Drawing.Point(20, 57);
            this.rdoThemmoidata.Name = "rdoThemmoidata";
            this.rdoThemmoidata.Size = new System.Drawing.Size(121, 21);
            this.rdoThemmoidata.TabIndex = 35;
            this.rdoThemmoidata.TabStop = true;
            this.rdoThemmoidata.Text = "Thêm mới data";
            this.rdoThemmoidata.UseVisualStyleBackColor = true;
            this.rdoThemmoidata.CheckedChanged += new System.EventHandler(this.rdoTaomoidata_CheckedChanged);
            // 
            // rdoTaomoidata
            // 
            this.rdoTaomoidata.AutoSize = true;
            this.rdoTaomoidata.Location = new System.Drawing.Point(20, 30);
            this.rdoTaomoidata.Name = "rdoTaomoidata";
            this.rdoTaomoidata.Size = new System.Drawing.Size(109, 21);
            this.rdoTaomoidata.TabIndex = 34;
            this.rdoTaomoidata.TabStop = true;
            this.rdoTaomoidata.Text = "Tạo mới data";
            this.rdoTaomoidata.UseVisualStyleBackColor = true;
            this.rdoTaomoidata.CheckedChanged += new System.EventHandler(this.rdoTaomoidata_CheckedChanged);
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(114, 39);
            this.txtServer.MenuManager = this.barManager1;
            this.txtServer.Name = "txtServer";
            this.txtServer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtServer.Size = new System.Drawing.Size(151, 22);
            this.txtServer.TabIndex = 36;
            // 
            // txtdien50
            // 
            this.txtdien50.Enabled = false;
            this.txtdien50.Location = new System.Drawing.Point(453, 84);
            this.txtdien50.MenuManager = this.barManager1;
            this.txtdien50.Name = "txtdien50";
            this.txtdien50.Size = new System.Drawing.Size(64, 22);
            this.txtdien50.TabIndex = 41;
            // 
            // txtkt4
            // 
            this.txtkt4.Enabled = false;
            this.txtkt4.Location = new System.Drawing.Point(588, 86);
            this.txtkt4.MenuManager = this.barManager1;
            this.txtkt4.Name = "txtkt4";
            this.txtkt4.Size = new System.Drawing.Size(64, 22);
            this.txtkt4.TabIndex = 42;
            // 
            // txtdieh50
            // 
            this.txtdieh50.Enabled = false;
            this.txtdieh50.Location = new System.Drawing.Point(453, 125);
            this.txtdieh50.MenuManager = this.barManager1;
            this.txtdieh50.Name = "txtdieh50";
            this.txtdieh50.Size = new System.Drawing.Size(64, 22);
            this.txtdieh50.TabIndex = 43;
            // 
            // txtkillt5
            // 
            this.txtkillt5.Enabled = false;
            this.txtkillt5.Location = new System.Drawing.Point(588, 124);
            this.txtkillt5.MenuManager = this.barManager1;
            this.txtkillt5.Name = "txtkillt5";
            this.txtkillt5.Size = new System.Drawing.Size(64, 22);
            this.txtkillt5.TabIndex = 44;
            // 
            // Die
            // 
            this.Die.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Die.Appearance.Options.UseFont = true;
            this.Die.Location = new System.Drawing.Point(399, 83);
            this.Die.Name = "Die";
            this.Die.Size = new System.Drawing.Size(45, 22);
            this.Die.TabIndex = 45;
            this.Die.Text = "Die <";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(399, 124);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(45, 22);
            this.labelControl3.TabIndex = 46;
            this.labelControl3.Text = "Die >";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(522, 85);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(65, 22);
            this.labelControl4.TabIndex = 47;
            this.labelControl4.Text = "Kill T4:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(522, 124);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(65, 22);
            this.labelControl5.TabIndex = 48;
            this.labelControl5.Text = "Kill T5:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(664, 85);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(64, 22);
            this.labelControl6.TabIndex = 54;
            this.labelControl6.Text = "Pow<>:";
            // 
            // txtpow
            // 
            this.txtpow.Enabled = false;
            this.txtpow.Location = new System.Drawing.Point(730, 86);
            this.txtpow.MenuManager = this.barManager1;
            this.txtpow.Name = "txtpow";
            this.txtpow.Size = new System.Drawing.Size(95, 22);
            this.txtpow.TabIndex = 53;
            // 
            // frmImportExcelToGridcontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 655);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtpow);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.Die);
            this.Controls.Add(this.txtkillt5);
            this.Controls.Add(this.txtdieh50);
            this.Controls.Add(this.txtkt4);
            this.Controls.Add(this.txtdien50);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnluustt);
            this.Controls.Add(this.btnXapXep);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.gcData);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmImportExcelToGridcontrol.IconOptions.Image")));
            this.Name = "frmImportExcelToGridcontrol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import Excel To Data";
            this.Load += new System.EventHandler(this.frmImportExcelToGridcontrol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Browse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtServer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdien50.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtkt4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdieh50.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtkillt5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpow.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnBrowse;
        private DevExpress.XtraGrid.GridControl gcData;
        private DevExpress.XtraGrid.Views.Grid.GridView gvData;
        private DevExpress.XtraEditors.TextEdit Browse;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnTaotaikhoan;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnUpdateKpi;
        private DevExpress.XtraEditors.SimpleButton btnluustt;
        private DevExpress.XtraEditors.SimpleButton btnXapXep;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoXapxep;
        private System.Windows.Forms.RadioButton rdoThemmoidata;
        private System.Windows.Forms.RadioButton rdoTaomoidata;
        private DevExpress.XtraEditors.ComboBoxEdit txtServer;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl Die;
        private DevExpress.XtraEditors.TextEdit txtkillt5;
        private DevExpress.XtraEditors.TextEdit txtdieh50;
        private DevExpress.XtraEditors.TextEdit txtkt4;
        private DevExpress.XtraEditors.TextEdit txtdien50;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtpow;
    }
}
namespace WSArchiver.GUI
{
    partial class ArchivingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArchivingForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DocTitleTB = new System.Windows.Forms.TextBox();
            this.DestinationCB = new System.Windows.Forms.ComboBox();
            this.PartyCB = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.FolderCB = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.IDRegNUD = new System.Windows.Forms.NumericUpDown();
            this.IDInNud = new System.Windows.Forms.NumericUpDown();
            this.RegDT = new System.Windows.Forms.DateTimePicker();
            this.InDT = new System.Windows.Forms.DateTimePicker();
            this.PagesLV = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SaveB = new System.Windows.Forms.Button();
            this.DeletePageB = new System.Windows.Forms.Button();
            this.importFileB = new System.Windows.Forms.Button();
            this.ProcessTB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ShowPageB = new System.Windows.Forms.Button();
            this.RenameB = new System.Windows.Forms.Button();
            this.documentInfo = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.DocSubjectTB = new System.Windows.Forms.TextBox();
            this.FolderGB = new System.Windows.Forms.GroupBox();
            this.inGB = new System.Windows.Forms.GroupBox();
            this.registrationGB = new System.Windows.Forms.GroupBox();
            this.destinationGB = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.creationDateTB = new System.Windows.Forms.TextBox();
            this.creatorTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lastModificationGB = new System.Windows.Forms.GroupBox();
            this.lastModificationDatTB = new System.Windows.Forms.TextBox();
            this.lastModifierTB = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.filesGB = new System.Windows.Forms.GroupBox();
            this.categoriesControl = new WSArchiver.GUI.UserControls.CategoriesControl();
            this.categoriesGB = new System.Windows.Forms.GroupBox();
            this.loaderBGW = new System.ComponentModel.BackgroundWorker();
            this.encryptorBGW = new System.ComponentModel.BackgroundWorker();
            this.decryptorBGW = new System.ComponentModel.BackgroundWorker();
            this.saverBGW = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IDRegNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDInNud)).BeginInit();
            this.documentInfo.SuspendLayout();
            this.FolderGB.SuspendLayout();
            this.inGB.SuspendLayout();
            this.registrationGB.SuspendLayout();
            this.destinationGB.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.lastModificationGB.SuspendLayout();
            this.filesGB.SuspendLayout();
            this.categoriesGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(853, 47);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(706, 14);
            this.label1.Size = new System.Drawing.Size(135, 19);
            this.label1.Text = "خصائص المستند";
            // 
            // exitB
            // 
            this.exitB.Location = new System.Drawing.Point(480, 606);
            this.exitB.Size = new System.Drawing.Size(96, 41);
            this.exitB.TabIndex = 10;
            this.exitB.Click += new System.EventHandler(this.exitB_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(453, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "اسم المستند";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "اسم المصدر";
            // 
            // DocTitleTB
            // 
            this.DocTitleTB.Location = new System.Drawing.Point(277, 31);
            this.DocTitleTB.Name = "DocTitleTB";
            this.DocTitleTB.Size = new System.Drawing.Size(244, 20);
            this.DocTitleTB.TabIndex = 0;
            // 
            // DestinationCB
            // 
            this.DestinationCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DestinationCB.FormattingEnabled = true;
            this.DestinationCB.Location = new System.Drawing.Point(8, 40);
            this.DestinationCB.Name = "DestinationCB";
            this.DestinationCB.Size = new System.Drawing.Size(245, 21);
            this.DestinationCB.TabIndex = 0;
            // 
            // PartyCB
            // 
            this.PartyCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PartyCB.FormattingEnabled = true;
            this.PartyCB.Location = new System.Drawing.Point(6, 30);
            this.PartyCB.Name = "PartyCB";
            this.PartyCB.Size = new System.Drawing.Size(245, 21);
            this.PartyCB.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(192, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "اسم المجلد";
            // 
            // FolderCB
            // 
            this.FolderCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FolderCB.FormattingEnabled = true;
            this.FolderCB.Location = new System.Drawing.Point(6, 73);
            this.FolderCB.Name = "FolderCB";
            this.FolderCB.Size = new System.Drawing.Size(245, 21);
            this.FolderCB.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(190, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "رقم التسجيل";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(115, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "تاريخ التسجيل";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(177, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "موضوع المستند";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(207, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "رقم الوارد";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(133, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "تاريخ الوارد";
            // 
            // IDRegNUD
            // 
            this.IDRegNUD.Location = new System.Drawing.Point(195, 48);
            this.IDRegNUD.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.IDRegNUD.Name = "IDRegNUD";
            this.IDRegNUD.Size = new System.Drawing.Size(59, 20);
            this.IDRegNUD.TabIndex = 0;
            // 
            // IDInNud
            // 
            this.IDInNud.Location = new System.Drawing.Point(195, 48);
            this.IDInNud.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.IDInNud.Name = "IDInNud";
            this.IDInNud.Size = new System.Drawing.Size(59, 20);
            this.IDInNud.TabIndex = 0;
            // 
            // RegDT
            // 
            this.RegDT.Location = new System.Drawing.Point(6, 48);
            this.RegDT.Name = "RegDT";
            this.RegDT.Size = new System.Drawing.Size(178, 20);
            this.RegDT.TabIndex = 1;
            // 
            // InDT
            // 
            this.InDT.Location = new System.Drawing.Point(6, 48);
            this.InDT.Name = "InDT";
            this.InDT.Size = new System.Drawing.Size(178, 20);
            this.InDT.TabIndex = 1;
            // 
            // PagesLV
            // 
            this.PagesLV.LargeImageList = this.imageList1;
            this.PagesLV.Location = new System.Drawing.Point(123, 19);
            this.PagesLV.Name = "PagesLV";
            this.PagesLV.RightToLeftLayout = true;
            this.PagesLV.Size = new System.Drawing.Size(564, 112);
            this.PagesLV.TabIndex = 1;
            this.PagesLV.UseCompatibleStateImageBehavior = false;
            this.PagesLV.ItemActivate += new System.EventHandler(this.PagesLV_ItemActivate);
            this.PagesLV.SelectedIndexChanged += new System.EventHandler(this.PagesLV_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "0.png");
            this.imageList1.Images.SetKeyName(1, "1.png");
            this.imageList1.Images.SetKeyName(2, "2.png");
            this.imageList1.Images.SetKeyName(3, "3.png");
            this.imageList1.Images.SetKeyName(4, "4.png");
            this.imageList1.Images.SetKeyName(5, "5.png");
            this.imageList1.Images.SetKeyName(6, "6.png");
            this.imageList1.Images.SetKeyName(7, "7.png");
            this.imageList1.Images.SetKeyName(8, "8.png");
            this.imageList1.Images.SetKeyName(9, "9.png");
            this.imageList1.Images.SetKeyName(10, "10.png");
            this.imageList1.Images.SetKeyName(11, "11.png");
            this.imageList1.Images.SetKeyName(12, "12.png");
            this.imageList1.Images.SetKeyName(13, "13.png");
            this.imageList1.Images.SetKeyName(14, "14.png");
            this.imageList1.Images.SetKeyName(15, "15.png");
            this.imageList1.Images.SetKeyName(16, "16.png");
            this.imageList1.Images.SetKeyName(17, "17.png");
            this.imageList1.Images.SetKeyName(18, "18.png");
            this.imageList1.Images.SetKeyName(19, "19.png");
            this.imageList1.Images.SetKeyName(20, "20.png");
            this.imageList1.Images.SetKeyName(21, "21.png");
            this.imageList1.Images.SetKeyName(22, "22.png");
            this.imageList1.Images.SetKeyName(23, "23.png");
            this.imageList1.Images.SetKeyName(24, "24.png");
            // 
            // SaveB
            // 
            this.SaveB.Location = new System.Drawing.Point(290, 606);
            this.SaveB.Name = "SaveB";
            this.SaveB.Size = new System.Drawing.Size(96, 41);
            this.SaveB.TabIndex = 9;
            this.SaveB.Text = "حفظ في الأرشيف";
            this.SaveB.UseVisualStyleBackColor = true;
            this.SaveB.Click += new System.EventHandler(this.SaveB_Click);
            // 
            // DeletePageB
            // 
            this.DeletePageB.Enabled = false;
            this.DeletePageB.Location = new System.Drawing.Point(6, 92);
            this.DeletePageB.Name = "DeletePageB";
            this.DeletePageB.Size = new System.Drawing.Size(112, 23);
            this.DeletePageB.TabIndex = 4;
            this.DeletePageB.Text = "حذف صفحة";
            this.DeletePageB.UseVisualStyleBackColor = true;
            this.DeletePageB.Click += new System.EventHandler(this.DeletePageB_Click);
            // 
            // importFileB
            // 
            this.importFileB.Location = new System.Drawing.Point(693, 19);
            this.importFileB.Name = "importFileB";
            this.importFileB.Size = new System.Drawing.Size(96, 41);
            this.importFileB.TabIndex = 0;
            this.importFileB.Text = "إدخال من الماسحة";
            this.importFileB.UseVisualStyleBackColor = true;
            this.importFileB.Click += new System.EventHandler(this.importFileB_Click);
            // 
            // ProcessTB
            // 
            this.ProcessTB.Location = new System.Drawing.Point(277, 70);
            this.ProcessTB.Multiline = true;
            this.ProcessTB.Name = "ProcessTB";
            this.ProcessTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ProcessTB.Size = new System.Drawing.Size(244, 106);
            this.ProcessTB.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(488, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "الإجراء";
            // 
            // ShowPageB
            // 
            this.ShowPageB.Enabled = false;
            this.ShowPageB.Location = new System.Drawing.Point(7, 28);
            this.ShowPageB.Name = "ShowPageB";
            this.ShowPageB.Size = new System.Drawing.Size(111, 23);
            this.ShowPageB.TabIndex = 2;
            this.ShowPageB.Text = "عرض صفحة";
            this.ShowPageB.UseVisualStyleBackColor = true;
            this.ShowPageB.Click += new System.EventHandler(this.ShowPageB_Click);
            // 
            // RenameB
            // 
            this.RenameB.Enabled = false;
            this.RenameB.Location = new System.Drawing.Point(7, 60);
            this.RenameB.Name = "RenameB";
            this.RenameB.Size = new System.Drawing.Size(111, 23);
            this.RenameB.TabIndex = 3;
            this.RenameB.Text = "إعادة تسمية صفحة";
            this.RenameB.UseVisualStyleBackColor = true;
            this.RenameB.Click += new System.EventHandler(this.RenameB_Click);
            // 
            // documentInfo
            // 
            this.documentInfo.Controls.Add(this.textBox1);
            this.documentInfo.Controls.Add(this.DocTitleTB);
            this.documentInfo.Controls.Add(this.label17);
            this.documentInfo.Controls.Add(this.label2);
            this.documentInfo.Controls.Add(this.ProcessTB);
            this.documentInfo.Controls.Add(this.label10);
            this.documentInfo.Controls.Add(this.DocSubjectTB);
            this.documentInfo.Controls.Add(this.label11);
            this.documentInfo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.documentInfo.Location = new System.Drawing.Point(25, 53);
            this.documentInfo.Name = "documentInfo";
            this.documentInfo.Size = new System.Drawing.Size(531, 191);
            this.documentInfo.TabIndex = 0;
            this.documentInfo.TabStop = false;
            this.documentInfo.Text = "معلومات عامة";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(244, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(194, 15);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "نوع المستند";
            // 
            // DocSubjectTB
            // 
            this.DocSubjectTB.Location = new System.Drawing.Point(11, 70);
            this.DocSubjectTB.Multiline = true;
            this.DocSubjectTB.Name = "DocSubjectTB";
            this.DocSubjectTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DocSubjectTB.Size = new System.Drawing.Size(244, 106);
            this.DocSubjectTB.TabIndex = 2;
            // 
            // FolderGB
            // 
            this.FolderGB.Controls.Add(this.label4);
            this.FolderGB.Controls.Add(this.PartyCB);
            this.FolderGB.Controls.Add(this.label7);
            this.FolderGB.Controls.Add(this.FolderCB);
            this.FolderGB.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.FolderGB.Location = new System.Drawing.Point(296, 246);
            this.FolderGB.Name = "FolderGB";
            this.FolderGB.Size = new System.Drawing.Size(260, 100);
            this.FolderGB.TabIndex = 3;
            this.FolderGB.TabStop = false;
            this.FolderGB.Text = "المصدر";
            // 
            // inGB
            // 
            this.inGB.Controls.Add(this.IDInNud);
            this.inGB.Controls.Add(this.label13);
            this.inGB.Controls.Add(this.label14);
            this.inGB.Controls.Add(this.InDT);
            this.inGB.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.inGB.Location = new System.Drawing.Point(25, 352);
            this.inGB.Name = "inGB";
            this.inGB.Size = new System.Drawing.Size(260, 100);
            this.inGB.TabIndex = 2;
            this.inGB.TabStop = false;
            this.inGB.Text = "الوارد";
            // 
            // registrationGB
            // 
            this.registrationGB.Controls.Add(this.IDRegNUD);
            this.registrationGB.Controls.Add(this.RegDT);
            this.registrationGB.Controls.Add(this.label8);
            this.registrationGB.Controls.Add(this.label9);
            this.registrationGB.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.registrationGB.Location = new System.Drawing.Point(25, 246);
            this.registrationGB.Name = "registrationGB";
            this.registrationGB.Size = new System.Drawing.Size(260, 100);
            this.registrationGB.TabIndex = 1;
            this.registrationGB.TabStop = false;
            this.registrationGB.Text = "التسجيل";
            // 
            // destinationGB
            // 
            this.destinationGB.Controls.Add(this.DestinationCB);
            this.destinationGB.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.destinationGB.Location = new System.Drawing.Point(296, 352);
            this.destinationGB.Name = "destinationGB";
            this.destinationGB.Size = new System.Drawing.Size(260, 100);
            this.destinationGB.TabIndex = 4;
            this.destinationGB.TabStop = false;
            this.destinationGB.Text = "موجه إلى : (إدارة /مكتب /موظف)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.creationDateTB);
            this.groupBox1.Controls.Add(this.creatorTB);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.Location = new System.Drawing.Point(562, 246);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الإنشاء";
            // 
            // creationDateTB
            // 
            this.creationDateTB.Location = new System.Drawing.Point(6, 73);
            this.creationDateTB.Name = "creationDateTB";
            this.creationDateTB.ReadOnly = true;
            this.creationDateTB.Size = new System.Drawing.Size(244, 20);
            this.creationDateTB.TabIndex = 1;
            this.creationDateTB.TabStop = false;
            // 
            // creatorTB
            // 
            this.creatorTB.Location = new System.Drawing.Point(6, 31);
            this.creatorTB.Name = "creatorTB";
            this.creatorTB.ReadOnly = true;
            this.creatorTB.Size = new System.Drawing.Size(244, 20);
            this.creatorTB.TabIndex = 0;
            this.creatorTB.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(189, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "تاريخ الإنشاء";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(106, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(147, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "المستخدم الذي أنشأ المستند";
            // 
            // lastModificationGB
            // 
            this.lastModificationGB.Controls.Add(this.lastModificationDatTB);
            this.lastModificationGB.Controls.Add(this.lastModifierTB);
            this.lastModificationGB.Controls.Add(this.label15);
            this.lastModificationGB.Controls.Add(this.label16);
            this.lastModificationGB.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lastModificationGB.Location = new System.Drawing.Point(562, 352);
            this.lastModificationGB.Name = "lastModificationGB";
            this.lastModificationGB.Size = new System.Drawing.Size(266, 100);
            this.lastModificationGB.TabIndex = 7;
            this.lastModificationGB.TabStop = false;
            this.lastModificationGB.Text = "التعديل الأخير";
            // 
            // lastModificationDatTB
            // 
            this.lastModificationDatTB.Location = new System.Drawing.Point(6, 73);
            this.lastModificationDatTB.Name = "lastModificationDatTB";
            this.lastModificationDatTB.ReadOnly = true;
            this.lastModificationDatTB.Size = new System.Drawing.Size(244, 20);
            this.lastModificationDatTB.TabIndex = 1;
            this.lastModificationDatTB.TabStop = false;
            // 
            // lastModifierTB
            // 
            this.lastModifierTB.Location = new System.Drawing.Point(6, 33);
            this.lastModifierTB.Name = "lastModifierTB";
            this.lastModifierTB.ReadOnly = true;
            this.lastModifierTB.Size = new System.Drawing.Size(244, 20);
            this.lastModifierTB.TabIndex = 0;
            this.lastModifierTB.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(177, 57);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "تاريخ آخر تعديل";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(104, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(149, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "المستخدم الذي قام بآخر تعديل\r\n";
            // 
            // filesGB
            // 
            this.filesGB.Controls.Add(this.importFileB);
            this.filesGB.Controls.Add(this.ShowPageB);
            this.filesGB.Controls.Add(this.DeletePageB);
            this.filesGB.Controls.Add(this.RenameB);
            this.filesGB.Controls.Add(this.PagesLV);
            this.filesGB.Location = new System.Drawing.Point(26, 457);
            this.filesGB.Name = "filesGB";
            this.filesGB.Size = new System.Drawing.Size(802, 142);
            this.filesGB.TabIndex = 8;
            this.filesGB.TabStop = false;
            this.filesGB.Text = "الملفات المرتبطة بالمستند";
            // 
            // categoriesControl
            // 
            this.categoriesControl.FilterType = Library.Common.Search.Filter.FilterEnum.DOC_REGISTRATION_NUMBER;
            this.categoriesControl.Location = new System.Drawing.Point(12, 42);
            this.categoriesControl.Name = "categoriesControl";
            this.categoriesControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.categoriesControl.Size = new System.Drawing.Size(242, 114);
            this.categoriesControl.TabIndex = 0;
            // 
            // categoriesGB
            // 
            this.categoriesGB.Controls.Add(this.categoriesControl);
            this.categoriesGB.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.categoriesGB.Location = new System.Drawing.Point(562, 53);
            this.categoriesGB.Name = "categoriesGB";
            this.categoriesGB.Size = new System.Drawing.Size(266, 191);
            this.categoriesGB.TabIndex = 5;
            this.categoriesGB.TabStop = false;
            this.categoriesGB.Text = "تصنيفات المستند";
            // 
            // loaderBGW
            // 
            this.loaderBGW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.loaderBGW_DoWork);
            this.loaderBGW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.loaderBGW_RunWorkerCompleted);
            // 
            // encryptorBGW
            // 
            this.encryptorBGW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.encryptorBGW_DoWork);
            this.encryptorBGW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.encryptorBGW_RunWorkerCompleted);
            // 
            // decryptorBGW
            // 
            this.decryptorBGW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.decryptorBGW_DoWork);
            this.decryptorBGW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.decryptorBGW_RunWorkerCompleted);
            // 
            // saverBGW
            // 
            this.saverBGW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.saverBGW_DoWork);
            this.saverBGW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.saverBGW_RunWorkerCompleted);
            // 
            // ArchivingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 683);
            this.Controls.Add(this.categoriesGB);
            this.Controls.Add(this.filesGB);
            this.Controls.Add(this.destinationGB);
            this.Controls.Add(this.registrationGB);
            this.Controls.Add(this.inGB);
            this.Controls.Add(this.lastModificationGB);
            this.Controls.Add(this.SaveB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FolderGB);
            this.Controls.Add(this.documentInfo);
            this.Name = "ArchivingForm";
            this.Text = "ArchivingForm";
            this.Load += new System.EventHandler(this.ArchivingForm_Load);
            this.Controls.SetChildIndex(this.exitB, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.documentInfo, 0);
            this.Controls.SetChildIndex(this.FolderGB, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.SaveB, 0);
            this.Controls.SetChildIndex(this.lastModificationGB, 0);
            this.Controls.SetChildIndex(this.inGB, 0);
            this.Controls.SetChildIndex(this.registrationGB, 0);
            this.Controls.SetChildIndex(this.destinationGB, 0);
            this.Controls.SetChildIndex(this.filesGB, 0);
            this.Controls.SetChildIndex(this.categoriesGB, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IDRegNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDInNud)).EndInit();
            this.documentInfo.ResumeLayout(false);
            this.documentInfo.PerformLayout();
            this.FolderGB.ResumeLayout(false);
            this.FolderGB.PerformLayout();
            this.inGB.ResumeLayout(false);
            this.inGB.PerformLayout();
            this.registrationGB.ResumeLayout(false);
            this.registrationGB.PerformLayout();
            this.destinationGB.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.lastModificationGB.ResumeLayout(false);
            this.lastModificationGB.PerformLayout();
            this.filesGB.ResumeLayout(false);
            this.categoriesGB.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DocTitleTB;
        private System.Windows.Forms.ComboBox DestinationCB;
        private System.Windows.Forms.ComboBox PartyCB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox FolderCB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown IDRegNUD;
        private System.Windows.Forms.NumericUpDown IDInNud;
        private System.Windows.Forms.DateTimePicker RegDT;
        private System.Windows.Forms.DateTimePicker InDT;
        private System.Windows.Forms.ListView PagesLV;
        private System.Windows.Forms.TextBox ProcessTB;
        private System.Windows.Forms.Label label10;
        protected System.Windows.Forms.Button SaveB;
        protected System.Windows.Forms.Button DeletePageB;
        protected System.Windows.Forms.Button importFileB;
        protected System.Windows.Forms.Button ShowPageB;
        protected System.Windows.Forms.Button RenameB;
        private System.Windows.Forms.GroupBox documentInfo;
        private System.Windows.Forms.TextBox DocSubjectTB;
        private System.Windows.Forms.GroupBox FolderGB;
        private System.Windows.Forms.GroupBox inGB;
        private System.Windows.Forms.GroupBox registrationGB;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox destinationGB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox creationDateTB;
        private System.Windows.Forms.TextBox creatorTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox lastModificationGB;
        private System.Windows.Forms.TextBox lastModificationDatTB;
        private System.Windows.Forms.TextBox lastModifierTB;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private UserControls.CategoriesControl categoriesControl;
        private System.Windows.Forms.GroupBox categoriesGB;
        private System.ComponentModel.BackgroundWorker loaderBGW;
        private System.ComponentModel.BackgroundWorker encryptorBGW;
        private System.Windows.Forms.ImageList imageList1;
        private System.ComponentModel.BackgroundWorker decryptorBGW;
        private System.ComponentModel.BackgroundWorker saverBGW;
        protected System.Windows.Forms.GroupBox filesGB;
    }
}
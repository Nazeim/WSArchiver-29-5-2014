namespace WSArchiver.GUI.Archive
{
    partial class AdvancedSearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdvancedSearchForm));
            this.singlelineStringCheckedGroup1 = new WSArchiver.GUI.UserControls.SinglelineStringCheckedGroup();
            this.singlelineStringCheckedGroup2 = new WSArchiver.GUI.UserControls.SinglelineStringCheckedGroup();
            this.partyIdCG = new WSArchiver.GUI.UserControls.ComboBoxCheckedGroup();
            this.FolderCG = new WSArchiver.GUI.UserControls.ComboBoxCheckedGroup();
            this.destinationCG = new WSArchiver.GUI.UserControls.ComboBoxCheckedGroup();
            this.creatorIdCG = new WSArchiver.GUI.UserControls.ComboBoxCheckedGroup();
            this.lastModifierIdCG = new WSArchiver.GUI.UserControls.ComboBoxCheckedGroup();
            this.numericUpDownCheckedGroup1 = new WSArchiver.GUI.UserControls.NumericUpDownCheckedGroup();
            this.numericUpDownCheckedGroup2 = new WSArchiver.GUI.UserControls.NumericUpDownCheckedGroup();
            this.numericUpDownCheckedGroup3 = new WSArchiver.GUI.UserControls.NumericUpDownCheckedGroup();
            this.numericUpDownCheckedGroup4 = new WSArchiver.GUI.UserControls.NumericUpDownCheckedGroup();
            this.dateRangeCheckedGroup1 = new WSArchiver.GUI.UserControls.DateRangeCheckedGroup();
            this.dateRangeCheckedGroup2 = new WSArchiver.GUI.UserControls.DateRangeCheckedGroup();
            this.dateRangeCheckedGroup3 = new WSArchiver.GUI.UserControls.DateRangeCheckedGroup();
            this.dateRangeCheckedGroup4 = new WSArchiver.GUI.UserControls.DateRangeCheckedGroup();
            this.dateRangeCheckedGroup6 = new WSArchiver.GUI.UserControls.DateRangeCheckedGroup();
            this.categoriesCG = new WSArchiver.GUI.UserControls.MultipleItemsCheckedGroup();
            this.multilineStringCheckedGroup1 = new WSArchiver.GUI.UserControls.MultilineStringCheckedGroup();
            this.multilineStringCheckedGroup2 = new WSArchiver.GUI.UserControls.MultilineStringCheckedGroup();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchGB.SuspendLayout();
            this.searchResultsGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchForExactMatchResultsButton
            // 
            this.SearchForExactMatchResultsButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchForExactMatchResultsButton.Location = new System.Drawing.Point(90, 305);
            this.SearchForExactMatchResultsButton.Size = new System.Drawing.Size(138, 39);
            this.SearchForExactMatchResultsButton.TabIndex = 20;
            this.toolTip1.SetToolTip(this.SearchForExactMatchResultsButton, "خيارات البحث النصية مثل اسم المستند أو موضوع المستند تتم مطابقتها \r\nمطابقة حرفية " +
        "للوصول إلى عدد نتائج أقل");
            this.SearchForExactMatchResultsButton.Click += new System.EventHandler(this.SearchForExactMatchResultsButton_Click);
            // 
            // SearchForSimilarResultsButton
            // 
            this.SearchForSimilarResultsButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchForSimilarResultsButton.Location = new System.Drawing.Point(260, 305);
            this.SearchForSimilarResultsButton.Size = new System.Drawing.Size(138, 39);
            this.toolTip1.SetToolTip(this.SearchForSimilarResultsButton, "خيارات البحث النصية مثل اسم المستند أو موضوع المستند تتم مطابقتها\r\n مطابقة غير حر" +
        "فية بحيث يتم التسامح مع أخطاء الإدخال أو مع الحالات\r\n التي لا يعرف فيها المستخدم" +
        " كامل العبارة");
            this.SearchForSimilarResultsButton.Click += new System.EventHandler(this.SearchForSimilarResultsButton_Click);
            // 
            // searchGB
            // 
            this.searchGB.Controls.Add(this.pictureBox1);
            this.searchGB.Controls.Add(this.multilineStringCheckedGroup2);
            this.searchGB.Controls.Add(this.multilineStringCheckedGroup1);
            this.searchGB.Controls.Add(this.categoriesCG);
            this.searchGB.Controls.Add(this.numericUpDownCheckedGroup2);
            this.searchGB.Controls.Add(this.singlelineStringCheckedGroup1);
            this.searchGB.Controls.Add(this.singlelineStringCheckedGroup2);
            this.searchGB.Controls.Add(this.partyIdCG);
            this.searchGB.Controls.Add(this.FolderCG);
            this.searchGB.Controls.Add(this.numericUpDownCheckedGroup4);
            this.searchGB.Controls.Add(this.destinationCG);
            this.searchGB.Controls.Add(this.numericUpDownCheckedGroup1);
            this.searchGB.Controls.Add(this.dateRangeCheckedGroup4);
            this.searchGB.Controls.Add(this.dateRangeCheckedGroup2);
            this.searchGB.Controls.Add(this.dateRangeCheckedGroup6);
            this.searchGB.Controls.Add(this.dateRangeCheckedGroup3);
            this.searchGB.Controls.Add(this.dateRangeCheckedGroup1);
            this.searchGB.Controls.Add(this.creatorIdCG);
            this.searchGB.Controls.Add(this.numericUpDownCheckedGroup3);
            this.searchGB.Controls.Add(this.lastModifierIdCG);
            this.searchGB.Location = new System.Drawing.Point(12, 6);
            this.searchGB.Size = new System.Drawing.Size(1126, 358);
            this.searchGB.TabIndex = 0;
            this.searchGB.Tag = true;
            this.searchGB.Controls.SetChildIndex(this.lastModifierIdCG, 0);
            this.searchGB.Controls.SetChildIndex(this.numericUpDownCheckedGroup3, 0);
            this.searchGB.Controls.SetChildIndex(this.creatorIdCG, 0);
            this.searchGB.Controls.SetChildIndex(this.dateRangeCheckedGroup1, 0);
            this.searchGB.Controls.SetChildIndex(this.dateRangeCheckedGroup3, 0);
            this.searchGB.Controls.SetChildIndex(this.dateRangeCheckedGroup6, 0);
            this.searchGB.Controls.SetChildIndex(this.dateRangeCheckedGroup2, 0);
            this.searchGB.Controls.SetChildIndex(this.dateRangeCheckedGroup4, 0);
            this.searchGB.Controls.SetChildIndex(this.numericUpDownCheckedGroup1, 0);
            this.searchGB.Controls.SetChildIndex(this.destinationCG, 0);
            this.searchGB.Controls.SetChildIndex(this.numericUpDownCheckedGroup4, 0);
            this.searchGB.Controls.SetChildIndex(this.FolderCG, 0);
            this.searchGB.Controls.SetChildIndex(this.partyIdCG, 0);
            this.searchGB.Controls.SetChildIndex(this.SearchForSimilarResultsButton, 0);
            this.searchGB.Controls.SetChildIndex(this.SearchForExactMatchResultsButton, 0);
            this.searchGB.Controls.SetChildIndex(this.singlelineStringCheckedGroup2, 0);
            this.searchGB.Controls.SetChildIndex(this.singlelineStringCheckedGroup1, 0);
            this.searchGB.Controls.SetChildIndex(this.numericUpDownCheckedGroup2, 0);
            this.searchGB.Controls.SetChildIndex(this.categoriesCG, 0);
            this.searchGB.Controls.SetChildIndex(this.multilineStringCheckedGroup1, 0);
            this.searchGB.Controls.SetChildIndex(this.multilineStringCheckedGroup2, 0);
            this.searchGB.Controls.SetChildIndex(this.pictureBox1, 0);
            // 
            // searchResultsGB
            // 
            this.searchResultsGB.Location = new System.Drawing.Point(10, 370);
            this.searchResultsGB.TabIndex = 1;
            this.searchResultsGB.Tag = true;
            // 
            // loaderBGW
            // 
            this.loaderBGW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.loaderBGW_RunWorkerCompleted);
            // 
            // showSelectedFileB
            // 
            this.showSelectedFileB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("showSelectedFileB.BackgroundImage")));
            this.showSelectedFileB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.showSelectedFileB.Location = new System.Drawing.Point(193, 210);
            this.showSelectedFileB.Size = new System.Drawing.Size(76, 33);
            this.showSelectedFileB.TabIndex = 0;
            this.showSelectedFileB.Text = "";
            // 
            // removeSelectedFile
            // 
            this.removeSelectedFile.BackgroundImage = global::WSArchiver.Properties.Resources.delete_64;
            this.removeSelectedFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.removeSelectedFile.Location = new System.Drawing.Point(111, 210);
            this.removeSelectedFile.Size = new System.Drawing.Size(76, 33);
            this.removeSelectedFile.TabIndex = 1;
            this.removeSelectedFile.Text = "";
            // 
            // editSelectedDocumentB
            // 
            this.editSelectedDocumentB.BackgroundImage = global::WSArchiver.Properties.Resources.Edit2;
            this.editSelectedDocumentB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.editSelectedDocumentB.Location = new System.Drawing.Point(1046, 210);
            this.editSelectedDocumentB.Size = new System.Drawing.Size(76, 33);
            this.editSelectedDocumentB.TabIndex = 0;
            this.editSelectedDocumentB.Text = "";
            // 
            // deleteSelectedDocumentB
            // 
            this.deleteSelectedDocumentB.BackgroundImage = global::WSArchiver.Properties.Resources.delete_64;
            this.deleteSelectedDocumentB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deleteSelectedDocumentB.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.deleteSelectedDocumentB.Location = new System.Drawing.Point(964, 210);
            this.deleteSelectedDocumentB.Size = new System.Drawing.Size(76, 33);
            this.deleteSelectedDocumentB.TabIndex = 1;
            this.deleteSelectedDocumentB.Text = "";
            // 
            // exitB
            // 
            this.exitB.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitB.Location = new System.Drawing.Point(1017, 632);
            this.exitB.TabIndex = 2;
            this.exitB.Tag = true;
            // 
            // singlelineStringCheckedGroup1
            // 
            this.singlelineStringCheckedGroup1.GroupText = "اسم المستند";
            this.singlelineStringCheckedGroup1.Location = new System.Drawing.Point(810, 14);
            this.singlelineStringCheckedGroup1.Name = "singlelineStringCheckedGroup1";
            this.singlelineStringCheckedGroup1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.singlelineStringCheckedGroup1.Size = new System.Drawing.Size(310, 42);
            this.singlelineStringCheckedGroup1.TabIndex = 0;
            this.singlelineStringCheckedGroup1.Load += new System.EventHandler(this.singlelineStringCheckedGroup1_Load);
            // 
            // singlelineStringCheckedGroup2
            // 
            this.singlelineStringCheckedGroup2.GroupText = "اسم الصفحة/الملف";
            this.singlelineStringCheckedGroup2.Location = new System.Drawing.Point(810, 62);
            this.singlelineStringCheckedGroup2.Name = "singlelineStringCheckedGroup2";
            this.singlelineStringCheckedGroup2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.singlelineStringCheckedGroup2.Size = new System.Drawing.Size(310, 42);
            this.singlelineStringCheckedGroup2.TabIndex = 1;
            this.singlelineStringCheckedGroup2.Load += new System.EventHandler(this.singlelineStringCheckedGroup2_Load);
            // 
            // partyIdCG
            // 
            this.partyIdCG.GroupText = "اسم الجهة";
            this.partyIdCG.Location = new System.Drawing.Point(809, 110);
            this.partyIdCG.Name = "partyIdCG";
            this.partyIdCG.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.partyIdCG.Size = new System.Drawing.Size(311, 42);
            this.partyIdCG.TabIndex = 2;
            this.partyIdCG.Load += new System.EventHandler(this.comboBoxCheckedGroup1_Load);
            // 
            // FolderCG
            // 
            this.FolderCG.GroupText = "اسم الملف العام";
            this.FolderCG.Location = new System.Drawing.Point(809, 158);
            this.FolderCG.Name = "FolderCG";
            this.FolderCG.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FolderCG.Size = new System.Drawing.Size(311, 42);
            this.FolderCG.TabIndex = 3;
            this.FolderCG.Load += new System.EventHandler(this.comboBoxCheckedGroup2_Load);
            // 
            // destinationCG
            // 
            this.destinationCG.GroupText = "موجه إلى";
            this.destinationCG.Location = new System.Drawing.Point(809, 206);
            this.destinationCG.Name = "destinationCG";
            this.destinationCG.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.destinationCG.Size = new System.Drawing.Size(311, 42);
            this.destinationCG.TabIndex = 4;
            this.destinationCG.Load += new System.EventHandler(this.comboBoxCheckedGroup3_Load);
            // 
            // creatorIdCG
            // 
            this.creatorIdCG.GroupText = "المستخدم الذي أدخل المستند أول مرة";
            this.creatorIdCG.Location = new System.Drawing.Point(809, 254);
            this.creatorIdCG.Name = "creatorIdCG";
            this.creatorIdCG.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.creatorIdCG.Size = new System.Drawing.Size(311, 42);
            this.creatorIdCG.TabIndex = 5;
            this.creatorIdCG.Load += new System.EventHandler(this.comboBoxCheckedGroup4_Load);
            // 
            // lastModifierIdCG
            // 
            this.lastModifierIdCG.GroupText = "المستخدم الذي عدل المستند آخر مرة";
            this.lastModifierIdCG.Location = new System.Drawing.Point(809, 302);
            this.lastModifierIdCG.Name = "lastModifierIdCG";
            this.lastModifierIdCG.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lastModifierIdCG.Size = new System.Drawing.Size(311, 42);
            this.lastModifierIdCG.TabIndex = 6;
            this.lastModifierIdCG.Load += new System.EventHandler(this.comboBoxCheckedGroup5_Load);
            // 
            // numericUpDownCheckedGroup1
            // 
            this.numericUpDownCheckedGroup1.GroupText = "رقم التسجيل";
            this.numericUpDownCheckedGroup1.Location = new System.Drawing.Point(487, 129);
            this.numericUpDownCheckedGroup1.Name = "numericUpDownCheckedGroup1";
            this.numericUpDownCheckedGroup1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numericUpDownCheckedGroup1.Size = new System.Drawing.Size(150, 43);
            this.numericUpDownCheckedGroup1.TabIndex = 10;
            this.numericUpDownCheckedGroup1.Load += new System.EventHandler(this.numericUpDownCheckedGroup1_Load);
            // 
            // numericUpDownCheckedGroup2
            // 
            this.numericUpDownCheckedGroup2.GroupText = "رقم الجهة";
            this.numericUpDownCheckedGroup2.Location = new System.Drawing.Point(648, 129);
            this.numericUpDownCheckedGroup2.Name = "numericUpDownCheckedGroup2";
            this.numericUpDownCheckedGroup2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numericUpDownCheckedGroup2.Size = new System.Drawing.Size(150, 43);
            this.numericUpDownCheckedGroup2.TabIndex = 9;
            this.numericUpDownCheckedGroup2.Load += new System.EventHandler(this.numericUpDownCheckedGroup2_Load);
            // 
            // numericUpDownCheckedGroup3
            // 
            this.numericUpDownCheckedGroup3.GroupText = "رقم الملف العام";
            this.numericUpDownCheckedGroup3.Location = new System.Drawing.Point(648, 181);
            this.numericUpDownCheckedGroup3.Name = "numericUpDownCheckedGroup3";
            this.numericUpDownCheckedGroup3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numericUpDownCheckedGroup3.Size = new System.Drawing.Size(150, 43);
            this.numericUpDownCheckedGroup3.TabIndex = 11;
            this.numericUpDownCheckedGroup3.Load += new System.EventHandler(this.numericUpDownCheckedGroup3_Load);
            // 
            // numericUpDownCheckedGroup4
            // 
            this.numericUpDownCheckedGroup4.GroupText = "رقم الوارد";
            this.numericUpDownCheckedGroup4.Location = new System.Drawing.Point(487, 181);
            this.numericUpDownCheckedGroup4.Name = "numericUpDownCheckedGroup4";
            this.numericUpDownCheckedGroup4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numericUpDownCheckedGroup4.Size = new System.Drawing.Size(150, 43);
            this.numericUpDownCheckedGroup4.TabIndex = 12;
            this.numericUpDownCheckedGroup4.Load += new System.EventHandler(this.numericUpDownCheckedGroup4_Load);
            // 
            // dateRangeCheckedGroup1
            // 
            this.dateRangeCheckedGroup1.GroupText = "تاريخ الأرشفة";
            this.dateRangeCheckedGroup1.Location = new System.Drawing.Point(487, 14);
            this.dateRangeCheckedGroup1.Name = "dateRangeCheckedGroup1";
            this.dateRangeCheckedGroup1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateRangeCheckedGroup1.Size = new System.Drawing.Size(311, 51);
            this.dateRangeCheckedGroup1.TabIndex = 7;
            this.dateRangeCheckedGroup1.Load += new System.EventHandler(this.dateRangeCheckedGroup1_Load);
            // 
            // dateRangeCheckedGroup2
            // 
            this.dateRangeCheckedGroup2.GroupText = "تاريخ إدخال الملفات";
            this.dateRangeCheckedGroup2.Location = new System.Drawing.Point(487, 70);
            this.dateRangeCheckedGroup2.Name = "dateRangeCheckedGroup2";
            this.dateRangeCheckedGroup2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateRangeCheckedGroup2.Size = new System.Drawing.Size(311, 51);
            this.dateRangeCheckedGroup2.TabIndex = 8;
            this.dateRangeCheckedGroup2.Load += new System.EventHandler(this.dateRangeCheckedGroup2_Load);
            // 
            // dateRangeCheckedGroup3
            // 
            this.dateRangeCheckedGroup3.GroupText = "تاريخ التسجيل";
            this.dateRangeCheckedGroup3.Location = new System.Drawing.Point(487, 232);
            this.dateRangeCheckedGroup3.Name = "dateRangeCheckedGroup3";
            this.dateRangeCheckedGroup3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateRangeCheckedGroup3.Size = new System.Drawing.Size(311, 51);
            this.dateRangeCheckedGroup3.TabIndex = 13;
            this.dateRangeCheckedGroup3.Load += new System.EventHandler(this.dateRangeCheckedGroup3_Load);
            // 
            // dateRangeCheckedGroup4
            // 
            this.dateRangeCheckedGroup4.GroupText = "تاريخ الوارد";
            this.dateRangeCheckedGroup4.Location = new System.Drawing.Point(487, 293);
            this.dateRangeCheckedGroup4.Name = "dateRangeCheckedGroup4";
            this.dateRangeCheckedGroup4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateRangeCheckedGroup4.Size = new System.Drawing.Size(311, 51);
            this.dateRangeCheckedGroup4.TabIndex = 14;
            this.dateRangeCheckedGroup4.Load += new System.EventHandler(this.dateRangeCheckedGroup4_Load);
            // 
            // dateRangeCheckedGroup6
            // 
            this.dateRangeCheckedGroup6.GroupText = "تاريخ آخر تعديل";
            this.dateRangeCheckedGroup6.Location = new System.Drawing.Point(170, 129);
            this.dateRangeCheckedGroup6.Name = "dateRangeCheckedGroup6";
            this.dateRangeCheckedGroup6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateRangeCheckedGroup6.Size = new System.Drawing.Size(311, 51);
            this.dateRangeCheckedGroup6.TabIndex = 16;
            this.dateRangeCheckedGroup6.Load += new System.EventHandler(this.dateRangeCheckedGroup6_Load);
            // 
            // categoriesCG
            // 
            this.categoriesCG.GroupText = "تصنيفات المستند";
            this.categoriesCG.Location = new System.Drawing.Point(92, 11);
            this.categoriesCG.Name = "categoriesCG";
            this.categoriesCG.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.categoriesCG.Size = new System.Drawing.Size(389, 110);
            this.categoriesCG.TabIndex = 15;
            this.categoriesCG.Load += new System.EventHandler(this.multipleItemsCheckedGroup1_Load);
            // 
            // multilineStringCheckedGroup1
            // 
            this.multilineStringCheckedGroup1.GroupText = "الإجراء";
            this.multilineStringCheckedGroup1.Location = new System.Drawing.Point(170, 180);
            this.multilineStringCheckedGroup1.Name = "multilineStringCheckedGroup1";
            this.multilineStringCheckedGroup1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.multilineStringCheckedGroup1.Size = new System.Drawing.Size(311, 103);
            this.multilineStringCheckedGroup1.TabIndex = 17;
            this.multilineStringCheckedGroup1.Load += new System.EventHandler(this.multilineStringCheckedGroup1_Load);
            // 
            // multilineStringCheckedGroup2
            // 
            this.multilineStringCheckedGroup2.GroupText = "موضوع المستند";
            this.multilineStringCheckedGroup2.Location = new System.Drawing.Point(6, 129);
            this.multilineStringCheckedGroup2.Name = "multilineStringCheckedGroup2";
            this.multilineStringCheckedGroup2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.multilineStringCheckedGroup2.Size = new System.Drawing.Size(158, 154);
            this.multilineStringCheckedGroup2.TabIndex = 18;
            this.multilineStringCheckedGroup2.Load += new System.EventHandler(this.multilineStringCheckedGroup2_Load);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WSArchiver.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // AdvancedSearchForm
            // 
            this.AcceptButton = this.SearchForExactMatchResultsButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.CancelButton = this.exitB;
            this.ClientSize = new System.Drawing.Size(1150, 685);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdvancedSearchForm";
            this.searchGB.ResumeLayout(false);
            this.searchResultsGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.SinglelineStringCheckedGroup singlelineStringCheckedGroup1;
        private UserControls.SinglelineStringCheckedGroup singlelineStringCheckedGroup2;
        private UserControls.ComboBoxCheckedGroup partyIdCG;
        private UserControls.ComboBoxCheckedGroup FolderCG;
        private UserControls.ComboBoxCheckedGroup destinationCG;
        private UserControls.ComboBoxCheckedGroup creatorIdCG;
        private UserControls.NumericUpDownCheckedGroup numericUpDownCheckedGroup1;
        private UserControls.ComboBoxCheckedGroup lastModifierIdCG;
        private UserControls.NumericUpDownCheckedGroup numericUpDownCheckedGroup2;
        private UserControls.NumericUpDownCheckedGroup numericUpDownCheckedGroup4;
        private UserControls.NumericUpDownCheckedGroup numericUpDownCheckedGroup3;
        private UserControls.MultipleItemsCheckedGroup categoriesCG;
        private UserControls.DateRangeCheckedGroup dateRangeCheckedGroup4;
        private UserControls.DateRangeCheckedGroup dateRangeCheckedGroup2;
        private UserControls.DateRangeCheckedGroup dateRangeCheckedGroup6;
        private UserControls.DateRangeCheckedGroup dateRangeCheckedGroup3;
        private UserControls.DateRangeCheckedGroup dateRangeCheckedGroup1;
        private UserControls.MultilineStringCheckedGroup multilineStringCheckedGroup2;
        private UserControls.MultilineStringCheckedGroup multilineStringCheckedGroup1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}

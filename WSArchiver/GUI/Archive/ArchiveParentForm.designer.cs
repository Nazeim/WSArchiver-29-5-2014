namespace WSArchiver.GUI.Archive
{
    partial class ArchiveParentForm
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
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.SearchForExactMatchResultsButton = new System.Windows.Forms.Button();
            this.SearchForSimilarResultsButton = new System.Windows.Forms.Button();
            this.DocumentsdataGridView = new System.Windows.Forms.DataGridView();
            this.creationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FolderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastEditDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastEditorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastEditorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creatorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FolderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FilesdataGridView2 = new System.Windows.Forms.DataGridView();
            this.additionDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchGB = new System.Windows.Forms.GroupBox();
            this.searchResultsGB = new System.Windows.Forms.GroupBox();
            this.showSelectedFileB = new System.Windows.Forms.Button();
            this.removeSelectedFile = new System.Windows.Forms.Button();
            this.editSelectedDocumentB = new System.Windows.Forms.Button();
            this.deleteSelectedDocumentB = new System.Windows.Forms.Button();
            this.loaderBGW = new System.ComponentModel.BackgroundWorker();
            this.searcherBGW = new System.ComponentModel.BackgroundWorker();
            this.decryptorBGW = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentsdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilesdataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filesBindingSource)).BeginInit();
            this.searchGB.SuspendLayout();
            this.searchResultsGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitB
            // 
            this.exitB.Location = new System.Drawing.Point(995, 484);
            this.exitB.Size = new System.Drawing.Size(121, 24);
            this.exitB.TabIndex = 28;
            this.exitB.Click += new System.EventHandler(this.exitB_Click);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // SearchForExactMatchResultsButton
            // 
            this.SearchForExactMatchResultsButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SearchForExactMatchResultsButton.Location = new System.Drawing.Point(373, 157);
            this.SearchForExactMatchResultsButton.Name = "SearchForExactMatchResultsButton";
            this.SearchForExactMatchResultsButton.Size = new System.Drawing.Size(138, 23);
            this.SearchForExactMatchResultsButton.TabIndex = 18;
            this.SearchForExactMatchResultsButton.Text = "بحث عن نتائج مطابقة";
            this.SearchForExactMatchResultsButton.UseVisualStyleBackColor = true;
            // 
            // SearchForSimilarResultsButton
            // 
            this.SearchForSimilarResultsButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SearchForSimilarResultsButton.Location = new System.Drawing.Point(519, 157);
            this.SearchForSimilarResultsButton.Name = "SearchForSimilarResultsButton";
            this.SearchForSimilarResultsButton.Size = new System.Drawing.Size(138, 23);
            this.SearchForSimilarResultsButton.TabIndex = 19;
            this.SearchForSimilarResultsButton.Text = "بحث عن نتائج مشابهة";
            this.SearchForSimilarResultsButton.UseVisualStyleBackColor = true;
            this.SearchForSimilarResultsButton.Click += new System.EventHandler(this.SearchForSimilarResultsButton_Click);
            // 
            // DocumentsdataGridView
            // 
            this.DocumentsdataGridView.AllowUserToAddRows = false;
            this.DocumentsdataGridView.AllowUserToDeleteRows = false;
            this.DocumentsdataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DocumentsdataGridView.AutoGenerateColumns = false;
            this.DocumentsdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DocumentsdataGridView.BackgroundColor = System.Drawing.Color.White;
            this.DocumentsdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DocumentsdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.creationDateDataGridViewTextBoxColumn,
            this.OutNumberDataGridViewTextBoxColumn,
            this.inNumberDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.destinationDataGridViewTextBoxColumn,
            this.processDataGridViewTextBoxColumn,
            this.subjectDataGridViewTextBoxColumn,
            this.FolderDataGridViewTextBoxColumn,
            this.lastEditDateTimeDataGridViewTextBoxColumn,
            this.lastEditorDataGridViewTextBoxColumn,
            this.creatorDataGridViewTextBoxColumn,
            this.OutDateTimeDataGridViewTextBoxColumn,
            this.inDateTimeDataGridViewTextBoxColumn,
            this.destinationIdDataGridViewTextBoxColumn,
            this.lastEditorIdDataGridViewTextBoxColumn,
            this.creatorIdDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn1,
            this.FolderIdDataGridViewTextBoxColumn});
            this.DocumentsdataGridView.DataSource = this.documentsBindingSource;
            this.DocumentsdataGridView.Location = new System.Drawing.Point(275, 19);
            this.DocumentsdataGridView.Name = "DocumentsdataGridView";
            this.DocumentsdataGridView.ReadOnly = true;
            this.DocumentsdataGridView.RowHeadersVisible = false;
            this.DocumentsdataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DocumentsdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DocumentsdataGridView.Size = new System.Drawing.Size(847, 190);
            this.DocumentsdataGridView.StandardTab = true;
            this.DocumentsdataGridView.TabIndex = 58;
            this.DocumentsdataGridView.TabStop = false;
            // 
            // creationDateDataGridViewTextBoxColumn
            // 
            this.creationDateDataGridViewTextBoxColumn.DataPropertyName = "CreationDate";
            this.creationDateDataGridViewTextBoxColumn.HeaderText = "تاريخ الأرشفة";
            this.creationDateDataGridViewTextBoxColumn.Name = "creationDateDataGridViewTextBoxColumn";
            this.creationDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // OutNumberDataGridViewTextBoxColumn
            // 
            this.OutNumberDataGridViewTextBoxColumn.DataPropertyName = "OutNumber";
            this.OutNumberDataGridViewTextBoxColumn.HeaderText = "رقم التسجيل";
            this.OutNumberDataGridViewTextBoxColumn.Name = "OutNumberDataGridViewTextBoxColumn";
            this.OutNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inNumberDataGridViewTextBoxColumn
            // 
            this.inNumberDataGridViewTextBoxColumn.DataPropertyName = "InNumber";
            this.inNumberDataGridViewTextBoxColumn.HeaderText = "رقم الوارد";
            this.inNumberDataGridViewTextBoxColumn.Name = "inNumberDataGridViewTextBoxColumn";
            this.inNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "اسم المستند";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // destinationDataGridViewTextBoxColumn
            // 
            this.destinationDataGridViewTextBoxColumn.DataPropertyName = "Destination";
            this.destinationDataGridViewTextBoxColumn.HeaderText = "موجه إلى";
            this.destinationDataGridViewTextBoxColumn.Name = "destinationDataGridViewTextBoxColumn";
            this.destinationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // processDataGridViewTextBoxColumn
            // 
            this.processDataGridViewTextBoxColumn.DataPropertyName = "Process";
            this.processDataGridViewTextBoxColumn.HeaderText = "الإجراء";
            this.processDataGridViewTextBoxColumn.Name = "processDataGridViewTextBoxColumn";
            this.processDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subjectDataGridViewTextBoxColumn
            // 
            this.subjectDataGridViewTextBoxColumn.DataPropertyName = "Subject";
            this.subjectDataGridViewTextBoxColumn.HeaderText = "Subject";
            this.subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
            this.subjectDataGridViewTextBoxColumn.ReadOnly = true;
            this.subjectDataGridViewTextBoxColumn.Visible = false;
            // 
            // FolderDataGridViewTextBoxColumn
            // 
            this.FolderDataGridViewTextBoxColumn.DataPropertyName = "Folder";
            this.FolderDataGridViewTextBoxColumn.HeaderText = "Folder";
            this.FolderDataGridViewTextBoxColumn.Name = "FolderDataGridViewTextBoxColumn";
            this.FolderDataGridViewTextBoxColumn.ReadOnly = true;
            this.FolderDataGridViewTextBoxColumn.Visible = false;
            // 
            // lastEditDateTimeDataGridViewTextBoxColumn
            // 
            this.lastEditDateTimeDataGridViewTextBoxColumn.DataPropertyName = "LastEditDateTime";
            this.lastEditDateTimeDataGridViewTextBoxColumn.HeaderText = "LastEditDateTime";
            this.lastEditDateTimeDataGridViewTextBoxColumn.Name = "lastEditDateTimeDataGridViewTextBoxColumn";
            this.lastEditDateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastEditDateTimeDataGridViewTextBoxColumn.Visible = false;
            // 
            // lastEditorDataGridViewTextBoxColumn
            // 
            this.lastEditorDataGridViewTextBoxColumn.DataPropertyName = "LastEditor";
            this.lastEditorDataGridViewTextBoxColumn.HeaderText = "LastEditor";
            this.lastEditorDataGridViewTextBoxColumn.Name = "lastEditorDataGridViewTextBoxColumn";
            this.lastEditorDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastEditorDataGridViewTextBoxColumn.Visible = false;
            // 
            // creatorDataGridViewTextBoxColumn
            // 
            this.creatorDataGridViewTextBoxColumn.DataPropertyName = "Creator";
            this.creatorDataGridViewTextBoxColumn.HeaderText = "Creator";
            this.creatorDataGridViewTextBoxColumn.Name = "creatorDataGridViewTextBoxColumn";
            this.creatorDataGridViewTextBoxColumn.ReadOnly = true;
            this.creatorDataGridViewTextBoxColumn.Visible = false;
            // 
            // OutDateTimeDataGridViewTextBoxColumn
            // 
            this.OutDateTimeDataGridViewTextBoxColumn.DataPropertyName = "OutDateTime";
            this.OutDateTimeDataGridViewTextBoxColumn.HeaderText = "OutDateTime";
            this.OutDateTimeDataGridViewTextBoxColumn.Name = "OutDateTimeDataGridViewTextBoxColumn";
            this.OutDateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.OutDateTimeDataGridViewTextBoxColumn.Visible = false;
            // 
            // inDateTimeDataGridViewTextBoxColumn
            // 
            this.inDateTimeDataGridViewTextBoxColumn.DataPropertyName = "InDateTime";
            this.inDateTimeDataGridViewTextBoxColumn.HeaderText = "InDateTime";
            this.inDateTimeDataGridViewTextBoxColumn.Name = "inDateTimeDataGridViewTextBoxColumn";
            this.inDateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.inDateTimeDataGridViewTextBoxColumn.Visible = false;
            // 
            // destinationIdDataGridViewTextBoxColumn
            // 
            this.destinationIdDataGridViewTextBoxColumn.DataPropertyName = "DestinationId";
            this.destinationIdDataGridViewTextBoxColumn.HeaderText = "DestinationId";
            this.destinationIdDataGridViewTextBoxColumn.Name = "destinationIdDataGridViewTextBoxColumn";
            this.destinationIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.destinationIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // lastEditorIdDataGridViewTextBoxColumn
            // 
            this.lastEditorIdDataGridViewTextBoxColumn.DataPropertyName = "LastEditorId";
            this.lastEditorIdDataGridViewTextBoxColumn.HeaderText = "LastEditorId";
            this.lastEditorIdDataGridViewTextBoxColumn.Name = "lastEditorIdDataGridViewTextBoxColumn";
            this.lastEditorIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastEditorIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // creatorIdDataGridViewTextBoxColumn
            // 
            this.creatorIdDataGridViewTextBoxColumn.DataPropertyName = "CreatorId";
            this.creatorIdDataGridViewTextBoxColumn.HeaderText = "CreatorId";
            this.creatorIdDataGridViewTextBoxColumn.Name = "creatorIdDataGridViewTextBoxColumn";
            this.creatorIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.creatorIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // FolderIdDataGridViewTextBoxColumn
            // 
            this.FolderIdDataGridViewTextBoxColumn.DataPropertyName = "FolderId";
            this.FolderIdDataGridViewTextBoxColumn.HeaderText = "FolderId";
            this.FolderIdDataGridViewTextBoxColumn.Name = "FolderIdDataGridViewTextBoxColumn";
            this.FolderIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.FolderIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // documentsBindingSource
            // 
            this.documentsBindingSource.DataSource = typeof(Library.Common.DocumentVO);
            this.documentsBindingSource.CurrentChanged += new System.EventHandler(this.documentsBindingSource_PositionChanged);
            // 
            // FilesdataGridView2
            // 
            this.FilesdataGridView2.AllowUserToAddRows = false;
            this.FilesdataGridView2.AllowUserToDeleteRows = false;
            this.FilesdataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FilesdataGridView2.AutoGenerateColumns = false;
            this.FilesdataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FilesdataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.FilesdataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FilesdataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.additionDateTimeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.documentIdDataGridViewTextBoxColumn});
            this.FilesdataGridView2.DataSource = this.filesBindingSource;
            this.FilesdataGridView2.Location = new System.Drawing.Point(6, 19);
            this.FilesdataGridView2.Name = "FilesdataGridView2";
            this.FilesdataGridView2.ReadOnly = true;
            this.FilesdataGridView2.RowHeadersVisible = false;
            this.FilesdataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FilesdataGridView2.Size = new System.Drawing.Size(263, 190);
            this.FilesdataGridView2.TabIndex = 60;
            this.FilesdataGridView2.TabStop = false;
            // 
            // additionDateTimeDataGridViewTextBoxColumn
            // 
            this.additionDateTimeDataGridViewTextBoxColumn.DataPropertyName = "AdditionDateTime";
            this.additionDateTimeDataGridViewTextBoxColumn.HeaderText = "تاريخ الأرشفة";
            this.additionDateTimeDataGridViewTextBoxColumn.Name = "additionDateTimeDataGridViewTextBoxColumn";
            this.additionDateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "اسم الصفحة/الملف";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // documentIdDataGridViewTextBoxColumn
            // 
            this.documentIdDataGridViewTextBoxColumn.DataPropertyName = "DocumentId";
            this.documentIdDataGridViewTextBoxColumn.HeaderText = "DocumentId";
            this.documentIdDataGridViewTextBoxColumn.Name = "documentIdDataGridViewTextBoxColumn";
            this.documentIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.documentIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // filesBindingSource
            // 
            this.filesBindingSource.DataSource = typeof(Library.Common.FileVO);
            this.filesBindingSource.CurrentChanged += new System.EventHandler(this.filesBindingSource_PositionChanged);
            // 
            // searchGB
            // 
            this.searchGB.BackColor = System.Drawing.SystemColors.Control;
            this.searchGB.Controls.Add(this.SearchForSimilarResultsButton);
            this.searchGB.Controls.Add(this.SearchForExactMatchResultsButton);
            this.searchGB.Location = new System.Drawing.Point(9, 12);
            this.searchGB.Name = "searchGB";
            this.searchGB.Size = new System.Drawing.Size(1128, 204);
            this.searchGB.TabIndex = 61;
            this.searchGB.TabStop = false;
            this.searchGB.Text = "البحث";
            // 
            // searchResultsGB
            // 
            this.searchResultsGB.BackColor = System.Drawing.SystemColors.Control;
            this.searchResultsGB.Controls.Add(this.showSelectedFileB);
            this.searchResultsGB.Controls.Add(this.removeSelectedFile);
            this.searchResultsGB.Controls.Add(this.editSelectedDocumentB);
            this.searchResultsGB.Controls.Add(this.DocumentsdataGridView);
            this.searchResultsGB.Controls.Add(this.deleteSelectedDocumentB);
            this.searchResultsGB.Controls.Add(this.FilesdataGridView2);
            this.searchResultsGB.Location = new System.Drawing.Point(9, 222);
            this.searchResultsGB.Name = "searchResultsGB";
            this.searchResultsGB.Size = new System.Drawing.Size(1128, 256);
            this.searchResultsGB.TabIndex = 62;
            this.searchResultsGB.TabStop = false;
            this.searchResultsGB.Text = "نتائج البحث";
            // 
            // showSelectedFileB
            // 
            this.showSelectedFileB.Enabled = false;
            this.showSelectedFileB.Location = new System.Drawing.Point(148, 215);
            this.showSelectedFileB.Name = "showSelectedFileB";
            this.showSelectedFileB.Size = new System.Drawing.Size(121, 23);
            this.showSelectedFileB.TabIndex = 61;
            this.showSelectedFileB.Text = "عرض الملف المحدد";
            this.showSelectedFileB.UseVisualStyleBackColor = true;
            this.showSelectedFileB.Click += new System.EventHandler(this.showSelectedFileB_Click);
            // 
            // removeSelectedFile
            // 
            this.removeSelectedFile.Enabled = false;
            this.removeSelectedFile.Location = new System.Drawing.Point(21, 215);
            this.removeSelectedFile.Name = "removeSelectedFile";
            this.removeSelectedFile.Size = new System.Drawing.Size(121, 23);
            this.removeSelectedFile.TabIndex = 61;
            this.removeSelectedFile.Text = "حذف الملف المحدد";
            this.removeSelectedFile.UseVisualStyleBackColor = true;
            this.removeSelectedFile.Click += new System.EventHandler(this.removeSelectedFile_Click);
            // 
            // editSelectedDocumentB
            // 
            this.editSelectedDocumentB.Enabled = false;
            this.editSelectedDocumentB.Location = new System.Drawing.Point(1001, 215);
            this.editSelectedDocumentB.Name = "editSelectedDocumentB";
            this.editSelectedDocumentB.Size = new System.Drawing.Size(121, 23);
            this.editSelectedDocumentB.TabIndex = 61;
            this.editSelectedDocumentB.Text = "تعديل الوثيقة المحددة";
            this.editSelectedDocumentB.UseVisualStyleBackColor = true;
            this.editSelectedDocumentB.Click += new System.EventHandler(this.editSelectedDocumentB_Click);
            // 
            // deleteSelectedDocumentB
            // 
            this.deleteSelectedDocumentB.Enabled = false;
            this.deleteSelectedDocumentB.Location = new System.Drawing.Point(874, 215);
            this.deleteSelectedDocumentB.Name = "deleteSelectedDocumentB";
            this.deleteSelectedDocumentB.Size = new System.Drawing.Size(121, 23);
            this.deleteSelectedDocumentB.TabIndex = 61;
            this.deleteSelectedDocumentB.Text = "حذف الوثيقة المحددة";
            this.deleteSelectedDocumentB.UseVisualStyleBackColor = true;
            this.deleteSelectedDocumentB.Click += new System.EventHandler(this.deleteSelectedDocumentB_Click);
            // 
            // loaderBGW
            // 
            this.loaderBGW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.loaderBGW_DoWork);
            // 
            // searcherBGW
            // 
            this.searcherBGW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.searcherBGW_DoWork);
            this.searcherBGW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.searcherBGW_RunWorkerCompleted);
            // 
            // decryptorBGW
            // 
            this.decryptorBGW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.decryptorBGW_DoWork);
            this.decryptorBGW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.decryptorBGW_RunWorkerCompleted);
            // 
            // ArchiveParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 536);
            this.Controls.Add(this.searchResultsGB);
            this.Controls.Add(this.searchGB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ArchiveParentForm";
            this.Text = "الأرشيف";
            this.Load += new System.EventHandler(this.ArchiveParentForm_Load);
            this.Controls.SetChildIndex(this.searchGB, 0);
            this.Controls.SetChildIndex(this.exitB, 0);
            this.Controls.SetChildIndex(this.searchResultsGB, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DocumentsdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilesdataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filesBindingSource)).EndInit();
            this.searchGB.ResumeLayout(false);
            this.searchResultsGB.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button SearchForExactMatchResultsButton;
        protected System.Windows.Forms.Button SearchForSimilarResultsButton;
        private System.Windows.Forms.BindingSource documentsBindingSource;
        private System.Windows.Forms.BindingSource filesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn processDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FolderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastEditDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastEditorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastEditorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creatorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FolderIdDataGridViewTextBoxColumn;
        protected System.Windows.Forms.GroupBox searchGB;
        protected System.Windows.Forms.GroupBox searchResultsGB;
        private System.Windows.Forms.DataGridViewTextBoxColumn additionDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentIdDataGridViewTextBoxColumn;
        protected System.ComponentModel.BackgroundWorker loaderBGW;
        private System.ComponentModel.BackgroundWorker searcherBGW;
        public System.Windows.Forms.Button showSelectedFileB;
        public System.Windows.Forms.Button removeSelectedFile;
        public System.Windows.Forms.Button editSelectedDocumentB;
        public System.Windows.Forms.Button deleteSelectedDocumentB;
        public System.Windows.Forms.DataGridView DocumentsdataGridView;
        public System.Windows.Forms.DataGridView FilesdataGridView2;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.ComponentModel.BackgroundWorker decryptorBGW;
    }
}
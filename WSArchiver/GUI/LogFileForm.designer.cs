namespace WSArchiver.GUI
{
    partial class LogFileForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.SearchB = new System.Windows.Forms.Button();
            this.operationCCB = new WSArchiver.GUI.UserControls.ComboBoxCheckedGroup();
            this.userCCB = new WSArchiver.GUI.UserControls.ComboBoxCheckedGroup();
            this.dateRangeCheckedGroup1 = new WSArchiver.GUI.UserControls.DateRangeCheckedGroup();
            this.label1 = new System.Windows.Forms.Label();
            this.searcherBGW = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // exitB
            // 
            this.exitB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitB.BackgroundImage = global::WSArchiver.Properties.Resources.exit;
            this.exitB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitB.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitB.Location = new System.Drawing.Point(659, 432);
            this.exitB.Size = new System.Drawing.Size(82, 35);
            this.exitB.TabIndex = 5;
            this.exitB.Text = "";
            this.exitB.Click += new System.EventHandler(this.exitB_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateTimeDataGridViewTextBoxColumn,
            this.userDataGridViewTextBoxColumn,
            this.operationDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.operationIdDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView1.Location = new System.Drawing.Point(15, 188);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(726, 238);
            this.dataGridView1.TabIndex = 4;
            // 
            // dateTimeDataGridViewTextBoxColumn
            // 
            this.dateTimeDataGridViewTextBoxColumn.DataPropertyName = "DateTime";
            this.dateTimeDataGridViewTextBoxColumn.FillWeight = 20F;
            this.dateTimeDataGridViewTextBoxColumn.HeaderText = "التاريخ و التوقيت";
            this.dateTimeDataGridViewTextBoxColumn.Name = "dateTimeDataGridViewTextBoxColumn";
            this.dateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userDataGridViewTextBoxColumn
            // 
            this.userDataGridViewTextBoxColumn.DataPropertyName = "User";
            this.userDataGridViewTextBoxColumn.FillWeight = 12F;
            this.userDataGridViewTextBoxColumn.HeaderText = "المستخدم";
            this.userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
            this.userDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // operationDataGridViewTextBoxColumn
            // 
            this.operationDataGridViewTextBoxColumn.DataPropertyName = "Operation";
            this.operationDataGridViewTextBoxColumn.FillWeight = 25F;
            this.operationDataGridViewTextBoxColumn.HeaderText = "العملية";
            this.operationDataGridViewTextBoxColumn.Name = "operationDataGridViewTextBoxColumn";
            this.operationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.FillWeight = 43F;
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "التفاصيل";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // operationIdDataGridViewTextBoxColumn
            // 
            this.operationIdDataGridViewTextBoxColumn.DataPropertyName = "OperationId";
            this.operationIdDataGridViewTextBoxColumn.HeaderText = "OperationId";
            this.operationIdDataGridViewTextBoxColumn.Name = "operationIdDataGridViewTextBoxColumn";
            this.operationIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.operationIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Library.Common.LogEntryVO);
            // 
            // SearchB
            // 
            this.SearchB.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchB.Location = new System.Drawing.Point(397, 86);
            this.SearchB.Name = "SearchB";
            this.SearchB.Size = new System.Drawing.Size(73, 51);
            this.SearchB.TabIndex = 3;
            this.SearchB.Text = "بحث";
            this.SearchB.UseVisualStyleBackColor = true;
            this.SearchB.Click += new System.EventHandler(this.SearchB_Click);
            // 
            // operationCCB
            // 
            this.operationCCB.GroupText = "العملية";
            this.operationCCB.Location = new System.Drawing.Point(192, 115);
            this.operationCCB.Name = "operationCCB";
            this.operationCCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.operationCCB.Size = new System.Drawing.Size(168, 51);
            this.operationCCB.TabIndex = 2;
            // 
            // userCCB
            // 
            this.userCCB.GroupText = "المستخدم";
            this.userCCB.Location = new System.Drawing.Point(15, 115);
            this.userCCB.Name = "userCCB";
            this.userCCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userCCB.Size = new System.Drawing.Size(168, 51);
            this.userCCB.TabIndex = 1;
            // 
            // dateRangeCheckedGroup1
            // 
            this.dateRangeCheckedGroup1.GroupText = "المجال الزمني";
            this.dateRangeCheckedGroup1.Location = new System.Drawing.Point(15, 58);
            this.dateRangeCheckedGroup1.Name = "dateRangeCheckedGroup1";
            this.dateRangeCheckedGroup1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateRangeCheckedGroup1.Size = new System.Drawing.Size(345, 51);
            this.dateRangeCheckedGroup1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "قم باختيار معايير البحث التي تريدها ثم اضغط على زر (بحث).إن عدم اختيار معيار بحث " +
    "يعني\r\n أن جميع القيم الممكنة له ستؤخذ بعين الاعتبار";
            // 
            // searcherBGW
            // 
            this.searcherBGW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.searcherBGW_DoWork);
            this.searcherBGW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.searcherBGW_RunWorkerCompleted);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WSArchiver.Properties.Resources.edit_find;
            this.pictureBox1.Location = new System.Drawing.Point(550, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // LogFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitB;
            this.ClientSize = new System.Drawing.Size(753, 503);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateRangeCheckedGroup1);
            this.Controls.Add(this.userCCB);
            this.Controls.Add(this.operationCCB);
            this.Controls.Add(this.SearchB);
            this.Controls.Add(this.dataGridView1);
            this.Name = "LogFileForm";
            this.Text = "(LogFile)ملف المراقبة  ";
            this.Load += new System.EventHandler(this.LogFileForm_Load);
            this.Controls.SetChildIndex(this.exitB, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.SearchB, 0);
            this.Controls.SetChildIndex(this.operationCCB, 0);
            this.Controls.SetChildIndex(this.userCCB, 0);
            this.Controls.SetChildIndex(this.dateRangeCheckedGroup1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SearchB;
        private System.Windows.Forms.BindingSource bindingSource1;
        private UserControls.ComboBoxCheckedGroup operationCCB;
        private UserControls.ComboBoxCheckedGroup userCCB;
        private UserControls.DateRangeCheckedGroup dateRangeCheckedGroup1;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker searcherBGW;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operationIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
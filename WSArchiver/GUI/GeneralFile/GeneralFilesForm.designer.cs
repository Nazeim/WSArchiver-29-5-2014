namespace WSArchiver.GUI
{
    partial class FoldersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoldersForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FoldersDataGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.InsertFilebutton1 = new System.Windows.Forms.Button();
            this.UpdateFilebutton2 = new System.Windows.Forms.Button();
            this.RemovFilebutton3 = new System.Windows.Forms.Button();
            this.IdPartynumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FoldercomboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.IdFoldersNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.FolderTB = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FoldersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdPartynumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdFoldersNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Size = new System.Drawing.Size(721, 79);
            this.panel1.Controls.SetChildIndex(this.pictureBox1, 0);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            this.panel1.Controls.SetChildIndex(this.label2, 0);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(603, 17);
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.Text = "الملفات العامة";
            // 
            // exitB
            // 
            this.exitB.BackgroundImage = global::WSArchiver.Properties.Resources.exit;
            this.exitB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitB.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitB.Location = new System.Drawing.Point(12, 335);
            this.exitB.Size = new System.Drawing.Size(77, 38);
            this.exitB.TabIndex = 8;
            this.exitB.Text = "";
            this.exitB.Click += new System.EventHandler(this.exitB_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(189, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(526, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "يتم في هذه الشاشة فتح ملفات فرعية عامة لكل جهة أو شركة أو إدارة تم تكوين أرشيفها " +
    "مسبقاً\r\n في شاشة الجهات.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(157, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "الرقم";
            // 
            // FoldersDataGridView
            // 
            this.FoldersDataGridView.AllowUserToAddRows = false;
            this.FoldersDataGridView.AllowUserToDeleteRows = false;
            this.FoldersDataGridView.AutoGenerateColumns = false;
            this.FoldersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FoldersDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.FoldersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FoldersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn});
            this.FoldersDataGridView.DataSource = this.bindingSource1;
            this.FoldersDataGridView.Location = new System.Drawing.Point(95, 169);
            this.FoldersDataGridView.Name = "FoldersDataGridView";
            this.FoldersDataGridView.ReadOnly = true;
            this.FoldersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FoldersDataGridView.Size = new System.Drawing.Size(635, 206);
            this.FoldersDataGridView.TabIndex = 7;
            this.FoldersDataGridView.TabStop = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 40F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "اسم الملف";
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
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Library.Common.FolderVO);
            // 
            // InsertFilebutton1
            // 
            this.InsertFilebutton1.BackgroundImage = global::WSArchiver.Properties.Resources.plus_64;
            this.InsertFilebutton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.InsertFilebutton1.Location = new System.Drawing.Point(12, 173);
            this.InsertFilebutton1.Name = "InsertFilebutton1";
            this.InsertFilebutton1.Size = new System.Drawing.Size(77, 38);
            this.InsertFilebutton1.TabIndex = 4;
            this.InsertFilebutton1.UseVisualStyleBackColor = true;
            this.InsertFilebutton1.Click += new System.EventHandler(this.InsertFilebutton1_Click);
            // 
            // UpdateFilebutton2
            // 
            this.UpdateFilebutton2.BackgroundImage = global::WSArchiver.Properties.Resources.Edit2;
            this.UpdateFilebutton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UpdateFilebutton2.Location = new System.Drawing.Point(12, 227);
            this.UpdateFilebutton2.Name = "UpdateFilebutton2";
            this.UpdateFilebutton2.Size = new System.Drawing.Size(77, 38);
            this.UpdateFilebutton2.TabIndex = 5;
            this.UpdateFilebutton2.UseVisualStyleBackColor = true;
            this.UpdateFilebutton2.Click += new System.EventHandler(this.UpdateFilebutton2_Click);
            // 
            // RemovFilebutton3
            // 
            this.RemovFilebutton3.BackgroundImage = global::WSArchiver.Properties.Resources.delete_64;
            this.RemovFilebutton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RemovFilebutton3.Location = new System.Drawing.Point(12, 281);
            this.RemovFilebutton3.Name = "RemovFilebutton3";
            this.RemovFilebutton3.Size = new System.Drawing.Size(77, 38);
            this.RemovFilebutton3.TabIndex = 6;
            this.RemovFilebutton3.UseVisualStyleBackColor = true;
            this.RemovFilebutton3.Click += new System.EventHandler(this.RemovFilebutton3_Click);
            // 
            // IdPartynumericUpDown
            // 
            this.IdPartynumericUpDown.Location = new System.Drawing.Point(160, 101);
            this.IdPartynumericUpDown.Name = "IdPartynumericUpDown";
            this.IdPartynumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.IdPartynumericUpDown.TabIndex = 0;
            this.IdPartynumericUpDown.ValueChanged += new System.EventHandler(this.IdPartynumericUpDown_ValueChanged);
            // 
            // FoldercomboBox
            // 
            this.FoldercomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FoldercomboBox.FormattingEnabled = true;
            this.FoldercomboBox.Location = new System.Drawing.Point(361, 100);
            this.FoldercomboBox.Name = "FoldercomboBox";
            this.FoldercomboBox.Size = new System.Drawing.Size(155, 21);
            this.FoldercomboBox.TabIndex = 1;
            this.FoldercomboBox.SelectedIndexChanged += new System.EventHandler(this.FoldercomboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(358, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = " الجهة";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(358, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "اسم الملف العام";
            // 
            // IdFoldersNumericUpDown
            // 
            this.IdFoldersNumericUpDown.Location = new System.Drawing.Point(160, 143);
            this.IdFoldersNumericUpDown.Name = "IdFoldersNumericUpDown";
            this.IdFoldersNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.IdFoldersNumericUpDown.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(157, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "الرقم";
            // 
            // FolderTB
            // 
            this.FolderTB.Location = new System.Drawing.Point(361, 142);
            this.FolderTB.Name = "FolderTB";
            this.FolderTB.Size = new System.Drawing.Size(155, 20);
            this.FolderTB.TabIndex = 3;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WSArchiver.Properties.Resources.mydocuments;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FoldersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitB;
            this.ClientSize = new System.Drawing.Size(721, 384);
            this.Controls.Add(this.FolderTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.IdFoldersNumericUpDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FoldersDataGridView);
            this.Controls.Add(this.InsertFilebutton1);
            this.Controls.Add(this.FoldercomboBox);
            this.Controls.Add(this.UpdateFilebutton2);
            this.Controls.Add(this.IdPartynumericUpDown);
            this.Controls.Add(this.RemovFilebutton3);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FoldersForm";
            this.Text = "الملفات العامة";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FoldersForm_FormClosing);
            this.Load += new System.EventHandler(this.FoldersForm_Load);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.exitB, 0);
            this.Controls.SetChildIndex(this.RemovFilebutton3, 0);
            this.Controls.SetChildIndex(this.IdPartynumericUpDown, 0);
            this.Controls.SetChildIndex(this.UpdateFilebutton2, 0);
            this.Controls.SetChildIndex(this.FoldercomboBox, 0);
            this.Controls.SetChildIndex(this.InsertFilebutton1, 0);
            this.Controls.SetChildIndex(this.FoldersDataGridView, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.IdFoldersNumericUpDown, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.FolderTB, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FoldersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdPartynumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdFoldersNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView FoldersDataGridView;
        private System.Windows.Forms.Button InsertFilebutton1;
        private System.Windows.Forms.Button UpdateFilebutton2;
        private System.Windows.Forms.Button RemovFilebutton3;
        private System.Windows.Forms.NumericUpDown IdPartynumericUpDown;
        private System.Windows.Forms.ComboBox FoldercomboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown IdFoldersNumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox FolderTB;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partyIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;

    }
}
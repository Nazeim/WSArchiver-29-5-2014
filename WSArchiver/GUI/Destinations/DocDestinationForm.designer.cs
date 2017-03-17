namespace WSArchiver.GUI
{
    partial class DocDestinationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocDestinationForm));
            this.InsertDestinationButton = new System.Windows.Forms.Button();
            this.UpdateDestinationButton = new System.Windows.Forms.Button();
            this.RemovDestinationButton = new System.Windows.Forms.Button();
            this.DestinationDataGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DestinationTB = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DestinationDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Size = new System.Drawing.Size(742, 75);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            this.panel1.Controls.SetChildIndex(this.label2, 0);
            this.panel1.Controls.SetChildIndex(this.pictureBox1, 0);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(617, 20);
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.Text = "وجهة المستند";
            // 
            // exitB
            // 
            this.exitB.BackgroundImage = global::WSArchiver.Properties.Resources.exit;
            this.exitB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitB.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitB.Location = new System.Drawing.Point(9, 346);
            this.exitB.Size = new System.Drawing.Size(77, 38);
            this.exitB.TabIndex = 6;
            this.exitB.Text = "";
            this.exitB.Click += new System.EventHandler(this.exitB_Click);
            // 
            // InsertDestinationButton
            // 
            this.InsertDestinationButton.BackgroundImage = global::WSArchiver.Properties.Resources.plus_64;
            this.InsertDestinationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.InsertDestinationButton.Location = new System.Drawing.Point(9, 166);
            this.InsertDestinationButton.Name = "InsertDestinationButton";
            this.InsertDestinationButton.Size = new System.Drawing.Size(77, 38);
            this.InsertDestinationButton.TabIndex = 2;
            this.InsertDestinationButton.UseVisualStyleBackColor = true;
            this.InsertDestinationButton.Click += new System.EventHandler(this.InsertDestinationButton_Click);
            // 
            // UpdateDestinationButton
            // 
            this.UpdateDestinationButton.BackgroundImage = global::WSArchiver.Properties.Resources.Edit2;
            this.UpdateDestinationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UpdateDestinationButton.Location = new System.Drawing.Point(9, 226);
            this.UpdateDestinationButton.Name = "UpdateDestinationButton";
            this.UpdateDestinationButton.Size = new System.Drawing.Size(77, 38);
            this.UpdateDestinationButton.TabIndex = 3;
            this.UpdateDestinationButton.UseVisualStyleBackColor = true;
            this.UpdateDestinationButton.Click += new System.EventHandler(this.UpdateDestinationButton_Click);
            // 
            // RemovDestinationButton
            // 
            this.RemovDestinationButton.BackgroundImage = global::WSArchiver.Properties.Resources.delete_64;
            this.RemovDestinationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RemovDestinationButton.Location = new System.Drawing.Point(9, 286);
            this.RemovDestinationButton.Name = "RemovDestinationButton";
            this.RemovDestinationButton.Size = new System.Drawing.Size(77, 38);
            this.RemovDestinationButton.TabIndex = 4;
            this.RemovDestinationButton.UseVisualStyleBackColor = true;
            this.RemovDestinationButton.Click += new System.EventHandler(this.RemovDestinationButton_Click);
            // 
            // DestinationDataGridView
            // 
            this.DestinationDataGridView.AllowUserToAddRows = false;
            this.DestinationDataGridView.AllowUserToDeleteRows = false;
            this.DestinationDataGridView.AutoGenerateColumns = false;
            this.DestinationDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DestinationDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.DestinationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DestinationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn});
            this.DestinationDataGridView.DataSource = this.bindingSource1;
            this.DestinationDataGridView.Location = new System.Drawing.Point(90, 133);
            this.DestinationDataGridView.Name = "DestinationDataGridView";
            this.DestinationDataGridView.ReadOnly = true;
            this.DestinationDataGridView.RowHeadersVisible = false;
            this.DestinationDataGridView.Size = new System.Drawing.Size(637, 276);
            this.DestinationDataGridView.TabIndex = 29;
            this.DestinationDataGridView.TabStop = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "اسم الوجهة";
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
            this.bindingSource1.DataSource = typeof(Library.Common.DestinationVO);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(278, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(452, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "يتم في هذه الشاشة إدراج أسماء المدراء والموظفين والمكاتب الموجه إليهم الوثائق الص" +
    "ادرة والواردة";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "اسم [الإدارة/المكتب/الموظف]";
            // 
            // DestinationTB
            // 
            this.DestinationTB.Location = new System.Drawing.Point(90, 110);
            this.DestinationTB.Name = "DestinationTB";
            this.DestinationTB.Size = new System.Drawing.Size(292, 20);
            this.DestinationTB.TabIndex = 1;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WSArchiver.Properties.Resources.folder_blue_users;
            this.pictureBox1.Location = new System.Drawing.Point(15, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // DocDestinationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitB;
            this.ClientSize = new System.Drawing.Size(742, 434);
            this.Controls.Add(this.DestinationTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DestinationDataGridView);
            this.Controls.Add(this.InsertDestinationButton);
            this.Controls.Add(this.UpdateDestinationButton);
            this.Controls.Add(this.RemovDestinationButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DocDestinationForm";
            this.Text = "وجهة المستند : الإدارات/المكاتب/الموظفين";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DocDestinationForm_FormClosing);
            this.Load += new System.EventHandler(this.DocDestinationForm_Load);
            this.Controls.SetChildIndex(this.exitB, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.RemovDestinationButton, 0);
            this.Controls.SetChildIndex(this.UpdateDestinationButton, 0);
            this.Controls.SetChildIndex(this.InsertDestinationButton, 0);
            this.Controls.SetChildIndex(this.DestinationDataGridView, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.DestinationTB, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DestinationDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InsertDestinationButton;
        private System.Windows.Forms.Button UpdateDestinationButton;
        private System.Windows.Forms.Button RemovDestinationButton;
        private System.Windows.Forms.DataGridView DestinationDataGridView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DestinationTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
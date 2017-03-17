namespace WSArchiver.GUI.Archive
{
    partial class SimpleSearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimpleSearchForm));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.advancedSearchB = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchGB.SuspendLayout();
            this.searchResultsGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchForExactMatchResultsButton
            // 
            this.SearchForExactMatchResultsButton.Location = new System.Drawing.Point(255, 40);
            this.SearchForExactMatchResultsButton.TabIndex = 2;
            this.SearchForExactMatchResultsButton.Click += new System.EventHandler(this.SearchForExactMatchResultsButton_Click);
            // 
            // SearchForSimilarResultsButton
            // 
            this.SearchForSimilarResultsButton.Location = new System.Drawing.Point(255, 74);
            this.SearchForSimilarResultsButton.TabIndex = 3;
            this.SearchForSimilarResultsButton.Click += new System.EventHandler(this.SearchForSimilarResultsButton_Click);
            // 
            // searchGB
            // 
            this.searchGB.Controls.Add(this.pictureBox1);
            this.searchGB.Controls.Add(this.advancedSearchB);
            this.searchGB.Controls.Add(this.label2);
            this.searchGB.Controls.Add(this.comboBox1);
            this.searchGB.Controls.Add(this.label1);
            this.searchGB.Controls.Add(this.flowLayoutPanel1);
            this.searchGB.Location = new System.Drawing.Point(12, 12);
            this.searchGB.Size = new System.Drawing.Size(1126, 142);
            this.searchGB.TabIndex = 0;
            this.searchGB.Tag = true;
            this.searchGB.Controls.SetChildIndex(this.SearchForSimilarResultsButton, 0);
            this.searchGB.Controls.SetChildIndex(this.SearchForExactMatchResultsButton, 0);
            this.searchGB.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            this.searchGB.Controls.SetChildIndex(this.label1, 0);
            this.searchGB.Controls.SetChildIndex(this.comboBox1, 0);
            this.searchGB.Controls.SetChildIndex(this.label2, 0);
            this.searchGB.Controls.SetChildIndex(this.advancedSearchB, 0);
            this.searchGB.Controls.SetChildIndex(this.pictureBox1, 0);
            // 
            // searchResultsGB
            // 
            this.searchResultsGB.Location = new System.Drawing.Point(10, 160);
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
            this.showSelectedFileB.Location = new System.Drawing.Point(193, 215);
            this.showSelectedFileB.Size = new System.Drawing.Size(76, 33);
            this.showSelectedFileB.TabIndex = 2;
            this.showSelectedFileB.Text = "";
            // 
            // removeSelectedFile
            // 
            this.removeSelectedFile.BackgroundImage = global::WSArchiver.Properties.Resources.delete_64;
            this.removeSelectedFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.removeSelectedFile.Location = new System.Drawing.Point(111, 215);
            this.removeSelectedFile.Size = new System.Drawing.Size(76, 33);
            this.removeSelectedFile.TabIndex = 3;
            this.removeSelectedFile.Text = "";
            // 
            // editSelectedDocumentB
            // 
            this.editSelectedDocumentB.BackgroundImage = global::WSArchiver.Properties.Resources.Edit2;
            this.editSelectedDocumentB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.editSelectedDocumentB.Location = new System.Drawing.Point(1046, 215);
            this.editSelectedDocumentB.Size = new System.Drawing.Size(76, 33);
            this.editSelectedDocumentB.TabIndex = 0;
            this.editSelectedDocumentB.Text = "";
            // 
            // deleteSelectedDocumentB
            // 
            this.deleteSelectedDocumentB.BackgroundImage = global::WSArchiver.Properties.Resources.delete_64;
            this.deleteSelectedDocumentB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deleteSelectedDocumentB.Location = new System.Drawing.Point(964, 215);
            this.deleteSelectedDocumentB.Size = new System.Drawing.Size(76, 33);
            this.deleteSelectedDocumentB.TabIndex = 1;
            this.deleteSelectedDocumentB.Text = "";
            // 
            // exitB
            // 
            this.exitB.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitB.Location = new System.Drawing.Point(1017, 422);
            this.exitB.TabIndex = 2;
            this.exitB.Tag = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(399, 40);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(410, 90);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(815, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "البحث عن:";
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "String";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(523, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(286, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(820, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 26);
            this.label2.TabIndex = 23;
            this.label2.Text = "حدد معيار\r\nالبحث:";
            // 
            // advancedSearchB
            // 
            this.advancedSearchB.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.advancedSearchB.Enabled = false;
            this.advancedSearchB.Location = new System.Drawing.Point(255, 107);
            this.advancedSearchB.Name = "advancedSearchB";
            this.advancedSearchB.Size = new System.Drawing.Size(138, 23);
            this.advancedSearchB.TabIndex = 4;
            this.advancedSearchB.Text = "البحث المتقدم";
            this.advancedSearchB.UseVisualStyleBackColor = true;
            this.advancedSearchB.Click += new System.EventHandler(this.advancedSearchB_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WSArchiver.Properties.Resources.search_artdesigner_lv__1_;
            this.pictureBox1.Location = new System.Drawing.Point(45, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // SimpleSearchForm
            // 
            this.AcceptButton = this.SearchForExactMatchResultsButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.exitB;
            this.ClientSize = new System.Drawing.Size(1150, 472);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SimpleSearchForm";
            this.Load += new System.EventHandler(this.SimpleSearchForm_Load);
            this.searchGB.ResumeLayout(false);
            this.searchGB.PerformLayout();
            this.searchResultsGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button advancedSearchB;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

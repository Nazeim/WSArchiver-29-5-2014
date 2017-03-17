namespace WSArchiver.GUI.Archiving
{
    partial class EFilesArchivingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EFilesArchivingForm));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.filesGB.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveB
            // 
            this.SaveB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveB.BackgroundImage")));
            this.SaveB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SaveB.Location = new System.Drawing.Point(302, 606);
            this.SaveB.Size = new System.Drawing.Size(91, 52);
            this.SaveB.Tag = true;
            this.SaveB.Text = "";
            this.SaveB.Click += new System.EventHandler(this.SaveB_Click_1);
            // 
            // DeletePageB
            // 
            this.DeletePageB.BackgroundImage = global::WSArchiver.Properties.Resources.delete_64;
            this.DeletePageB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DeletePageB.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.DeletePageB.Location = new System.Drawing.Point(13, 98);
            this.DeletePageB.Size = new System.Drawing.Size(106, 33);
            this.DeletePageB.TabIndex = 3;
            this.DeletePageB.Text = "";
            // 
            // importFileB
            // 
            this.importFileB.BackColor = System.Drawing.Color.Transparent;
            this.importFileB.BackgroundImage = global::WSArchiver.Properties.Resources.opened;
            this.importFileB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.importFileB.Location = new System.Drawing.Point(709, 39);
            this.importFileB.Size = new System.Drawing.Size(71, 64);
            this.importFileB.Text = "";
            this.importFileB.UseVisualStyleBackColor = false;
            // 
            // ShowPageB
            // 
            this.ShowPageB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ShowPageB.BackgroundImage")));
            this.ShowPageB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ShowPageB.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.ShowPageB.Location = new System.Drawing.Point(13, 19);
            this.ShowPageB.Size = new System.Drawing.Size(106, 33);
            this.ShowPageB.TabIndex = 1;
            this.ShowPageB.Text = "";
            // 
            // RenameB
            // 
            this.RenameB.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.RenameB.Location = new System.Drawing.Point(13, 59);
            this.RenameB.Size = new System.Drawing.Size(106, 33);
            this.RenameB.TabIndex = 2;
            this.RenameB.Text = "إعادة تسمية";
            this.RenameB.Click += new System.EventHandler(this.RenameB_Click);
            // 
            // filesGB
            // 
            this.filesGB.Tag = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            this.panel1.Controls.SetChildIndex(this.pictureBox1, 0);
            // 
            // exitB
            // 
            this.exitB.BackgroundImage = global::WSArchiver.Properties.Resources.exit;
            this.exitB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitB.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitB.Location = new System.Drawing.Point(460, 606);
            this.exitB.Size = new System.Drawing.Size(91, 52);
            this.exitB.Tag = true;
            this.exitB.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "jpeg";
            this.openFileDialog1.Filter = resources.GetString("openFileDialog1.Filter");
            this.openFileDialog1.FilterIndex = 2;
            this.openFileDialog1.Title = "اختر ملفاً لأرشفته";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WSArchiver.Properties.Resources.Document;
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // EFilesArchivingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.CancelButton = this.exitB;
            this.ClientSize = new System.Drawing.Size(853, 683);
            this.Name = "EFilesArchivingForm";
            this.Text = "المستندات الرقمية";
            this.filesGB.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

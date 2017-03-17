namespace WSArchiver.GUI.Archiving
{
    partial class PaperArchivingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaperArchivingForm));
            this.scannerSettingsL = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.filesGB.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveB
            // 
            this.SaveB.BackgroundImage = global::WSArchiver.Properties.Resources.save_64;
            this.SaveB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SaveB.Font = new System.Drawing.Font("Tahoma", 8F);
            this.SaveB.Location = new System.Drawing.Point(302, 606);
            this.SaveB.Size = new System.Drawing.Size(91, 52);
            this.SaveB.Tag = true;
            this.SaveB.Text = "";
            // 
            // DeletePageB
            // 
            this.DeletePageB.BackgroundImage = global::WSArchiver.Properties.Resources.delete_64;
            this.DeletePageB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DeletePageB.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.DeletePageB.Location = new System.Drawing.Point(12, 98);
            this.DeletePageB.Size = new System.Drawing.Size(106, 33);
            this.DeletePageB.Text = "";
            // 
            // importFileB
            // 
            this.importFileB.BackgroundImage = global::WSArchiver.Properties.Resources.Hardware_Scanner_1_icon;
            this.importFileB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.importFileB.Location = new System.Drawing.Point(710, 40);
            this.importFileB.Size = new System.Drawing.Size(71, 64);
            this.importFileB.Text = "";
            // 
            // ShowPageB
            // 
            this.ShowPageB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ShowPageB.BackgroundImage")));
            this.ShowPageB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ShowPageB.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.ShowPageB.Location = new System.Drawing.Point(12, 19);
            this.ShowPageB.Size = new System.Drawing.Size(106, 33);
            this.ShowPageB.Text = "";
            // 
            // RenameB
            // 
            this.RenameB.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.RenameB.Location = new System.Drawing.Point(12, 59);
            this.RenameB.Size = new System.Drawing.Size(106, 33);
            this.RenameB.Text = "إعادة تسمية";
            // 
            // filesGB
            // 
            this.filesGB.Controls.Add(this.scannerSettingsL);
            this.filesGB.Tag = true;
            this.filesGB.Controls.SetChildIndex(this.ShowPageB, 0);
            this.filesGB.Controls.SetChildIndex(this.DeletePageB, 0);
            this.filesGB.Controls.SetChildIndex(this.RenameB, 0);
            this.filesGB.Controls.SetChildIndex(this.importFileB, 0);
            this.filesGB.Controls.SetChildIndex(this.scannerSettingsL, 0);
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
            this.exitB.Cursor = System.Windows.Forms.Cursors.Default;
            this.exitB.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitB.Location = new System.Drawing.Point(460, 606);
            this.exitB.Size = new System.Drawing.Size(91, 52);
            this.exitB.Tag = true;
            this.exitB.Text = "";
            // 
            // scannerSettingsL
            // 
            this.scannerSettingsL.AutoSize = true;
            this.scannerSettingsL.Location = new System.Drawing.Point(703, 115);
            this.scannerSettingsL.Name = "scannerSettingsL";
            this.scannerSettingsL.Size = new System.Drawing.Size(86, 13);
            this.scannerSettingsL.TabIndex = 6;
            this.scannerSettingsL.TabStop = true;
            this.scannerSettingsL.Text = "إعدادات الماسحة";
            this.scannerSettingsL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.scannerSettingsL_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WSArchiver.Properties.Resources.scanner_camera_folder_2;
            this.pictureBox1.Location = new System.Drawing.Point(12, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // PaperArchivingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.CancelButton = this.exitB;
            this.ClientSize = new System.Drawing.Size(853, 683);
            this.Name = "PaperArchivingForm";
            this.Text = "أرشفة مستندات ورقية";
            this.filesGB.ResumeLayout(false);
            this.filesGB.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel scannerSettingsL;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

namespace WSArchiver.GUI
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.localStoragePathTB = new System.Windows.Forms.TextBox();
            this.serverAddressTB = new System.Windows.Forms.TextBox();
            this.Okbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.browseFolderB = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.defaultB = new System.Windows.Forms.Button();
            this.checkerBGW = new System.ComponentModel.BackgroundWorker();
            this.verifyServerAddressB = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Size = new System.Drawing.Size(549, 64);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            this.panel1.Controls.SetChildIndex(this.label2, 0);
            this.panel1.Controls.SetChildIndex(this.pictureBox1, 0);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(403, 16);
            this.label1.Size = new System.Drawing.Size(123, 19);
            this.label1.Text = "إعدادات الاتصال";
            // 
            // exitB
            // 
            this.exitB.BackgroundImage = global::WSArchiver.Properties.Resources.exit;
            this.exitB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitB.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitB.Location = new System.Drawing.Point(299, 207);
            this.exitB.Size = new System.Drawing.Size(75, 35);
            this.exitB.Text = "";
            this.exitB.Click += new System.EventHandler(this.exitB_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(183, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "يتم في هذه الشاشة تحديد إعدادات الاتصال اللازمة للمنظومة ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "المسار المحلي لتخزين الملفات:\r\n";
            // 
            // localStoragePathTB
            // 
            this.localStoragePathTB.Location = new System.Drawing.Point(187, 87);
            this.localStoragePathTB.Name = "localStoragePathTB";
            this.localStoragePathTB.Size = new System.Drawing.Size(235, 20);
            this.localStoragePathTB.TabIndex = 4;
            // 
            // serverAddressTB
            // 
            this.serverAddressTB.Location = new System.Drawing.Point(187, 123);
            this.serverAddressTB.Name = "serverAddressTB";
            this.serverAddressTB.Size = new System.Drawing.Size(235, 20);
            this.serverAddressTB.TabIndex = 5;
            // 
            // Okbutton
            // 
            this.Okbutton.BackgroundImage = global::WSArchiver.Properties.Resources.tick_64;
            this.Okbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Okbutton.Location = new System.Drawing.Point(174, 207);
            this.Okbutton.Name = "Okbutton";
            this.Okbutton.Size = new System.Drawing.Size(75, 35);
            this.Okbutton.TabIndex = 7;
            this.Okbutton.UseVisualStyleBackColor = true;
            this.Okbutton.Click += new System.EventHandler(this.Okbutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WSArchiver.Properties.Resources.configuration_settings;
            this.pictureBox1.Location = new System.Drawing.Point(12, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "عنوان المخدم على الشبكة:";
            // 
            // browseFolderB
            // 
            this.browseFolderB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.browseFolderB.Location = new System.Drawing.Point(467, 80);
            this.browseFolderB.Name = "browseFolderB";
            this.browseFolderB.Size = new System.Drawing.Size(34, 31);
            this.browseFolderB.TabIndex = 9;
            this.browseFolderB.Text = "...";
            this.toolTip1.SetToolTip(this.browseFolderB, "استعراض");
            this.browseFolderB.UseVisualStyleBackColor = true;
            this.browseFolderB.Click += new System.EventHandler(this.browseFolderB_Click);
            // 
            // defaultB
            // 
            this.defaultB.Location = new System.Drawing.Point(187, 149);
            this.defaultB.Name = "defaultB";
            this.defaultB.Size = new System.Drawing.Size(75, 23);
            this.defaultB.TabIndex = 10;
            this.defaultB.Text = "افتراضي";
            this.defaultB.UseVisualStyleBackColor = true;
            this.defaultB.Click += new System.EventHandler(this.defaultB_Click);
            // 
            // checkerBGW
            // 
            this.checkerBGW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.checkerBGW_DoWork);
            this.checkerBGW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.checkerBGW_RunWorkerCompleted);
            // 
            // verifyServerAddressB
            // 
            this.verifyServerAddressB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("verifyServerAddressB.BackgroundImage")));
            this.verifyServerAddressB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.verifyServerAddressB.Location = new System.Drawing.Point(428, 117);
            this.verifyServerAddressB.Name = "verifyServerAddressB";
            this.verifyServerAddressB.Size = new System.Drawing.Size(34, 31);
            this.verifyServerAddressB.TabIndex = 11;
            this.toolTip1.SetToolTip(this.verifyServerAddressB, "تحقق");
            this.verifyServerAddressB.UseVisualStyleBackColor = true;
            this.verifyServerAddressB.Click += new System.EventHandler(this.verifyServerAddressB_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(428, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 31);
            this.button2.TabIndex = 11;
            this.toolTip1.SetToolTip(this.button2, "تحقق");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.Okbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitB;
            this.ClientSize = new System.Drawing.Size(549, 277);
            this.Controls.Add(this.defaultB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.serverAddressTB);
            this.Controls.Add(this.localStoragePathTB);
            this.Controls.Add(this.Okbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.verifyServerAddressB);
            this.Controls.Add(this.browseFolderB);
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.Text = "الإعدادات";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.Controls.SetChildIndex(this.browseFolderB, 0);
            this.Controls.SetChildIndex(this.verifyServerAddressB, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.Okbutton, 0);
            this.Controls.SetChildIndex(this.localStoragePathTB, 0);
            this.Controls.SetChildIndex(this.serverAddressTB, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.defaultB, 0);
            this.Controls.SetChildIndex(this.exitB, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox localStoragePathTB;
        private System.Windows.Forms.TextBox serverAddressTB;
        private System.Windows.Forms.Button Okbutton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button browseFolderB;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button defaultB;
        private System.ComponentModel.BackgroundWorker checkerBGW;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button verifyServerAddressB;
        private System.Windows.Forms.Button button2;
    }
}
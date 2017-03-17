namespace WSArchiver.GUI.Destinations
{
    partial class DestinationEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DestinationEditForm));
            this.button1 = new System.Windows.Forms.Button();
            this.DestTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Size = new System.Drawing.Size(363, 59);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            this.panel1.Controls.SetChildIndex(this.pictureBox1, 0);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(246, 20);
            this.label1.Size = new System.Drawing.Size(105, 19);
            this.label1.Text = "تعديل الوجهة";
            // 
            // exitB
            // 
            this.exitB.BackgroundImage = global::WSArchiver.Properties.Resources.exit;
            this.exitB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitB.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitB.Location = new System.Drawing.Point(200, 126);
            this.exitB.Size = new System.Drawing.Size(77, 37);
            this.exitB.Text = "";
            this.exitB.Click += new System.EventHandler(this.exitB_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::WSArchiver.Properties.Resources.tick_64;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(92, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 37);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DestTB
            // 
            this.DestTB.Location = new System.Drawing.Point(64, 85);
            this.DestTB.Name = "DestTB";
            this.DestTB.Size = new System.Drawing.Size(237, 20);
            this.DestTB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "اسم الوجهة";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WSArchiver.Properties.Resources.folder_blue_users;
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // DestinationEditForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitB;
            this.ClientSize = new System.Drawing.Size(363, 188);
            this.Controls.Add(this.DestTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DestinationEditForm";
            this.Text = "تعديل";
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.exitB, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.DestTB, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox DestTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
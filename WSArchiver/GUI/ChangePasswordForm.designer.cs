namespace WSArchiver.GUI
{
    partial class ChangePasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.confirmpasswordTB = new System.Windows.Forms.TextBox();
            this.SaveB = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Size = new System.Drawing.Size(469, 64);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            this.panel1.Controls.SetChildIndex(this.label2, 0);
            this.panel1.Controls.SetChildIndex(this.pictureBox1, 0);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 13);
            this.label1.Size = new System.Drawing.Size(133, 19);
            this.label1.Text = "تغيير كلمة المرور";
            // 
            // exitB
            // 
            this.exitB.BackgroundImage = global::WSArchiver.Properties.Resources.exit;
            this.exitB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitB.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitB.Location = new System.Drawing.Point(257, 179);
            this.exitB.Size = new System.Drawing.Size(77, 37);
            this.exitB.TabIndex = 4;
            this.exitB.Text = "";
            this.exitB.Click += new System.EventHandler(this.exitB_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(143, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "يتم في هذه الشاشة تخصيص كلمة مرور جديدة من قبل المستخدم";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "كلمة المرور الجديدة:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "تأكيد كلمة المرور :";
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(161, 97);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '*';
            this.passwordTB.Size = new System.Drawing.Size(249, 20);
            this.passwordTB.TabIndex = 1;
            // 
            // confirmpasswordTB
            // 
            this.confirmpasswordTB.Location = new System.Drawing.Point(161, 131);
            this.confirmpasswordTB.Name = "confirmpasswordTB";
            this.confirmpasswordTB.PasswordChar = '*';
            this.confirmpasswordTB.Size = new System.Drawing.Size(249, 20);
            this.confirmpasswordTB.TabIndex = 2;
            // 
            // SaveB
            // 
            this.SaveB.BackgroundImage = global::WSArchiver.Properties.Resources.tick_64;
            this.SaveB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SaveB.Location = new System.Drawing.Point(135, 179);
            this.SaveB.Name = "SaveB";
            this.SaveB.Size = new System.Drawing.Size(77, 37);
            this.SaveB.TabIndex = 3;
            this.SaveB.UseVisualStyleBackColor = true;
            this.SaveB.Click += new System.EventHandler(this.SaveB_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WSArchiver.Properties.Resources.password;
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ChangePasswordForm
            // 
            this.AcceptButton = this.SaveB;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitB;
            this.ClientSize = new System.Drawing.Size(469, 246);
            this.Controls.Add(this.SaveB);
            this.Controls.Add(this.confirmpasswordTB);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangePasswordForm";
            this.Text = "تغيير كلمة المرور";
            this.Controls.SetChildIndex(this.exitB, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.passwordTB, 0);
            this.Controls.SetChildIndex(this.confirmpasswordTB, 0);
            this.Controls.SetChildIndex(this.SaveB, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.TextBox confirmpasswordTB;
        private System.Windows.Forms.Button SaveB;
    }
}
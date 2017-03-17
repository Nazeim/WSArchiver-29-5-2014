namespace WSArchiver.GUI
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.label3 = new System.Windows.Forms.Label();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.LogInB = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.UserNameTB = new System.Windows.Forms.TextBox();
            this.localRB = new System.Windows.Forms.RadioButton();
            this.serverRB = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Size = new System.Drawing.Size(415, 64);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            this.panel1.Controls.SetChildIndex(this.pictureBox1, 0);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(284, 22);
            this.label1.Size = new System.Drawing.Size(119, 19);
            this.label1.Text = "تسجيل الدخول";
            // 
            // exitB
            // 
            this.exitB.BackgroundImage = global::WSArchiver.Properties.Resources.exit;
            this.exitB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitB.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitB.Location = new System.Drawing.Point(231, 240);
            this.exitB.Size = new System.Drawing.Size(77, 38);
            this.exitB.TabIndex = 5;
            this.exitB.Text = "";
            this.exitB.Click += new System.EventHandler(this.exitB_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "كلــمــة المــرور :";
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(132, 119);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.PasswordChar = '*';
            this.PasswordTB.Size = new System.Drawing.Size(244, 20);
            this.PasswordTB.TabIndex = 1;
            // 
            // LogInB
            // 
            this.LogInB.BackgroundImage = global::WSArchiver.Properties.Resources.tick_64;
            this.LogInB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LogInB.Location = new System.Drawing.Point(107, 241);
            this.LogInB.Name = "LogInB";
            this.LogInB.Size = new System.Drawing.Size(77, 37);
            this.LogInB.TabIndex = 4;
            this.LogInB.UseVisualStyleBackColor = true;
            this.LogInB.Click += new System.EventHandler(this.LogInB_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "اسم المستخدم :";
            // 
            // UserNameTB
            // 
            this.UserNameTB.Location = new System.Drawing.Point(132, 93);
            this.UserNameTB.Name = "UserNameTB";
            this.UserNameTB.Size = new System.Drawing.Size(244, 20);
            this.UserNameTB.TabIndex = 0;
            // 
            // localRB
            // 
            this.localRB.AutoSize = true;
            this.localRB.Checked = true;
            this.localRB.Location = new System.Drawing.Point(132, 145);
            this.localRB.Name = "localRB";
            this.localRB.Size = new System.Drawing.Size(123, 17);
            this.localRB.TabIndex = 2;
            this.localRB.TabStop = true;
            this.localRB.Text = "قاعدة البيانات المحلية";
            this.localRB.UseVisualStyleBackColor = true;
            // 
            // serverRB
            // 
            this.serverRB.AutoSize = true;
            this.serverRB.Location = new System.Drawing.Point(132, 168);
            this.serverRB.Name = "serverRB";
            this.serverRB.Size = new System.Drawing.Size(115, 17);
            this.serverRB.TabIndex = 3;
            this.serverRB.Text = "قاعدة بيانات المخدم";
            this.serverRB.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "الاتصـــال بـــ :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WSArchiver.Properties.Resources.system_lock_screen;
            this.pictureBox1.Location = new System.Drawing.Point(12, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(168, 201);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(78, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "إعدادات الاتصال";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // LogInForm
            // 
            this.AcceptButton = this.LogInB;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitB;
            this.ClientSize = new System.Drawing.Size(415, 303);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.serverRB);
            this.Controls.Add(this.localRB);
            this.Controls.Add(this.UserNameTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LogInB);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogInForm";
            this.Text = "تسجيل الدخول";
            this.Load += new System.EventHandler(this.LogInForm_Load);
            this.Controls.SetChildIndex(this.exitB, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.PasswordTB, 0);
            this.Controls.SetChildIndex(this.LogInB, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.UserNameTB, 0);
            this.Controls.SetChildIndex(this.localRB, 0);
            this.Controls.SetChildIndex(this.serverRB, 0);
            this.Controls.SetChildIndex(this.linkLabel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Button LogInB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox UserNameTB;
        private System.Windows.Forms.RadioButton localRB;
        private System.Windows.Forms.RadioButton serverRB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
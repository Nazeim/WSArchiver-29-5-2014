namespace Messenger.GUI.UserControls
{
    partial class UserUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.userNameL = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.messagesCountL = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.userNameL, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.messagesCountL, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(133, 20);
            this.tableLayoutPanel1.TabIndex = 3;
            this.tableLayoutPanel1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.tableLayoutPanel1.MouseEnter += new System.EventHandler(this.tableLayoutPanel1_MouseEnter);
            this.tableLayoutPanel1.MouseLeave += new System.EventHandler(this.tableLayoutPanel1_MouseLeave);
            // 
            // userNameL
            // 
            this.userNameL.AutoSize = true;
            this.userNameL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userNameL.Location = new System.Drawing.Point(19, 0);
            this.userNameL.Name = "userNameL";
            this.userNameL.Size = new System.Drawing.Size(94, 20);
            this.userNameL.TabIndex = 6;
            this.userNameL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userNameL.Click += new System.EventHandler(this.pictureBox1_Click);
            this.userNameL.MouseEnter += new System.EventHandler(this.tableLayoutPanel1_MouseEnter);
            this.userNameL.MouseLeave += new System.EventHandler(this.tableLayoutPanel1_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(116, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(17, 20);
            this.panel1.TabIndex = 4;
            this.panel1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.panel1.MouseEnter += new System.EventHandler(this.tableLayoutPanel1_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.tableLayoutPanel1_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.tableLayoutPanel1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.tableLayoutPanel1_MouseLeave);
            // 
            // messagesCountL
            // 
            this.messagesCountL.AutoSize = true;
            this.messagesCountL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messagesCountL.Location = new System.Drawing.Point(3, 0);
            this.messagesCountL.Name = "messagesCountL";
            this.messagesCountL.Size = new System.Drawing.Size(10, 20);
            this.messagesCountL.TabIndex = 5;
            this.messagesCountL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.messagesCountL.Click += new System.EventHandler(this.pictureBox1_Click);
            this.messagesCountL.MouseEnter += new System.EventHandler(this.tableLayoutPanel1_MouseEnter);
            this.messagesCountL.MouseLeave += new System.EventHandler(this.tableLayoutPanel1_MouseLeave);
            // 
            // UserUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserUserControl";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(133, 20);
            this.Click += new System.EventHandler(this.pictureBox1_Click);
            this.MouseEnter += new System.EventHandler(this.tableLayoutPanel1_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.tableLayoutPanel1_MouseLeave);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label messagesCountL;
        private System.Windows.Forms.Label userNameL;
    }
}

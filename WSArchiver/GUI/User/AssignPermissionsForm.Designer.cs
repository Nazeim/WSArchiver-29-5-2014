namespace WSArchiver.GUI.User
{
    partial class AssignPermissionsForm
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.saveB = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Size = new System.Drawing.Size(389, 64);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            this.panel1.Controls.SetChildIndex(this.pictureBox1, 0);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(215, 19);
            this.label1.Size = new System.Drawing.Size(162, 19);
            this.label1.Text = "سماحيات المستخدم";
            // 
            // exitB
            // 
            this.exitB.BackgroundImage = global::WSArchiver.Properties.Resources.exit;
            this.exitB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitB.Location = new System.Drawing.Point(226, 317);
            this.exitB.Size = new System.Drawing.Size(77, 37);
            this.exitB.Text = "";
            this.exitB.Click += new System.EventHandler(this.exitB_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.ColumnWidth = 175;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(16, 141);
            this.checkedListBox1.MultiColumn = true;
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(361, 154);
            this.checkedListBox1.TabIndex = 2;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // saveB
            // 
            this.saveB.BackgroundImage = global::WSArchiver.Properties.Resources.tick_64;
            this.saveB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.saveB.Enabled = false;
            this.saveB.Location = new System.Drawing.Point(85, 317);
            this.saveB.Name = "saveB";
            this.saveB.Size = new System.Drawing.Size(77, 37);
            this.saveB.TabIndex = 3;
            this.saveB.UseVisualStyleBackColor = true;
            this.saveB.Click += new System.EventHandler(this.saveB_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "اختر السماحيات الخاصة بالمستخدم: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(237, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "المستخدم المحدد:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WSArchiver.Properties.Resources.key_48;
            this.pictureBox1.Location = new System.Drawing.Point(12, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // AssignPermissionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(389, 391);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saveB);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "AssignPermissionsForm";
            this.Text = "تعديل سماحيات المستخدم";
            this.Load += new System.EventHandler(this.AssignPermissionsForm_Load);
            this.Controls.SetChildIndex(this.exitB, 0);
            this.Controls.SetChildIndex(this.checkedListBox1, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.saveB, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button saveB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

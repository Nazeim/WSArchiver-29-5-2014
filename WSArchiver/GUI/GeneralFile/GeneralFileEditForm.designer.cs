namespace WSArchiver.GUI.Folder
{
    partial class FolderEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FolderEditForm));
            this.button1 = new System.Windows.Forms.Button();
            this.FolderTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.IdFoldersNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FoldercomboBox = new System.Windows.Forms.ComboBox();
            this.IdPartynumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IdFoldersNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdPartynumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Size = new System.Drawing.Size(469, 47);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            this.panel1.Controls.SetChildIndex(this.pictureBox1, 0);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(299, 13);
            this.label1.Size = new System.Drawing.Size(159, 19);
            this.label1.Text = "تعديل الملفات العامة";
            // 
            // exitB
            // 
            this.exitB.BackgroundImage = global::WSArchiver.Properties.Resources.exit;
            this.exitB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitB.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitB.Location = new System.Drawing.Point(245, 180);
            this.exitB.Size = new System.Drawing.Size(77, 37);
            this.exitB.Text = "";
            this.exitB.Click += new System.EventHandler(this.exitB_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::WSArchiver.Properties.Resources.tick_64;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(147, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 37);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FolderTB
            // 
            this.FolderTB.Location = new System.Drawing.Point(217, 137);
            this.FolderTB.Name = "FolderTB";
            this.FolderTB.Size = new System.Drawing.Size(173, 20);
            this.FolderTB.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(214, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "اسم الملف العام";
            // 
            // IdFoldersNumericUpDown
            // 
            this.IdFoldersNumericUpDown.Location = new System.Drawing.Point(82, 137);
            this.IdFoldersNumericUpDown.Name = "IdFoldersNumericUpDown";
            this.IdFoldersNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.IdFoldersNumericUpDown.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(79, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "الرقم";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(214, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = " الجهة";
            // 
            // FoldercomboBox
            // 
            this.FoldercomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FoldercomboBox.FormattingEnabled = true;
            this.FoldercomboBox.Location = new System.Drawing.Point(217, 86);
            this.FoldercomboBox.Name = "FoldercomboBox";
            this.FoldercomboBox.Size = new System.Drawing.Size(173, 21);
            this.FoldercomboBox.TabIndex = 14;
            this.FoldercomboBox.SelectedIndexChanged += new System.EventHandler(this.FoldercomboBox_SelectedIndexChanged);
            // 
            // IdPartynumericUpDown
            // 
            this.IdPartynumericUpDown.Location = new System.Drawing.Point(82, 86);
            this.IdPartynumericUpDown.Name = "IdPartynumericUpDown";
            this.IdPartynumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.IdPartynumericUpDown.TabIndex = 13;
            this.IdPartynumericUpDown.ValueChanged += new System.EventHandler(this.IdPartynumericUpDown_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "الرقم";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WSArchiver.Properties.Resources.mydocuments;
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // FolderEditForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitB;
            this.ClientSize = new System.Drawing.Size(469, 246);
            this.Controls.Add(this.FolderTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.IdFoldersNumericUpDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FoldercomboBox);
            this.Controls.Add(this.IdPartynumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FolderEditForm";
            this.Text = "تعديل";
            this.Load += new System.EventHandler(this.FolderEditForm_Load);
            this.Controls.SetChildIndex(this.exitB, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.IdPartynumericUpDown, 0);
            this.Controls.SetChildIndex(this.FoldercomboBox, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.IdFoldersNumericUpDown, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.FolderTB, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IdFoldersNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdPartynumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox FolderTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown IdFoldersNumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox FoldercomboBox;
        private System.Windows.Forms.NumericUpDown IdPartynumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
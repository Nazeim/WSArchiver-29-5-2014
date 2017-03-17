namespace WSArchiver.GUI.Party
{
    partial class PartyEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartyEditForm));
            this.button1 = new System.Windows.Forms.Button();
            this.partyNameTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.IdPartynumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IdPartynumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Size = new System.Drawing.Size(469, 49);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            this.panel1.Controls.SetChildIndex(this.pictureBox1, 0);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(361, 15);
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.Text = "تعديل الجهة";
            // 
            // exitB
            // 
            this.exitB.BackgroundImage = global::WSArchiver.Properties.Resources.exit;
            this.exitB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitB.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitB.Location = new System.Drawing.Point(253, 173);
            this.exitB.Size = new System.Drawing.Size(77, 37);
            this.exitB.TabIndex = 3;
            this.exitB.Text = "";
            this.exitB.Click += new System.EventHandler(this.exitB_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::WSArchiver.Properties.Resources.tick_64;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(138, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 37);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // partyNameTB
            // 
            this.partyNameTB.Location = new System.Drawing.Point(165, 92);
            this.partyNameTB.Name = "partyNameTB";
            this.partyNameTB.Size = new System.Drawing.Size(234, 20);
            this.partyNameTB.TabIndex = 1;
            this.partyNameTB.TextChanged += new System.EventHandler(this.IdPartynumericUpDown_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(162, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "اسم الجهة";
            // 
            // IdPartynumericUpDown
            // 
            this.IdPartynumericUpDown.Location = new System.Drawing.Point(72, 92);
            this.IdPartynumericUpDown.Name = "IdPartynumericUpDown";
            this.IdPartynumericUpDown.Size = new System.Drawing.Size(71, 20);
            this.IdPartynumericUpDown.TabIndex = 0;
            this.IdPartynumericUpDown.ValueChanged += new System.EventHandler(this.IdPartynumericUpDown_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "الرقم";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WSArchiver.Properties.Resources.User_Files_icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // PartyEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitB;
            this.ClientSize = new System.Drawing.Size(469, 246);
            this.Controls.Add(this.partyNameTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IdPartynumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PartyEditForm";
            this.Text = "تعديل الجهة";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PartyEditForm_FormClosing);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.exitB, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.IdPartynumericUpDown, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.partyNameTB, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IdPartynumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox partyNameTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown IdPartynumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
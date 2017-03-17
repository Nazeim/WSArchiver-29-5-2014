namespace WSArchiver.GUI
{
    partial class PartyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartyForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PartyDataGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.IdPartynumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.InsertPartybutton1 = new System.Windows.Forms.Button();
            this.UpdatePartybutton2 = new System.Windows.Forms.Button();
            this.RemovPartybutton3 = new System.Windows.Forms.Button();
            this.partyNameTB = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PartyDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdPartynumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Size = new System.Drawing.Size(742, 64);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            this.panel1.Controls.SetChildIndex(this.label2, 0);
            this.panel1.Controls.SetChildIndex(this.pictureBox1, 0);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(655, 9);
            this.label1.Text = "الجهات";
            // 
            // exitB
            // 
            this.exitB.BackgroundImage = global::WSArchiver.Properties.Resources.exit;
            this.exitB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitB.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitB.Location = new System.Drawing.Point(10, 317);
            this.exitB.Size = new System.Drawing.Size(77, 38);
            this.exitB.TabIndex = 6;
            this.exitB.Text = "";
            this.exitB.Click += new System.EventHandler(this.exitB_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(208, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(505, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "يتم في هذه الشاشة تكوين أرشيف لكل الجهات والشركات والإدارات التي سيتم التعامل معه" +
    "ا";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(355, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "اسم الجهة";
            // 
            // PartyDataGridView
            // 
            this.PartyDataGridView.AllowUserToAddRows = false;
            this.PartyDataGridView.AllowUserToDeleteRows = false;
            this.PartyDataGridView.AutoGenerateColumns = false;
            this.PartyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PartyDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.PartyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PartyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn});
            this.PartyDataGridView.DataSource = this.bindingSource1;
            this.PartyDataGridView.Location = new System.Drawing.Point(93, 147);
            this.PartyDataGridView.Name = "PartyDataGridView";
            this.PartyDataGridView.ReadOnly = true;
            this.PartyDataGridView.RowHeadersVisible = false;
            this.PartyDataGridView.RowHeadersWidth = 15;
            this.PartyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PartyDataGridView.Size = new System.Drawing.Size(637, 228);
            this.PartyDataGridView.TabIndex = 5;
            this.PartyDataGridView.TabStop = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 90F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "اسم الجهة";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Library.Common.PartyVO);
            // 
            // IdPartynumericUpDown
            // 
            this.IdPartynumericUpDown.Location = new System.Drawing.Point(197, 109);
            this.IdPartynumericUpDown.Name = "IdPartynumericUpDown";
            this.IdPartynumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.IdPartynumericUpDown.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(194, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "الرقم";
            // 
            // InsertPartybutton1
            // 
            this.InsertPartybutton1.BackgroundImage = global::WSArchiver.Properties.Resources.plus_64;
            this.InsertPartybutton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.InsertPartybutton1.Location = new System.Drawing.Point(10, 170);
            this.InsertPartybutton1.Name = "InsertPartybutton1";
            this.InsertPartybutton1.Size = new System.Drawing.Size(77, 38);
            this.InsertPartybutton1.TabIndex = 2;
            this.InsertPartybutton1.UseVisualStyleBackColor = true;
            this.InsertPartybutton1.Click += new System.EventHandler(this.InsertPartybutton1_Click);
            // 
            // UpdatePartybutton2
            // 
            this.UpdatePartybutton2.BackgroundImage = global::WSArchiver.Properties.Resources.Edit2;
            this.UpdatePartybutton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UpdatePartybutton2.Location = new System.Drawing.Point(10, 219);
            this.UpdatePartybutton2.Name = "UpdatePartybutton2";
            this.UpdatePartybutton2.Size = new System.Drawing.Size(77, 38);
            this.UpdatePartybutton2.TabIndex = 3;
            this.UpdatePartybutton2.UseVisualStyleBackColor = true;
            this.UpdatePartybutton2.Click += new System.EventHandler(this.UpdatePartybutton2_Click);
            // 
            // RemovPartybutton3
            // 
            this.RemovPartybutton3.BackgroundImage = global::WSArchiver.Properties.Resources.delete_64;
            this.RemovPartybutton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RemovPartybutton3.Location = new System.Drawing.Point(10, 268);
            this.RemovPartybutton3.Name = "RemovPartybutton3";
            this.RemovPartybutton3.Size = new System.Drawing.Size(77, 38);
            this.RemovPartybutton3.TabIndex = 4;
            this.RemovPartybutton3.UseVisualStyleBackColor = true;
            this.RemovPartybutton3.Click += new System.EventHandler(this.RemovPartybutton3_Click);
            // 
            // partyNameTB
            // 
            this.partyNameTB.Location = new System.Drawing.Point(358, 109);
            this.partyNameTB.Name = "partyNameTB";
            this.partyNameTB.Size = new System.Drawing.Size(234, 20);
            this.partyNameTB.TabIndex = 1;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WSArchiver.Properties.Resources.User_Files_icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // PartyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitB;
            this.ClientSize = new System.Drawing.Size(742, 400);
            this.Controls.Add(this.partyNameTB);
            this.Controls.Add(this.InsertPartybutton1);
            this.Controls.Add(this.UpdatePartybutton2);
            this.Controls.Add(this.RemovPartybutton3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PartyDataGridView);
            this.Controls.Add(this.IdPartynumericUpDown);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PartyForm";
            this.Text = "الجهات";
            this.Load += new System.EventHandler(this.PartyForm_Load);
            this.Controls.SetChildIndex(this.exitB, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.IdPartynumericUpDown, 0);
            this.Controls.SetChildIndex(this.PartyDataGridView, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.RemovPartybutton3, 0);
            this.Controls.SetChildIndex(this.UpdatePartybutton2, 0);
            this.Controls.SetChildIndex(this.InsertPartybutton1, 0);
            this.Controls.SetChildIndex(this.partyNameTB, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PartyDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdPartynumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView PartyDataGridView;
        private System.Windows.Forms.NumericUpDown IdPartynumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button InsertPartybutton1;
        private System.Windows.Forms.Button UpdatePartybutton2;
        private System.Windows.Forms.Button RemovPartybutton3;
        private System.Windows.Forms.TextBox partyNameTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
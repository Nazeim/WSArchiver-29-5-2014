namespace WSArchiver.GUI
{
    partial class CategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryForm));
            this.label4 = new System.Windows.Forms.Label();
            this.UpdateB = new System.Windows.Forms.Button();
            this.RemovB = new System.Windows.Forms.Button();
            this.CategoryDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.InsertB = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Size = new System.Drawing.Size(742, 75);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            this.panel1.Controls.SetChildIndex(this.label2, 0);
            this.panel1.Controls.SetChildIndex(this.pictureBox1, 0);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(635, 17);
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.Text = "التصنيفات";
            // 
            // exitB
            // 
            this.exitB.BackgroundImage = global::WSArchiver.Properties.Resources.exit;
            this.exitB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitB.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitB.Location = new System.Drawing.Point(10, 346);
            this.exitB.Size = new System.Drawing.Size(77, 38);
            this.exitB.TabIndex = 5;
            this.exitB.Text = "";
            this.exitB.Click += new System.EventHandler(this.exitB_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "التصنيف";
            // 
            // UpdateB
            // 
            this.UpdateB.BackgroundImage = global::WSArchiver.Properties.Resources.Edit2;
            this.UpdateB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UpdateB.Location = new System.Drawing.Point(10, 226);
            this.UpdateB.Name = "UpdateB";
            this.UpdateB.Size = new System.Drawing.Size(77, 38);
            this.UpdateB.TabIndex = 3;
            this.UpdateB.UseVisualStyleBackColor = true;
            this.UpdateB.Click += new System.EventHandler(this.UpdateB_Click);
            // 
            // RemovB
            // 
            this.RemovB.BackgroundImage = global::WSArchiver.Properties.Resources.delete_64;
            this.RemovB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RemovB.Location = new System.Drawing.Point(10, 286);
            this.RemovB.Name = "RemovB";
            this.RemovB.Size = new System.Drawing.Size(77, 38);
            this.RemovB.TabIndex = 4;
            this.RemovB.UseVisualStyleBackColor = true;
            this.RemovB.Click += new System.EventHandler(this.RemovB_Click);
            // 
            // CategoryDataGridView
            // 
            this.CategoryDataGridView.AllowUserToAddRows = false;
            this.CategoryDataGridView.AllowUserToDeleteRows = false;
            this.CategoryDataGridView.AutoGenerateColumns = false;
            this.CategoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CategoryDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.CategoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.CategoryDataGridView.DataSource = this.bindingSource1;
            this.CategoryDataGridView.Location = new System.Drawing.Point(93, 133);
            this.CategoryDataGridView.Name = "CategoryDataGridView";
            this.CategoryDataGridView.ReadOnly = true;
            this.CategoryDataGridView.RowHeadersVisible = false;
            this.CategoryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CategoryDataGridView.Size = new System.Drawing.Size(637, 276);
            this.CategoryDataGridView.TabIndex = 1;
            this.CategoryDataGridView.TabStop = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.FillWeight = 30F;
            this.idDataGridViewTextBoxColumn.HeaderText = "الرقم";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 70F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "التصنيف";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Library.Common.CategoryVO);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(263, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(452, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "يتم في هذه الشاشة إنشاء وتعديل تصنيفات الوثائق، تفيد التصنيفات في سهولة البحث عن " +
    "الوثائق.";
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(93, 107);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(292, 20);
            this.NameTB.TabIndex = 0;
            // 
            // InsertB
            // 
            this.InsertB.BackgroundImage = global::WSArchiver.Properties.Resources.plus_64;
            this.InsertB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.InsertB.Location = new System.Drawing.Point(10, 166);
            this.InsertB.Name = "InsertB";
            this.InsertB.Size = new System.Drawing.Size(77, 38);
            this.InsertB.TabIndex = 2;
            this.InsertB.UseVisualStyleBackColor = true;
            this.InsertB.Click += new System.EventHandler(this.InsertB_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WSArchiver.Properties.Resources.mydocuments;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitB;
            this.ClientSize = new System.Drawing.Size(742, 434);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.CategoryDataGridView);
            this.Controls.Add(this.InsertB);
            this.Controls.Add(this.UpdateB);
            this.Controls.Add(this.RemovB);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CategoryForm";
            this.Text = "التصنيفات";
            this.Controls.SetChildIndex(this.exitB, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.RemovB, 0);
            this.Controls.SetChildIndex(this.UpdateB, 0);
            this.Controls.SetChildIndex(this.InsertB, 0);
            this.Controls.SetChildIndex(this.CategoryDataGridView, 0);
            this.Controls.SetChildIndex(this.NameTB, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button InsertB;
        private System.Windows.Forms.Button UpdateB;
        private System.Windows.Forms.Button RemovB;
        private System.Windows.Forms.DataGridView CategoryDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
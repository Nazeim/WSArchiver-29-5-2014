namespace WSArchiver.GUI.UserControls
{
    partial class DocumentDetailsListItem
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
            this.label1 = new System.Windows.Forms.Label();
            this.documentTitleL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fromL = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.creationDateL = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.06863F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.06863F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.06863F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.79412F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.documentTitleL, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.fromL, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 4, 0);
            this.tableLayoutPanel1.Controls.Add(toLabel, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.creationDateL, 7, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(650, 21);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.MouseEnter += new System.EventHandler(this.DocumentDetailsListItem_MouseEnter);
            this.tableLayoutPanel1.MouseLeave += new System.EventHandler(this.DocumentDetailsListItem_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.MouseEnter += new System.EventHandler(this.DocumentDetailsListItem_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.DocumentDetailsListItem_MouseLeave);
            // 
            // documentTitleL
            // 
            this.documentTitleL.AutoSize = true;
            this.documentTitleL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.documentTitleL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.documentTitleL.Location = new System.Drawing.Point(38, 0);
            this.documentTitleL.Name = "documentTitleL";
            this.documentTitleL.Size = new System.Drawing.Size(105, 21);
            this.documentTitleL.TabIndex = 1;
            this.documentTitleL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.documentTitleL.MouseEnter += new System.EventHandler(this.DocumentDetailsListItem_MouseEnter);
            this.documentTitleL.MouseLeave += new System.EventHandler(this.DocumentDetailsListItem_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "From:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.MouseEnter += new System.EventHandler(this.DocumentDetailsListItem_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.DocumentDetailsListItem_MouseLeave);
            // 
            // fromL
            // 
            this.fromL.AutoSize = true;
            this.fromL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fromL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fromL.Location = new System.Drawing.Point(194, 0);
            this.fromL.Name = "fromL";
            this.fromL.Size = new System.Drawing.Size(105, 21);
            this.fromL.TabIndex = 3;
            this.fromL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fromL.MouseEnter += new System.EventHandler(this.DocumentDetailsListItem_MouseEnter);
            this.fromL.MouseLeave += new System.EventHandler(this.DocumentDetailsListItem_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(305, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "To:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.MouseEnter += new System.EventHandler(this.DocumentDetailsListItem_MouseEnter);
            this.label3.MouseLeave += new System.EventHandler(this.DocumentDetailsListItem_MouseLeave);
            // 
            // toLabel
            // 
            toLabel.AutoSize = true;
            toLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            toLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            toLabel.Location = new System.Drawing.Point(335, 0);
            toLabel.Name = "toLabel";
            toLabel.Size = new System.Drawing.Size(105, 21);
            toLabel.TabIndex = 5;
            toLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            toLabel.MouseEnter += new System.EventHandler(this.DocumentDetailsListItem_MouseEnter);
            toLabel.MouseLeave += new System.EventHandler(this.DocumentDetailsListItem_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(446, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Creation Date:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.MouseEnter += new System.EventHandler(this.DocumentDetailsListItem_MouseEnter);
            this.label4.MouseLeave += new System.EventHandler(this.DocumentDetailsListItem_MouseLeave);
            // 
            // creationDateL
            // 
            this.creationDateL.AutoSize = true;
            this.creationDateL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.creationDateL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.creationDateL.Location = new System.Drawing.Point(540, 0);
            this.creationDateL.Name = "creationDateL";
            this.creationDateL.Size = new System.Drawing.Size(107, 21);
            this.creationDateL.TabIndex = 7;
            this.creationDateL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.creationDateL.MouseEnter += new System.EventHandler(this.DocumentDetailsListItem_MouseEnter);
            this.creationDateL.MouseLeave += new System.EventHandler(this.DocumentDetailsListItem_MouseLeave);
            // 
            // DocumentDetailsListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "DocumentDetailsListItem";
            this.Size = new System.Drawing.Size(650, 21);
            this.MouseEnter += new System.EventHandler(this.DocumentDetailsListItem_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.DocumentDetailsListItem_MouseLeave);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label documentTitleL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label fromL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label creationDateL;

    }
}

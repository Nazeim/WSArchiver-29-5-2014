namespace WSArchiver.GUI.UserControls
{
    partial class DateRangeCheckedGroup
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
            this.dateRangeSearchControl1 = new WSArchiver.GUI.UserControls.DateRangeSearchControl();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateRangeSearchControl1);
            this.groupBox1.Size = new System.Drawing.Size(311, 51);
            this.groupBox1.Controls.SetChildIndex(this.dateRangeSearchControl1, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // dateRangeSearchControl1
            // 
            this.dateRangeSearchControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateRangeSearchControl1.FilterType = Library.Common.Search.Filter.FilterEnum.DOC_REGISTRATION_NUMBER;
            this.dateRangeSearchControl1.Location = new System.Drawing.Point(5, 11);
            this.dateRangeSearchControl1.Name = "dateRangeSearchControl1";
            this.dateRangeSearchControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateRangeSearchControl1.Size = new System.Drawing.Size(300, 36);
            this.dateRangeSearchControl1.TabIndex = 1;
            // 
            // DateRangeCheckedGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "DateRangeCheckedGroup";
            this.Size = new System.Drawing.Size(311, 51);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public DateRangeSearchControl dateRangeSearchControl1;

    }
}

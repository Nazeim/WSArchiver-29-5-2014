namespace WSArchiver.GUI.UserControls
{
    partial class SinglelineStringCheckedGroup
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
            this.singleLineStringSearchControl1 = new WSArchiver.GUI.UserControls.SingleLineStringSearchControl();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.singleLineStringSearchControl1);
            this.groupBox1.Size = new System.Drawing.Size(310, 42);
            this.groupBox1.Controls.SetChildIndex(this.singleLineStringSearchControl1, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // singleLineStringSearchControl1
            // 
            this.singleLineStringSearchControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.singleLineStringSearchControl1.FilterType = Library.Common.Search.Filter.FilterEnum.DOC_REGISTRATION_NUMBER;
            this.singleLineStringSearchControl1.Location = new System.Drawing.Point(6, 19);
            this.singleLineStringSearchControl1.Name = "singleLineStringSearchControl1";
            this.singleLineStringSearchControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.singleLineStringSearchControl1.Size = new System.Drawing.Size(301, 20);
            this.singleLineStringSearchControl1.TabIndex = 1;
            
            // 
            // SinglelineStringCheckedGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "SinglelineStringCheckedGroup";
            this.Size = new System.Drawing.Size(310, 42);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public SingleLineStringSearchControl singleLineStringSearchControl1;

    }
}

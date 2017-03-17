namespace WSArchiver.GUI.UserControls
{
    partial class MultilineStringCheckedGroup
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
            this.multilineStringSearchControl1 = new WSArchiver.GUI.UserControls.MultilineStringSearchControl();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.multilineStringSearchControl1);
            this.groupBox1.Controls.SetChildIndex(this.multilineStringSearchControl1, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // multilineStringSearchControl1
            // 
            this.multilineStringSearchControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.multilineStringSearchControl1.FilterType = Library.Common.Search.Filter.FilterEnum.DOC_REGISTRATION_NUMBER;
            this.multilineStringSearchControl1.Location = new System.Drawing.Point(5, 19);
            this.multilineStringSearchControl1.Name = "multilineStringSearchControl1";
            this.multilineStringSearchControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.multilineStringSearchControl1.Size = new System.Drawing.Size(300, 65);
            this.multilineStringSearchControl1.TabIndex = 1;
            
            // 
            // MultilineStringCheckedGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "MultilineStringCheckedGroup";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public MultilineStringSearchControl multilineStringSearchControl1;

    }
}

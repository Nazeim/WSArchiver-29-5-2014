namespace WSArchiver.GUI.UserControls
{
    partial class NumericUpDownCheckedGroup
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
            this.numericUpDownSearchControl1 = new WSArchiver.GUI.UserControls.NumericUpDownSearchControl();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownSearchControl1);
            this.groupBox1.Size = new System.Drawing.Size(155, 43);
            this.groupBox1.Controls.SetChildIndex(this.numericUpDownSearchControl1, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.Location = new System.Drawing.Point(72, 0);
            // 
            // numericUpDownSearchControl1
            // 
            this.numericUpDownSearchControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownSearchControl1.FilterType = Library.Common.Search.Filter.FilterEnum.DOC_REGISTRATION_NUMBER;
            this.numericUpDownSearchControl1.Location = new System.Drawing.Point(6, 16);
            this.numericUpDownSearchControl1.Name = "numericUpDownSearchControl1";
            this.numericUpDownSearchControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numericUpDownSearchControl1.Size = new System.Drawing.Size(143, 23);
            this.numericUpDownSearchControl1.TabIndex = 1;
            
            this.numericUpDownSearchControl1.Value = 0;
            // 
            // NumericUpDownCheckedGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "NumericUpDownCheckedGroup";
            this.Size = new System.Drawing.Size(155, 43);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private NumericUpDownSearchControl numericUpDownSearchControl1;


    }
}

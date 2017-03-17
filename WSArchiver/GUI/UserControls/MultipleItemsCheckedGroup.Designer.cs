namespace WSArchiver.GUI.UserControls
{
    partial class MultipleItemsCheckedGroup
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
            this.multipleItemsSearchControl1 = new WSArchiver.GUI.UserControls.MultipleItemsSearchControl();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.multipleItemsSearchControl1);
            this.groupBox1.Size = new System.Drawing.Size(389, 105);
            this.groupBox1.Controls.SetChildIndex(this.multipleItemsSearchControl1, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.Location = new System.Drawing.Point(305, 0);
            this.toolTip1.SetToolTip(this.checkBox1, "إيجاد الوثائق التي تنتمي إلى أيّ من التصنيفات المختارة");
            // 
            // multipleItemsSearchControl1
            // 
            this.multipleItemsSearchControl1.FilterType = Library.Common.Search.Filter.FilterEnum.DOC_REGISTRATION_NUMBER;
            this.multipleItemsSearchControl1.Location = new System.Drawing.Point(4, 16);
            this.multipleItemsSearchControl1.Name = "multipleItemsSearchControl1";
            this.multipleItemsSearchControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.multipleItemsSearchControl1.Size = new System.Drawing.Size(381, 83);
            this.multipleItemsSearchControl1.TabIndex = 1;
            this.toolTip1.SetToolTip(this.multipleItemsSearchControl1, "إيجاد الوثائق التي تنتمي إلى أيّ من التصنيفات المختارة");
            // 
            // MultipleItemsCheckedGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "MultipleItemsCheckedGroup";
            this.Size = new System.Drawing.Size(389, 105);
            this.toolTip1.SetToolTip(this, "إيجاد الوثائق التي تنتمي إلى أيّ من التصنيفات المختارة");
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public MultipleItemsSearchControl multipleItemsSearchControl1;
        private System.Windows.Forms.ToolTip toolTip1;

    }
}

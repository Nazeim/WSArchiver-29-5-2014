namespace WSArchiver.GUI.UserControls
{
    partial class DateRangeSearchControl
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
            this.startDTP = new System.Windows.Forms.DateTimePicker();
            this.endDTP = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startDTP
            // 
            this.startDTP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startDTP.Location = new System.Drawing.Point(156, 16);
            this.startDTP.Name = "startDTP";
            this.startDTP.RightToLeftLayout = true;
            this.startDTP.Size = new System.Drawing.Size(144, 20);
            this.startDTP.TabIndex = 0;
            this.startDTP.ValueChanged += new System.EventHandler(this.startDTP_ValueChanged);
            // 
            // endDTP
            // 
            this.endDTP.Location = new System.Drawing.Point(0, 16);
            this.endDTP.Name = "endDTP";
            this.endDTP.RightToLeftLayout = true;
            this.endDTP.Size = new System.Drawing.Size(144, 20);
            this.endDTP.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "من:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "إلى:";
            // 
            // DateRangeSearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.endDTP);
            this.Controls.Add(this.startDTP);
            this.Name = "DateRangeSearchControl";
            this.Size = new System.Drawing.Size(300, 36);
            this.Load += new System.EventHandler(this.DateRangeSearchControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker startDTP;
        private System.Windows.Forms.DateTimePicker endDTP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

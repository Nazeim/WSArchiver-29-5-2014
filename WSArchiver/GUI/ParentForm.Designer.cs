namespace WSArchiver.GUI
{
    partial class ParentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParentForm));
            this.exitB = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripProgressBar2 = new System.Windows.Forms.ToolStripProgressBar();
            this.statusStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.rowsCountStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.currentUserStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitB
            // 
            this.exitB.Location = new System.Drawing.Point(478, 275);
            this.exitB.Name = "exitB";
            this.exitB.Size = new System.Drawing.Size(75, 23);
            this.exitB.TabIndex = 0;
            this.exitB.Text = "خروج";
            this.exitB.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripProgressBar2,
            this.statusStripLabel,
            this.rowsCountStripLabel,
            this.currentUserStripLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 313);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(565, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.MarqueeAnimationSpeed = 20;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.RightToLeftLayout = true;
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripProgressBar2
            // 
            this.toolStripProgressBar2.MarqueeAnimationSpeed = 30;
            this.toolStripProgressBar2.Name = "toolStripProgressBar2";
            this.toolStripProgressBar2.RightToLeftLayout = true;
            this.toolStripProgressBar2.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar2.Visible = false;
            // 
            // statusStripLabel
            // 
            this.statusStripLabel.BackColor = System.Drawing.Color.Transparent;
            this.statusStripLabel.Name = "statusStripLabel";
            this.statusStripLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // rowsCountStripLabel
            // 
            this.rowsCountStripLabel.BackColor = System.Drawing.Color.Transparent;
            this.rowsCountStripLabel.Name = "rowsCountStripLabel";
            this.rowsCountStripLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // currentUserStripLabel
            // 
            this.currentUserStripLabel.BackColor = System.Drawing.Color.Transparent;
            this.currentUserStripLabel.Name = "currentUserStripLabel";
            this.currentUserStripLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(565, 335);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.exitB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ParentForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ParentForm_FormClosing);
            this.Load += new System.EventHandler(this.ParentForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button exitB;
        protected System.Windows.Forms.StatusStrip statusStrip1;
        protected System.Windows.Forms.ToolStripStatusLabel currentUserStripLabel;
        protected System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        protected System.Windows.Forms.ToolStripStatusLabel statusStripLabel;
        protected System.Windows.Forms.ToolStripStatusLabel rowsCountStripLabel;
        protected System.Windows.Forms.ToolStripProgressBar toolStripProgressBar2;
        protected System.Windows.Forms.ToolTip toolTip2;
    }
}


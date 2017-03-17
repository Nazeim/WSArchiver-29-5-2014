namespace WSArchiver.GUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.treeControl1 = new WSArchiver.GUI.UserControls.TreeControl();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "address_16.png");
            this.imageList1.Images.SetKeyName(1, "block_16.png");
            this.imageList1.Images.SetKeyName(2, "warning_16.png");
            this.imageList1.Images.SetKeyName(3, "calendar_16.png");
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(194, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // treeControl1
            // 
            this.treeControl1.ContainerImageIndex = 1;
            this.treeControl1.ContainerName = "مجلد";
            this.treeControl1.ControlLanguage = WSArchiver.GUI.UserControls.Language.ARABIC;
            this.treeControl1.CutContainerImageIndex = 2;
            this.treeControl1.CutLeafImageIndex = 3;
            this.treeControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeControl1.ImageList = this.imageList1;
            this.treeControl1.LeafImageIndex = 0;
            this.treeControl1.LeafName = "مستند";
            this.treeControl1.Location = new System.Drawing.Point(0, 0);
            this.treeControl1.Name = "treeControl1";
            this.treeControl1.Size = new System.Drawing.Size(194, 390);
            this.treeControl1.TabIndex = 0;
            this.treeControl1.NodeExpanded += new System.EventHandler<WSArchiver.GUI.UserControls.TreeControl.ContainerEventArgs>(this.treeControl1_NodeExpanded);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 390);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.treeControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.TreeControl treeControl1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
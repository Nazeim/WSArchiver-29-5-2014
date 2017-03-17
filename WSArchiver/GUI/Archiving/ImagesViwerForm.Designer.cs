using MigraDoc.Rendering.Forms;
using System.Windows.Forms;
using System.Drawing;

namespace WSArchiver.GUI.Archiving
{
    partial class ImagesViwerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImagesViwerForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.preview = new WSArchiver.GUI.UserControls.NoWheelDocumentPreview();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.التقريبToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.كاملالصفحةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.initializerBGW = new System.ComponentModel.BackgroundWorker();
            this.zoomInB = new System.Windows.Forms.Button();
            this.zoomOutB = new System.Windows.Forms.Button();
            this.fullPageB = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saverBGW = new System.ComponentModel.BackgroundWorker();
            this.printerBGW = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitB
            // 
            this.exitB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitB.BackgroundImage = global::WSArchiver.Properties.Resources.exit;
            this.exitB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitB.Location = new System.Drawing.Point(730, 525);
            this.exitB.Size = new System.Drawing.Size(75, 40);
            this.exitB.Text = "";
            this.exitB.Click += new System.EventHandler(this.exitB_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.preview);
            this.panel1.Location = new System.Drawing.Point(12, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 437);
            this.panel1.TabIndex = 2;
            // 
            // preview
            // 
            this.preview.BackColor = System.Drawing.Color.Gray;
            this.preview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.preview.Ddl = null;
            this.preview.DesktopColor = System.Drawing.SystemColors.ControlDark;
            this.preview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.preview.Document = null;
            this.preview.Location = new System.Drawing.Point(0, 0);
            this.preview.Name = "preview";
            this.preview.Page = 0;
            this.preview.PageColor = System.Drawing.Color.White;
            this.preview.PageSize = new System.Drawing.Size(595, 842);
            this.preview.PrivateFonts = null;
            this.preview.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.preview.Size = new System.Drawing.Size(793, 437);
            this.preview.TabIndex = 0;
            this.preview.Zoom = MigraDoc.Rendering.Forms.Zoom.FullPage;
            this.preview.ZoomPercent = 36;
            this.preview.PageChanged += new MigraDoc.Rendering.Forms.PagePreviewEventHandler(this.preview_PageChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(817, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.fileToolStripMenuItem.Text = "ملف";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(154, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.saveToolStripMenuItem.Text = "حفظ";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(154, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.printToolStripMenuItem.Text = "طباعة";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.miPrint_Click);
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.printPreviewToolStripMenuItem.Text = "معاينة قبل الطباعة";
            this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.miPreview_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(154, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.exitToolStripMenuItem.Text = "خروج";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nextToolStripMenuItem,
            this.previousToolStripMenuItem,
            this.التقريبToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.toolsToolStripMenuItem.Text = "أدوات";
            this.toolsToolStripMenuItem.Click += new System.EventHandler(this.toolsToolStripMenuItem_Click);
            // 
            // nextToolStripMenuItem
            // 
            this.nextToolStripMenuItem.Name = "nextToolStripMenuItem";
            this.nextToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.nextToolStripMenuItem.Text = "الصفحة التالية";
            this.nextToolStripMenuItem.Click += new System.EventHandler(this.nextToolStripMenuItem_Click);
            // 
            // previousToolStripMenuItem
            // 
            this.previousToolStripMenuItem.Name = "previousToolStripMenuItem";
            this.previousToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.previousToolStripMenuItem.Text = "الصفحة السابقة";
            this.previousToolStripMenuItem.Click += new System.EventHandler(this.previousToolStripMenuItem_Click);
            // 
            // التقريبToolStripMenuItem
            // 
            this.التقريبToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomInToolStripMenuItem,
            this.zoomOutToolStripMenuItem,
            this.كاملالصفحةToolStripMenuItem});
            this.التقريبToolStripMenuItem.Name = "التقريبToolStripMenuItem";
            this.التقريبToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.التقريبToolStripMenuItem.Text = "التقريب";
            // 
            // zoomInToolStripMenuItem
            // 
            this.zoomInToolStripMenuItem.Image = global::WSArchiver.Properties.Resources.gnome_zoom_in;
            this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            this.zoomInToolStripMenuItem.ShortcutKeyDisplayString = "\'+\'+Ctrl";
            this.zoomInToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
            this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.zoomInToolStripMenuItem.Text = "تقريب";
            this.zoomInToolStripMenuItem.Click += new System.EventHandler(this.zoomInB_Click);
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.Image = global::WSArchiver.Properties.Resources.gnome_zoom_out__1_;
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.ShortcutKeyDisplayString = "\'-\'+Ctrl";
            this.zoomOutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus)));
            this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.zoomOutToolStripMenuItem.Text = "تبعيد";
            this.zoomOutToolStripMenuItem.Click += new System.EventHandler(this.zoomOutB_Click);
            // 
            // كاملالصفحةToolStripMenuItem
            // 
            this.كاملالصفحةToolStripMenuItem.Image = global::WSArchiver.Properties.Resources.gnome_zoom_fit_best;
            this.كاملالصفحةToolStripMenuItem.Name = "كاملالصفحةToolStripMenuItem";
            this.كاملالصفحةToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.كاملالصفحةToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.كاملالصفحةToolStripMenuItem.Text = "كامل الصفحة";
            this.كاملالصفحةToolStripMenuItem.Click += new System.EventHandler(this.fullPageB_Click);
            // 
            // initializerBGW
            // 
            this.initializerBGW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.initializerBGW_DoWork);
            this.initializerBGW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.initializerBGW_RunWorkerCompleted);
            // 
            // zoomInB
            // 
            this.zoomInB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("zoomInB.BackgroundImage")));
            this.zoomInB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.zoomInB.Location = new System.Drawing.Point(12, 35);
            this.zoomInB.Name = "zoomInB";
            this.zoomInB.Size = new System.Drawing.Size(45, 41);
            this.zoomInB.TabIndex = 4;
            this.toolTip2.SetToolTip(this.zoomInB, "تقريب");
            this.zoomInB.UseVisualStyleBackColor = true;
            this.zoomInB.Click += new System.EventHandler(this.zoomInB_Click);
            // 
            // zoomOutB
            // 
            this.zoomOutB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("zoomOutB.BackgroundImage")));
            this.zoomOutB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.zoomOutB.Location = new System.Drawing.Point(114, 35);
            this.zoomOutB.Name = "zoomOutB";
            this.zoomOutB.Size = new System.Drawing.Size(45, 41);
            this.zoomOutB.TabIndex = 5;
            this.toolTip2.SetToolTip(this.zoomOutB, "تبعيد");
            this.zoomOutB.UseVisualStyleBackColor = true;
            this.zoomOutB.Click += new System.EventHandler(this.zoomOutB_Click);
            // 
            // fullPageB
            // 
            this.fullPageB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fullPageB.BackgroundImage")));
            this.fullPageB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.fullPageB.Location = new System.Drawing.Point(63, 35);
            this.fullPageB.Name = "fullPageB";
            this.fullPageB.Size = new System.Drawing.Size(45, 41);
            this.fullPageB.TabIndex = 6;
            this.toolTip2.SetToolTip(this.fullPageB, "كامل الصفحة");
            this.fullPageB.UseVisualStyleBackColor = true;
            this.fullPageB.Click += new System.EventHandler(this.fullPageB_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "JPEG File (*.JPEG)|*.JPEG|PDF File (*.PDF)|*.PDF";
            // 
            // saverBGW
            // 
            this.saverBGW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.saverBGW_DoWork);
            this.saverBGW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.saverBGW_RunWorkerCompleted);
            // 
            // printerBGW
            // 
            this.printerBGW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.printerBGW_DoWork);
            this.printerBGW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.printerBGW_RunWorkerCompleted);
            // 
            // ImagesViwerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 590);
            this.Controls.Add(this.fullPageB);
            this.Controls.Add(this.zoomOutB);
            this.Controls.Add(this.zoomInB);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ImagesViwerForm";
            this.Text = "مستعرض ملفات/صفحات المستند";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.exitB, 0);
            this.Controls.SetChildIndex(this.menuStrip1, 0);
            this.Controls.SetChildIndex(this.zoomInB, 0);
            this.Controls.SetChildIndex(this.zoomOutB, 0);
            this.Controls.SetChildIndex(this.fullPageB, 0);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem nextToolStripMenuItem;
        private ToolStripMenuItem previousToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker initializerBGW;
        private Button zoomInB;
        private Button zoomOutB;
        private Button fullPageB;
        private ToolStripMenuItem التقريبToolStripMenuItem;
        private ToolStripMenuItem zoomInToolStripMenuItem;
        private ToolStripMenuItem zoomOutToolStripMenuItem;
        private ToolStripMenuItem كاملالصفحةToolStripMenuItem;
        private SaveFileDialog saveFileDialog1;
        private System.ComponentModel.BackgroundWorker saverBGW;
        private System.ComponentModel.BackgroundWorker printerBGW;
    }
}
namespace WSArchiver.GUI.UserControls
{
    partial class TreeControl
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
            this.components = new System.ComponentModel.Container();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.containerMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leafToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.containerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.collapseAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expandAllStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelCuttoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leafMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openLeafToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cutLeafToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelCutLeafToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.renameToolLeafStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteLeafToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.rootMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.NewRootToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewLeafRoottoolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.NewContainerRootTtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.CollapseAllRootToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExpandAllRootToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.CancelCutRootToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteRootToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.RenameRootToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.containerMenuStrip.SuspendLayout();
            this.leafMenuStrip.SuspendLayout();
            this.rootMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.LabelEdit = true;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(175, 317);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeView1_AfterLabelEdit);
            this.treeView1.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeExpand);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            this.treeView1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.treeView1_PreviewKeyDown);
            // 
            // containerMenuStrip
            // 
            this.containerMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripSeparator1,
            this.collapseAllToolStripMenuItem,
            this.expandAllStripMenuItem,
            this.toolStripSeparator5,
            this.cutToolStripMenuItem,
            this.cancelCuttoolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator3,
            this.renameToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.containerMenuStrip.Name = "containerMenuStrip";
            this.containerMenuStrip.Size = new System.Drawing.Size(157, 198);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leafToolStripMenuItem,
            this.containerToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // leafToolStripMenuItem
            // 
            this.leafToolStripMenuItem.Name = "leafToolStripMenuItem";
            this.leafToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.leafToolStripMenuItem.Text = "Leaf";
            this.leafToolStripMenuItem.Click += new System.EventHandler(this.leafToolStripMenuItem_Click);
            // 
            // containerToolStripMenuItem
            // 
            this.containerToolStripMenuItem.Name = "containerToolStripMenuItem";
            this.containerToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.containerToolStripMenuItem.Text = "Container";
            this.containerToolStripMenuItem.Click += new System.EventHandler(this.containerToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(153, 6);
            // 
            // collapseAllToolStripMenuItem
            // 
            this.collapseAllToolStripMenuItem.Name = "collapseAllToolStripMenuItem";
            this.collapseAllToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.collapseAllToolStripMenuItem.Text = "Collapse All";
            this.collapseAllToolStripMenuItem.Click += new System.EventHandler(this.collapseAllToolStripMenuItem_Click);
            // 
            // expandAllStripMenuItem
            // 
            this.expandAllStripMenuItem.Name = "expandAllStripMenuItem";
            this.expandAllStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.expandAllStripMenuItem.Text = "Expand All";
            this.expandAllStripMenuItem.Click += new System.EventHandler(this.expandAllStripMenuItem1_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(153, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // cancelCuttoolStripMenuItem
            // 
            this.cancelCuttoolStripMenuItem.Enabled = false;
            this.cancelCuttoolStripMenuItem.Name = "cancelCuttoolStripMenuItem";
            this.cancelCuttoolStripMenuItem.ShortcutKeyDisplayString = "Esc";
            this.cancelCuttoolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.cancelCuttoolStripMenuItem.Text = "Cancel Cut";
            this.cancelCuttoolStripMenuItem.Click += new System.EventHandler(this.cancelCuttoolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Enabled = false;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(153, 6);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.renameToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.renameToolStripMenuItem.Text = "Rename";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // leafMenuStrip
            // 
            this.leafMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openLeafToolStripMenuItem,
            this.toolStripSeparator2,
            this.cutLeafToolStripMenuItem2,
            this.cancelCutLeafToolStripMenuItem,
            this.toolStripSeparator4,
            this.renameToolLeafStripMenuItem,
            this.deleteLeafToolStripMenuItem5});
            this.leafMenuStrip.Name = "leafMenuStrip";
            this.leafMenuStrip.Size = new System.Drawing.Size(133, 126);
            // 
            // openLeafToolStripMenuItem
            // 
            this.openLeafToolStripMenuItem.Name = "openLeafToolStripMenuItem";
            this.openLeafToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.openLeafToolStripMenuItem.Text = "Open";
            this.openLeafToolStripMenuItem.Click += new System.EventHandler(this.openLeafToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(129, 6);
            // 
            // cutLeafToolStripMenuItem2
            // 
            this.cutLeafToolStripMenuItem2.Name = "cutLeafToolStripMenuItem2";
            this.cutLeafToolStripMenuItem2.Size = new System.Drawing.Size(132, 22);
            this.cutLeafToolStripMenuItem2.Text = "Cut";
            this.cutLeafToolStripMenuItem2.Click += new System.EventHandler(this.cutLeafToolStripMenuItem2_Click);
            // 
            // cancelCutLeafToolStripMenuItem
            // 
            this.cancelCutLeafToolStripMenuItem.Enabled = false;
            this.cancelCutLeafToolStripMenuItem.Name = "cancelCutLeafToolStripMenuItem";
            this.cancelCutLeafToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.cancelCutLeafToolStripMenuItem.Text = "Cancel Cut";
            this.cancelCutLeafToolStripMenuItem.Click += new System.EventHandler(this.cancelCutLeafToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(129, 6);
            // 
            // renameToolLeafStripMenuItem
            // 
            this.renameToolLeafStripMenuItem.Name = "renameToolLeafStripMenuItem";
            this.renameToolLeafStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.renameToolLeafStripMenuItem.Text = "Rename";
            this.renameToolLeafStripMenuItem.Click += new System.EventHandler(this.renameToolLeafStripMenuItem_Click);
            // 
            // deleteLeafToolStripMenuItem5
            // 
            this.deleteLeafToolStripMenuItem5.Name = "deleteLeafToolStripMenuItem5";
            this.deleteLeafToolStripMenuItem5.Size = new System.Drawing.Size(132, 22);
            this.deleteLeafToolStripMenuItem5.Text = "Delete";
            this.deleteLeafToolStripMenuItem5.Click += new System.EventHandler(this.deleteLeafToolStripMenuItem5_Click);
            // 
            // rootMenuStrip
            // 
            this.rootMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewRootToolStripMenuItem,
            this.toolStripSeparator6,
            this.CollapseAllRootToolStripMenuItem,
            this.ExpandAllRootToolStripMenuItem,
            this.toolStripSeparator7,
            this.CancelCutRootToolStripMenuItem7,
            this.PasteRootToolStripMenuItem,
            this.toolStripSeparator8,
            this.RenameRootToolStripMenuItem});
            this.rootMenuStrip.Name = "containerMenuStrip";
            this.rootMenuStrip.Size = new System.Drawing.Size(157, 176);
            // 
            // NewRootToolStripMenuItem
            // 
            this.NewRootToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewLeafRoottoolStripMenuItem2,
            this.NewContainerRootTtoolStripMenuItem});
            this.NewRootToolStripMenuItem.Name = "NewRootToolStripMenuItem";
            this.NewRootToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.NewRootToolStripMenuItem.Text = "New";
            // 
            // NewLeafRoottoolStripMenuItem2
            // 
            this.NewLeafRoottoolStripMenuItem2.Name = "NewLeafRoottoolStripMenuItem2";
            this.NewLeafRoottoolStripMenuItem2.Size = new System.Drawing.Size(126, 22);
            this.NewLeafRoottoolStripMenuItem2.Text = "Leaf";
            this.NewLeafRoottoolStripMenuItem2.Click += new System.EventHandler(this.leafToolStripMenuItem_Click);
            // 
            // NewContainerRootTtoolStripMenuItem
            // 
            this.NewContainerRootTtoolStripMenuItem.Name = "NewContainerRootTtoolStripMenuItem";
            this.NewContainerRootTtoolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.NewContainerRootTtoolStripMenuItem.Text = "Container";
            this.NewContainerRootTtoolStripMenuItem.Click += new System.EventHandler(this.containerToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(153, 6);
            // 
            // CollapseAllRootToolStripMenuItem
            // 
            this.CollapseAllRootToolStripMenuItem.Name = "CollapseAllRootToolStripMenuItem";
            this.CollapseAllRootToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.CollapseAllRootToolStripMenuItem.Text = "Collapse All";
            this.CollapseAllRootToolStripMenuItem.Click += new System.EventHandler(this.collapseAllToolStripMenuItem_Click);
            // 
            // ExpandAllRootToolStripMenuItem
            // 
            this.ExpandAllRootToolStripMenuItem.Name = "ExpandAllRootToolStripMenuItem";
            this.ExpandAllRootToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.ExpandAllRootToolStripMenuItem.Text = "Expand All";
            this.ExpandAllRootToolStripMenuItem.Click += new System.EventHandler(this.expandAllStripMenuItem1_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(153, 6);
            // 
            // CancelCutRootToolStripMenuItem7
            // 
            this.CancelCutRootToolStripMenuItem7.Enabled = false;
            this.CancelCutRootToolStripMenuItem7.Name = "CancelCutRootToolStripMenuItem7";
            this.CancelCutRootToolStripMenuItem7.ShortcutKeyDisplayString = "Esc";
            this.CancelCutRootToolStripMenuItem7.Size = new System.Drawing.Size(156, 22);
            this.CancelCutRootToolStripMenuItem7.Text = "Cancel Cut";
            this.CancelCutRootToolStripMenuItem7.Click += new System.EventHandler(this.cancelCutLeafToolStripMenuItem_Click);
            // 
            // PasteRootToolStripMenuItem
            // 
            this.PasteRootToolStripMenuItem.Enabled = false;
            this.PasteRootToolStripMenuItem.Name = "PasteRootToolStripMenuItem";
            this.PasteRootToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.PasteRootToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.PasteRootToolStripMenuItem.Text = "Paste";
            this.PasteRootToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(153, 6);
            // 
            // RenameRootToolStripMenuItem
            // 
            this.RenameRootToolStripMenuItem.Name = "RenameRootToolStripMenuItem";
            this.RenameRootToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.RenameRootToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.RenameRootToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.RenameRootToolStripMenuItem.Text = "Rename";
            this.RenameRootToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            // 
            // TreeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeView1);
            this.Name = "TreeControl";
            this.Size = new System.Drawing.Size(175, 317);
            this.containerMenuStrip.ResumeLayout(false);
            this.leafMenuStrip.ResumeLayout(false);
            this.rootMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ContextMenuStrip containerMenuStrip;
        private System.Windows.Forms.ContextMenuStrip leafMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem collapseAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leafToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem containerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem expandAllStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cancelCuttoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openLeafToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem cutLeafToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cancelCutLeafToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem renameToolLeafStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteLeafToolStripMenuItem5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ContextMenuStrip rootMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem NewRootToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewLeafRoottoolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem NewContainerRootTtoolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem CollapseAllRootToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExpandAllRootToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem CancelCutRootToolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem PasteRootToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem RenameRootToolStripMenuItem;

    }
}

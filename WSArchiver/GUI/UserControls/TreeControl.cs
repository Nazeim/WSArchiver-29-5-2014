using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Library.Common.Composite;
using WSArchiver.GUI.Tree;
using System.Collections;


namespace WSArchiver.GUI.UserControls
{
    public partial class TreeControl : UserControl, IMultiLingualControl
    {
        private IComposite root;
        private TreeNode cutNode;
        private TreeNode newNode;
        private Language currentLanguage = Language.ENGLISH;

        private TreeNode SelectedNode
        {
            get
            {
                return treeView1.SelectedNode;
            }
            set
            {
                treeView1.SelectedNode = value;
            }
        }

        public Language ControlLanguage
        {
            get
            {
                return currentLanguage;
            }
            set
            {
                currentLanguage = value;
                if (currentLanguage == Language.ARABIC)
                {
                    treeView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                    //treeView1.RightToLeftLayout = true;
                    SetArabicStrips();
                }
                else
                {
                    treeView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
                    //treeView1.RightToLeftLayout = false;
                    SetEngilshStrips();
                }
            }
        }

        #region Container And Leaf Event Args

        public class LeafEventArgs : EventArgs
        {
            private ILeaf leaf;
            private bool cancel = false;

            public bool Cancel
            {
                get { return cancel; }
                set { cancel = value; }
            }
            public ILeaf Leaf
            {
                get { return leaf; }
            }
            public LeafEventArgs()
            { }
            public LeafEventArgs(ILeaf leaf)
            {
                this.leaf = leaf;
            }
        }
        public class ContainerEventArgs : EventArgs
        {
            private IComposite node;
            private bool cancel = false;

            public bool Cancel
            {
                get { return cancel; }
                set { cancel = value; }
            }
            public IComposite Node
            {
                get { return node; }
            }
            public ContainerEventArgs()
            { }
            public ContainerEventArgs(IComposite node)
            {
                this.node = node;
            }
        }
        public class LeafCreatedEventArgs : ContainerEventArgs
        {
            LeafTreeNode leaf;
            public LeafCreatedEventArgs()
            { }
            public LeafCreatedEventArgs(LeafTreeNode leaf, IComposite composite)
                : base(composite)
            {
                this.leaf = Leaf;
            }


            public LeafTreeNode Leaf
            {
                get { return leaf; }
                set { leaf = value; }
            }
        }
        public class ContainerCreatedEventArgs : ContainerEventArgs
        {
            ContainerTreeNode newComposite;
            public ContainerCreatedEventArgs()
            { }
            public ContainerCreatedEventArgs(ContainerTreeNode composite, IComposite parent)
                : base(parent)
            {
                newComposite = composite;
            }

            public ContainerTreeNode NewComposite
            {
                get { return newComposite; }
                set { newComposite = value; }
            }

        }
        #endregion

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            SelectedNode = e.Node;
        }

        #region Images
        int containerImgIndex;
        int leafImgIndex;
        int cutCntainerImgIndex;
        int cutLeafImgIndex;

        public int CutLeafImageIndex
        {
            get { return cutLeafImgIndex; }
            set { cutLeafImgIndex = value; }

        }
        public int CutContainerImageIndex
        {
            get { return cutCntainerImgIndex; }
            set { cutCntainerImgIndex = value; }
        }
        public int LeafImageIndex
        {
            get { return leafImgIndex; }
            set { leafImgIndex = value; }
        }
        public int ContainerImageIndex
        {
            get { return containerImgIndex; }
            set { containerImgIndex = value; }
        }
        public ImageList ImageList
        {
            set { treeView1.ImageList = value; }
            get { return treeView1.ImageList; }

        }

        private void RefreshImagesIndexes(TreeNode node, bool isCutNode)
        {
            if (node is ContainerTreeNode)
            {
                if (isCutNode)
                {
                    SetImageIndexes(node, cutCntainerImgIndex);
                }
                else
                {
                    SetImageIndexes(node, containerImgIndex);
                }
            }
            else
            {
                if (isCutNode)
                {
                    SetImageIndexes(node, cutLeafImgIndex);
                }
                else
                {
                    SetImageIndexes(node, leafImgIndex);
                }
            }
        }
        private void SetImageIndexes(TreeNode node, int index)
        {
            node.ImageIndex = index;
            node.SelectedImageIndex = index;
        }
        #endregion

        #region Node Expanded Event
        public event EventHandler<ContainerEventArgs> NodeExpanded;
        protected void OnNodeExpanded(ContainerEventArgs e)
        {
            if (NodeExpanded != null)
                NodeExpanded(this, e);
        }
        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node == cutNode)
            {
                e.Cancel = true;
                return;
            }

            if (!((bool)e.Node.Tag))
                return;

            ContainerEventArgs ee = new ContainerEventArgs((e.Node as ContainerTreeNode).Container);
            OnNodeExpanded(ee);

            if (ee.Cancel)
                return;

            e.Node.Nodes.Clear();
            BuildBranch((e.Node as ContainerTreeNode), true);
            e.Node.Tag = false;
        }
        #endregion

        void treeView1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (SelectedNode != null)
                    if (SelectedNode is LeafTreeNode)
                    {
                        LeafEventArgs ee = new LeafEventArgs((SelectedNode as LeafTreeNode).Leaf);
                        OnLeafDoubleClicked(ee);
                    }
                    else
                    {
                        if (SelectedNode.IsExpanded)
                            SelectedNode.Collapse();
                        else
                            SelectedNode.Expand();
                    }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                CancelCut();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                if (SelectedNode is ContainerTreeNode)
                {
                    if (SelectedNode != treeView1.Nodes[0])
                        ContainerDelete();
                }
                else
                    LeafDelete();
            }
        }

        #region Leaf Double Click And Open Event

        public event EventHandler<LeafEventArgs> LeafDoubleClicked;
        protected void OnLeafDoubleClicked(LeafEventArgs e)
        {
            if (LeafDoubleClicked != null)
                LeafDoubleClicked(this, e);
        }

        private void openLeafToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LeafEventArgs ee = new LeafEventArgs((SelectedNode as LeafTreeNode).Leaf);
            OnLeafDoubleClicked(ee);

        }

        void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node is LeafTreeNode)
            {
                LeafEventArgs ee = new LeafEventArgs((e.Node as LeafTreeNode).Leaf);
                OnLeafDoubleClicked(ee);
            }
        }
        #endregion

        #region Context Menu Strips
        class MenuLabels
        {
            public const string ArNew = "جديد";
            public const string ArCollapseAll = "طي الكل";
            public const string ArExpandAll = "توسيع الكل";
            public const string ArRename = "إعادة تسمية";
            public const string ArCut = "قص";
            public const string ArCancelCut = "إلغاء القص";
            public const string ArPaste = "لصق";
            public const string ArOpen = "فتح";
            public const string ArDelete = "حذف";

            public const string EnNew = "New";
            public const string EnCollapseAll = "Collapse All";
            public const string EnExpandAll = "Expand All";
            public const string EnRename = "Rename";
            public const string EnCut = "Cut";
            public const string EnCancelCut = "Cancel Cut";
            public const string EnPaste = "Paste";
            public const string EnOpen = "Open";
            public const string EnDelete = "Delete";
        }

        string leafName;
        string containerName;

        public string LeafName
        {
            get { return leafName; }
            set
            {
                leafName = value;
                leafToolStripMenuItem.Text = LeafName;
                NewLeafRoottoolStripMenuItem2.Text = LeafName;
            }
        }
        public string ContainerName
        {
            get { return containerName; }
            set
            {
                containerName = value;
                containerToolStripMenuItem.Text = ContainerName;
                NewContainerRootTtoolStripMenuItem.Text = ContainerName;

            }
        }

        private void SetArabicStrips()
        {
            newToolStripMenuItem.Text = MenuLabels.ArNew;
            collapseAllToolStripMenuItem.Text = MenuLabels.ArCollapseAll;
            expandAllStripMenuItem.Text = MenuLabels.ArExpandAll;
            renameToolStripMenuItem.Text = MenuLabels.ArRename;
            cutToolStripMenuItem.Text = MenuLabels.ArCut;
            cancelCuttoolStripMenuItem.Text = MenuLabels.ArCancelCut;
            pasteToolStripMenuItem.Text = MenuLabels.ArPaste;
            deleteToolStripMenuItem.Text = MenuLabels.ArDelete;

            openLeafToolStripMenuItem.Text = MenuLabels.ArOpen;
            renameToolLeafStripMenuItem.Text = MenuLabels.ArRename;
            cutLeafToolStripMenuItem2.Text = MenuLabels.ArCut;
            cancelCutLeafToolStripMenuItem.Text = MenuLabels.ArCancelCut;
            deleteLeafToolStripMenuItem5.Text = MenuLabels.ArDelete;

            NewRootToolStripMenuItem.Text = MenuLabels.ArNew;
            CollapseAllRootToolStripMenuItem.Text = MenuLabels.ArCollapseAll;
            ExpandAllRootToolStripMenuItem.Text = MenuLabels.ArExpandAll;
            CancelCutRootToolStripMenuItem7.Text = MenuLabels.ArCancelCut;
            PasteRootToolStripMenuItem.Text = MenuLabels.ArPaste;
            RenameRootToolStripMenuItem.Text = MenuLabels.ArRename;

        }
        private void SetEngilshStrips()
        {
            newToolStripMenuItem.Text = MenuLabels.EnNew;
            collapseAllToolStripMenuItem.Text = MenuLabels.EnCollapseAll;
            expandAllStripMenuItem.Text = MenuLabels.EnExpandAll;
            renameToolStripMenuItem.Text = MenuLabels.EnRename;
            cutToolStripMenuItem.Text = MenuLabels.EnCut;
            cancelCuttoolStripMenuItem.Text = MenuLabels.EnCancelCut;
            pasteToolStripMenuItem.Text = MenuLabels.EnPaste;
            deleteToolStripMenuItem.Text = MenuLabels.EnDelete;

            openLeafToolStripMenuItem.Text = MenuLabels.EnOpen;
            renameToolLeafStripMenuItem.Text = MenuLabels.EnRename;
            cutLeafToolStripMenuItem2.Text = MenuLabels.EnCut;
            cancelCutLeafToolStripMenuItem.Text = MenuLabels.EnCancelCut;
            deleteLeafToolStripMenuItem5.Text = MenuLabels.EnDelete;

            NewRootToolStripMenuItem.Text = MenuLabels.EnNew;
            CollapseAllRootToolStripMenuItem.Text = MenuLabels.EnCollapseAll;
            ExpandAllRootToolStripMenuItem.Text = MenuLabels.EnExpandAll;
            CancelCutRootToolStripMenuItem7.Text = MenuLabels.EnCancelCut;
            PasteRootToolStripMenuItem.Text = MenuLabels.EnPaste;
            RenameRootToolStripMenuItem.Text = MenuLabels.EnRename;
        }
        #endregion

        #region Initialiaze Tree And branches

        public TreeControl()
        {
            InitializeComponent();
        }
        public void SetTree(IComposite root)
        {
            this.root = root;
            ContainerTreeNode node = CreateContainerNode(root, true);
            RefreshImagesIndexes(node, false);
            treeView1.Nodes.Add(node);
            node.ContextMenuStrip = rootMenuStrip;
            BuildBranch(new ContainerTreeNode(root), true);
        }
        public void BuildBranch(ContainerTreeNode root, bool addFakeNode)
        {
            TreeNode current;
            Library.Common.Composite.IComponent currentComponent;

            for (int i = 0; i < root.Container.GetChildrenCount(); i++)
            {
                currentComponent = root.Container.GetChildAt(i);

                if (currentComponent is ILeaf)
                {
                    current = new LeafTreeNode((ILeaf)currentComponent);
                    RefreshImagesIndexes(current, false);
                    current.ContextMenuStrip = leafMenuStrip;
                }
                else
                {
                    current = CreateContainerNode((IComposite)currentComponent, addFakeNode);
                    RefreshImagesIndexes(current, false);
                    current.ContextMenuStrip = containerMenuStrip;
                }

                root.Nodes.Add(current);
            }
        }
        private ContainerTreeNode CreateContainerNode(IComposite currentComponent, bool addFake)
        {
            ContainerTreeNode current = new ContainerTreeNode(currentComponent);
            current.Tag = true;

            if (addFake)
            {
                current.Nodes.Add("fake");
            }

            return current;
        }
        #endregion

        #region Create New Leaf Event
        public event EventHandler<LeafCreatedEventArgs> CreatingNewLeaf;
        protected void OnCreatingNewLeaf(LeafCreatedEventArgs e)
        {
            if (CreatingNewLeaf != null)
                CreatingNewLeaf(this, e);
        }
        private void leafToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LeafTreeNode node = new LeafTreeNode(LeafName);
            SelectedNode.Expand();
            RefreshImagesIndexes(node, false);
            SelectedNode.Nodes.Add(node);
            node.ContextMenuStrip = leafMenuStrip;
            SelectedNode = node;
            newNode = node;
            node.BeginEdit();
        }
        #endregion
       

        #region Create New Container Event
        public event EventHandler<ContainerEventArgs> NewContainerOrdered;
        protected void OnNewContainerOrdered(ContainerEventArgs e)
        {
            if (NewContainerOrdered != null)
                NewContainerOrdered(this, e);
        }
        private void containerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContainerTreeNode node = new ContainerTreeNode(ContainerName);
            SelectedNode.Expand();
            node.Tag = false;
            RefreshImagesIndexes(node, false);
            SelectedNode.Nodes.Insert(0, node);
            node.ContextMenuStrip = containerMenuStrip;
            SelectedNode = node;
            newNode = node;
            node.BeginEdit();
        }
        #endregion

        #region Expand And Collapse Node
        private void collapseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectedNode.Collapse();
        }

        private void expandAllStripMenuItem1_Click(object sender, EventArgs e)
        {
            SelectedNode.ExpandAll();
        }

        #endregion

        #region  Cut
        private void Cut()
        {
            CancelCut();
            EnableCutPasteCancelCutStrips(true);
            cutNode = SelectedNode;
            RefreshImagesIndexes(cutNode, true);
        }
        private void CancelCut()
        {
            if (cutNode != null)
            {
                RefreshImagesIndexes(cutNode, false);
                cutNode = null;
                EnableCutPasteCancelCutStrips(false);
            }
        }
        private void EnableCutPasteCancelCutStrips(bool isEnabled)
        {
            PasteRootToolStripMenuItem.Enabled = isEnabled;
            CancelCutRootToolStripMenuItem7.Enabled = isEnabled;
            pasteToolStripMenuItem.Enabled = isEnabled;
            cancelCutLeafToolStripMenuItem.Enabled = isEnabled;
            cancelCuttoolStripMenuItem.Enabled = isEnabled;
        }

        private void ContainerCut()
        {
            Cut();
            cutNode.Collapse();
        }
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContainerCut();
        }
        private void cancelCuttoolStripMenuItem_Click(object sender, EventArgs e)
        {
            CancelCut();
        }

        private void cutLeafToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            LeafCut();
        }
        private void LeafCut()
        {
            Cut();
        }
        private void cancelCutLeafToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CancelCut();
        }
        #endregion

        #region Paste
        public class LeafPasteEventArgs : ContainerEventArgs
        {
            ILeaf leaf;
            public ILeaf Leaf
            {
                get { return leaf; }
            }
            public LeafPasteEventArgs(ILeaf leaf, IComposite destination)
                : base(destination)
            {
                this.leaf = leaf;
            }
        }
        public event EventHandler<LeafPasteEventArgs> LeafPasteClicked;
        protected void OnLeafPaste(LeafPasteEventArgs e)
        {
            if (LeafPasteClicked != null)
                LeafPasteClicked(this, e);
        }
        public class ContainerPasteEventArgs : ContainerEventArgs
        {
            IComposite container;
            public IComposite Container
            {
                get { return container; }
            }
            public ContainerPasteEventArgs(IComposite source, IComposite destination)
                : base(destination)
            {
                this.container = source;
            }
        }
        public event EventHandler<ContainerPasteEventArgs> ContainerPasteClicked;
        protected void OnContainerPaste(ContainerPasteEventArgs e)
        {
            if (ContainerPasteClicked != null)
                ContainerPasteClicked(this, e);
        }
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paste();
        }
        private void Paste()
        {
            if (!CanMove(cutNode, SelectedNode))
                return;

            if (cutNode is LeafTreeNode)
            {
                LeafPasteEventArgs ee = new LeafPasteEventArgs((cutNode as LeafTreeNode).Leaf, (SelectedNode as ContainerTreeNode).Container);
                OnLeafPaste(ee);
                if (!ee.Cancel)
                {
                    cutNode.Remove();
                    SelectedNode.Expand();
                    SelectedNode.Nodes.Add(cutNode);
                }
            }
            else
            {
                ContainerPasteEventArgs ee = new ContainerPasteEventArgs((cutNode as ContainerTreeNode).Container, (SelectedNode as ContainerTreeNode).Container);
                OnContainerPaste(ee);
                if (!ee.Cancel)
                {
                    cutNode.Remove();
                    SelectedNode.Expand();
                    SelectedNode.Nodes.Insert(0, cutNode);
                }
            }

            SelectedNode.Expand();
            SortBranch(SelectedNode as ContainerTreeNode);
            CancelCut();
        }

        private bool CanMove(TreeNode node, TreeNode destination)
        {
            if (node.Parent == destination || node == destination)
            {
                CancelCut();
                string message;
                string caption;

                if (currentLanguage == Language.ARABIC)
                {
                    caption = "لا يمكن النقل";
                    message = String.Format("ال{0} المصدر هو نفسه ال{1} الوجهة", ContainerName, ContainerName);
                }
                else
                {
                    caption = "Moving cannot be done";
                    message = string.Format("The destination {0} is the same as the source {1}", ContainerName, ContainerName);
                }

                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }
        #endregion

        #region Rename

        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectedNode.BeginEdit();
        }
        private void renameToolLeafStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectedNode.BeginEdit();
        }

        public event EventHandler<ContainerEventArgs> ContainerLabelEdited;
        protected void OnContainerLabelEdit(ContainerEventArgs e)
        {
            if (ContainerLabelEdited != null)
                ContainerLabelEdited(this, e);
        }
        public event EventHandler<LeafEventArgs> LeafLabelEdited;
        protected void OnLeafLableEdit(LeafEventArgs e)
        {
            if (LeafLabelEdited != null)
                LeafLabelEdited(this, e);
        }
        private void treeView1_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (SelectedNode is ContainerTreeNode)
            {
                if (e.Node == newNode)
                {
                    ContainerCreatedEventArgs ee = new ContainerCreatedEventArgs(SelectedNode as ContainerTreeNode, (SelectedNode.Parent as ContainerTreeNode).Container);
                    newNode = null;
                    OnNewContainerOrdered(ee);
                }
                else
                {
                    ContainerEventArgs ee = new ContainerEventArgs((SelectedNode as ContainerTreeNode).Container);
                    OnContainerLabelEdit(ee);
                }
            }
            else
            {
                if (e.Node == newNode)
                {
                    newNode = null;
                    LeafCreatedEventArgs ee = new LeafCreatedEventArgs(SelectedNode as LeafTreeNode, (SelectedNode.Parent as ContainerTreeNode).Container);
                    OnCreatingNewLeaf(ee);
                }
                else
                {
                    LeafEventArgs ee = new LeafEventArgs((SelectedNode as LeafTreeNode).Leaf);
                    OnLeafLableEdit(ee);
                }
            }

        }

        #endregion

        #region Delete
        public event EventHandler<ContainerEventArgs> ContainerDeleted;
        protected void OnContainerDelete(ContainerEventArgs e)
        {
            if (ContainerDeleted != null)
                ContainerDeleted(this, e);
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContainerDelete();
        }
        private void ContainerDelete()
        {
            if (ShowDeleteMessage(SelectedNode) == DialogResult.Yes)
            {
                ContainerEventArgs ee = new ContainerEventArgs((SelectedNode as ContainerTreeNode).Container);

                if (cutNode != null && cutNode == SelectedNode)
                    CancelCut();

                OnContainerDelete(ee);

                if (!ee.Cancel)
                    SelectedNode.Remove();
            }
        }
        public event EventHandler<LeafEventArgs> LeafDeleted;
        protected void OnLeafDelete(LeafEventArgs e)
        {
            if (LeafDeleted != null)
                LeafDeleted(this, e);
        }
        private void deleteLeafToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            LeafDelete();
        }
        private void LeafDelete()
        {
            if (ShowDeleteMessage(SelectedNode) == DialogResult.Yes)
            {
                LeafEventArgs ee = new LeafEventArgs((SelectedNode as LeafTreeNode).Leaf);

                if (cutNode != null && cutNode == SelectedNode)
                    CancelCut();

                OnLeafDelete(ee);

                if (!ee.Cancel)
                    SelectedNode.Remove();
            }
        }
        private DialogResult ShowDeleteMessage(TreeNode node)
        {
            string message;
            string caption;
            if (currentLanguage == Language.ARABIC)
            {
                caption = "تأكيد الحذف";

                if (node is LeafTreeNode)
                {
                    message = "هل انت متأكد انك تريد حذف ال" + LeafName + " " + node.Text;
                    // message = string.Format("{1} هل انت متأكد انك تريد حذف ال{0}", LeafName, node.Text);
                }
                else
                {
                    message = "هل انت متأكد انك تريد حذف ال" + ContainerName + " " + node.Text;
                }
            }
            else
            {
                caption = "Confirm Deleting";

                if (node is LeafTreeNode)
                {
                    message = String.Format("Are you sure you want to delete the {0} , {1}", LeafName, node.Text);
                }
                else
                {
                    message = String.Format("Are you sure you want to delete the {0} , {1}", ContainerName, node.Text);
                }
            }

            return MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        #endregion

        #region Sort Tree
        class Sorter : IComparer
        {
            public int Compare(object x, object y)
            {
                if (x is ContainerTreeNode)
                {
                    if (y is ContainerTreeNode)
                        return ((ContainerTreeNode)x).Text.CompareTo(((ContainerTreeNode)y).Text);
                    else
                        return -1;

                }
                else
                {
                    if (y is ContainerTreeNode)
                        return 1;
                    else
                        return ((LeafTreeNode)x).Text.CompareTo(((LeafTreeNode)y).Text);

                }

            }
        }
        private void SortBranch(ContainerTreeNode root)
        {
            Sorter comparer = new Sorter();
            ArrayList list = new ArrayList();

            foreach (TreeNode child in root.Nodes)
            {
                list.Add(child);
            }

            list.Sort(comparer);
            root.Nodes.Clear();

            foreach (TreeNode node in list)
            {
                root.Nodes.Add(node);
            }
        }

        #endregion
    }
}

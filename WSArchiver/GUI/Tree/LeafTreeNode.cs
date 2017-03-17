using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Library.Common;
using Library.Common.Composite;

namespace WSArchiver.GUI.Tree
{
   public class LeafTreeNode : TreeNode
    {
        private ILeaf leaf;

        public ILeaf Leaf
        {
            get { return leaf; }
            set { leaf = value; }
        }
        public LeafTreeNode(string treeNodeName)
            :base(treeNodeName)
        {
        }
        public LeafTreeNode(ILeaf leaf)
            : base(leaf.GetName())
        {
            this.leaf = leaf;
        }
    }
}

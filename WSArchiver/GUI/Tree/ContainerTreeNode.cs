using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Library.Common;
using Library.Common.Composite;

namespace WSArchiver.GUI.Tree
{
    public class ContainerTreeNode : TreeNode
    {
        private IComposite container;

        public ContainerTreeNode(string treeNodeName)
            :base(treeNodeName)
        {
        }
        public ContainerTreeNode(IComposite fVo)
            : base(fVo.GetName())
        {
            this.Container = fVo;
        }
        public IComposite Container
        {
            get { return container; }
            set { container = value; }
        }
        
    }
}

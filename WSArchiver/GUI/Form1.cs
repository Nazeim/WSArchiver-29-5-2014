using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Library.BLL;
using Library.Common;
using WSArchiver.GUI.UserControls;

namespace WSArchiver.GUI
{
    public partial class Form1 : Form
    {
        FoldersManager manager = new FoldersManager();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FolderVO folder = manager.GetRootFolder();
            treeControl1.SetTree(folder);
        }

        private void treeControl1_NodeExpanded(object sender, UserControls.TreeControl.ContainerEventArgs e)
        {
            FoldersManager manager = new FoldersManager();
            ((FolderVO)e.Node).Folders = manager.GetSubFoldersOfFolder((FolderVO)e.Node);
            DocumentsManager manager1 = new DocumentsManager();
            ((FolderVO)e.Node).Documents = manager1.GetDocumentsOfFolder((FolderVO)e.Node);

            //Trash
            DocumentDetailsListItem temp;
            flowLayoutPanel1.Controls.Clear();

            foreach (DocumentVO doc in (e.Node as FolderVO).Documents)
            {
                temp = new DocumentDetailsListItem();
                temp.Document = doc;
                temp.HighlightColor = Color.Azure;
                flowLayoutPanel1.Controls.Add(temp);
            }
        }


    }
}

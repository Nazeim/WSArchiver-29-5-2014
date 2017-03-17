using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Library.Common;

namespace WSArchiver.GUI.Archiving
{
    public partial class EFilesArchivingForm : WSArchiver.GUI.ArchivingForm
    {

        public EFilesArchivingForm()
        {
            InitializeComponent();
        }

        public EFilesArchivingForm(DocumentVO doc, OperationMode mode)
            : base(doc, mode)
        {
            InitializeComponent();
        }

        protected override string AcquireNewFile()
        {
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                return openFileDialog1.FileName;
            }
            else
            {
                return "";
            }
        }

        protected override bool FillDocument()
        {
            //currentDocument.Type = DocumentVO.DocumentType.FILES;

            return base.FillDocument();
        }

        private void SaveB_Click_1(object sender, EventArgs e)
        {

        }

        private void RenameB_Click(object sender, EventArgs e)
        {

        }
    }
}

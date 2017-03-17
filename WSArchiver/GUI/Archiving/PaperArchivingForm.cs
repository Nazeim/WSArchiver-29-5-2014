using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Library.Common;
using Library.BLL;

namespace WSArchiver.GUI.Archiving
{
    public partial class PaperArchivingForm : WSArchiver.GUI.ArchivingForm
    {
        ScannerManager scanner = new ScannerManager();

        public PaperArchivingForm()
        {
            InitializeComponent();
        }

        public PaperArchivingForm(DocumentVO doc, OperationMode mode)
            : base(doc, mode)
        {
            InitializeComponent();
        }

        protected override string AcquireNewFile()
        {
            try
            {
                if (scanner.CanScan())
                {
                    ScanningForm form = new ScanningForm(scanner);
                    DialogResult res = form.ShowDialog();

                    if (res == System.Windows.Forms.DialogResult.OK)
                    {
                        return form.FilePath;
                    }
                    else
                    {
                        return "";
                    }
                }
                else
                {
                    Error("لا توجد ماسحات متصلة");

                    return "";
                }
            }
            catch
            {
                return "";
            }

        }

        protected override bool FillDocument()
        {
            //currentDocument.Type = DocumentVO.DocumentType.SCANNED;

            return base.FillDocument();
        }

        private void scannerSettingsL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ScanningSettingsForm form = new ScanningSettingsForm(scanner);
            form.ShowDialog();
        }

        protected override string GetBaseFileName()
        {
            return "صفحة-";
        }
    }
}

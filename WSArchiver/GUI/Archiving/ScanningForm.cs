using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Library.BLL;

namespace WSArchiver.GUI.Archiving
{
    public partial class ScanningForm : ParentForm
    {
        private ScannerManager scanner;
        private string filePath;
        private EventHandler<ScannerManager.FileAcquiredEventArgs> handler;

        public string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }

        public ScanningForm()
        {
            InitializeComponent();

            Controls.Remove(statusStrip1);
        }

        public ScanningForm(ScannerManager manager)
            : this()
        {
            this.scanner = manager;
        }

        private void ScanningForm_Load(object sender, EventArgs e)
        {
            handler = new EventHandler<ScannerManager.FileAcquiredEventArgs>(scanner_FileAcquired);
            scanner.FileAcquired += handler;

            try
            {
                scanner.ScanToTempDir();
            }
            catch 
            {
                Error("حصل خطأ أثناء عملية المسح. تحقق من إعدادات الماسحة");
                filePath = "";
                DialogResult = System.Windows.Forms.DialogResult.Abort;
            }
        }

        void scanner_FileAcquired(object sender, ScannerManager.FileAcquiredEventArgs e)
        {
            if (e.filePath == "")
            {
                filePath = "";
                DialogResult = System.Windows.Forms.DialogResult.Abort;
            }
            else
            {
                filePath = e.filePath;
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }

            scanner.FileAcquired -= handler;
        }

        private void ScanningForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            scanner.Close();
        }
    }
}

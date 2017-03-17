using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WSArchiver.GUI.Archive;
using WSArchiver.GUI.Archiving;
using Library.Common;
using Library.BLL;
using System.Diagnostics;

namespace WSArchiver.GUI
{
    public partial class MainForm : ParentForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void PartiesButton_Click(object sender, EventArgs e)
        {
            PartyForm form = new PartyForm();
            form.ShowDialog();
        }

        private void FoldersButton_Click(object sender, EventArgs e)
        {
            FoldersForm form = new FoldersForm();
            form.ShowDialog();
        }

        private void EmployeeOfficeManagmentButton_Click(object sender, EventArgs e)
        {
            DocDestinationForm form = new DocDestinationForm();
            form.ShowDialog();
        }

        private void ArchivePaperDocButton_Click(object sender, EventArgs e)
        {
            PaperArchivingForm form = new PaperArchivingForm(null, ArchivingForm.OperationMode.CREATE);
            form.ShowDialog();
        }

        private void ArchiveEDocButton_Click(object sender, EventArgs e)
        {
            EFilesArchivingForm form = new EFilesArchivingForm(null, ArchivingForm.OperationMode.CREATE);
            form.ShowDialog();
        }

        private void ArchivesButton_Click(object sender, EventArgs e)
        {
            SimpleSearchForm form = new SimpleSearchForm();
            form.ShowDialog();
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            ChangePasswordForm form = new ChangePasswordForm();
            form.ShowDialog();
        }

        private void UsersButton_Click(object sender, EventArgs e)
        {
            UsersForm form = new UsersForm();
            form.ShowDialog();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm form = new SettingsForm();
            form.ShowDialog();
        }

        private void LogFileButton_Click(object sender, EventArgs e)
        {
            LogFileForm form = new LogFileForm();
            form.ShowDialog();
        }

        protected override void ParentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Log(OperationsManager.LOGIN_LOGOUT, "قام المستخدم بتسجيل الخروج");
            Library.ConfigurationManager.currUser = null;
            Message("تم تسجيل الخروج بنجاح");

            base.ParentForm_FormClosing(sender, e);
        }

        private void exitB_Click(object sender, EventArgs e)
        {
            if (Question("هل أنت متأكد من تسجيل الخروج؟") == System.Windows.Forms.DialogResult.Yes)
            {
                Close();
            }
        }

        private void categoriesB_Click(object sender, EventArgs e)
        {
            CategoryForm form = new CategoryForm();
            form.ShowDialog();
        }

        protected override void ValidateUserPermissions()
        {
            foreach (OperationVO op in Library.ConfigurationManager.currUser.Permissions)
            {
                switch (op.Name)
                {
                    case OperationsManager.CREATE_DOCS:
                        ArchiveEDocButton.Enabled = true;
                        break;
                    case OperationsManager.EDIT_CATEGORIES:
                        categoriesB.Enabled = true;
                        break;
                    case OperationsManager.EDIT_DESTINATIONS:
                        EmployeeOfficeManagmentButton.Enabled = true;
                        break;
                    case OperationsManager.EDIT_GENERAL_FILES:
                        FoldersButton.Enabled = true;
                        break;
                    case OperationsManager.EDIT_PARTIES:
                        PartiesButton.Enabled = true;
                        break;
                    case OperationsManager.EDIT_USERS:
                        UsersButton.Enabled = true;
                        break;
                    case OperationsManager.SEARCH_LOG:
                        LogFileButton.Enabled = true;
                        break;
                    case OperationsManager.SIMPLE_SEARCH:
                        ArchivesButton.Enabled = true;
                        break;
                }
            }
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            AboutBox1 form = new AboutBox1();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string userName = Library.ConfigurationManager.currUser.Username;
            string password = Library.ConfigurationManager.currUser.Password;
            string serverIp = Library.ConfigurationManager.DBServerName;

            string path = @"f:\Release\Messenger.exe";
            Process.Start(path, userName + " " + password + " " + serverIp);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BackupRestoreManager m = new BackupRestoreManager();
            m.Backup("WSArchiverDB.BAK");
       
        }

    }
}

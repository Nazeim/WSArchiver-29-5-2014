using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Library.BLL;

namespace WSArchiver.GUI
{
    public partial class SettingsForm : DialogParent
    {
        string prevAddress;
        bool prevIsLocal;
        //LogManager prevMan;

        public SettingsForm()
        {
            InitializeComponent();
        }


        private void browseFolderB_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string folderPath = folderBrowserDialog1.SelectedPath;

                if (!Directory.Exists(folderPath))
                {
                    Error("المسار المحدد غير موجود");
                    folderPath = "";
                }
                else
                {
                    localStoragePathTB.Text = folderPath;
                }
            }
        }

        private void Okbutton_Click(object sender, EventArgs e)
        {
            Library.ConfigurationManager.DBServerName = serverAddressTB.Text.Trim();
            Library.ConfigurationManager.LocalStoragePath = localStoragePathTB.Text.Trim();

            Message("تم تعديل إعدادات الاتصال");
            Close();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            localStoragePathTB.Text = Library.ConfigurationManager.LocalStoragePath;
            serverAddressTB.Text = Library.ConfigurationManager.DBServerName;
        }

        private void defaultB_Click(object sender, EventArgs e)
        {
            serverAddressTB.Text = Library.ConfigurationManager.DEFAULT_SERVER_ADDRESS;
            localStoragePathTB.Text = Library.ConfigurationManager.GetDefaultStorageDirectoryPath();
        }

        private void exitB_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkerBGW_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                OperationsManager man = new OperationsManager();
                e.Result = man.Ping();
            }
            catch
            {
                e.Result = false;
            }
        }

        private void checkerBGW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                SetEnabled(true);
                SetStatus("");
                toolStripProgressBar1.Style = ProgressBarStyle.Blocks;

                Library.ConfigurationManager.DBServerName = prevAddress;
                Library.ConfigurationManager.IsLocalConnection = prevIsLocal;

                if (!((bool)e.Result))
                {
                    Error("تعذر إيجاد قاعدة البيانات على المخدم المحدد");
                    return;
                }
                else
                {
                    Message("تمكن البرنامج من إيجاد قاعدة البيانات على المخدم المحدد");
                }
            }
            catch
            { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string folderPath = localStoragePathTB.Text.Trim();


            if (!Directory.Exists(folderPath))
            {
                Error("المسار المحدد للتخزين المحلي غير موجود");
                return;
            }
            else
            {
                Message("المسار صالح");
            }
        }

        private void verifyServerAddressB_Click(object sender, EventArgs e)
        {
            string serverIp = serverAddressTB.Text;

            prevAddress = Library.ConfigurationManager.DBServerName;
            prevIsLocal = Library.ConfigurationManager.IsLocalConnection;
            Library.ConfigurationManager.IsLocalConnection = false;
            Library.ConfigurationManager.DBServerName = serverIp;
            SetEnabled(false);
            SetStatus("جاري التحقق من الإعدادات");
            toolStripProgressBar1.Style = ProgressBarStyle.Marquee;

            checkerBGW.RunWorkerAsync();
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (checkerBGW.IsBusy)
            {
                Message("الرجاء الانتظار ريثما يتم التحقق من إعدادات الاتصال");
                e.Cancel = true;
            }
        }


    }
}

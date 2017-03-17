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
using System.IO;

namespace WSArchiver.GUI
{
    public partial class LogInForm : DialogParent
    {
        UsersManager manager;
        UserVO user = new UserVO();

        public LogInForm()
        {
            InitializeComponent();
            Controls.Remove(statusStrip1);
        }

        private void LogInB_Click(object sender, EventArgs e)
        {
            Library.ConfigurationManager.IsLocalConnection = localRB.Checked;
            Library.ConfigurationManager.FTPServerName = "192.168.1.35";
            Library.ConfigurationManager.FTPServerUserName = "User1";
            Library.ConfigurationManager.FTPServerPassword = "123456";
            manager = new UsersManager();
            user.Username = UserNameTB.Text.Trim();
            user.Password = PasswordTB.Text;
            UsersManager.AuthenticationResult result = manager.Authenticate(user);

            if (result == UsersManager.AuthenticationResult.WRONG_PASSWORD ||
                result == UsersManager.AuthenticationResult.WRONG_USER_NAME ||
                result == UsersManager.AuthenticationResult.NO_USERS_IN_DB)
            {
                Error("اسم المستخدم أو كلمة المرور غير صحيحة");
            }
            else if (result == UsersManager.AuthenticationResult.NOT_ACTIVE)
            {
                Error("حساب المستخدم غير مفعل");
            }
            else if (result == UsersManager.AuthenticationResult.SUCCESSFUL)
            {
                Library.ConfigurationManager.currUser = user;
                Log(OperationsManager.LOGIN_LOGOUT, "قام المستخدم بتسجيل الدخول");
                UserNameTB.Text = "";
                PasswordTB.Text = "";
                //Message("تم تسجيل الدخول بنجاح");
                MainForm form = new MainForm();
                form.Owner = this;
                Hide();
                form.Show();
                return;
            }
            else if (result == UsersManager.AuthenticationResult.CONNECTION_ERROR)
                Error("تعذر الاتصال بقاعدة البيانات");
            else
                Error("المستخدم لا يمتلك سماحيات للدخول");

            Library.ConfigurationManager.currUser = null;
        }

        private void exitB_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SettingsForm form = new SettingsForm();
            form.ShowDialog();
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(Library.ConfigurationManager.GetDefaultStorageDirectoryPath()))
                    Directory.CreateDirectory(Library.ConfigurationManager.GetDefaultStorageDirectoryPath());
            }
            catch
            { }
        }

    }
}

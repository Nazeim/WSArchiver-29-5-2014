using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Library.Common;
using Library.BLL;
using WSArchiver.GUI.User;

namespace WSArchiver.GUI
{
    public partial class UsersForm : DialogParent
    {
        private UsersManager manager = new UsersManager();

        public UsersForm()
        {
            InitializeComponent();

        }


        private void InsertUserButton_Click(object sender, EventArgs e)
        {
            UserVO user = new UserVO();
            user.Username = UserNametextBox.Text.Trim();

            user.Password = manager.GenerateHash(passwordTB.Text);
            user.IsActive = true;
            if (UserNametextBox.Text.Trim() == "")
                Error("اسم المستخدم لايمكن أن يكون فارغاً");
            else if (!manager.IsUserNew(user))
                Error("اسم المستخدم موجود مسبقاً");
            else if (passwordTB.Text == "")
                Error("كلمة المرور لايمكن ان تكون فارغة");
            else
            {
                if (manager.Insert(user) < 0)
                    Error();
                else
                {
                    bindingSource1.Add(user);
                    UsersDataGridView.Refresh();
                    Message("تم إضافة المستخدم بنجاح. لا تنس أن تحدد سماحياته");
                    passwordTB.Text = "";
                    UserNametextBox.Text = "";
                    Log(OperationsManager.EDIT_USERS);
                }
            }

        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        private void Initialize()
        {


            StartWorker();

        }

        private void StartWorker()
        {
            SetEnabled(false);
            backgroundWorker1.RunWorkerAsync();
            toolStripProgressBar1.Style = ProgressBarStyle.Marquee;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            List<UserVO> all = manager.GetAll();
            e.Result = all;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                List<UserVO> all = e.Result as List<UserVO>;
                bindingSource1.Clear();

                foreach (UserVO u in all)
                {
                    if (!manager.IsAdmin(u))
                        bindingSource1.Add(u);
                }

                SetEnabled(true);
                toolStripProgressBar1.Style = ProgressBarStyle.Blocks;
            }
            catch
            { }
        }

        private void exitB_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateUserButton_Click(object sender, EventArgs e)
        {
            UserVO current = bindingSource1.Current as UserVO;

            if (current != null)
            {
                UserEditForm form = new UserEditForm(current, manager);


                if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    UsersDataGridView.Refresh();
                    Log(OperationsManager.EDIT_USERS);
                }
            }
        }

        private void RemovUserButton_Click(object sender, EventArgs e)
        {
            UserVO current = bindingSource1.Current as UserVO;
          
                if (current != null)
                {
                    if (Question("هل أنت متأكد من الحذف؟") == System.Windows.Forms.DialogResult.Yes)
                    {

                        if (manager.Delete(current))
                        {
                            bindingSource1.Remove(current);
                            UsersDataGridView.Refresh();
                            Message("تم الحذف بنجاح");
                            Log(OperationsManager.EDIT_USERS);
                        }
                        else
                        {
                            Error();
                        }
                            
                    }

                       
                    }
        }

        private void UserSPrivilegesButton_Click(object sender, EventArgs e)
        {
            UserVO current = bindingSource1.Current as UserVO;

            if (current == null)
                return;

            AssignPermissionsForm form = new AssignPermissionsForm(current);
            form.ShowDialog();
        }
    }
}

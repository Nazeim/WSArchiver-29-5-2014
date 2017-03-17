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

namespace WSArchiver.GUI.User
{
    public partial class UserEditForm : DialogParent
    {
        UserVO user;
        UsersManager manager = new UsersManager();
        bool isAutomatic = false;

        public UserEditForm()
        {
            InitializeComponent();
            statusStrip1.Items.Clear();
            statusStrip1.Items.Add(currentUserStripLabel);
        }

        public UserEditForm(UserVO u, UsersManager m)
            : this()
        {
            user = u;
            manager = m;
            isAutomatic = true;
            userNameTB.Text = user.Username;
            isActiveUserComboBox.Text = user.IsActiveAsString;
            isAutomatic = false;
        }

        private void exitB_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UserEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != System.Windows.Forms.DialogResult.OK)
                DialogResult = System.Windows.Forms.DialogResult.Cancel;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (userNameTB.Text.Trim() == "")
            {
                Error("اسم المستخدم لا يمكن أن يكون فارغاً");
                return;
            }

            UserVO temp = new UserVO();
            temp.Id = user.Id;
            temp.Username = userNameTB.Text.Trim();

            if (isActiveUserComboBox.SelectedIndex == 0)
            {
                temp.IsActive = false;
            }
            else
                temp.IsActive = true;

            if (checkBox1.Checked)
                temp.Password = manager.GenerateHash(Library.ConfigurationManager.USER_DEFAULT_PASSWORD);


            if (!manager.IsUserNew(temp))
            {
                Error("هناك مستخدم آخر له نفس الاسم ", "فشل تعديل المستخدم");
                return;
            }

            if (manager.Update(temp))
            {
                user.Username = temp.Username;
                user.IsActive = temp.IsActive;
                user.Password = temp.Password;

                Message("تم تعديل المستخدم بنجاح");
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                Error();
            }
        }

        private void userNameTB_TextChanged(object sender, EventArgs e)
        {
            if (!isAutomatic)
                button1.Enabled = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                Message(Library.ConfigurationManager.USER_DEFAULT_PASSWORD + "عند إتمام التعديل ستكون كلمة السر ");
        }

    }
}

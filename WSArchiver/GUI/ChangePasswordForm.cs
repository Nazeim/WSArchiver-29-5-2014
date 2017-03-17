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

namespace WSArchiver.GUI
{
    public partial class ChangePasswordForm : DialogParent
    {
        public ChangePasswordForm()
        {
            InitializeComponent();

            statusStrip1.Items.Clear();
            statusStrip1.Items.Add(currentUserStripLabel);
        }

        private void SaveB_Click(object sender, EventArgs e)
        {
            if (passwordTB.Text.Length > 0 && confirmpasswordTB.Text.Length > 0)
            {
                UsersManager manager = new UsersManager();
                UserVO user = new UserVO();
                user = Library.ConfigurationManager.currUser;

                if (passwordTB.Text == confirmpasswordTB.Text)
                {
                    user.Password = manager.GenerateHash(passwordTB.Text);



                    if (manager.Update(user))
                    {
                        Library.ConfigurationManager.currUser = user;
                        Message("تم تغيير كلمة المرور بنجاح");
                    }
                    else
                        Error("فشلت عملية تغيير كلمة المرور");
                    
                }
                else
                    Error("كلمة المرور وتأكيدها غير متطابقتان");

            }
            else
                Error("كلمة المرور أو تأكيدها لا يمكن أن تكون فارغة");
        }

        private void exitB_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

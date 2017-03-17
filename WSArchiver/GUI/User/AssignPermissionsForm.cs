using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Library.Common;
using Library.BLL;

namespace WSArchiver.GUI.User
{
    public partial class AssignPermissionsForm : WSArchiver.GUI.DialogParent
    {
        UserVO selectedUser;
        OperationsManager manager = new OperationsManager();

        public AssignPermissionsForm()
        {
            InitializeComponent();

            statusStrip1.Items.Clear();
            statusStrip1.Items.Add(currentUserStripLabel);
        }

        public AssignPermissionsForm(UserVO user)
            : this()
        {
            selectedUser = user;
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            saveB.Enabled = true;
        }

        private void saveB_Click(object sender, EventArgs e)
        {
            if (Question("هل أنت متأكد من أنك تريد تغيير سماحيات المستخدم؟") == System.Windows.Forms.DialogResult.Yes)
            {
                List<OperationVO> operations = new List<OperationVO>();

                foreach(OperationVO op in checkedListBox1.CheckedItems)
                    operations.Add(op);

                if (manager.AssignPermissionsToUser(selectedUser, operations))
                {
                    Message("تمت العملية بنجاح");
                    Log(OperationsManager.EDIT_USERS);
                    Close();
                }
                else
                {
                    Error();
                }
            }
            else
            {
                Close();
            }
        }

        private void AssignPermissionsForm_Load(object sender, EventArgs e)
        {
            List<OperationVO> userOperations = manager.GetOperationsOfUser(selectedUser);
            List<OperationVO> all = manager.GetAll();
            textBox1.Text = selectedUser.Username;

            for(int i = 0; i < all.Count; i++)
            {
                checkedListBox1.Items.Add(all[i]);

                if (userOperations.Contains(all[i]))
                    checkedListBox1.SetItemChecked(i, true);
                else
                    checkedListBox1.SetItemChecked(i, false);
            }
        }

        private void exitB_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

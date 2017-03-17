using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Library.Common;
using Messenger.Properties;
using Messenger;
using Library.DAL.Interface;
using Library;

namespace Messenger.GUI.UserControls
{
    public partial class UserUserControl : UserControl
    {
        private Color normalColor;
        private Color selectedColor;

        public Color SelectedColor
        {
            get { return selectedColor; }
            set { selectedColor = value; }
        }
        

        public UserUserControl()
        {
            InitializeComponent();
        }
        public UserUserControl(UserVO user)
            : this()
        {
            User = user;
        }
      
        private UserVO user;
        public UserVO User
        {
            get { return user; }
            set 
            {
                user = value;
                SetUserName(user.Username);
                SetOnline(user.IsLoggedIn);
            }

        }

        public void SetMessagesCount(int count)
        {
            if (count != 0)
            {
                messagesCountL.Text = String.Format("({0})", count);
            }
            else
            {
                messagesCountL.Text = "";
            }
        }
        public void SetUserName(string userName)
        {
            userNameL.Text = String.Format("{0}", user.Username);
        }
        public void SetOnline(bool isOnline)
        {
            pictureBox1.Image = isOnline ? Resources.green_light : Resources.red_light__2_;
        }

        #region User Event Args
        public class UserEventArgs : EventArgs
        {
            private UserVO user;

            public UserVO User
            {
                get { return user; }
                set { user = value; }
            }

           

            public UserEventArgs() { }
            public UserEventArgs(UserVO user)
            {
          
                this.user = user;
            }

 
        }
        public event EventHandler<UserEventArgs> UserClicked;
        
        protected void OnUserClicked(UserEventArgs e)
        {
            EventHandler<UserEventArgs> userClicked = UserClicked;
            if (userClicked != null)
                userClicked(this, e);
        }


        #endregion


        private void tableLayoutPanel1_MouseEnter(object sender, EventArgs e)
        {
            normalColor = BackColor;
            BackColor = SelectedColor;
            tableLayoutPanel1.Cursor = Cursors.Hand;
        }
        private void tableLayoutPanel1_MouseLeave(object sender, EventArgs e)
        {
            BackColor = normalColor;
            tableLayoutPanel1.Cursor = Cursors.Default;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UserEventArgs ee = new UserEventArgs(user);
            OnUserClicked(ee);
        }

    }
}

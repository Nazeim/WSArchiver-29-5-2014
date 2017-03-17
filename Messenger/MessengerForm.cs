using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Library.Common;
using Messenger.GUI.UserControls;
using Library.BLL;
using Library.Common.Search;
using Library;


namespace Messenger.GUI.Messenger
{
    public partial class MessengerForm : Form
    {
        private readonly string userName;
        private readonly string password;
        private readonly string serverIp;

        UsersManager usersManager;
        MessagesManager messageManager;
        UserVO toUser;
        UserUserControl control;
        Color currentUserColor = Color.SteelBlue;
        Color toUserColor = Color.Black;


        public MessengerForm()
        {
            userName = "";
            password = "";
            serverIp = "";
            InitializeComponent();
        }

        public MessengerForm(string userName, string password, string serverIp)
        {
            this.password = password;
            this.userName = userName;
            this.serverIp = serverIp;
            InitializeComponent();
        }

        private void Intialize()
        {
            Library.ConfigurationManager.IsLocalConnection = false;
            Library.ConfigurationManager.DBServerName = serverIp;
            usersManager = new Library.BLL.UsersManager();
            //Library.ConfigurationManager.IsLocalConnection = false;
            messageManager = new MessagesManager();
            UserVO user = new UserVO();
            //user.Username = userName;
            //user.Password = password;
            user.Username = "Admin";
            user.Password = "Admin";
            usersManager.Authenticate(user);       
            Library.ConfigurationManager.currUser = user;
       
            AddUsers();
        }

        public void AddUser(UserVO user)
        {
            control = new UserUserControl();
            control.User = user;

            control.SetMessagesCount(messageManager.GetUnSeenMessagesCount(user, ConfigurationManager.currUser));
            MessengerL.Controls.Add(control);
            control.UserClicked += new EventHandler<UserUserControl.UserEventArgs>(control_UserClicked);
            control.SelectedColor = Color.AliceBlue;

        }


        void control_UserClicked(object sender, UserUserControl.UserEventArgs e)
        {
            toUser = e.User;
            TypingTB.Enabled = true;
            ButtonSend.Enabled = true;
            timer1.Enabled = true;
            label1.Enabled = true;
            label1.Text = e.User.Username;
            
            ConversationRTB.Clear();
            List<MessageVO> all = messageManager.GetChat(e.User, ConfigurationManager.currUser);

            foreach (MessageVO m in all)
            {
                AppendMessage(m);

            } 
        }

        private void AppendMessage(MessageVO message)
        {
            if (message.FromUser.Id == toUser.Id)
            {
                ConversationRTB.SelectionColor = toUserColor;
            }
            else
            {
                ConversationRTB.SelectionColor = currentUserColor;
            }

            ConversationRTB.SelectedText = message.FromUser + ": " + message.Body + "\n";
            ConversationRTB.AppendText(ConversationRTB.SelectedText);
           
        }
       
        private void AddUsers()
        {
            List<UserVO> all = usersManager.GetAll();
            foreach (UserVO u in all)
            {
                if (u.Id != ConfigurationManager.currUser.Id)
                    AddUser(u);

            }

        }

        private void AddMessage()
        {
            string text = TypingTB.Text;
            

            if (text != String.Empty)
            {
                MessageVO message = new MessageVO();
                message.Body = text;
                message.FromUser = ConfigurationManager.currUser;
                message.ToUser = toUser;
                messageManager.Insert(message);
                AppendMessage(message);
                
            }
                
        }

        private void MessengerForm_Load(object sender, EventArgs e)
        {    
            Intialize();
            //messageManager.Insert(new MessageVO());
        }

        private void ButtonSend_Click_1(object sender, EventArgs e)
        {
            AddMessage();   
            TypingTB.Clear();
        }

        private void TypingTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           List<MessageVO> allUnseen= messageManager.GetUnseenMessages(toUser,ConfigurationManager.currUser);
           foreach (MessageVO m in allUnseen)
           {
               AppendMessage(m);
           }

           foreach (UserUserControl  item in MessengerL.Controls)
           {
              item.SetMessagesCount(messageManager.GetUnSeenMessagesCount(item.User, ConfigurationManager.currUser));  
           }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.Common
{
    public class MessageVO : VO
    {
        private UserVO fromUser;
        private UserVO toUser;
        private DateTime date;
        private bool isSeen;
        private string body;

        public UserVO FromUser
        {
            get { return fromUser; }
            set { fromUser = value; }
        }

        public UserVO ToUser
        {
            get { return toUser; }
            set { toUser = value; }
        }

        public int FromUserID
        {
            get
            {
                return fromUser.Id;
            }
        }

        public int ToUserID
        {
            get
            {
                return toUser.Id;
            }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public string Body
        {
            get { return body; }
            set { body = value; }
        }

        public bool IsSeen
        {
            get { return isSeen; }
            set { isSeen = value; }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.DAL.Interface;
using Library.BLL;
using Library.Common.Search;
using Library.Common;
using System.Data.SqlClient;

namespace Library.BLL
{
   public  class MessagesManager : Manager<MessageVO>
    {
        public MessagesManager()
            : base(DAL.DALManager.GetMessageDAO())
        { }

        public List<MessageVO> GetMessages(UserVO from,UserVO to)
        {
            List<MessageVO> result = ((IMessageDAO)dataAccessObject).GetMessages(from, to);
            Close();

            return result;
        }

        public List<MessageVO> GetChat(UserVO to, UserVO from)
        {
            List<MessageVO> result = ((IMessageDAO)dataAccessObject).GetChat(to, from);
            Close();

            return result; 
        }
        public override int Insert(MessageVO message)
        {
            
            message.IsSeen = false;
            message.Date = GetDate();
		    
            return base.Insert(message);
        }

        public int GetUnSeenMessagesCount(UserVO from,UserVO to)
        {
            int result = ((IMessageDAO)dataAccessObject).GetUnSeenMessagesCount(from, to);
            Close();

            return result;
        }

        public List<MessageVO> GetUnseenMessages(UserVO from, UserVO to)
        {
            List<MessageVO> result = ((IMessageDAO)dataAccessObject).GetUnseenMessages(from,to);
            Close();

            return result; 
        }

  
    }
}

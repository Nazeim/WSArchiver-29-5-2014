using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.DAL.Interface;
using Library.Common.Search;
using Library.Common;

namespace Library.DAL.Interface
{
    public interface IMessageDAO : IDAO<MessageVO>
    {

        List<MessageVO> GetMessages(UserVO from, UserVO to);
        int GetUnSeenMessagesCount(UserVO from, UserVO to);
        List<MessageVO> GetChat(UserVO user1, UserVO user2);
        bool SetMessagesSeen(UserVO fromUser, UserVO toUser);
        bool DeleteOldMessages(UserVO from, UserVO to);
        List<MessageVO> GetUnseenMessages(UserVO from, UserVO to);
    }
}

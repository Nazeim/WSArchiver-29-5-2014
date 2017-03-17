using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.DAL.Interface;
using System.Data.SqlServerCe;
using System.Data;
using Library.DAL.Compact;
using Library.Common.Search;
using Library.Common;

namespace Library.DAL.Compact
{
    public class MessageDAO : DAO<MessageVO>, IMessageDAO
    {
        public const string messageFrom = "messageFrom";
        public const string messageTo = "messageTo";
        public const string messageDate = "messageDate";
        public const string messageIsSeen = "messageIsSeen";
        public const string messageBody = "messageBody";

        UserDAO udao = new UserDAO();

        public MessageDAO()
            : base("Message", "messageId", 6)
        { }

        protected override SqlCeParameter[] MakeSqlParameters(MessageVO vo)
        {
            SqlCeParameter[] parameters = new SqlCeParameter[]
            {
                MakeSqlParameter(messageFrom,vo.FromUserID),
                MakeSqlParameter(messageTo,vo.ToUserID),
                MakeSqlParameter(messageDate,vo.Date,SqlDbType.DateTime),
                MakeSqlParameter(messageIsSeen,vo.IsSeen,SqlDbType.Bit),
                MakeSqlParameter(messageBody, vo.Body, SqlDbType.NVarChar)
            };

            return parameters;
        }
        protected override string[] ConvertColumnNamesToArray()
        {
            return ConvertToArray(messageFrom, messageTo, messageDate, messageIsSeen, messageBody);
        }
        public override MessageVO ReadRecord(SqlCeDataReader reader)
        {
            MessageVO result = new MessageVO();

            result.Id = reader.GetInt32(reader.GetOrdinal(idColumnName));

            result.FromUser = udao.GetItem(reader.GetInt32(reader.GetOrdinal(messageFrom)));
            result.ToUser = udao.GetItem(reader.GetInt32(reader.GetOrdinal(messageTo)));
            udao.CloseConnection();

            result.Date = reader.GetDateTime(reader.GetOrdinal(messageDate));
            result.IsSeen = reader.GetBoolean(reader.GetOrdinal(messageIsSeen));
            result.Body = reader[messageBody].ToString();

            return result;

        }

        public List<MessageVO> GetMessages(UserVO from, UserVO to)
        {
            SqlCeParameter[] parameters = 
            {
                MakeSqlParameter(messageFrom,from.Id),
                MakeSqlParameter(messageTo,to.Id)
            };

            return IdenticalMatch(parameters);
        }

        public int GetUnSeenMessagesCount(UserVO from, UserVO to)
        {
            SqlCeParameter[] parameters = 
            {
                MakeSqlParameter(messageFrom,from.Id),
                MakeSqlParameter(messageTo,to.Id),
                MakeSqlParameter(messageIsSeen,false, SqlDbType.Bit)
            };

            List<MessageVO> res = IdenticalMatch(parameters);

            return res.Count;

        }
       
        
        

        public List<MessageVO> GetUnseenMessages(UserVO from, UserVO to)
        {
            SqlCeParameter[] parameters = 
            {
                MakeSqlParameter(messageFrom, from.Id),
                MakeSqlParameter(messageTo, to.Id),
                MakeSqlParameter(messageIsSeen, false, SqlDbType.Bit)
            };
            

            List<MessageVO> result = IdenticalMatch(parameters);
            MessageSorter sorter = new MessageSorter();
            result.Sort(sorter);

            SetMessagesSeen(from, to);
            DeleteOldMessages(from, to);

            return result;
        }

        public List<MessageVO> GetChat(UserVO from, UserVO to)
        {
            List<MessageVO> m = GetMessages(to, from);
            m.AddRange(GetMessages(from, to));
            MessageSorter sorter = new MessageSorter();
            m.Sort(sorter);

            SetMessagesSeen(from, to);
            DeleteOldMessages(from, to);
            return m;
        }

        public bool DeleteOldMessages(UserVO from, UserVO to)
        {
            List<MessageVO> m = GetMessages(from, to);


            if (m.Count <= ConfigurationManager.MAXIMUM_MESSAGES_COUNT)
                return true;

            m.Sort(new MessageSorter());
            int firstOldMessageIndex = m.Count - 1 - ConfigurationManager.MAXIMUM_MESSAGES_COUNT;
            MessageVO firstOldMessage = m[firstOldMessageIndex];
            DateTime toDeleteDate = firstOldMessage.Date;
            string condition = string.Format("({0} <= @{0} and {1}=@{1} and {2}=@{2})", messageDate, messageFrom, messageTo);
            string statement = SqlStatememtGenerator.Delete_ByCondition(tableName, condition);

            SqlCeParameter[] parameters =
            {
                MakeSqlParameter(messageDate, toDeleteDate, SqlDbType.DateTime),
                MakeSqlParameter(messageFrom, from.Id),
                MakeSqlParameter(messageTo, to.Id)
            };

            return executer.ExecuteDeleteStatement(statement, parameters);
         
        }

        public bool SetMessagesSeen(UserVO fromUser, UserVO toUser)
        {
            string condition = string.Format("({0} = @{0} and {1} = @{1})", messageFrom, messageTo);
            string statement = SqlStatememtGenerator.Update_ByCondition(tableName, new string[] { messageIsSeen }, condition);

            SqlCeParameter[] parameters = 
            {
                MakeSqlParameter(messageFrom, fromUser.Id),
                MakeSqlParameter(messageTo, toUser.Id),
                MakeSqlParameter(messageIsSeen, true, SqlDbType.Bit)
            };

            return executer.ExecuteUpdateStatement(statement, parameters);
        }

        class MessageSorter : IComparer<MessageVO>
        {
            public int Compare(MessageVO x, MessageVO y)
            {
                return x.Date.CompareTo(y.Date);
            }
        }



    }
}

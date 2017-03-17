using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Common;
using System.Data.SqlClient;

namespace Library.DAL.Server
{
    class LogEntryDAO:ManyToManyDAO<LogEntryVO, UserVO, OperationVO>, Interface.ILogEntryDAO
    {
        public const string logEntryUserId = "logEntryUserId";
        public const string logEntryOperationId = "logEntryOperationId";
        public const string logEntryDateTime = "logEntryDateTime";
        public const string logEntryDescription = "logEntryDescription";

        public LogEntryDAO()
            : base("LogEntry", "logEntryId", 5, logEntryUserId, logEntryOperationId, new UserDAO(), new OperationDAO())
        { }


        protected override SqlParameter[] MakeSqlParameters(LogEntryVO vo)
        {
            SqlParameter[] paramteres = new SqlParameter[]
            {
                MakeSqlParameter(logEntryUserId, vo.UserId),
                MakeSqlParameter(logEntryOperationId, vo.OperationId),
                MakeSqlParameter(logEntryDateTime, vo.DateTime, System.Data.SqlDbType.DateTime),
                MakeSqlParameter(logEntryDescription, vo.Description, System.Data.SqlDbType.NVarChar)
            };

            return paramteres;
        }

        protected override string[] ConvertColumnNamesToArray()
        {
            return ConvertToArray(logEntryUserId, logEntryOperationId, logEntryDateTime, logEntryDescription);
        }

        public override LogEntryVO ReadRecord(System.Data.SqlClient.SqlDataReader reader)
        {
            LogEntryVO result = new LogEntryVO();
            result.Id = reader.GetInt32(reader.GetOrdinal(idColumnName));
            result.DateTime = reader.GetDateTime(reader.GetOrdinal(logEntryDateTime));
            result.Description = reader[logEntryDescription].ToString();
            int userId = reader.GetInt32(reader.GetOrdinal(logEntryUserId));
            int operationId = reader.GetInt32(reader.GetOrdinal(logEntryOperationId));

            result.User = firstTableDAO.GetItem(userId);
            result.Operation = secondTableDAO.GetItem(operationId);

            firstTableDAO.CloseConnection();
            secondTableDAO.CloseConnection();

            return result;
        }

        #region ILogEntryDAO Members
        private const string startParam = "RangeStart";
        private const string endParam = "RangeEnd";

        public List<LogEntryVO> Find(Common.Search.DateRange range, OperationVO operation, UserVO user)
        {
            SqlParameter[] parameters = GetParameters(range);
            string condition = GetCondition(range, operation, user);
            string statement = SqlStatememtGenerator.Select_ReadAllColumnsByCondition(tableName, condition);
            SqlDataReader reader = executer.ExecuteSelectStatement(statement, parameters);

            return ReadAllRecords(reader);
        }

        private SqlParameter[] GetParameters(Common.Search.DateRange range)
        {
            if (range == null)
                return null;

            return GetDateRangeParameters(range);
        }

        private string GetCondition(Common.Search.DateRange range, OperationVO operation, UserVO user)
        {
            StringBuilder builder = new StringBuilder();
            bool rangeB = false;
            bool operationB = false;

            if (range != null)
            {
                builder.Append(GetDateRangeCondition());
                rangeB = true;
            }

            if (operation != null)
            {
                if (rangeB)
                    builder.Append(" AND ");

                builder.Append(GetOperationCondition(operation));
                operationB = true;
            }

            if (user != null)
            {
                if (rangeB || operationB)
                    builder.Append(" AND ");

                builder.Append(GetUserCondition(user));
            }

            if (builder.Length == 0)
                return "1 = 1";

            return builder.ToString();
        }

        private string GetDateRangeCondition()
        {
            string condition = string.Format("({0} >= @{1} AND {0} < @{2})",logEntryDateTime, startParam, endParam);

            return condition;
        }

        private SqlParameter[] GetDateRangeParameters(Common.Search.DateRange range)
        {
            SqlParameter[] result = 
            {
                MakeSqlParameter(startParam, range.Start, System.Data.SqlDbType.DateTime),
                MakeSqlParameter(endParam, range.End, System.Data.SqlDbType.DateTime)
            };

            return result;
        }

        private string GetOperationCondition(OperationVO operation)
        {
            return string.Format("({0} = {1})", logEntryOperationId, operation.Id);
        }

        private string GetUserCondition(UserVO user)
        {
            return string.Format("({0} = {1})", logEntryUserId, user.Id);
        }
        #endregion
    }
}

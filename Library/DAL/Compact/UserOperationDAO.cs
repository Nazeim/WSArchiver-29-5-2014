using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Common;
using System.Data.SqlServerCe;

namespace Library.DAL.Compact
{
    class UserOperationDAO:ManyToManyDAO<UserOperationVO, UserVO, OperationVO>, Interface.IUserOperationDAO
    {
        public const string userOperationUserId = "userOperationUserId";
        public const string userOperationOperationId = "userOperationOperationId";

        public UserOperationDAO()
            : base("UserOperation", "userOperationId", 3, userOperationUserId, userOperationOperationId, new UserDAO(), new OperationDAO())
        { }

        protected override SqlCeParameter[] MakeSqlParameters(UserOperationVO vo)
        {
            SqlCeParameter[] parameters = new SqlCeParameter[] 
            {
                MakeSqlParameter(userOperationUserId, vo.UserId),
                MakeSqlParameter(userOperationOperationId, vo.OperationId)
            };

            return parameters;
        }

        protected override string[] ConvertColumnNamesToArray()
        {
            return ConvertToArray(userOperationUserId, userOperationOperationId);
        }

        public override UserOperationVO ReadRecord(System.Data.SqlServerCe.SqlCeDataReader reader)
        {
            UserOperationVO result = new UserOperationVO();
            result.Id = reader.GetInt32(reader.GetOrdinal(idColumnName));
            int userId = reader.GetInt32(reader.GetOrdinal(userOperationUserId));
            int operationId = reader.GetInt32(reader.GetOrdinal(userOperationOperationId));

            result.User = firstTableDAO.GetItem(userId);
            result.Operation = secondTableDAO.GetItem(operationId);
            firstTableDAO.CloseConnection();
            secondTableDAO.CloseConnection();

            return result;
            
        }
    }
}

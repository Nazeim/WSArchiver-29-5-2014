using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Library.Common;
using Library.DAL.Interface;
using System.Data.SqlClient;

namespace Library.DAL.Server
{
    class UserDAO:DAO<UserVO>,IUserDAO
    {   
        public const string userName= "userName";
        public const string userPassword = "userPassword";
        public const string userIsActive = "userIsActive";
        public const string userIsLoggedIn = "userIsLoggedIn";


        public UserDAO()
            : base("User", "userId", 5)
        { 
        }
        protected override SqlParameter[] MakeSqlParameters(UserVO vo)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                MakeSqlParameter(userName, vo.Username, SqlDbType.NVarChar),
                MakeSqlParameter(userPassword, vo.Password, SqlDbType.NVarChar),
                MakeSqlParameter(userIsActive, vo.IsActive, SqlDbType.Bit),
                MakeSqlParameter(userIsLoggedIn,vo.IsLoggedIn, SqlDbType.Bit)
            };

            return parameters;
        }

        protected override string[] ConvertColumnNamesToArray()
        {
            return ConvertToArray(userName, userPassword, userIsActive, userIsLoggedIn);
        }

        public override UserVO ReadRecord(SqlDataReader reader)
        {
            UserVO result = new UserVO();

            result.Id = reader.GetInt32(reader.GetOrdinal(idColumnName));
            result.Username = reader[userName].ToString();
            result.Password = reader[userPassword].ToString();
            result.IsActive = reader.GetBoolean(reader.GetOrdinal(userIsActive));
            result.IsLoggedIn = reader.GetBoolean(reader.GetOrdinal(userIsLoggedIn));

            return result;
        }

        #region IUserDAO Members

        public void FullLoad(UserVO vo)
        {
            UserOperationDAO dao = new UserOperationDAO();
            List<int> operationsIds = dao.GetAssociationsOfFirstTable(vo);
            dao.CloseConnection();

            OperationDAO opDao = new OperationDAO();
            List<OperationVO> result = new List<OperationVO>();

            foreach (int item in operationsIds)
                result.Add(opDao.GetItem(item));

            opDao.CloseConnection();
            vo.Permissions = result;
        }

        #endregion
    }
}

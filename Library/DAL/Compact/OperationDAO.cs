using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using System.Data;
using Library.Common;
using Library.DAL.Interface;

namespace Library.DAL.Compact
{
    class OperationDAO : DAO<OperationVO>, IOperationDAO
    {
        public const string operationName = "operationName";

        public OperationDAO()
            : base("Operation", "operationId", 2)
        {
        }

        protected override SqlCeParameter[] MakeSqlParameters(OperationVO vo)
        {
            SqlCeParameter[] parameters = new SqlCeParameter[]
             {
                 MakeSqlParameter(operationName,vo.Name,SqlDbType.NVarChar)
             };

            return parameters;
        }

        protected override string[] ConvertColumnNamesToArray()
        {
            return ConvertToArray(operationName);
        }

        public override OperationVO ReadRecord(SqlCeDataReader reader)
        {
            OperationVO result = new OperationVO();

            result.Id = reader.GetInt32(reader.GetOrdinal(idColumnName));
            result.Name = reader[operationName].ToString();

            return result;

        }

        #region IOperationDAO Members

        public bool Ping()
        {
            try
            {
                GetRecordsCount();

                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion
    }
}

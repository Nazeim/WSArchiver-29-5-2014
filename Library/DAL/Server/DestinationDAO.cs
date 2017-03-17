using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Library.Common;
using Library.DAL.Interface;

namespace Library.DAL.Server
{
    class DestinationDAO : DAO<DestinationVO>, IDestinationDAO
    {
        public const string destinationName = "destinationName";

        public DestinationDAO()
            : base("Destination", "destinationId", 2)
        {
        }

        protected override SqlParameter[] MakeSqlParameters(DestinationVO vo)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                 MakeSqlParameter(destinationName,vo.Name,SqlDbType.NVarChar)
            };

            return parameters;
        }

        protected override string[] ConvertColumnNamesToArray()
        {
            return ConvertToArray(destinationName);
        }

        public override DestinationVO ReadRecord(SqlDataReader reader)
        {
            DestinationVO result = new DestinationVO();

            result.Id = reader.GetInt32(reader.GetOrdinal(idColumnName));
            result.Name = reader[destinationName].ToString();

            return result;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Common;
using Library.DAL.Interface;
using System.Data.SqlServerCe;
using System.Data;

namespace Library.DAL.Compact
{
    class DestinationDAO : DAO<DestinationVO>, IDestinationDAO
    {
        public const string destinationName = "destinationName";

        public DestinationDAO()
            : base("Destination", "destinationId", 2)
        {
        }

        protected override SqlCeParameter[] MakeSqlParameters(DestinationVO vo)
        {
            SqlCeParameter[] parameters = new SqlCeParameter[]
            {
                 MakeSqlParameter(destinationName,vo.Name,SqlDbType.NVarChar)
            };

            return parameters;
        }

        protected override string[] ConvertColumnNamesToArray()
        {
            return ConvertToArray(destinationName);
        }

        public override DestinationVO ReadRecord(SqlCeDataReader reader)
        {
            DestinationVO result = new DestinationVO();

            result.Id = reader.GetInt32(reader.GetOrdinal(idColumnName));
            result.Name = reader[destinationName].ToString();

            return result;
        }

    }
}

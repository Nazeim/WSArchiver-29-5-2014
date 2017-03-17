using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Library.Common;
using Library.DAL.Interface;

namespace Library.DAL.Server
{
    class PartyDAO : DAO<PartyVO>, IPartyDAO
    {
        public const string partyName = "partyName";

        public PartyDAO()
            : base("Party", "partyId", 2)
        {
        }

        protected override SqlParameter[] MakeSqlParameters(PartyVO vo)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                MakeSqlParameter(partyName, vo.Name, SqlDbType.NVarChar)
            };

            return parameters;
        }

        protected override string[] ConvertColumnNamesToArray()
        {
            return ConvertToArray(partyName);
        }

        public override PartyVO ReadRecord(SqlDataReader reader)
        {
            PartyVO result = new PartyVO();

            result.Id = reader.GetInt32(reader.GetOrdinal(idColumnName));
            result.Name = reader[partyName].ToString();

            return result;
        }
    }
}

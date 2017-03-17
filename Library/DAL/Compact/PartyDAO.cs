using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Common;
using System.Data.SqlServerCe;
using System.Data;
using Library.DAL.Interface;

namespace Library.DAL.Compact
{
    class PartyDAO:DAO<PartyVO>, IPartyDAO
    {
        public const string partyName = "partyName";

        public PartyDAO()
            : base("Party", "partyId", 2)
        {
        }

        protected override SqlCeParameter[] MakeSqlParameters(PartyVO vo)
        {
            SqlCeParameter[] parameters = new SqlCeParameter[]
            {
                MakeSqlParameter(partyName, vo.Name, SqlDbType.NVarChar)
            };

            return parameters;
        }

        protected override string[] ConvertColumnNamesToArray()
        {
            return ConvertToArray(partyName);
        }

        public override PartyVO ReadRecord(SqlCeDataReader reader)
        {
            PartyVO result = new PartyVO();

            result.Id = reader.GetInt32(reader.GetOrdinal(idColumnName));
            result.Name = reader[partyName].ToString();

            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.DAL.Interface;
using Library.Common;
using System.Data.SqlServerCe;
using System.Data;

namespace Library.DAL.Compact
{
    class CategoryDAO : DAO<CategoryVO>, ICategoryDAO
    {
        public const string categoryName = "categoryName";

        public CategoryDAO()
            : base("Category", "categoryId", 2)
        {
        }

        protected override SqlCeParameter[] MakeSqlParameters(CategoryVO vo)
        {
            SqlCeParameter[] parameters = new SqlCeParameter[]
           {
                MakeSqlParameter(categoryName,vo.Name,SqlDbType.NVarChar)  
           };

            return parameters;
        }

        protected override string[] ConvertColumnNamesToArray()
        {
            return ConvertToArray(categoryName);
        }

        public override CategoryVO ReadRecord(SqlCeDataReader reader)
        {
            CategoryVO result = new CategoryVO();

            result.Id = reader.GetInt32(reader.GetOrdinal(idColumnName));
            result.Name = reader[categoryName].ToString();

            return result;

        }

    }
}

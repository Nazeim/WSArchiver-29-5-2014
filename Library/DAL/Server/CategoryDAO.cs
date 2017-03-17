using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Common;
using Library.DAL.Interface;
using System.Data;
using System.Data.SqlClient;

namespace Library.DAL.Server
{
    class CategoryDAO : DAO<CategoryVO>, ICategoryDAO
    {
        public const string categoryName = "categoryName";

        public CategoryDAO()
            : base("Category", "categoryId", 2)
        {
        }

        protected override SqlParameter[] MakeSqlParameters(CategoryVO vo)
        {
            SqlParameter[] parameters = new SqlParameter[]
           {
                MakeSqlParameter(categoryName,vo.Name,SqlDbType.NVarChar)  
           };

            return parameters;
        }

        protected override string[] ConvertColumnNamesToArray()
        {
            return ConvertToArray(categoryName);
        }

        public override CategoryVO ReadRecord(SqlDataReader reader)
        {
            CategoryVO result = new CategoryVO();

            result.Id = reader.GetInt32(reader.GetOrdinal(idColumnName));
            result.Name = reader[categoryName].ToString();

            return result;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Library.Common;
using Library.DAL.Interface;

namespace Library.DAL.Server
{
    public abstract class DAO<T> :IDAO<T> where T : VO
    {
        public readonly string tableName;
        public readonly string idColumnName;
        public readonly int columnsCount;

        protected SqlStatementExecuter executer;

        #region protected methods
        protected DAO(string tableName, string idColumnName, int columnsCount)
        {
            this.tableName = tableName;
            this.idColumnName = idColumnName;
            this.columnsCount = columnsCount;
            executer = new SqlStatementExecuter();
        }

        protected string[] ConvertToArray(params string[] parameters)
        {
            return parameters;
        }

        protected SqlParameter MakeSqlParameter(string columnName, object value)
        {
            SqlParameter result;
            object val;

            if (value != null)
            {
                if (value is string && String.IsNullOrEmpty(((string)value)))
                    val = DBNull.Value;
                else
                    val = value;
            }
            else
                val = DBNull.Value;

            result = new SqlParameter("@" + columnName, val);

            return result;
        }

        protected SqlParameter MakeSqlParameter(string columnName, object value, System.Data.SqlDbType type)
        {
            SqlParameter result = MakeSqlParameter(columnName, value);
            result.SqlDbType = type;

            return result;
        }

        abstract protected SqlParameter[] MakeSqlParameters(T vo);

        abstract protected string[] ConvertColumnNamesToArray();


        protected List<T> GetAllByColumnValue(string columnName, object value, System.Data.SqlDbType type)
        {
            SqlParameter parameter = MakeSqlParameter(columnName, value, type);

            return IdenticalMatch(new SqlParameter[] { parameter });
        }

        protected List<T> IdenticalMatch(SqlParameter[] parameters)
        {
            
            StringBuilder builder = new StringBuilder();

            if (parameters.Length > 0)
            {
                for (int i = 0; i < parameters.Length; i++)
                {
                    builder.AppendFormat("{0} = @{0}", parameters[i].ParameterName.Substring(1));

                    if (i < parameters.Length - 1)
                        builder.Append(" AND ");
                }
            }
            else
            {
                builder.AppendFormat("1 = 1");
            }

            string condition = builder.ToString();
            string statement = SqlStatememtGenerator.Select_ReadAllColumnsByCondition(tableName, condition);
            SqlDataReader reader = executer.ExecuteSelectStatement(statement, parameters);

            if (reader == null)
                return new List<T>();

            return ReadAllRecords(reader);
        }


        protected virtual Guid ReadGuid(SqlDataReader reader, string columnName)
        {
            return reader.GetGuid(reader.GetOrdinal(columnName));
        }
        protected virtual Guid? ReadGuidOrNull(SqlDataReader reader, string columnName)
        {
            if (reader.IsDBNull(reader.GetOrdinal(columnName)))
                return null;

            return ReadGuid(reader, columnName);
        }
        protected virtual int ReadInt(SqlDataReader reader, string columnName)
        {
            return reader.GetInt32(reader.GetOrdinal(columnName));
        }
        protected virtual int? ReadIntOrNull(SqlDataReader reader, string columnName)
        {
            if (reader.IsDBNull(reader.GetOrdinal(columnName)))
                return null;

            return reader.GetInt32(reader.GetOrdinal(columnName));
        }
        protected virtual bool ReadBool(SqlDataReader reader, string columnName)
        {
            return reader.GetBoolean(reader.GetOrdinal(columnName));
        }
        protected virtual DateTime? ReadDateTimeOrNull(SqlDataReader reader, string columnName)
        {
            if (reader.IsDBNull(reader.GetOrdinal(columnName)))
                return null;

            return reader.GetDateTime(reader.GetOrdinal(columnName));
        }
        protected virtual DateTime ReadDateTime(SqlDataReader reader, string columnName)
        {
            return reader.GetDateTime(reader.GetOrdinal(columnName));
        }
        protected virtual string ReadString(SqlDataReader reader, string columnName)
        {
            try
            {
                return reader[columnName].ToString();
            }
            catch
            {
                return "";
            }
        }
        #endregion

        #region public methods
        abstract public T ReadRecord(SqlDataReader reader);
        /// <summary>
        /// Inserts the object in databse and sets its Id property to the inserted record id.
        /// </summary>
        /// <param name="vo">The VO object to be inserted.</param>
        /// <returns>The inserted record id. -1 if the insertion was not successful.</returns>
        public virtual int Insert(T vo)
        {
            string[] columnsNames = ConvertColumnNamesToArray();
            string statement = SqlStatememtGenerator.Insert(tableName, columnsNames);
            SqlParameter[] parameters = MakeSqlParameters(vo);
            int id = executer.ExecuteInsertStatement(statement, parameters);
            vo.Id = id;

            return id;
        }

        public virtual bool Update(T vo)
        {
            string[] columnsNames = ConvertColumnNamesToArray();
            string statement = SqlStatememtGenerator.Update_ById(tableName, columnsNames, idColumnName);

            SqlParameter[] parameters = new SqlParameter[columnsCount];
            Array.Copy(MakeSqlParameters(vo), parameters, columnsCount - 1);
            parameters[columnsCount - 1] = MakeSqlParameter(idColumnName, vo.Id);

            bool result = executer.ExecuteUpdateStatement(statement, parameters);

            return result;
        }

        public virtual bool DeleteAll()
        {
            string statement = SqlStatememtGenerator.Delete_ByCondition(tableName, "1=1");

            return executer.ExecuteDeleteStatement(statement, null);
        }

        public virtual bool DeleteItem(int id)
        {
            string statement = SqlStatememtGenerator.Delete_ById(tableName, idColumnName);
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = MakeSqlParameter(idColumnName, id);
            bool result = executer.ExecuteDeleteStatement(statement, parameters);

            return result;
        }

        public void CloseConnection()
        {
            executer.CloseConnection();
        }

        public virtual T GetItem(int id)
        {
            string statement = SqlStatememtGenerator.Select_ReadAllColumnsById(tableName, idColumnName);
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = MakeSqlParameter(idColumnName, id);
            SqlDataReader reader = executer.ExecuteSelectStatement(statement, parameters);

            if (reader == null)
                return null;

            T result = null;

            if (reader.HasRows)
            {
                reader.Read();
                result = ReadRecord(reader);
            }

            reader.Close();

            return result;
        }

        public virtual List<T> GetAll()
        {
            string statement = SqlStatememtGenerator.Select_ReadAllColumnsByCondition(tableName, "1=1");
            SqlDataReader reader = executer.ExecuteSelectStatement(statement, null);

            if (reader == null)
                return new List<T>();

            return ReadAllRecords(reader);
        }

        public virtual List<T> ReadAllRecords(SqlDataReader reader)
        {
            List<T> result = new List<T>();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    result.Add(ReadRecord(reader) as T);
                }
            }

            reader.Close();

            return result;
        }

        public virtual int GetRecordsCount()
        {
            string condition = " 1 = 1 ";
            string statement = SqlStatememtGenerator.Select_ReadSomeColumnsByCondition(tableName, new string[] { "count(*)" }, condition);

            return Convert.ToInt32(executer.ExecuteScalarSelectStatement(statement, null));
        }

        public int GetMaxId()
        {
            string[] temp = new string[]{
                string.Format("max({0})", idColumnName)
            };
            string statement = SqlStatememtGenerator.Select_ReadSomeColumnsByCondition(tableName, temp, "1=1");

            try
            {
                int result = Convert.ToInt32(executer.ExecuteScalarSelectStatement(statement, null));
                return result;
            }
            catch
            {
                return -1;
            }

        }

        public DateTime GetDate()
        {

            return Convert.ToDateTime(executer.ExecuteScalarSelectStatement("SELECT SYSDATETIME();", null));

        }
        #endregion
    }
}

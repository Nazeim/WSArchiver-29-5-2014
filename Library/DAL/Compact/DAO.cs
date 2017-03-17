using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Common;
using System.Data.SqlServerCe;
using Library.DAL.Interface;


namespace Library.DAL.Compact
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

        protected SqlCeParameter MakeSqlParameter(string columnName, object value)
        {
            SqlCeParameter result;
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

            result = new SqlCeParameter("@" + columnName, val);

            return result;
        }

        protected SqlCeParameter MakeSqlParameter(string columnName, object value, System.Data.SqlDbType type)
        {
            SqlCeParameter result = MakeSqlParameter(columnName, value);
            result.SqlDbType = type;

            return result;
        }

        abstract protected SqlCeParameter[] MakeSqlParameters(T vo);

        abstract protected string[] ConvertColumnNamesToArray();

        protected List<T> GetAllByColumnValue(string columnName, object value, System.Data.SqlDbType type)
        {
            SqlCeParameter parameter = MakeSqlParameter(columnName, value, type);

            return IdenticalMatch(new SqlCeParameter[] { parameter });
        }

        protected List<T> IdenticalMatch(SqlCeParameter[] parameters)
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
            SqlCeDataReader reader = executer.ExecuteSelectStatement(statement, parameters);

            if (reader == null)
                return new List<T>();

            return ReadAllRecords(reader);
        }

        protected virtual Guid ReadGuid(SqlCeDataReader reader, string columnName)
        {
            return reader.GetGuid(reader.GetOrdinal(columnName));
        }

        protected virtual Guid? ReadGuidOrNull(SqlCeDataReader reader, string columnName)
        {
            if(reader.IsDBNull(reader.GetOrdinal(columnName)))
                return null;

            return ReadGuid(reader, columnName);
        }
        protected virtual int ReadInt(SqlCeDataReader reader, string columnName)
        {
            return reader.GetInt32(reader.GetOrdinal(columnName));
        }
        protected virtual int? ReadIntOrNull(SqlCeDataReader reader, string columnName)
        {
            if (reader.IsDBNull(reader.GetOrdinal(columnName)))
                return null;

            return reader.GetInt32(reader.GetOrdinal(columnName));
        }
        protected virtual bool ReadBool(SqlCeDataReader reader, string columnName)
        {
            return reader.GetBoolean(reader.GetOrdinal(columnName));
        }
        protected virtual DateTime? ReadDateTimeOrNull(SqlCeDataReader reader, string columnName)
        {
            if (reader.IsDBNull(reader.GetOrdinal(columnName)))
                return null;

            return reader.GetDateTime(reader.GetOrdinal(columnName));
        }
        protected virtual DateTime ReadDateTime(SqlCeDataReader reader, string columnName)
        {
            return reader.GetDateTime(reader.GetOrdinal(columnName));
        }
        protected virtual string ReadString(SqlCeDataReader reader, string columnName)
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
        abstract public T ReadRecord(SqlCeDataReader reader);
        /// <summary>
        /// Inserts the object in databse and sets its Id property to the inserted record id.
        /// </summary>
        /// <param name="vo">The VO object to be inserted.</param>
        /// <returns>The inserted record id. -1 if the insertion was not successful.</returns>
        public virtual int Insert(T vo)
        {
            string[] columnsNames = ConvertColumnNamesToArray();
            string statement = SqlStatememtGenerator.Insert(tableName, columnsNames);
            SqlCeParameter[] parameters = MakeSqlParameters(vo);

            if (!executer.ExecuteInsertStatement(statement, parameters))
                return -1;

            int id = GetMaxId();
            vo.Id = id;

            return id;
        }

        public virtual bool Update(T vo)
        {
            string[] columnsNames = ConvertColumnNamesToArray();
            string statement = SqlStatememtGenerator.Update_ById(tableName, columnsNames, idColumnName);

            SqlCeParameter[] parameters = new SqlCeParameter[columnsCount];
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
            SqlCeParameter[] parameters = new SqlCeParameter[1];
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
            SqlCeParameter[] parameters = new SqlCeParameter[1];
            parameters[0] = MakeSqlParameter(idColumnName, id);
            SqlCeDataReader reader = executer.ExecuteSelectStatement(statement, parameters);

            if (reader == null)
                return null;

            T result = null;

            try
            {
                reader.Read();
                result = ReadRecord(reader);
            }
            catch { }

            reader.Close();

            return result;
        }

        public virtual List<T> GetAll()
        {
            string statement = SqlStatememtGenerator.Select_ReadAllColumnsByCondition(tableName, "1=1");
            SqlCeDataReader reader = executer.ExecuteSelectStatement(statement, null);

            if (reader == null)
                return new List<T>();

            return ReadAllRecords(reader);
        }

        public virtual List<T> ReadAllRecords(SqlCeDataReader reader)
        {
            List<T> result = new List<T>();
            
            try
            {
                while (reader.Read())
                {
                    result.Add(ReadRecord(reader) as T);
                }
            }
            catch
            {

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
            return DateTime.Now;
        }

       
        #endregion


        
    }
}

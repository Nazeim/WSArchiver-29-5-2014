using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Library.Common;
using Library.DAL.Interface;

namespace Library.DAL.Server
{
    public abstract class ManyToManyDAO<T, T1, T2> : DAO<T>, IManyToManyDAO<T, T1, T2>
        where T : VO
        where T1 : VO
        where T2 : VO
    {
        protected readonly string firstTableIdColumnName;
        protected readonly string secondTableIdColumnName;
        protected DAO<T1> firstTableDAO;
        protected DAO<T2> secondTableDAO;

        public ManyToManyDAO(string tableName, string idColumnName, int columnsCount
            , string firstTableIdColumnName, string secondTableIdColumnName, DAO<T1> firstTable, DAO<T2> secondTable)
            : base(tableName, idColumnName, columnsCount)
        {
            this.firstTableIdColumnName = firstTableIdColumnName;
            this.secondTableIdColumnName = secondTableIdColumnName;
            this.firstTableDAO = firstTable;
            this.secondTableDAO = secondTable;
        }

        public bool IsAttached(T1 firstTableVO, T2 secondTableVO)
        {
            return GetAssociationsCount(firstTableVO, secondTableVO) > 0;
        }

        public int Attach(T1 firstTableVO, T2 secondTableVO)
        {
            string statement = SqlStatememtGenerator.Insert(tableName, ConvertToArray(firstTableIdColumnName, secondTableIdColumnName));
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = MakeSqlParameter(firstTableIdColumnName, firstTableVO.Id);
            parameters[1] = MakeSqlParameter(secondTableIdColumnName, secondTableVO.Id);

            return executer.ExecuteInsertStatement(statement, parameters);
        }

        public bool Detach(T1 firstTableVO, T2 secondTableVO)
        {
            string condition = string.Format("{0} = @{0} and {1} = @{1}", firstTableIdColumnName, secondTableIdColumnName);
            string statement = SqlStatememtGenerator.Delete_ByCondition(tableName, condition);

            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = MakeSqlParameter(firstTableIdColumnName, firstTableVO.Id);
            parameters[1] = MakeSqlParameter(secondTableIdColumnName, secondTableVO.Id);

            return executer.ExecuteDeleteStatement(statement, parameters);
        }

        public int GetAssociationsCount(T1 firstTableVO, T2 secondTableVO)
        {
            try
            {
                string condition = string.Format("{0}=@{0} and {1}=@{1}", firstTableIdColumnName, secondTableIdColumnName);
                string statement = SqlStatememtGenerator.Select_ReadSomeColumnsByCondition(tableName, new string[] { "count(*)" }, condition);

                SqlParameter[] parameters = new SqlParameter[2];
                parameters[0] = MakeSqlParameter(firstTableIdColumnName, firstTableVO.Id);
                parameters[1] = MakeSqlParameter(secondTableIdColumnName, secondTableVO.Id);

                int count = Convert.ToInt32(executer.ExecuteScalarSelectStatement(statement, parameters).ToString());

                return count;
            }
            catch
            {
                return -1;
            }
        }

        public int GetAssociationsCountOfFirstTable(T1 firstTableVO)
        {
            try
            {
                string condition = string.Format("{0}=@{0}", firstTableIdColumnName);
                string statement = SqlStatememtGenerator.Select_ReadSomeColumnsByCondition(tableName, new string[] { "count(*)" }, condition);

                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = MakeSqlParameter(firstTableIdColumnName, firstTableVO.Id);

                int count = Convert.ToInt32(executer.ExecuteScalarSelectStatement(statement, parameters).ToString());

                return count;
            }
            catch
            {
                return -1;
            }
        }

        public int GetAssociationsCountOfSecondTable(T2 secondTableVO)
        {
            try
            {
                string condition = string.Format("{0}=@{0}", secondTableIdColumnName);
                string statement = SqlStatememtGenerator.Select_ReadSomeColumnsByCondition(tableName, new string[] { "count(*)" }, condition);

                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = MakeSqlParameter(secondTableIdColumnName, secondTableVO.Id);

                int count = Convert.ToInt32(executer.ExecuteScalarSelectStatement(statement, parameters).ToString());

                return count;
            }
            catch
            {
                return -1;
            }
        }

        private List<int> GetAssociationsOfTable(VO tableElement, string providedTableColumnName, string requiredTableColumnName)
        {
            List<int> result = new List<int>();
            string condition = string.Format("{0} = @{0}", providedTableColumnName);
            string statement = SqlStatememtGenerator.Select_ReadAllColumnsByCondition(tableName, condition);

            SqlParameter[] parameters = new SqlParameter[] { MakeSqlParameter(providedTableColumnName, tableElement.Id) };
            SqlDataReader reader = executer.ExecuteSelectStatement(statement, parameters);

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    result.Add(reader.GetInt32(reader.GetOrdinal(requiredTableColumnName)));
                }
            }

            reader.Close();
            return result;
        }

        public List<int> GetAssociationsOfFirstTable(T1 firstTableElement)
        {
            return GetAssociationsOfTable(firstTableElement, firstTableIdColumnName, secondTableIdColumnName);
        }

        public List<int> GetAssociationsOfSecondTable(T2 secondTableElement)
        {
            return GetAssociationsOfTable(secondTableElement, secondTableIdColumnName, firstTableIdColumnName);
        }

        private bool DeleteAssociationsOfTableElement(VO tableElement, string providedTableColumnName)
        {
            string condition = string.Format("{0} = @{0}", providedTableColumnName);
            string statement = SqlStatememtGenerator.Delete_ByCondition(tableName, condition);
            SqlParameter[] parameters = new SqlParameter[] { MakeSqlParameter(providedTableColumnName, tableElement.Id) };

            return executer.ExecuteDeleteStatement(statement, parameters);
        }

        public bool DeleteAssociationsOfFirstTableElement(T1 tableElement)
        {
            return DeleteAssociationsOfTableElement(tableElement, firstTableIdColumnName);
        }

        public bool DeleteAssociationsOfSecondTableElement(T2 tableElement)
        {
            return DeleteAssociationsOfTableElement(tableElement, firstTableIdColumnName);
        }
    }
}

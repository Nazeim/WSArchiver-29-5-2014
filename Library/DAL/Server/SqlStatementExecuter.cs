﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Library.DAL.Server
{
    public class SqlStatementExecuter
    {
        private SqlConnection connection;

        /// <summary>
        /// Initialise the object, this does not open the connection
        /// </summary>
        public SqlStatementExecuter()
        {
            try
            {
                connection = new SqlConnection(ConfigurationManager.SqlServerConnectionString);
                //connection = new SqlConnection(string.Format(@"Data Source={0}\SQLEXPRESS2012;Initial Catalog=WSArchiverDB;Integrated Security=True", ConfigurationManager.DBServerName));
            }
            catch
            {
                connection = null;
            }
        }

        /// <summary>
        /// Open database connection if closed or broken.
        /// </summary>
        private void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed || connection.State == ConnectionState.Broken)
            {
                connection.Open();
            }
        }

        /// <summary>
        /// Closes the connection
        /// </summary>
        public void CloseConnection()
        {
            connection.Close();
        }

        /// <summary>
        /// Opens the connection (if not open already) and initializes a new SqlCommand.
        /// </summary>
        /// <param name="query">The text of the sql statement.</param>
        /// <param name="sqlParameter">The parameters of the sql statement.</param>
        /// <returns>An initialized SqlCommand with an open connection</returns>
        private SqlCommand CreateCommand(string query, SqlParameter[] sqlParameter)
        {
            OpenConnection();
            SqlCommand myCommand = new SqlCommand(query, connection);

            if (sqlParameter != null)
                myCommand.Parameters.AddRange(sqlParameter);

            return myCommand;
        }


        /// <summary>
        /// Executes a select query which returns a table. This method opens a connection but doesn't close it explicitly. 
        /// </summary>
        /// <param name="query">The text of the T-SQL select statement to run against the database.</param>
        /// <param name="sqlParameter">A list of the parameters required by the select statement.<keyword>null</keyword> if no parameters are required by the statement</param>
        /// <returns>An SqlCeDataReader which can read the selected rows.</returns>
        /// <exception cref="SqlException">Could be thrown.</exception>
        public SqlDataReader ExecuteSelectStatement(string query, SqlParameter[] sqlParameter)
        {
            try
            {
                SqlCommand myCommand = CreateCommand(query, sqlParameter);

                return myCommand.ExecuteReader();
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Executes a select query which returns a scalar value. This method opens a connection but doesn't close it explicitly. 
        /// </summary>
        /// <param name="query">The text of the T-SQL select statement to run against the database.</param>
        /// <param name="sqlParameter">A list of the parameters required by the select statement.<keyword>null</keyword> if no parameters are required by the statement</param>
        /// <returns>The scalar value returned as the reesult of the query.</returns>
        /// <exception cref="SqlException">Could be thrown.</exception>
        public object ExecuteScalarSelectStatement(string query, SqlParameter[] sqlParameter)
        {
            try
            {
                SqlCommand myCommand = CreateCommand(query, sqlParameter);
                object result = myCommand.ExecuteScalar();
                return result;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// A general method to execute any sql statement which returns no results.
        /// </summary>
        /// <param name="statement">The text of the statement.</param>
        /// <param name="sqlParameter">The parameters of the statement.</param>
        /// <returns>A boolean which represents the success of the execution of the statement.</returns>
        public bool ExecuteNonQuery(string statement, SqlParameter[] sqlParameter)
        {
            try
            {
                SqlCommand myCommand = CreateCommand(statement, sqlParameter);
                myCommand.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Executes an insert statement and returns the id of the inserted record.
        /// </summary>
        /// <param name="statement">The text of the statement.</param>
        /// <param name="sqlParameter">The parameters of the statement.</param>
        /// <returns>The id of the inserted record. -1 if insertion is not successful.</returns>
        public int ExecuteInsertStatement(string statement, SqlParameter[] sqlParameter)
        {
            statement += " select SCOPE_IDENTITY();";

            try
            {
                return Convert.ToInt32(ExecuteScalarSelectStatement(statement, sqlParameter));
            }
            catch
            {
                return -1;
            }
        }

        /// <summary>
        /// Executes an update statement.
        /// </summary>
        /// <param name="statement">The text of the statement.</param>
        /// <param name="sqlParameter">The parameters of the statement.</param>
        /// <returns>A boolean which represents the success of the execution of the statement.</returns>
        public bool ExecuteUpdateStatement(string statement, SqlParameter[] sqlParameter)
        {
            return ExecuteNonQuery(statement, sqlParameter);
        }

        /// <summary>
        /// Executes a delete statement.
        /// </summary>
        /// <param name="statement">The text of the statement.</param>
        /// <param name="sqlParameter">The parameters of the statement.</param>
        /// <returns>A boolean which represents the success of the execution of the statement.</returns>
        public bool ExecuteDeleteStatement(string statement, SqlParameter[] sqlParameter)
        {
            return ExecuteNonQuery(statement, sqlParameter);
        }

        public SqlDataReader ExecuteStoredProcedure(string spName, params SqlParameter[] parameters)
        {
            try
            {
                SqlCommand myCommand = CreateCommand(spName, parameters);
                myCommand.CommandType = CommandType.StoredProcedure;
                SqlDataReader result = myCommand.ExecuteReader();

                return result;
            }
            catch
            {
                return null;
            }
        }

        public SqlTransaction BeginTransaction(System.Data.IsolationLevel isoLevel)
        {
            OpenConnection();
            return connection.BeginTransaction(isoLevel);
        }
    }
}
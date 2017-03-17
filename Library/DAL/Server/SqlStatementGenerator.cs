using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.IO;
using System.Collections;

namespace Library.DAL.Server
{
    public class SqlStatememtGenerator
    {
        //To use with column names
        private static string MakeCommaSeparatedList(IList list)
        {
            if (list.Count == 0)
                return "";
            string commaSeparatedList = list[0].ToString();

            for (int i = 1; i < list.Count; i++)
            {
                commaSeparatedList += ", " + list[i];
            }

            return commaSeparatedList;
        }


        private static string[] MakeParameters(string[] list)
        {
            string[] result = new string[list.Length];

            for (int i = 0; i < list.Length; i++)
                result[i] = "@" + list[i];

            return result;
        }
        //Get maximum value of primary key of some table
        public static string Select_GetMaxID(string tableName, string idColumnName)
        {
            string selectStatement = string.Format("select MAX({0}) from [{1}];", idColumnName, tableName);

            return selectStatement;
        }

        //To insert a new record in a table
        public static string Insert(string tableName, string[] columnsNames)
        {
            string commaColNames = MakeCommaSeparatedList(columnsNames);
            string[] parameters = MakeParameters(columnsNames);
            string commaValues = MakeCommaSeparatedList(parameters);

            string insertStatement = string.Format("insert into [{0}]({1}) values ({2});", tableName, commaColNames, commaValues);

            return insertStatement;
        }

        /*Operations By A Primary Key*/
        //To get a record from the database
        public static string Select_ReadAllColumnsById(string tableName, string idColumnName)
        {
            string selectCondition = string.Format("{0} = {1}", idColumnName, "@" + idColumnName);
            string statement = Select_ReadAllColumnsByCondition(tableName, selectCondition);

            return statement;
        }

        public static string Select_ReadAllColumnsByIds(string tableName, string idColumnName, List<int> ids)
        {
            string idsAsList = MakeCommaSeparatedList(ids);
            string condition = string.Format("{0} in ({1})", idColumnName, idsAsList);
            string statement = Select_ReadAllColumnsByCondition(tableName, condition);

            return statement;
        }

        public static string Select_ReadSomeColumnsById(string tableName, string[] columns, string idColumnName)
        {
            string selectCondition = string.Format("{0} = {1}", idColumnName, "@" + idColumnName);
            string statement = Select_ReadSomeColumnsByCondition(tableName, columns, selectCondition);

            return statement;
        }

        //To delete a record from the database
        public static string Delete_ById(string tableName, string idColumnName)
        {
            string condition = string.Format("{0} = {1}", idColumnName, "@" + idColumnName);

            return Delete_ByCondition(tableName, condition);
        }

        //To update a record from database
        public static string Update_ById(string tableName, string[] toUpdateColumnNames, string idColumnName)
        {
            string condition = string.Format("{0} = {1}", idColumnName, "@" + idColumnName);

            return Update_ByCondition(tableName, toUpdateColumnNames, condition);
        }

        /*Operations By A Condition*/
        //To get records from the database by a condition
        private static string Select_ReadRecords(string tableName, string toSelectString, string selectCondition)
        {
            string selectCommand = string.Format("select {0} from [{1}] where {2};", toSelectString, tableName, selectCondition);

            return selectCommand;
        }

        public static string Select_ReadAllColumnsByCondition(string tableName, string selectCondition)
        {
            return Select_ReadRecords(tableName, " * ", selectCondition);
        }

        public static string Select_ReadSomeColumnsByCondition(string tableName, string[] toSelectColumnNames, string selectionCondition)
        {
            string columns = MakeCommaSeparatedList(toSelectColumnNames);

            return Select_ReadRecords(tableName, columns, selectionCondition);
        }

        //To delete records from database by a condition
        public static string Delete_ByCondition(string tableName, string deleteCondition)
        {
            string deleteStatement = string.Format("delete from [{0}] where {1};", tableName, deleteCondition);

            return deleteStatement;
        }

        //To update records from database by a condition
        public static string Update_ByCondition(string tableName, string[] toUpdateColumnNames, string updateCondition)
        {
            string[] parameters = MakeParameters(toUpdateColumnNames);
            string[] assignments = new string[toUpdateColumnNames.Length];
            string commaAssignments;

            for (int i = 0; i < assignments.Length; i++)
                assignments[i] = toUpdateColumnNames[i] + " = " + parameters[i];

            commaAssignments = MakeCommaSeparatedList(assignments);

            string updateStatement = string.Format("update [{0}] set {1} where {2};", tableName, commaAssignments, updateCondition);

            return updateStatement;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Common;
using Library.Common.Search;
using Library.DAL.Interface;

namespace Library.BLL
{
    public class LogManager:Manager<LogEntryVO>
    {
        OperationsManager manager = new OperationsManager();

        public LogManager()
            : base(DAL.DALManager.GetLogEntryDAO())
        {

        }

        public void Write(string operationS, string description)
        {
            UserVO user = ConfigurationManager.currUser;
            OperationVO operation = manager.GetOperationByName(operationS);

            if (operation == null)
                return;

            LogEntryVO entry = new LogEntryVO() 
            {
                DateTime = DateTime.Now,
                Operation = operation,
                User = user,
                Description = description,
                Id = -1
            };

            Insert(entry);

        }

        public void Write(string operationS)
        {
            string desc = string.Format("{0} {1} {2}{3}", "قام المستخدم", ConfigurationManager.currUser.Username, "ب", operationS);
            Write(operationS, desc);
        }

        public List<LogEntryVO> Find(DateRange range, OperationVO operation, UserVO user)
        {
            List<LogEntryVO> result = ((ILogEntryDAO)dataAccessObject).Find(range, operation, user);
            dataAccessObject.CloseConnection();

            return result;
        }
    }
}

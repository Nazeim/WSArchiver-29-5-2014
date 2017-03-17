using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.Common
{
    public class LogEntryVO : VO
    {
        private UserVO user;
        private OperationVO operation;
        private DateTime dateTime;
        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public DateTime DateTime
        {
            get { return dateTime; }
            set { dateTime = value; }
        }

        public int OperationId
        {
            get
            {
                return operation.Id;
            }
        }

        public int UserId
        {
            get
            {
                return user.Id;
            }
        }

        public OperationVO Operation
        {
            get { return operation; }
            set { operation = value; }
        }

        public UserVO User
        {
            get { return user; }
            set { user = value; }
        }
    }
}

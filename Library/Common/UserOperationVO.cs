using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.Common
{
    public class UserOperationVO : VO
    {
        private UserVO user;
        private OperationVO operation;

        public OperationVO Operation
        {
            get { return operation; }
            set { operation = value; }
        }

        public int OperationId
        {
            get
            {
                return operation.Id;
            }
        }

        public UserVO User
        {
            get { return user; }
            set { user = value; }
        }

        public int UserId
        {
            get
            {
                return user.Id;
            }
        }
    }
}

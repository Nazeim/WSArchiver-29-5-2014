using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.Common
{
    public class UserVO : VO
    {
        private string username;
        private string password;
        private bool isActive;
        private bool isLoggedIn;

       
        private List<OperationVO> permissions;

        public List<OperationVO> Permissions
        {
            get { return permissions; }
            set { permissions = value; }
        }

        public bool IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string IsActiveAsString
        {
            get
            {
                if (IsActive)
                    return "مفعل";
                return "غير مفعل";
            }

        }

        public bool IsLoggedIn
        {
            get { return isLoggedIn; }
            set { isLoggedIn = value; }
        }


        public override string ToString()
        {
            return Username;
        }

    }
}

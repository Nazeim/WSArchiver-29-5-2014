using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Common;
using Library.DAL;
using System.Security.Cryptography;


namespace Library.BLL
{
    public class UsersManager : Manager<UserVO>
    {
        public enum AuthenticationResult
        {
            WRONG_PASSWORD,
            WRONG_USER_NAME,
            SUCCESSFUL,
            NOT_ACTIVE,
            NO_USERS_IN_DB,
            CONNECTION_ERROR,
            NO_PERMISSION
        }

        private const string ADMIN_USER_NAME = "Admin";
        private const string ADMIN_PASSWORD = "Admin";

        public UsersManager()
            : base(DALManager.GetUserDAO())
        { }

        public bool IsUserNew(UserVO user)
        {
            List<UserVO> users = GetAll();

            foreach (UserVO u in users)
            {
                if (!(u.Id == user.Id))
                {
                    if (user.Username == u.Username)
                        return false;
                }
            }

            return true;
        }

        public AuthenticationResult Authenticate(UserVO user)
        {
            try
            {
                if (user.Username == ADMIN_USER_NAME)
                    RestoreAdmin();

                List<UserVO> all = GetAll();

                if (all.Count == 0)
                    return AuthenticationResult.NO_USERS_IN_DB;

                foreach (UserVO curUser in all)
                {
                    if (curUser.Username == user.Username)
                    {
                        user.IsActive = curUser.IsActive;

                        if (ValidateHash(user.Password, curUser.Password))
                        {
                            if (curUser.IsActive)
                            {
                                OperationsManager manager = new OperationsManager();
                                user.Id = curUser.Id;

                                if(manager.HasPermission(OperationsManager.LOGIN_LOGOUT, user))
                                {
                                    user.Permissions = manager.GetOperationsOfUser(user);

                                    return AuthenticationResult.SUCCESSFUL;
                                }
                                else
                                    return AuthenticationResult.NO_PERMISSION;
                            }
                            else
                                return AuthenticationResult.NOT_ACTIVE;
                        }
                        else
                            return AuthenticationResult.WRONG_PASSWORD;
                    }
                }

                return AuthenticationResult.WRONG_USER_NAME;
            }
            catch
            {
                return AuthenticationResult.CONNECTION_ERROR;
            }
        }

        public string GenerateHash(string original)
        {
            MD5 hasher = MD5.Create();
            byte[] hashBytes = hasher.ComputeHash(ASCIIEncoding.UTF8.GetBytes(original));
            StringBuilder sBuilder = new StringBuilder();
  
          for (int i = 0; i < hashBytes.Length; i++)
          {
              sBuilder.Append(hashBytes[i].ToString("x2"));
          }

            return sBuilder.ToString();
        }

        private bool ValidateHash(string password, string storedHash)
        {
            string passwordHash = GenerateHash(password);

            return (passwordHash.Equals(storedHash));
        }

        private UserVO GetUserByName(string name)
        {
            List<UserVO> users = GetAll();

            foreach (UserVO user in users)
                if (user.Username == name)
                    return user;

            return null;
        }

        //Called on every Admin login
        public bool RestoreAdmin()
        {
            OperationsManager manager = new OperationsManager();
            List<OperationVO> all = manager.GetAll();
            UserVO admin = GetUserByName(ADMIN_USER_NAME);

            if (admin == null)
            {
                UserVO user = new UserVO();
                user.Username = ADMIN_USER_NAME;
                user.Password = GenerateHash(ADMIN_PASSWORD);
                user.IsActive = true;

                if (Insert(user) < 0)
                    return false;

                admin = user;
            }

            if(all != null )
            {
                return manager.AssignPermissionsToUser(admin, all);
            }

            return false;
        }

        public bool IsAdmin(UserVO user)
        {
            return user.Username == ADMIN_USER_NAME;
        }
    }
}

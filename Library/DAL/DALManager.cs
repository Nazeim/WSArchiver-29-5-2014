using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.DAL.Interface;

namespace Library.DAL
{
    class DALManager
    {
        public static ICategoryDAO GetCategoryDAO()
        {
            if(ConfigurationManager.IsLocalConnection)
                return new Compact.CategoryDAO();

            return new Server.CategoryDAO();
        }

        public static IDestinationDAO GetDestinationDAO()
        {
            if (ConfigurationManager.IsLocalConnection)
                return new Compact.DestinationDAO();

            return new Server.DestinationDAO();
        }

        public static IDocumentDAO GetDocumentDAO()
        {
            if (ConfigurationManager.IsLocalConnection)
                return new Compact.DocumentDAO();

            return new Server.DocumentDAO();
        }

        public static IDocumentCategoryDAO GetDocumentCategoryDAO()
        {
            if (ConfigurationManager.IsLocalConnection)
                return new Compact.DocumentCategoryDAO();

            return new Server.DocumentCategoryDAO();
        }

        public static IFileDAO GetFileDAO()
        {
            if (ConfigurationManager.IsLocalConnection)
                return new Compact.FileDAO();

            return new Server.FileDAO();
        }

        public static IFolderDAO GetFolderDAO()
        {
            if (ConfigurationManager.IsLocalConnection)
                return new Compact.FolderDAO();

            return new Server.FolderDAO();
        }

        public static ILogEntryDAO GetLogEntryDAO()
        {
            if (ConfigurationManager.IsLocalConnection)
                return new Compact.LogEntryDAO();

            return new Server.LogEntryDAO();
        }

        public static IOperationDAO GetOperationDAO()
        {
            if (ConfigurationManager.IsLocalConnection)
                return new Compact.OperationDAO();

            return new Server.OperationDAO();
        }

        public static IPartyDAO GetPartyDAO()
        {
            if (ConfigurationManager.IsLocalConnection)
                return new Compact.PartyDAO();

            return new Server.PartyDAO();
        }

        public static IUserDAO GetUserDAO()
        {
            if (ConfigurationManager.IsLocalConnection)
                return new Compact.UserDAO();

            return new Server.UserDAO();
        }

        public static IUserOperationDAO GetUserOperation()
        {
            if (ConfigurationManager.IsLocalConnection)
                return new Compact.UserOperationDAO();

            return new Server.UserOperationDAO() ;
        }

        public static IMessageDAO GetMessageDAO()
        {
            if (ConfigurationManager.IsLocalConnection)
                return new Compact.MessageDAO();

            return new Server.MessageDAO();
        
        }
        public static IBackupRestoreDAO GetBackupRestoreDAO()
        {
            if (ConfigurationManager.IsLocalConnection)
                return new Server.BackupDAO();

            return new Server.BackupDAO();
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.DAL.Server;
using Library.DAL.Interface;
using System.IO;

namespace Library.DAL.Server
{
    class BackupDAO : IBackupRestoreDAO
    {


        SqlStatementExecuter executer = new SqlStatementExecuter();

        private byte[] ReadStream(string filePath)
        {

            FileStream fStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            return FileDAO.ReadFully(fStream);
        }


        #region Backup
        public bool BackupDataBase(string backupFileName)
        {
            string statement = string.Format("BACKUP DATABASE {0} to disk ='{1}\\{2}'", ConfigurationManager., ConfigurationManager.FtpDirectoryOnServer, backupFileName);
            bool result = executer.ExecuteNonQuery(statement, null);

            if (result)
            {
                try
                {
                    StringBuilder sB = new StringBuilder();
                    sB.Append(ConfigurationManager.FtpDirectoryOnServer);
                    sB.Append("\\");
                    sB.Append(backupFileName);

                    byte[] file = FTPClient.DownloadFile(backupFileName);
                    return FileDAO.StoreFile(file);
                }
                catch
                {
                    return false;
                }
            }
            return result;
        }
       

        public bool BackupFile(string serverFilePath)
        {
            byte[] file = FTPClient.DownloadFile(serverFilePath);
            return FileDAO.StoreFile(file);
        }

        public List<string> GetFilesList()
        {
            return FTPClient.GetFilesList();
        }

        #endregion

        #region Restore

        public bool RestoreDataBase(string localBackupFileName)
        {

            string fileName = Path.GetFileName(localBackupFileName);
            string filePathOnServer = ConfigurationManager.FtpDirectoryOnServer + fileName;
            try
            {
                byte[] file = ReadStream(localBackupFileName);

                FTPClient.UploadFile(filePathOnServer, file);
            }
            catch
            {
                return false;
            }

            string statement = string.Format("use master restore database {0} from disk ='{1}' with replace", ConfigurationManager.DBServerName, filePathOnServer);
            bool result = executer.ExecuteNonQuery(statement, null);
            return result;

        }

        public bool RestoreFile(string localFilePath)
        {

            string fileName = Path.GetFileName(localFilePath);
            string serverFilePath = ConfigurationManager.FtpDirectoryOnServer + fileName;
            byte[] file = ReadStream(localFilePath);

            return FTPClient.UploadFile(serverFilePath, file);
        }

        #endregion        
    }
}

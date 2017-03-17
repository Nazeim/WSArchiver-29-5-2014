using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.DAL.Interface;

namespace Library.BLL
{
    public class BackupRestoreManager
    {
        IBackupRestoreDAO dataAccessObject;
        FilesManager fManager;
        List<string> filesList;

        public BackupRestoreManager()
        {
            dataAccessObject = DAL.DALManager.GetBackupRestoreDAO();
            fManager = new FilesManager();
            filesList = dataAccessObject.GetFilesList();
        }

        #region Backup

        public bool Backup(string backupFileName)
        {

            if (!dataAccessObject.BackupDataBase(backupFileName))
                return false;

            fManager.ClearTempDirectory();

            foreach (string s in filesList)
            {
                if (!dataAccessObject.BackupFile(s))
                    return false;
            }
            return true;

        }

        #endregion

        #region Restore

        public bool Restore(string backupFileName)
        {
            if (!dataAccessObject.RestoreDataBase(backupFileName))
                return false;
            

            foreach (string s in filesList)
            {
                if (!dataAccessObject.RestoreFile(s))
                    return false;
            }
            return true;


        }

        #endregion


    }
}

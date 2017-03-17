using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.DAL.Interface
{
    public interface IBackupRestoreDAO
    {
        bool BackupDataBase(string backupFileName);
        bool BackupFile(string serverFilePath);
        bool RestoreDataBase(string localBackupFileName);
        bool RestoreFile(string localFilePath);
        List<string> GetFilesList();

    }
}

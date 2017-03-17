using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Common;
using Library.Properties;

namespace Library
{
    public class ConfigurationManager
    {
        #region Database Connection
        public static UserVO currUser;
        public const string DEFAULT_SERVER_ADDRESS = "(local)";
        private static bool isLocalConnection = true;
        private static string sqlServerUserName = "WSArchiverDBAdmin";
        private static string sqlServerPassword = "WE6_$19ht";
        private static string sqlServerInitialCatalog = "WSArchiverDB";

        public static string SqlServerConnectionString
        {
            get
            {
               // return string.Format(@"Data Source=DN-HP\SQLEXPRESS2012;Initial Catalog=WSArchiver;Persist Security Info=True;User ID=WSArchiverDBAdmin;Password=WE6_$19ht");
                return string.Format("Data Source={0}\\SQLEXPRESS2012;Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}", DBServerName, SqlServerInitialCatalog, SqlServerUserName, SqlServerPassword);
            }
        }
        public static string SqlCompactConnectionString
        {
            get
            {
                return string.Format("Data Source={0};Persist Security Info=True;Password=WE6_$19ht", ConfigurationManager.GetLocalDBFilePath());
            }
        }
        public static string SqlServerInitialCatalog
        {
            get { return ConfigurationManager.sqlServerInitialCatalog; }
            set { ConfigurationManager.sqlServerInitialCatalog = value; }
        }
        public static string SqlServerPassword
        {
            get { return ConfigurationManager.sqlServerPassword; }
            set { ConfigurationManager.sqlServerPassword = value; }
        }
        public static string SqlServerUserName
        {
            get { return ConfigurationManager.sqlServerUserName; }
            set { ConfigurationManager.sqlServerUserName = value; }
        }
        public static bool IsLocalConnection
        {
            get { return ConfigurationManager.isLocalConnection; }
            set { ConfigurationManager.isLocalConnection = value; }
        }
        public static string GetLocalDBDebugFilePath()
        {
            return string.Format("f:\\{0}DB.sdf", PROGRAM_NAME);
        }
        public static string GetTempStorageDirectoryPath()
        {
            return string.Format("{0}\\temp", GetProgramPath());
        }
        public static string GetDBName()
        {
            return PROGRAM_NAME + "DB";
        }
        public static string DBServerName
        {
            get
            {
                //Settings.Default.ServerIPAddress = "(local)";
                if (Settings.Default.DBServerIPAddress == "")
                    return DEFAULT_SERVER_ADDRESS;
                else
                    return Settings.Default.DBServerIPAddress;
            }

            set
            {
                Settings.Default.DBServerIPAddress = value;
                Settings.Default.Save();
            }
        }
        public static string GetLocalDBFilePath()
        {
            return string.Format("{0}\\DBFiles\\{1}DB.sdf", GetProgramPath(), PROGRAM_NAME);
        }
        #endregion

        #region Program
        public const string PROGRAM_NAME = "DigitalDocument";
        public static string GetProgramPath()
        {

            return string.Format("{0}\\{1}", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), PROGRAM_NAME);
        }
        #endregion

        #region Scanning
        private const float DEFAULT_SCANNING_RESOLUTION = 100.0F;
        private const int DEFAULT_SCANNING_DEVICE_INDEX = 0;
        public static void SetScanningSettingsToDefaults()
        {
            ScanningDeviceIndex = DEFAULT_SCANNING_DEVICE_INDEX;
            ScanningResolution = DEFAULT_SCANNING_RESOLUTION;
        }
        public static void SetConnectionSettingsToDefaults()
        {
            DBServerName = DEFAULT_SERVER_ADDRESS;
            LocalStoragePath = GetDefaultStorageDirectoryPath();
        }
        public static int ScanningDeviceIndex
        {
            get
            {
                return Settings.Default.ScanningDeviceIndex;
            }

            set
            {
                Settings.Default.ScanningDeviceIndex = value;
                Settings.Default.Save();
            }
        }
        public static float ScanningResolution
        {
            get
            {
                return Settings.Default.ScanningResolution;
            }

            set
            {
                Settings.Default.ScanningResolution = value;
                Settings.Default.Save();
            }
        }
        #endregion

        #region File Storage
        private const string DEFAULT_FTP_USER_NAME = "User1";
        private const string DEFAULT_FTP_PASSWORD = "123456";
        private const string DEFAULT_FTP_DIRECTORY_ON_SERVER = @"F:\FtpFolderTest";

        public static string FtpDirectoryOnServer
        {
            get
            {
                if (Settings.Default.FTPDirectoryOnServer == "")
                    return DEFAULT_FTP_DIRECTORY_ON_SERVER;
                return Settings.Default.FTPDirectoryOnServer;
            }

            set
            {
                Settings.Default.FTPDirectoryOnServer = value;
                Settings.Default.Save();
            }

        } 

        public static string GetDefaultStorageDirectoryPath()
        {
            return string.Format("{0}\\Files", GetProgramPath());
        }
        public static string LocalStoragePath
        {
            get
            {
                if (Settings.Default.LocalStoragePath == "")
                    return GetDefaultStorageDirectoryPath();
                else
                    return Settings.Default.LocalStoragePath;
            }

            set
            {
                Settings.Default.LocalStoragePath = value;
                Settings.Default.Save();
            }
        }
        public static string FTPServerName
        {
            get
            {
                //Settings.Default.ServerIPAddress = "(local)";
                if (Settings.Default.FTPServerIPAddress == "")
                    return DEFAULT_SERVER_ADDRESS;
                else
                    return Settings.Default.FTPServerIPAddress;
            }

            set
            {
                Settings.Default.FTPServerIPAddress = value;
                Settings.Default.Save();
            }
        }
        public static string FTPServerUserName
        {
            get
            {
                return Settings.Default.FTPServerUserName;
            }

            set
            {
                Settings.Default.FTPServerUserName = value;
                Settings.Default.Save();
            }
        }
        public static string FTPServerPassword
        {
            get
            {
                return Settings.Default.FTPServerPassword;
            }

            set
            {
                Settings.Default.FTPServerPassword = value;
                Settings.Default.Save();
            }
        }
        #endregion

        #region Misc
        public const string USER_DEFAULT_PASSWORD = "DigitalDocument";
        public const double LEVENSTEIN_DISTANCE_UPPER_LIMIT = 0.2;
        public const int MAXIMUM_MESSAGES_COUNT = 50;
        #endregion
    }
}

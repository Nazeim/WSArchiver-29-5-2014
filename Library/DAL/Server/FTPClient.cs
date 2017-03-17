using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace Library.DAL.Server
{
    class FTPClient
    {
        private static FtpWebRequest GenerateRequest(string method, string filePath)
        {
            ConfigurationManager.FTPServerName = "127.0.0.1";
            FtpWebRequest result = (FtpWebRequest)WebRequest.Create(GenerateFtpURI(filePath));
            result.Timeout = 3000;
            result.ReadWriteTimeout = 3000;
            result.Method = method;
            result.Credentials = new NetworkCredential(ConfigurationManager.FTPServerUserName, ConfigurationManager.FTPServerPassword);

            return result;
        }

        private static string GenerateFtpURI(string filePath)
        {
            string result = string.Format("ftp://{0}//{1}", ConfigurationManager.FTPServerName, filePath);

            return result;
        }

        private static byte[] ReadFully(Stream input)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                input.CopyTo(ms);
                return ms.ToArray();
            }
        }

        public static byte[] DownloadFile(string serverFilePath)
        {
            try
            {
                FtpWebRequest request = GenerateRequest(WebRequestMethods.Ftp.DownloadFile, serverFilePath);
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                Stream responseStream = response.GetResponseStream();
                byte[] result = ReadFully(responseStream);
                response.Close();
                responseStream.Close();

                return result;
            }
            catch(Exception e)
            {
                return null;
            }
        }

        public static bool DeleteFile(string serverFilePath)
        {
            try
            {
                FtpWebRequest request = GenerateRequest(WebRequestMethods.Ftp.DeleteFile, serverFilePath);

                using (request.GetResponse())
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool UploadFile(string serverFilePath, byte[] fileData)
        {
            try
            {
                FtpWebRequest request = GenerateRequest(WebRequestMethods.Ftp.UploadFile, serverFilePath);
                WebRequest.DefaultWebProxy = null;
                request.Proxy = null;
                request.ContentLength = fileData.Length;
                Stream requestStream = request.GetRequestStream();
                requestStream.Write(fileData, 0, fileData.Length);
                requestStream.Close();
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                response.Close();

                return true;

            }
            catch
            {
                return false;
            }
        }

        public static List<string> GetFilesList()
        {
            FtpWebRequest request = GenerateRequest(WebRequestMethods.Ftp.ListDirectory, "");
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            StreamReader streamReader = new StreamReader(response.GetResponseStream());
            List<string> directories = new List<string>();
            string file = streamReader.ReadLine();

            while (!String.IsNullOrEmpty(file))
            {
                directories.Add(file);
                file = streamReader.ReadLine();
            }
            streamReader.Close();

            return directories;
        }
    }

}

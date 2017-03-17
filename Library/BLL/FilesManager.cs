using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Common;
using Library.DAL;
using Library.DAL.Interface;
using System.Security.Cryptography;
using System.IO;

namespace Library.BLL
{
    public class FilesManager : Manager<FileVO>
    {
        public FilesManager()
            : base(DALManager.GetFileDAO())
        {
        }

        public List<FileVO> FindFilesByName(string name, bool isExact)
        {
            IFileDAO dao = (IFileDAO)dataAccessObject;
            List<FileVO> result = dao.FindFilesByName(name, isExact);
            dao.CloseConnection();

            return result;
        }

        public List<FileVO> GetFilesOfDocument(DocumentVO document)
        {
            List<FileVO> result = ((IFileDAO)dataAccessObject).GetFilesOfDocument(document);
            dataAccessObject.CloseConnection();

            return result;
        }

        public FileVO GenerateNewFile(string filePath, string newFileName, DocumentVO parentDocument, FileVO.FileType type)
        {
            FileVO result = new FileVO();
            result.Name = newFileName;
            result.Document = parentDocument;
            FillData(result, filePath);
            result.Type = type;

            return result;
        }

        private byte[] EncryptFile(string filePath)
        {
            FileStream fStream = new FileStream(filePath, FileMode.Open);
            byte[] result = new byte[fStream.Length];
            fStream.Read(result, 0, result.Length);

            return EncryptionManager.Encrypt(result);
        }

        private void FillData(FileVO vo, string filePath)
        {
            vo.FileData = EncryptFile(filePath);
        }

        public override int Insert(FileVO vo)
        {
            try
            {
                vo.AdditionDateTime = DateTime.Now;
                vo.Id = base.Insert(vo);

                if (vo.Id < 0)
                    return vo.Id;

                ((IFileDAO)dataAccessObject).StoreFile(vo);

                return vo.Id;
            }
            catch
            {
                return -1;
            }
        }

        public override bool Delete(FileVO vo)
        {
            try
            {
                ((IFileDAO)dataAccessObject).DeleteFile(vo);
                return base.Delete(vo);
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Called when decrypting a file in order to preview it.
        /// </summary>
        /// <param name="file">The file -not fully loaded yet- to store in the temp directory.</param>
        /// <returns>The path of the newly stored file.</returns>
        public string StoreFileInTempDirectory(FileVO file)
        {
            FileStream stream = null;

            try
            {
                if (file.FileData == null)
                {
                    if (!((IFileDAO)dataAccessObject).LoadFileData(file))
                        return "";

                    if (file.FileData == null)
                        return "";
                }

                byte[] fileBytes = EncryptionManager.Decrypt(file.FileData);
                Guid guid = Guid.NewGuid();
                string tempDir = ConfigurationManager.GetTempStorageDirectoryPath();
                string path = String.Format("{0}\\{1}.{2}", tempDir, guid.ToString(), file.Type.ToString());
               
                if (!Directory.Exists(tempDir))
                    Directory.CreateDirectory(tempDir);

                stream = new FileStream(path, FileMode.Create);
                stream.Write(fileBytes, 0, fileBytes.Length);

                return path;
            }
            catch
            {
                return "";
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
        }

        public void ClearTempDirectory()
        {
            string tempDir = ConfigurationManager.GetTempStorageDirectoryPath();

            if (!Directory.Exists(tempDir))
                return;

            string[] files = Directory.GetFiles(tempDir);

            foreach (string file in files)
            {
                try
                {
                    File.Delete(file);
                }
                catch
                { }
            }
        }

        public bool RenameFile(FileVO file)
        {
            IFileDAO dao = ((IFileDAO)dataAccessObject);
            bool res = dao.RenameFile(file);
            dao.CloseConnection();

            return res;
        }
    }
}

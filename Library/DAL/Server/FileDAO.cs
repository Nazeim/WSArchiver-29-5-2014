using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Library.Common;
using Library.DAL.Interface;
using System.Data.SqlClient;
using Library.Common.Search;
using System.IO;
using System.Data.SqlTypes;

namespace Library.DAL.Server
{
    class FileDAO : DAO<FileVO>, IFileDAO
    {
        //public const int MAX_FILE_SIZE = 25 * 1024 * 1024;
        public const string fileName = "fileName";
        public const string fileDocumentId = "fileDocumentId";
        public const string fileType = "fileType";
        public const string fileAdditionDate = "fileAdditionDate";

        public FileDAO()
            : base("File", "fileId", 5)
        {
        }

        protected override SqlParameter[] MakeSqlParameters(FileVO vo)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                MakeSqlParameter(fileName,vo.Name,SqlDbType.NVarChar),
                MakeSqlParameter(fileDocumentId,vo.DocumentId),
                MakeSqlParameter(fileType,vo.Type),
                MakeSqlParameter(fileAdditionDate,vo.AdditionDateTime,SqlDbType.DateTime)
                //MakeSqlParameter(fileData, vo.FileData, SqlDbType.VarBinary)
            };

            return parameters;
        }

        protected override string[] ConvertColumnNamesToArray()
        {
            return ConvertToArray(fileName, fileDocumentId, fileType, fileAdditionDate);
        }

        public static byte[] ReadFully(Stream input)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                input.CopyTo(ms);
                return ms.ToArray();
            }
        }

        public static bool StoreFile(byte[] file)
        {
            try
            {
                FileStream fStream = new FileStream(ConfigurationManager.GetTempStorageDirectoryPath(), FileMode.Create, FileAccess.Write);
                fStream.Write(file, 0, file.Length);

                fStream.Close();
                return true;
            }

            catch(Exception e)
            {
                return false;
            }
        }

        //Does not load the fileData column
        public override FileVO ReadRecord(System.Data.SqlClient.SqlDataReader reader)
        {
            FileVO result = new FileVO();

            result.Id = reader.GetInt32(reader.GetOrdinal(idColumnName));
            result.Name = reader[fileName].ToString();
            DocumentDAO ddao = new DocumentDAO();
            result.Document = ddao.GetItem(reader.GetInt32(reader.GetOrdinal(fileDocumentId)));
            ddao.CloseConnection();
            short valInt = reader.GetInt16(reader.GetOrdinal(fileType));
            result.Type = (FileVO.FileType)valInt;
            result.AdditionDateTime = reader.GetDateTime(reader.GetOrdinal(fileAdditionDate));

            return result;
        }

        //Does not load the fileData column
        public override FileVO GetItem(int id)
        {
            string[] columns = { idColumnName, fileName, fileDocumentId, fileType, fileAdditionDate };
            string statement = SqlStatememtGenerator.Select_ReadSomeColumnsById(tableName, columns, idColumnName);
            SqlParameter[] parameters = { MakeSqlParameter(idColumnName, id) };
            SqlDataReader reader = executer.ExecuteSelectStatement(statement, parameters);
            FileVO result = null;

            if (reader.HasRows)
            {
                reader.Read();
                result = ReadRecord(reader);

                return result;
            }

            reader.Close();

            return null;
        }

        //Does not load the fileData column
        public override List<FileVO> GetAll()
        {
            string[] columns = { idColumnName, fileName, fileDocumentId, fileType, fileAdditionDate };
            string statement = SqlStatememtGenerator.Select_ReadSomeColumnsByCondition(tableName, columns, "1 = 1");

            return ReadAllRecords(executer.ExecuteSelectStatement(statement, null));
        }


        #region IFileDAO Members

        public List<FileVO> FindFilesByName(string name, bool isExact)
        {
            List<FileVO> result = null;

            if (isExact)
                result = ExactFindByStringColumn(name, fileName);
            else
                result = LooseFindStringColumn(name, fileName);

            return result;
        }

        private List<FileVO> ExactFindByStringColumn(string name, string columnName)
        {
            string condition = string.Format("{0} like '{1}'", columnName, name);
            string statement = SqlStatememtGenerator.Select_ReadAllColumnsByCondition(tableName, condition);
            SqlDataReader reader = executer.ExecuteSelectStatement(statement, null);

            return ReadAllRecords(reader);
        }

        private List<FileVO> LooseFindStringColumn(string name, string columnName)
        {
            List<FileVO> all = GetAll();
            List<SortableSearchItem> resultSortable = new List<SortableSearchItem>();
            double curDistance;
            string currentCompareTo;

            for (int i = 0; i < all.Count; i++)
            {
                currentCompareTo = all[i].Name;

                curDistance = Common.Search.StringSearchFunctions.MixedDistance.AverageNormalizedDistance(
                    name, currentCompareTo, ConfigurationManager.LEVENSTEIN_DISTANCE_UPPER_LIMIT);

                if (curDistance > 0)
                {
                    resultSortable.Add(new SortableSearchItem(curDistance, all[i]));
                }
            }

            resultSortable.Sort(SortableSearchItem.GetComparer());
            all.Clear();

            foreach (SortableSearchItem item in resultSortable)
            {
                all.Add(item.Record as FileVO);
            }

            return all;
        }

        public List<FileVO> FindFilesByArchivingDate(DateRange range)
        {
            string rStart = "rangeStart";
            string rEnd = "rEnd";

            string condition = string.Format("{0} >= @{1} and {0} < @{2}", fileAdditionDate, rStart, rEnd);
            string statement = SqlStatememtGenerator.Select_ReadAllColumnsByCondition(tableName, condition);

            SqlParameter[] paramters = new SqlParameter[]
            {
                MakeSqlParameter(rStart, range.Start, SqlDbType.DateTime),
                MakeSqlParameter(rEnd, range.End, SqlDbType.DateTime)
            };

            SqlDataReader reader = executer.ExecuteSelectStatement(statement, paramters);
            List<FileVO> result = ReadAllRecords(reader);

            return result;
        }

        public List<FileVO> GetFilesOfDocument(DocumentVO document)
        {
            string condition = string.Format("{0}={1}", fileDocumentId, document.Id);
            string statement = SqlStatememtGenerator.Select_ReadAllColumnsByCondition(tableName, condition);
            SqlDataReader reader = executer.ExecuteSelectStatement(statement, null);

            return ReadAllRecords(reader);
        }
        #endregion

        #region IFileDAO Members


        public bool StoreFile(FileVO vo)
        {
            string filePath = GenerateFilePath(vo);

            return FTPClient.UploadFile(filePath, vo.FileData);
        }

        #endregion

        #region IFileDAO Members

        public void DeleteFile(FileVO vo)
        {
            string filePath = GenerateFilePath(vo);
            FTPClient.DeleteFile(filePath);
        }

        #endregion

        #region IFileDAO Members


        public bool RenameFile(FileVO vo)
        {
            string statement = string.Format("Update [{0}] set {1} = '{2}' where {3} = {4}",
            tableName, fileName, vo.Name, idColumnName, vo.Id);

            return executer.ExecuteUpdateStatement(statement, null);
        }

        #endregion

        #region IFileDAO Members


        public bool LoadFileData(FileVO vo)
        {
            string filePath = GenerateFilePath(vo);
            byte[] data = FTPClient.DownloadFile(filePath);

            if (data != null)
            {
                vo.FileData = data;

                return true;
            }

            return false;
        }

        private string GenerateFilePath(FileVO vo)
        {
            return string.Format("{0}.enc", vo.Id);
        }
        #endregion
    }
}

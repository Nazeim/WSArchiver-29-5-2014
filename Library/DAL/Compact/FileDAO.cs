using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using Library.Common;
using Library.DAL.Interface;
using Library.Common.Search;
using System.IO;

namespace Library.DAL.Compact
{
    class FileDAO:DAO<FileVO>,IFileDAO
    {
        public const string fileName = "fileName";
        public const string fileDocumentId = "fileDocumentId";
        public const string fileType = "fileType";
        public const string fileAdditionDate = "fileAdditionDate";

        public FileDAO()
            :base ("File","fileId",6)
        { 
        }
        

        protected override SqlCeParameter[] MakeSqlParameters(FileVO vo)
        {
            SqlCeParameter[] parameters = new SqlCeParameter[]
            {
                MakeSqlParameter(fileName,vo.Name,SqlDbType.NVarChar),
                MakeSqlParameter(fileDocumentId,vo.DocumentId),
                MakeSqlParameter(fileType,(short)vo.Type, SqlDbType.SmallInt),
                MakeSqlParameter(fileAdditionDate,vo.AdditionDateTime,SqlDbType.DateTime)             
            };
            return parameters;
        }

        protected override string[] ConvertColumnNamesToArray()
        {
            return ConvertToArray(fileName, fileDocumentId,fileType,fileAdditionDate);
        }

        public override FileVO ReadRecord(System.Data.SqlServerCe.SqlCeDataReader reader)
        {
            FileVO result = new FileVO();
            
            result.Id = reader.GetInt32(reader.GetOrdinal(idColumnName));
            result.Name = reader[fileName].ToString();
            DocumentDAO ddao = new DocumentDAO();
            result.Document = ddao.GetItem(reader.GetInt32(reader.GetOrdinal(fileDocumentId)));
            ddao.CloseConnection();
            result.Type = (FileVO.FileType)reader.GetInt16(reader.GetOrdinal(fileType));
            result.AdditionDateTime = reader.GetDateTime(reader.GetOrdinal(fileAdditionDate));

            return result;
        }

        public override int Insert(FileVO vo)
        {
            vo.AdditionDateTime = DateTime.Now;

            return base.Insert(vo);
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
            return GetAllByColumnValue(columnName, name, SqlDbType.NVarChar);
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

            SqlCeParameter[] paramters = new SqlCeParameter[]
            {
                MakeSqlParameter(rStart, range.Start, SqlDbType.DateTime),
                MakeSqlParameter(rEnd, range.End, SqlDbType.DateTime)
            };

            SqlCeDataReader reader = executer.ExecuteSelectStatement(statement, paramters);
            List<FileVO> result = ReadAllRecords(reader);

            return result;
        }

        public List<FileVO> GetFilesOfDocument(DocumentVO document)
        {
            return GetAllByColumnValue(fileDocumentId, document.Id, SqlDbType.Int);
        }

        #endregion

        #region IFileDAO Members

        private string GetStorageFilePath(FileVO vo)
        {
            string localStoragePath = ConfigurationManager.LocalStoragePath;
            string filePath = string.Format("{0}\\{1}.enc", localStoragePath, vo.Id);

            return filePath;
        }

        public bool StoreFile(FileVO vo)
        {
            string localStoragePath = ConfigurationManager.LocalStoragePath;
            FileStream stream = null;

            try
            {
                if (!Directory.Exists(localStoragePath))
                    Directory.CreateDirectory(localStoragePath);

                string filePath = GetStorageFilePath(vo);

                stream = new FileStream(filePath, FileMode.Create);
                byte[] data = vo.FileData;
                stream.Write(data, 0, data.Length);

                return true; 
            }
            catch
            {
                return false;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
        }


        public void DeleteFile(FileVO vo)
        {
            string path = GetStorageFilePath(vo);

            if (!File.Exists(path))
                return;

            try
            {
                File.Delete(path);
            }
            catch
            { }
        }

        #endregion

        #region IFileDAO Members


        public bool RenameFile(FileVO vo)
        {
            string statement = string.Format("Update [{0}] set {1} = {2} where {3} = {4}",
                tableName, fileName, vo.Name, idColumnName, vo.Id);

            return executer.ExecuteUpdateStatement(statement, null);
        }

        #endregion

        #region IFileDAO Members


        public bool LoadFileData(FileVO vo)
        {
            FileStream fStream = null;

            try
            {
                string path = GetStorageFilePath(vo);
                fStream = new FileStream(path, FileMode.Open);
                byte[] data = new byte[fStream.Length];

                fStream.Read(data, 0, data.Length);
                vo.FileData = data;

                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                if (fStream != null)
                    fStream.Close();
            }
        }

        #endregion
    }
}

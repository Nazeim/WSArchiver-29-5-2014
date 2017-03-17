using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using Library.Common;
using Library.Common.Search;
using System.Collections;

namespace Library.DAL.Compact
{
    class DocumentDAO : DAO<DocumentVO>, Interface.IDocumentDAO
    {
        public const string documentInDate = "documentInDate";
        public const string documentInNumber = "documentInNumber";
        public const string documentOutDate = "documentRegistrationDate";
        public const string documentOutNumber = "documentRegistrationNumber";
        public const string documentCreationDate = "documentCreationDate";
        public const string documentCreatorId = "documentCreatorId";
        public const string documentLastEditDate = "documentLastEditDate";
        public const string documentLastEditorId = "documentLastEditorId";
        public const string documentDestinationId = "documentDestinationId";
        public const string documentFolderId = "documentFolderId";
        public const string documentTitle = "documentTitle";
        public const string documentProcess = "documentProcess";
        public const string documentSubject = "documentSubject";
        public const string documentPartyId = "documentPartyId";
        public const string documentIsDeleted = "documentIsDeleted";

        UserDAO udao = new UserDAO();
        DestinationDAO ddao = new DestinationDAO();
        FolderDAO gdao = new FolderDAO();
        PartyDAO pdao = new PartyDAO();

        public DocumentDAO()
            : base("Document", "documentId", 16)
        {
        }

        protected override SqlCeParameter[] MakeSqlParameters(DocumentVO vo)
        {
            SqlCeParameter[] parameters = new SqlCeParameter[]
            {
                MakeSqlParameter(documentInDate, vo.InDateTime, SqlDbType.DateTime),
                MakeSqlParameter(documentInNumber, vo.InNumber),

                MakeSqlParameter(documentOutDate, vo.OutDateTime, SqlDbType.DateTime),
                MakeSqlParameter(documentOutNumber, vo.OutNumber),

                MakeSqlParameter(documentCreationDate, vo.CreationDate, SqlDbType.DateTime),
                MakeSqlParameter(documentCreatorId, vo.CreatorId),

                MakeSqlParameter(documentLastEditDate, vo.LastEditDateTime, SqlDbType.DateTime),
                MakeSqlParameter(documentLastEditorId, vo.LastEditorId),
                MakeSqlParameter(documentDestinationId, vo.DestinationId),

                MakeSqlParameter(documentFolderId, vo.FolderId),
                    
                MakeSqlParameter(documentTitle, vo.Title,SqlDbType.NVarChar),

                MakeSqlParameter(documentProcess, vo.Process,SqlDbType.NVarChar),
                MakeSqlParameter(documentSubject, vo.Subject,SqlDbType.NVarChar),
                MakeSqlParameter(documentPartyId, vo.PartyId),

                MakeSqlParameter(documentIsDeleted, vo.IsDeleted, SqlDbType.Bit)
            };

            return parameters;
        }

        protected override string[] ConvertColumnNamesToArray()
        {
            return ConvertToArray(documentInDate, documentInNumber, documentOutDate
                , documentOutNumber, documentCreationDate, documentCreatorId, documentLastEditDate
                , documentLastEditorId, documentDestinationId, documentFolderId
                , documentTitle, documentProcess, documentSubject, documentPartyId, documentIsDeleted);
        }

        public override DocumentVO ReadRecord(SqlCeDataReader reader)
        {
            DocumentVO result = new DocumentVO();

            result.Id = reader.GetInt32(reader.GetOrdinal(idColumnName));
            result.InDateTime = reader.GetDateTime(reader.GetOrdinal(documentInDate));
            result.InNumber = reader.GetInt32(reader.GetOrdinal(documentInNumber));
            result.OutDateTime = reader.GetDateTime(reader.GetOrdinal(documentOutDate));
            result.OutNumber = reader.GetInt32(reader.GetOrdinal(documentOutNumber));
            result.CreationDate = reader.GetDateTime(reader.GetOrdinal(documentCreationDate));
            result.Creator = udao.GetItem(reader.GetInt32(reader.GetOrdinal(documentCreatorId)));
            result.LastEditDateTime = reader.GetDateTime(reader.GetOrdinal(documentLastEditDate));
            result.LastEditor = udao.GetItem(reader.GetInt32(reader.GetOrdinal(documentLastEditorId)));
            udao.CloseConnection();

            result.Destination = ddao.GetItem(reader.GetInt32(reader.GetOrdinal(documentDestinationId)));

            ddao.CloseConnection();
            result.Folder = gdao.GetItem(reader.GetInt32(reader.GetOrdinal(documentFolderId)));
            gdao.CloseConnection();
            
            result.Title = reader[documentTitle].ToString();
            result.Process = reader[documentProcess].ToString();
            result.Subject = reader[documentSubject].ToString();

            result.Party = pdao.GetItem(reader.GetInt32(reader.GetOrdinal(documentPartyId)));
            pdao.CloseConnection();

            result.IsDeleted = ReadBool(reader, documentIsDeleted);

            return result;
        }

        #region IDocumentDAO Members

        #region Helper
        private List<DocumentVO> FindByParty(PartyVO party)
        {
            return FindByPartyId(party.Id);
        }

        private void FullLoadList(List<DocumentVO> list)
        {
            foreach (DocumentVO doc in list)
            {
                FullLoad(doc);
            }
        }

        private List<DocumentVO> GetItemsInRange(List<int> ids)
        {
            if (ids == null || ids.Count == 0)
                return new List<DocumentVO>();

            string cond = string.Format("{0} in {1}", idColumnName, MakeCommaSeparatedValues(ids));
            string statement = SqlStatememtGenerator.Select_ReadAllColumnsByCondition(tableName, cond);

            SqlCeDataReader reader = executer.ExecuteSelectStatement(statement, null);

            return ReadAllRecords(reader);
        }

        private List<DocumentVO> FindByStringColumn(string title, bool isExact, string columnName)
        {
            List<DocumentVO> result = null;

            if (isExact)
                result = ExactFindByStringColumn(title, columnName);
            else
                result = LooseFindStringColumn(title, columnName);

            FullLoadList(result);

            return result;
        }

        private List<DocumentVO> ExactFindByStringColumn(string title, string columnName)
        {
            string condition = string.Format("{0} like '{1}'", columnName, title);
            string statement = SqlStatememtGenerator.Select_ReadAllColumnsByCondition(tableName, condition);
            SqlCeDataReader reader = executer.ExecuteSelectStatement(statement, null);

            return ReadAllRecords(reader);
        }

        private List<DocumentVO> LooseFindStringColumn(string title, string columnName)
        {
            List<DocumentVO> all = GetAll();
            List<SortableSearchItem> resultSortable = new List<SortableSearchItem>();
            double curDistance;
            string currentCompareTo;

            for (int i = 0; i < all.Count; i++)
            {
                if (columnName == documentProcess)
                    currentCompareTo = all[i].Process;
                else if (columnName == documentSubject)
                    currentCompareTo = all[i].Subject;
                else
                    currentCompareTo = all[i].Title;

                curDistance = Common.Search.StringSearchFunctions.MixedDistance.AverageNormalizedDistance(
                    title, currentCompareTo, ConfigurationManager.LEVENSTEIN_DISTANCE_UPPER_LIMIT);

                if (curDistance > 0)
                {
                    resultSortable.Add(new SortableSearchItem(curDistance, all[i]));
                }
            }

            resultSortable.Sort(SortableSearchItem.GetComparer());
            all.Clear();

            foreach (SortableSearchItem item in resultSortable)
            {
                all.Add(item.Record as DocumentVO);
            }

            return all;
        }

        private List<DocumentVO> FindByIntegerColumn(int value, string columnName)
        {
            string condition = string.Format("{0} = {1}", columnName, value);
            string statement = SqlStatememtGenerator.Select_ReadAllColumnsByCondition(tableName, condition);

            SqlCeDataReader reader = executer.ExecuteSelectStatement(statement, null);
            List<DocumentVO> result = ReadAllRecords(reader);
            FullLoadList(result);

            return result;
        }

        private List<DocumentVO> FindByDateRangeColumn(DateRange range, string columName)
        {
            string rStart = "rangeStart";
            string rEnd = "rEnd";

            string condition = string.Format("{0} >= @{1} and {0} < @{2}", columName, rStart, rEnd);
            string statement = SqlStatememtGenerator.Select_ReadAllColumnsByCondition(tableName, condition);

            SqlCeParameter[] paramters = new SqlCeParameter[]
            {
                MakeSqlParameter(rStart, range.Start, SqlDbType.DateTime),
                MakeSqlParameter(rEnd, range.End, SqlDbType.DateTime)
            };

            SqlCeDataReader reader = executer.ExecuteSelectStatement(statement, paramters);
            List<DocumentVO> result = ReadAllRecords(reader);
            FullLoadList(result);

            return result;
        }

        private string MakeCommaSeparatedValues(IList list)
        {
            StringBuilder b = new StringBuilder();
            b.Append("(");

            for (int i = 0; i < list.Count; i++)
            {
                b.Append(list[i].ToString());

                if (i < list.Count - 1)
                {
                    b.Append(",");
                }
            }

            b.Append(")");

            return b.ToString();
        }

        #endregion

        public List<DocumentVO> FindByTtile(string title, bool isExact)
        {
            return FindByStringColumn(title, isExact, documentTitle);
        }

        public List<DocumentVO> FindByProcess(string process, bool isExact)
        {
            return FindByStringColumn(process, isExact, documentProcess);
        }

        public List<DocumentVO> FindBySubject(string subject, bool isExact)
        {
            return FindByStringColumn(subject, isExact, documentSubject);
        }

        public List<DocumentVO> FindByOutNumber(int registrationNumber)
        {
            return FindByIntegerColumn(registrationNumber, documentOutNumber);
        }

        public List<DocumentVO> FindByOutDate(Common.Search.DateRange range)
        {
            return FindByDateRangeColumn(range, documentOutDate);
        }

        public List<DocumentVO> FindByInNumber(int number)
        {
            return FindByIntegerColumn(number, documentInNumber);
        }

        public List<DocumentVO> FindByInDate(Common.Search.DateRange range)
        {
            return FindByDateRangeColumn(range, documentInDate);
        }

        public List<DocumentVO> FindByCreationDate(Common.Search.DateRange range)
        {
            return FindByDateRangeColumn(range, documentCreationDate);
        }

        public List<DocumentVO> FindByLastModificationDate(Common.Search.DateRange range)
        {
            return FindByDateRangeColumn(range, documentLastEditDate);
        }

        public List<DocumentVO> FindByFileArchivingDate(Common.Search.DateRange range)
        {
            FileDAO dao = new FileDAO();
            List<FileVO> files = dao.FindFilesByArchivingDate(range);
            dao.CloseConnection();
            NoRepeatList<DocumentVO> result = new NoRepeatList<DocumentVO>();

            foreach (FileVO file in files)
            {
                result.AddDistinct(file.Document);
            }

            FullLoadList(result);

            return result;
        }

        public List<DocumentVO> FindByFileName(string fileName, bool isExact)
        {
            FileDAO dao = new FileDAO();
            List<FileVO> files = dao.FindFilesByName(fileName, isExact);
            dao.CloseConnection();
            NoRepeatList<DocumentVO> result = new NoRepeatList<DocumentVO>();

            foreach (FileVO file in files)
            {
                result.AddDistinct(file.Document);
            }

            FullLoadList(result);

            return result;
        }

        public List<DocumentVO> FindByPartyId(int partyId)
        {
            return GetAllByColumnValue(documentPartyId, partyId, SqlDbType.Int);
        }

        public List<DocumentVO> FindByFolderId(int gf)
        {
            return FindByIntegerColumn(gf, documentFolderId);
        }

        public List<DocumentVO> FindByCreatorId(int id)
        {
            return FindByIntegerColumn(id, documentCreatorId); ;
        }

        public List<DocumentVO> FindByLastModifierId(int id)
        {
            return FindByIntegerColumn(id, documentLastEditorId);
        }

        public List<DocumentVO> FindByCategoryId(List<CategoryVO> categories)
        {
            DocumentCategoryDAO dao = new DocumentCategoryDAO();
            NoRepeatList<DocumentVO> result = new NoRepeatList<DocumentVO>();


            foreach (CategoryVO cat in categories)
            {
                result.AddDistinct(GetItemsInRange(dao.GetAssociationsOfSecondTable(cat)));
            }

            dao.CloseConnection();
            FullLoadList(result);

            return result;
        }

        public List<DocumentVO> FindByDestinationId(int id)
        {
            return FindByIntegerColumn(id, documentDestinationId);
        }

        #endregion

        #region IDocumentDAO Members
        public void FullLoad(DocumentVO doc)
        {
            DocumentCategoryDAO dao = new DocumentCategoryDAO();
            List<int> categoriesIds = dao.GetAssociationsOfFirstTable(doc);
            dao.CloseConnection();

            CategoryDAO catDao = new CategoryDAO();
            List<CategoryVO> result = new List<CategoryVO>();

            foreach (int item in categoriesIds)
                result.Add(catDao.GetItem(item));

            catDao.CloseConnection();
            doc.Categories = result;

            FileDAO fileDao = new FileDAO();
            doc.Files = fileDao.GetFilesOfDocument(doc);
            fileDao.CloseConnection();
        }
        public List<DocumentVO> GetSubDocumentsOfFolder(FolderVO folder)
        {
            return GetAllByColumnValue(documentFolderId, folder.Id, SqlDbType.Int);
        }
        public List<DocumentVO> GetDocumentsOfFolder(FolderVO folder)
        {
            string condition = string.Format("{0}={1}", documentFolderId, folder.Id);
            string statement = SqlStatememtGenerator.Select_ReadAllColumnsByCondition(tableName, condition);
            SqlCeDataReader reader = executer.ExecuteSelectStatement(statement, null);

            return ReadAllRecords(reader);
        }
        #endregion
    }

}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Common;
using System.Data.SqlServerCe;
using Library.DAL.Interface;
using System.Data;

namespace Library.DAL.Compact
{
    class FolderDAO : DAO<FolderVO>, IFolderDAO
    {
        public const string folderName = "folderName";
        public const string folderIsPermanent = "folderIsPermanent";
        public const string baseFolderId = "baseFolderId";

        FolderDAO fDao;

        public FolderDAO()
            : base("Folder", "folderId", 4)
        {
        }

        protected override SqlCeParameter[] MakeSqlParameters(FolderVO vo)
        {
            SqlCeParameter[] parameters = new SqlCeParameter[]
            {
                MakeSqlParameter(folderName, vo.Name, System.Data.SqlDbType.NVarChar),
                MakeSqlParameter(folderIsPermanent, vo.IsPermanent),
                MakeSqlParameter(baseFolderId, vo.BaseFolderId)
            };

            return parameters;
        }

        protected override string[] ConvertColumnNamesToArray()
        {
            return ConvertToArray(folderName, folderIsPermanent, baseFolderId);
        }

        public override FolderVO ReadRecord(SqlCeDataReader reader)
        {
            FolderVO result = new FolderVO();
            fDao = new FolderDAO();

            result.Id = reader.GetInt32(reader.GetOrdinal(idColumnName));
            result.Name = reader[folderName].ToString();
            result.IsPermanent = reader.GetBoolean(reader.GetOrdinal(folderIsPermanent));
            int? baseFolderid = ReadIntOrNull(reader, baseFolderId);

            if (baseFolderid != null)
                result.BaseFolder = fDao.GetItem(baseFolderid.Value);
            else
                result.BaseFolder = null;

            fDao.CloseConnection();

            return result;
        }

        #region IFolderDAO Members
        public List<FolderVO> GetSubFoldersOfFolder(FolderVO folder)
        {
            return GetAllByColumnValue(baseFolderId, folder.Id, SqlDbType.Int);
        }

        #endregion


        public FolderVO GetRootFolder()
        {
            List<FolderVO> result = GetAllByColumnValue(folderIsPermanent, true, SqlDbType.Bit);

            if (result != null)
                return result[0];

            return null;
        }
    }
}

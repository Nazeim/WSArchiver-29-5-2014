using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Common;
using System.Data.SqlServerCe;

namespace Library.DAL.Compact
{
    class DocumentCategoryDAO : ManyToManyDAO<DocumentCategoryVO, DocumentVO, CategoryVO>, Interface.IDocumentCategoryDAO
    {
        public const string documentCategoryDocumentId = "documentCategoryDocumentId";
        public const string documentCategoryCategoryId = "documentCategoryCategoryId";

        public DocumentCategoryDAO()
            : base("DocumentCategory", "documentCategoryId", 3, documentCategoryDocumentId, documentCategoryCategoryId,
            new DocumentDAO(), new CategoryDAO())
        { }
        protected override SqlCeParameter[] MakeSqlParameters(DocumentCategoryVO vo)
        {
            SqlCeParameter[] parameters = new SqlCeParameter[]
            {
                MakeSqlParameter(documentCategoryDocumentId, vo.DocumentId),
                MakeSqlParameter(documentCategoryCategoryId, vo.CategoryId)
            };

            return parameters;
        }

        protected override string[] ConvertColumnNamesToArray()
        {
            return ConvertToArray(documentCategoryDocumentId, documentCategoryCategoryId);
        }

        public override DocumentCategoryVO ReadRecord(System.Data.SqlServerCe.SqlCeDataReader reader)
        {
            DocumentCategoryVO result = new DocumentCategoryVO();

            result.Id = reader.GetInt32(reader.GetOrdinal(idColumnName));
            int documentId = reader.GetInt32(reader.GetOrdinal(documentCategoryDocumentId));
            int categoryId = reader.GetInt32(reader.GetOrdinal(documentCategoryCategoryId));

            result.Document = firstTableDAO.GetItem(documentId);
            result.Category = secondTableDAO.GetItem(categoryId);
            firstTableDAO.CloseConnection();
            secondTableDAO.CloseConnection();

            return result;
        }
    }
}

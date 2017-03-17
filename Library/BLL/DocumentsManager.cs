using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Common;
using Library.Common.Search;
using Library.BLL.Search.SearchFilters;
using Library.BLL.Search;
using Library.DAL.Interface;

namespace Library.BLL
{
    public class DocumentsManager : Manager<DocumentVO>
    {
        private AttacherDetacher<DocumentCategoryVO, DocumentVO, CategoryVO> documentCategoryAttacherDetacher =
            new AttacherDetacher<DocumentCategoryVO, DocumentVO, CategoryVO>(DAL.DALManager.GetDocumentCategoryDAO());

        public AttacherDetacher<DocumentCategoryVO, DocumentVO, CategoryVO> DocumentCategoryAttacherDetacher
        {
            get { return documentCategoryAttacherDetacher; }
            set { documentCategoryAttacherDetacher = value; }
        }


        public DocumentsManager()
            : base(DAL.DALManager.GetDocumentDAO())
        { }

        #region Search
        public List<DocumentVO> Find(List<Filter> filters)
        {
            if (filters.Count == 0)
                return new List<DocumentVO>();

            SortFilters(filters);
            List<SearchFilter> searchFilters = new List<SearchFilter>();

            foreach (Filter filter in filters)
                searchFilters.Add(FiltersManager.GetFilter(filter));

            List<SortableSearchItem> primaryResult = FindInDB(searchFilters[0]);

            for (int i = 1; i < searchFilters.Count; i++)
            {
                searchFilters[i].Apply(primaryResult);
            }

            primaryResult.Sort(SortableSearchItem.GetComparer());
            List<DocumentVO> res = ExtractNormalList(primaryResult);

            foreach(DocumentVO fol in res)
                ((IDocumentDAO)dataAccessObject).FullLoad(fol);

            return res;
        }

        private List<DocumentVO> ExtractNormalList(List<SortableSearchItem> sortableList)
        {
            List<DocumentVO> result = new List<DocumentVO>();

            foreach (SortableSearchItem item in sortableList)
                result.Add(item.Record as DocumentVO);

            return result;
        }
        private List<SortableSearchItem> GenerateSortableList(List<DocumentVO> documents)
        {
            List<SortableSearchItem> result = new List<SortableSearchItem>();
            SortableSearchItem temp;

            for (int i = 0; i < documents.Count; i++)
            {
                temp = new SortableSearchItem((double)i / documents.Count, documents[i]);
                result.Add(temp);
            }

            return result;
        }
        private void SortFilters(List<Filter> filters)
        {
            filters.Sort(Filter.GetComparer());
        }
        private List<SortableSearchItem> FindInDB(SearchFilter searchFilter)
        {
            List<DocumentVO> result;
            DAL.Interface.IDocumentDAO dao = (DAL.Interface.IDocumentDAO)dataAccessObject;

            if (searchFilter is CategoryIdFilter)
                result = dao.FindByCategoryId((List<CategoryVO>)searchFilter.Criteria);
            else if (searchFilter is DestinationIdFilter)
                result = dao.FindByDestinationId((int)searchFilter.Criteria);
            else if (searchFilter is DocCreationDateFilter)
                result = dao.FindByCreationDate((DateRange)searchFilter.Criteria);
            else if (searchFilter is DocCreatorIdFilter)
                result = dao.FindByCreatorId((int)searchFilter.Criteria);
            else if (searchFilter is DocFolderIdFilter)
                result = dao.FindByFolderId((int)searchFilter.Criteria);
            else if (searchFilter is DocInDateFilter)
                result = dao.FindByInDate((DateRange)searchFilter.Criteria);
            else if (searchFilter is DocInNumberFilter)
                result = dao.FindByInNumber((int)searchFilter.Criteria);
            else if (searchFilter is DocLastModificationDateFilter)
                result = dao.FindByLastModificationDate((DateRange)searchFilter.Criteria);
            else if (searchFilter is DocLastModifierIdFilter)
                result = dao.FindByLastModifierId((int)searchFilter.Criteria);
            else if (searchFilter is DocProcessExactFilter)
                result = dao.FindByProcess((string)searchFilter.Criteria, true);
            else if (searchFilter is DocProcessFilter)
                result = dao.FindByProcess((string)searchFilter.Criteria, false);
            else if (searchFilter is DocOutDateFilter)
                result = dao.FindByOutDate((DateRange)searchFilter.Criteria);
            else if (searchFilter is DocOutNumberFilter)
                result = dao.FindByOutNumber((int)searchFilter.Criteria);
            else if (searchFilter is DocSubjectExactFilter)
                result = dao.FindBySubject((string)searchFilter.Criteria, true);
            else if (searchFilter is DocSubjectFilter)
                result = dao.FindBySubject((string)searchFilter.Criteria, false);
            else if (searchFilter is DocTitleExactFilter)
                result = dao.FindByTtile((string)searchFilter.Criteria, true);
            else if (searchFilter is DocTitleFilter)
                result = dao.FindByTtile((string)searchFilter.Criteria, false);
            else if (searchFilter is FileArchivingDateFilter)
                result = dao.FindByFileArchivingDate((DateRange)searchFilter.Criteria);
            else if (searchFilter is FileNameExactFilter)
                result = dao.FindByFileName((string)searchFilter.Criteria, true);
            else if (searchFilter is FileNameFilter)
                result = dao.FindByFileName((string)searchFilter.Criteria, false);
            else if (searchFilter is FolderNumberFilter)
                result = null;
            else if (searchFilter is PartyIdFilter)
                result = dao.FindByPartyId((int)searchFilter.Criteria);
            else //(searchFilter is PartyNumberFilter)
                result = null;

            return GenerateSortableList(result);
        }
        #endregion

        public override int Insert(DocumentVO vo)
        {
            vo.CreationDate = DateTime.Now;
            vo.LastEditDateTime = DateTime.Now;
            vo.Creator = ConfigurationManager.currUser;
            vo.LastEditor = ConfigurationManager.currUser;

            int res = base.Insert(vo);

            if (res < 0)
                return res;

            if (vo.Categories != null)
            {
                foreach (CategoryVO category in vo.Categories)
                {
                    documentCategoryAttacherDetacher.Attach(vo, category);
                }
            }

            if (vo.Files != null)
            {
                FilesManager filesManager = new FilesManager();

                foreach (FileVO file in vo.Files)
                {
                    filesManager.Insert(file);
                }
            }

            return res;
        }

        public override bool Delete(DocumentVO vo)
        {
            FilesManager manager = new FilesManager();

            if (vo.Files == null)
            {
                vo.Files = manager.GetFilesOfDocument(vo);
            }

            foreach (FileVO file in vo.Files)
            {
                manager.Delete(file);
            }

            return base.Delete(vo);
        }

        public override bool Update(DocumentVO vo)
        {
            vo.LastEditor = ConfigurationManager.currUser;
            vo.LastEditDateTime = DateTime.Now;
            documentCategoryAttacherDetacher.DetachAllFrom(vo);

            if (vo.Categories != null)
            {
                foreach (CategoryVO cat in vo.Categories)
                {
                    documentCategoryAttacherDetacher.Attach(vo, cat);
                }
            }

            return base.Update(vo);
        }

        public List<DocumentVO> GetDocumentsOfFolder(FolderVO folder)
        {
            List<DocumentVO> documents = ((IDocumentDAO)dataAccessObject).GetDocumentsOfFolder(folder);
            dataAccessObject.CloseConnection();
            return documents;
        }
    }
}

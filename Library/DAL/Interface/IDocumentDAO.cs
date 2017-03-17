using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Common;
using Library.Common.Search;

namespace Library.DAL.Interface
{
    public interface IDocumentDAO : IDAO<DocumentVO>
    {
        List<DocumentVO> FindByTtile(string title, bool isExact);
        List<DocumentVO> FindByProcess(string process, bool isExact);
        List<DocumentVO> FindBySubject(string subject, bool isExact);
        List<DocumentVO> FindByOutNumber(int OutNumber);
        List<DocumentVO> FindByOutDate(DateRange range);
        List<DocumentVO> FindByInNumber(int number);
        List<DocumentVO> FindByInDate(DateRange range);
        List<DocumentVO> FindByCreationDate(DateRange range);
        List<DocumentVO> FindByLastModificationDate(DateRange range);
        List<DocumentVO> FindByFileArchivingDate(DateRange range);
        List<DocumentVO> FindByFileName(string fileName, bool isExact);
        List<DocumentVO> FindByPartyId(int party);
        List<DocumentVO> FindByFolderId(int id);
        List<DocumentVO> FindByCreatorId(int id);
        List<DocumentVO> FindByLastModifierId(int id);
        List<DocumentVO> FindByCategoryId(List<CategoryVO> categories);
        List<DocumentVO> FindByDestinationId(int id);
        void FullLoad(DocumentVO doc);
        List<DocumentVO> GetSubDocumentsOfFolder(FolderVO Folder);
        List<DocumentVO> GetDocumentsOfFolder(FolderVO folder);
    }
}

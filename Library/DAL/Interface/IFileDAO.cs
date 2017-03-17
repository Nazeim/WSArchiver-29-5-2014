using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Common;
using Library.Common.Search;

namespace Library.DAL.Interface
{
    public interface IFileDAO : IDAO<FileVO>
    {
        List<FileVO> FindFilesByName(string name, bool isExact);
        List<FileVO> FindFilesByArchivingDate(DateRange range);
        List<FileVO> GetFilesOfDocument(DocumentVO document);
        bool StoreFile(FileVO vo);
        void DeleteFile(FileVO vo);
        bool RenameFile(FileVO vo);
        bool LoadFileData(FileVO vo);
    }
}

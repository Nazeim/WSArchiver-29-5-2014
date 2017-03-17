using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Common;
using Library.DAL;
using Library.DAL.Interface;

namespace Library.BLL
{
    public class FoldersManager : Manager<FolderVO>
    {
        public FoldersManager()
            : base(DALManager.GetFolderDAO())
        {
        }

        public bool IsFolderNew(FolderVO folder)
        {
            List<FolderVO> folders = GetAll();

            foreach (FolderVO f in folders)
            {
                if (!(f.Id == folder.Id))
                {
                    if (folder.Name == f.Name && folder.BaseFolderId==f.BaseFolderId)
                        return false;
                }


            }


            return true;
        }

        public bool DeleteFolder(FolderVO folder)
        {
            DocumentsManager documentManager = new DocumentsManager();
            folder.Folders = ((IFolderDAO)dataAccessObject).GetSubFoldersOfFolder(folder);
            folder.Documents = documentManager.GetDocumentsOfFolder(folder);

            foreach (DocumentVO d in folder.Documents)
            {
                if (!documentManager.Delete(d))
                    return false;
            }

            foreach (FolderVO f in folder.Folders)
            {
                if (!DeleteFolder(f))
                    return false;
            }
            return Delete(folder);
        }

        public bool MoveFolder(FolderVO source, FolderVO dest)
        {
            source.BaseFolder = dest;
            return Update(source);
        }

        public List<FolderVO> GetSubFoldersOfFolder(FolderVO folder)
        {
            List<FolderVO> result = ((IFolderDAO)dataAccessObject).GetSubFoldersOfFolder(folder);
            Close();

            return result;
        }

        public FolderVO GetRootFolder()
        {
            FolderVO result = (dataAccessObject as IFolderDAO).GetRootFolder();
            Close();

            return result;
        }
    
    }
}

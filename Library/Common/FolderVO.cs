using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Common.Composite;

namespace Library.Common
{
    public class FolderVO : NameBasedVO,IComposite
    {
        private bool isPermanent;
        private FolderVO baseFolder;

        private List<DocumentVO> documents;
        private List<FolderVO> folders;

        public List<FolderVO> Folders
        {
            get { return folders; }
            set { folders = value; }
        }

        public List<DocumentVO> Documents
        {
            get { return documents; }
            set { documents = value; }
        }


        public FolderVO BaseFolder
        {
            get { return baseFolder; }
            set { baseFolder = value; }
        }

        public bool IsPermanent
        {
            get { return isPermanent; }
            set { isPermanent = value; }
        }

        public int? BaseFolderId
        {
            get
            {
                if(baseFolder != null)
                    return baseFolder.Id;

                return null;
            }
        }


        public IComponent GetChildAt(int index) 
        {
            if (index >= 0)
            {
                if (index < Folders.Count )
                {
                    return Folders[index];
                }
                if (index - Folders.Count < Documents.Count )
                {
                    return Documents[index - Folders.Count];
                }
            }
            return null;
                
        }

        public string GetName()
        {
            return Name;
        }


        public int GetChildrenCount()
        {
            int foldersCount = 0;
            int documentsCount = 0;

            if (Folders != null)
                foldersCount = Folders.Count;

            if (Documents != null)
                documentsCount = Documents.Count;

            return foldersCount + documentsCount;
        }
    }
}

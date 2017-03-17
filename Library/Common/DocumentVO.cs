using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Common.Composite;

namespace Library.Common
{
    public class DocumentVO : VO,ILeaf
    {
        private DateTime inDateTime;
        private int inNumber = -1;
        private DateTime outDateTime;
        private int outNumber = -1;
        private DateTime creationDate;
        private UserVO creator;
        private DateTime lastEditDateTime;
        private UserVO lastEditor;
        private DestinationVO destination;
        private FolderVO folder;
        private string title;
        private string process;
        private string subject;
        private bool isDeleted;
        private List<FileVO> files = null;
        private List<CategoryVO> categories = null;
        private PartyVO party;


        public bool IsDeleted
        {
            get { return isDeleted; }
            set { isDeleted = value; }
        }

        public PartyVO Party
        {
            get { return party; }
            set { party = value; }
        }
        public int PartyId
        {
            get
            {
                return party.Id;
            }
        }


        public List<CategoryVO> Categories
        {
            get { return categories; }
            set { categories = value; }
        }

        public List<FileVO> Files
        {
            get { return files; }
            set { files = value; }
        }

        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }

        public string Process
        {
            get { return process; }
            set { process = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public int FolderId
        {
            get
            {
                return folder.Id;
            }
        }

        public FolderVO Folder
        {
            get { return folder; }
            set { folder = value; }
        }


        public int DestinationId
        {
            get
            {
                return destination.Id;
            }
        }

        public DestinationVO Destination
        {
            get { return destination; }
            set { destination = value; }
        }

        public int LastEditorId
        {
            get
            {
                return lastEditor.Id;
            }
        }

        public UserVO LastEditor
        {
            get { return lastEditor; }
            set { lastEditor = value; }
        }

        public DateTime LastEditDateTime
        {
            get { return lastEditDateTime; }
            set { lastEditDateTime = value; }
        }

        public int CreatorId
        {
            get
            {
                return creator.Id;
            }
        }

        public UserVO Creator
        {
            get { return creator; }
            set { creator = value; }
        }

        public DateTime CreationDate
        {
            get { return creationDate; }
            set { creationDate = value; }
        }

        public int OutNumber
        {
            get { return outNumber; }
            set { outNumber = value; }
        }

        public DateTime OutDateTime
        {
            get { return outDateTime; }
            set { outDateTime = value; }
        }


        public int InNumber
        {
            get { return inNumber; }
            set { inNumber = value; }
        }

        public DateTime InDateTime
        {
            get { return inDateTime; }
            set { inDateTime = value; }
        }

        public string GetName()
        {
            return Title;
        }
    }
}

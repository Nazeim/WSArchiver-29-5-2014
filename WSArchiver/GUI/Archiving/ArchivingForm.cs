using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Library.BLL;
using Library.Common;
using System.Collections;
using System.Diagnostics;
using WSArchiver.GUI.Archiving;

namespace WSArchiver.GUI
{
    public partial class ArchivingForm : DialogParent
    {
        public enum OperationMode
        {
            PREVIEW,
            EDIT,
            CREATE
        }

        protected DocumentsManager docsManager = new DocumentsManager();
        protected FilesManager filesManager = new FilesManager();
        protected List<FolderVO> allFolders;
        protected List<PartyVO> allParties;
        protected List<DestinationVO> allDestinations;
        protected List<CategoryVO> allCategories;
        protected DocumentVO currentDocument;
        protected OperationMode operationMode;

        string filePath;
        string fileName;
        FileVO.FileType type;
        bool isPreviewingImage;

        public ArchivingForm()
        {
            InitializeComponent();
        }

        public ArchivingForm(DocumentVO document, OperationMode mode)
            : this()
        {
            if (document == null)
            {
                currentDocument = new DocumentVO();
                currentDocument.Files = new List<FileVO>();
            }
            else
                currentDocument = document;

            operationMode = mode;
        }

        #region Initialization
        private void ArchivingForm_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        private void Initialize()
        {
            ApplyOperationMode();
            SetEnabled(false);
            toolStripProgressBar1.Style = ProgressBarStyle.Marquee;
            loaderBGW.RunWorkerAsync();
        }

        private void FillForm()
        {
            DocTitleTB.Text = currentDocument.Title;
            ProcessTB.Text = currentDocument.Process;
            DocSubjectTB.Text = currentDocument.Subject;
            //IDRegNUD.Value = currentDocument.OutNumber;
            //RegDT.Value = currentDocument.OutDateTime;
            IDInNud.Value = currentDocument.InNumber;
            InDT.Value = currentDocument.InDateTime;

            //if (currentDocument.Type == DocumentVO.DocumentType.FILES)
            //    textBox1.Text = "مستند ملفات إلكترونية";
            //else
            //    textBox1.Text = "مستند صفحات مدخلة بالماسحة الضوئية";

            creationDateTB.Text = currentDocument.CreationDate.ToString();
            creatorTB.Text = currentDocument.Creator.Username;
            lastModificationDatTB.Text = currentDocument.LastEditDateTime.ToString();
            lastModifierTB.Text = currentDocument.LastEditor.Username;
            FolderCB.SelectedItem = currentDocument.Folder;


            //foreach (FolderVO gf in allFolders)
            //{
            //    if (gf.Id == currentDocument.FolderId)
            //    {
            //        PartyVO p = gf.Party;

            //        foreach (PartyVO party in PartyCB.Items)
            //        {
            //            if (party.Id == p.Id)
            //            {
            //                PartyCB.SelectedItem = party;

            //                foreach (FolderVO gf2 in FolderCB.Items)
            //                {
            //                    if (gf2.Id == currentDocument.FolderId)
            //                    {
            //                        FolderCB.SelectedItem = gf2;
            //                        break;
            //                    }
            //                }

            //                break;
            //            }
            //        }

            //        break;
            //    }
            //}

            foreach (DestinationVO des in DestinationCB.Items)
            {
                if (des.Id == currentDocument.DestinationId)
                    DestinationCB.SelectedItem = des;
            }

            if (currentDocument.Categories != null)
                categoriesControl.SelectItems(currentDocument.Categories);

            if (currentDocument.Files != null)
            {
                foreach (FileVO file in currentDocument.Files)
                {
                    AddItemToListView(file);
                }
            }
        }

        private void ApplyOperationMode()
        {
            switch (operationMode)
            {
                case OperationMode.PREVIEW:
                    ApplyPreviewMode();
                    break;
                case OperationMode.EDIT:
                    ApplyEditMode();
                    break;
            }

        }

        private void ApplyPreviewMode()
        {

        }

        private void ApplyEditMode()
        {
            //SaveB.Text = "حفظ التغييرات";
        }

        private void loaderBGW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                AddListToComboBox(PartyCB, allParties);
                AddListToComboBox(DestinationCB, allDestinations);
                AddListToComboBox(FolderCB, allFolders);
                categoriesControl.SetItems(allCategories);

                SetEnabled(true);
                toolStripProgressBar1.Style = ProgressBarStyle.Blocks;

                if (currentDocument.Id > 0)
                    FillForm();
            }
            catch
            { }
        }

        protected void AddListToComboBox(ComboBox comboBox, IList list)
        {
            comboBox.Items.Clear();

            if (list != null && list.Count > 0)
            {
                foreach (object item in list)
                    comboBox.Items.Add(item);

                comboBox.SelectedIndex = 0;
            }
        }

        private void loaderBGW_DoWork(object sender, DoWorkEventArgs e)
        {
            FoldersManager FoldersManager = new FoldersManager();
            CategoriesManager categoriesManager = new CategoriesManager();
            PartiesManager partiesManager = new PartiesManager();
            DestinationsManager destinationManager = new DestinationsManager();
            //Thread.Sleep(5000);
            allFolders = FoldersManager.GetAll();
            allCategories = categoriesManager.GetAll();
            allParties = partiesManager.GetAll();
            allDestinations = destinationManager.GetAll();
        }

        #endregion

        #region Files
        #region To Override
        protected virtual string GetBaseFileName()
        {
            return "ملف-";
        }

        protected virtual string AcquireNewFile()
        {
            return "";
        }
        #endregion

        #region Import Files
        private void importFileB_Click(object sender, EventArgs e)
        {
            filePath = AcquireNewFile();

            if (filePath == "")
                return;

            type = GetTypeFromPath(filePath);

            if (type == FileVO.FileType.UNKNOWN)
            {
                Error("الملف المحدد من نوع بيانات غير معروف");
                return;
            }

            fileName = GenerateNewFileName();
            SetEnabled(false);
            toolStripProgressBar1.Style = ProgressBarStyle.Marquee;
            SetStatus("جاري تشفير الملف");
            encryptorBGW.RunWorkerAsync();
        }

        private void encryptorBGW_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                FileVO file = filesManager.GenerateNewFile(filePath, fileName, currentDocument, type);
                e.Result = file;
            }
            catch
            {
                e.Result = null;
            }
        }

        private void encryptorBGW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                FileVO file = (FileVO)e.Result;
                HandleNewFile(file);
                SetEnabled(true);
                toolStripProgressBar1.Style = ProgressBarStyle.Blocks;
                SetStatus("");
            }
            catch
            {
                Error("حصل خطأ أثناء قراءة الملف و تشفيره. قد يكون حجم الملف كبيراً جداً");
            }
        }

        private void HandleNewFile(FileVO file)
        {
            if (file == null)
            {
                Error("حصل خطأ أثناء قراءة الملف و تشفيره. قد يكون حجم الملف كبيراً جداً");
                return;
            }
            currentDocument.Files.Add(file);

            if (currentDocument.Id > 0)
            {
                if (filesManager.Insert(file) < 0)
                {
                    Error("حصل خطا أثناء عملية حفظ الملف المشفر في قاعدة البيانات. قد يكون حجم الملف كبيراً جداً");
                    return;
                }
            }

            AddItemToListView(file);
        }

        private void AddItemToListView(FileVO file)
        {
            ListViewItem item = PagesLV.Items.Add(file.Name, (int)file.Type);
            item.Tag = file;
        }

        private string GenerateNewFileName()
        {
            int initial = currentDocument.Files.Count + 1;
            string baseName = GetBaseFileName();
            string current;

            for (int i = initial; i < 1000; i++)
            {
                current = baseName + i.ToString();

                if (IsFileNameNew(current))
                    return current;
            }

            Random r = new Random();

            while (true)
            {
                current = baseName + r.Next(1000, Int32.MaxValue);

                if (IsFileNameNew(current))
                    return current;
            }
        }

        private bool IsFileNameNew(string fileName)
        {
            foreach (FileVO file in currentDocument.Files)
            {
                if (file.Name.Equals(fileName.Trim()))
                    return false;
            }

            return true;
        }

        private FileVO.FileType GetTypeFromPath(string filePath)
        {
            string[] temp = filePath.Split('.');

            if (temp.Length == 1)
                return FileVO.FileType.UNKNOWN;

            try
            {
                FileVO.FileType result = (FileVO.FileType)Enum.Parse(typeof(FileVO.FileType), temp[temp.Length - 1], true);
                return result;
            }
            catch
            {
                return FileVO.FileType.UNKNOWN;
            }
        }
        #endregion

        #region Rename Files
        private void RenameFile(FileVO file)
        {
            ChangeFileNameForm form = new ChangeFileNameForm(file.Name);

            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                file.Name = form.NewName;

                if (file.Id >= 0)
                    if (!filesManager.RenameFile(file))
                    {
                        Error("حصل خطأ أثناء إعادة تسمية الملف");
                    }

                PagesLV.SelectedItems[0].Text = form.NewName;
            }
        }
        private void RenameB_Click(object sender, EventArgs e)
        {
            if (PagesLV.SelectedItems.Count > 0)
                RenameFile(PagesLV.SelectedItems[0].Tag as FileVO);
        }

        #endregion

        #region Delete File
        private void DeleteFiles(ListView.SelectedListViewItemCollection collection)
        {
            if (Question("هل أنت متأكد من حذف الملف (الملفات) المحددة؟") == System.Windows.Forms.DialogResult.Yes)
            {
                foreach (ListViewItem item in collection)
                    DeleteFile(item);

                Message("تم حذف الملف (الملفات) بنجاح");
            }
        }

        private void DeleteFile(ListViewItem item)
        {
            FileVO file = item.Tag as FileVO;
            item.Tag = null;
            PagesLV.Items.Remove(item);
            currentDocument.Files.Remove(file);

            if (file.Id >= 0)
            {
                if (!filesManager.Delete(file))
                {
                    Error("حصل خطأ أثناء حذف الملف");
                }
            }
        }

        private void DeletePageB_Click(object sender, EventArgs e)
        {
            if (PagesLV.SelectedItems.Count > 0)
                DeleteFiles(PagesLV.SelectedItems);
        }
        #endregion

        #region Preview File
        private void PreviewFile(FileVO file)
        {
            SetEnabled(false);
            toolStripProgressBar1.Style = ProgressBarStyle.Marquee;
            SetStatus("جاري فك تشفير الملف");
            isPreviewingImage = file.IsImage();
            decryptorBGW.RunWorkerAsync(file);
        }

        private void decryptorBGW_DoWork(object sender, DoWorkEventArgs e)
        {
            FileVO file = (FileVO)e.Argument;
            filesManager.ClearTempDirectory();

            if (isPreviewingImage)
            {
                List<FileVO> images = GetImageFilesOfDocument();
                List<string> imagePaths = new List<string>();
                string current;

                foreach (FileVO currFile in images)
                {
                    current = filesManager.StoreFileInTempDirectory(currFile);

                    if (current != "")
                        imagePaths.Add(current);
                }

                e.Result = imagePaths;
            }
            else
            {
                string path = filesManager.StoreFileInTempDirectory(file);
                e.Result = path;
            }
        }

        private void decryptorBGW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                SetStatus("");
                SetEnabled(true);
                toolStripProgressBar1.Style = ProgressBarStyle.Blocks;

                if (isPreviewingImage)
                {
                    List<string> paths = (List<string>)e.Result;
                    ImagesViwerForm form = new ImagesViwerForm(paths);
                    form.ShowDialog();
                }
                else
                {
                    string path = (string)e.Result;

                    if (path == "")
                    {
                        Error("حصل خطأ أثناء عرض الملف");
                        return;
                    }

                    try
                    {
                        Process.Start(path);
                    }
                    catch
                    {
                        Error("حصل خطأ أثناء عرض الملف");
                        return;
                    }
                }
            }
            catch
            {
                int a = 0;
                int b = a;
            }
        }
        private void ShowPageB_Click(object sender, EventArgs e)
        {
            if (PagesLV.SelectedItems.Count > 0)
                PreviewFile(PagesLV.SelectedItems[0].Tag as FileVO);
        }
        private void PagesLV_ItemActivate(object sender, EventArgs e)
        {
            try
            {
                if (PagesLV.SelectedItems.Count > 0)
                {
                    PreviewFile(PagesLV.SelectedItems[0].Tag as FileVO);
                }
            }
            catch
            { }
        }

        private List<FileVO> GetImageFilesOfDocument()
        {
            List<FileVO> result = new List<FileVO>();

            foreach (FileVO file in currentDocument.Files)
            {
                if (file.IsImage())
                    result.Add(file);
            }

            return result;
        }
        #endregion

        private void PagesLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PagesLV.SelectedItems.Count > 0)
            {
                DeletePageB.Enabled = true;

                if (PagesLV.SelectedItems.Count == 1)
                {
                    RenameB.Enabled = true;
                    ShowPageB.Enabled = true;
                }
                else
                {
                    RenameB.Enabled = false;
                    ShowPageB.Enabled = false;
                }
            }
            else
            {
                RenameB.Enabled = false;
                ShowPageB.Enabled = false;
                DeletePageB.Enabled = false;
            }
        }

        #endregion

        #region Save and update
        private bool ValidateDocument()
        {
            if (FolderCB.SelectedItem == null
                || DestinationCB.SelectedItem == null
                || DocTitleTB.Text.Trim() == ""
                || ProcessTB.Text.Trim() == ""
                || DocSubjectTB.Text.Trim() == "")
            {
                Error("هناك معلومات ناقصة في الوثيقة");
                return false;
            }

            return true;
        }

        protected virtual bool FillDocument()
        {
            if (!ValidateDocument())
                return false;

            currentDocument.Title = DocTitleTB.Text.Trim();
            currentDocument.Process = ProcessTB.Text.Trim();
            currentDocument.Subject = DocSubjectTB.Text.Trim();
            currentDocument.OutNumber = (int)IDRegNUD.Value;
            currentDocument.OutDateTime = RegDT.Value;
            currentDocument.InNumber = (int)IDInNud.Value;
            currentDocument.InDateTime = InDT.Value;
            currentDocument.Folder = (FolderCB.SelectedItem as FolderVO);
            currentDocument.Destination = (DestinationCB.SelectedItem as DestinationVO);
            currentDocument.Categories = categoriesControl.GetSelectedItems();
            currentDocument.Party = PartyCB.SelectedItem as PartyVO;

            return true;
        }
        protected void SaveB_Click(object sender, EventArgs e)
        {
            if (FillDocument())
            {
                SetStatus("جاري الحفظ");
                SetEnabled(false);
                toolStripProgressBar1.Style = ProgressBarStyle.Marquee;
                saverBGW.RunWorkerAsync();
            }
        }
        private void saverBGW_DoWork(object sender, DoWorkEventArgs e)
        {
            if (currentDocument.Id < 0)
            {
                if (docsManager.Insert(currentDocument) < 0)
                    e.Result = false;
                else
                    e.Result = true;
            }
            else
            {
                e.Result = docsManager.Update(currentDocument);
            }
        }

        private void saverBGW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                SetStatus("");
                SetEnabled(true);
                toolStripProgressBar1.Style = ProgressBarStyle.Continuous;

                if (((bool)e.Result))
                {
                    Message("تم إنجاز العملية بنجاح");
                    WriteToLog();

                    Close();
                }
                else
                {
                    Error();
                }
            }
            catch
            { }
        }

        #endregion

        #region Logging
        private void WriteToLog()
        {
            switch (operationMode)
            {
                case OperationMode.CREATE:
                    //if (currentDocument.Type == DocumentVO.DocumentType.FILES)
                    //{
                    string desc = string.Format("{0} {1} {2} {3}", "المستخدم", Library.ConfigurationManager.currUser.Username, "قام بإنشاء الوثيقة", currentDocument.Title);
                    Log(OperationsManager.CREATE_DOCS, desc);
                    // }
                    //else
                    //{
                    //    string desc = string.Format("{0} {1} {2} {3}", "المستخدم", Library.ConfigurationManager.currUser.Username, "قام بإنشاء الوثيقة", currentDocument.Title);
                    //    Log(OperationsManager.CREATE_PAPER_DOCS, desc);
                    //}

                    break;
                case OperationMode.EDIT:
                    //if (currentDocument.Type == DocumentVO.DocumentType.FILES)
                    //{
                    string descr = string.Format("{0} {1} {2} {3}", "المستخدم", Library.ConfigurationManager.currUser.Username, "قام بتعديل الوثيقة", currentDocument.Title);
                    Log(OperationsManager.EDIT_DOCS, descr);
                    //}
                    //else
                    //{
                    //    string desc = string.Format("{0} {1} {2} {3}", "المستخدم", Library.ConfigurationManager.currUser.Username, "قام بتعديل الوثيقة", currentDocument.Title);
                    //    Log(OperationsManager.EDIT_PAPER_DOCS, desc);
                    //}
                    break;
            }
        }

        #endregion

        #region Exiting
        private void exitB_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

    }
}





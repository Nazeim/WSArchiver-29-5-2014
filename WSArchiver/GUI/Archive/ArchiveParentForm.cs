using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Library.Common;
using Library.BLL;
using Library.Common.Search;
using System.Threading;
using System.Diagnostics;
using WSArchiver.GUI.Archiving;

namespace WSArchiver.GUI.Archive
{
    public partial class ArchiveParentForm : ParentForm
    {
        protected DocumentsManager docsManager = new DocumentsManager();
        protected List<FolderVO> allFolders = new List<FolderVO>();
        protected List<UserVO> allUsers = new List<UserVO>();
        protected List<PartyVO> allParties = new List<PartyVO>();
        protected List<DestinationVO> allDestinations = new List<DestinationVO>();
        protected List<CategoryVO> allCategories = new List<CategoryVO>();

        #region Initi
        public ArchiveParentForm()
        {
            InitializeComponent();
        }

        private void ArchiveParentForm_Load(object sender, EventArgs e)
        {
            SetEnabled(false);
            loaderBGW.RunWorkerAsync();
            toolStripProgressBar2.Visible = true;
            statusStrip1.Items.RemoveAt(0);
            toolStripProgressBar2.Style = ProgressBarStyle.Marquee;
        }

        private void loaderBGW_DoWork(object sender, DoWorkEventArgs e)
        {
            FoldersManager FoldersManager = new FoldersManager();
            CategoriesManager categoriesManager = new CategoriesManager();
            UsersManager usersManager = new UsersManager();
            PartiesManager partiesManager = new PartiesManager();
            DestinationsManager destinationManager = new DestinationsManager();
            //Thread.Sleep(5000);
            allFolders = FoldersManager.GetAll();
            allCategories = categoriesManager.GetAll();
            allUsers = usersManager.GetAll();
            allParties = partiesManager.GetAll();
            allDestinations = destinationManager.GetAll();
        }
        #endregion

        #region GridViews
        private void documentsBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (documentsBindingSource.Current == null)
            {
                filesBindingSource.Clear();
                editSelectedDocumentB.Enabled = false;
                deleteSelectedDocumentB.Enabled = false;
            }
            else
            {
                deleteSelectedDocumentB.Enabled = true;
                editSelectedDocumentB.Enabled = true;
                DocumentVO document = documentsBindingSource.Current as DocumentVO;

                if (document.Files != null)
                {
                    filesBindingSource.Clear();

                    foreach (FileVO file in document.Files)
                    {
                        filesBindingSource.Add(file);
                    }
                }
            }
        }

        private void filesBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (filesBindingSource.Current == null)
            {
                showSelectedFileB.Enabled = false;
                removeSelectedFile.Enabled = false;
            }
            else
            {
                showSelectedFileB.Enabled = true;
                removeSelectedFile.Enabled = true;
            }
        }
        #endregion

        #region Buttons
        private void exitB_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void deleteSelectedDocumentB_Click(object sender, EventArgs e)
        {
            OperationsManager opMan = new OperationsManager();
            DocumentVO document = documentsBindingSource.Current as DocumentVO;

            if (document != null)
            {
                if (!opMan.HasPermission(OperationsManager.EDIT_DOCS, Library.ConfigurationManager.currUser))
                {
                    Error("أنت لا تمتلك السماحية للقيام بهذه العملية");
                    return;
                }
            }
            else
                return;

            DialogResult result = Question("هل أنت متأكد من أنك تريد حذف الوثيقة المحددة؟ هذا سيؤدي إلى حذف الملفات المرتبطة بها كذلك كما أنه لا يمكنك التراجع عن هذه العملية لاحقاً");

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                document = documentsBindingSource.Current as DocumentVO;

                if (docsManager.Delete(document))
                {
                    Message("تمت عملية الحذف بنجاح", "عملية ناجحة");
                    WriteToLogDocDleted(document);
                    filesBindingSource.Clear();
                    documentsBindingSource.Remove(document);
                    SetResultsCount(documentsBindingSource.Count);
                }
                else
                    Error("فشل عملية الحذف", "عملية فاشلة");
            }

        }

        private void removeSelectedFile_Click(object sender, EventArgs e)
        {
            OperationsManager opMan = new OperationsManager();
            DocumentVO document = documentsBindingSource.Current as DocumentVO;
            FileVO file = filesBindingSource.Current as FileVO;

            if (document != null && file != null)
            {
                if (!opMan.HasPermission(OperationsManager.EDIT_DOCS, Library.ConfigurationManager.currUser))
                {
                    Error("أنت لا تمتلك السماحية للقيام بهذه العملية");
                    return;
                }
            }
            else
                return;

            DialogResult result = Question("هل أنت متأكد من أنك تريد حذف الملف المحدد؟ لا يمكنك التراجع عن هذه العملية لاحقاً");

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                FilesManager manager = new FilesManager();

                if (manager.Delete(file))
                {
                    WriteToLogFileDleted(document, file);
                    Message("تمت عملية الحذف بنجاح", "عملية ناجحة");
                    filesBindingSource.Remove(file);
                }
                else
                    Error("فشل عملية الحذف", "عملية فاشلة");
            }
        }
        #endregion

        #region Search
        protected virtual List<Filter> GenerateFilters()
        {
            return null;
        }

        protected void Search()
        {
            SetEnabled(false);
            documentsBindingSource.Clear();
            filesBindingSource.Clear();
            rowsCountStripLabel.Visible = false;
            toolStripProgressBar2.Style = ProgressBarStyle.Marquee;
            SetStatus("جاري البحث");
            searcherBGW.RunWorkerAsync(GenerateFilters());


        }

        private void ShowSearchResults(List<DocumentVO> result)
        {
            documentsBindingSource.Clear();

            foreach (DocumentVO doc in result)
                documentsBindingSource.Add(doc);

            DocumentsdataGridView.Refresh();
        }
        #endregion

        private void searcherBGW_DoWork(object sender, DoWorkEventArgs e)
        {
            List<Filter> filter = (List<Filter>)e.Argument;
            List<DocumentVO> result = docsManager.Find(filter);
            //Thread.Sleep(5000);
            e.Result = result;
        }

        private void searcherBGW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                SetEnabled(true);
                showSelectedFileB.Enabled = false;
                removeSelectedFile.Enabled = false;
                editSelectedDocumentB.Enabled = false;
                deleteSelectedDocumentB.Enabled = false;

                toolStripProgressBar2.Style = ProgressBarStyle.Blocks;
                List<DocumentVO> result = (List<DocumentVO>)e.Result;
                SetStatus("انتهى البحث");
                rowsCountStripLabel.Visible = true;
                SetResultsCount(result.Count);
                ShowSearchResults(result);
            }
            catch
            { }
        }

        private void showSelectedFileB_Click(object sender, EventArgs e)
        {
            //TODO: Future : make sql server load file data only on demand
            FileVO file = filesBindingSource.Current as FileVO;

            if (file == null)
                return;

            SetEnabled(false);
            SetStatus("جاري فك تشفير الملف");
            toolStripProgressBar2.Style = ProgressBarStyle.Marquee;

            decryptorBGW.RunWorkerAsync(file);
        }

        private void decryptorBGW_DoWork(object sender, DoWorkEventArgs e)
        {
            FileVO file = (FileVO)e.Argument;
            FilesManager filesManager = new FilesManager();
            string path = filesManager.StoreFileInTempDirectory(file);
            e.Result = path;
        }

        private void decryptorBGW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                SetEnabled(true);
                SetStatus("");
                toolStripProgressBar2.Style = ProgressBarStyle.Continuous;
                string path = (string)e.Result;

                if (path == "")
                {
                    Error("تعذر فتح الملف المحدد");
                    return;
                }

                try
                {
                    Process.Start(path);
                }
                catch
                {
                    Error("تعذر فتح الملف المحدد");
                }
            }
            catch
            { }
        }

        private void editSelectedDocumentB_Click(object sender, EventArgs e)
        {
            DocumentVO document = documentsBindingSource.Current as DocumentVO;

            if (document != null)
            {
                OperationsManager manager = new OperationsManager();

                //if (document.Type == DocumentVO.DocumentType.FILES)
                //{
                if (manager.HasPermission(OperationsManager.EDIT_DOCS, Library.ConfigurationManager.currUser))
                {
                    EFilesArchivingForm form = new EFilesArchivingForm(document, ArchivingForm.OperationMode.EDIT);
                    form.ShowDialog();
                }
                else
                {
                    Error("أنت لا تمتلك السماحية للقيام بهذه العملية");
                }
                //}
                //else
                //{
                //    if (manager.HasPermission(OperationsManager.EDIT_PAPER_DOCS, Library.ConfigurationManager.currUser))
                //    {
                //        PaperArchivingForm form1 = new PaperArchivingForm(document, ArchivingForm.OperationMode.EDIT);
                //        form1.ShowDialog();
                //    }
                //    else
                //    {
                //        Error("أنت لا تمتلك السماحية للقيام بهذه العملية");
                //    }
                //}

            }
        }

        private void WriteToLogDocDleted(DocumentVO doc)
        {

            //if (doc.Type == DocumentVO.DocumentType.FILES)
            //{
            string desc = string.Format("{0} {1} {2} {3}", "المستخدم", Library.ConfigurationManager.currUser.Username, "قام بحذف الوثيقة", doc.Title);
            Log(OperationsManager.EDIT_DOCS, desc);
            //}
            //else
            //{
            //    string desc = string.Format("{0} {1} {2} {3}", "المستخدم", Library.ConfigurationManager.currUser.Username, "قام بحذف الوثيقة", doc.Title);
            //    Log(OperationsManager.EDIT_PAPER_DOCS, desc);
            //}
        }

        private void WriteToLogFileDleted(DocumentVO doc, FileVO file)
        {
            //if (doc.Type == DocumentVO.DocumentType.FILES)
            //{
            string desc = string.Format("{0} {1} {2} {3} {4} {5}", "المستخدم", Library.ConfigurationManager.currUser.Username, "قام بحذف الملف", file.Name, "الخاص بالوثيقة", doc.Title);
            Log(OperationsManager.EDIT_DOCS, desc);
            //}
            //else
            //{
            //    string desc = string.Format("{0} {1} {2} {3} {4} {5}", "المستخدم", Library.ConfigurationManager.currUser.Username, "قام بحذف الملف", file.Name, "الخاص بالوثيقة", doc.Title);
            //    Log(OperationsManager.EDIT_PAPER_DOCS, desc);
            //}
        }

        private void SearchForSimilarResultsButton_Click(object sender, EventArgs e)
        {

        }



    }
}

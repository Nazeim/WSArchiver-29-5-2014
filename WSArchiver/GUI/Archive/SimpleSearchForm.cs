using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WSArchiver.GUI.UserControls;
using Library.Common;
using Library.Common.Search;
using Library.BLL;

namespace WSArchiver.GUI.Archive
{
    public partial class SimpleSearchForm : ArchiveParentForm
    {
        private bool isExact = false;

        #region SearchControls
        ComboBoxSearchControl docFolderId =
                new ComboBoxSearchControl(Library.Common.Search.Filter.FilterEnum.DOC_GENERAL_FILE_ID);
        ComboBoxSearchControl docCreatorId =
            new ComboBoxSearchControl(Library.Common.Search.Filter.FilterEnum.DOC_CREATOR_ID);
        ComboBoxSearchControl docLastModifier =
            new ComboBoxSearchControl(Library.Common.Search.Filter.FilterEnum.DOC_LAST_MODIFIER_ID);
        ComboBoxSearchControl partyId =
            new ComboBoxSearchControl(Library.Common.Search.Filter.FilterEnum.PARTY_ID);
        ComboBoxSearchControl destinationId =
            new ComboBoxSearchControl(Library.Common.Search.Filter.FilterEnum.DESTINATION_ID);

        MultipleItemsSearchControl categoryId =
            new MultipleItemsSearchControl(Library.Common.Search.Filter.FilterEnum.CATEGOTY_ID);

        NumericUpDownSearchControl docRegistrationNum =
            new NumericUpDownSearchControl(Library.Common.Search.Filter.FilterEnum.DOC_REGISTRATION_NUMBER);
        NumericUpDownSearchControl docInNum =
            new NumericUpDownSearchControl(Library.Common.Search.Filter.FilterEnum.DOC_IN_NUMBER);
        NumericUpDownSearchControl partyNumber =
            new NumericUpDownSearchControl(Library.Common.Search.Filter.FilterEnum.PARTY_NUMBER);
        NumericUpDownSearchControl FolderNumber =
            new NumericUpDownSearchControl(Library.Common.Search.Filter.FilterEnum.GENERAL_FILE_NUMBER);

        DateRangeSearchControl docRegDate =
            new DateRangeSearchControl(Library.Common.Search.Filter.FilterEnum.DOC_REGISTRATION_DATE);
        DateRangeSearchControl docInDate =
            new DateRangeSearchControl(Library.Common.Search.Filter.FilterEnum.DOC_IN_DATE);
        DateRangeSearchControl docCreationDate =
            new DateRangeSearchControl(Library.Common.Search.Filter.FilterEnum.DOC_CREATION_DATE);
        DateRangeSearchControl docLastModification =
            new DateRangeSearchControl(Library.Common.Search.Filter.FilterEnum.DOC_LAST_MODIFICATION_DATE);
        DateRangeSearchControl fileArchivingDate =
            new DateRangeSearchControl(Library.Common.Search.Filter.FilterEnum.FILE_ARCHIVING_DATE);

        SingleLineStringSearchControl fileName =
            new SingleLineStringSearchControl(Library.Common.Search.Filter.FilterEnum.FILE_NAME);
        SingleLineStringSearchControl docTitle =
            new SingleLineStringSearchControl(Library.Common.Search.Filter.FilterEnum.DOC_TITLE);

        MultilineStringSearchControl docProcess =
            new MultilineStringSearchControl(Library.Common.Search.Filter.FilterEnum.DOC_PROCESS);
        MultilineStringSearchControl docSubject =
            new MultilineStringSearchControl(Library.Common.Search.Filter.FilterEnum.DOC_SUBJECT);
        #endregion

        public SimpleSearchForm()
        {
            InitializeComponent();
        }

        private void Initialize()
        {
            comboBox1.Items.Add(docTitle);
            comboBox1.Items.Add(fileName);
            comboBox1.Items.Add(partyNumber);
            comboBox1.Items.Add(partyId);
            comboBox1.Items.Add(docFolderId);
            comboBox1.Items.Add(FolderNumber);
            comboBox1.Items.Add(destinationId);
            comboBox1.Items.Add(docRegistrationNum);
            comboBox1.Items.Add(docRegDate);
            comboBox1.Items.Add(docCreationDate);
            comboBox1.Items.Add(docCreatorId);
            comboBox1.Items.Add(docLastModification);
            comboBox1.Items.Add(docLastModifier);
            comboBox1.Items.Add(fileArchivingDate);
            comboBox1.Items.Add(docInNum);
            comboBox1.Items.Add(docInDate);
            comboBox1.Items.Add(categoryId);
            comboBox1.Items.Add(docProcess);
            comboBox1.Items.Add(docSubject);
        }

        private void loaderBGW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                docFolderId.SetItems(allFolders);
                docCreatorId.SetItems(allUsers);
                docLastModifier.SetItems(allUsers);
                partyId.SetItems(allParties);
                destinationId.SetItems(allDestinations);
                categoryId.SetItems(allCategories);
                toolStripProgressBar2.Style = ProgressBarStyle.Blocks;
                SetEnabled(true);
                comboBox1.SelectedIndex = 0;
            }
            catch
            { }
        }

        private void SimpleSearchForm_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchControl current = comboBox1.SelectedItem as SearchControl;
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(current);
            flowLayoutPanel1.Controls[0].Focus();


            if (current.FilterType == Filter.FilterEnum.DOC_SUBJECT || current.FilterType == Filter.FilterEnum.DOC_TITLE
                || current.FilterType == Filter.FilterEnum.DOC_PROCESS || current.FilterType == Filter.FilterEnum.FILE_NAME)
            {
                SearchForSimilarResultsButton.Enabled = true;
            }
            else
                SearchForSimilarResultsButton.Enabled = false;
        }

        private void SearchForExactMatchResultsButton_Click(object sender, EventArgs e)
        {
            isExact = true;
            Search();
            Log(OperationsManager.SIMPLE_SEARCH);
        }

        private void SearchForSimilarResultsButton_Click(object sender, EventArgs e)
        {
            isExact = false;
            Search();
            Log(OperationsManager.SIMPLE_SEARCH);
        }

        protected override List<Filter> GenerateFilters()
        {
            List<Filter> filters = new List<Filter>();
            SearchControl control = flowLayoutPanel1.Controls[0] as SearchControl;

            if (isExact)
            {
                switch (control.FilterType)
                {
                    case Filter.FilterEnum.DOC_PROCESS:
                        control.FilterType = Filter.FilterEnum.DOC_PROCESS_EXACT;
                        break;
                    case Filter.FilterEnum.DOC_SUBJECT:
                        control.FilterType = Filter.FilterEnum.DOC_SUBJECT_EXACT;
                        break;
                    case Filter.FilterEnum.DOC_TITLE:
                        control.FilterType = Filter.FilterEnum.DOC_TITLE_EXACT;
                        break;
                    case Filter.FilterEnum.FILE_NAME:
                        control.FilterType = Filter.FilterEnum.FILE_NAME_EXACT;
                        break;
                }
            }
            else
            {
                switch (control.FilterType)
                {
                    case Filter.FilterEnum.DOC_PROCESS_EXACT:
                        control.FilterType = Filter.FilterEnum.DOC_PROCESS;
                        break;
                    case Filter.FilterEnum.DOC_SUBJECT_EXACT:
                        control.FilterType = Filter.FilterEnum.DOC_SUBJECT;
                        break;
                    case Filter.FilterEnum.DOC_TITLE_EXACT:
                        control.FilterType = Filter.FilterEnum.DOC_TITLE;
                        break;
                    case Filter.FilterEnum.FILE_NAME_EXACT:
                        control.FilterType = Filter.FilterEnum.FILE_NAME;
                        break;
                }
            }

            filters.Add(control.Filter);

            return filters;
        }

        private void advancedSearchB_Click(object sender, EventArgs e)
        {
            AdvancedSearchForm form = new AdvancedSearchForm();
            Hide();
            form.ShowDialog();
            Close();
        }

        protected override void ValidateUserPermissions()
        {
            OperationsManager manager = new OperationsManager();

            if (manager.HasPermission(OperationsManager.ADVANCED_SEARCH, Library.ConfigurationManager.currUser))
                advancedSearchB.Enabled = true;
        }

    }
}

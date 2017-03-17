using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WSArchiver.GUI.UserControls;
using Library.Common.Search;
using Library.BLL;

namespace WSArchiver.GUI.Archive
{
    public partial class AdvancedSearchForm : WSArchiver.GUI.Archive.ArchiveParentForm
    {
        private bool isExact;
        #region Initialization
        public AdvancedSearchForm()
        {
            InitializeComponent();
        }

        private void loaderBGW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                partyIdCG.comboBoxSearchControl1.SetItems(allParties);
                FolderCG.comboBoxSearchControl1.SetItems(allFolders);
                destinationCG.comboBoxSearchControl1.SetItems(allDestinations);
                creatorIdCG.comboBoxSearchControl1.SetItems(allUsers);
                lastModifierIdCG.comboBoxSearchControl1.SetItems(allUsers);
                categoriesCG.multipleItemsSearchControl1.SetItems(allCategories);

                toolStripProgressBar2.Style = ProgressBarStyle.Blocks;
                SetEnabled(true);
            }
            catch { }
        }

        private void singlelineStringCheckedGroup1_Load(object sender, EventArgs e)
        {
            ((CheckedGroupBox)sender).SearchControl.FilterType = Library.Common.Search.Filter.FilterEnum.DOC_TITLE;
        }

        private void singlelineStringCheckedGroup2_Load(object sender, EventArgs e)
        {
            ((CheckedGroupBox)sender).SearchControl.FilterType = Library.Common.Search.Filter.FilterEnum.FILE_NAME;
        }

        private void comboBoxCheckedGroup1_Load(object sender, EventArgs e)
        {
            ((CheckedGroupBox)sender).SearchControl.FilterType = Library.Common.Search.Filter.FilterEnum.PARTY_ID;
        }

        private void comboBoxCheckedGroup2_Load(object sender, EventArgs e)
        {
            ((CheckedGroupBox)sender).SearchControl.FilterType = Library.Common.Search.Filter.FilterEnum.DOC_GENERAL_FILE_ID;
        }

        private void comboBoxCheckedGroup3_Load(object sender, EventArgs e)
        {
            ((CheckedGroupBox)sender).SearchControl.FilterType = Library.Common.Search.Filter.FilterEnum.DESTINATION_ID;
        }

        private void comboBoxCheckedGroup4_Load(object sender, EventArgs e)
        {
            ((CheckedGroupBox)sender).SearchControl.FilterType = Library.Common.Search.Filter.FilterEnum.DOC_CREATOR_ID;
        }

        private void comboBoxCheckedGroup5_Load(object sender, EventArgs e)
        {
            ((CheckedGroupBox)sender).SearchControl.FilterType = Library.Common.Search.Filter.FilterEnum.DOC_LAST_MODIFIER_ID;
        }

        private void dateRangeCheckedGroup1_Load(object sender, EventArgs e)
        {
            ((CheckedGroupBox)sender).SearchControl.FilterType = Library.Common.Search.Filter.FilterEnum.DOC_CREATION_DATE;
        }

        private void dateRangeCheckedGroup2_Load(object sender, EventArgs e)
        {
            ((CheckedGroupBox)sender).SearchControl.FilterType = Library.Common.Search.Filter.FilterEnum.FILE_ARCHIVING_DATE;
        }

        private void numericUpDownCheckedGroup2_Load(object sender, EventArgs e)
        {
            ((CheckedGroupBox)sender).SearchControl.FilterType = Library.Common.Search.Filter.FilterEnum.PARTY_NUMBER;
        }

        private void numericUpDownCheckedGroup1_Load(object sender, EventArgs e)
        {
            ((CheckedGroupBox)sender).SearchControl.FilterType = Library.Common.Search.Filter.FilterEnum.DOC_REGISTRATION_NUMBER;
        }

        private void numericUpDownCheckedGroup3_Load(object sender, EventArgs e)
        {
            ((CheckedGroupBox)sender).SearchControl.FilterType = Library.Common.Search.Filter.FilterEnum.GENERAL_FILE_NUMBER;
        }

        private void numericUpDownCheckedGroup4_Load(object sender, EventArgs e)
        {
            ((CheckedGroupBox)sender).SearchControl.FilterType = Library.Common.Search.Filter.FilterEnum.DOC_IN_NUMBER;
        }

        private void dateRangeCheckedGroup3_Load(object sender, EventArgs e)
        {
            ((CheckedGroupBox)sender).SearchControl.FilterType = Library.Common.Search.Filter.FilterEnum.DOC_REGISTRATION_DATE;
        }

        private void dateRangeCheckedGroup4_Load(object sender, EventArgs e)
        {
            ((CheckedGroupBox)sender).SearchControl.FilterType = Library.Common.Search.Filter.FilterEnum.DOC_IN_DATE;
        }

        private void multipleItemsCheckedGroup1_Load(object sender, EventArgs e)
        {
            ((CheckedGroupBox)sender).SearchControl.FilterType = Library.Common.Search.Filter.FilterEnum.CATEGOTY_ID;
        }

        private void dateRangeCheckedGroup6_Load(object sender, EventArgs e)
        {
            ((CheckedGroupBox)sender).SearchControl.FilterType = Library.Common.Search.Filter.FilterEnum.DOC_LAST_MODIFICATION_DATE;
        }

        private void multilineStringCheckedGroup1_Load(object sender, EventArgs e)
        {
            ((CheckedGroupBox)sender).SearchControl.FilterType = Library.Common.Search.Filter.FilterEnum.DOC_PROCESS;
        }

        private void multilineStringCheckedGroup2_Load(object sender, EventArgs e)
        {
            ((CheckedGroupBox)sender).SearchControl.FilterType = Library.Common.Search.Filter.FilterEnum.DOC_SUBJECT;
        }

        #endregion

        protected override List<Filter> GenerateFilters()
        {
            List<Filter> filters = new List<Filter>();
            SearchControl current;

            foreach (Control c in searchGB.Controls)
            {
                if (c is CheckedGroupBox && ((CheckedGroupBox)c).GroupChecked)
                {
                    current = ((CheckedGroupBox)c).SearchControl;

                    if (isExact)
                    {
                        switch (current.FilterType)
                        {
                            case Filter.FilterEnum.DOC_PROCESS:
                                current.FilterType = Filter.FilterEnum.DOC_PROCESS_EXACT;
                                break;
                            case Filter.FilterEnum.DOC_SUBJECT:
                                current.FilterType = Filter.FilterEnum.DOC_SUBJECT_EXACT;
                                break;
                            case Filter.FilterEnum.DOC_TITLE:
                                current.FilterType = Filter.FilterEnum.DOC_TITLE_EXACT;
                                break;
                            case Filter.FilterEnum.FILE_NAME:
                                current.FilterType = Filter.FilterEnum.FILE_NAME_EXACT;
                                break;
                        }
                    }
                    else
                    {
                        switch (current.FilterType)
                        {
                            case Filter.FilterEnum.DOC_PROCESS_EXACT:
                                current.FilterType = Filter.FilterEnum.DOC_PROCESS;
                                break;
                            case Filter.FilterEnum.DOC_SUBJECT_EXACT:
                                current.FilterType = Filter.FilterEnum.DOC_SUBJECT;
                                break;
                            case Filter.FilterEnum.DOC_TITLE_EXACT:
                                current.FilterType = Filter.FilterEnum.DOC_TITLE;
                                break;
                            case Filter.FilterEnum.FILE_NAME_EXACT:
                                current.FilterType = Filter.FilterEnum.FILE_NAME;
                                break;
                        }
                    }

                    filters.Add(current.Filter);
                }
            }



            return filters;
        }

        private void SearchForSimilarResultsButton_Click(object sender, EventArgs e)
        {
            isExact = false;
            Search();
            Log(OperationsManager.ADVANCED_SEARCH);
        }

        private void SearchForExactMatchResultsButton_Click(object sender, EventArgs e)
        {
            isExact = true;
            Search();
            Log(OperationsManager.ADVANCED_SEARCH);
        }

    }
}

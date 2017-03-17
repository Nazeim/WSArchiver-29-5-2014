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
using WSArchiver.GUI.UserControls;
using Library.Common.Search;

namespace WSArchiver.GUI
{
    public partial class LogFileForm : ParentForm
    {
        OperationsManager operationsManager = new OperationsManager();
        UsersManager usersManager = new UsersManager();
        LogManager manager = new LogManager();

        DateRange currentRange;
        OperationVO currentOperation;
        UserVO currentUser;

        public LogFileForm()
        {
            InitializeComponent();
        }

        private void SearchB_Click(object sender, EventArgs e)
        {
            Log(OperationsManager.SEARCH_LOG);
            currentOperation = GenerateOperation();
            currentRange = GenerateDateRange();
            currentUser = GenerateUser();
            toolStripProgressBar1.Style = ProgressBarStyle.Marquee;
            SetEnabled(false);
            SetStatus("جاري البحث");
            searcherBGW.RunWorkerAsync();
        }

        private void LogFileForm_Load(object sender, EventArgs e)
        {
            List<OperationVO> allOps = operationsManager.GetAll();
            List<UserVO> allUsers = usersManager.GetAll();

            (operationCCB.SearchControl as ComboBoxSearchControl).SetItems(allOps);
            (userCCB.SearchControl as ComboBoxSearchControl).SetItems(allUsers);
        }

        private DateRange GenerateDateRange()
        {
            if(dateRangeCheckedGroup1.GroupChecked)
                return dateRangeCheckedGroup1.dateRangeSearchControl1.GenerateDateRange();

            return null;
        }

        private OperationVO GenerateOperation()
        {
            if(operationCCB.GroupChecked)
                return (operationCCB.SearchControl as ComboBoxSearchControl).GetSelection() as OperationVO;

            return null;
        }

        private UserVO GenerateUser()
        {
            if(userCCB.GroupChecked)
                return (userCCB.SearchControl as ComboBoxSearchControl).GetSelection() as UserVO;

            return null;
        }

        private void searcherBGW_DoWork(object sender, DoWorkEventArgs e)
        {
            List<LogEntryVO> result = manager.Find(currentRange, currentOperation, currentUser);
            e.Result = result;
        }

        private void searcherBGW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                List<LogEntryVO> result = (List<LogEntryVO>)e.Result;
                SetStatus("انتهى البحث");
                SetEnabled(true);
                SetResultsCount(result.Count);
                toolStripProgressBar1.Style = ProgressBarStyle.Continuous;

                bindingSource1.Clear();

                foreach (LogEntryVO item in result)
                    bindingSource1.Add(item);
            }
            catch
            { }
        }

        private void exitB_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}

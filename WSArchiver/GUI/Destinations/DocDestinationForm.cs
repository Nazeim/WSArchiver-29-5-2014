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
using WSArchiver.GUI.Destinations;

namespace WSArchiver.GUI
{
    public partial class DocDestinationForm : DialogParent
    {

        DestinationsManager manager = new DestinationsManager();


        // List<DestinationVO> list;

        public DocDestinationForm()
        {
            InitializeComponent();
        }
        private void Initialize()
        {
            StartWorker();
        }
        private void StartWorker()
        {
            SetEnabled(false);
            backgroundWorker1.RunWorkerAsync();
            toolStripProgressBar1.Style = ProgressBarStyle.Marquee;
        }

        private void DocDestinationForm_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        private void exitB_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            List<DestinationVO> all = manager.GetAll();
            e.Result = all;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                List<DestinationVO> all = e.Result as List<DestinationVO>;
                bindingSource1.Clear();

                foreach (DestinationVO d in all)
                    bindingSource1.Add(d);

                SetEnabled(true);
                toolStripProgressBar1.Style = ProgressBarStyle.Blocks;

            }
            catch
            { }
        }


        private void DocDestinationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != System.Windows.Forms.DialogResult.OK)
                DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }



        private void InsertDestinationButton_Click(object sender, EventArgs e)
        {
            DestinationVO dest = new DestinationVO();
            dest.Name = DestinationTB.Text.Trim();

            if (!manager.IsDestinationNew(dest))
            {
                Error("اسم الوجهة موجود سابقاً", "تعذر إضافة وجهة جديد");
                return;
            }
            if (DestinationTB.Text.Trim() == "")
            {
                Error("اسم الوجهة لا يمكن أن يكون فارغاً");
                return;
            }
            if (manager.Insert(dest) < 0)
            {
                Error("حدث خطأ أثناء عملية إضافة الوجهة", "فشل عملية الإضافة");
            }
            else
            {
                bindingSource1.Add(dest);
                Message("تم إضافة الملف بنجاح", "عملية ناجحة");
                DestinationTB.Text = "";
                DestinationTB.Focus();
                Log(OperationsManager.EDIT_DESTINATIONS);
            }
        }

        private void UpdateDestinationButton_Click(object sender, EventArgs e)
        {

            DestinationVO current = bindingSource1.Current as DestinationVO;
            if (current != null)
            {
                DestinationEditForm form = new DestinationEditForm(current, manager);

                if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    DestinationDataGridView.Refresh();
                    Log(OperationsManager.EDIT_DESTINATIONS);
                }
            }
        }

        private void RemovDestinationButton_Click(object sender, EventArgs e)
        {
            DestinationVO current = bindingSource1.Current as DestinationVO;
            if (current != null)
            {
                if (Question("هل أنت متأكد من الحذف؟") == System.Windows.Forms.DialogResult.Yes)
                {
                    if (manager.Delete(current))
                    {
                        bindingSource1.Remove(current);
                        DestinationDataGridView.Refresh();
                        Message("تم الحذف بنجاح");
                        Log(OperationsManager.EDIT_DESTINATIONS);
                    }
                    else
                    {
                        Error();
                    }
                }
            }
        }
    }
}
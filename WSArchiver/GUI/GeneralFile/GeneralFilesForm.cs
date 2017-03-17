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
using WSArchiver.GUI.Folder;

namespace WSArchiver.GUI
{
    public partial class FoldersForm : DialogParent
    {
        PartiesManager manager = new PartiesManager();
        FoldersManager gManager = new FoldersManager();
        List<PartyVO> list;

        public FoldersForm()
        {
            InitializeComponent();
        }
        private void Initialize()
        {
            StartWorker();

            foreach (Control c in Controls)
            {
                if (c is NumericUpDown)
                    ((NumericUpDown)c).Maximum = Int32.MaxValue;
            }


            list = manager.GetAll();

            foreach (PartyVO v in list)
                FoldercomboBox.Items.Add(v);

            if (list.Count > 0)
                FoldercomboBox.SelectedIndex = 0;



        }

        private void StartWorker()
        {
            SetEnabled(false);
            backgroundWorker1.RunWorkerAsync();
            toolStripProgressBar1.Style = ProgressBarStyle.Marquee;
        }


        private void FoldersForm_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        private void FoldercomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FoldercomboBox.SelectedIndex >= 0)
            {
                PartyVO current = list[FoldercomboBox.SelectedIndex] as PartyVO;
                //IdPartynumericUpDown.Value = current.Number;
            }
        }

        private void IdPartynumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            //foreach (PartyVO part in list)
            //{
            //    if (part.Number == (int)IdPartynumericUpDown.Value)
            //    {
            //        FoldercomboBox.SelectedItem = part;
            //        return;
            //    }
            //}

            //FoldercomboBox.SelectedIndex = -1;
        }


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            List<FolderVO> all = gManager.GetAll();
            e.Result = all;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                List<FolderVO> all = e.Result as List<FolderVO>;
                bindingSource1.Clear();

                if (all.Count > 0)
                {
                    //int maxNumber = Int32.MinValue;

                    //foreach (FolderVO f in all)
                    //{
                    //    maxNumber = Math.Max(maxNumber, f.Number);
                    //    bindingSource1.Add(f);
                    //}

                    //IdFoldersNumericUpDown.Value = (int)maxNumber + 1;
                }

                SetEnabled(true);
                toolStripProgressBar1.Style = ProgressBarStyle.Blocks;
            }
            catch
            { }
        }


        private void exitB_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void FoldersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != System.Windows.Forms.DialogResult.OK)
                DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }


        private void InsertFilebutton1_Click(object sender, EventArgs e)
        {
            FolderVO file = new FolderVO();

            file.Name = FolderTB.Text.Trim();
            //file.Number = (int)IdFoldersNumericUpDown.Value;
            //file.Party = FoldercomboBox.SelectedItem as PartyVO;

            //if (file.Party == null)
            //{
            //    Error("لا بمكن إضافة ملف عام بدون ربطه بجهة معينة");
            //    return;
            //}

            if (!gManager.IsFolderNew(file))
            {
                Error("اسم الملف أو رقمه موجود سابقاً", "تعذر إضافة ملف جديد");
                return;
            }
            if (FolderTB.Text.Trim() == "")
            {
                Error("اسم الملف لا يمكن أن يكون فارغاً");
                return;
            }
            if (gManager.Insert(file) < 0)
            {
                Error("حدث خطأ أثناء عملية إضافة الملف", "فشل عملية الإضافة");
            }
            else
            {
                bindingSource1.Add(file);
                Message("تم إضافة الملف بنجاح", "عملية ناجحة");
                IdFoldersNumericUpDown.Value++;
                FolderTB.Text = "";
                FolderTB.Focus();
                Log(OperationsManager.EDIT_GENERAL_FILES);
            }
        }
        private void UpdateFilebutton2_Click(object sender, EventArgs e)
        {
            FolderVO current = bindingSource1.Current as FolderVO;

            if (current != null)
            {
                FolderEditForm form = new FolderEditForm(current, gManager);

                if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    FoldersDataGridView.Refresh();
                    Log(OperationsManager.EDIT_GENERAL_FILES);
                }
            }
        }
        private void RemovFilebutton3_Click(object sender, EventArgs e)
        {
            FolderVO current = bindingSource1.Current as FolderVO;
            if (current != null)
            {
                if (Question("هل أنت متأكد من الحذف؟ هذا سيؤدي إلى حذف الوثائق و الملفات المرتبطة") == System.Windows.Forms.DialogResult.Yes)
                {
                    if (gManager.Delete(current))
                    {
                        bindingSource1.Remove(current);
                        FoldersDataGridView.Refresh();
                        Message("تم الحذف بنجاح");
                        Log(OperationsManager.EDIT_GENERAL_FILES);
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

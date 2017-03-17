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
using System.IO;
using System.Threading;
using WSArchiver.GUI.Party;

namespace WSArchiver.GUI
{
    public partial class PartyForm : DialogParent
    {
        PartiesManager manager = new PartiesManager();

        #region Initialization
        public PartyForm()
        {
            InitializeComponent();
            
        }

        private void PartyForm_Load(object sender, EventArgs e)
        {
            Initialize();
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

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            List<PartyVO> all = manager.GetAll();
            //Thread.Sleep(5000);
            e.Result = all;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                List<PartyVO> all = e.Result as List<PartyVO>;
                bindingSource1.Clear();

                if (all.Count > 0)
                {
                    int maxNumber = Int32.MinValue;

                    foreach (PartyVO party in all)
                    {
                        bindingSource1.Add(party);
                        //maxNumber = Math.Max(maxNumber, party.Number);
                    }

                    IdPartynumericUpDown.Value = (int)maxNumber + 1;
                }

                SetEnabled(true);
                toolStripProgressBar1.Style = ProgressBarStyle.Blocks;
                IdPartynumericUpDown.Focus();
                IdPartynumericUpDown.Select(0, IdPartynumericUpDown.Value.ToString().Length);
            }
            catch
            { }
        }
        #endregion

        private void InsertPartybutton1_Click(object sender, EventArgs e)
        {
            PartyVO party = new PartyVO();
            party.Name = partyNameTB.Text.Trim();
            //party.Number = (int)IdPartynumericUpDown.Value;

            if (!manager.IsPartyNew(party))
            {
                Error("اسم الجهة أو رقمها موجود سابقاً", "تعذر إضافة جهة جديدة");
                return;
            }
            if (partyNameTB.Text.Trim() == "")
            {
                Error("اسم الجهة لا يمكن أن يكون فارغاً");
                return;
            }
            if (manager.Insert(party) < 0)
            {
                Error("حدث خطأ أثناء عملية إضافة الجهة", "فشل عملية الإضافة");
            }
            else
            {
                bindingSource1.Add(party);
                Message("تم إضافة الجهة بنجاح", "عملية ناجحة");
                IdPartynumericUpDown.Value++;
                partyNameTB.Text = "";
                partyNameTB.Focus();
            }

        }


        private void RemovPartybutton3_Click(object sender, EventArgs e)
        {
            PartyVO current = bindingSource1.Current as PartyVO;
            if (current != null)
            {
                if (Question("هل أنت متأكد من الحذف؟ هذا سيؤدي إلى حذف الملفات العامة و الوثائق و الملفات المرتبطة") == System.Windows.Forms.DialogResult.Yes)
                {
                    if (manager.Delete(current))
                    {
                        bindingSource1.Remove(current);
                        PartyDataGridView.Refresh();
                        Message("تم الحذف بنجاح");
                    }
                    else
                    {
                        Error();
                    }
                }
            }
        }

        private void UpdatePartybutton2_Click(object sender, EventArgs e)
        {
            PartyVO current = bindingSource1.Current as PartyVO;
            if (current != null)
            {
                PartyEditForm form = new PartyEditForm(current, manager);

                if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    PartyDataGridView.Refresh();
                }
            }
        }

        private void exitB_Click(object sender, EventArgs e)
        {
            Close();
        }









    }
}

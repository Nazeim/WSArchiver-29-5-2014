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

namespace WSArchiver.GUI.Folder
{
    public partial class FolderEditForm : DialogParent
    {
        PartiesManager manager = new PartiesManager();
        FoldersManager gManager = new FoldersManager();
        FolderVO file;
        List<PartyVO> list;

        bool isAutomatic = false;

        public FolderEditForm()
        {
            InitializeComponent();
            statusStrip1.Items.Clear();
            statusStrip1.Items.Add(currentUserStripLabel);
        }

        private void Initialize()
        {

            foreach (Control c in Controls)
            {
                if (c is NumericUpDown)
                    ((NumericUpDown)c).Maximum = Int32.MaxValue;
            }


            list = manager.GetAll();

            foreach (PartyVO v in list)
                FoldercomboBox.Items.Add(v);

            //if (list.Count > 0)
            //    FoldercomboBox.SelectedIndex = list.IndexOf(file.Party);
        }


        public FolderEditForm(FolderVO f, FoldersManager m)
            : this()
        {
            file = f;
            gManager = m;
            isAutomatic = true;
            //IdFoldersNumericUpDown.Value = file.Number;
            FolderTB.Text = file.Name;

            isAutomatic = false;
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

        private void button1_Click(object sender, EventArgs e)
        {
            FolderVO temp = new FolderVO();
            temp.Id = file.Id;
            temp.Name = FolderTB.Text.Trim();

            if (FolderTB.Text.Trim() == "")
            {
                Error("اسم الملف لا يمكن أن يكون فارغاً");
                return;
            }

            if (!gManager.IsFolderNew(temp))
            {
                Error("هناك ملف آخر له نفس الاسم أو الرقم", "فشل تعديل الملف");
                return;
            }

            else
            {
                if (gManager.Update(temp))
                {
                    file.Name = temp.Name;
                    Message("تم تعديل الملف بنجاح");
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                }
                else
                {
                    Error();
                }
            }
        }

        private void FolderEditForm_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        private void exitB_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

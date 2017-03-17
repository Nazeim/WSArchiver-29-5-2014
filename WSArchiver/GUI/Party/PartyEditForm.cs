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

namespace WSArchiver.GUI.Party
{
    public partial class PartyEditForm : DialogParent
    {
        PartyVO party;
        PartiesManager manager;
        bool isAutomatic = false;

        public PartyEditForm()
        {
            InitializeComponent();
            statusStrip1.Items.Clear();
            statusStrip1.Items.Add(currentUserStripLabel);
        }

        public PartyEditForm(PartyVO p, PartiesManager m)
            : this()
        {
            party = p;
            manager = m;

            isAutomatic = true;
            //IdPartynumericUpDown.Value = party.Number;
            partyNameTB.Text = party.Name;
            isAutomatic = false;
        }

        private void IdPartynumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (!isAutomatic)
                button1.Enabled = true;
        }

        private void exitB_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PartyEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != System.Windows.Forms.DialogResult.OK)
                DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PartyVO partyTemp = new PartyVO();
            partyTemp.Id = party.Id;
            partyTemp.Name = partyNameTB.Text.Trim();
            //partyTemp.Number = (int)IdPartynumericUpDown.Value;

            if (partyNameTB.Text.Trim() == "")
            {
                Error("اسم الجهة لا يمكن أن يكون فارغاً");
            }
            else
            {
                if (!manager.IsPartyNew(partyTemp))
                {
                    Error("هناك جهة أخرى لها نفس الاسم أو الرقم", "فشل تعديل الجهة");
                }
                else
                {
                    if (manager.Update(partyTemp))
                    {
                        party.Name = partyTemp.Name;
                        //party.Number = partyTemp.Number;
                        Message("تم تعديل الجهة بنجاح");
                        DialogResult = System.Windows.Forms.DialogResult.OK;
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

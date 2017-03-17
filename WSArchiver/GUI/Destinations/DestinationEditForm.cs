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

namespace WSArchiver.GUI.Destinations
{
    public partial class DestinationEditForm : DialogParent
    {
        DestinationVO dest;
        DestinationsManager manager = new DestinationsManager();
        //List<DestinationVO> list;

        bool isAutomatic = false;

        public DestinationEditForm()
        {
            InitializeComponent();
            statusStrip1.Items.Clear();
            statusStrip1.Items.Add(currentUserStripLabel);
        }
        public DestinationEditForm(DestinationVO des, DestinationsManager m)
            : this()
        {
            dest = des;
            manager = m;
            isAutomatic = true;
            DestTB.Text = des.Name;
            isAutomatic = false;
        }

        private void exitB_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DestinationVO temp = new DestinationVO();
            temp.Id = dest.Id;
            temp.Name = DestTB.Text.Trim();
     
            if (DestTB.Text.Trim() == "")
            {
                Error("اسم الوجهة لا يمكن أن يكون فارغاً");
                return;
            }
            if (!manager.IsDestinationNew(temp))
            {
                Error("هناك وجهة أخرى لها نفس الاسم", "فشل تعديل الوجهة");
                return;
            }

            else
            {
                if (manager.Update(temp))
                {
                    dest.Name = temp.Name;
                    Message("تم تعديل الوجهة بنجاح");
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

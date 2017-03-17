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

namespace WSArchiver.GUI
{
    public partial class CategoryEditForm : DialogParent
    {

        CategoryVO category;
        CategoriesManager manager;
        bool isAutomatic = false;

        public CategoryEditForm()
        {
            InitializeComponent();

            statusStrip1.Items.Clear();
            statusStrip1.Items.Add(currentUserStripLabel);
        }

        public CategoryEditForm(CategoryVO p, CategoriesManager m)
            : this()
        {
            category = p;
            manager = m;

            isAutomatic = true;
            NameB.Text = category.Name;
            isAutomatic = false;
        }


        private void exitB_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void CategoryEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != System.Windows.Forms.DialogResult.OK)
                DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CategoryVO temp = new CategoryVO();
            temp.Id = category.Id;
            temp.Name = NameB.Text.Trim();

            if (NameB.Text.Trim() == "")
                Message("اسم التصنيف لايمكن أن يكون فارغاً");
            else
                if (!manager.IsCategoryNew(temp))
                {
                    Error("هناك تصنيف آخر له نفس الاسم", "فشل تعديل التصنيف");
                    return;
                }
                else
                {
                    if (manager.Update(temp))
                    {
                        category.Name = temp.Name;
                        Message("تم تعديل التصنيف بنجاح");
                        DialogResult = System.Windows.Forms.DialogResult.OK;
                    }
                    else
                    {
                        Error();
                    }
                }
        }

        private void exitB_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void NameB_TextChanged(object sender, EventArgs e)
        {
            if (!isAutomatic)
                button1.Enabled = true;
        }
    }

}

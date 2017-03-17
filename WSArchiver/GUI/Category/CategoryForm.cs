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
    public partial class CategoryForm : DialogParent
    {
        CategoriesManager manager = new CategoriesManager();

        public CategoryForm()
        {
            InitializeComponent();
            Initialize();
        }


        private void Initialize()
        {
            List<CategoryVO> list = new List<CategoryVO>();
            list = manager.GetAll();

            foreach (CategoryVO c in list)
            {
                bindingSource1.Add(c);
            }

        }
        private void UpdateB_Click(object sender, EventArgs e)
        {
            CategoryVO current = bindingSource1.Current as CategoryVO;
            if (current != null)
            {
                CategoryEditForm form = new CategoryEditForm(current, manager);

                if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    CategoryDataGridView.Refresh();
                    Log(OperationsManager.EDIT_CATEGORIES);
                }
            }
        }

        private void InsertB_Click(object sender, EventArgs e)
        {
            CategoryVO category = new CategoryVO();
            category.Name = NameTB.Text.Trim();

            if (NameTB.Text.Trim() == "")
            {
                Error("اسم التصنيف لايمكن أن يكون فارغاً");
                return;
            }
            if (!manager.IsCategoryNew(category))
            {
                Error("اسم التصنيف موجود سابقاً", "تعذر إضافة تصنيف جديد");
                return;
            }


            if (manager.Insert(category) < 0)
            {
                Error("حدث خطأ أثناء عملية إضافة التصنيف", "فشل عملية الإضافة");
            }
            else
            {
                bindingSource1.Add(category);
                CategoryDataGridView.Refresh();
                Message("تم إضافة التصنيف بنجاح", "عملية ناجحة");
                NameTB.Text = "";
                NameTB.Focus();
                Log(OperationsManager.EDIT_CATEGORIES);
            }
        }

        private void RemovB_Click(object sender, EventArgs e)
        {
            CategoryVO current = bindingSource1.Current as CategoryVO;
            if (current != null)
            {
                if (Question("هل أنت متأكد من الحذف؟") == System.Windows.Forms.DialogResult.Yes)
                {
                    if (manager.Delete(current))
                    {
                        bindingSource1.Remove(current);
                        CategoryDataGridView.Refresh();
                        Message("تم الحذف بنجاح");
                        Log(OperationsManager.EDIT_CATEGORIES);
                    }
                    else
                    {
                        Error();
                    }
                }
            }
        }

        private void exitB_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

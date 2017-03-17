using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using Library.Common;

namespace WSArchiver.GUI.UserControls
{
    public partial class MultipleItemsSearchControl : WSArchiver.GUI.UserControls.SearchControl
    {

        public MultipleItemsSearchControl()
        {
            InitializeComponent();
        }

        public MultipleItemsSearchControl(Library.Common.Search.Filter.FilterEnum filter)
            : base(filter)
        {
            InitializeComponent();
        }

        public void SetItems(IList list)
        {
            comboBox1.Items.Clear();
            listBox1.Items.Clear();

            foreach (object item in list)
            {
                comboBox1.Items.Add(item);
            }

            if (list.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
                addB.Enabled = true;
            }
        }

        public List<CategoryVO> GetSelectedItems()
        {
            List<CategoryVO> selectedItems = new List<CategoryVO>();

            foreach (CategoryVO item in listBox1.Items)
                selectedItems.Add(item);

            return selectedItems;
        }

        public void SelectItems(List<CategoryVO> categories)
        {
            List<int> toSelect = new List<int>();
            List<CategoryVO> all = new List<CategoryVO>();

            foreach (CategoryVO cat in categories)
                toSelect.Add(cat.Id);

            foreach (CategoryVO cat in comboBox1.Items)
            {
                all.Add(cat);
            }

            foreach (CategoryVO cat in all)
            {
                if (toSelect.Contains(cat.Id))
                    SelectItem(cat);
            }
        }

        protected override object GenerateCriteria()
        {
            return GetSelectedItems();
        }

        private void addB_Click(object sender, EventArgs e)
        {
            object current = comboBox1.SelectedItem;
            SelectItem(current as CategoryVO);
        }

        private void SelectItem(CategoryVO current)
        {
            if (current != null)
            {
                comboBox1.Items.Remove(current);

                if (comboBox1.Items.Count > 0)
                    comboBox1.SelectedIndex = 0;
                else
                    addB.Enabled = false;

                listBox1.Items.Add(current);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
                deleteB.Enabled = true;
            else
                deleteB.Enabled = false;
        }

        private void deleteB_Click(object sender, EventArgs e)
        {
            object current = listBox1.SelectedItem;

            if (current != null)
            {
                listBox1.Items.Remove(current);
                listBox1.SelectedIndex = -1;

                comboBox1.Items.Add(current);

                if (comboBox1.Items.Count == 1)
                {
                    comboBox1.SelectedIndex = 0;
                    addB.Enabled = true;
                }
            }
        }


    }
}

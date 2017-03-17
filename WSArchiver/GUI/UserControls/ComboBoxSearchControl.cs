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
    public partial class ComboBoxSearchControl : WSArchiver.GUI.UserControls.SearchControl
    {
        public ComboBoxSearchControl()
        {
            InitializeComponent();
        }

        public ComboBoxSearchControl(Library.Common.Search.Filter.FilterEnum filter)
            : base(filter)
        {
            InitializeComponent();
        }
        public object GetSelectedItem()
        {
            return comboBox1.SelectedItem;
        }

        public void SetItems(IList list)
        {
            comboBox1.Items.Clear();

            foreach (object item in list)
                comboBox1.Items.Add(item);

            if (list.Count > 0)
                comboBox1.SelectedIndex = 0;
        }

        protected override object GenerateCriteria()
        {
            return ((VO)comboBox1.SelectedItem).Id;
        }

        public VO GetSelection()
        {
            return (VO)comboBox1.SelectedItem;
        }
    }
}

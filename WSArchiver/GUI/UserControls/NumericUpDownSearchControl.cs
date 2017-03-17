using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WSArchiver.GUI.UserControls
{
    public partial class NumericUpDownSearchControl : SearchControl
    {
        public NumericUpDownSearchControl()
        {
            InitializeComponent();
            numericUpDown1.Maximum = Int32.MaxValue;
        }

        public NumericUpDownSearchControl(Library.Common.Search.Filter.FilterEnum filter)
            :base(filter)
        {
            InitializeComponent();
            numericUpDown1.Maximum = Int32.MaxValue;
        }

        protected override object GenerateCriteria()
        {
            return (int)numericUpDown1.Value;
        }

        public int Value
        {
            get
            {
                return (int)numericUpDown1.Value;
            }

            set
            {
                numericUpDown1.Value = value;
            }
        }
    }
}

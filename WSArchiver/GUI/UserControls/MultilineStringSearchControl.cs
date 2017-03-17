using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WSArchiver.GUI.UserControls
{
    public partial class MultilineStringSearchControl : SearchControl
    {
        public MultilineStringSearchControl()
        {
            InitializeComponent();
        }

        public MultilineStringSearchControl(Library.Common.Search.Filter.FilterEnum filter)
            : base(filter)
        {
            InitializeComponent();
        }
        protected override object GenerateCriteria()
        {
            return textBox1.Text;
        }
    }
}

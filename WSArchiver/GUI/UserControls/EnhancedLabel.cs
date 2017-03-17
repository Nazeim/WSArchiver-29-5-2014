using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library.GUI.UserControls
{
    public partial class EnhancedLabel : UserControl
    {
        public string LabelText
        {
            get
            {
                return label1.Text;
            }

            set
            {
                label1.Text = value;
            }
        }

        public EnhancedLabel()
        {
            InitializeComponent();
        }
    }
}

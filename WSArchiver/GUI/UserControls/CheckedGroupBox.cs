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
    public partial class CheckedGroupBox : UserControl
    {

        public SearchControl SearchControl
        {
            get
            {
                foreach (Control c in groupBox1.Controls)
                {
                    if (c is SearchControl)
                        return c as SearchControl;
                }

                return null;
            }
        }
        public CheckedGroupBox()
        {
            InitializeComponent();
        }

        public bool GroupChecked
        {
            get
            {
                return checkBox1.Checked;
            }
        }

        public string GroupText
        {
            get
            {
                return checkBox1.Text;
            }

            set
            {
                checkBox1.Text = value;
            }
        }

        private void SetEnabled(bool isEnabled)
        {
            foreach (Control c in groupBox1.Controls)
                if (!(c is CheckBox))
                    c.Enabled = isEnabled;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            SetEnabled(checkBox1.Checked);
        }

        private void CheckedGroupBox_Load(object sender, EventArgs e)
        {
            SetEnabled(false);
        }
    }
}

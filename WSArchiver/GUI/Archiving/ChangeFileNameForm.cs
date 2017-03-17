using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WSArchiver.GUI.Archiving
{
    public partial class ChangeFileNameForm : WSArchiver.GUI.DialogParent
    {
        public ChangeFileNameForm()
        {
            InitializeComponent();
            statusStrip1.Items.Clear();
            statusStrip1.Items.Add(currentUserStripLabel);
        }

        public ChangeFileNameForm(string text)
            : this()
        {
            textBox1.Text = text;
        }

        public string NewName
        {
            get
            {
                return textBox1.Text;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void exitB_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void ChangeFileNameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != System.Windows.Forms.DialogResult.OK)
                DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}

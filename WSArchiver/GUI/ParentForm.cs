using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Library.BLL;

namespace WSArchiver.GUI
{
    public partial class ParentForm : Form
    {
        protected LogManager log;

        public ParentForm()
        {
            InitializeComponent();
        }

        protected void SetEnabled(bool enabled)
        {
            foreach (Control c in Controls)
            {
                if (!(c is Label) && !(c is ToolStrip) && !(c is Panel))
                {
                    if (enabled)
                    {
                        if (((bool)c.Tag) == true)
                            c.Enabled = true;
                    }
                    else
                    {
                        //Remember the previous state
                        c.Tag = c.Enabled;
                        c.Enabled = false;
                    }
                    
                }
            }
        }

        protected void Error(string message, string caption)
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        protected void Error(string message)
        {
            Error(message, "فشل العملية");
        }

        protected void Error()
        {
            Error("حدث خطأ أثناء تنفيذ العملية");
        }

        protected void Message(string message, string caption)
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        protected void Message(string message)
        {
            Message(message, "نجاح العملية");
        }

        protected DialogResult Question(string message, string caption)
        {
            return MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        protected DialogResult Question(string message)
        {
            return Question(message, "تأكيد العملية");
        }

        protected void SetStatus(string status)
        {
            statusStripLabel.Text = status + " -";
        }

        protected void SetResultsCount(int count)
        {
            rowsCountStripLabel.Text = string.Format("{0}: {1} -", "عدد الأسطر", count);
        }

        private void ParentForm_Load(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is NumericUpDown)
                    ((NumericUpDown)c).Maximum = Int32.MaxValue;
            }

            if (Library.ConfigurationManager.currUser != null)
            {
                currentUserStripLabel.Text = string.Format("{0}: {1}", "المستخدم الحالي", Library.ConfigurationManager.currUser.Username);
            }

            ValidateUserPermissions();
        }

        protected virtual void ValidateUserPermissions()
        {
 
        }

        protected virtual void ParentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (Owner != null)
                {
                    Owner.Show();
                }
            }
            catch
            { }
        }

        protected void Log(string operation, string description)
        {
            if(log == null)
                log = new LogManager();

            log.Write(operation, description);
        }

        protected void Log(string operation)
        {
            if (log == null)
                log = new LogManager();

            log.Write(operation);
        }
    }
}

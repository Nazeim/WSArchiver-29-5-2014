using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Library.BLL;

namespace WSArchiver.GUI.Archiving
{
    public partial class ScanningSettingsForm : DialogParent
    {
        ScannerManager manager;

        public ScanningSettingsForm()
        {
            InitializeComponent();
            statusStrip1.Items.Clear();
            statusStrip1.Items.Add(currentUserStripLabel);
        }

        public ScanningSettingsForm(ScannerManager manager)
            : this()
        {
            this.manager = manager;
        }

        private void ScanningSettingsForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (!manager.CanScan())
                    throw new Exception();

                List<string> allDevices = manager.GetDevices();

                if (allDevices.Count > 0)
                {
                    int defaultIndex = Library.ConfigurationManager.ScanningDeviceIndex;

                    foreach (string s in allDevices)
                        comboBox1.Items.Add(s);

                    if (defaultIndex < allDevices.Count)
                        comboBox1.SelectedIndex = defaultIndex;
                    else
                        comboBox1.SelectedIndex = 0;
                }
            }
            catch
            {
                Error("لا توجد ماسحات متصلة");
                Close();
            }
        }

        private void exitB_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Library.ConfigurationManager.ScanningDeviceIndex = comboBox1.SelectedIndex;
                Library.ConfigurationManager.ScanningResolution = float.Parse(comboBox2.SelectedItem.ToString());
                Close();
            }
            catch
            {
                Error();
                Close();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();

            if (comboBox1.SelectedIndex >= 0)
            {
                try
                {           
                    List<float> allResolutions = manager.GetResolutions(comboBox1.SelectedIndex);

                    if (allResolutions.Count > 0)
                    {
                        float defRes = Library.ConfigurationManager.ScanningResolution;
                        int index = -1;

                        for(int i = 0; i < allResolutions.Count; i++)
                        {
                            if (allResolutions[i] == defRes)
                                index = i;

                            comboBox2.Items.Add(string.Format("{0:N0}", allResolutions[i]));
                        }

                        if (index >= 0)
                            comboBox2.SelectedIndex = index;
                        else
                            comboBox2.SelectedIndex = 0;
                    }
                }
                catch
                {
                    Error("لا توجد ماسحات مدعومة");
                    Close();
                }
            }
        }


    }
}

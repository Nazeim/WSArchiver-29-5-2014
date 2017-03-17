using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WSArchiver.GUI;
using WSArchiver.GUI.User;
using WSArchiver.GUI.Folder;
using WSArchiver.GUI.Destinations;
using SecureApp;

namespace Library
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SecureApp.Form1 form = new SecureApp.Form1();

            if (form.CanEnter())
            {
                Application.Run(new WSArchiver.GUI.LogInForm());
            }
        }
    }
}

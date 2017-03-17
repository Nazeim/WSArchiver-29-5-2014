using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MigraDoc.Rendering.Forms;

namespace WSArchiver.GUI.UserControls
{
    public partial class NoWheelDocumentPreview : DocumentPreview
    {
        public NoWheelDocumentPreview()
        {
            InitializeComponent();
        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Library.Common;

namespace WSArchiver.GUI.UserControls
{
    public partial class DocumentDetailsListItem : UserControl, IMultiLingualControl
    {
        class LabelsSet
        {
            public string title;
            public string from;
            public string to;
            public string creationDate;
        }

        private Color highlightColor = DefaultBackColor;
        private Color baseColor;
        private DocumentVO document;
        private Language currentLanguage;
        private Dictionary<Language, LabelsSet> labelLanguages = new Dictionary<Language, LabelsSet>();

        public Color HighlightColor
        {
            get { return highlightColor; }
            set { highlightColor = value; }
        }

        public DocumentVO Document
        {
            get { return document; }
            set
            {
                document = value;

                if (value != null)
                    FillDocumentInfo(value);
            }
        }

        public Language ControlLanguage
        {
            get
            {
                return currentLanguage;
            }
            set
            {
                currentLanguage = value;
                ApplyLanguage(value);
            }
        }

        public DocumentDetailsListItem()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            labelLanguages.Add(
                Language.ARABIC, new LabelsSet()
                {
                    creationDate = "تاريخ الإنشاء",
                    from = "من",
                    to = "إلى",
                    title = "العنوان"
                });

            labelLanguages.Add(
                Language.ENGLISH, new LabelsSet()
                {
                    creationDate = "Creation Date",
                    from = "From",
                    to = "To",
                    title = "Title"
                });
        }

        private void ApplyLanguage(Language language)
        {
            LabelsSet labelSet = labelLanguages[language];
            label1.Text = labelSet.title + ":";
            label2.Text = labelSet.from + ":";
            label3.Text = labelSet.to + ":";
            label4.Text = labelSet.creationDate + ":";

            if (language == Language.ARABIC)
                RightToLeft = RightToLeft.Yes;
            else
                RightToLeft = RightToLeft.No;
        }

        private void FillDocumentInfo(DocumentVO doc)
        {
            documentTitleL.Text = doc.Title;
            fromL.Text = doc.Party.Name;
            toLabel.Text = doc.Destination.Name;
            creationDateL.Text = doc.CreationDate.ToString();
        }

        private void DocumentDetailsListItem_MouseEnter(object sender, EventArgs e)
        {
            baseColor = BackColor;
            BackColor = highlightColor;
        }

        private void DocumentDetailsListItem_MouseLeave(object sender, EventArgs e)
        {
            BackColor = baseColor;
        }
    }
}

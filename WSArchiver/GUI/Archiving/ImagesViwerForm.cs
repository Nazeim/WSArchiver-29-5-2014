using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Shapes;
using MigraDoc.DocumentObjectModel.IO;
using Library.BLL;
using WSArchiver.GUI.UserControls;
using MigraDoc.Rendering.Forms;
using MigraDoc.Rendering;
using System.Diagnostics;
using System.Drawing.Imaging;
using PdfSharp.Drawing;
using System.IO;
using System.Drawing.Printing;
using MigraDoc.Rendering.Printing;

namespace WSArchiver.GUI.Archiving
{
    public partial class ImagesViwerForm : ParentForm
    {
        private NoWheelDocumentPreview preview;
        PrinterSettings printerSettings = new PrinterSettings();
        private Document document;
        private Section currentSection;
        private Paragraph currentParagraph;
        private const double A4_RATIO = 297.0 / 210.0;
        private const string A4_WIDTH = "19cm";
        private const string A4_HEIGHT = "27.7cm";
        private const string MARGIN = "1cm";
        private const int DPI = 150;
        private Dictionary<int, int> zoomValues = new Dictionary<int, int>();
        private int currentZoom;

        public ImagesViwerForm()
        {
            InitializeComponent();
        }

        public ImagesViwerForm(List<string> images)
            : this()
        {
            InitializeDocument(images);
            InitializeZoomValues();
        }

        #region Init
        private void InitializeZoomValues()
        {
            zoomValues.Add(0, 10);
            zoomValues.Add(1, 25);
            zoomValues.Add(2, 50);
            zoomValues.Add(3, 75);
            zoomValues.Add(4, 100);
            zoomValues.Add(5, 150);
            zoomValues.Add(6, 200);
            zoomValues.Add(7, 400);
            zoomValues.Add(8, 600);
            zoomValues.Add(9, 800);
        }
        private void InitializeDocument(List<string> images)
        {
            SetEnabled(false);
            SetStatus("جاري تهيئة العرض");
            toolStripProgressBar1.Style = ProgressBarStyle.Marquee;
            initializerBGW.RunWorkerAsync(images);
        }

        private void AddImageFileToDocument(string filePath)
        {
            currentSection = document.AddSection();
            currentSection.PageSetup.PageFormat = PageFormat.A4;
            currentSection.PageSetup.TopMargin = MARGIN;
            currentSection.PageSetup.BottomMargin = MARGIN;
            currentSection.PageSetup.LeftMargin = MARGIN;
            currentSection.PageSetup.RightMargin = MARGIN;
            currentParagraph = currentSection.AddParagraph();
            currentParagraph.Format.Alignment = ParagraphAlignment.Center;
            MigraDoc.DocumentObjectModel.Shapes.Image image = currentParagraph.AddImage(filePath);
            ChooseDimensions(filePath, image);
        }
        private void initializerBGW_DoWork(object sender, DoWorkEventArgs e)
        {
            document = new Document();
            List<string> images = (List<string>)e.Argument;

            for (int i = 0; i < images.Count; i++)
            {
                AddImageFileToDocument(images[i]);
            }
        }

        private void initializerBGW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                SetEnabled(true);
                SetStatus("");
                toolStripProgressBar1.Style = ProgressBarStyle.Blocks;
                preview.Ddl = DdlWriter.WriteToString(document);
                SetZoomIndexByActualZoom();
            }
            catch
            { }
        }
        private void ChooseDimensions(string filePath, MigraDoc.DocumentObjectModel.Shapes.Image image)
        {
            System.Drawing.Image currentImage = System.Drawing.Image.FromFile(filePath);
            int width = currentImage.Width;
            int height = currentImage.Height;
            currentImage.Dispose();
            double ratio;
            image.LockAspectRatio = true;

            if (width > height)
            {
                currentSection.PageSetup.Orientation = MigraDoc.DocumentObjectModel.Orientation.Landscape;
                ratio = (double)width / height;

                if (ratio >= A4_RATIO)
                {
                    image.Width = A4_HEIGHT;

                }
                else
                {
                    image.Height = A4_WIDTH;
                }
            }
            else
            {
                currentSection.PageSetup.Orientation = MigraDoc.DocumentObjectModel.Orientation.Portrait;
                ratio = (double)height / width;

                if (ratio >= A4_RATIO)
                {
                    image.Height = A4_HEIGHT;

                }
                else
                {
                    image.Width = A4_WIDTH;
                }
            }
        }
        #endregion  

        #region Next Prev
        private void GotoPage(int pageNumber)
        {
            preview.Page = pageNumber;
        }

        private void PrevPage()
        {
            try
            {
                preview.PrevPage();
            }
            catch
            { }
        }

        private void NextPage()
        {
            try
            {
                preview.NextPage();
            }
            catch
            { }
        }


        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int allPages = preview.PageCount;
            int current = preview.Page;

            nextToolStripMenuItem.Enabled = (current < allPages);
            previousToolStripMenuItem.Enabled = (current > 1);
        }

        private void nextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NextPage();
        }

        private void previousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrevPage();
        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            int delta = e.Delta;
            if (delta > 0)
                PrevPage();
            else if (delta < 0)
                NextPage();
        }

        #endregion

        #region Zoom
        private void SetZoomIndexByActualZoom()
        {
            int minDifference = Int32.MaxValue;
            int currDifferenece;
            int closestIndex = -1;

            foreach (int index in zoomValues.Keys)
            {
                currDifferenece = Math.Abs(zoomValues[index] - preview.ZoomPercent);

                if (minDifference > currDifferenece)
                {
                    minDifference = currDifferenece;
                    closestIndex = index;
                }
            }

            currentZoom = closestIndex;
        }

        private void ZoomTo(int zoomIndex)
        {
            try
            {
                preview.ZoomPercent = zoomValues[zoomIndex];

                if (currentZoom == zoomValues.Count - 1)
                {
                    zoomInB.Enabled = false;
                    zoomInToolStripMenuItem.Enabled = false;
                }
                else
                {
                    zoomInB.Enabled = true;
                    zoomInToolStripMenuItem.Enabled = true;
                }

                if (currentZoom == 0)
                {
                    zoomOutB.Enabled = false;
                    zoomOutToolStripMenuItem.Enabled = false;
                }
                else
                {
                    zoomOutB.Enabled = true;
                    zoomOutToolStripMenuItem.Enabled = true;
                }

            }
            catch
            {
            }
        }
        private void ZoomIn()
        {
            currentZoom++;
            ZoomTo(currentZoom);
        }

        private void ZoomOut()
        {
            currentZoom--;
            ZoomTo(currentZoom);
        }

        private void FullPage()
        {
            preview.Zoom = Zoom.FullPage;
            SetZoomIndexByActualZoom();
        }

        private void zoomInB_Click(object sender, EventArgs e)
        {
            ZoomIn();
        }

        private void zoomOutB_Click(object sender, EventArgs e)
        {
            ZoomOut();
        }

        private void fullPageB_Click(object sender, EventArgs e)
        {
            FullPage();
        }

        #endregion

        #region Conversion

        private bool SaveAsPDF(string filePath)
        {
            try
            {
                PdfDocumentRenderer printer = new PdfDocumentRenderer();
                printer.DocumentRenderer = preview.Renderer;
                printer.Document = preview.Document;
                printer.RenderDocument();
                preview.Document.BindToRenderer(null);
                printer.Save(filePath);

                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool SaveAsJPEG(string filePath)
        {
            try
            {
                int page = preview.Page;

                // Reuse the renderer from the preview
                DocumentRenderer renderer = preview.Renderer;
                PageInfo info = renderer.FormattedDocument.GetPageInfo(page);

                // Create an image

                int dx, dy;
                if (info.Orientation == PdfSharp.PageOrientation.Portrait)
                {
                    dx = (int)(info.Width.Inch * DPI);
                    dy = (int)(info.Height.Inch * DPI);
                }
                else
                {
                    dx = (int)(info.Height.Inch * DPI);
                    dy = (int)(info.Width.Inch * DPI);
                }

                System.Drawing.Image image = new Bitmap(dx, dy, PixelFormat.Format32bppRgb);

                // Create a Graphics object for the image and scale it for drawing with 72 dpi
                Graphics graphics = Graphics.FromImage(image);
                graphics.Clear(System.Drawing.Color.White);
                float scale = DPI / 72f;
                graphics.ScaleTransform(scale, scale);

                // Create an XGraphics object and render the page
                XGraphics gfx = XGraphics.FromGraphics(graphics, new XSize(info.Width.Point, info.Height.Point));
                renderer.RenderPage(gfx, page);
                gfx.Dispose();
                image.Save(filePath, ImageFormat.Jpeg);

                return true;
            }
            catch
            {
                return false;
            }
        }


        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;
                SetEnabled(false);
                SetStatus("جاري حفظ الملف");
                toolStripProgressBar1.Style = ProgressBarStyle.Marquee;
                saverBGW.RunWorkerAsync(filePath);
            }
        }

        private void saverBGW_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string filePath = (string)e.Argument;
                string extension = Path.GetExtension(filePath).ToUpper();

                if (extension == ".PDF")
                {
                    e.Result = SaveAsPDF(filePath);
                }
                else if (extension == ".JPEG" || extension == ".JPG")
                {
                    e.Result = SaveAsJPEG(filePath);
                }
                else
                {
                    e.Result = false;
                }
            }
            catch
            {
                e.Result = false;
            }
        }

        private void saverBGW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                SetStatus("");
                SetEnabled(true);
                toolStripProgressBar1.Style = ProgressBarStyle.Continuous;

                if ((bool)e.Result)
                {
                    if (MessageBox.Show("تم حفظ الملف بنجاح هل تريد فتحه؟", "عملية ناجحة", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                        Process.Start(saveFileDialog1.FileName);
                }
                else
                    Error("حدث خطأ أثناء عملية حفظ الملف");
            }
            catch
            {

            }
        }

        #endregion

        #region Printing
        private DialogResult SetupPrinting()
        {
            using (PrintDialog dialog = new PrintDialog())
            {
                dialog.PrinterSettings = this.printerSettings;
                dialog.AllowSelection = true;
                dialog.AllowSomePages = true;
                dialog.PrinterSettings.MinimumPage = 1;
                dialog.PrinterSettings.MaximumPage = preview.PageCount;
                dialog.PrinterSettings.FromPage = 1;
                dialog.PrinterSettings.ToPage = preview.PageCount;
                return dialog.ShowDialog();
            }
        }

        private bool Print()
        {
            try
            {
                // Reuse the renderer from the preview
                DocumentRenderer renderer = preview.Renderer;
                if (renderer != null)
                {
                    int pageCount = renderer.FormattedDocument.PageCount;

                    // Creates a PrintDocument that simplyfies printing of MigraDoc documents
                    MigraDocPrintDocument printDocument = new MigraDocPrintDocument();

                    // Attach the current printer settings
                    printDocument.PrinterSettings = this.printerSettings;

                    if (this.printerSettings.PrintRange == PrintRange.Selection)
                        printDocument.SelectedPage = preview.Page;

                    // Attach the current document renderer
                    printDocument.Renderer = renderer;

                    // Print the document
                    printDocument.Print();

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }

        }

        /// <summary>
        /// Prints the current document on a printer.
        /// </summary>
        private void miPrint_Click(object sender, System.EventArgs e)
        {
            if (SetupPrinting() == System.Windows.Forms.DialogResult.OK)
            {
                SetStatus("جاري إرسال أمر الطباعة");
                SetEnabled(false);
                toolStripProgressBar1.Style = ProgressBarStyle.Marquee;
                printerBGW.RunWorkerAsync();
            }
        }

        private void miPreview_Click(object sender, System.EventArgs e)
        {
            using (PrintPreviewDialog dialog = new PrintPreviewDialog())
            {
                dialog.Text = "الاستعراض قبل الطباعة";
                dialog.MinimizeBox = false;
                dialog.MaximizeBox = false;

                // Reuse the renderer from the preview
                DocumentRenderer renderer = preview.Renderer;

                // Creates a PrintDocument that simplifies printing of MigraDoc documents
                MigraDocPrintDocument printDocument = new MigraDocPrintDocument();

                // Attach the current printer settings
                printDocument.PrinterSettings = this.printerSettings;

                // Attach the current document renderer
                printDocument.Renderer = renderer;

                // Attach the current print document
                dialog.Document = printDocument;

                // Show the preview
                dialog.ShowDialog();
            }
        }

        private void printerBGW_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = Print();
        }

        private void printerBGW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                SetEnabled(true);
                SetStatus("");
                toolStripProgressBar1.Style = ProgressBarStyle.Continuous;

                if (!((bool)e.Result))
                {
                    Error("حصل خطأ أثناء إرسال أمر الطباعة");
                }
            }
            catch
            { }
        }

        #endregion

        #region Exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void exitB_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        private void preview_PageChanged(object sender, EventArgs e)
        {
            SetStatus(string.Format("{0}({1}/{2})", "الصفحة", preview.Page, preview.PageCount));
            SetZoomIndexByActualZoom();
        }
    }
}
 
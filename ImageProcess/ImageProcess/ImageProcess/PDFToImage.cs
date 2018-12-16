using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcess
{
    public partial class PDFToImage : Form
    {
        string sourcePDF = "";

        public PDFToImage()
        {
            InitializeComponent();
            btnSave.Enabled = false;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var o = new OpenFileDialog();
            o.Filter = "PDF files (*.pdf) | *.pdf";
            o.Multiselect = false;
            if (o.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                sourcePDF = o.FileName;
                btnSave.Enabled = true;
            }
        }

        private void Pdf2Image(string sourcePDFFile)
        {
            PdfImageCollection objPdfImageCollection;
            using (var pdfReader = new PdfReader(sourcePDFFile))
            {
                var pdfParser = new PdfReaderContentParser(pdfReader);

                for (var iPage = 1; iPage <= pdfReader.NumberOfPages; iPage++)
                {
                    objPdfImageCollection = new PdfImageCollection(sourcePDFFile, iPage);
                    pdfParser.ProcessContent(iPage, objPdfImageCollection);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Pdf2Image(sourcePDF);
            MessageBox.Show("Images exported successfully!", "PDF To Image");
        }

        private void btnOpenOutputFolder_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(Constents.ROOTPATH + "\\" + Constents.PDF_TO_IMAGES_FOLDER);
            var path = Constents.ROOTPATH + "\\" + Constents.PDF_TO_IMAGES_FOLDER;
            System.Diagnostics.Process.Start(path);
        }
    }
}

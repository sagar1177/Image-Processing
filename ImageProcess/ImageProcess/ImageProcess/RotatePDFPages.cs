using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcess
{
    public partial class RotatePDFPages : Form
    {
        OpenFileDialog o = new OpenFileDialog();
        public RotatePDFPages()
        {
            InitializeComponent();
            btnSave.Enabled = false;
            txtOutputPath.Text = Constents.ROOTPATH + "\\" + Constents.PDFROTATE_FOLDER;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            o.Filter = "PDF files (*.pdf) | *.pdf";
            o.Multiselect = false;
            if (o.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                btnSave.Enabled = true;
            }
        }

        private void SaveImages(string InputPDFFile, int specificPageNumber, int degree)
        {
            Directory.CreateDirectory(Constents.ROOTPATH + "\\" + Constents.PDFROTATE_FOLDER);
            var filename = Path.GetFileName(InputPDFFile);
            string outfile = Constents.ROOTPATH + "\\" + Constents.PDFROTATE_FOLDER + filename;
            txtOutputPath.Text = outfile;

            using (FileStream outStream = new FileStream(outfile, FileMode.Create))
            {
                iTextSharp.text.pdf.PdfReader reader = new iTextSharp.text.pdf.PdfReader(InputPDFFile);
                iTextSharp.text.pdf.PdfStamper stamper = new iTextSharp.text.pdf.PdfStamper(reader, outStream);
                int noofPages = reader.NumberOfPages;

                if (specificPageNumber > 0) //Rotae Specific Page
                {
                    iTextSharp.text.pdf.PdfDictionary pageDict = reader.GetPageN(specificPageNumber);
                    int desiredRot = degree; // 90 degrees clockwise from what it is now
                    iTextSharp.text.pdf.PdfNumber rotation = pageDict.GetAsNumber(iTextSharp.text.pdf.PdfName.ROTATE);

                    if (rotation != null)
                    {
                        desiredRot += rotation.IntValue;
                        desiredRot %= 360; // must be 0, 90, 180, or 270
                    }
                    pageDict.Put(iTextSharp.text.pdf.PdfName.ROTATE, new iTextSharp.text.pdf.PdfNumber(desiredRot));
                }
                else // Rotate All Pages
                {
                    for (int i = 1; i <= noofPages; i++)
                    {
                        iTextSharp.text.pdf.PdfDictionary pageDict = reader.GetPageN(i);
                        int desiredRot = degree; // 90 degrees clockwise from what it is now
                        iTextSharp.text.pdf.PdfNumber rotation = pageDict.GetAsNumber(iTextSharp.text.pdf.PdfName.ROTATE);

                        if (rotation != null)
                        {
                            desiredRot += rotation.IntValue;
                            desiredRot %= 360; // must be 0, 90, 180, or 270
                        }
                        pageDict.Put(iTextSharp.text.pdf.PdfName.ROTATE, new iTextSharp.text.pdf.PdfNumber(desiredRot));
                    }
                }

                stamper.Close();
            }
        }

        private int GetRotateDegree()
        {
            if (rbtn90.Checked)
                return 90;
            if (rbtn180.Checked)
                return 180;
            if (rbtn270.Checked)
                return 270;
            else
                return 360;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int degree = GetRotateDegree();
            SaveImages(o.FileName, -1, degree);
            MessageBox.Show("PDF Rotated successfully!", "PDF Rotate");
        }

        private void btnOpenOutputFolder_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(Constents.ROOTPATH + "\\" + Constents.PDFROTATE_FOLDER);
            var path = Constents.ROOTPATH + "\\" + Constents.PDFROTATE_FOLDER;
            System.Diagnostics.Process.Start(path);
        }
    }
}

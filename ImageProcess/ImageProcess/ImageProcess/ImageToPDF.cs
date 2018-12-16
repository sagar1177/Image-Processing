using iTextSharp.text;
using iTextSharp.text.pdf;
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
    public partial class ImageToPDF : Form
    {
        private List<System.Drawing.Image> lstImage;
        private List<System.Drawing.Image> lstImageProcess;
        public ImageToPDF()
        {
            InitializeComponent();
            panel1.AutoScroll = true;
            lstImage = new List<System.Drawing.Image>();
            lstImageProcess = new List<System.Drawing.Image>();
            btnRotate.Enabled = false;
            btnSave.Enabled = false;
            trkWidth.Enabled = trkHeight.Enabled = false;
            chkEnableResize.Checked = false;
            chkEnableResize.Enabled = false;

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            lstImage.Clear();
            lstImageProcess.Clear();

            var o = new OpenFileDialog();
            o.Filter = "Image files (*.bmp, *.jpg, *.jpeg, *.png) | *.bmp; *.jpg; *.jpeg; *.png";
            o.Multiselect = true;
            if (o.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (var file in o.FileNames)
                {
                    if (Path.GetExtension(file).ToLower() == ".bmp" || Path.GetExtension(file).ToLower() == ".jpg" || Path.GetExtension(file).ToLower() == ".jpeg" || Path.GetExtension(file).ToLower() == ".png")
                    {
                        System.Drawing.Image image = System.Drawing.Image.FromFile(file);
                        lstImage.Add(image);
                        lstImageProcess.Add(image);
                    }
                }
            }

            LoadViewer();

        }

        private void SavePDF()
        {
            Document doc = new Document(PageSize.A4, 10f, 10f, 100f, 0f);
            Directory.CreateDirectory(Constents.ROOTPATH + "\\" + Constents.IMG_TO_PDF_FOLDER);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(Constents.IMG_TO_PDF_FOLDER + Guid.NewGuid().ToString().Replace("-", "") + ".pdf", FileMode.Create));
            doc.Open();

            int x = 20;
            int y = 20;
            int maxHeight = -1;

            foreach (var image in lstImageProcess)
            {
                iTextSharp.text.Image pic = iTextSharp.text.Image.GetInstance(image, System.Drawing.Imaging.ImageFormat.Jpeg);
                //pic.ScaleToFit(140f, 120f);
                pic.Alignment = Element.ALIGN_LEFT;

                //if (pic.Height > pic.Width)
                //{
                //    //Maximum height is 800 pixels.
                //    float percentage = 0.0f;
                //    percentage = 700 / pic.Height;
                //    pic.ScalePercent(percentage * 100);
                //}
                //else
                //{
                //    //Maximum width is 600 pixels.
                //    float percentage = 0.0f;
                //    percentage = 540 / pic.Width;
                //    pic.ScalePercent(percentage * 100);
                //}
                pic.ScaleToFit(doc.PageSize);
                //pic.SetAbsolutePosition(0, 0);

                doc.Add(pic);
                doc.NewPage();
            }

            doc.Close();
        }

        private static ImageCodecInfo GetEncoder(ImageFormat format)
        {

            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();

            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }

        private System.Drawing.Image CompressImage(System.Drawing.Image imgToResize)
        {
            Bitmap bmp1 = new Bitmap(imgToResize);
            ImageCodecInfo jgpEncoder = GetEncoder(ImageFormat.Jpeg);

            // Create an Encoder object based on the GUID
            // for the Quality parameter category.
            System.Drawing.Imaging.Encoder myEncoder =
                System.Drawing.Imaging.Encoder.Quality;

            // Create an EncoderParameters object.
            // An EncoderParameters object has an array of EncoderParameter
            // objects. In this case, there is only one
            // EncoderParameter object in the array.
            EncoderParameters myEncoderParameters = new EncoderParameters(1);

            EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder,
                10L);
            myEncoderParameters.Param[0] = myEncoderParameter;


            //myEncoderParameter = new EncoderParameter(myEncoder, 100L);
            //myEncoderParameters.Param[0] = myEncoderParameter;
            //fileSavePath = Path.Combine(HttpContext.Current.Server.MapPath("~/Download/"), "TestPhotoQuality100.jpeg");
            //bmp1.Save(fileSavePath, jgpEncoder,
            //    myEncoderParameters);

            // Save the bitmap as a JPG file with 75 quality level compression.
            myEncoderParameter = new EncoderParameter(myEncoder, 10L);
            //myEncoderParameters.Param[0] = myEncoderParameter;


            MemoryStream stream = new MemoryStream();
            bmp1.Save(stream, jgpEncoder, myEncoderParameters);

            return (System.Drawing.Image)bmp1;

        }
        private void LoadViewer(bool enabledRotation = false)
        {
            panel1.Controls.Clear();
            int x = 20;
            int y = 20;
            int maxHeight = -1;
            if (lstImage.Count > 0)
            {
                btnRotate.Enabled = true;
                btnSave.Enabled = true;
                chkEnableResize.Enabled = true;
            }

            for (int i = 0; i < lstImage.Count; i++)
            {
                PictureBox pb = new PictureBox();
                pb.BorderStyle = BorderStyle.Fixed3D;
                pb.Location = new Point(x, y);
                if (chkEnableResize.Checked && trkWidth.Value > 0 && trkHeight.Value > 0)
                {
                    lstImageProcess[i] = (System.Drawing.Image)new Bitmap(lstImage[i], trkWidth.Value, trkHeight.Value);
                }
                else
                {
                    lstImageProcess[i] = lstImage[i];
                }

                if (enabledRotation)
                    lstImageProcess[i].RotateFlip(RotateFlipType.Rotate90FlipXY);

                //if (chkImageQualityReduce.Checked)
                //    lstImageProcess[i] = CompressImage(lstImageProcess[i]);

                pb.Image = lstImageProcess[i];
                maxHeight = Math.Max(pb.Image.Height, maxHeight);
                y += maxHeight + 10;
                pb.SizeMode = PictureBoxSizeMode.AutoSize;
                panel1.Controls.Add(pb);
            }
        }
        private void btnRotate_Click(object sender, EventArgs e)
        {
            if (panel1.Controls.Count > 0)
            {
                LoadViewer(true);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SavePDF();
        }

        private void chkEnableResize_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEnableResize.Checked)
            {
                trkHeight.Value = 250;
                trkWidth.Value = 200;
                lblHeightValue.Text = trkHeight.Value.ToString();
                lblWidthValue.Text = trkWidth.Value.ToString();

                trkWidth.Enabled = true;
                trkHeight.Enabled = true;
            }
            else
            {
                trkWidth.Enabled = false;
                trkHeight.Enabled = false;
            }
            LoadViewer();
        }

        private void trkWidth_Scroll(object sender, EventArgs e)
        {
            lblWidthValue.Text = trkWidth.Value.ToString();
            LoadViewer();
        }

        private void trkHeight_Scroll(object sender, EventArgs e)
        {
            lblHeightValue.Text = trkHeight.Value.ToString();
            LoadViewer();
        }

        private void chkImageQualityReduce_CheckedChanged(object sender, EventArgs e)
        {
            LoadViewer();
        }

        private void btnOpenOutputFolder_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(Constents.ROOTPATH + "\\" + Constents.IMG_TO_PDF_FOLDER);
            var path = Constents.ROOTPATH + "\\" + Constents.IMG_TO_PDF_FOLDER;
            System.Diagnostics.Process.Start(path);
        }

        private void ImageToPDF_Load(object sender, EventArgs e)
        {

        }
    }
}

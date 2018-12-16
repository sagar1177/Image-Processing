using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcess
{
    public class PdfImageCollection : IRenderListener
    {
        public string FileName { get; }

        public int CurrentPageNo { get; set; }

        public PdfImageCollection(string fileName, int pageNo)
        {
            this.FileName = fileName;
            this.CurrentPageNo = pageNo;
        }

        public void BeginTextBlock()
        {
        }

        public void EndTextBlock()
        {
        }

        public void RenderImage(ImageRenderInfo renderInfo)
        {
            Directory.CreateDirectory(Constents.ROOTPATH + "\\" + Constents.PDF_TO_IMAGES_FOLDER);
            var imageObject = renderInfo.GetImage();
            var outputImagefile = Constents.ROOTPATH + Constents.PDF_TO_IMAGES_FOLDER + System.IO.Path.GetFileNameWithoutExtension(FileName) + "_" + this.CurrentPageNo.ToString() + ".jpg";
            var data = imageObject.GetImageAsBytes();
            File.WriteAllBytes(outputImagefile, data);
        }

        public void RenderText(TextRenderInfo renderInfo)
        {
        }
    }
}

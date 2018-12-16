using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcess
{
    public partial class frmImageProcessMDI : Form
    {
        private int childFormNumber = 0;

        public frmImageProcessMDI()
        {
            InitializeComponent();
            Constents.ROOTPATH = AppDomain.CurrentDomain.BaseDirectory;
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void imageToPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Constents.IsAuthenticate)
            {
                ImageToPDF form = new ImageToPDF();
                form.StartPosition = FormStartPosition.CenterScreen;
                form.ShowDialog(this);
                form.Dispose();
                form = null;
            }
            else
            {
                AuthenticateUser login = new AuthenticateUser();
                login.StartPosition = FormStartPosition.CenterScreen;
                login.ShowDialog(this);
                login.Dispose();
                login = null;
            }
        }

        private void pDFToImagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Constents.IsAuthenticate)
            {
                PDFToImage form = new PDFToImage();
                form.StartPosition = FormStartPosition.CenterScreen;
                form.ShowDialog(this);
                form.Dispose();
                form = null;
            }
            else
            {
                AuthenticateUser login = new AuthenticateUser();
                login.StartPosition = FormStartPosition.CenterScreen;
                login.ShowDialog(this);
                login.Dispose();
                login = null;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs form = new AboutUs();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog(this);
            form.Dispose();
            form = null;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void rotatePDFPagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Constents.IsAuthenticate)
            {
                RotatePDFPages form = new RotatePDFPages();
                form.StartPosition = FormStartPosition.CenterScreen;
                form.ShowDialog(this);
                form.Dispose();
                form = null;
            }
            else
            {
                AuthenticateUser login = new AuthenticateUser();
                login.StartPosition = FormStartPosition.CenterScreen;
                login.ShowDialog(this);
                login.Dispose();
                login = null;
            }
        }
    }
}

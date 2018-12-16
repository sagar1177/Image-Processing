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
    public partial class AuthenticateUser : Form
    {
        public AuthenticateUser()
        {
            InitializeComponent();            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtMobileNo.Text == Constents.ValidMobile)
            {
                Constents.IsAuthenticate = true;
                MessageBox.Show("Login Successfully!", "Login");
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid User mobile!", "Login");
                txtMobileNo.Text = "";
                return;
            }
        }
    }
}

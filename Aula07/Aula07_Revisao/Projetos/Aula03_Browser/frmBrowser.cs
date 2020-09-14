using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NA018_Browser
{
    public partial class frmBrowser : Form
    {
        public frmBrowser()
        {
            InitializeComponent();
        }

        private void btnChamarSite_Click(object sender, EventArgs e)
        {
            wbSite.Navigate(txtURL.Text.Trim());           
        }
    }
}

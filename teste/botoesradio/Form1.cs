using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace botoesradio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RdoVerde_CheckedChanged(object sender, EventArgs e)
        {
            lblCor.BackColor = Color.Green;
        }

        private void RdoVermelho_CheckedChanged(object sender, EventArgs e)
        {
            lblCor.BackColor = Color.Red;
        }
    }
}

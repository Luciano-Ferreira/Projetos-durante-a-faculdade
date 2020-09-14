using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BotoesRadio
{
    public partial class FrmTesteBotoesRadio : Form
    {
        public FrmTesteBotoesRadio()
        {
            InitializeComponent();
        }

        private void RdoVerde_CheckedChanged(object sender, EventArgs e)
        {
            LblCor.BackColor = Color.Green;
        }

        private void RdoVermelho_CheckedChanged(object sender, EventArgs e)
        {
            LblCor.BackColor = Color.Red;
        }
    }
}

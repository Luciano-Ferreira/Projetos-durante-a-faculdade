using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NA019_NumericUpDownEProgressBar
{
    public partial class frmNumericUpDownEProgressBar : Form
    {
        public frmNumericUpDownEProgressBar()
        {
            InitializeComponent();
        }

        private void nupContador_ValueChanged(object sender, EventArgs e)
        {
            pbBarraDeProgresso.Value = Convert.ToInt32(nupContador.Value);
        }
    }
}

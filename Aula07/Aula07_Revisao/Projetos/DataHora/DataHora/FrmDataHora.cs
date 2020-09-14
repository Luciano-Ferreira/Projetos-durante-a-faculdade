using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataHora
{
    public partial class FrmDataHora : Form
    {
        public FrmDataHora()
        {
            InitializeComponent();
        }

        private void dt01_ValueChanged(object sender, EventArgs e)
        {
            LblDataHora.Text = dt01.Text;
        }

        private void dt02_ValueChanged(object sender, EventArgs e)
        {
            LblDataHora.Text = dt02.Text;
        }

        private void dt03_ValueChanged(object sender, EventArgs e)
        {
            LblDataHora.Text = dt03.Text;
        }

        private void dt04_DateChanged(object sender, DateRangeEventArgs e)
        {
            LblDataHora.Text = dt04.SelectionStart.ToShortDateString();
        }
    }
}

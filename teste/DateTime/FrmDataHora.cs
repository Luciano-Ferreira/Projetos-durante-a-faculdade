using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTime
{
    public partial class frmDataHora : Form
    {
        public frmDataHora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            lblDataHora.Text = dt03.Text;
        }

        private void Dt01_ValueChanged(object sender, EventArgs e)
        {
            lblDataHora.Text = dt01.Text;
        }

        private void Dt02_ValueChanged(object sender, EventArgs e)
        {
            lblDataHora.Text = dt02.Text;
        }

        private void Dt04_DateChanged(object sender, DateRangeEventArgs e)
        {
            lblDataHora.Text = dt04.SelectionStart.ToShortDateString();
        }
    }
}

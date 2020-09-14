using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ListBox
{
    public partial class FrmTesteListBox : Form
    {
        public FrmTesteListBox()
        {
            InitializeComponent();
        }

        private void BtnTesteListBox_Click(object sender, EventArgs e)
        {
            LsbLista.Items.Add(TxtTexto.Text);
        }
    }
}

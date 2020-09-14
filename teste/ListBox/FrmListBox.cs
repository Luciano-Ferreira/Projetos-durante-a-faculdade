using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class FrmListBox : Form
    {
        public FrmListBox()
        {
            InitializeComponent();
        }

        private void LsbLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void FrmListBox_Load(object sender, EventArgs e)
        {

        }

        private void TxtTexto_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnListBox_Click(object sender, EventArgs e)
        {
            lsbLista.Items.Add(txtTexto.Text);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TesteCheckBox
{
    public partial class FrmTesteCheckBox : Form
    {
        public FrmTesteCheckBox()
        {
            InitializeComponent();
        }

        private void ChkOpcaoUm_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkOpcaoUm.Checked) LstListaOpcoes.Items.Add("Opcao Um");
        }

        private void ChkOpcaoDois_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkOpcaoDois.Checked) LstListaOpcoes.Items.Add("Opcao Dois");
        }
    }
}

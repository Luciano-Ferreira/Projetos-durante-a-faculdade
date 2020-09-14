using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class FrmTesteComboBox : Form
    {
        public FrmTesteComboBox()
        {
            InitializeComponent();
        }

        private void CboListaOpcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblOpcaoSelecionada.Text = CboListaOpcoes.Text;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NA009_GroupBox
{
    public partial class frmGroupBox : Form
    {
        public frmGroupBox()
        {
            InitializeComponent();
        }

        #region [METODOS AUXILIARES]
        void TestaQualBotaoDeRadioFoiSelecionado()
        {
            string strBotaoApertado = string.Empty;

            strBotaoApertado = "Aviso : ";

            if (rdoOpcaoUm.Checked == true)
            {
                strBotaoApertado += rdoOpcaoUm.Text + " Foi Selecinada \n";
            }
            else if (rdoOpcaoDois.Checked == true)
            {
                strBotaoApertado += rdoOpcaoDois.Text + " Foi Selecinada \n";
            }

            if (rdoOpcaoTres.Checked == true)
            {
                strBotaoApertado += rdoOpcaoTres.Text + " Foi Selecinada \n";
            }
            else if (rdoOpcaoQuatro.Checked == true)
            {
                strBotaoApertado += rdoOpcaoQuatro.Text + " Foi Selecinada \n";
            }

            MessageBox.Show(strBotaoApertado, "Opções Seleciondas");
        }
        #endregion



        private void rdoOpcaoUm_CheckedChanged(object sender, EventArgs e)
        {
            TestaQualBotaoDeRadioFoiSelecionado();
        }

        private void rdoOpcaoDois_CheckedChanged(object sender, EventArgs e)
        {
            TestaQualBotaoDeRadioFoiSelecionado();
        }

        private void rdoOpcaoTres_CheckedChanged(object sender, EventArgs e)
        {
            TestaQualBotaoDeRadioFoiSelecionado();
        }

        private void rdoOpcaoQUATRO_CheckedChanged(object sender, EventArgs e)
        {
            TestaQualBotaoDeRadioFoiSelecionado();
        }
    }
}

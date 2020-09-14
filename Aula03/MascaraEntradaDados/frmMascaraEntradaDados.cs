using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NA015_MascaraEntradaDados
{
    public partial class frmMascaraEntradaDados : Form
    {
        public frmMascaraEntradaDados()
        {
            InitializeComponent();
        }

        #region [FUNCOES AUXILIARES]
        void AjustaMascaraEntradaDados()
        {
            if (rdoMascaraTelefone.Checked)
            {
                mtxtDadosEntrada.Mask = rdoMascaraTelefone.Text;
            }
            else if (rdoData.Checked)
            {
                mtxtDadosEntrada.Mask = rdoData.Text;
            }
            else if (rdoCPF.Checked)
            {
                mtxtDadosEntrada.Mask = rdoCPF.Text;
            }
        }

        #endregion

        private void frmMascaraEntradaDados_Load(object sender, EventArgs e)
        {
            AjustaMascaraEntradaDados();
        }

        private void rdoMascaraTelefone_CheckedChanged(object sender, EventArgs e)
        {
            AjustaMascaraEntradaDados();
        }

        private void rdoData_CheckedChanged(object sender, EventArgs e)
        {
            AjustaMascaraEntradaDados();
        }

        private void rdoCPF_CheckedChanged(object sender, EventArgs e)
        {
            AjustaMascaraEntradaDados();
        }
    }
}

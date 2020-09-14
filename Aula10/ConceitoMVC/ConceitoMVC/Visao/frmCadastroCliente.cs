using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ConceitoMVC.Modelo;

namespace ConceitoMVC.Visao
{
    public partial class frmCadastroCliente : Form
    {
        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var cli = new ClienteModel();
            string status="";

            lblStatus.Text = "";
            lblStatus.Refresh();

            cli.Idade = int.Parse(txtIdade.Text);
            cli.NomeCliente = txtNomeCliente.Text;
            cli.Sexo = (rdoSexoFeminino.Checked) ? 'F' : 'M';

            dbBaseModel db = new dbBaseModel();

            db.CadastroCliente(cli, ref status);

            lblStatus.Text = status;
        }
    }
}

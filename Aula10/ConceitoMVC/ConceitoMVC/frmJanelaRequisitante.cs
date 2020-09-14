using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ConceitoMVC.Controlador;

namespace ConceitoMVC
{
    public partial class frmJanelaRequisitante : Form
    {
        public frmJanelaRequisitante()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ATENDENDO A REQUISICAO DO USUARIO
            CadastroController controlador = new CadastroController();
            Form cadCliente = controlador.Cliente();
            cadCliente.MdiParent = this;
            cadCliente.Show();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void relatoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clienteOKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ATENDENDO A REQUISICAO DO USUARIO
            ConsultaController controlador = new ConsultaController();
            Form consultaCliente = controlador.Cliente();
            consultaCliente.MdiParent = this;
            consultaCliente.Show();
        }

        private void clienteEmDebitoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void forncedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

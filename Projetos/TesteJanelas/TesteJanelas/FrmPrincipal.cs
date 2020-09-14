using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteJanelas
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroClientes jan = new FrmCadastroClientes();
            jan.MdiParent = this;
            jan.Show();
        }

        private void MotoristasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroMotorista jan = new FrmCadastroMotorista();
            jan.MdiParent = this;
            jan.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}

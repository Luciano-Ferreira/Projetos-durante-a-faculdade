using dll01;
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
    public partial class FrmCadastroClientes : Form
    {
        public FrmCadastroClientes()
        {
            InitializeComponent();
        }

        private void BtnSalvarClientes_Click(object sender, EventArgs e)
        {
            Class1 obj = new Class1();
            txtNome.Text = obj.Nome();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NA006_MessageBoxSimples
{
    public partial class frmMessageBoxSimples : Form
    {
        public frmMessageBoxSimples()
        {
            InitializeComponent();
        }

        private void btnMensageBoxSimples_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Informando ao usuário sobre algum acontecimento", "Título do Aviso");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ConceitoMVC.Visao;

namespace ConceitoMVC.Controlador
{
    public class CadastroController
    {
        public Form Cliente()
        {
            frmCadastroCliente View = new frmCadastroCliente();

            return View;
        }

    }
}

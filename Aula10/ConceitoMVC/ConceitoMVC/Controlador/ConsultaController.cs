﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ConceitoMVC.Visao;

namespace ConceitoMVC.Controlador
{
    public class ConsultaController
    {
        public Form Cliente()
        {
            frmConsultaClientes View = new frmConsultaClientes();

            return View;
        }
    }
}

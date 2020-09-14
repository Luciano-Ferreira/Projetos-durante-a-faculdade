using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNIP.POOII.BS_BlibliotecaPOOII
{
    interface IBSBanco
    {
        bool Salvar();
        bool Atualizar();
        bool Apagar();
        bool Consultar();
    }
}


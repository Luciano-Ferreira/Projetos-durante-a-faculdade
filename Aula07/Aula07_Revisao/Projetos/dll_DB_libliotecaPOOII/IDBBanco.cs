using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNIP.POOII.DB_BlibliotecaPOOII
{
    interface IDBBanco
    {
        bool Salvar();
        bool Atualizar();
        bool Apagar();
        bool Consultar();
    }
}

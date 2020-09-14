using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteConsole
{
    public class VIP : Ingresso
    {
        private double valorAdicional;

        public new double ImprimeValor()
        {
            return valorIngresso + valorAdicional;
        }
    }
}

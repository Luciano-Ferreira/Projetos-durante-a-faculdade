using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteConsole
{
    class CamaroteSuperior : VIP
    {
        private double valorAdicionalCS;


        public double RetornaValorDoIngresso()
        {
            return valorIngresso + valorAdicionalCS;
        }
    }
}

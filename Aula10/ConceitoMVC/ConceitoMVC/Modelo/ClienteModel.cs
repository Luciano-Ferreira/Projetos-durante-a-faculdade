using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConceitoMVC.Modelo
{
    public class ClienteModel
    {
        public int CodCliente { get; set; }
        public string NomeCliente { get; set; }
        public int Idade { get; set; }
        public char Sexo { get; set; }
    }
}

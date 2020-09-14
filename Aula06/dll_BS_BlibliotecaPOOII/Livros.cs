using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using UNIP.POOII.DB_BlibliotecaPOOII;

namespace UNIP.POOII.BS_BlibliotecaPOOII
{
    public class Livros:bsNegocio, IBSBanco
    {
       public int CodLivro{get;set;}
       public string Titulo {get;set;}
       public string ISBN { get; set; }
       public DateTime DataEntrada { get; set; }
       public string Status { get; set; }
       public int Quantidade { get; set; }
       public double Valor { get; set; }

       tbLivros tb = new tbLivros();

        public bool Salvar()
        {
            throw new NotImplementedException();
        }

        public bool Atualizar()
        {
            throw new NotImplementedException();
        }

        public bool Apagar()
        {
            throw new NotImplementedException();
        }

        public bool Consultar()
        {
            throw new NotImplementedException();
        }

        public int ProximoCodigo()
        {
            int ret = int.MinValue;

            ret = tb.ProximoCodigo();

            return ret;
        }

        public DataSet LerTodosDados()
        {
            DataSet ds = new DataSet();

            ds = tb.LerTodosDados();

            return ds;
        }
    }
}

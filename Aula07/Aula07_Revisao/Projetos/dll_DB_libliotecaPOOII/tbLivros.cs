using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace UNIP.POOII.DB_BlibliotecaPOOII
{
    public class tbLivros : dbTabelas, IDBBanco
    {
        public int CodLivro { get; set; }
        public string Titulo { get; set; }
        public string ISBN { get; set; }
        public DateTime DataEntrada { get; set; }
        public string Status { get; set; }
        public int Quantidade { get; set; }
        public double Valor { get; set; }

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

            string query = "";

            query = "SELECT Max(CodLivro) FROM tbLivros";

            ret = base.ProximoCodigo(query);

            return ret;
        }

        public DataSet LerTodosDados()
        {
            DataSet ds = new DataSet();

            string query = "";

            query = "SELECT CodLivro, Titulo, ISBN, DataEntrada, Status, Quantidade, Valor FROM tbLivros";

            ds = base.LerTodosDados(query);

            return ds;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace UNIP.POOII.DB_BlibliotecaPOOII
{
    public class tbAutores : dbTabelas, IDBBanco
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public DateTime Data { get; set; }
       
        public bool Salvar()
        {
            bool ret = false;
            int count = int.MinValue;
            string query = "";

            query = "SELECT COUNT(*) FROM tbAutores WHERE CodAutor=" + Codigo.ToString();

            count = base.ConsultarNumeroInteiro(query);

            if (0 >= count)
            {
                query = "INSERT INTO tbAutores(CodAutor,NomeAutor,DataEntrada)VALUES(" +
                        Codigo.ToString() +
                        "," + "'" + Nome + "'" +
                        "," + "'" +
                        Data.Year.ToString() + "/" +
                        Data.Month.ToString() + "/" +
                        Data.Day.ToString() +
                        "'" + ")";
            }
            else
            {
                query = " UPDATE tbAutores " +
                    " SET NomeAutor =" + "'" + Nome + "'" +
                    "," + "DataEntrada = " + "'" +
                        Data.Year.ToString() + "/" +
                        Data.Month.ToString() + "/" +
                        Data.Day.ToString() +
                        "'" +
                        " WHERE CodAutor=" + Codigo.ToString();

            }
            ret = base.Salvar(query);

            return ret;
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

            query = "SELECT Max(CodAutor) FROM tbAutores";

            ret = base.ProximoCodigo(query);

            return ret;
        }

        public DataSet LerTodosDados()
        {
            DataSet ds = new DataSet();

            string query = "";

            query = "SELECT CodAutor, NomeAutor, DataEntrada FROM tbAutores";

            ds = base.LerTodosDados(query);

            return ds;
        }
    }
}

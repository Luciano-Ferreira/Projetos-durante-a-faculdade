using dbDLLGenerico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dbDLLEspecifica
{
    public class DBBaseEspefifica
    {
        public void InserirTB01(string Nome)
        {
            DBBase db = new DBBase();
            string Query = "INSERT INTO tb01(Nome)VALUES(" + Nome + ")";
            db.ExecutaInstrucaoNaBase(Query);
        }

        public void ApagarTB01(int Id)
        {
            DBBase db = new DBBase();
            string Query = "DELETE tb01 where Id=" + Id.ToString();
            db.ExecutaInstrucaoNaBase(Query);
        }

        public void AtualizarTB01(int Id, string Nome)
        {
            DBBase db = new DBBase();
            string Query = "UPDATE tb01 SET Nome='" + Nome + "' where Id=" + Id;
            db.ExecutaInstrucaoNaBase(Query);
        }

    }
}

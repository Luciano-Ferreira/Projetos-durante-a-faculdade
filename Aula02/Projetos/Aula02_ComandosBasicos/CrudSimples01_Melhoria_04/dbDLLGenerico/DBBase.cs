using dllConfiguracao;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace dbDLLGenerico
{
    public class DBBase
    {
        public void ExecutaInstrucaoNaBase(string QuerySQL)
        {

            Configuracao conf = new Configuracao();

            string strConxao = conf.StrConfiguracao;
                //"Data Source=DESKTOP-MGO8CIR;Initial Catalog=dbAula02;Integrated Security=True";
            string Query = QuerySQL;
            SqlConnection con = new SqlConnection(strConxao);
            SqlCommand sqlCommand = new SqlCommand(Query, con);

            try
            {
                con.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                string erro = ex.Message;
                erro += "   !!!";
            }
            finally
            {
                con.Close();
            }

        }
    }
}

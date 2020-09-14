using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace CrudSimples01
{
    public class DBBase
    {
        public void ExecutaInstrucaoNaBase(string QuerySQL)
        {
            string strConxao = "Data Source=ESTUDOS;Initial Catalog=dbTeste;Integrated Security=True";
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

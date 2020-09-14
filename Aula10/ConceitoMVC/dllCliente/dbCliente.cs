using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace dllBanco
{

    public class dbCliente
    {
        public int CodCliente { get; set; }
        public string NomeCliente { get; set; }
        public int Idade { get; set; }
        public char Sexo { get; set; }
       
        public bool Salvar(ref string status)
        {
            bool ret = false;

            string erro = "";

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=DESKTOP-MGO8CIR;Initial Catalog=MVC;Integrated Security=True";

            SqlCommand comando = new SqlCommand();

            try
            {
                comando.Connection = conexao;

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("@NomeCliente", SqlDbType.VarChar).Value = NomeCliente;
                comando.Parameters.Add("@Idade", SqlDbType.Int).Value = Idade;
                comando.Parameters.Add("@Sexo", SqlDbType.Char).Value = Sexo;

                comando.Parameters.Add("@MsgErro", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;

                comando.CommandText = "sp_CadastrarCliente";

                conexao.Open();
                comando.ExecuteNonQuery();

                erro = comando.Parameters["@MsgErro"].Value.ToString();

                status = erro;
            }
            catch (Exception ex)
            {
                string err = ex.Message;
            }
            finally
            {
                conexao.Close();
            }
            return ret;
        }

        public DataSet ListaClientes(ref string status)
        {
            DataSet ds = new DataSet();
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=ANGEL01\SQL2017DEV;Initial Catalog=MVC;Integrated Security=True";

            SqlCommand comando = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                comando.Connection = conexao;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "sp_ConsultaTodosClientes";

                da.SelectCommand = comando;

                da.Fill(ds);

                status = "Consulta Executada com Sucesso";
            }
            catch (Exception ex)
            {
                string err = ex.Message;
                status = "Consulta Falhou";
            }

            return ds;
        }
    }
}

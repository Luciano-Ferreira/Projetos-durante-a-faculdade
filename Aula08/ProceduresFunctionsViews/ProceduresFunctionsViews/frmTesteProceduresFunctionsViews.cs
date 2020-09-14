using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace ProceduresFunctionsViews
{
    public partial class frmTesteProceduresFunctionsViews : Form
    {
        public frmTesteProceduresFunctionsViews()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string strConexao = "";
            string Query="";
            DataTable view = new DataTable();
            SqlConnection conexao = null;
            SqlCommand comando = null;

            try{
                strConexao = ConfigurationManager.ConnectionStrings["dbProceduresFunctionsViews"].ConnectionString; ;
                Query = "SELECT CodPedido"+
                    ",CodProduto" +
                    ",NomeProduto"+
                    ", Preco"+
                    ", Quantidade"+
                    " FROM RelatorioPedidos";

                conexao = 
                    new SqlConnection(strConexao);
                comando = 
                    new SqlCommand(Query, conexao);
                conexao.Open();
                view.Load(
                    comando.ExecuteReader()
                    );
                dgView.DataSource = view;
            }
            catch (Exception ex){
                string err = ex.Message;
                err += "   !!!";
            }
            finally{
                if (conexao != null)
                    conexao.Close();
            }
        }

        private void btnChamaFuncaoTipoEscadar_Click(object sender, EventArgs e)
        {
            string strConexao = "";
            string Query = "";
            string RetornoFuncao = "";
            DataTable view = new DataTable();
            SqlConnection conexao = null;
            SqlCommand comando = null;

            try{
                strConexao = ConfigurationManager.ConnectionStrings["dbProceduresFunctionsViews"].ConnectionString;

                Query = "SELECT dbo.fn_ToTalPedido(@CodPedido)";

                conexao = new SqlConnection(strConexao);
                comando = new SqlCommand(Query, conexao);

                SqlParameter codigoPedido = 
                   new SqlParameter("@CodPedido", SqlDbType.Int);

                codigoPedido.Value = 
                    int.Parse(txtCodigoPedido.Text);
                comando.Parameters.Add(codigoPedido);

                conexao.Open();

                RetornoFuncao = 
                    comando.ExecuteScalar().ToString();

                lblTotal.Text = RetornoFuncao;
            }
            catch (Exception ex){
                string err = ex.Message;
                err += "   !!!";
            }
            finally{
                if (conexao != null)
                    conexao.Close();
            }
        }

        private void btnFuncaoTipoTabela_Click(object sender, EventArgs e)
        {
            string strConexao = "";
            string Query = "";
            DataTable RetornoFuncaoTabela = new DataTable();
            DataTable view = new DataTable();
            SqlConnection conexao = null;
            SqlCommand comando = null;

            try
            {
                strConexao = ConfigurationManager.ConnectionStrings["dbProceduresFunctionsViews"].ConnectionString;

                Query= 
                    "SELECT * FROM " + 
                    "dbo.fn_DadosPedido(@CodPedido)";

                conexao=new SqlConnection(strConexao);
                comando=new SqlCommand(Query, conexao);

                SqlParameter codigoPedido =
                    new SqlParameter("@CodPedido", 
                        SqlDbType.Int);

                codigoPedido.Value = 
                    int.Parse(txtCodigoPedidoTipoTabela.Text);

                comando.Parameters.Add(codigoPedido);

                conexao.Open();

                RetornoFuncaoTabela.Load(comando.ExecuteReader());

                dgDadosPedido.DataSource = RetornoFuncaoTabela;
            }
            catch (Exception ex)
            {
                string err = ex.Message;
                err += "   !!!";
            }
            finally
            {
                if (conexao != null) conexao.Close();
            }

        }

        private void btnChamaprocRetornaTabela_Click(object sender, EventArgs e)
        {
            string strConexao = "";
            string Query = "";
            DataTable RetornoFuncaoTabela = new DataTable();
            DataTable view = new DataTable();
            SqlConnection conexao = null;
            SqlCommand comando = null;

            try
            {
                strConexao = ConfigurationManager.ConnectionStrings["dbProceduresFunctionsViews"].ConnectionString;

                Query = "sp_DadosPedido";

                conexao = new SqlConnection(strConexao);
                comando = new SqlCommand(Query, conexao);

                // POR PADRAO O TIPO DE COMANDO E TEXTO, OU SEJA, UMA QUERY NORMAL
                // POREM PARA PROCEDURES DEVEMOS MUDAR O TIPO PARA -> CommandType.StoredProcedure
                comando.CommandType = CommandType.StoredProcedure;

                //APENAS UM OUTRO JEITO DE ADICIONAR PARAMETROS
                //COSTUMA SER BASTANTE USADO POIS REDUZ O NUMERO DE LINHAS E CODIGO
                comando.Parameters.Add(new SqlParameter("@CodPedido", SqlDbType.Int)).Value = int.Parse(txtCodPedidoProcTabela.Text);

                conexao.Open();

                RetornoFuncaoTabela.Load(comando.ExecuteReader());

                dgProcDadosPedido.DataSource = RetornoFuncaoTabela;
            }
            catch (Exception ex)
            {
                string err = ex.Message;
                err += "   !!!";
            }
            finally
            {
                if (conexao != null) conexao.Close();
            }

        }

        private void btnChamaprocRetornaEscalar_Click(object sender, EventArgs e)
        {
            string strConexao = "";
            string Query = "";
            string RetornoFuncao = "";
            DataTable view = new DataTable();
            SqlConnection conexao = null;
            SqlCommand comando = null;

            try
            {
                strConexao = ConfigurationManager.ConnectionStrings["dbProceduresFunctionsViews"].ConnectionString;

                Query = "sp_ToTalPedido";

                conexao = new SqlConnection(strConexao);
                comando = new SqlCommand(Query, conexao);


                // POR PADRAO O TIPO DE COMANDO E TEXTO, OU SEJA, UMA QUERY NORMAL
                // POREM PARA PROCEDURES DEVEMOS MUDAR O TIPO PARA -> CommandType.StoredProcedure
                comando.CommandType = CommandType.StoredProcedure;


                SqlParameter codigoPedido = new SqlParameter("@CodPedido", SqlDbType.Int);

                codigoPedido.Value = int.Parse(txtCodPedidoProcEscalar.Text);
                comando.Parameters.Add(codigoPedido);

                conexao.Open();

                RetornoFuncao = comando.ExecuteScalar().ToString();

                lblRetornoProcEscalar.Text = RetornoFuncao;
            }
            catch (Exception ex)
            {
                string err = ex.Message;
                err += "   !!!";
            }
            finally
            {
                if (conexao != null) conexao.Close();
            }
        }

        private void btnInserirProduto_Click(object sender, EventArgs e)
        {
            string strConexao = "";
            string Query = "";
            DataTable RetornoFuncaoTabela = new DataTable();
            DataTable view = new DataTable();
            SqlConnection conexao = null;
            SqlCommand comando = null;

            try
            {
                strConexao = ConfigurationManager.ConnectionStrings["dbProceduresFunctionsViews"].ConnectionString;

                Query = "sp_InsertProduto";

                conexao = new SqlConnection(strConexao);
                comando = new SqlCommand(Query, conexao);

                // POR PADRAO O TIPO DE COMANDO E TEXTO, OU SEJA, UMA QUERY NORMAL
                // POREM PARA PROCEDURES DEVEMOS MUDAR O TIPO PARA -> CommandType.StoredProcedure
                comando.CommandType = CommandType.StoredProcedure;

                //APENAS UM OUTRO JEITO DE ADICIONAR PARAMETROS
                //COSTUMA SER BASTANTE USADO POIS REDUZ O NUMERO DE LINHAS E CODIGO
                comando.Parameters.Add(new SqlParameter("@NomeProduto", SqlDbType.VarChar)).Value = txtNomeProduto.Text;
                comando.Parameters.Add(new SqlParameter("@Preco", SqlDbType.Decimal)).Value = Convert.ToDecimal(txtPreco.Text);

                conexao.Open();

                comando.ExecuteNonQuery();

                dgProcDadosPedido.DataSource = RetornoFuncaoTabela;
            }
            catch (Exception ex)
            {
                string err = ex.Message;
                err += "   !!!";
            }
            finally
            {
                if (conexao != null) conexao.Close();
            }
        }

        private void btnAtualizarProduto_Click(object sender, EventArgs e)
        {
            string strConexao = "";
            string Query = "";
            DataTable RetornoFuncaoTabela = new DataTable();
            DataTable view = new DataTable();
            SqlConnection conexao = null;
            SqlCommand comando = null;

            try
            {
                strConexao = ConfigurationManager.ConnectionStrings["dbProceduresFunctionsViews"].ConnectionString;

                Query = "sp_AtualizarProduto";

                conexao = new SqlConnection(strConexao);
                comando = new SqlCommand(Query, conexao);

                // POR PADRAO O TIPO DE COMANDO E TEXTO, OU SEJA, UMA QUERY NORMAL
                // POREM PARA PROCEDURES DEVEMOS MUDAR O TIPO PARA -> CommandType.StoredProcedure
                comando.CommandType = CommandType.StoredProcedure;

                //APENAS UM OUTRO JEITO DE ADICIONAR PARAMETROS
                //COSTUMA SER BASTANTE USADO POIS REDUZ O NUMERO DE LINHAS E CODIGO
                comando.Parameters.Add(new SqlParameter("@CodProduto", SqlDbType.Int )).Value = int.Parse(txtCodProdutoAtualizar.Text);
                comando.Parameters.Add(new SqlParameter("@NomeProduto", SqlDbType.VarChar)).Value = txtNomeAtualizarProduto.Text;
                comando.Parameters.Add(new SqlParameter("@Preco", SqlDbType.Decimal)).Value = Convert.ToDecimal(txtPrecoAtualizarProduto.Text);

                conexao.Open();

                comando.ExecuteNonQuery();

                dgProcDadosPedido.DataSource = RetornoFuncaoTabela;
            }
            catch (Exception ex)
            {
                string err = ex.Message;
                err += "   !!!";
            }
            finally
            {
                if (conexao != null) conexao.Close();
            }

        }

        private void btnApagarProduto_Click(object sender, EventArgs e)
        {
            string strConexao = "";
            string Query = "";
            DataTable RetornoFuncaoTabela = new DataTable();
            DataTable view = new DataTable();
            SqlConnection conexao = null;
            SqlCommand comando = null;

            try
            {
                strConexao = ConfigurationManager.ConnectionStrings["dbProceduresFunctionsViews"].ConnectionString;

                Query = "sp_ApagarProduto";

                conexao = new SqlConnection(strConexao);
                comando = new SqlCommand(Query, conexao);

                // POR PADRAO O TIPO DE COMANDO E TEXTO, OU SEJA, UMA QUERY NORMAL
                // POREM PARA PROCEDURES DEVEMOS MUDAR O TIPO PARA -> CommandType.StoredProcedure
                comando.CommandType = CommandType.StoredProcedure;

                //APENAS UM OUTRO JEITO DE ADICIONAR PARAMETROS
                //COSTUMA SER BASTANTE USADO POIS REDUZ O NUMERO DE LINHAS E CODIGO
                comando.Parameters.Add(new SqlParameter("@CodProduto", SqlDbType.Int)).Value = int.Parse(txtCodProdutoApagar.Text);

                conexao.Open();

                comando.ExecuteNonQuery();

                dgProcDadosPedido.DataSource = RetornoFuncaoTabela;
            }
            catch (Exception ex)
            {
                string err = ex.Message;
                err += "   !!!";
            }
            finally
            {
                if (conexao != null) conexao.Close();
            }

        }


    }
}

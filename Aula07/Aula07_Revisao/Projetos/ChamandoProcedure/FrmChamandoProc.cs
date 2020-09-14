using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChamandoProcedure
{
    public partial class FrmChamandoProc : Form
    {
        public FrmChamandoProc()
        {
            InitializeComponent();
        }

        private void BtnChamandoProc_Click(object sender, EventArgs e)
        {
            string strConexao = "Data Source=ESTUDOS;Initial Catalog=dbTeste;Integrated Security=True";
            string Query = "sp_ProcedureSimplesExemplo"; //NOME DA PROC
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand comando = new SqlCommand(Query, conexao);

            //AJUSTAR O TIPO DE COMANDO PARA StoredProcedure
            //POR PADRAO O TIPO DE COMANDO E Text
            comando.CommandType = CommandType.StoredProcedure;

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(comando);

            da.Fill(ds);

            dgTb01.DataSource = ds.Tables[0];

        }

        private void BtnChamandoView1_Click(object sender, EventArgs e)
        {
            string strConexao = "Data Source=ESTUDOS;Initial Catalog=dbTeste;Integrated Security=True";
            string Query = "Select id, Nome from vw_Tb01"; //CHAMA A VIEW COMO UMA TABELA 
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand comando = new SqlCommand(Query, conexao);

            //AJUSTAR O TIPO DE COMANDO PARA StoredProcedure
            //POR PADRAO O TIPO DE COMANDO E Text
            //comando.CommandType = CommandType.StoredProcedure;

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(comando);

            da.Fill(ds);

            dgTb01.DataSource = ds.Tables[0];
        }

        private void BtnChamandoView2_Click(object sender, EventArgs e)
        {
            string strConexao = "Data Source=ESTUDOS;Initial Catalog=dbTeste;Integrated Security=True";
            string Query = "Select id, Nome from vw_Tb01 where id > 2"; //CHAMA A VIEW COMO UMA TABELA 
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand comando = new SqlCommand(Query, conexao);

            //AJUSTAR O TIPO DE COMANDO PARA StoredProcedure
            //POR PADRAO O TIPO DE COMANDO E Text
            //comando.CommandType = CommandType.StoredProcedure;

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(comando);

            da.Fill(ds);

            dgTb01.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strConexao = "Data Source=ESTUDOS;Initial Catalog=dbTeste;Integrated Security=True";
            string Query = "Select id, Nome from fn_TB01()"; //CHAMA A funcao que retorna TABELA 
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand comando = new SqlCommand(Query, conexao);

            //AJUSTAR O TIPO DE COMANDO PARA StoredProcedure
            //POR PADRAO O TIPO DE COMANDO E Text
            //comando.CommandType = CommandType.StoredProcedure;

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(comando);

            da.Fill(ds);

            dgTb01.DataSource = ds.Tables[0];
        }
    }
}

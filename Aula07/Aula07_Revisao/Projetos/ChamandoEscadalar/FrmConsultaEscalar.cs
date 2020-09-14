using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChamandoEscadalar
{
    public partial class FrmConsultaEscalar : Form
    {
        public FrmConsultaEscalar()
        {
            InitializeComponent();
        }

        private void BtnConsulta1_Click(object sender, EventArgs e)
        {
            string strConexao = "Data Source=ESTUDOS;Initial Catalog=dbTeste;Integrated Security=True";
            string Query = "Select Nome from vw_Tb01 WHERE id=1"; 
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand comando = new SqlCommand(Query, conexao);
            try
            {
                conexao.Open();
                string retornoQuery = "";
                retornoQuery = comando.ExecuteScalar().ToString();
                TxtEscalar.Text = retornoQuery;
            }
            catch(Exception ex)
            {
                string erro = ex.Message;
            }
            finally
            {
                conexao.Close();
            }
        }

        private void BtnConsulta2_Click(object sender, EventArgs e)
        {
            string strConexao = "Data Source=ESTUDOS;Initial Catalog=dbTeste;Integrated Security=True";
            string Query = "Select dbo.fn_Funcao01() CampoX";
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand comando = new SqlCommand(Query, conexao);
            try
            {
                conexao.Open();
                string retornoQuery = "";
                retornoQuery = comando.ExecuteScalar().ToString();
                TxtEscalar.Text = retornoQuery;
            }
            catch (Exception ex)
            {
                string erro = ex.Message;
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}

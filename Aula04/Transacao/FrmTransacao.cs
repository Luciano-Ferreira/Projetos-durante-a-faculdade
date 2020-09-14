using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Transacao
{
    public partial class FrmTransacao : Form
    {
        public FrmTransacao()
        {
            InitializeComponent();
        }

        private void BtnExecutarTransacaoOK_Click(object sender, EventArgs e)
        {
            //QUANDO AS EM UMA OPERAÇAO DEVE-SE SE EXECUTAR MAIS DE UMA
            //ALTERACAO NA BASE, OU SEJA, INSERTS/UPDATES/DELETES
            //SE TAL FORMA QUE A OPERAÇAO SEJA ATOMICA E EM CASO DE FALHA
            //EXECUTAR O ROOLBACK E NO CASO DE SUSSESSO EXECUTAR O COMMIT

            string strConexao = "Data Source=desktop-mgo8cir;Initial Catalog=dbTeste01;Integrated Security=True";
            using (SqlConnection conexao = new SqlConnection(strConexao))
            {
                conexao.Open();

                SqlCommand comando = conexao.CreateCommand();
                SqlTransaction transacao;

                transacao = conexao.BeginTransaction();

                comando.Connection = conexao;
                comando.Transaction = transacao;

                try
                {
                    comando.CommandText =
                        "INSERT INTO tb01(Nome) VALUES('" + "T01_" + DateTime.Now.Millisecond.ToString() + "')";
                    comando.ExecuteNonQuery();
                    comando.CommandText =
                        "INSERT INTO tb01(Nome) VALUES('" + "T02_" + DateTime.Now.Millisecond.ToString() + "')";
                    comando.ExecuteNonQuery();

                    // Tracao OK
                    transacao.Commit();
                    lblStatus.Text = "Tracao OK";
                }
                catch (Exception ex)
                {
                    lblStatus.Text = "F A L H O U ";
                    try
                    {
                        transacao.Rollback();
                    }
                    catch (Exception ex2)
                    {
                        lblStatus.Text = "ROLLBACK F A L H O U ";
                    }
                }
                finally
                {
                    conexao.Close();
                }
            }
        }

        private void BtnExecutarTransacaoFalha_Click(object sender, EventArgs e)
        {
            //QUANDO AS EM UMA OPERAÇAO DEVE-SE SE EXECUTAR MAIS DE UMA
            //ALTERACAO NA BASE, OU SEJA, INSERTS/UPDATES/DELETES
            //SE TAL FORMA QUE A OPERAÇAO SEJA ATOMICA E EM CASO DE FALHA
            //EXECUTAR O ROOLBACK E NO CASO DE SUSSESSO EXECUTAR O COMMIT

            string strConexao = "Data Source=desktop-mgo8cir;Initial Catalog=dbTeste01;Integrated Security=True";
            using (SqlConnection conexao = new SqlConnection(strConexao))
            {
                conexao.Open();

                SqlCommand comando = conexao.CreateCommand();
                SqlTransaction transacao;

                transacao = conexao.BeginTransaction();

                comando.Connection = conexao;
                comando.Transaction = transacao;

                try
                {
                    comando.CommandText =
                        "INSERT INTO tb01(Nome) VALUES('" + "T03_" + DateTime.Now.Millisecond.ToString() + "')";
                    comando.ExecuteNonQuery();
                    comando.CommandText =
                        "INSERT INTO tb01(Nome1) VALUES('" + "T04_" + DateTime.Now.Millisecond.ToString() + "')";
                    comando.ExecuteNonQuery();

                    // Tracao OK
                    transacao.Commit();
                    lblStatus.Text = "Tracao OK";
                }
                catch (Exception ex)
                {
                    lblStatus.Text = "F A L H O U ";
                    try
                    {
                        transacao.Rollback();
                    }
                    catch (Exception ex2)
                    {
                        lblStatus.Text = "ROLLBACK F A L H O U ";
                    }
                }
                finally
                {
                    conexao.Close();
                }
            }

        }
    }
}

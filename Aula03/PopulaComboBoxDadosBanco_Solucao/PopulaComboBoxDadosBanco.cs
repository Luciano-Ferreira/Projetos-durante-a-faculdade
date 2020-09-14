using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NA024_PopulaComboBoxDadosBanco_Solucao
{
    public partial class frmPopulaComboBoxDadosBanco_Solucao : Form
    {
        public frmPopulaComboBoxDadosBanco_Solucao()
        {
            InitializeComponent();
        }

        private void frmPopulaComboBoxDadosBanco_Solucao_Load(object sender, EventArgs e)
        {
            lblCodigoCidadeSelecionada.Text = "";

            //http://www.ibge.gov.br/home/geociencias/areaterritorial/principal.shtm
            //http://www.ibge.gov.br/home/geociencias/geografia/redes_fluxos/gestao_do_territorio_2014/base.shtm
            //https://gustavomaiaaguiar.wordpress.com/2008/10/12/como-resolver-problemas-relacionados-a-conflitos-de-collation/
        }


        void PopulaUF()
        {
            string stringDeConexao = "Data Source=desktop-mgo8cir;Initial Catalog=dbTeste;Integrated Security=True";
            string QuerySQL = "SELECT Sigla + '-' + UF  as NomeUF, CodUF from tbUF";
            
            try
            {                
                //Cria conexão com banco de dados
                using (SqlConnection conexao = new SqlConnection(stringDeConexao))
                {
                    //Cria um dataadapter para receber o select do banco de dados
                    using (SqlDataAdapter da = new SqlDataAdapter(QuerySQL, conexao))
                    {
                        //cria um datatable
                        DataTable dt = new DataTable();
                        //Faz um fill dos dados do DataAdapter para o DataTable
                        da.Fill(dt);
                        //Fonte de dados do Combobox recebe o datatable
                        this.cboUF.DataSource = dt;
                        //DisplayMember = recebe o nome que está no banco de dados
                        this.cboUF.DisplayMember = "NomeUF";
                        //ValueMember = recebe o código e guarda internamente em cada item do combobox.
                        this.cboUF.ValueMember = "CodUF";
                    }
                }
            }
            catch (Exception ex)
            {
                string err = ex.Message;
                err = "Falha : " + err;
            }
        }

        void PopulaMunicipio(string CodUF)
        {
            string stringDeConexao = "Data Source=desktop-mgo8cir;Initial Catalog=dbTeste;Integrated Security=True";
            string QuerySQL = "SELECT NomeMunic , Codmun FROM tbIBGEMunicipios WHERE CodUF=";
            try
            {
                //Cria conexão com banco de dados
                using (SqlConnection conexao = new SqlConnection(stringDeConexao))
                {
                    QuerySQL += CodUF;

                    //Cria um dataadapter para receber o select do banco de dados
                    using (SqlDataAdapter da = new SqlDataAdapter(QuerySQL, conexao))
                    {
                        //cria um datatable
                        DataTable dt = new DataTable();
                        //Faz um fill dos dados do DataAdapter para o DataTable
                        da.Fill(dt);
                        //Fonte de dados do Combobox recebe o datatable
                        this.cboMunicipio.DataSource = dt;
                        //DisplayMember = recebe o nome que está no banco de dados
                        this.cboMunicipio.DisplayMember = "NomeMunic";
                        //ValueMember = recebe o código e guarda internamente em cada item do combobox.
                        this.cboMunicipio.ValueMember = "Codmun";
                    }
                }
            }
            catch (Exception ex)
            {
                string err = ex.Message;
                err = "Falha : " + err;
            }
        }


        private void btnConsultaUF_Click(object sender, EventArgs e)
        {
            lblCodigoCidadeSelecionada.Text = "";
            PopulaUF();
        }


        private void cboUF_SelectedIndexChanged(object sender, EventArgs e)
        {            
            string CodUF = cboUF.SelectedValue.ToString();
            PopulaMunicipio(CodUF);
            lblCodigoCidadeSelecionada.Text = "";
        }

        private void cboMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCodigoCidadeSelecionada.Text = cboMunicipio.SelectedValue.ToString();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblCodigoCidadeSelecionada_Click(object sender, EventArgs e)
        {

        }
    }
}

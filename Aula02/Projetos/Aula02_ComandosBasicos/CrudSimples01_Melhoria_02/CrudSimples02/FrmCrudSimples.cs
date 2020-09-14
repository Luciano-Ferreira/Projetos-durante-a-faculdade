using dbDLLGenerico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudSimples01
{
    public partial class FrmCrudSimples : Form
    {
        public FrmCrudSimples()
        {
            InitializeComponent();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            string strConxao = "Data Source=DESKTOP-MGO8CIR;Initial Catalog=dbAula02;Integrated Security=True";
            string Query = "Select * from tb01";
            SqlConnection con = new SqlConnection(strConxao);
            SqlDataAdapter da = new SqlDataAdapter(Query,con);
            DataTable dt = new DataTable();

            da.Fill(dt);

            dgTabela.DataSource = dt;
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            LblStatus.Text = "";
            string strConxao = "Data Source=DESKTOP-MGO8CIR;Initial Catalog=dbAula02;Integrated Security=True";
            string Query = "Select * from tb01 where Id=" + TxtID01.Text;
            SqlConnection con = new SqlConnection(strConxao);
            SqlCommand sqlCommand = new SqlCommand(Query, con);
            SqlDataReader dr = null;

            con.Open();

            dr = sqlCommand.ExecuteReader();

            if (dr.Read())
            {
                TxtNome01.Text = dr["Nome"].ToString();
            }

            con.Close();

            LblStatus.Text = "Registro Selecionado Com Sucesso";
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            LblStatus.Text = "";
            DBBase db = new DBBase();
            string Query = "INSERT INTO tb01(Nome)VALUES(" + "'" +TxtNome.Text + "'" + ")";
            db.ExecutaInstrucaoNaBase(Query);
            LblStatus.Text = "Registro Inserido Com Sucesso";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            LblStatus.Text = "";
            DBBase db = new DBBase();
            string Query = "DELETE tb01 where Id=" + TxtID02.Text;
            db.ExecutaInstrucaoNaBase(Query);
            LblStatus.Text = "Registro Apagado Com Sucesso";
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            LblStatus.Text = "";

            DBBase db = new DBBase();
            string Query = "UPDATE tb01 SET Nome=" + "'" + TxtNome03.Text + "'" + " where Id=" + TxtID03.Text;
            db.ExecutaInstrucaoNaBase(Query);
            LblStatus.Text = "Registro Atualizado Com Sucesso";
        }
        /*aqui ele pegou DBBASE  e colocou em "references"*/
        private void DgTabela_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

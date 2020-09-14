using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ConceitoMVC.Modelo;

namespace ConceitoMVC.Visao
{
    public partial class frmConsultaClientes : Form
    {
        public frmConsultaClientes()
        {
            InitializeComponent();
        }

        private void frmConsultaClientes_Load(object sender, EventArgs e)
        {
            PopulaGrid();
        }


        void PopulaGrid()
        {
            DataSet ds = new DataSet();
            dbBaseModel db = new dbBaseModel(); 
            string status="";

            ds = db.ConsultaTodosClientes(ref status);

            dgListaClientes.DataSource = ds.Tables[0];
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NA023_DataGrid
{
    public partial class frmDataGrid : Form
    {
        public frmDataGrid()
        {
            InitializeComponent();
        }


        /// <summary>
        /// O Código deste evento foicopiado do link
        /// https://msdn.microsoft.com/pt-br/library/system.data.datatable.newrow(v=vs.110).aspx
        /// 
        /// E Este é um comentário especial que serve para gerar documentação 
        /// para um futuro manual que exlica o que o metodo faz
        /// 
        /// que no caso cria uma tabela com o DataTable, usando o DataColumn
        /// uma coluna é para armazenar inteiros e outra dados alfanumericos,
        /// ou seja, strings, depois cria linhas row da tabela clonando
        /// a linha da tabela.
        /// 
        /// Criada a Linha adicona a linha na tabela.
        /// 
        /// Já se poderia adionar a tabela ao grid, porem criou-se uma view
        /// 
        /// A view os da maior flexibilidade para apresentação dos dados
        /// 
        /// como por exemplo ordenação.
        /// 
        /// por fim usa-se a view como fonte de dados para o componente visual
        /// que no caso é um DataGridView
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtnAdicionarLinhas_Click(object sender, EventArgs e)
        {
            // Create new DataTable and DataSource objects.
            DataTable table = new DataTable();

            // Declare DataColumn and DataRow variables.
            DataColumn column;
            DataRow row;
            DataView view;

            // Create new DataColumn, set DataType, ColumnName and add to DataTable.    
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "id";
            table.Columns.Add(column);

            // Create second column.
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "item";
            table.Columns.Add(column);

            // Create new DataRow objects and add to DataTable.    
            for (int i = 0; i < 10; i++)
            {
                row = table.NewRow();
                row["id"] = i;
                row["item"] = "item " + i.ToString();
                table.Rows.Add(row);
            }

            // Create a DataView using the DataTable.
            view = new DataView(table);

            // Set a DataGrid control's DataSource to the DataView.
            dgTabelaUm.DataSource = view;
        }
    }
}


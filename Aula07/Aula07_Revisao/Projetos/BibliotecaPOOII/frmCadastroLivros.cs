using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UNIP.POOII.BS_BlibliotecaPOOII;

namespace UNIP.POOII.BibliotecaPOOII
{
    public partial class frmCadastroLivros : Form
    {
        //SITE PARA ENTENDER COMO VALIDAR O ISBN
        //https://pt.wikipedia.org/wiki/International_Standard_Book_Number

        Livros livro = new Livros();

        public frmCadastroLivros()
        {
            InitializeComponent();
        }

        private void btnSalvarLivro_Click(object sender, EventArgs e)
        {
            if (validaFormulario())
            {
                //livro.Nome = txtNomeAutor.Text;
                //livro.Codigo = Convert.ToInt32(txtCodigo.Text);
                //livro.Data = dtData.Value;

                if (livro.Salvar())
                {
                    MessageBox.Show("Sucesso ao Salvar Dados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Falha ao Salvar Dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        bool validaFormulario()
        {
            bool ret = false;

            //if (txtNomeAutor.Text.Trim().Length <= 0)
            //{
            //    MessageBox.Show("Nome não está preechido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return ret;
            //}

            ret = true;

            return ret;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UNIP.POOII.BibliotecaPOOII
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirNovoForm<frmCadastroAutores>("AUTORES");

            //frmCadastroAutores frmCadAutor = new frmCadastroAutores();
            //frmCadAutor.MdiParent = this;
            //frmCadAutor.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


        void AbrirNovoForm<T>(string TAG) where T : Form, new()
        {
            foreach (Form f in MdiChildren)
            {
                if (f.GetType() == typeof(T))
                {
                    f.Activate();
                    return;
                }
            }

            Form form = new T();
            form.MdiParent = this;
            form.Tag = TAG;
            form.Show();
        }
    }
}

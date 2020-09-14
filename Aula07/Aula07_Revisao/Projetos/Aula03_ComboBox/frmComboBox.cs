using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NA022_ComboBox
{
    public partial class frmComboBox : Form
    {
        public frmComboBox()
        {
            InitializeComponent();
        }

        private void btnSetaSelecionado_Click(object sender, EventArgs e)
        {
            cboListaDois.Items.Add(cboListaUm.SelectedItem);
        }
    }
}

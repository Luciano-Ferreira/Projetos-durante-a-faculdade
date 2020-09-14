using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FrmMDI : Form
    {
        public FrmMDI()
        {
            InitializeComponent();
        }

        private void chamarSDI01ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSDI01 form01 = new FrmSDI01();
            form01.MdiParent = this;
            form01.Show();
        }

        private void chamarSDI02ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSDI02 form02 = new FrmSDI02();
            //form02.MdiParent = this;
            form02.Show();
        }
    }
}

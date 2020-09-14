using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Timer01
{
    public partial class FrmTimer01 : Form
    {
        public FrmTimer01()
        {
            InitializeComponent();
        }

        private void TmTemporizadorRelogio_Tick(object sender, EventArgs e)
        {
            //DateTime.Now = DATA E HORA DO SISTEMA
            DateTime dt = DateTime.Now;
            string Hora = dt.ToLongTimeString();
            SetarLabel(Hora);
        }

        private void BtnIniciarRelogio_Click(object sender, EventArgs e)
        {
            TmTemporizadorRelogio.Interval = 1000;
            TmTemporizadorRelogio.Enabled = true;
            TmTemporizadorRelogio.Start();
        }

        private void BtnPararRelogio_Click(object sender, EventArgs e)
        {
            TmTemporizadorRelogio.Stop();
            TmTemporizadorRelogio.Enabled = false;            
        }

        void SetarLabel(string strLabel)
        {
            //O EVETO TIMER COSTUMA PODE OCORRER EM THREAD SEPADA
            //ESTE METODO PREVIQUE QUE HAJA CONFLITO DE RECURSOS ENTRE THREADS
            if(lblDataHora.InvokeRequired)
            {
                lblDataHora.Invoke(new Action(() => lblDataHora.Text = strLabel));
            }
            else
            {
                lblDataHora.Text = strLabel;
            }
        }

        private void FrmTimer01_Load(object sender, EventArgs e)
        {
            //O EVENTO LOAD DO FORMULARIO OCORRE SEMPRE 
            //ANTES DO FORMULARIO SER EXIBIDO AO USUARIO
            //LOCAL USADO DE REGRA PARA INICIALIZAR COMPONETES
            lblDataHora.Text = "00:00:00";
        }
    }
}

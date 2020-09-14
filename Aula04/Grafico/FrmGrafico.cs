using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Grafico
{
    public partial class FrmGrafico : Form
    {
        public FrmGrafico()
        {
            InitializeComponent();
        }

        private void BtnExemplo01_Click(object sender, EventArgs e)
        {
            ExamploBarras();
        }


        public void ExamploBarras()
        {
            chkPizza.Enabled = false;
            this.ChtGrafico01.Titles.Clear();
            this.ChtGrafico01.Series.Clear();

            // Data arrays
            string[] seriesArray = { "Gato", "Cao", "Passaro", "Macaco" };
            int[] pointsArray = { 2, 1, 7, 5 };

            // Set palette
            this.ChtGrafico01.Palette = ChartColorPalette.EarthTones;

            // Set title
            this.ChtGrafico01.Titles.Add("Animais");

            // Add series.
            for (int i = 0; i < seriesArray.Length; i++)
            {
                Series series = this.ChtGrafico01.Series.Add(seriesArray[i]);
                series.Points.Add(pointsArray[i]);
            }
        }

        private void SplineChartExample()
        {
            chkPizza.Enabled = true;
            this.ChtGrafico01.Titles.Clear();
            this.ChtGrafico01.Series.Clear();

            this.ChtGrafico01.Titles.Add("Totais");

            Series series = this.ChtGrafico01.Series.Add("Total");
            series.ChartType = SeriesChartType.Spline;
            series.Points.AddXY("Set", 100);
            series.Points.AddXY("Out", 300);
            series.Points.AddXY("Nov", 800);
            series.Points.AddXY("Dez", 200);
            series.Points.AddXY("Jan", 600);
            series.Points.AddXY("Fev", 400);
        }


        private void BtnExemplo02_Click(object sender, EventArgs e)
        {
            SplineChartExample();
        }

        private void chkPizza_CheckedChanged(object sender, EventArgs e)
        {
            if (ChtGrafico01.Titles[0].Text == "Totais")
            {
                if(chkPizza.Checked)
                {
                    ChtGrafico01.Series[0].ChartType = SeriesChartType.Pie;
                }
                else
                {
                    ChtGrafico01.Series[0].ChartType = SeriesChartType.Spline;
                }
            }
        }

        private void FrmGrafico_Load(object sender, EventArgs e)
        {
            chkPizza.Enabled = false;
        }

        private void ChtGrafico01_Click(object sender, EventArgs e)
        {

        }
    }
}

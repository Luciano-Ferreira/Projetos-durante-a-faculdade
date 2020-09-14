namespace Grafico
{
    partial class FrmGrafico
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ChtGrafico01 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BtnExemplo01 = new System.Windows.Forms.Button();
            this.BtnExemplo02 = new System.Windows.Forms.Button();
            this.chkPizza = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ChtGrafico01)).BeginInit();
            this.SuspendLayout();
            // 
            // ChtGrafico01
            // 
            chartArea1.Name = "ChartArea1";
            this.ChtGrafico01.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChtGrafico01.Legends.Add(legend1);
            this.ChtGrafico01.Location = new System.Drawing.Point(16, 15);
            this.ChtGrafico01.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ChtGrafico01.Name = "ChtGrafico01";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ChtGrafico01.Series.Add(series1);
            this.ChtGrafico01.Size = new System.Drawing.Size(605, 327);
            this.ChtGrafico01.TabIndex = 0;
            this.ChtGrafico01.Text = "chart1";
            this.ChtGrafico01.Click += new System.EventHandler(this.ChtGrafico01_Click);
            // 
            // BtnExemplo01
            // 
            this.BtnExemplo01.Location = new System.Drawing.Point(647, 59);
            this.BtnExemplo01.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnExemplo01.Name = "BtnExemplo01";
            this.BtnExemplo01.Size = new System.Drawing.Size(100, 28);
            this.BtnExemplo01.TabIndex = 1;
            this.BtnExemplo01.Text = "Exemplo 1";
            this.BtnExemplo01.UseVisualStyleBackColor = true;
            this.BtnExemplo01.Click += new System.EventHandler(this.BtnExemplo01_Click);
            // 
            // BtnExemplo02
            // 
            this.BtnExemplo02.Location = new System.Drawing.Point(647, 122);
            this.BtnExemplo02.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnExemplo02.Name = "BtnExemplo02";
            this.BtnExemplo02.Size = new System.Drawing.Size(100, 28);
            this.BtnExemplo02.TabIndex = 2;
            this.BtnExemplo02.Text = "Exemplo 2";
            this.BtnExemplo02.UseVisualStyleBackColor = true;
            this.BtnExemplo02.Click += new System.EventHandler(this.BtnExemplo02_Click);
            // 
            // chkPizza
            // 
            this.chkPizza.AutoSize = true;
            this.chkPizza.Location = new System.Drawing.Point(647, 203);
            this.chkPizza.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkPizza.Name = "chkPizza";
            this.chkPizza.Size = new System.Drawing.Size(64, 21);
            this.chkPizza.TabIndex = 3;
            this.chkPizza.Text = "Pizza";
            this.chkPizza.UseVisualStyleBackColor = true;
            this.chkPizza.CheckedChanged += new System.EventHandler(this.chkPizza_CheckedChanged);
            // 
            // FrmGrafico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 362);
            this.Controls.Add(this.chkPizza);
            this.Controls.Add(this.BtnExemplo02);
            this.Controls.Add(this.BtnExemplo01);
            this.Controls.Add(this.ChtGrafico01);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmGrafico";
            this.Text = "Exemplo Grafico";
            this.Load += new System.EventHandler(this.FrmGrafico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChtGrafico01)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ChtGrafico01;
        private System.Windows.Forms.Button BtnExemplo01;
        private System.Windows.Forms.Button BtnExemplo02;
        private System.Windows.Forms.CheckBox chkPizza;
    }
}


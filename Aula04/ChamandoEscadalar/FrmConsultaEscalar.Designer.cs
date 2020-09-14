namespace ChamandoEscadalar
{
    partial class FrmConsultaEscalar
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
            this.TxtEscalar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnConsulta1 = new System.Windows.Forms.Button();
            this.BtnConsulta2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtEscalar
            // 
            this.TxtEscalar.Location = new System.Drawing.Point(70, 12);
            this.TxtEscalar.Name = "TxtEscalar";
            this.TxtEscalar.Size = new System.Drawing.Size(116, 20);
            this.TxtEscalar.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnConsulta2);
            this.groupBox1.Controls.Add(this.BtnConsulta1);
            this.groupBox1.Location = new System.Drawing.Point(70, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(116, 98);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta Escalar";
            // 
            // BtnConsulta1
            // 
            this.BtnConsulta1.Location = new System.Drawing.Point(17, 30);
            this.BtnConsulta1.Name = "BtnConsulta1";
            this.BtnConsulta1.Size = new System.Drawing.Size(75, 23);
            this.BtnConsulta1.TabIndex = 0;
            this.BtnConsulta1.Text = "Consulta 1";
            this.BtnConsulta1.UseVisualStyleBackColor = true;
            this.BtnConsulta1.Click += new System.EventHandler(this.BtnConsulta1_Click);
            // 
            // BtnConsulta2
            // 
            this.BtnConsulta2.Location = new System.Drawing.Point(17, 59);
            this.BtnConsulta2.Name = "BtnConsulta2";
            this.BtnConsulta2.Size = new System.Drawing.Size(75, 23);
            this.BtnConsulta2.TabIndex = 1;
            this.BtnConsulta2.Text = "Consulta 2";
            this.BtnConsulta2.UseVisualStyleBackColor = true;
            this.BtnConsulta2.Click += new System.EventHandler(this.BtnConsulta2_Click);
            // 
            // FrmConsultaEscalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 163);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TxtEscalar);
            this.Name = "FrmConsultaEscalar";
            this.Text = "Consulta Escalar";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtEscalar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnConsulta1;
        private System.Windows.Forms.Button BtnConsulta2;
    }
}


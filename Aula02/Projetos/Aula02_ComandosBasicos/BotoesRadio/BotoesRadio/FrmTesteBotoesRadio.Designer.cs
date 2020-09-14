namespace BotoesRadio
{
    partial class FrmTesteBotoesRadio
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
            this.RdoVerde = new System.Windows.Forms.RadioButton();
            this.RdoVermelho = new System.Windows.Forms.RadioButton();
            this.LblCor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RdoVerde
            // 
            this.RdoVerde.AutoSize = true;
            this.RdoVerde.Checked = true;
            this.RdoVerde.Location = new System.Drawing.Point(79, 57);
            this.RdoVerde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RdoVerde.Name = "RdoVerde";
            this.RdoVerde.Size = new System.Drawing.Size(67, 21);
            this.RdoVerde.TabIndex = 0;
            this.RdoVerde.TabStop = true;
            this.RdoVerde.Text = "Verde";
            this.RdoVerde.UseVisualStyleBackColor = true;
            this.RdoVerde.CheckedChanged += new System.EventHandler(this.RdoVerde_CheckedChanged);
            // 
            // RdoVermelho
            // 
            this.RdoVermelho.AutoSize = true;
            this.RdoVermelho.Location = new System.Drawing.Point(337, 57);
            this.RdoVermelho.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RdoVermelho.Name = "RdoVermelho";
            this.RdoVermelho.Size = new System.Drawing.Size(89, 21);
            this.RdoVermelho.TabIndex = 1;
            this.RdoVermelho.Text = "Vermelho";
            this.RdoVermelho.UseVisualStyleBackColor = true;
            this.RdoVermelho.CheckedChanged += new System.EventHandler(this.RdoVermelho_CheckedChanged);
            // 
            // LblCor
            // 
            this.LblCor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblCor.Location = new System.Drawing.Point(79, 140);
            this.LblCor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCor.Name = "LblCor";
            this.LblCor.Size = new System.Drawing.Size(372, 28);
            this.LblCor.TabIndex = 2;
            this.LblCor.Click += new System.EventHandler(this.LblCor_Click);
            // 
            // FrmTesteBotoesRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 219);
            this.Controls.Add(this.LblCor);
            this.Controls.Add(this.RdoVermelho);
            this.Controls.Add(this.RdoVerde);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmTesteBotoesRadio";
            this.Text = "Exemplo Botões de Rádio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RdoVerde;
        private System.Windows.Forms.RadioButton RdoVermelho;
        private System.Windows.Forms.Label LblCor;
    }
}


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
            this.RdoVerde.Location = new System.Drawing.Point(59, 46);
            this.RdoVerde.Name = "RdoVerde";
            this.RdoVerde.Size = new System.Drawing.Size(53, 17);
            this.RdoVerde.TabIndex = 0;
            this.RdoVerde.TabStop = true;
            this.RdoVerde.Text = "Verde";
            this.RdoVerde.UseVisualStyleBackColor = true;
            this.RdoVerde.CheckedChanged += new System.EventHandler(this.RdoVerde_CheckedChanged);
            // 
            // RdoVermelho
            // 
            this.RdoVermelho.AutoSize = true;
            this.RdoVermelho.Location = new System.Drawing.Point(253, 46);
            this.RdoVermelho.Name = "RdoVermelho";
            this.RdoVermelho.Size = new System.Drawing.Size(69, 17);
            this.RdoVermelho.TabIndex = 1;
            this.RdoVermelho.Text = "Vermelho";
            this.RdoVermelho.UseVisualStyleBackColor = true;
            this.RdoVermelho.CheckedChanged += new System.EventHandler(this.RdoVermelho_CheckedChanged);
            // 
            // LblCor
            // 
            this.LblCor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblCor.Location = new System.Drawing.Point(59, 114);
            this.LblCor.Name = "LblCor";
            this.LblCor.Size = new System.Drawing.Size(279, 23);
            this.LblCor.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 178);
            this.Controls.Add(this.LblCor);
            this.Controls.Add(this.RdoVermelho);
            this.Controls.Add(this.RdoVerde);
            this.Name = "Form1";
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


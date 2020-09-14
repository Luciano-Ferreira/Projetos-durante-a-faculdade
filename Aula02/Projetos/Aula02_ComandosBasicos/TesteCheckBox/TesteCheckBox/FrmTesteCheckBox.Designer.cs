namespace TesteCheckBox
{
    partial class FrmTesteCheckBox
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
            this.LstListaOpcoes = new System.Windows.Forms.ListBox();
            this.ChkOpcaoUm = new System.Windows.Forms.CheckBox();
            this.ChkOpcaoDois = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // LstListaOpcoes
            // 
            this.LstListaOpcoes.FormattingEnabled = true;
            this.LstListaOpcoes.Location = new System.Drawing.Point(43, 108);
            this.LstListaOpcoes.Name = "LstListaOpcoes";
            this.LstListaOpcoes.Size = new System.Drawing.Size(282, 95);
            this.LstListaOpcoes.TabIndex = 0;
            // 
            // ChkOpcaoUm
            // 
            this.ChkOpcaoUm.AutoSize = true;
            this.ChkOpcaoUm.Location = new System.Drawing.Point(43, 57);
            this.ChkOpcaoUm.Name = "ChkOpcaoUm";
            this.ChkOpcaoUm.Size = new System.Drawing.Size(67, 17);
            this.ChkOpcaoUm.TabIndex = 1;
            this.ChkOpcaoUm.Text = "Opcao 1";
            this.ChkOpcaoUm.UseVisualStyleBackColor = true;
            this.ChkOpcaoUm.CheckedChanged += new System.EventHandler(this.ChkOpcaoUm_CheckedChanged);
            // 
            // ChkOpcaoDois
            // 
            this.ChkOpcaoDois.AutoSize = true;
            this.ChkOpcaoDois.Location = new System.Drawing.Point(245, 57);
            this.ChkOpcaoDois.Name = "ChkOpcaoDois";
            this.ChkOpcaoDois.Size = new System.Drawing.Size(80, 17);
            this.ChkOpcaoDois.TabIndex = 2;
            this.ChkOpcaoDois.Text = "checkBox2";
            this.ChkOpcaoDois.UseVisualStyleBackColor = true;
            this.ChkOpcaoDois.CheckedChanged += new System.EventHandler(this.ChkOpcaoDois_CheckedChanged);
            // 
            // FrmTesteCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 249);
            this.Controls.Add(this.ChkOpcaoDois);
            this.Controls.Add(this.ChkOpcaoUm);
            this.Controls.Add(this.LstListaOpcoes);
            this.Name = "FrmTesteCheckBox";
            this.Text = "Teste Check Box";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstListaOpcoes;
        private System.Windows.Forms.CheckBox ChkOpcaoUm;
        private System.Windows.Forms.CheckBox ChkOpcaoDois;
    }
}


namespace ComboBox
{
    partial class FrmTesteComboBox
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
            this.CboListaOpcoes = new System.Windows.Forms.ComboBox();
            this.LblOpcaoSelecionada = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CboListaOpcoes
            // 
            this.CboListaOpcoes.FormattingEnabled = true;
            this.CboListaOpcoes.Items.AddRange(new object[] {
            "Opcao 1",
            "Opcao 2",
            "Opcao 3",
            "Opcao 4"});
            this.CboListaOpcoes.Location = new System.Drawing.Point(35, 32);
            this.CboListaOpcoes.Name = "CboListaOpcoes";
            this.CboListaOpcoes.Size = new System.Drawing.Size(161, 21);
            this.CboListaOpcoes.TabIndex = 0;
            this.CboListaOpcoes.SelectedIndexChanged += new System.EventHandler(this.CboListaOpcoes_SelectedIndexChanged);
            // 
            // LblOpcaoSelecionada
            // 
            this.LblOpcaoSelecionada.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblOpcaoSelecionada.Location = new System.Drawing.Point(35, 88);
            this.LblOpcaoSelecionada.Name = "LblOpcaoSelecionada";
            this.LblOpcaoSelecionada.Size = new System.Drawing.Size(161, 23);
            this.LblOpcaoSelecionada.TabIndex = 1;
            // 
            // FrmTesteComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 145);
            this.Controls.Add(this.LblOpcaoSelecionada);
            this.Controls.Add(this.CboListaOpcoes);
            this.Name = "FrmTesteComboBox";
            this.Text = "Teste Combo Box";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CboListaOpcoes;
        private System.Windows.Forms.Label LblOpcaoSelecionada;
    }
}


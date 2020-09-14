namespace ListBox
{
    partial class FrmTesteListBox
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
            this.LsbLista = new System.Windows.Forms.ListBox();
            this.TxtTexto = new System.Windows.Forms.TextBox();
            this.BtnTesteListBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LsbLista
            // 
            this.LsbLista.FormattingEnabled = true;
            this.LsbLista.Location = new System.Drawing.Point(44, 104);
            this.LsbLista.Name = "LsbLista";
            this.LsbLista.Size = new System.Drawing.Size(298, 95);
            this.LsbLista.TabIndex = 0;
            // 
            // TxtTexto
            // 
            this.TxtTexto.Location = new System.Drawing.Point(44, 52);
            this.TxtTexto.Name = "TxtTexto";
            this.TxtTexto.Size = new System.Drawing.Size(210, 20);
            this.TxtTexto.TabIndex = 1;
            this.TxtTexto.Text = "Texto de Exemplo";
            // 
            // BtnTesteListBox
            // 
            this.BtnTesteListBox.Location = new System.Drawing.Point(267, 52);
            this.BtnTesteListBox.Name = "BtnTesteListBox";
            this.BtnTesteListBox.Size = new System.Drawing.Size(75, 23);
            this.BtnTesteListBox.TabIndex = 2;
            this.BtnTesteListBox.Text = "Adicionar";
            this.BtnTesteListBox.UseVisualStyleBackColor = true;
            this.BtnTesteListBox.Click += new System.EventHandler(this.BtnTesteListBox_Click);
            // 
            // FrmTesteListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 223);
            this.Controls.Add(this.BtnTesteListBox);
            this.Controls.Add(this.TxtTexto);
            this.Controls.Add(this.LsbLista);
            this.Name = "FrmTesteListBox";
            this.Text = "Teste List Box";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LsbLista;
        private System.Windows.Forms.TextBox TxtTexto;
        private System.Windows.Forms.Button BtnTesteListBox;
    }
}


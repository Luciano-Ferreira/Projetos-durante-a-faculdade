namespace Transacao
{
    partial class FrmTransacao
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
            this.BtnExecutarTransacaoOK = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.BtnExecutarTransacaoFalha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnExecutarTransacaoOK
            // 
            this.BtnExecutarTransacaoOK.Location = new System.Drawing.Point(21, 30);
            this.BtnExecutarTransacaoOK.Name = "BtnExecutarTransacaoOK";
            this.BtnExecutarTransacaoOK.Size = new System.Drawing.Size(133, 23);
            this.BtnExecutarTransacaoOK.TabIndex = 0;
            this.BtnExecutarTransacaoOK.Text = "Transacao OK";
            this.BtnExecutarTransacaoOK.UseVisualStyleBackColor = true;
            this.BtnExecutarTransacaoOK.Click += new System.EventHandler(this.BtnExecutarTransacaoOK_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.lblStatus.BackColor = System.Drawing.Color.Black;
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Yellow;
            this.lblStatus.Location = new System.Drawing.Point(21, 84);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(545, 48);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnExecutarTransacaoFalha
            // 
            this.BtnExecutarTransacaoFalha.Location = new System.Drawing.Point(433, 30);
            this.BtnExecutarTransacaoFalha.Name = "BtnExecutarTransacaoFalha";
            this.BtnExecutarTransacaoFalha.Size = new System.Drawing.Size(133, 23);
            this.BtnExecutarTransacaoFalha.TabIndex = 2;
            this.BtnExecutarTransacaoFalha.Text = "Transacao FALHA";
            this.BtnExecutarTransacaoFalha.UseVisualStyleBackColor = true;
            this.BtnExecutarTransacaoFalha.Click += new System.EventHandler(this.BtnExecutarTransacaoFalha_Click);
            // 
            // FrmTransacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 141);
            this.Controls.Add(this.BtnExecutarTransacaoFalha);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.BtnExecutarTransacaoOK);
            this.Name = "FrmTransacao";
            this.Text = "Transaçao Banco";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnExecutarTransacaoOK;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button BtnExecutarTransacaoFalha;
    }
}


namespace Timer01
{
    partial class FrmTimer01
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
            this.components = new System.ComponentModel.Container();
            this.TmTemporizadorRelogio = new System.Windows.Forms.Timer(this.components);
            this.lblDataHora = new System.Windows.Forms.Label();
            this.BtnIniciarRelogio = new System.Windows.Forms.Button();
            this.BtnPararRelogio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TmTemporizadorRelogio
            // 
            this.TmTemporizadorRelogio.Tick += new System.EventHandler(this.TmTemporizadorRelogio_Tick);
            // 
            // lblDataHora
            // 
            this.lblDataHora.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDataHora.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDataHora.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataHora.ForeColor = System.Drawing.Color.Yellow;
            this.lblDataHora.Location = new System.Drawing.Point(169, 28);
            this.lblDataHora.Name = "lblDataHora";
            this.lblDataHora.Size = new System.Drawing.Size(150, 41);
            this.lblDataHora.TabIndex = 0;
            this.lblDataHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnIniciarRelogio
            // 
            this.BtnIniciarRelogio.Location = new System.Drawing.Point(62, 96);
            this.BtnIniciarRelogio.Name = "BtnIniciarRelogio";
            this.BtnIniciarRelogio.Size = new System.Drawing.Size(137, 23);
            this.BtnIniciarRelogio.TabIndex = 1;
            this.BtnIniciarRelogio.Text = "Iniciar Relogio";
            this.BtnIniciarRelogio.UseVisualStyleBackColor = true;
            this.BtnIniciarRelogio.Click += new System.EventHandler(this.BtnIniciarRelogio_Click);
            // 
            // BtnPararRelogio
            // 
            this.BtnPararRelogio.Location = new System.Drawing.Point(294, 96);
            this.BtnPararRelogio.Name = "BtnPararRelogio";
            this.BtnPararRelogio.Size = new System.Drawing.Size(122, 23);
            this.BtnPararRelogio.TabIndex = 2;
            this.BtnPararRelogio.Text = "Parar Relogio";
            this.BtnPararRelogio.UseVisualStyleBackColor = true;
            this.BtnPararRelogio.Click += new System.EventHandler(this.BtnPararRelogio_Click);
            // 
            // FrmTimer01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 140);
            this.Controls.Add(this.BtnPararRelogio);
            this.Controls.Add(this.BtnIniciarRelogio);
            this.Controls.Add(this.lblDataHora);
            this.Name = "FrmTimer01";
            this.Text = "Exemplo Timer";
            this.Load += new System.EventHandler(this.FrmTimer01_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer TmTemporizadorRelogio;
        private System.Windows.Forms.Label lblDataHora;
        private System.Windows.Forms.Button BtnIniciarRelogio;
        private System.Windows.Forms.Button BtnPararRelogio;
    }
}


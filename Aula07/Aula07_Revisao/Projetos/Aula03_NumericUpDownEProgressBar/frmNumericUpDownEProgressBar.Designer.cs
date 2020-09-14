namespace NA019_NumericUpDownEProgressBar
{
    partial class frmNumericUpDownEProgressBar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbBarraDeProgresso = new System.Windows.Forms.ProgressBar();
            this.nupContador = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nupContador)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBarraDeProgresso
            // 
            this.pbBarraDeProgresso.Location = new System.Drawing.Point(24, 34);
            this.pbBarraDeProgresso.Name = "pbBarraDeProgresso";
            this.pbBarraDeProgresso.Size = new System.Drawing.Size(235, 23);
            this.pbBarraDeProgresso.TabIndex = 0;
            // 
            // nupContador
            // 
            this.nupContador.Location = new System.Drawing.Point(289, 34);
            this.nupContador.Name = "nupContador";
            this.nupContador.Size = new System.Drawing.Size(58, 20);
            this.nupContador.TabIndex = 1;
            this.nupContador.ValueChanged += new System.EventHandler(this.nupContador_ValueChanged);
            // 
            // frmNumericUpDownEProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 77);
            this.Controls.Add(this.nupContador);
            this.Controls.Add(this.pbBarraDeProgresso);
            this.Name = "frmNumericUpDownEProgressBar";
            this.Text = "Exemplo Usando Barra de Progresso e Contador";
            ((System.ComponentModel.ISupportInitialize)(this.nupContador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbBarraDeProgresso;
        private System.Windows.Forms.NumericUpDown nupContador;
    }
}


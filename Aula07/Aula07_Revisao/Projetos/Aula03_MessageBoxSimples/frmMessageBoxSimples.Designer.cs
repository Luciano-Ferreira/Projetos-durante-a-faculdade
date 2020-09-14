namespace NA006_MessageBoxSimples
{
    partial class frmMessageBoxSimples
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
            this.btnMensageBoxSimples = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMensageBoxSimples
            // 
            this.btnMensageBoxSimples.Location = new System.Drawing.Point(139, 34);
            this.btnMensageBoxSimples.Name = "btnMensageBoxSimples";
            this.btnMensageBoxSimples.Size = new System.Drawing.Size(136, 59);
            this.btnMensageBoxSimples.TabIndex = 0;
            this.btnMensageBoxSimples.Text = "Mostrando Mensagem ao Usuário";
            this.btnMensageBoxSimples.UseVisualStyleBackColor = true;
            this.btnMensageBoxSimples.Click += new System.EventHandler(this.btnMensageBoxSimples_Click);
            // 
            // frmMessageBoxSimples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 121);
            this.Controls.Add(this.btnMensageBoxSimples);
            this.Name = "frmMessageBoxSimples";
            this.Text = "Exemplo Exibindo um Message Box";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMensageBoxSimples;
    }
}


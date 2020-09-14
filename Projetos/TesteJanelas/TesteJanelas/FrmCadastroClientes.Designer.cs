namespace TesteJanelas
{
    partial class FrmCadastroClientes
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnSalvarClientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nome";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(65, 10);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 22);
            this.txtNome.TabIndex = 1;
            // 
            // btnSalvarClientes
            // 
            this.btnSalvarClientes.Location = new System.Drawing.Point(90, 38);
            this.btnSalvarClientes.Name = "btnSalvarClientes";
            this.btnSalvarClientes.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarClientes.TabIndex = 2;
            this.btnSalvarClientes.Text = "Salvar";
            this.btnSalvarClientes.UseVisualStyleBackColor = true;
            this.btnSalvarClientes.Click += new System.EventHandler(this.BtnSalvarClientes_Click);
            // 
            // FrmCadastroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalvarClientes);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblName);
            this.Name = "FrmCadastroClientes";
            this.Text = "FrmCadastroClientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnSalvarClientes;
    }
}
namespace NA022_ComboBox
{
    partial class frmComboBox
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
            this.cboListaUm = new System.Windows.Forms.ComboBox();
            this.btnSetaSelecionado = new System.Windows.Forms.Button();
            this.cboListaDois = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cboListaUm
            // 
            this.cboListaUm.FormattingEnabled = true;
            this.cboListaUm.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cboListaUm.Location = new System.Drawing.Point(34, 57);
            this.cboListaUm.Name = "cboListaUm";
            this.cboListaUm.Size = new System.Drawing.Size(131, 21);
            this.cboListaUm.TabIndex = 0;
            // 
            // btnSetaSelecionado
            // 
            this.btnSetaSelecionado.Location = new System.Drawing.Point(208, 31);
            this.btnSetaSelecionado.Name = "btnSetaSelecionado";
            this.btnSetaSelecionado.Size = new System.Drawing.Size(75, 23);
            this.btnSetaSelecionado.TabIndex = 1;
            this.btnSetaSelecionado.Text = "-->>";
            this.btnSetaSelecionado.UseVisualStyleBackColor = true;
            this.btnSetaSelecionado.Click += new System.EventHandler(this.btnSetaSelecionado_Click);
            // 
            // cboListaDois
            // 
            this.cboListaDois.FormattingEnabled = true;
            this.cboListaDois.Location = new System.Drawing.Point(328, 57);
            this.cboListaDois.Name = "cboListaDois";
            this.cboListaDois.Size = new System.Drawing.Size(131, 21);
            this.cboListaDois.TabIndex = 2;
            // 
            // frmComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 146);
            this.Controls.Add(this.cboListaDois);
            this.Controls.Add(this.btnSetaSelecionado);
            this.Controls.Add(this.cboListaUm);
            this.Name = "frmComboBox";
            this.Text = "Exemplo Usando Combo Box";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboListaUm;
        private System.Windows.Forms.Button btnSetaSelecionado;
        private System.Windows.Forms.ComboBox cboListaDois;
    }
}


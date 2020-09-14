namespace botoesradio
{
    partial class Form1
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
            this.rdoVerde = new System.Windows.Forms.RadioButton();
            this.rdoVermelho = new System.Windows.Forms.RadioButton();
            this.lblCor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rdoVerde
            // 
            this.rdoVerde.AutoSize = true;
            this.rdoVerde.Checked = true;
            this.rdoVerde.Location = new System.Drawing.Point(69, 91);
            this.rdoVerde.Name = "rdoVerde";
            this.rdoVerde.Size = new System.Drawing.Size(67, 21);
            this.rdoVerde.TabIndex = 0;
            this.rdoVerde.TabStop = true;
            this.rdoVerde.Text = "Verde";
            this.rdoVerde.UseVisualStyleBackColor = true;
            this.rdoVerde.CheckedChanged += new System.EventHandler(this.RdoVerde_CheckedChanged);
            // 
            // rdoVermelho
            // 
            this.rdoVermelho.AutoSize = true;
            this.rdoVermelho.Location = new System.Drawing.Point(355, 91);
            this.rdoVermelho.Name = "rdoVermelho";
            this.rdoVermelho.Size = new System.Drawing.Size(89, 21);
            this.rdoVermelho.TabIndex = 1;
            this.rdoVermelho.Text = "Vermelho";
            this.rdoVermelho.UseVisualStyleBackColor = true;
            this.rdoVermelho.CheckedChanged += new System.EventHandler(this.RdoVermelho_CheckedChanged);
            // 
            // lblCor
            // 
            this.lblCor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCor.Location = new System.Drawing.Point(69, 149);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(375, 23);
            this.lblCor.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 238);
            this.Controls.Add(this.lblCor);
            this.Controls.Add(this.rdoVermelho);
            this.Controls.Add(this.rdoVerde);
            this.Name = "Form1";
            this.Text = "Exemplo Botões Radio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoVerde;
        private System.Windows.Forms.RadioButton rdoVermelho;
        private System.Windows.Forms.Label lblCor;
    }
}


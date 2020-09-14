namespace NA015_MascaraEntradaDados
{
    partial class frmMascaraEntradaDados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMascaraEntradaDados));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoMascaraTelefone = new System.Windows.Forms.RadioButton();
            this.mtxtDadosEntrada = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdoData = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rdoCPF = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rdoCPF);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rdoData);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.mtxtDadosEntrada);
            this.groupBox1.Controls.Add(this.rdoMascaraTelefone);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 232);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entrada de Dados com Máscara";
            // 
            // rdoMascaraTelefone
            // 
            this.rdoMascaraTelefone.AutoSize = true;
            this.rdoMascaraTelefone.Checked = true;
            this.rdoMascaraTelefone.Location = new System.Drawing.Point(95, 96);
            this.rdoMascaraTelefone.Name = "rdoMascaraTelefone";
            this.rdoMascaraTelefone.Size = new System.Drawing.Size(94, 17);
            this.rdoMascaraTelefone.TabIndex = 0;
            this.rdoMascaraTelefone.Text = "(00)0000-0000";
            this.rdoMascaraTelefone.UseVisualStyleBackColor = true;
            this.rdoMascaraTelefone.CheckedChanged += new System.EventHandler(this.rdoMascaraTelefone_CheckedChanged);
            // 
            // mtxtDadosEntrada
            // 
            this.mtxtDadosEntrada.Location = new System.Drawing.Point(15, 29);
            this.mtxtDadosEntrada.Name = "mtxtDadosEntrada";
            this.mtxtDadosEntrada.Size = new System.Drawing.Size(180, 20);
            this.mtxtDadosEntrada.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Telefone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data";
            // 
            // rdoData
            // 
            this.rdoData.AutoSize = true;
            this.rdoData.Location = new System.Drawing.Point(95, 140);
            this.rdoData.Name = "rdoData";
            this.rdoData.Size = new System.Drawing.Size(83, 17);
            this.rdoData.TabIndex = 3;
            this.rdoData.Text = "00/00/0000";
            this.rdoData.UseVisualStyleBackColor = true;
            this.rdoData.CheckedChanged += new System.EventHandler(this.rdoData_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "CPF";
            // 
            // rdoCPF
            // 
            this.rdoCPF.AutoSize = true;
            this.rdoCPF.Location = new System.Drawing.Point(95, 185);
            this.rdoCPF.Name = "rdoCPF";
            this.rdoCPF.Size = new System.Drawing.Size(100, 17);
            this.rdoCPF.TabIndex = 5;
            this.rdoCPF.Text = "000.000.000-00";
            this.rdoCPF.UseVisualStyleBackColor = true;
            this.rdoCPF.CheckedChanged += new System.EventHandler(this.rdoCPF_CheckedChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(250, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(273, 185);
            this.label4.TabIndex = 7;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // frmMascaraEntradaDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(568, 261);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMascaraEntradaDados";
            this.Text = "Exemplo de Máscara de Entrada de Dados";
            this.Load += new System.EventHandler(this.frmMascaraEntradaDados_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtxtDadosEntrada;
        private System.Windows.Forms.RadioButton rdoMascaraTelefone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdoCPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdoData;
        private System.Windows.Forms.Label label4;
    }
}


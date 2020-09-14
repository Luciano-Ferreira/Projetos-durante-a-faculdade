namespace NA024_PopulaComboBoxDadosBanco_Solucao
{
    partial class frmPopulaComboBoxDadosBanco_Solucao
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCodigoCidadeSelecionada = new System.Windows.Forms.Label();
            this.cboMunicipio = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConsultaUF = new System.Windows.Forms.Button();
            this.cboUF = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblCodigoCidadeSelecionada);
            this.groupBox1.Controls.Add(this.cboMunicipio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnConsultaUF);
            this.groupBox1.Controls.Add(this.cboUF);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(765, 204);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados De Cidade";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cod Cidade:";
            // 
            // lblCodigoCidadeSelecionada
            // 
            this.lblCodigoCidadeSelecionada.BackColor = System.Drawing.Color.Black;
            this.lblCodigoCidadeSelecionada.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodigoCidadeSelecionada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoCidadeSelecionada.ForeColor = System.Drawing.Color.Yellow;
            this.lblCodigoCidadeSelecionada.Location = new System.Drawing.Point(121, 144);
            this.lblCodigoCidadeSelecionada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoCidadeSelecionada.Name = "lblCodigoCidadeSelecionada";
            this.lblCodigoCidadeSelecionada.Size = new System.Drawing.Size(185, 28);
            this.lblCodigoCidadeSelecionada.TabIndex = 5;
            this.lblCodigoCidadeSelecionada.Text = "label3";
            this.lblCodigoCidadeSelecionada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCodigoCidadeSelecionada.Click += new System.EventHandler(this.lblCodigoCidadeSelecionada_Click);
            // 
            // cboMunicipio
            // 
            this.cboMunicipio.FormattingEnabled = true;
            this.cboMunicipio.Location = new System.Drawing.Point(121, 86);
            this.cboMunicipio.Margin = new System.Windows.Forms.Padding(4);
            this.cboMunicipio.Name = "cboMunicipio";
            this.cboMunicipio.Size = new System.Drawing.Size(635, 24);
            this.cboMunicipio.TabIndex = 4;
            this.cboMunicipio.SelectedIndexChanged += new System.EventHandler(this.cboMunicipio_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Município";
            // 
            // btnConsultaUF
            // 
            this.btnConsultaUF.Location = new System.Drawing.Point(623, 28);
            this.btnConsultaUF.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultaUF.Name = "btnConsultaUF";
            this.btnConsultaUF.Size = new System.Drawing.Size(135, 28);
            this.btnConsultaUF.TabIndex = 2;
            this.btnConsultaUF.Text = "Consultar UF";
            this.btnConsultaUF.UseVisualStyleBackColor = true;
            this.btnConsultaUF.Click += new System.EventHandler(this.btnConsultaUF_Click);
            // 
            // cboUF
            // 
            this.cboUF.FormattingEnabled = true;
            this.cboUF.Location = new System.Drawing.Point(121, 31);
            this.cboUF.Margin = new System.Windows.Forms.Padding(4);
            this.cboUF.Name = "cboUF";
            this.cboUF.Size = new System.Drawing.Size(247, 24);
            this.cboUF.TabIndex = 1;
            this.cboUF.SelectedIndexChanged += new System.EventHandler(this.cboUF_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "UF";
            // 
            // frmPopulaComboBoxDadosBanco_Solucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 244);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPopulaComboBoxDadosBanco_Solucao";
            this.Text = "Exemplo de Como Popular Combo Box Com informações do Banco de Dados Solucao";
            this.Load += new System.EventHandler(this.frmPopulaComboBoxDadosBanco_Solucao_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConsultaUF;
        private System.Windows.Forms.ComboBox cboUF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMunicipio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCodigoCidadeSelecionada;
        private System.Windows.Forms.Label label3;
    }
}


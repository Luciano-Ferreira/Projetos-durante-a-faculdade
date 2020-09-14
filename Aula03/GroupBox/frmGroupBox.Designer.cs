namespace NA009_GroupBox
{
    partial class frmGroupBox
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoOpcaoUm = new System.Windows.Forms.RadioButton();
            this.rdoOpcaoDois = new System.Windows.Forms.RadioButton();
            this.rdoOpcaoTres = new System.Windows.Forms.RadioButton();
            this.rdoOpcaoQuatro = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoOpcaoDois);
            this.groupBox1.Controls.Add(this.rdoOpcaoUm);
            this.groupBox1.Location = new System.Drawing.Point(56, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grupo de Opções Um";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoOpcaoQuatro);
            this.groupBox2.Controls.Add(this.rdoOpcaoTres);
            this.groupBox2.Location = new System.Drawing.Point(56, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grupo de Opções Dois";
            // 
            // rdoOpcaoUm
            // 
            this.rdoOpcaoUm.AutoSize = true;
            this.rdoOpcaoUm.Checked = true;
            this.rdoOpcaoUm.Location = new System.Drawing.Point(22, 48);
            this.rdoOpcaoUm.Name = "rdoOpcaoUm";
            this.rdoOpcaoUm.Size = new System.Drawing.Size(77, 17);
            this.rdoOpcaoUm.TabIndex = 0;
            this.rdoOpcaoUm.TabStop = true;
            this.rdoOpcaoUm.Text = "Opção UM";
            this.rdoOpcaoUm.UseVisualStyleBackColor = true;
            this.rdoOpcaoUm.CheckedChanged += new System.EventHandler(this.rdoOpcaoUm_CheckedChanged);
            // 
            // rdoOpcaoDois
            // 
            this.rdoOpcaoDois.AutoSize = true;
            this.rdoOpcaoDois.Location = new System.Drawing.Point(162, 48);
            this.rdoOpcaoDois.Name = "rdoOpcaoDois";
            this.rdoOpcaoDois.Size = new System.Drawing.Size(86, 17);
            this.rdoOpcaoDois.TabIndex = 1;
            this.rdoOpcaoDois.Text = "Opção DOIS";
            this.rdoOpcaoDois.UseVisualStyleBackColor = true;
            this.rdoOpcaoDois.CheckedChanged += new System.EventHandler(this.rdoOpcaoDois_CheckedChanged);
            // 
            // rdoOpcaoTres
            // 
            this.rdoOpcaoTres.AutoSize = true;
            this.rdoOpcaoTres.Checked = true;
            this.rdoOpcaoTres.Location = new System.Drawing.Point(22, 41);
            this.rdoOpcaoTres.Name = "rdoOpcaoTres";
            this.rdoOpcaoTres.Size = new System.Drawing.Size(89, 17);
            this.rdoOpcaoTres.TabIndex = 2;
            this.rdoOpcaoTres.TabStop = true;
            this.rdoOpcaoTres.Text = "Opção TRÊS";
            this.rdoOpcaoTres.UseVisualStyleBackColor = true;
            this.rdoOpcaoTres.CheckedChanged += new System.EventHandler(this.rdoOpcaoTres_CheckedChanged);
            // 
            // rdoOpcaoQuatro
            // 
            this.rdoOpcaoQuatro.AutoSize = true;
            this.rdoOpcaoQuatro.Location = new System.Drawing.Point(162, 41);
            this.rdoOpcaoQuatro.Name = "rdoOpcaoQuatro";
            this.rdoOpcaoQuatro.Size = new System.Drawing.Size(107, 17);
            this.rdoOpcaoQuatro.TabIndex = 3;
            this.rdoOpcaoQuatro.TabStop = true;
            this.rdoOpcaoQuatro.Text = "Opção QUADRO";
            this.rdoOpcaoQuatro.UseVisualStyleBackColor = true;
            this.rdoOpcaoQuatro.CheckedChanged += new System.EventHandler(this.rdoOpcaoQUATRO_CheckedChanged);
            // 
            // frmGroupBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 266);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmGroupBox";
            this.Text = "Exemplo Tipico de Uso do Container GroupBox";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoOpcaoDois;
        private System.Windows.Forms.RadioButton rdoOpcaoUm;
        private System.Windows.Forms.RadioButton rdoOpcaoQuatro;
        private System.Windows.Forms.RadioButton rdoOpcaoTres;
    }
}


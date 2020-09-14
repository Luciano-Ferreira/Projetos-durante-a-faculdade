namespace ChamandoProcedure
{
    partial class FrmChamandoProc
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
            this.dgTb01 = new System.Windows.Forms.DataGridView();
            this.BtnChamandoProc = new System.Windows.Forms.Button();
            this.BtnChamandoView1 = new System.Windows.Forms.Button();
            this.BtnChamandoView2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgTb01)).BeginInit();
            this.SuspendLayout();
            // 
            // dgTb01
            // 
            this.dgTb01.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTb01.Location = new System.Drawing.Point(12, 23);
            this.dgTb01.Name = "dgTb01";
            this.dgTb01.Size = new System.Drawing.Size(301, 199);
            this.dgTb01.TabIndex = 0;
            // 
            // BtnChamandoProc
            // 
            this.BtnChamandoProc.Location = new System.Drawing.Point(354, 23);
            this.BtnChamandoProc.Name = "BtnChamandoProc";
            this.BtnChamandoProc.Size = new System.Drawing.Size(127, 23);
            this.BtnChamandoProc.TabIndex = 1;
            this.BtnChamandoProc.Text = "Procedure";
            this.BtnChamandoProc.UseVisualStyleBackColor = true;
            this.BtnChamandoProc.Click += new System.EventHandler(this.BtnChamandoProc_Click);
            // 
            // BtnChamandoView1
            // 
            this.BtnChamandoView1.Location = new System.Drawing.Point(354, 52);
            this.BtnChamandoView1.Name = "BtnChamandoView1";
            this.BtnChamandoView1.Size = new System.Drawing.Size(127, 23);
            this.BtnChamandoView1.TabIndex = 2;
            this.BtnChamandoView1.Text = "View  Ex 1";
            this.BtnChamandoView1.UseVisualStyleBackColor = true;
            this.BtnChamandoView1.Click += new System.EventHandler(this.BtnChamandoView1_Click);
            // 
            // BtnChamandoView2
            // 
            this.BtnChamandoView2.Location = new System.Drawing.Point(354, 81);
            this.BtnChamandoView2.Name = "BtnChamandoView2";
            this.BtnChamandoView2.Size = new System.Drawing.Size(127, 23);
            this.BtnChamandoView2.TabIndex = 3;
            this.BtnChamandoView2.Text = "View  Ex 2";
            this.BtnChamandoView2.UseVisualStyleBackColor = true;
            this.BtnChamandoView2.Click += new System.EventHandler(this.BtnChamandoView2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(354, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Function Como Tabela";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmChamandoProc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 242);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnChamandoView2);
            this.Controls.Add(this.BtnChamandoView1);
            this.Controls.Add(this.BtnChamandoProc);
            this.Controls.Add(this.dgTb01);
            this.Name = "FrmChamandoProc";
            this.Text = "Exemplo Chamando Procedure";
            ((System.ComponentModel.ISupportInitialize)(this.dgTb01)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgTb01;
        private System.Windows.Forms.Button BtnChamandoProc;
        private System.Windows.Forms.Button BtnChamandoView1;
        private System.Windows.Forms.Button BtnChamandoView2;
        private System.Windows.Forms.Button button1;
    }
}


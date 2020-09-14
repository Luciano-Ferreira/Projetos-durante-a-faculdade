namespace NA023_DataGrid
{
    partial class frmDataGrid
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
            this.dgTabelaUm = new System.Windows.Forms.DataGridView();
            this.dtnAdicionarLinhas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgTabelaUm)).BeginInit();
            this.SuspendLayout();
            // 
            // dgTabelaUm
            // 
            this.dgTabelaUm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTabelaUm.Location = new System.Drawing.Point(22, 58);
            this.dgTabelaUm.Name = "dgTabelaUm";
            this.dgTabelaUm.Size = new System.Drawing.Size(409, 177);
            this.dgTabelaUm.TabIndex = 0;
            // 
            // dtnAdicionarLinhas
            // 
            this.dtnAdicionarLinhas.Location = new System.Drawing.Point(22, 12);
            this.dtnAdicionarLinhas.Name = "dtnAdicionarLinhas";
            this.dtnAdicionarLinhas.Size = new System.Drawing.Size(115, 28);
            this.dtnAdicionarLinhas.TabIndex = 1;
            this.dtnAdicionarLinhas.Text = "Adicionar Linhas";
            this.dtnAdicionarLinhas.UseVisualStyleBackColor = true;
            this.dtnAdicionarLinhas.Click += new System.EventHandler(this.dtnAdicionarLinhas_Click);
            // 
            // frmDataGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 251);
            this.Controls.Add(this.dtnAdicionarLinhas);
            this.Controls.Add(this.dgTabelaUm);
            this.Name = "frmDataGrid";
            this.Text = "Exemplo de Uso de DataGrid";
            ((System.ComponentModel.ISupportInitialize)(this.dgTabelaUm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgTabelaUm;
        private System.Windows.Forms.Button dtnAdicionarLinhas;
    }
}


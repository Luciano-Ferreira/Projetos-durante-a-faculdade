namespace CrudSimples01
{
    partial class FrmCrudSimples
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.TxtNome03 = new System.Windows.Forms.TextBox();
            this.TxtID03 = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.TxtID02 = new System.Windows.Forms.TextBox();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.TxtNome01 = new System.Windows.Forms.TextBox();
            this.TxtID01 = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.dgTabela = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTabela)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblStatus);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.BtnUpdate);
            this.groupBox1.Controls.Add(this.TxtNome03);
            this.groupBox1.Controls.Add(this.TxtID03);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.TxtID02);
            this.groupBox1.Controls.Add(this.BtnInsert);
            this.groupBox1.Controls.Add(this.TxtNome);
            this.groupBox1.Controls.Add(this.BtnSelect);
            this.groupBox1.Controls.Add(this.TxtNome01);
            this.groupBox1.Controls.Add(this.TxtID01);
            this.groupBox1.Controls.Add(this.Nome);
            this.groupBox1.Controls.Add(this.Id);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(20, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(732, 635);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CRUD";
            // 
            // LblStatus
            // 
            this.LblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblStatus.Location = new System.Drawing.Point(195, 581);
            this.LblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(479, 32);
            this.LblStatus.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 597);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Status";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(549, 522);
            this.BtnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(100, 28);
            this.BtnUpdate.TabIndex = 14;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // TxtNome03
            // 
            this.TxtNome03.Location = new System.Drawing.Point(324, 527);
            this.TxtNome03.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtNome03.Name = "TxtNome03";
            this.TxtNome03.Size = new System.Drawing.Size(132, 22);
            this.TxtNome03.TabIndex = 13;
            // 
            // TxtID03
            // 
            this.TxtID03.Location = new System.Drawing.Point(71, 526);
            this.TxtID03.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtID03.Name = "TxtID03";
            this.TxtID03.Size = new System.Drawing.Size(132, 22);
            this.TxtID03.TabIndex = 12;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(549, 465);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // TxtID02
            // 
            this.TxtID02.Location = new System.Drawing.Point(71, 469);
            this.TxtID02.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtID02.Name = "TxtID02";
            this.TxtID02.Size = new System.Drawing.Size(132, 22);
            this.TxtID02.TabIndex = 9;
            // 
            // BtnInsert
            // 
            this.BtnInsert.Location = new System.Drawing.Point(549, 405);
            this.BtnInsert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(100, 28);
            this.BtnInsert.TabIndex = 8;
            this.BtnInsert.Text = "Insert";
            this.BtnInsert.UseVisualStyleBackColor = true;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(324, 410);
            this.TxtNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(132, 22);
            this.TxtNome.TabIndex = 7;
            // 
            // BtnSelect
            // 
            this.BtnSelect.Location = new System.Drawing.Point(549, 342);
            this.BtnSelect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(100, 28);
            this.BtnSelect.TabIndex = 5;
            this.BtnSelect.Text = "Select";
            this.BtnSelect.UseVisualStyleBackColor = true;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // TxtNome01
            // 
            this.TxtNome01.Location = new System.Drawing.Point(324, 347);
            this.TxtNome01.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtNome01.Name = "TxtNome01";
            this.TxtNome01.Size = new System.Drawing.Size(132, 22);
            this.TxtNome01.TabIndex = 4;
            // 
            // TxtID01
            // 
            this.TxtID01.Location = new System.Drawing.Point(71, 346);
            this.TxtID01.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtID01.Name = "TxtID01";
            this.TxtID01.Size = new System.Drawing.Size(132, 22);
            this.TxtID01.TabIndex = 3;
            this.TxtID01.Text = "2";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(360, 297);
            this.Nome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(45, 17);
            this.Nome.TabIndex = 2;
            this.Nome.Text = "Nome";
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(103, 297);
            this.Id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(19, 17);
            this.Id.TabIndex = 1;
            this.Id.Text = "Id";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnConsultar);
            this.groupBox2.Controls.Add(this.dgTabela);
            this.groupBox2.Location = new System.Drawing.Point(39, 49);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(635, 223);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consultar uma Tabela Initeira";
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Location = new System.Drawing.Point(511, 23);
            this.BtnConsultar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(100, 28);
            this.BtnConsultar.TabIndex = 1;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // dgTabela
            // 
            this.dgTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTabela.Location = new System.Drawing.Point(32, 23);
            this.dgTabela.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgTabela.Name = "dgTabela";
            this.dgTabela.RowHeadersWidth = 51;
            this.dgTabela.Size = new System.Drawing.Size(433, 185);
            this.dgTabela.TabIndex = 0;
            // 
            // FrmCrudSimples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 684);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmCrudSimples";
            this.Text = "Exemplo Crud Simples";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgTabela)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.TextBox TxtNome03;
        private System.Windows.Forms.TextBox TxtID03;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox TxtID02;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.TextBox TxtNome01;
        private System.Windows.Forms.TextBox TxtID01;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.DataGridView dgTabela;
    }
}


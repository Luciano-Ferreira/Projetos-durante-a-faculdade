namespace UNIP.POOII.BibliotecaPOOII
{
    partial class frmConsultaAutores
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
            this.dgTodosAutores = new System.Windows.Forms.DataGridView();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgTodosAutores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgTodosAutores
            // 
            this.dgTodosAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTodosAutores.Location = new System.Drawing.Point(12, 32);
            this.dgTodosAutores.Name = "dgTodosAutores";
            this.dgTodosAutores.Size = new System.Drawing.Size(404, 150);
            this.dgTodosAutores.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(341, 206);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmConsultaAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 241);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dgTodosAutores);
            this.Name = "frmConsultaAutores";
            this.Text = "Consultar Autores";
            this.Load += new System.EventHandler(this.frmConsultaAutores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTodosAutores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgTodosAutores;
        private System.Windows.Forms.Button btnOK;
    }
}
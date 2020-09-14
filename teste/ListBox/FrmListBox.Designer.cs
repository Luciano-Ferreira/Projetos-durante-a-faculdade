namespace ListBox
{
    partial class FrmListBox
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
            this.lsbLista = new System.Windows.Forms.ListBox();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.btnListBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsbLista
            // 
            this.lsbLista.FormattingEnabled = true;
            this.lsbLista.ItemHeight = 16;
            this.lsbLista.Location = new System.Drawing.Point(12, 41);
            this.lsbLista.Name = "lsbLista";
            this.lsbLista.Size = new System.Drawing.Size(209, 180);
            this.lsbLista.TabIndex = 0;
            this.lsbLista.SelectedIndexChanged += new System.EventHandler(this.LsbLista_SelectedIndexChanged);
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(12, 12);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(127, 22);
            this.txtTexto.TabIndex = 1;
            this.txtTexto.Text = "Default Text";
            this.txtTexto.TextChanged += new System.EventHandler(this.TxtTexto_TextChanged);
            // 
            // btnListBox
            // 
            this.btnListBox.Location = new System.Drawing.Point(145, 12);
            this.btnListBox.Name = "btnListBox";
            this.btnListBox.Size = new System.Drawing.Size(75, 23);
            this.btnListBox.TabIndex = 2;
            this.btnListBox.Text = "Adicionar";
            this.btnListBox.UseVisualStyleBackColor = true;
            this.btnListBox.Click += new System.EventHandler(this.BtnListBox_Click);
            // 
            // FrmListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 321);
            this.Controls.Add(this.btnListBox);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.lsbLista);
            this.Name = "FrmListBox";
            this.Text = "List Box";
            this.Load += new System.EventHandler(this.FrmListBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbLista;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Button btnListBox;
    }
}


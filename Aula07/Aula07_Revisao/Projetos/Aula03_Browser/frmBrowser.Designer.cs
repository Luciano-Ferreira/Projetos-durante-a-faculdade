namespace NA018_Browser
{
    partial class frmBrowser
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
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChamarSite = new System.Windows.Forms.Button();
            this.wbSite = new System.Windows.Forms.WebBrowser();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(79, 31);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(358, 20);
            this.txtURL.TabIndex = 0;
            this.txtURL.Text = "http://www.unip.br";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL";
            // 
            // btnChamarSite
            // 
            this.btnChamarSite.Location = new System.Drawing.Point(462, 28);
            this.btnChamarSite.Name = "btnChamarSite";
            this.btnChamarSite.Size = new System.Drawing.Size(75, 23);
            this.btnChamarSite.TabIndex = 2;
            this.btnChamarSite.Text = "Chamar Site";
            this.btnChamarSite.UseVisualStyleBackColor = true;
            this.btnChamarSite.Click += new System.EventHandler(this.btnChamarSite_Click);
            // 
            // wbSite
            // 
            this.wbSite.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wbSite.Location = new System.Drawing.Point(16, 101);
            this.wbSite.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbSite.Name = "wbSite";
            this.wbSite.Size = new System.Drawing.Size(521, 227);
            this.wbSite.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(360, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Para algo mais avançado pesquise sobre o webkit";
            // 
            // frmBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 350);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wbSite);
            this.Controls.Add(this.btnChamarSite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtURL);
            this.Name = "frmBrowser";
            this.Text = "Exemplo de Uso do Browser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChamarSite;
        private System.Windows.Forms.WebBrowser wbSite;
        private System.Windows.Forms.Label label2;
    }
}


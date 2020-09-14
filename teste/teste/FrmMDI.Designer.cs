namespace teste
{
    partial class FrmMDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exemploMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chamarSDI01ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chamarSDI02ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exemploMenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(871, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exemploMenuToolStripMenuItem
            // 
            this.exemploMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chamarSDI01ToolStripMenuItem,
            this.chamarSDI02ToolStripMenuItem});
            this.exemploMenuToolStripMenuItem.Name = "exemploMenuToolStripMenuItem";
            this.exemploMenuToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.exemploMenuToolStripMenuItem.Text = "Exemplo menu";
            // 
            // chamarSDI01ToolStripMenuItem
            // 
            this.chamarSDI01ToolStripMenuItem.Name = "chamarSDI01ToolStripMenuItem";
            this.chamarSDI01ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.chamarSDI01ToolStripMenuItem.Text = "Chamar SDI 01";
            this.chamarSDI01ToolStripMenuItem.Click += new System.EventHandler(this.ChamarSDI01ToolStripMenuItem_Click);
            // 
            // chamarSDI02ToolStripMenuItem
            // 
            this.chamarSDI02ToolStripMenuItem.Name = "chamarSDI02ToolStripMenuItem";
            this.chamarSDI02ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.chamarSDI02ToolStripMenuItem.Text = "Chamar SDI 02";
            this.chamarSDI02ToolStripMenuItem.Click += new System.EventHandler(this.ChamarSDI02ToolStripMenuItem_Click);
            // 
            // FrmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMDI";
            this.Text = "Formulario MDI";
            this.Load += new System.EventHandler(this.FrmMDI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exemploMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chamarSDI01ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chamarSDI02ToolStripMenuItem;
    }
}


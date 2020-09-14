namespace DataHora
{
    partial class FrmDataHora
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
            this.dt01 = new System.Windows.Forms.DateTimePicker();
            this.dt02 = new System.Windows.Forms.DateTimePicker();
            this.dt03 = new System.Windows.Forms.DateTimePicker();
            this.dt04 = new System.Windows.Forms.MonthCalendar();
            this.LblDataHora = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dt01
            // 
            this.dt01.Location = new System.Drawing.Point(37, 42);
            this.dt01.Name = "dt01";
            this.dt01.Size = new System.Drawing.Size(227, 20);
            this.dt01.TabIndex = 0;
            this.dt01.ValueChanged += new System.EventHandler(this.dt01_ValueChanged);
            // 
            // dt02
            // 
            this.dt02.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dt02.Location = new System.Drawing.Point(290, 42);
            this.dt02.Name = "dt02";
            this.dt02.ShowUpDown = true;
            this.dt02.Size = new System.Drawing.Size(200, 20);
            this.dt02.TabIndex = 1;
            this.dt02.ValueChanged += new System.EventHandler(this.dt02_ValueChanged);
            // 
            // dt03
            // 
            this.dt03.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt03.Location = new System.Drawing.Point(541, 42);
            this.dt03.Name = "dt03";
            this.dt03.Size = new System.Drawing.Size(200, 20);
            this.dt03.TabIndex = 2;
            this.dt03.ValueChanged += new System.EventHandler(this.dt03_ValueChanged);
            // 
            // dt04
            // 
            this.dt04.Location = new System.Drawing.Point(37, 111);
            this.dt04.Name = "dt04";
            this.dt04.TabIndex = 3;
            this.dt04.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.dt04_DateChanged);
            // 
            // LblDataHora
            // 
            this.LblDataHora.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblDataHora.Location = new System.Drawing.Point(290, 186);
            this.LblDataHora.Name = "LblDataHora";
            this.LblDataHora.Size = new System.Drawing.Size(451, 23);
            this.LblDataHora.TabIndex = 4;
            // 
            // FrmDataHora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 305);
            this.Controls.Add(this.LblDataHora);
            this.Controls.Add(this.dt04);
            this.Controls.Add(this.dt03);
            this.Controls.Add(this.dt02);
            this.Controls.Add(this.dt01);
            this.Name = "FrmDataHora";
            this.Text = "Teste Controles de Data e Hora";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dt01;
        private System.Windows.Forms.DateTimePicker dt02;
        private System.Windows.Forms.DateTimePicker dt03;
        private System.Windows.Forms.MonthCalendar dt04;
        private System.Windows.Forms.Label LblDataHora;
    }
}


namespace DateTime
{
    partial class frmDataHora
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
            this.dt01 = new System.Windows.Forms.DateTimePicker();
            this.dt04 = new System.Windows.Forms.MonthCalendar();
            this.lblDataHora = new System.Windows.Forms.Label();
            this.dt02 = new System.Windows.Forms.DateTimePicker();
            this.dt03 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // dt01
            // 
            this.dt01.Location = new System.Drawing.Point(12, 47);
            this.dt01.Name = "dt01";
            this.dt01.Size = new System.Drawing.Size(270, 22);
            this.dt01.TabIndex = 0;
            this.dt01.ValueChanged += new System.EventHandler(this.Dt01_ValueChanged);
            // 
            // dt04
            // 
            this.dt04.BackColor = System.Drawing.SystemColors.Window;
            this.dt04.ForeColor = System.Drawing.SystemColors.MenuText;
            this.dt04.Location = new System.Drawing.Point(18, 240);
            this.dt04.Name = "dt04";
            this.dt04.TabIndex = 1;
            this.dt04.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Dt04_DateChanged);
            // 
            // lblDataHora
            // 
            this.lblDataHora.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDataHora.Location = new System.Drawing.Point(12, 163);
            this.lblDataHora.Name = "lblDataHora";
            this.lblDataHora.Size = new System.Drawing.Size(440, 23);
            this.lblDataHora.TabIndex = 2;
            // 
            // dt02
            // 
            this.dt02.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dt02.Location = new System.Drawing.Point(289, 46);
            this.dt02.Name = "dt02";
            this.dt02.ShowUpDown = true;
            this.dt02.Size = new System.Drawing.Size(200, 22);
            this.dt02.TabIndex = 3;
            this.dt02.ValueChanged += new System.EventHandler(this.Dt02_ValueChanged);
            // 
            // dt03
            // 
            this.dt03.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt03.Location = new System.Drawing.Point(496, 46);
            this.dt03.Name = "dt03";
            this.dt03.Size = new System.Drawing.Size(200, 22);
            this.dt03.TabIndex = 4;
            this.dt03.ValueChanged += new System.EventHandler(this.DateTimePicker3_ValueChanged);
            // 
            // frmDataHora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(725, 450);
            this.Controls.Add(this.dt03);
            this.Controls.Add(this.dt02);
            this.Controls.Add(this.lblDataHora);
            this.Controls.Add(this.dt04);
            this.Controls.Add(this.dt01);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Name = "frmDataHora";
            this.Text = "Data e Hora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dt01;
        private System.Windows.Forms.MonthCalendar dt04;
        private System.Windows.Forms.Label lblDataHora;
        private System.Windows.Forms.DateTimePicker dt02;
        private System.Windows.Forms.DateTimePicker dt03;
    }
}


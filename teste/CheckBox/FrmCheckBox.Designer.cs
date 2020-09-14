namespace CheckBox
{
    partial class frmCheckBox
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.ckbOne = new System.Windows.Forms.CheckBox();
            this.ckbTwo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(96, 132);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(285, 132);
            this.listBox.TabIndex = 0;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // ckbOne
            // 
            this.ckbOne.AutoSize = true;
            this.ckbOne.Location = new System.Drawing.Point(96, 105);
            this.ckbOne.Name = "ckbOne";
            this.ckbOne.Size = new System.Drawing.Size(100, 21);
            this.ckbOne.TabIndex = 1;
            this.ckbOne.Text = "Option one";
            this.ckbOne.UseVisualStyleBackColor = true;
            this.ckbOne.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // ckbTwo
            // 
            this.ckbTwo.AutoSize = true;
            this.ckbTwo.Location = new System.Drawing.Point(282, 105);
            this.ckbTwo.Name = "ckbTwo";
            this.ckbTwo.Size = new System.Drawing.Size(97, 21);
            this.ckbTwo.TabIndex = 2;
            this.ckbTwo.Text = "Option two";
            this.ckbTwo.UseVisualStyleBackColor = true;
            this.ckbTwo.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // frmCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ckbTwo);
            this.Controls.Add(this.ckbOne);
            this.Controls.Add(this.listBox);
            this.Name = "frmCheckBox";
            this.Text = "Check Box";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.CheckBox ckbOne;
        private System.Windows.Forms.CheckBox ckbTwo;
    }
}


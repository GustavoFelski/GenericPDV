namespace GenericPdv
{
    partial class Teste
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
            this.lbTeste = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTeste
            // 
            this.lbTeste.AutoSize = true;
            this.lbTeste.Location = new System.Drawing.Point(48, 63);
            this.lbTeste.Name = "lbTeste";
            this.lbTeste.Size = new System.Drawing.Size(35, 13);
            this.lbTeste.TabIndex = 0;
            this.lbTeste.Text = "label1";
            // 
            // Teste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 332);
            this.Controls.Add(this.lbTeste);
            this.Name = "Teste";
            this.Text = "Teste";
            this.Load += new System.EventHandler(this.Teste_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTeste;
    }
}
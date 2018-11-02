namespace GenericPdv
{
    partial class AberturaDeCaixaForm
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
            this.txtValorDeApertura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btAbrirCaixa = new System.Windows.Forms.Button();
            this.lbMensagem = new System.Windows.Forms.Label();
            this.btClouse = new System.Windows.Forms.Button();
            this.btVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtValorDeApertura
            // 
            this.txtValorDeApertura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtValorDeApertura.Location = new System.Drawing.Point(51, 56);
            this.txtValorDeApertura.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtValorDeApertura.Name = "txtValorDeApertura";
            this.txtValorDeApertura.Size = new System.Drawing.Size(164, 26);
            this.txtValorDeApertura.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(64, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor de Abertura \r\nde Caixa";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btAbrirCaixa
            // 
            this.btAbrirCaixa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btAbrirCaixa.FlatAppearance.BorderSize = 0;
            this.btAbrirCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAbrirCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btAbrirCaixa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btAbrirCaixa.Location = new System.Drawing.Point(135, 138);
            this.btAbrirCaixa.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btAbrirCaixa.Name = "btAbrirCaixa";
            this.btAbrirCaixa.Size = new System.Drawing.Size(116, 28);
            this.btAbrirCaixa.TabIndex = 1;
            this.btAbrirCaixa.Text = "Abrir Caixa";
            this.btAbrirCaixa.UseVisualStyleBackColor = false;
            this.btAbrirCaixa.Click += new System.EventHandler(this.btAbrirCaixa_Click);
            // 
            // lbMensagem
            // 
            this.lbMensagem.AutoSize = true;
            this.lbMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensagem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbMensagem.Location = new System.Drawing.Point(37, 86);
            this.lbMensagem.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbMensagem.Name = "lbMensagem";
            this.lbMensagem.Size = new System.Drawing.Size(197, 45);
            this.lbMensagem.TabIndex = 3;
            this.lbMensagem.Text = "Este é o seu fundo de caixa atual.\r\nCaso queira altera-lo, basta digitar \r\num nov" +
    "o valor.";
            this.lbMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btClouse
            // 
            this.btClouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btClouse.FlatAppearance.BorderSize = 0;
            this.btClouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btClouse.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btClouse.Location = new System.Drawing.Point(222, 3);
            this.btClouse.Name = "btClouse";
            this.btClouse.Size = new System.Drawing.Size(36, 28);
            this.btClouse.TabIndex = 4;
            this.btClouse.TabStop = false;
            this.btClouse.Text = "X";
            this.btClouse.UseVisualStyleBackColor = true;
            this.btClouse.Click += new System.EventHandler(this.btClouse_Click);
            // 
            // btVoltar
            // 
            this.btVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btVoltar.FlatAppearance.BorderSize = 0;
            this.btVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btVoltar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btVoltar.Location = new System.Drawing.Point(9, 138);
            this.btVoltar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(116, 28);
            this.btVoltar.TabIndex = 5;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = false;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // AberturaDeCaixaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(261, 179);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.btClouse);
            this.Controls.Add(this.lbMensagem);
            this.Controls.Add(this.btAbrirCaixa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValorDeApertura);
            this.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AberturaDeCaixaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AberturaDeCaixaForm";
            this.Load += new System.EventHandler(this.AberturaDeCaixaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValorDeApertura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAbrirCaixa;
        private System.Windows.Forms.Label lbMensagem;
        private System.Windows.Forms.Button btClouse;
        private System.Windows.Forms.Button btVoltar;
    }
}
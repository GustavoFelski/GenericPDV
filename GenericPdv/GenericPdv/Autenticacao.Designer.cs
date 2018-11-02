namespace GenericPdv
{
    partial class Autenticacao
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
            this.Autenticação = new System.Windows.Forms.Label();
            this.btAcessar = new System.Windows.Forms.Button();
            this.textNome = new System.Windows.Forms.TextBox();
            this.btClose = new System.Windows.Forms.Button();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Autenticação
            // 
            this.Autenticação.AutoSize = true;
            this.Autenticação.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Autenticação.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Autenticação.Location = new System.Drawing.Point(12, 9);
            this.Autenticação.Name = "Autenticação";
            this.Autenticação.Size = new System.Drawing.Size(103, 20);
            this.Autenticação.TabIndex = 0;
            this.Autenticação.Text = "Autenticação";
            // 
            // btAcessar
            // 
            this.btAcessar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btAcessar.FlatAppearance.BorderSize = 0;
            this.btAcessar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAcessar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btAcessar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAcessar.Location = new System.Drawing.Point(64, 155);
            this.btAcessar.Name = "btAcessar";
            this.btAcessar.Size = new System.Drawing.Size(110, 44);
            this.btAcessar.TabIndex = 1;
            this.btAcessar.Text = "Acessar";
            this.btAcessar.UseVisualStyleBackColor = false;
            this.btAcessar.Click += new System.EventHandler(this.btAcessar_Click);
            // 
            // textNome
            // 
            this.textNome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNome.Location = new System.Drawing.Point(51, 60);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(145, 26);
            this.textNome.TabIndex = 2;
            this.textNome.Leave += new System.EventHandler(this.textNome_Leave);
            // 
            // btClose
            // 
            this.btClose.FlatAppearance.BorderSize = 0;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btClose.Location = new System.Drawing.Point(205, 3);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(30, 28);
            this.btClose.TabIndex = 3;
            this.btClose.Text = "X";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // textSenha
            // 
            this.textSenha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSenha.Location = new System.Drawing.Point(51, 115);
            this.textSenha.Name = "textSenha";
            this.textSenha.Size = new System.Drawing.Size(145, 26);
            this.textSenha.TabIndex = 4;
            this.textSenha.UseSystemPasswordChar = true;
            this.textSenha.Leave += new System.EventHandler(this.textSenha_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(59, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome de Acesso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(56, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Senha de Acesso";
            // 
            // Autenticacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(239, 210);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textSenha);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.btAcessar);
            this.Controls.Add(this.Autenticação);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Autenticacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autenticacao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Autenticação;
        private System.Windows.Forms.Button btAcessar;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.TextBox textSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
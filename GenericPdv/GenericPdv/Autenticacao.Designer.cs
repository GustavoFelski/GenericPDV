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
            this.btAcessar = new System.Windows.Forms.Button();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btRecuperar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAcessar
            // 
            this.btAcessar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btAcessar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btAcessar.FlatAppearance.BorderSize = 0;
            this.btAcessar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAcessar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btAcessar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAcessar.Location = new System.Drawing.Point(1, 136);
            this.btAcessar.Margin = new System.Windows.Forms.Padding(1);
            this.btAcessar.Name = "btAcessar";
            this.btAcessar.Size = new System.Drawing.Size(237, 36);
            this.btAcessar.TabIndex = 3;
            this.btAcessar.Text = "Acessar";
            this.btAcessar.UseVisualStyleBackColor = false;
            this.btAcessar.Click += new System.EventHandler(this.btAcessar_Click);
            // 
            // textNome
            // 
            this.textNome.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textNome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNome.Location = new System.Drawing.Point(0, 22);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(179, 26);
            this.textNome.TabIndex = 1;
            this.textNome.Leave += new System.EventHandler(this.textNome_Leave);
            // 
            // textSenha
            // 
            this.textSenha.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textSenha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSenha.Location = new System.Drawing.Point(0, 24);
            this.textSenha.Name = "textSenha";
            this.textSenha.Size = new System.Drawing.Size(179, 26);
            this.textSenha.TabIndex = 2;
            this.textSenha.UseSystemPasswordChar = true;
            this.textSenha.Leave += new System.EventHandler(this.textSenha_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(25, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome de Acesso";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(25, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Senha de Acesso";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btRecuperar, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btAcessar, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.90173F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0578F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.07514F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.38728F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(239, 173);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // btRecuperar
            // 
            this.btRecuperar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btRecuperar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btRecuperar.FlatAppearance.BorderSize = 0;
            this.btRecuperar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRecuperar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRecuperar.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btRecuperar.Location = new System.Drawing.Point(1, 103);
            this.btRecuperar.Margin = new System.Windows.Forms.Padding(1);
            this.btRecuperar.Name = "btRecuperar";
            this.btRecuperar.Size = new System.Drawing.Size(237, 31);
            this.btRecuperar.TabIndex = 2;
            this.btRecuperar.TabStop = false;
            this.btRecuperar.Text = "Recuperar senha.";
            this.btRecuperar.UseVisualStyleBackColor = false;
            this.btRecuperar.Click += new System.EventHandler(this.btRecuperar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textNome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(30, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(30, 1, 30, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 48);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textSenha);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(30, 51);
            this.panel2.Margin = new System.Windows.Forms.Padding(30, 1, 30, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(179, 50);
            this.panel2.TabIndex = 1;
            // 
            // Autenticacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(239, 173);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Autenticacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autenticação";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btAcessar;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btRecuperar;
    }
}
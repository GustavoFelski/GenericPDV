namespace GenericPdv
{
    partial class CadastroDeFuncionario
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
            this.btClouse = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mkbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.textBusca = new System.Windows.Forms.TextBox();
            this.BtPesquisar = new System.Windows.Forms.Button();
            this.btDeletar = new System.Windows.Forms.Button();
            this.BtAlterar = new System.Windows.Forms.Button();
            this.BtCancelar = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ckbReset = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbStatus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textAcesso = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbCargo = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btClouse
            // 
            this.btClouse.FlatAppearance.BorderSize = 0;
            this.btClouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClouse.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClouse.Location = new System.Drawing.Point(749, 6);
            this.btClouse.Name = "btClouse";
            this.btClouse.Size = new System.Drawing.Size(31, 26);
            this.btClouse.TabIndex = 21;
            this.btClouse.Text = "X";
            this.btClouse.UseVisualStyleBackColor = true;
            this.btClouse.Click += new System.EventHandler(this.btClouse_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.Location = new System.Drawing.Point(9, 10);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 20;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.mkbTelefone);
            this.groupBox1.Controls.Add(this.textEmail);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textNome);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textId);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 105);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Funcionario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(655, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Telefone";
            // 
            // mkbTelefone
            // 
            this.mkbTelefone.Location = new System.Drawing.Point(658, 79);
            this.mkbTelefone.Mask = "(99) 00000-0000";
            this.mkbTelefone.Name = "mkbTelefone";
            this.mkbTelefone.Size = new System.Drawing.Size(112, 22);
            this.mkbTelefone.TabIndex = 12;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(9, 79);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(371, 22);
            this.textEmail.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "E-mail";
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(81, 37);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(689, 22);
            this.textNome.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome: ";
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(6, 37);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(69, 22);
            this.textId.TabIndex = 6;
            // 
            // textBusca
            // 
            this.textBusca.Location = new System.Drawing.Point(253, 12);
            this.textBusca.Name = "textBusca";
            this.textBusca.Size = new System.Drawing.Size(269, 20);
            this.textBusca.TabIndex = 16;
            // 
            // BtPesquisar
            // 
            this.BtPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtPesquisar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtPesquisar.Location = new System.Drawing.Point(528, 10);
            this.BtPesquisar.Name = "BtPesquisar";
            this.BtPesquisar.Size = new System.Drawing.Size(75, 23);
            this.BtPesquisar.TabIndex = 15;
            this.BtPesquisar.Text = "Pesquisar";
            this.BtPesquisar.UseVisualStyleBackColor = true;
            this.BtPesquisar.Click += new System.EventHandler(this.BtPesquisar_Click);
            // 
            // btDeletar
            // 
            this.btDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDeletar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeletar.Location = new System.Drawing.Point(90, 10);
            this.btDeletar.Name = "btDeletar";
            this.btDeletar.Size = new System.Drawing.Size(75, 23);
            this.btDeletar.TabIndex = 14;
            this.btDeletar.Text = "Deletar";
            this.btDeletar.UseVisualStyleBackColor = true;
            this.btDeletar.Click += new System.EventHandler(this.btDeletar_Click);
            // 
            // BtAlterar
            // 
            this.BtAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtAlterar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAlterar.Location = new System.Drawing.Point(172, 10);
            this.BtAlterar.Name = "BtAlterar";
            this.BtAlterar.Size = new System.Drawing.Size(75, 23);
            this.BtAlterar.TabIndex = 13;
            this.BtAlterar.Text = "Alterar";
            this.BtAlterar.UseVisualStyleBackColor = true;
            this.BtAlterar.Click += new System.EventHandler(this.BtAlterar_Click);
            // 
            // BtCancelar
            // 
            this.BtCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtCancelar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCancelar.Location = new System.Drawing.Point(624, 221);
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtCancelar.TabIndex = 12;
            this.BtCancelar.Text = "Cancelar";
            this.BtCancelar.UseVisualStyleBackColor = true;
            this.BtCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // btNovo
            // 
            this.btNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNovo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovo.Location = new System.Drawing.Point(705, 221);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(75, 23);
            this.btNovo.TabIndex = 11;
            this.btNovo.Text = "Novo";
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ckbReset);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cbbStatus);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textAcesso);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbbCargo);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(431, 96);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações de Acesso";
            // 
            // ckbReset
            // 
            this.ckbReset.AutoSize = true;
            this.ckbReset.Location = new System.Drawing.Point(7, 65);
            this.ckbReset.Name = "ckbReset";
            this.ckbReset.Size = new System.Drawing.Size(325, 21);
            this.ckbReset.TabIndex = 19;
            this.ckbReset.Text = "Resetar a Senha desde usuário no proximo acesso.";
            this.ckbReset.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(283, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Status";
            // 
            // cbbStatus
            // 
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.Items.AddRange(new object[] {
            "Desabilitado",
            "Habilitado"});
            this.cbbStatus.Location = new System.Drawing.Point(286, 33);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(137, 25);
            this.cbbStatus.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(152, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Nome de Acesso";
            // 
            // textAcesso
            // 
            this.textAcesso.Location = new System.Drawing.Point(150, 34);
            this.textAcesso.Name = "textAcesso";
            this.textAcesso.Size = new System.Drawing.Size(130, 22);
            this.textAcesso.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Cargo";
            // 
            // cbbCargo
            // 
            this.cbbCargo.FormattingEnabled = true;
            this.cbbCargo.Items.AddRange(new object[] {
            "Administrador",
            "Caixa",
            "Estoquista"});
            this.cbbCargo.Location = new System.Drawing.Point(7, 34);
            this.cbbCargo.Name = "cbbCargo";
            this.cbbCargo.Size = new System.Drawing.Size(137, 25);
            this.cbbCargo.TabIndex = 0;
            // 
            // CadastroDeFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 257);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btClouse);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBusca);
            this.Controls.Add(this.BtPesquisar);
            this.Controls.Add(this.btDeletar);
            this.Controls.Add(this.BtAlterar);
            this.Controls.Add(this.BtCancelar);
            this.Controls.Add(this.btNovo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastroDeFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroDeFuncionario";
            this.Load += new System.EventHandler(this.CadastroDeFuncionario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btClouse;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.TextBox textBusca;
        private System.Windows.Forms.Button BtPesquisar;
        private System.Windows.Forms.Button btDeletar;
        private System.Windows.Forms.Button BtAlterar;
        private System.Windows.Forms.Button BtCancelar;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mkbTelefone;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textAcesso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbCargo;
        private System.Windows.Forms.ComboBox cbbStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox ckbReset;
    }
}
namespace GenericPdv
{
    partial class Sangria
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
            this.txtCaixa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNovoValor = new System.Windows.Forms.TextBox();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbData = new System.Windows.Forms.Label();
            this.lbMensagem = new System.Windows.Forms.Label();
            this.btConfirmar = new System.Windows.Forms.Button();
            this.btClouse = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCaixa
            // 
            this.txtCaixa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtCaixa.Location = new System.Drawing.Point(11, 30);
            this.txtCaixa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCaixa.Name = "txtCaixa";
            this.txtCaixa.ReadOnly = true;
            this.txtCaixa.Size = new System.Drawing.Size(161, 26);
            this.txtCaixa.TabIndex = 0;
            this.txtCaixa.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor de Caixa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(8, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor de Substuição";
            // 
            // txtNovoValor
            // 
            this.txtNovoValor.Location = new System.Drawing.Point(11, 94);
            this.txtNovoValor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNovoValor.Name = "txtNovoValor";
            this.txtNovoValor.Size = new System.Drawing.Size(161, 26);
            this.txtNovoValor.TabIndex = 2;
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbUsuario.Location = new System.Drawing.Point(175, 32);
            this.lbUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(64, 20);
            this.lbUsuario.TabIndex = 4;
            this.lbUsuario.Text = "Usuario";
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbData.Location = new System.Drawing.Point(175, 69);
            this.lbData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(44, 20);
            this.lbData.TabIndex = 5;
            this.lbData.Text = "Data";
            // 
            // lbMensagem
            // 
            this.lbMensagem.AutoSize = true;
            this.lbMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbMensagem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbMensagem.Location = new System.Drawing.Point(8, 129);
            this.lbMensagem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMensagem.Name = "lbMensagem";
            this.lbMensagem.Size = new System.Drawing.Size(51, 20);
            this.lbMensagem.TabIndex = 6;
            this.lbMensagem.Text = "label5";
            this.lbMensagem.Visible = false;
            // 
            // btConfirmar
            // 
            this.btConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btConfirmar.FlatAppearance.BorderSize = 0;
            this.btConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConfirmar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btConfirmar.Location = new System.Drawing.Point(162, 167);
            this.btConfirmar.Margin = new System.Windows.Forms.Padding(2);
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.Size = new System.Drawing.Size(94, 36);
            this.btConfirmar.TabIndex = 7;
            this.btConfirmar.Text = "Confirmar";
            this.btConfirmar.UseVisualStyleBackColor = false;
            this.btConfirmar.Click += new System.EventHandler(this.btConfirmar_Click);
            // 
            // btClouse
            // 
            this.btClouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btClouse.FlatAppearance.BorderSize = 0;
            this.btClouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btClouse.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btClouse.Location = new System.Drawing.Point(233, 1);
            this.btClouse.Margin = new System.Windows.Forms.Padding(2);
            this.btClouse.Name = "btClouse";
            this.btClouse.Size = new System.Drawing.Size(33, 32);
            this.btClouse.TabIndex = 8;
            this.btClouse.Text = "X";
            this.btClouse.UseVisualStyleBackColor = true;
            this.btClouse.Click += new System.EventHandler(this.btClouse_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btCancelar.FlatAppearance.BorderSize = 0;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btCancelar.Location = new System.Drawing.Point(11, 167);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(94, 36);
            this.btCancelar.TabIndex = 9;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // Sangria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(267, 214);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btClouse);
            this.Controls.Add(this.btConfirmar);
            this.Controls.Add(this.lbMensagem);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNovoValor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCaixa);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Sangria";
            this.Text = "Sangria";
            this.Load += new System.EventHandler(this.Sangria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCaixa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNovoValor;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Label lbMensagem;
        private System.Windows.Forms.Button btConfirmar;
        private System.Windows.Forms.Button btClouse;
        private System.Windows.Forms.Button btCancelar;
    }
}
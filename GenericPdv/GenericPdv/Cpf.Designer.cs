﻿namespace GenericPdv
{
    partial class Cpf
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
            this.mkbCpf = new System.Windows.Forms.MaskedTextBox();
            this.btValidar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCPF = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btClouse
            // 
            this.btClouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btClouse.FlatAppearance.BorderSize = 0;
            this.btClouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btClouse.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btClouse.Location = new System.Drawing.Point(236, 4);
            this.btClouse.Name = "btClouse";
            this.btClouse.Size = new System.Drawing.Size(36, 31);
            this.btClouse.TabIndex = 5;
            this.btClouse.Text = "X";
            this.btClouse.UseVisualStyleBackColor = true;
            this.btClouse.Click += new System.EventHandler(this.btClouse_Click);
            // 
            // mkbCpf
            // 
            this.mkbCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.mkbCpf.Location = new System.Drawing.Point(12, 43);
            this.mkbCpf.Mask = "999,999,999-99";
            this.mkbCpf.Name = "mkbCpf";
            this.mkbCpf.Size = new System.Drawing.Size(179, 30);
            this.mkbCpf.TabIndex = 6;
            this.mkbCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btValidar
            // 
            this.btValidar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btValidar.FlatAppearance.BorderSize = 0;
            this.btValidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btValidar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btValidar.Location = new System.Drawing.Point(197, 41);
            this.btValidar.Name = "btValidar";
            this.btValidar.Size = new System.Drawing.Size(75, 32);
            this.btValidar.TabIndex = 7;
            this.btValidar.Text = "Ok";
            this.btValidar.UseVisualStyleBackColor = false;
            this.btValidar.Click += new System.EventHandler(this.btValidar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "CPF";
            // 
            // lbCPF
            // 
            this.lbCPF.AutoSize = true;
            this.lbCPF.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCPF.Location = new System.Drawing.Point(12, 83);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(51, 20);
            this.lbCPF.TabIndex = 9;
            this.lbCPF.Text = "label2";
            this.lbCPF.Visible = false;
            // 
            // Cpf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(281, 111);
            this.Controls.Add(this.lbCPF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btValidar);
            this.Controls.Add(this.mkbCpf);
            this.Controls.Add(this.btClouse);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Cpf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CPF";
            this.Load += new System.EventHandler(this.Cpf_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btClouse;
        private System.Windows.Forms.MaskedTextBox mkbCpf;
        private System.Windows.Forms.Button btValidar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCPF;
    }
}
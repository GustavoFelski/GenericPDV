namespace GenericPdv
{
    partial class Alerta
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
            this.btOk = new System.Windows.Forms.Button();
            this.lbMensagem = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btOk
            // 
            this.btOk.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btOk.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btOk.FlatAppearance.BorderSize = 0;
            this.btOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btOk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btOk.Location = new System.Drawing.Point(0, 106);
            this.btOk.Margin = new System.Windows.Forms.Padding(1);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(224, 36);
            this.btOk.TabIndex = 2;
            this.btOk.Text = "Ok";
            this.btOk.UseVisualStyleBackColor = false;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // lbMensagem
            // 
            this.lbMensagem.AutoSize = true;
            this.lbMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensagem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbMensagem.Location = new System.Drawing.Point(3, 0);
            this.lbMensagem.Name = "lbMensagem";
            this.lbMensagem.Padding = new System.Windows.Forms.Padding(10);
            this.lbMensagem.Size = new System.Drawing.Size(135, 36);
            this.lbMensagem.TabIndex = 7;
            this.lbMensagem.Text = "Senha de Acesso";
            this.lbMensagem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lbMensagem);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(224, 142);
            this.flowLayoutPanel1.TabIndex = 8;
            this.flowLayoutPanel1.Enter += new System.EventHandler(this.btOk_Click);
            // 
            // Alerta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(224, 142);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Alerta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alerta";
            this.Load += new System.EventHandler(this.Alerta_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Label lbMensagem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
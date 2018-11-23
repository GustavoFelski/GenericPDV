namespace GenericPdv
{
    partial class Confirmacao
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btOk
            // 
            this.btOk.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btOk.Dock = System.Windows.Forms.DockStyle.Right;
            this.btOk.FlatAppearance.BorderSize = 0;
            this.btOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btOk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btOk.Location = new System.Drawing.Point(113, 0);
            this.btOk.Margin = new System.Windows.Forms.Padding(1);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(111, 36);
            this.btOk.TabIndex = 2;
            this.btOk.Text = "Ok";
            this.btOk.UseVisualStyleBackColor = false;
            // 
            // lbMensagem
            // 
            this.lbMensagem.AutoSize = true;
            this.lbMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensagem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbMensagem.Location = new System.Drawing.Point(6, 3);
            this.lbMensagem.Name = "lbMensagem";
            this.lbMensagem.Size = new System.Drawing.Size(115, 16);
            this.lbMensagem.TabIndex = 7;
            this.lbMensagem.Text = "Senha de Acesso";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btCancelar);
            this.panel1.Controls.Add(this.btOk);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 36);
            this.panel1.TabIndex = 8;
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.btCancelar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btCancelar.FlatAppearance.BorderSize = 0;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCancelar.Location = new System.Drawing.Point(-2, 0);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(1);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(115, 36);
            this.btCancelar.TabIndex = 3;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(60, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Confirmar ação?";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.81554F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.18447F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(224, 103);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 75);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 28);
            this.panel2.TabIndex = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lbMensagem);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(224, 75);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // Confirmacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(224, 142);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Confirmacao";
            this.Text = "Confirmação";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Label lbMensagem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
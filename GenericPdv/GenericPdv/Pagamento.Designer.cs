namespace GenericPdv
{
    partial class Pagamento
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
            System.Windows.Forms.ColumnHeader ColId;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pagamento));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTroco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValorPagar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValorCompra = new System.Windows.Forms.TextBox();
            this.btCancelarCompra = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btFecharCompra = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.listPagamento = new System.Windows.Forms.ListView();
            this.col1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.teste = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.btDescontoTotal = new System.Windows.Forms.Button();
            this.ckbTipoDesconto = new System.Windows.Forms.CheckBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btDinheiro = new System.Windows.Forms.Button();
            this.btDebito = new System.Windows.Forms.Button();
            this.btCredito = new System.Windows.Forms.Button();
            ColId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // ColId
            // 
            ColId.Text = "Id";
            ColId.Width = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.74133F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.25867F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(626, 306);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btCancelarCompra);
            this.panel1.Controls.Add(this.btLimpar);
            this.panel1.Controls.Add(this.btFecharCompra);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(289, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 300);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtTroco);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtValorPagar);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtValorCompra);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(334, 236);
            this.panel3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(136, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Troco";
            // 
            // txtTroco
            // 
            this.txtTroco.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTroco.Enabled = false;
            this.txtTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTroco.ForeColor = System.Drawing.Color.White;
            this.txtTroco.Location = new System.Drawing.Point(2, 194);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.ReadOnly = true;
            this.txtTroco.Size = new System.Drawing.Size(328, 47);
            this.txtTroco.TabIndex = 4;
            this.txtTroco.TabStop = false;
            this.txtTroco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(114, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor Pago";
            // 
            // txtValorPagar
            // 
            this.txtValorPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorPagar.Location = new System.Drawing.Point(2, 114);
            this.txtValorPagar.Name = "txtValorPagar";
            this.txtValorPagar.Size = new System.Drawing.Size(328, 47);
            this.txtValorPagar.TabIndex = 2;
            this.txtValorPagar.TabStop = false;
            this.txtValorPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValorPagar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorPagar_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(92, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor da Compra";
            // 
            // txtValorCompra
            // 
            this.txtValorCompra.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtValorCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorCompra.Location = new System.Drawing.Point(2, 34);
            this.txtValorCompra.Name = "txtValorCompra";
            this.txtValorCompra.ReadOnly = true;
            this.txtValorCompra.Size = new System.Drawing.Size(328, 47);
            this.txtValorCompra.TabIndex = 0;
            this.txtValorCompra.TabStop = false;
            this.txtValorCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btCancelarCompra
            // 
            this.btCancelarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.btCancelarCompra.FlatAppearance.BorderSize = 0;
            this.btCancelarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelarCompra.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btCancelarCompra.Location = new System.Drawing.Point(116, 249);
            this.btCancelarCompra.Name = "btCancelarCompra";
            this.btCancelarCompra.Size = new System.Drawing.Size(103, 42);
            this.btCancelarCompra.TabIndex = 2;
            this.btCancelarCompra.TabStop = false;
            this.btCancelarCompra.Text = "Cancelar Compra (F4)";
            this.btCancelarCompra.UseVisualStyleBackColor = false;
            this.btCancelarCompra.Click += new System.EventHandler(this.btCancelarCompra_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btLimpar.FlatAppearance.BorderSize = 0;
            this.btLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btLimpar.Location = new System.Drawing.Point(8, 249);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(103, 42);
            this.btLimpar.TabIndex = 1;
            this.btLimpar.TabStop = false;
            this.btLimpar.Text = "Limpar (Esc)";
            this.btLimpar.UseVisualStyleBackColor = false;
            this.btLimpar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // btFecharCompra
            // 
            this.btFecharCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btFecharCompra.FlatAppearance.BorderSize = 0;
            this.btFecharCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFecharCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFecharCompra.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btFecharCompra.Location = new System.Drawing.Point(224, 249);
            this.btFecharCompra.Name = "btFecharCompra";
            this.btFecharCompra.Size = new System.Drawing.Size(103, 42);
            this.btFecharCompra.TabIndex = 0;
            this.btFecharCompra.TabStop = false;
            this.btFecharCompra.Text = "Fechar Venda (F5)";
            this.btFecharCompra.UseVisualStyleBackColor = false;
            this.btFecharCompra.Click += new System.EventHandler(this.btFecharCompra_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 300);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(9, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Formas de Pagamento";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.listPagamento, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(280, 300);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // listPagamento
            // 
            this.listPagamento.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            ColId,
            this.col1,
            this.col2,
            this.col3,
            this.teste});
            this.listPagamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listPagamento.Location = new System.Drawing.Point(3, 88);
            this.listPagamento.Name = "listPagamento";
            this.listPagamento.Size = new System.Drawing.Size(274, 159);
            this.listPagamento.TabIndex = 12;
            this.listPagamento.TabStop = false;
            this.listPagamento.UseCompatibleStateImageBehavior = false;
            this.listPagamento.View = System.Windows.Forms.View.Details;
            // 
            // col1
            // 
            this.col1.Text = "Forma";
            this.col1.Width = 74;
            // 
            // col2
            // 
            this.col2.Text = "Quantidade Paga";
            this.col2.Width = 118;
            // 
            // col3
            // 
            this.col3.Text = "Troco";
            this.col3.Width = 78;
            // 
            // teste
            // 
            this.teste.Text = "teste";
            this.teste.Width = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btDescontoTotal);
            this.panel4.Controls.Add(this.ckbTipoDesconto);
            this.panel4.Controls.Add(this.txtDesconto);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 250);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(280, 50);
            this.panel4.TabIndex = 0;
            // 
            // btDescontoTotal
            // 
            this.btDescontoTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btDescontoTotal.FlatAppearance.BorderSize = 0;
            this.btDescontoTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDescontoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDescontoTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btDescontoTotal.Location = new System.Drawing.Point(3, 3);
            this.btDescontoTotal.Name = "btDescontoTotal";
            this.btDescontoTotal.Size = new System.Drawing.Size(101, 44);
            this.btDescontoTotal.TabIndex = 3;
            this.btDescontoTotal.Text = "Desconto Total (F6)";
            this.btDescontoTotal.UseVisualStyleBackColor = false;
            this.btDescontoTotal.Click += new System.EventHandler(this.btDescontoTotal_Click);
            this.btDescontoTotal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btDescontoTotal_KeyDown);
            // 
            // ckbTipoDesconto
            // 
            this.ckbTipoDesconto.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckbTipoDesconto.AutoSize = true;
            this.ckbTipoDesconto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ckbTipoDesconto.FlatAppearance.BorderSize = 0;
            this.ckbTipoDesconto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckbTipoDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbTipoDesconto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ckbTipoDesconto.Location = new System.Drawing.Point(214, 5);
            this.ckbTipoDesconto.MinimumSize = new System.Drawing.Size(20, 20);
            this.ckbTipoDesconto.Name = "ckbTipoDesconto";
            this.ckbTipoDesconto.Size = new System.Drawing.Size(59, 41);
            this.ckbTipoDesconto.TabIndex = 2;
            this.ckbTipoDesconto.Text = "R$";
            this.ckbTipoDesconto.UseVisualStyleBackColor = false;
            this.ckbTipoDesconto.CheckedChanged += new System.EventHandler(this.ckbTipoDesconto_CheckedChanged);
            // 
            // txtDesconto
            // 
            this.txtDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesconto.Location = new System.Drawing.Point(108, 2);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(100, 47);
            this.txtDesconto.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btDinheiro);
            this.panel5.Controls.Add(this.btDebito);
            this.panel5.Controls.Add(this.btCredito);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(280, 85);
            this.panel5.TabIndex = 13;
            // 
            // btDinheiro
            // 
            this.btDinheiro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btDinheiro.FlatAppearance.BorderSize = 0;
            this.btDinheiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDinheiro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btDinheiro.Location = new System.Drawing.Point(3, 34);
            this.btDinheiro.Name = "btDinheiro";
            this.btDinheiro.Size = new System.Drawing.Size(86, 44);
            this.btDinheiro.TabIndex = 0;
            this.btDinheiro.TabStop = false;
            this.btDinheiro.Text = "Dinheiro (F1)";
            this.btDinheiro.UseVisualStyleBackColor = false;
            this.btDinheiro.Click += new System.EventHandler(this.btDinheiro_Click);
            // 
            // btDebito
            // 
            this.btDebito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btDebito.FlatAppearance.BorderSize = 0;
            this.btDebito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDebito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDebito.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btDebito.Location = new System.Drawing.Point(187, 34);
            this.btDebito.Name = "btDebito";
            this.btDebito.Size = new System.Drawing.Size(86, 44);
            this.btDebito.TabIndex = 2;
            this.btDebito.TabStop = false;
            this.btDebito.Text = "Cartão de\r\nDébito (F3)";
            this.btDebito.UseVisualStyleBackColor = false;
            this.btDebito.Click += new System.EventHandler(this.btDebito_Click);
            // 
            // btCredito
            // 
            this.btCredito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btCredito.FlatAppearance.BorderSize = 0;
            this.btCredito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCredito.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btCredito.Location = new System.Drawing.Point(95, 34);
            this.btCredito.Name = "btCredito";
            this.btCredito.Size = new System.Drawing.Size(86, 44);
            this.btCredito.TabIndex = 1;
            this.btCredito.TabStop = false;
            this.btCredito.Text = "Cartão de\r\nCrédito (F2)";
            this.btCredito.UseVisualStyleBackColor = false;
            this.btCredito.Click += new System.EventHandler(this.btCredito_Click);
            // 
            // Pagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(626, 306);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Pagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagamento";
            this.Load += new System.EventHandler(this.Pagamento_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pagamento_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTroco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValorPagar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValorCompra;
        private System.Windows.Forms.Button btCancelarCompra;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btFecharCompra;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Button btDescontoTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btDebito;
        private System.Windows.Forms.Button btCredito;
        private System.Windows.Forms.Button btDinheiro;
        private System.Windows.Forms.CheckBox ckbTipoDesconto;
        private System.Windows.Forms.ListView listPagamento;
        private System.Windows.Forms.ColumnHeader col1;
        private System.Windows.Forms.ColumnHeader col2;
        private System.Windows.Forms.ColumnHeader col3;
        private System.Windows.Forms.ColumnHeader teste;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}
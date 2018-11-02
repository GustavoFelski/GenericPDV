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
            this.Voltar = new System.Windows.Forms.Button();
            this.btFecharCompra = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listPagamento = new System.Windows.Forms.ListView();
            this.col1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.teste = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ckbTipoDesconto = new System.Windows.Forms.CheckBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.btDescontoTotal = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btDebito = new System.Windows.Forms.Button();
            this.btCredito = new System.Windows.Forms.Button();
            this.btDinheiro = new System.Windows.Forms.Button();
            ColId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel1.Controls.Add(this.Voltar);
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
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 24);
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
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
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
            this.txtValorPagar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorPagar_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 24);
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
            // 
            // btCancelarCompra
            // 
            this.btCancelarCompra.Location = new System.Drawing.Point(116, 249);
            this.btCancelarCompra.Name = "btCancelarCompra";
            this.btCancelarCompra.Size = new System.Drawing.Size(103, 42);
            this.btCancelarCompra.TabIndex = 2;
            this.btCancelarCompra.Text = "Cancelar Compra";
            this.btCancelarCompra.UseVisualStyleBackColor = true;
            // 
            // Voltar
            // 
            this.Voltar.Location = new System.Drawing.Point(8, 249);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(103, 42);
            this.Voltar.TabIndex = 1;
            this.Voltar.Text = "Voltar ";
            this.Voltar.UseVisualStyleBackColor = true;
            this.Voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // btFecharCompra
            // 
            this.btFecharCompra.Location = new System.Drawing.Point(224, 249);
            this.btFecharCompra.Name = "btFecharCompra";
            this.btFecharCompra.Size = new System.Drawing.Size(103, 42);
            this.btFecharCompra.TabIndex = 0;
            this.btFecharCompra.Text = "Fechar Venda";
            this.btFecharCompra.UseVisualStyleBackColor = true;
            this.btFecharCompra.Click += new System.EventHandler(this.btFecharCompra_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listPagamento);
            this.panel2.Controls.Add(this.ckbTipoDesconto);
            this.panel2.Controls.Add(this.txtDesconto);
            this.panel2.Controls.Add(this.btDescontoTotal);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btDebito);
            this.panel2.Controls.Add(this.btCredito);
            this.panel2.Controls.Add(this.btDinheiro);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 300);
            this.panel2.TabIndex = 1;
            // 
            // listPagamento
            // 
            this.listPagamento.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            ColId,
            this.col1,
            this.col2,
            this.col3,
            this.teste});
            this.listPagamento.Location = new System.Drawing.Point(9, 87);
            this.listPagamento.Name = "listPagamento";
            this.listPagamento.Size = new System.Drawing.Size(268, 97);
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
            this.col3.Width = 71;
            // 
            // teste
            // 
            this.teste.Text = "teste";
            this.teste.Width = 0;
            // 
            // ckbTipoDesconto
            // 
            this.ckbTipoDesconto.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckbTipoDesconto.AutoSize = true;
            this.ckbTipoDesconto.Location = new System.Drawing.Point(222, 205);
            this.ckbTipoDesconto.MinimumSize = new System.Drawing.Size(20, 20);
            this.ckbTipoDesconto.Name = "ckbTipoDesconto";
            this.ckbTipoDesconto.Size = new System.Drawing.Size(31, 23);
            this.ckbTipoDesconto.TabIndex = 11;
            this.ckbTipoDesconto.Text = "R$";
            this.ckbTipoDesconto.UseVisualStyleBackColor = true;
            this.ckbTipoDesconto.CheckedChanged += new System.EventHandler(this.ckbTipoDesconto_CheckedChanged);
            // 
            // txtDesconto
            // 
            this.txtDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesconto.Location = new System.Drawing.Point(116, 204);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(100, 47);
            this.txtDesconto.TabIndex = 10;
            // 
            // btDescontoTotal
            // 
            this.btDescontoTotal.Location = new System.Drawing.Point(9, 205);
            this.btDescontoTotal.Name = "btDescontoTotal";
            this.btDescontoTotal.Size = new System.Drawing.Size(101, 44);
            this.btDescontoTotal.TabIndex = 8;
            this.btDescontoTotal.Text = "Desconto Total";
            this.btDescontoTotal.UseVisualStyleBackColor = true;
            this.btDescontoTotal.Click += new System.EventHandler(this.btDescontoTotal_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Formas de Pagamento";
            // 
            // btDebito
            // 
            this.btDebito.Location = new System.Drawing.Point(193, 37);
            this.btDebito.Name = "btDebito";
            this.btDebito.Size = new System.Drawing.Size(86, 44);
            this.btDebito.TabIndex = 2;
            this.btDebito.Text = "Cartão de\r\nDébito";
            this.btDebito.UseVisualStyleBackColor = true;
            this.btDebito.Click += new System.EventHandler(this.btDebito_Click);
            // 
            // btCredito
            // 
            this.btCredito.Location = new System.Drawing.Point(101, 37);
            this.btCredito.Name = "btCredito";
            this.btCredito.Size = new System.Drawing.Size(86, 44);
            this.btCredito.TabIndex = 1;
            this.btCredito.Text = "Cartão de\r\nCrédito";
            this.btCredito.UseVisualStyleBackColor = true;
            this.btCredito.Click += new System.EventHandler(this.btCredito_Click);
            // 
            // btDinheiro
            // 
            this.btDinheiro.Location = new System.Drawing.Point(9, 37);
            this.btDinheiro.Name = "btDinheiro";
            this.btDinheiro.Size = new System.Drawing.Size(86, 44);
            this.btDinheiro.TabIndex = 0;
            this.btDinheiro.Text = "Dinheiro";
            this.btDinheiro.UseVisualStyleBackColor = true;
            this.btDinheiro.Click += new System.EventHandler(this.btDinheiro_Click);
            // 
            // Pagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 306);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Pagamento";
            this.Text = "Pagamento";
            this.Load += new System.EventHandler(this.Pagamento_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Button Voltar;
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
    }
}
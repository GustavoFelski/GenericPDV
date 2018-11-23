namespace GenericPdv
{
    partial class FechamentoDeCaixaForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FechamentoDeCaixaForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btExporte = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPeriodo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.nada = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dinheiro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.credito = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.debito = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.abertura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fechamentoSangriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetGnPdv = new GenericPdv.DataSetGnPdv();
            this.fechamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fechamentoSangriaTableAdapter = new GenericPdv.DataSetGnPdvTableAdapters.FechamentoSangriaTableAdapter();
            this.idVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcNomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendDataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PagValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagamentoTipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sancria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idFuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sangriaValorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sangDataTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fechamentoSangriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGnPdv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechamentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btExporte, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.listView1, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 158F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 489);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btExporte
            // 
            this.btExporte.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btExporte.Dock = System.Windows.Forms.DockStyle.Right;
            this.btExporte.FlatAppearance.BorderSize = 0;
            this.btExporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btExporte.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btExporte.Location = new System.Drawing.Point(639, 446);
            this.btExporte.Margin = new System.Windows.Forms.Padding(1);
            this.btExporte.Name = "btExporte";
            this.btExporte.Size = new System.Drawing.Size(160, 42);
            this.btExporte.TabIndex = 5;
            this.btExporte.Text = "Exportar para PDF";
            this.btExporte.UseVisualStyleBackColor = false;
            this.btExporte.Click += new System.EventHandler(this.btExporte_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFuncionarioDataGridViewTextBoxColumn,
            this.sangriaValorDataGridViewTextBoxColumn,
            this.sangDataTimeDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.fechamentoSangriaBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.Location = new System.Drawing.Point(10, 252);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(780, 135);
            this.dataGridView2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVenda,
            this.funcNomeDataGridViewTextBoxColumn,
            this.valorCompraDataGridViewTextBoxColumn,
            this.vendDataDataGridViewTextBoxColumn,
            this.PagValor,
            this.pagamentoTipoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fechamentoBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.Location = new System.Drawing.Point(10, 53);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(780, 152);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbPeriodo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 50);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Relatório de Vendas";
            // 
            // lbPeriodo
            // 
            this.lbPeriodo.AutoSize = true;
            this.lbPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPeriodo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbPeriodo.Location = new System.Drawing.Point(9, 29);
            this.lbPeriodo.Name = "lbPeriodo";
            this.lbPeriodo.Size = new System.Drawing.Size(46, 18);
            this.lbPeriodo.TabIndex = 0;
            this.lbPeriodo.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 208);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 41);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(9, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Relatório de Sangria";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nada,
            this.dinheiro,
            this.credito,
            this.debito,
            this.total,
            this.abertura,
            this.sancria});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(3, 393);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(794, 49);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // nada
            // 
            this.nada.Text = "";
            this.nada.Width = 50;
            // 
            // dinheiro
            // 
            this.dinheiro.Text = "Valor em Caixa";
            this.dinheiro.Width = 98;
            // 
            // credito
            // 
            this.credito.Text = "Total em Crédito";
            this.credito.Width = 104;
            // 
            // debito
            // 
            this.debito.Text = "Total em Débito";
            this.debito.Width = 99;
            // 
            // total
            // 
            this.total.Text = "Valor Total";
            this.total.Width = 105;
            // 
            // abertura
            // 
            this.abertura.Text = "Abertura de Caixa";
            this.abertura.Width = 105;
            // 
            // fechamentoSangriaBindingSource
            // 
            this.fechamentoSangriaBindingSource.DataMember = "FechamentoSangria";
            this.fechamentoSangriaBindingSource.DataSource = this.dataSetGnPdv;
            // 
            // dataSetGnPdv
            // 
            this.dataSetGnPdv.DataSetName = "DataSetGnPdv";
            this.dataSetGnPdv.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fechamentoBindingSource
            // 
            this.fechamentoBindingSource.DataMember = "Fechamento";
            this.fechamentoBindingSource.DataSource = this.dataSetGnPdv;
            // 
            // fechamentoSangriaTableAdapter
            // 
            this.fechamentoSangriaTableAdapter.ClearBeforeFill = true;
            // 
            // idVenda
            // 
            this.idVenda.DataPropertyName = "idVenda";
            this.idVenda.HeaderText = "Cod Venda";
            this.idVenda.Name = "idVenda";
            this.idVenda.ReadOnly = true;
            // 
            // funcNomeDataGridViewTextBoxColumn
            // 
            this.funcNomeDataGridViewTextBoxColumn.DataPropertyName = "funcNome";
            this.funcNomeDataGridViewTextBoxColumn.HeaderText = "Vendedor";
            this.funcNomeDataGridViewTextBoxColumn.Name = "funcNomeDataGridViewTextBoxColumn";
            this.funcNomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorCompraDataGridViewTextBoxColumn
            // 
            this.valorCompraDataGridViewTextBoxColumn.DataPropertyName = "valorCompra";
            this.valorCompraDataGridViewTextBoxColumn.HeaderText = "Valor da Venda";
            this.valorCompraDataGridViewTextBoxColumn.Name = "valorCompraDataGridViewTextBoxColumn";
            this.valorCompraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vendDataDataGridViewTextBoxColumn
            // 
            this.vendDataDataGridViewTextBoxColumn.DataPropertyName = "vendData";
            this.vendDataDataGridViewTextBoxColumn.HeaderText = "Data e Hora";
            this.vendDataDataGridViewTextBoxColumn.Name = "vendDataDataGridViewTextBoxColumn";
            this.vendDataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // PagValor
            // 
            this.PagValor.DataPropertyName = "PagValor";
            this.PagValor.HeaderText = "Valor Pago";
            this.PagValor.Name = "PagValor";
            this.PagValor.ReadOnly = true;
            // 
            // pagamentoTipoDataGridViewTextBoxColumn
            // 
            this.pagamentoTipoDataGridViewTextBoxColumn.DataPropertyName = "pagamentoTipo";
            this.pagamentoTipoDataGridViewTextBoxColumn.HeaderText = "Metodo de Pagamento";
            this.pagamentoTipoDataGridViewTextBoxColumn.Name = "pagamentoTipoDataGridViewTextBoxColumn";
            this.pagamentoTipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sancria
            // 
            this.sancria.Text = "Total de Sangria";
            this.sancria.Width = 106;
            // 
            // idFuncionarioDataGridViewTextBoxColumn
            // 
            this.idFuncionarioDataGridViewTextBoxColumn.DataPropertyName = "funcNome";
            this.idFuncionarioDataGridViewTextBoxColumn.HeaderText = "Funcionario";
            this.idFuncionarioDataGridViewTextBoxColumn.Name = "idFuncionarioDataGridViewTextBoxColumn";
            // 
            // sangriaValorDataGridViewTextBoxColumn
            // 
            this.sangriaValorDataGridViewTextBoxColumn.DataPropertyName = "sangriaValor";
            this.sangriaValorDataGridViewTextBoxColumn.HeaderText = "Valor Retirado";
            this.sangriaValorDataGridViewTextBoxColumn.Name = "sangriaValorDataGridViewTextBoxColumn";
            // 
            // sangDataTimeDataGridViewTextBoxColumn
            // 
            this.sangDataTimeDataGridViewTextBoxColumn.DataPropertyName = "sangDataTime";
            this.sangDataTimeDataGridViewTextBoxColumn.HeaderText = "Data e Hora";
            this.sangDataTimeDataGridViewTextBoxColumn.Name = "sangDataTimeDataGridViewTextBoxColumn";
            // 
            // FechamentoDeCaixaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(816, 527);
            this.Name = "FechamentoDeCaixaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fechamento de Caixa";
            this.Load += new System.EventHandler(this.FechamentoDeCaixaForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fechamentoSangriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGnPdv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechamentoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPeriodo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btExporte;
        private System.Windows.Forms.BindingSource fechamentoSangriaBindingSource;
        private DataSetGnPdv dataSetGnPdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn caixaValorDinheiroDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fechamentoBindingSource;
        private DataSetGnPdvTableAdapters.FechamentoSangriaTableAdapter fechamentoSangriaTableAdapter;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader nada;
        private System.Windows.Forms.ColumnHeader dinheiro;
        private System.Windows.Forms.ColumnHeader credito;
        private System.Windows.Forms.ColumnHeader debito;
        private System.Windows.Forms.ColumnHeader total;
        private System.Windows.Forms.ColumnHeader abertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcNomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendDataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PagValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagamentoTipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.ColumnHeader sancria;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sangriaValorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sangDataTimeDataGridViewTextBoxColumn;
    }
}
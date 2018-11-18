namespace GenericPdv
{
    partial class RelatorioDeVendas
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btOk = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPeriodo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Col1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PagValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcNomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendDataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagamentoTipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetGnPdv = new GenericPdv.DataSetGnPdv();
            this.fechamentoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fechamentoSangriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fechamentoSangriaTableAdapter = new GenericPdv.DataSetGnPdvTableAdapters.FechamentoSangriaTableAdapter();
            this.fechamentoTableAdapter = new GenericPdv.DataSetGnPdvTableAdapters.FechamentoTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGnPdv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechamentoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechamentoSangriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btOk, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.listView1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 489);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btOk
            // 
            this.btOk.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btOk.Dock = System.Windows.Forms.DockStyle.Right;
            this.btOk.FlatAppearance.BorderSize = 0;
            this.btOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btOk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btOk.Location = new System.Drawing.Point(639, 446);
            this.btOk.Margin = new System.Windows.Forms.Padding(1);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(160, 42);
            this.btOk.TabIndex = 5;
            this.btOk.Text = "Exportar para PDF";
            this.btOk.UseVisualStyleBackColor = false;
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
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 208);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 41);
            this.panel2.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Col1,
            this.Col2,
            this.Col3,
            this.Col5,
            this.Col4});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(10, 393);
            this.listView1.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(780, 49);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Col1
            // 
            this.Col1.Text = "Total em Dinheiro";
            this.Col1.Width = 0;
            // 
            // Col2
            // 
            this.Col2.Text = "Total em Dinheiro";
            this.Col2.Width = 117;
            // 
            // Col3
            // 
            this.Col3.Text = "Total Em Cartão de crédito";
            this.Col3.Width = 157;
            // 
            // Col5
            // 
            this.Col5.Text = "Total Cartão de Débito";
            this.Col5.Width = 138;
            // 
            // Col4
            // 
            this.Col4.Text = "Faturamento Bruto";
            this.Col4.Width = 110;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 50);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 158);
            this.panel3.TabIndex = 6;
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(800, 158);
            this.dataGridView1.TabIndex = 1;
            // 
            // idVenda
            // 
            this.idVenda.DataPropertyName = "idVenda";
            this.idVenda.HeaderText = "Cod Venda";
            this.idVenda.Name = "idVenda";
            this.idVenda.ReadOnly = true;
            // 
            // PagValor
            // 
            this.PagValor.DataPropertyName = "PagValor";
            this.PagValor.HeaderText = "Valor Pago";
            this.PagValor.Name = "PagValor";
            this.PagValor.ReadOnly = true;
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
            // pagamentoTipoDataGridViewTextBoxColumn
            // 
            this.pagamentoTipoDataGridViewTextBoxColumn.DataPropertyName = "pagamentoTipo";
            this.pagamentoTipoDataGridViewTextBoxColumn.HeaderText = "Metodo de Pagamento";
            this.pagamentoTipoDataGridViewTextBoxColumn.Name = "pagamentoTipoDataGridViewTextBoxColumn";
            this.pagamentoTipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechamentoBindingSource
            // 
            this.fechamentoBindingSource.DataMember = "Fechamento";
            this.fechamentoBindingSource.DataSource = this.dataSetGnPdv;
            // 
            // dataSetGnPdv
            // 
            this.dataSetGnPdv.DataSetName = "DataSetGnPdv";
            this.dataSetGnPdv.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fechamentoBindingSource1
            // 
            this.fechamentoBindingSource1.DataMember = "Fechamento";
            this.fechamentoBindingSource1.DataSource = this.dataSetGnPdv;
            // 
            // fechamentoSangriaBindingSource
            // 
            this.fechamentoSangriaBindingSource.DataMember = "FechamentoSangria";
            this.fechamentoSangriaBindingSource.DataSource = this.dataSetGnPdv;
            // 
            // fechamentoSangriaTableAdapter
            // 
            this.fechamentoSangriaTableAdapter.ClearBeforeFill = true;
            // 
            // fechamentoTableAdapter
            // 
            this.fechamentoTableAdapter.ClearBeforeFill = true;
            // 
            // RelatorioDeVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(816, 527);
            this.Name = "RelatorioDeVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fechamento de Caixa";
            this.Load += new System.EventHandler(this.RelatorioDeVendas_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGnPdv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechamentoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechamentoSangriaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPeriodo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.ColumnHeader Col1;
        private System.Windows.Forms.ColumnHeader Col2;
        private System.Windows.Forms.ColumnHeader Col3;
        private System.Windows.Forms.ColumnHeader Col5;
        private System.Windows.Forms.ColumnHeader Col4;
        private System.Windows.Forms.BindingSource fechamentoSangriaBindingSource;
        private DataSetGnPdv dataSetGnPdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn caixaValorDinheiroDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fechamentoBindingSource;
        private DataSetGnPdvTableAdapters.FechamentoSangriaTableAdapter fechamentoSangriaTableAdapter;
        private System.Windows.Forms.BindingSource fechamentoBindingSource1;
        private DataSetGnPdvTableAdapters.FechamentoTableAdapter fechamentoTableAdapter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcNomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendDataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PagValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagamentoTipoDataGridViewTextBoxColumn;
    }
}
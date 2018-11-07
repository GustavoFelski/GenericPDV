namespace GenericPdv
{
    partial class Catalogo
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodCodBarrasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodNomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodMarcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodQuantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodDescontoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodDataInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodDataFimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodStatusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetGnPdv = new GenericPdv.DataSetGnPdv();
            this.produtoTableAdapter = new GenericPdv.DataSetGnPdvTableAdapters.ProdutoTableAdapter();
            this.fillByIdToolStrip = new System.Windows.Forms.ToolStrip();
            this.idToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByIdToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGnPdv)).BeginInit();
            this.fillByIdToolStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProdutoDataGridViewTextBoxColumn,
            this.prodCodBarrasDataGridViewTextBoxColumn,
            this.prodNomeDataGridViewTextBoxColumn,
            this.prodVendaDataGridViewTextBoxColumn,
            this.prodMarcaDataGridViewTextBoxColumn,
            this.prodQuantidadeDataGridViewTextBoxColumn,
            this.prodDescontoDataGridViewTextBoxColumn,
            this.prodDataInicioDataGridViewTextBoxColumn,
            this.prodDataFimDataGridViewTextBoxColumn,
            this.prodStatusDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.produtoBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.Size = new System.Drawing.Size(937, 432);
            this.dataGridView1.TabIndex = 0;
            // 
            // idProdutoDataGridViewTextBoxColumn
            // 
            this.idProdutoDataGridViewTextBoxColumn.DataPropertyName = "idProduto";
            this.idProdutoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.idProdutoDataGridViewTextBoxColumn.Name = "idProdutoDataGridViewTextBoxColumn";
            this.idProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prodCodBarrasDataGridViewTextBoxColumn
            // 
            this.prodCodBarrasDataGridViewTextBoxColumn.DataPropertyName = "prodCodBarras";
            this.prodCodBarrasDataGridViewTextBoxColumn.HeaderText = "Código de Barras";
            this.prodCodBarrasDataGridViewTextBoxColumn.Name = "prodCodBarrasDataGridViewTextBoxColumn";
            this.prodCodBarrasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prodNomeDataGridViewTextBoxColumn
            // 
            this.prodNomeDataGridViewTextBoxColumn.DataPropertyName = "prodNome";
            this.prodNomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.prodNomeDataGridViewTextBoxColumn.Name = "prodNomeDataGridViewTextBoxColumn";
            this.prodNomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prodVendaDataGridViewTextBoxColumn
            // 
            this.prodVendaDataGridViewTextBoxColumn.DataPropertyName = "prodVenda";
            this.prodVendaDataGridViewTextBoxColumn.HeaderText = "Preço de Venda";
            this.prodVendaDataGridViewTextBoxColumn.Name = "prodVendaDataGridViewTextBoxColumn";
            this.prodVendaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prodMarcaDataGridViewTextBoxColumn
            // 
            this.prodMarcaDataGridViewTextBoxColumn.DataPropertyName = "prodMarca";
            this.prodMarcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.prodMarcaDataGridViewTextBoxColumn.Name = "prodMarcaDataGridViewTextBoxColumn";
            this.prodMarcaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prodQuantidadeDataGridViewTextBoxColumn
            // 
            this.prodQuantidadeDataGridViewTextBoxColumn.DataPropertyName = "prodQuantidade";
            this.prodQuantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.prodQuantidadeDataGridViewTextBoxColumn.Name = "prodQuantidadeDataGridViewTextBoxColumn";
            this.prodQuantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prodDescontoDataGridViewTextBoxColumn
            // 
            this.prodDescontoDataGridViewTextBoxColumn.DataPropertyName = "prodDesconto";
            this.prodDescontoDataGridViewTextBoxColumn.HeaderText = "Preço de Oferta";
            this.prodDescontoDataGridViewTextBoxColumn.Name = "prodDescontoDataGridViewTextBoxColumn";
            this.prodDescontoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prodDataInicioDataGridViewTextBoxColumn
            // 
            this.prodDataInicioDataGridViewTextBoxColumn.DataPropertyName = "prodDataInicio";
            this.prodDataInicioDataGridViewTextBoxColumn.HeaderText = "Data de Inicio";
            this.prodDataInicioDataGridViewTextBoxColumn.Name = "prodDataInicioDataGridViewTextBoxColumn";
            this.prodDataInicioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prodDataFimDataGridViewTextBoxColumn
            // 
            this.prodDataFimDataGridViewTextBoxColumn.DataPropertyName = "prodDataFim";
            this.prodDataFimDataGridViewTextBoxColumn.HeaderText = "Data Final";
            this.prodDataFimDataGridViewTextBoxColumn.Name = "prodDataFimDataGridViewTextBoxColumn";
            this.prodDataFimDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prodStatusDataGridViewCheckBoxColumn
            // 
            this.prodStatusDataGridViewCheckBoxColumn.DataPropertyName = "prodStatus";
            this.prodStatusDataGridViewCheckBoxColumn.HeaderText = "Status";
            this.prodStatusDataGridViewCheckBoxColumn.Name = "prodStatusDataGridViewCheckBoxColumn";
            this.prodStatusDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "Produto";
            this.produtoBindingSource.DataSource = this.dataSetGnPdv;
            // 
            // dataSetGnPdv
            // 
            this.dataSetGnPdv.DataSetName = "DataSetGnPdv";
            this.dataSetGnPdv.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // fillByIdToolStrip
            // 
            this.fillByIdToolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fillByIdToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.idToolStripTextBox,
            this.fillByIdToolStripButton});
            this.fillByIdToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByIdToolStrip.Name = "fillByIdToolStrip";
            this.fillByIdToolStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fillByIdToolStrip.Size = new System.Drawing.Size(943, 29);
            this.fillByIdToolStrip.TabIndex = 1;
            this.fillByIdToolStrip.Text = "fillByIdToolStrip";
            // 
            // idToolStripTextBox
            // 
            this.idToolStripTextBox.Name = "idToolStripTextBox";
            this.idToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByIdToolStripButton
            // 
            this.fillByIdToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByIdToolStripButton.Name = "fillByIdToolStripButton";
            this.fillByIdToolStripButton.Size = new System.Drawing.Size(61, 22);
            this.fillByIdToolStripButton.Text = "Pesquisar";
            this.fillByIdToolStripButton.Click += new System.EventHandler(this.fillByIdToolStripButton_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(88, 22);
            this.toolStripLabel1.Text = "Pesquisa por ID";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.fillByIdToolStrip, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.20985F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.79015F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(943, 467);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // Catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Catalogo";
            this.Size = new System.Drawing.Size(943, 467);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGnPdv)).EndInit();
            this.fillByIdToolStrip.ResumeLayout(false);
            this.fillByIdToolStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodCodBarrasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodNomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodVendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodMarcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodQuantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodDescontoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodDataInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodDataFimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn prodStatusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private DataSetGnPdv dataSetGnPdv;
        private DataSetGnPdvTableAdapters.ProdutoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.ToolStrip fillByIdToolStrip;
        private System.Windows.Forms.ToolStripTextBox idToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByIdToolStripButton;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

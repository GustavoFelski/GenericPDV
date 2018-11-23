namespace GenericPdv
{
    partial class consulta
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
            this.txtPesquisaNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btConsulta = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPesquisaId = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodCodBarrasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodNomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodMarcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodDescontoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodDataFimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetGnPdv = new GenericPdv.DataSetGnPdv();
            this.produtoTableAdapter = new GenericPdv.DataSetGnPdvTableAdapters.ProdutoTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGnPdv)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPesquisaNome
            // 
            this.txtPesquisaNome.Location = new System.Drawing.Point(373, 4);
            this.txtPesquisaNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtPesquisaNome.Name = "txtPesquisaNome";
            this.txtPesquisaNome.Size = new System.Drawing.Size(265, 26);
            this.txtPesquisaNome.TabIndex = 2;
            this.txtPesquisaNome.TextChanged += new System.EventHandler(this.txtPesquisaNome_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pesquisa Código";
            // 
            // btConsulta
            // 
            this.btConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btConsulta.Dock = System.Windows.Forms.DockStyle.Right;
            this.btConsulta.FlatAppearance.BorderSize = 0;
            this.btConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btConsulta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btConsulta.Location = new System.Drawing.Point(642, 0);
            this.btConsulta.Margin = new System.Windows.Forms.Padding(2);
            this.btConsulta.Name = "btConsulta";
            this.btConsulta.Size = new System.Drawing.Size(98, 35);
            this.btConsulta.TabIndex = 3;
            this.btConsulta.Text = "Consultar";
            this.btConsulta.UseVisualStyleBackColor = false;
            this.btConsulta.Click += new System.EventHandler(this.btConsulta_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.48718F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.51282F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(740, 184);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtPesquisaId);
            this.panel1.Controls.Add(this.btConsulta);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtPesquisaNome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 35);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(249, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pesquisa Nome";
            // 
            // txtPesquisaId
            // 
            this.txtPesquisaId.Location = new System.Drawing.Point(140, 5);
            this.txtPesquisaId.Margin = new System.Windows.Forms.Padding(2);
            this.txtPesquisaId.Name = "txtPesquisaId";
            this.txtPesquisaId.Size = new System.Drawing.Size(103, 26);
            this.txtPesquisaId.TabIndex = 1;
            this.txtPesquisaId.TextChanged += new System.EventHandler(this.txtPesquisaId_TextChanged);
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
            this.prodMarcaDataGridViewTextBoxColumn,
            this.prodVendaDataGridViewTextBoxColumn,
            this.prodDescontoDataGridViewTextBoxColumn,
            this.prodDataFimDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.produtoBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(734, 143);
            this.dataGridView1.TabIndex = 1;
            // 
            // idProdutoDataGridViewTextBoxColumn
            // 
            this.idProdutoDataGridViewTextBoxColumn.DataPropertyName = "idProduto";
            this.idProdutoDataGridViewTextBoxColumn.FillWeight = 60F;
            this.idProdutoDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idProdutoDataGridViewTextBoxColumn.Name = "idProdutoDataGridViewTextBoxColumn";
            this.idProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idProdutoDataGridViewTextBoxColumn.Width = 60;
            // 
            // prodCodBarrasDataGridViewTextBoxColumn
            // 
            this.prodCodBarrasDataGridViewTextBoxColumn.DataPropertyName = "prodCodBarras";
            this.prodCodBarrasDataGridViewTextBoxColumn.FillWeight = 110F;
            this.prodCodBarrasDataGridViewTextBoxColumn.HeaderText = "Cód Barras";
            this.prodCodBarrasDataGridViewTextBoxColumn.Name = "prodCodBarrasDataGridViewTextBoxColumn";
            this.prodCodBarrasDataGridViewTextBoxColumn.ReadOnly = true;
            this.prodCodBarrasDataGridViewTextBoxColumn.Width = 110;
            // 
            // prodNomeDataGridViewTextBoxColumn
            // 
            this.prodNomeDataGridViewTextBoxColumn.DataPropertyName = "prodNome";
            this.prodNomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.prodNomeDataGridViewTextBoxColumn.Name = "prodNomeDataGridViewTextBoxColumn";
            this.prodNomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prodMarcaDataGridViewTextBoxColumn
            // 
            this.prodMarcaDataGridViewTextBoxColumn.DataPropertyName = "prodMarca";
            this.prodMarcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.prodMarcaDataGridViewTextBoxColumn.Name = "prodMarcaDataGridViewTextBoxColumn";
            this.prodMarcaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prodVendaDataGridViewTextBoxColumn
            // 
            this.prodVendaDataGridViewTextBoxColumn.DataPropertyName = "prodVenda";
            this.prodVendaDataGridViewTextBoxColumn.HeaderText = "Preço";
            this.prodVendaDataGridViewTextBoxColumn.Name = "prodVendaDataGridViewTextBoxColumn";
            this.prodVendaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prodDescontoDataGridViewTextBoxColumn
            // 
            this.prodDescontoDataGridViewTextBoxColumn.DataPropertyName = "prodDesconto";
            this.prodDescontoDataGridViewTextBoxColumn.HeaderText = "Oferta";
            this.prodDescontoDataGridViewTextBoxColumn.Name = "prodDescontoDataGridViewTextBoxColumn";
            this.prodDescontoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prodDataFimDataGridViewTextBoxColumn
            // 
            this.prodDataFimDataGridViewTextBoxColumn.DataPropertyName = "prodDataFim";
            this.prodDataFimDataGridViewTextBoxColumn.HeaderText = "Limite Oferta";
            this.prodDataFimDataGridViewTextBoxColumn.Name = "prodDataFimDataGridViewTextBoxColumn";
            this.prodDataFimDataGridViewTextBoxColumn.ReadOnly = true;
            this.prodDataFimDataGridViewTextBoxColumn.Width = 120;
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
            // consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(740, 184);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "consulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "consulta";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGnPdv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPesquisaNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btConsulta;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private DataSetGnPdv dataSetGnPdv;
        private DataSetGnPdvTableAdapters.ProdutoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPesquisaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodCodBarrasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodNomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodMarcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodVendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodDescontoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodDataFimDataGridViewTextBoxColumn;
    }
}
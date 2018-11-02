namespace GenericPdv
{
    partial class Admin
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btRelatorio = new System.Windows.Forms.Button();
            this.btCadFuncionario = new System.Windows.Forms.Button();
            this.btImportacao = new System.Windows.Forms.Button();
            this.btCadProdutos = new System.Windows.Forms.Button();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.btCatalogo = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetGnPdv = new GenericPdv.DataSetGnPdv();
            this.produtoTableAdapter = new GenericPdv.DataSetGnPdvTableAdapters.ProdutoTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGnPdv)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.2618F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.7382F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1165, 547);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btRelatorio);
            this.panel1.Controls.Add(this.btCadFuncionario);
            this.panel1.Controls.Add(this.btImportacao);
            this.panel1.Controls.Add(this.btCadProdutos);
            this.panel1.Controls.Add(this.sidePanel);
            this.panel1.Controls.Add(this.btCatalogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 541);
            this.panel1.TabIndex = 0;
            // 
            // btRelatorio
            // 
            this.btRelatorio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btRelatorio.FlatAppearance.BorderSize = 0;
            this.btRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRelatorio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRelatorio.ForeColor = System.Drawing.Color.White;
            this.btRelatorio.Location = new System.Drawing.Point(21, 370);
            this.btRelatorio.Name = "btRelatorio";
            this.btRelatorio.Size = new System.Drawing.Size(239, 49);
            this.btRelatorio.TabIndex = 15;
            this.btRelatorio.Text = "Relatorios";
            this.btRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRelatorio.UseVisualStyleBackColor = true;
            // 
            // btCadFuncionario
            // 
            this.btCadFuncionario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btCadFuncionario.FlatAppearance.BorderSize = 0;
            this.btCadFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadFuncionario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadFuncionario.ForeColor = System.Drawing.Color.White;
            this.btCadFuncionario.Location = new System.Drawing.Point(21, 315);
            this.btCadFuncionario.Name = "btCadFuncionario";
            this.btCadFuncionario.Size = new System.Drawing.Size(239, 49);
            this.btCadFuncionario.TabIndex = 14;
            this.btCadFuncionario.Text = "Cadastro de Funcionario";
            this.btCadFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCadFuncionario.UseVisualStyleBackColor = true;
            this.btCadFuncionario.Click += new System.EventHandler(this.btCadFuncionario_Click);
            // 
            // btImportacao
            // 
            this.btImportacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btImportacao.FlatAppearance.BorderSize = 0;
            this.btImportacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btImportacao.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btImportacao.ForeColor = System.Drawing.Color.White;
            this.btImportacao.Location = new System.Drawing.Point(21, 260);
            this.btImportacao.Name = "btImportacao";
            this.btImportacao.Size = new System.Drawing.Size(239, 49);
            this.btImportacao.TabIndex = 13;
            this.btImportacao.Text = "Importação de Produtos";
            this.btImportacao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btImportacao.UseVisualStyleBackColor = true;
            this.btImportacao.Click += new System.EventHandler(this.btImportacao_Click);
            // 
            // btCadProdutos
            // 
            this.btCadProdutos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btCadProdutos.FlatAppearance.BorderSize = 0;
            this.btCadProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadProdutos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadProdutos.ForeColor = System.Drawing.Color.White;
            this.btCadProdutos.Location = new System.Drawing.Point(21, 205);
            this.btCadProdutos.Name = "btCadProdutos";
            this.btCadProdutos.Size = new System.Drawing.Size(241, 49);
            this.btCadProdutos.TabIndex = 12;
            this.btCadProdutos.Text = "Cadastro de Produtos";
            this.btCadProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCadProdutos.UseVisualStyleBackColor = true;
            this.btCadProdutos.Click += new System.EventHandler(this.btCadProdutos_Click);
            // 
            // sidePanel
            // 
            this.sidePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sidePanel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.sidePanel.Location = new System.Drawing.Point(-3, 151);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(21, 49);
            this.sidePanel.TabIndex = 11;
            // 
            // btCatalogo
            // 
            this.btCatalogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btCatalogo.FlatAppearance.BorderSize = 0;
            this.btCatalogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCatalogo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCatalogo.ForeColor = System.Drawing.Color.White;
            this.btCatalogo.Location = new System.Drawing.Point(23, 150);
            this.btCatalogo.Name = "btCatalogo";
            this.btCatalogo.Size = new System.Drawing.Size(238, 49);
            this.btCatalogo.TabIndex = 10;
            this.btCatalogo.Text = "Catalogo de Produtos";
            this.btCatalogo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCatalogo.UseVisualStyleBackColor = true;
            this.btCatalogo.Click += new System.EventHandler(this.btCadProdutos_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(273, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 522F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(889, 541);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(883, 516);
            this.panel2.TabIndex = 0;
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
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1165, 547);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGnPdv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btRelatorio;
        private System.Windows.Forms.Button btCadFuncionario;
        private System.Windows.Forms.Button btImportacao;
        private System.Windows.Forms.Button btCadProdutos;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button btCatalogo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private DataSetGnPdv dataSetGnPdv;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private DataSetGnPdvTableAdapters.ProdutoTableAdapter produtoTableAdapter;
    }
}
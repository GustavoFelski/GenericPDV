namespace GenericPdv
{
    partial class ListFuncionario
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
            this.dataSetGnPdv = new GenericPdv.DataSetGnPdv();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionarioTableAdapter = new GenericPdv.DataSetGnPdvTableAdapters.FuncionarioTableAdapter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btAlterar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idFuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcNomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcAliaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoNomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcStatusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.funcionarioCargoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionarioCargoTableAdapter = new GenericPdv.DataSetGnPdvTableAdapters.funcionarioCargoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGnPdv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioCargoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSetGnPdv
            // 
            this.dataSetGnPdv.DataSetName = "DataSetGnPdv";
            this.dataSetGnPdv.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataMember = "Funcionario";
            this.funcionarioBindingSource.DataSource = this.dataSetGnPdv;
            // 
            // funcionarioTableAdapter
            // 
            this.funcionarioTableAdapter.ClearBeforeFill = true;
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.20985F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.79015F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(943, 467);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btAlterar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(943, 28);
            this.panel1.TabIndex = 1;
            // 
            // btAlterar
            // 
            this.btAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btAlterar.FlatAppearance.BorderSize = 0;
            this.btAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAlterar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btAlterar.Location = new System.Drawing.Point(3, 3);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(61, 22);
            this.btAlterar.TabIndex = 3;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = false;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFuncionarioDataGridViewTextBoxColumn,
            this.funcNomeDataGridViewTextBoxColumn,
            this.funcAliaseDataGridViewTextBoxColumn,
            this.cargoNomeDataGridViewTextBoxColumn,
            this.funcStatusDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.funcionarioCargoBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(937, 433);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // idFuncionarioDataGridViewTextBoxColumn
            // 
            this.idFuncionarioDataGridViewTextBoxColumn.DataPropertyName = "idFuncionario";
            this.idFuncionarioDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idFuncionarioDataGridViewTextBoxColumn.Name = "idFuncionarioDataGridViewTextBoxColumn";
            this.idFuncionarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // funcNomeDataGridViewTextBoxColumn
            // 
            this.funcNomeDataGridViewTextBoxColumn.DataPropertyName = "funcNome";
            this.funcNomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.funcNomeDataGridViewTextBoxColumn.Name = "funcNomeDataGridViewTextBoxColumn";
            this.funcNomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.funcNomeDataGridViewTextBoxColumn.Width = 200;
            // 
            // funcAliaseDataGridViewTextBoxColumn
            // 
            this.funcAliaseDataGridViewTextBoxColumn.DataPropertyName = "funcAliase";
            this.funcAliaseDataGridViewTextBoxColumn.HeaderText = "Nome de Acesso";
            this.funcAliaseDataGridViewTextBoxColumn.Name = "funcAliaseDataGridViewTextBoxColumn";
            this.funcAliaseDataGridViewTextBoxColumn.ReadOnly = true;
            this.funcAliaseDataGridViewTextBoxColumn.Width = 150;
            // 
            // cargoNomeDataGridViewTextBoxColumn
            // 
            this.cargoNomeDataGridViewTextBoxColumn.DataPropertyName = "cargoNome";
            this.cargoNomeDataGridViewTextBoxColumn.HeaderText = "Cargo";
            this.cargoNomeDataGridViewTextBoxColumn.Name = "cargoNomeDataGridViewTextBoxColumn";
            this.cargoNomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // funcStatusDataGridViewCheckBoxColumn
            // 
            this.funcStatusDataGridViewCheckBoxColumn.DataPropertyName = "funcStatus";
            this.funcStatusDataGridViewCheckBoxColumn.HeaderText = "Status";
            this.funcStatusDataGridViewCheckBoxColumn.Name = "funcStatusDataGridViewCheckBoxColumn";
            this.funcStatusDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // funcionarioCargoBindingSource
            // 
            this.funcionarioCargoBindingSource.DataMember = "funcionarioCargo";
            this.funcionarioCargoBindingSource.DataSource = this.dataSetGnPdv;
            // 
            // funcionarioCargoTableAdapter
            // 
            this.funcionarioCargoTableAdapter.ClearBeforeFill = true;
            // 
            // ListFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ListFuncionario";
            this.Size = new System.Drawing.Size(943, 467);
            this.Load += new System.EventHandler(this.ListFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGnPdv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioCargoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataSetGnPdv dataSetGnPdv;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private DataSetGnPdvTableAdapters.FuncionarioTableAdapter funcionarioTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btAlterar;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource funcionarioCargoBindingSource;
        private DataSetGnPdvTableAdapters.funcionarioCargoTableAdapter funcionarioCargoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcNomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcAliaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoNomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn funcStatusDataGridViewCheckBoxColumn;
    }
}

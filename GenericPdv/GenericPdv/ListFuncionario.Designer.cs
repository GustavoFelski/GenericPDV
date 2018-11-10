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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idFuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcNomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoNomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcAliaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcTelefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcStatusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.funcionariosCargoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetGnPdv = new GenericPdv.DataSetGnPdv();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionarioTableAdapter = new GenericPdv.DataSetGnPdvTableAdapters.FuncionarioTableAdapter();
            this.funcionariosCargoTableAdapter = new GenericPdv.DataSetGnPdvTableAdapters.FuncionariosCargoTableAdapter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btAlterar = new System.Windows.Forms.Button();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.funcNomeToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.funcNomeToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosCargoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGnPdv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFuncionarioDataGridViewTextBoxColumn,
            this.funcNomeDataGridViewTextBoxColumn,
            this.cargoNomeDataGridViewTextBoxColumn,
            this.funcAliaseDataGridViewTextBoxColumn,
            this.funcTelefoneDataGridViewTextBoxColumn,
            this.funcEmailDataGridViewTextBoxColumn,
            this.funcStatusDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.funcionariosCargoBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(937, 433);
            this.dataGridView1.TabIndex = 0;
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
            // cargoNomeDataGridViewTextBoxColumn
            // 
            this.cargoNomeDataGridViewTextBoxColumn.DataPropertyName = "cargoNome";
            this.cargoNomeDataGridViewTextBoxColumn.HeaderText = "Cargo";
            this.cargoNomeDataGridViewTextBoxColumn.Name = "cargoNomeDataGridViewTextBoxColumn";
            this.cargoNomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // funcAliaseDataGridViewTextBoxColumn
            // 
            this.funcAliaseDataGridViewTextBoxColumn.DataPropertyName = "funcAliase";
            this.funcAliaseDataGridViewTextBoxColumn.HeaderText = "Nome de Acesso";
            this.funcAliaseDataGridViewTextBoxColumn.Name = "funcAliaseDataGridViewTextBoxColumn";
            this.funcAliaseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // funcTelefoneDataGridViewTextBoxColumn
            // 
            this.funcTelefoneDataGridViewTextBoxColumn.DataPropertyName = "funcTelefone";
            this.funcTelefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.funcTelefoneDataGridViewTextBoxColumn.Name = "funcTelefoneDataGridViewTextBoxColumn";
            this.funcTelefoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // funcEmailDataGridViewTextBoxColumn
            // 
            this.funcEmailDataGridViewTextBoxColumn.DataPropertyName = "funcEmail";
            this.funcEmailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.funcEmailDataGridViewTextBoxColumn.Name = "funcEmailDataGridViewTextBoxColumn";
            this.funcEmailDataGridViewTextBoxColumn.ReadOnly = true;
            this.funcEmailDataGridViewTextBoxColumn.Width = 300;
            // 
            // funcStatusDataGridViewCheckBoxColumn
            // 
            this.funcStatusDataGridViewCheckBoxColumn.DataPropertyName = "funcStatus";
            this.funcStatusDataGridViewCheckBoxColumn.HeaderText = "Status";
            this.funcStatusDataGridViewCheckBoxColumn.Name = "funcStatusDataGridViewCheckBoxColumn";
            this.funcStatusDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // funcionariosCargoBindingSource
            // 
            this.funcionariosCargoBindingSource.DataMember = "FuncionariosCargo";
            this.funcionariosCargoBindingSource.DataSource = this.dataSetGnPdv;
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
            // funcionariosCargoTableAdapter
            // 
            this.funcionariosCargoTableAdapter.ClearBeforeFill = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
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
            this.panel1.Controls.Add(this.fillByToolStrip);
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
            this.btAlterar.Location = new System.Drawing.Point(297, 2);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(61, 22);
            this.btAlterar.TabIndex = 3;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = false;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcNomeToolStripLabel,
            this.funcNomeToolStripTextBox,
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(3, 1);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(291, 25);
            this.fillByToolStrip.TabIndex = 2;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // funcNomeToolStripLabel
            // 
            this.funcNomeToolStripLabel.Name = "funcNomeToolStripLabel";
            this.funcNomeToolStripLabel.Size = new System.Drawing.Size(116, 22);
            this.funcNomeToolStripLabel.Text = "Pesquisa por Nome: ";
            // 
            // funcNomeToolStripTextBox
            // 
            this.funcNomeToolStripTextBox.Name = "funcNomeToolStripTextBox";
            this.funcNomeToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(61, 22);
            this.fillByToolStripButton.Text = "Pesquisar";
            // 
            // ListFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ListFuncionario";
            this.Size = new System.Drawing.Size(943, 467);
            this.Load += new System.EventHandler(this.ListFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosCargoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGnPdv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetGnPdv dataSetGnPdv;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private DataSetGnPdvTableAdapters.FuncionarioTableAdapter funcionarioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcNomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoNomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcAliaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcTelefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn funcStatusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource funcionariosCargoBindingSource;
        private DataSetGnPdvTableAdapters.FuncionariosCargoTableAdapter funcionariosCargoTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel funcNomeToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox funcNomeToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.Button btAlterar;
    }
}

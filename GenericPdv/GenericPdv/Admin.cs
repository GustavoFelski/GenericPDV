using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericPdv
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSetGnPdv.Produto'. Você pode movê-la ou removê-la conforme necessário.
            //this.produtoTableAdapter.Fill(this.dataSetGnPdv.Produto);
            sidePanel.Height = btCatalogo.Height;
            sidePanel.Top = btCatalogo.Top;
            //catalogoProdutos1.Visible = false;
            //importacaoDeTabelas1.Visible = false;

        }

        private void btCatalogo_Click(object sender, EventArgs e)
        {
            //Design Button
            sidePanel.Height = btCatalogo.Height;
            sidePanel.Top = btCatalogo.Top;
            //catalogoProdutos1.Visible = true;
            //adcionar as listas de produtos

            //Logic Button
        }

        private void btCadProdutos_Click(object sender, EventArgs e)
        {
            //Design Button
            sidePanel.Height = btCadProdutos.Height;
            sidePanel.Top = btCadProdutos.Top;
            CadastroDeProduto cadastro = new CadastroDeProduto(true , 0);
            cadastro.ShowDialog();
            //Logic Button


        }

        private void btImportacao_Click(object sender, EventArgs e)
        {
            //Design Button
            sidePanel.Height = btImportacao.Height;
            sidePanel.Top = btImportacao.Top;
            //catalogoProdutos1.Visible = false;
            //importacaoDeTabelas1.Visible = true;


            //Logic Button
        }

        private void btCadFuncionario_Click(object sender, EventArgs e)
        {
            //Design Button
            sidePanel.Height = btCadFuncionario.Height;
            sidePanel.Top = btCadFuncionario.Top;

            //Logic Button
            CadastroDeFuncionario cadastro = new CadastroDeFuncionario();
            cadastro.Show();
        }

        private void btRelatorio_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btRelatorio.Height;
            sidePanel.Top = btRelatorio.Top;
        }

        private void btHelp_Click(object sender, EventArgs e)
        {

        }

        private void btSettings_Click(object sender, EventArgs e)
        {
            //Configuracoes configuracoes = new Configuracoes();
            //configuracoes.Show();

        }

        private void brLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btMinizar_Click(object sender, EventArgs e)
        {
            this.MinimizeBox = true;
        }
    }
}

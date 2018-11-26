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
        bool Administrador;

        public Admin(bool admin)
        {
            this.Administrador = admin;
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            panelSide.Height = btCatalogo.Height;
            panelSide.Top = btCatalogo.Top;

            if (Administrador) {
                catalogo1.Visible = false;
                listFuncionario1.Visible = false;
                relatorios1.Visible = false;
            }
            else
            {

                catalogo1.Visible = true;
                relatorios1.Visible = false;
                btListarFunc.Visible = false;
                listFuncionario1.Visible = false;
                btRelatorio.Visible = false;
                btCadastroFunc.Visible = false;
                btRelatorio.Visible = false;
            }
        }

        private void btCatalogo_Click(object sender, EventArgs e)
        {
            //Design Button
            panelSide.Height = btCatalogo.Height;
            panelSide.Top = btCatalogo.Top;

            catalogo1.Visible = true;
            relatorios1.Visible = false;
            listFuncionario1.Visible = false;
            //adcionar as listas de produtos


            //Logic Button
        }

        private void btCadProdutos_Click(object sender, EventArgs e)
        {
            //Design Button
            panelSide.Height = btCadastroProdutos.Height;
            panelSide.Top = btCadastroProdutos.Top;
            Catalogo catalogo = new Catalogo();
            CadastroDeProduto cadastro = new CadastroDeProduto(true , 0, catalogo );
            cadastro.ShowDialog();
            //Logic Button

        }

        private void btCadFuncionario_Click(object sender, EventArgs e)
        {
            //Design Button
            panelSide.Height = btCadastroFunc.Height;
            panelSide.Top = btCadastroFunc.Top;

            //Logic Button
            ListFuncionario listFuncionario = new ListFuncionario();
            CadastroDeFuncionario cadastro = new CadastroDeFuncionario(true, 0, listFuncionario);
            cadastro.ShowDialog();
        }

        private void btRelatorio_Click(object sender, EventArgs e)
        {
            panelSide.Height = btRelatorio.Height;
            panelSide.Top = btRelatorio.Top;

            catalogo1.Visible = false;
            relatorios1.Visible = true;
            relatorios1.BringToFront();
            listFuncionario1.Visible = false;
        }

        private void btHelp_Click(object sender, EventArgs e)
        {
            // implementar depois quem sabe
        }

        private void btListarFunc_Click(object sender, EventArgs e)
        {
            panelSide.Height = btListarFunc.Height;
            panelSide.Top = btListarFunc.Top;

            listFuncionario1.Visible = true;
            listFuncionario1.BringToFront();
            catalogo1.Visible = false;
            relatorios1.Visible = false;

        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            FrenteDeCaixa frente = new FrenteDeCaixa();
            AutenticacaoValidacao autenticacao = new AutenticacaoValidacao(1, frente, this);
            autenticacao.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Reprodutor ajuda = new Reprodutor(@"C:\Users\Dokahviin\source\repos\GenericPdv\GenericPdv\Ajuda\recuperarSenha.mp4");
            ajuda.Show();
        }
        //cadastrar Produtos
        private void lbAjuda_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Reprodutor ajuda = new Reprodutor(@"C:\Users\Dokahviin\source\repos\GenericPdv\GenericPdv\Ajuda\recuperarSenha.mp4");
            ajuda.Show();
        }

        //alterar funcionario
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        // Relatório de Vendas
        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Reprodutor ajuda = new Reprodutor(@"C:\Users\Dokahviin\source\repos\GenericPdv\GenericPdv\Ajuda\relatorioDeVendas.mp4");
            ajuda.Show();
        }
        //alterar funcionario
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}

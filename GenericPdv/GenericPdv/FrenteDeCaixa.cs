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
    public partial class FrenteDeCaixa : Form
    {
        public FrenteDeCaixa()
        {
            InitializeComponent();
            cpf = null;
        }
        //Adaptadores
        DataSetGnPdvTableAdapters.ItensDaVendaTableAdapter itensVenda = new DataSetGnPdvTableAdapters.ItensDaVendaTableAdapter();
        DataSetGnPdvTableAdapters.VendaTableAdapter venda = new DataSetGnPdvTableAdapters.VendaTableAdapter();
        DataSetGnPdvTableAdapters.ProdutoTableAdapter produto = new DataSetGnPdvTableAdapters.ProdutoTableAdapter();
        DataSetGnPdvTableAdapters.FuncionarioTableAdapter funcionario = new DataSetGnPdvTableAdapters.FuncionarioTableAdapter();
        DataSetGnPdvTableAdapters.CaixaTableAdapter caixa = new DataSetGnPdvTableAdapters.CaixaTableAdapter();
        //Variaveis Globais
        public double valorTotal { get; set; }
        public string[ , ] itensDaLista { get; set; }

        bool cpfNota = true;
        int count = 1;
        string[] itens = new string[6];
        public string cpf { get; set; }

        private void txtBusca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPesquisa.Text)) { return; }
            // verificar nome de produto para pesquisa
            if (e.KeyChar == (char)13)
            {
                try
                {
                    //pergunda se precisa de cpf 
                    if (cpfNota)
                    {
                        Cpf cpfJanela = new Cpf();
                        cpfJanela.ShowDialog();
                        cpf = cpfJanela.cpfCli;
                        cpfNota = false;
                        btFinalizar.Enabled = true;
                    }

                    var aux = Convert.ToDouble(txtQtd.Text);
                    var prod = produto.GetDataById(Convert.ToInt32(txtPesquisa.Text));

                    itens[0] = count.ToString();
                    itens[1] = txtCodProd.Text = (prod[0]["idProduto"].ToString());
                    itens[2] = prod[0]["prodNome"].ToString();
                    itens[3] = txtQtd.Text;
                    txtQuantidade.Text = txtQtd.Text + " UN";
                    // verificar se o produto em um valor em oferta e atribuir ao valor unitario
                    try
                    {
                        DateTime data1 = DateTime.Today;
                        if (DateTime.TryParse(prod[0]["prodDataInicio"].ToString(), out data1).Equals(true) && DateTime.TryParse(prod[0]["prodDataFim"].ToString(), out data1).Equals(true))    
                        {
                            itens[4] = txtValorUni.Text = prod[0]["prodDesconto"].ToString();
                        }
                        else
                        {
                            itens[4] = txtValorUni.Text = prod[0]["prodVenda"].ToString();
                        }
                    }catch(Exception ex)
                    {
                        itens[4] = txtValorUni.Text = prod[0]["prodVenda"].ToString();
                        MessageBox.Show(ex.Message);
                    }
                    aux = aux * Convert.ToDouble(txtValorUni.Text);
                    txtSubTotal.Text = aux.ToString();
                    valorTotal += aux;
                    itens[5] = txtSubTotal.Text;
                    txtValorTotal.Text = valorTotal.ToString();
                    txtPesquisa.Text = "";
                    txtPesquisa.Focus();

                    ListViewItem item = new ListViewItem(itens[0]);
                    for (int i = 1; i <= 5; i++)
                    {
                        item.SubItems.Add(itens[i]);
                    }
                    listView.Items.Add(item);
                    count++;
                }
                catch (Exception ex) {
                    MessageBox.Show("Não encontrado.");
                }
            }
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            if (listView.Items.Count > 0)
            {
                listView.Items.Remove(listView.SelectedItems[0]);
            }
        }
        
        private void btFinalizar_Click(object sender, EventArgs e)
        {
            // verificar erro de objeto e pq não esta aceitando o 
            
            itensDaLista = new string[this.listView.Items.Count , 6];

            for (int i = 0; i < this.listView.Items.Count; i++)
            {
                for (int j = 0; j <= 5; j++)
                {
                    //passando os itens e colunas para uma variavel publica que vai receber os itens e salvar no  banco na tela pagamento
                    itensDaLista[i , j] = listView.Items[i].SubItems[j].Text;
                }
            }
            Pagamento pagamento = new Pagamento(itensDaLista, valorTotal, cpf);
            pagamento.ShowDialog();

            // limpando array dos itens ja salvos
            for (int i = 0; i < itens.Length; i++)
            {
                itens[i] = "";
            }
            
            itens = new string[6];
            listView.Items.Clear();
            count = 0;
            cpfNota = true;
            cpf = null;
            valorTotal = 0.0;
            txtCodProd.Text = "";
            txtPesquisa.Text = "";
            txtQuantidade.Text = "";
            txtSubTotal.Text = "";
            txtValorUni.Text = "";
            txtValorTotal.Text = "";
            lbNomeProduto.Text = "";
        }

        private void btClouse_Click(object sender, EventArgs e)
        {
            // verificar se status ainda esta atendimento e se foi feito o fechamento
            this.Dispose();
        }

        private void btMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            // verificar se ha alguma operação em aberto
            consulta consulta = new consulta();
            consulta.ShowDialog();
        }

        private void btSangria_Click(object sender, EventArgs e)
        {
            // verificar se ha alguma operação em aberto
            // fazer autenticação de admistrador?
            AutenticacaoValidacao autenticacao = new AutenticacaoValidacao();
            autenticacao.ShowDialog();
            
        }

        private void frenteDeCaixa_Load(object sender, EventArgs e)
        {
            lbNomeUsuario.Text = AutenticacaoDeFuncionario.funcLogado.ToString();
            lbData.Text = DateTime.Today.ToString();
            lbStatus.Text = "Caixa aberto - Livre";
            btFinalizar.Enabled = false;
        }

        private void btFechamento_Click(object sender, EventArgs e)
        {

        }
    }
}

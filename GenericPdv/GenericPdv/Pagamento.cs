
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
    public partial class Pagamento : Form
    {
        DataSetGnPdvTableAdapters.CaixaTableAdapter caixa = new DataSetGnPdvTableAdapters.CaixaTableAdapter();
        DataSetGnPdvTableAdapters.PagamentoTableAdapter pagamento = new DataSetGnPdvTableAdapters.PagamentoTableAdapter();
        DataSetGnPdvTableAdapters.VendaTableAdapter venda = new DataSetGnPdvTableAdapters.VendaTableAdapter();
        DataSetGnPdvTableAdapters.ItensDaVendaTableAdapter itensVenda = new DataSetGnPdvTableAdapters.ItensDaVendaTableAdapter();

        private double valorTotal;
        double valorPagar, valorEmDinheiro, valorEmCredito, valorEmDebito;
        int tipo;
        bool tipoDeDesconto;
        string[,] itensDePagamento;
        string cpf;
        string[,] itensLista;

        public Pagamento(string[,] itens, double valorCompra, string cpfCli)
        {
            valorTotal = valorCompra;
            cpf = cpfCli;
            valorPagar = valorCompra;// variavel que vai ter o valor manipulado durante este processo
            itensLista = itens;
            InitializeComponent();
            
        }

        private void btFecharCompra_Click(object sender, EventArgs e)
        {
            try
            {
                //insere na tabela de Vendas
                venda.InsertQueryVenda(valorTotal, DateTime.Now, cpf, Convert.ToInt32(caixa.GetDataByLast()[0]["idCaixa"]), AutenticacaoDeFuncionario.idFuncionario);
                var LastId = venda.GetDataByLastId();

                //inserir as opções de pagamento para o id de venda
                itensDePagamento = new string[this.listPagamento.Items.Count, 5];
                  
                for (int i = 0; i < this.listPagamento.Items.Count; i++)
                {
                    try
                    {
                        pagamento.InsertQueryPagamento(Convert.ToInt32(listPagamento.Items[i].SubItems[4].Text), Convert.ToInt32(LastId), Convert.ToDouble(listPagamento.Items[i].SubItems[2].Text));
                        switch (Convert.ToInt32(listPagamento.Items[i].SubItems[4].Text))
                        {
                            case 1: { valorEmDinheiro += Convert.ToDouble(listPagamento.Items[i].SubItems[2].Text); } break;
                            case 2: { valorEmCredito += Convert.ToDouble(listPagamento.Items[i].SubItems[2].Text); } break;
                            case 3: { valorEmDebito +=  Convert.ToDouble(listPagamento.Items[i].SubItems[2].Text); } break;
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }   
                }

                //Adiciona os items a tabela itens itensVenda
                int linha = itensLista.Length / 6;

                for (int i = 0; i < linha; i++)
                {
                    for (int j = 0; j <= 5; j++)
                    {
                        try
                        {
                            itensVenda.InsertQuery(Convert.ToInt32(itensLista[i, 3]), Convert.ToInt32(itensLista[i, 5]), Convert.ToInt32(itensLista[i, 4]), Convert.ToInt32(itensLista[i, 1]), Convert.ToInt32(LastId));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                // fazer updade na tabela de caixa dos valores   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //Apresentar uma previsualização da compra e liberar para impressão
            try
            {
                Impressao print = new Impressao();
                print.imprimir(itensLista, cpf, valorTotal);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //adicionar valor em caixa 
            var aux = caixa.GetDataByLast();
            caixa.UpdateValores((Convert.ToDouble(aux[0]["caixaValorCartaoCredito"]) + valorEmCredito), (Convert.ToDouble(aux[0]["caixaValorDinheiro"]) + valorEmDinheiro), (Convert.ToDouble(aux[0]["caixaValorCartaoDebito"]) + valorEmDebito), Convert.ToInt32(aux[0]["idCaixa"]));
            //AberturaDeCaixa.adcionarValor(valorEmDinheiro);
            MessageBox.Show("venda ok");
            this.Close();
        }

        private void btDinheiro_Click(object sender, System.EventArgs e)
        {
            //focus em valor a Pagar
            btDinheiro.Enabled = false;
            btCredito.Enabled = false;
            btDebito.Enabled = false;
            txtValorPagar.Enabled = true;
            txtValorPagar.Focus();
            tipo = 1;
            //bloqueia desconto total e intens
        }   

        private void btCredito_Click(object sender, System.EventArgs e)
        {
            //focus em valor a Pagar
            btDinheiro.Enabled = false;
            btCredito.Enabled = false;
            btDebito.Enabled = false;
            txtValorPagar.Enabled = true;
            txtValorPagar.Focus();
            tipo = 2;
            //bloqueia desconto total e intens
        }

        private void btDebito_Click(object sender, System.EventArgs e)
        {
            //focus em valor a Pagar
            btDinheiro.Enabled = false;
            btCredito.Enabled = false;
            btDebito.Enabled = false;
            txtValorPagar.Enabled = true;
            txtValorPagar.Focus();
            tipo = 3;
            //bloqueia desconto total e intens
        }

        private void Pagamento_Load(object sender, EventArgs e)
        {
            txtValorCompra.Text = string.Format("{0,-10:C}", valorTotal);
            txtValorPagar.Enabled = false;
            btFecharCompra.Enabled = false;
            ckbTipoDesconto.Text = "R$";
            tipoDeDesconto = false;
            btDescontoTotal.Enabled = true;
            btLimpar.Enabled = false;
        }

        private void txtValorPagar_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (string.IsNullOrEmpty(txtValorPagar.Text)) { return; }
            if (e.KeyChar == (char)13)
            {
                ListViewItem item = new ListViewItem();
                string[] itens = new string[5];
                double valorPago, troco;
                try {
                    valorPago = Convert.ToDouble(txtValorPagar.Text);
                switch (tipo)
                {
                    #region pagamento em dinheiro
                    case 1:
                    //verificar se o valor pago é superior ao valor da compra
                    if (Convert.ToDouble(txtValorPagar.Text) >= valorPagar)
                    {
                        // fechar compra se o valor for abatido
                        if (Convert.ToDouble(txtValorPagar.Text) == valorPagar)
                        {
                            txtTroco.Text = "R$ 0,00";
                            valorPagar -= Convert.ToDouble(txtValorPagar.Text);
                        }
                        // Calcular troco e fechar compra 
                        if (Convert.ToDouble(txtValorPagar.Text) > valorPagar)
                        {
                            troco = valorPago - valorPagar;
                            txtTroco.Text = string.Format("{0,-10:C}", troco);
                        }
                        btFecharCompra.Enabled = true;
                        txtValorPagar.Enabled = false;
                        btDinheiro.Enabled = false;
                        btCredito.Enabled = false;
                        btDebito.Enabled = false;
                    }
                    // se o valor for inferior apenas decrementar o valor restante 
                    else
                    {
                        valorPagar -= valorPago;
                        txtValorCompra.Text = string.Format("{0,-10:C}", valorPagar);
                        if (string.IsNullOrEmpty(txtTroco.Text)) { txtTroco.Text = "R$ 0,00"; }
                        btFecharCompra.Enabled = false;
                        txtValorPagar.Enabled = false;
                        txtValorPagar.Text = "";
                        btDinheiro.Enabled = true;
                        btCredito.Enabled = true;
                        btDebito.Enabled = true;
                    }
                    #region adcionar a lista de pagamento
                    //adicionar a lista de pagamento
                    itens[0] = "Dinheiro";
                    itens[1] = valorPago.ToString();
                    itens[2] = txtTroco.Text;
                    itens[3] = tipo.ToString();

                    for (int i = 0; i <= 4; i++)
                    {
                        item.SubItems.Add(itens[i]);
                    }
                    listPagamento.Items.Add(item);
                    #endregion
                        
                    break;
                    #endregion

                    #region pagamento em debito
                    case 3:
                    // verificar se valor digitado excede o valor da compra
                    if (valorPago > valorPagar)
                    {
                        Alerta alerta = new Alerta("o valor digitado excede o valor da compra para esta opção. Por favor, entre um novo valor igual ou menor ao valor da compra");
                        alerta.ShowDialog();
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(txtTroco.Text)) { txtTroco.Text = "R$ 0,00"; }
                        if ( valorPagar == valorPago)
                        {
                            btFecharCompra.Enabled = true;
                            txtValorPagar.Enabled = false;
                            btCredito.Enabled = false;
                            btDinheiro.Enabled = false;
                            btDebito.Enabled = false;

                        }else
                        {
                            valorPagar -= valorPago;
                            txtValorCompra.Text = string.Format("{0,-10:C}", valorPagar);
                            btCredito.Enabled = true;
                            btDebito.Enabled = true;
                            btDinheiro.Enabled = true;
                            txtValorPagar.Enabled = false;
                            txtValorPagar.Text = "";
                        }

                        // adicionar a lista de pagamento
                        itens[3] = tipo.ToString();
                        itens[0] = "Debito";
                        itens[1] = valorPagar.ToString();
                        itens[2] = txtTroco.Text;

                        for (int i = 0; i <= 3; i++)
                        {
                            item.SubItems.Add(itens[i]);
                        }
                        listPagamento.Items.Add(item);
                    }
                    break;
                    #endregion

                    #region Pagamento em Crédito
                    case 2:
                    // verificar se valor digitado excede o valor da compra
                    if (valorPago > valorPagar)
                    {
                        Alerta alerta = new Alerta("o valor digitado excede o valor da compra para esta opção. Por favor, entre um novo valor igual ou menor ao valor da compra");
                        alerta.ShowDialog();
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(txtTroco.Text)) { txtTroco.Text = "R$ 0,00"; }
                            if (valorPagar == valorPago)
                            {
                                btFecharCompra.Enabled = true;
                                txtValorPagar.Enabled = false;
                                btCredito.Enabled = false;
                                btDinheiro.Enabled = false;
                                btDebito.Enabled = false;
                            }
                            else
                            {
                                valorPagar -= valorPago;
                                txtValorCompra.Text = string.Format("{0,-10:C}", valorPagar);
                                btCredito.Enabled = true;
                                btDebito.Enabled = true;
                                btDinheiro.Enabled = true;
                                txtValorPagar.Enabled = false;
                                txtValorPagar.Text = "";
                            }


                        // adicionar a lista de pagamento
                        itens[3] = tipo.ToString();
                        itens[0] = "Crédito";
                        itens[1] = valorPagar.ToString();
                        itens[2] = txtTroco.Text;
                        for (int i = 0; i <= 3; i++)
                        {
                            item.SubItems.Add(itens[i]);
                        }
                        listPagamento.Items.Add(item);
                    }
                    break;
                    #endregion
                }
                txtDesconto.Enabled = false;
                btDescontoTotal.Enabled = false;
                ckbTipoDesconto.Enabled = false;
                btLimpar.Enabled = true;
                }
                catch (Exception ex)
                {
                    Alerta alerta = new Alerta("Valor não compreendido por favor usar entre novamente");
                    alerta.ShowDialog();
                    txtValorPagar.Text = "";
                    txtValorPagar.Focus();
                }
            }
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            valorPagar = valorTotal;
            txtValorCompra.Text = string.Format("{0,-10:C}", valorPagar);
            txtTroco.Text = "";
            txtValorPagar.Text = "";
            listPagamento.Items.Clear();
            btCredito.Enabled = true;
            btDebito.Enabled = true;
            btDinheiro.Enabled = true;
            btDescontoTotal.Enabled = true;
            txtDesconto.Enabled = true;
            ckbTipoDesconto.Enabled = true;
        }

        private void btDescontoTotal_Click(object sender, EventArgs e)
        {
            try {
                if (string.IsNullOrEmpty(txtDesconto.Text))
                {
                    Alerta alerta = new Alerta("Insira um valor de desconto.");
                    alerta.ShowDialog();
                }
                else
                {
                    if (tipoDeDesconto)
                    {
                        if ((Convert.ToDouble(txtDesconto.Text) > 0) && ((Convert.ToDouble(txtDesconto.Text) <= 100)))
                        {
                            valorPagar -= ((valorPagar * (Convert.ToDouble(txtDesconto.Text)) / 100));
                            txtValorCompra.Text = string.Format("{0,-10:C}", valorPagar);
                            txtDesconto.Text = "";
                            btLimpar.Enabled = true;
                        }
                        else
                        {
                            Alerta alerta = new Alerta("Valor incorreto, por favor entrar valor entre 1% á 100%.");
                            alerta.ShowDialog();
                            txtDesconto.Text = "";
                            txtDesconto.Focus();
                        }
                    }
                    else
                    {
                        if ((Convert.ToDouble(txtDesconto.Text) > 0) && ((Convert.ToDouble(txtDesconto.Text) <= valorPagar)))
                        {
                            valorPagar -= Convert.ToDouble(txtDesconto.Text);
                            txtValorCompra.Text = string.Format("{0,-10:C}", valorPagar);
                            txtDesconto.Text = "";
                            btLimpar.Enabled = true;

                        }
                        else
                        {
                            Alerta alerta = new Alerta("Valor incorreto, por favor entrar valores maiores que R$0,00 e menores que o valor da compra.");
                            alerta.ShowDialog();
                            txtDesconto.Text = "";
                            txtDesconto.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Alerta alerta = new Alerta("Caracteres Incorretos.");
                alerta.ShowDialog();
            }
        }

        private void ckbTipoDesconto_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbTipoDesconto.Checked)
            {
                ckbTipoDesconto.Text = "%";
                tipoDeDesconto = true;
                btDescontoTotal.Enabled = true;
            }
            else
            {
                ckbTipoDesconto.Text = "R$";
                tipoDeDesconto = false;
                btDescontoTotal.Enabled = true;
            }
        }
    }
}



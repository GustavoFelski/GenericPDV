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
    public partial class AberturaDeCaixaForm : Form
    {
        
        
        DataSetGnPdvTableAdapters.CaixaTableAdapter caixa = new DataSetGnPdvTableAdapters.CaixaTableAdapter();
        bool zerado = true;
        public AberturaDeCaixaForm()
        {
            InitializeComponent();
            
        }
        
        private void AberturaDeCaixaForm_Load(object sender, EventArgs e)
        {
            // carrega o ultimo valor de caixa do sistema
            // verificar se o caixa foi fechado no dia antenterior(se caixaFundo == null and caixaFechamento == null)
            // abrir tela de sangria e posteriormente a tela de fechamento 
            // depois voltar a tela de abertura

            var last = caixa.GetDataByLast();
            if(last[0]["caixaFundo"].ToString() == ""){
                lbMensagem.Text = "Você não tem fundo adicionado Anteriormente. Adicione um Fundo de Caixa.";
                txtValorDeApertura.Text = "R$ 0,00";
                txtValorDeApertura.SelectAll();
                zerado = true;
            }
            else
            { 
                txtValorDeApertura.Text = String.Format("R{0,-10:C}", Convert.ToDouble(last[0]["caixaFundo"]));
                zerado = false;
            }
        }

        private void btAbrirCaixa_Click(object sender, EventArgs e)
        {
            try
            {
                if (zerado)
                {
                    if (string.IsNullOrEmpty(txtValorDeApertura.Text))
                    {
                        Alerta alerta1 = new Alerta("vc não pode deixar este campo vazio para proceguir.");
                        alerta1.ShowDialog();
                        txtValorDeApertura.Focus();
                    }
                    else
                    {
                        Alerta alerta = new Alerta("Adione um valor de abertura.");
                        alerta.ShowDialog();
                        txtValorDeApertura.Focus();
                    }
                }
                else
                {
                    
                    #region Retira R$
                    string valorAbertura = "";
                    for (int i = 0; i <= txtValorDeApertura.Text.Length - 1; i++)
                    {
                        if ((txtValorDeApertura.Text[i] >= '0' &&
                            txtValorDeApertura.Text[i] <= '9') ||
                            txtValorDeApertura.Text[i] == ',')
                        {
                            valorAbertura += txtValorDeApertura.Text[i];
                        }
                    }
                    #endregion
                    if (Convert.ToDouble(valorAbertura) >= 0)
                    {
                        caixa.InsertQueryAbertura(DateTime.Now, Convert.ToDouble(valorAbertura), 0, 0);
                        FrenteDeCaixa frente = new FrenteDeCaixa();
                        frente.Show();
                        this.Dispose();
                    }
                    else
                    {
                        Alerta alerta = new Alerta("Não é permitido abrir o caixa com este valor.\nRecomenda-se abrir o caixa valores acima de R$50,00");
                        alerta.ShowDialog();
                        txtValorDeApertura.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtValorDeApertura_Leave(object sender, EventArgs e)
        {
            zerado = false;
        }

    }
}

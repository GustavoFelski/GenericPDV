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
        double valorAbertura;
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
            if((Convert.ToDouble(last[0]["caixaFundo"]) == 0.0) || (last[0]["caixaFundo"] == null)){
                lbMensagem.Text += "Você não tem fundo adicionado Anteriormente\nAdicione um Fundo de Caixa.";
                txtValorDeApertura.Text = "";
            }
            else
            { 
                txtValorDeApertura.Text = String.Format("R{0,-10:C}", Convert.ToDouble(last[0]["caixaFundo"]));
            }
        }

        private void btClouse_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            // voltar a autenticação
            // apresentar novamnte autenticação
        }

        private void btAbrirCaixa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtValorDeApertura.Text)) { return; }
                else
                {
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
                    MessageBox.Show(valorAbertura);
                    caixa.InsertQueryAbertura(DateTime.Now, Convert.ToDouble(valorAbertura), 0, 0);
                }
                FrenteDeCaixa frente = new FrenteDeCaixa();
                frente.Show();
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

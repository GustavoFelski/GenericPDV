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

        public AberturaDeCaixaForm()
        {
            InitializeComponent();
            
        }
        
        private void AberturaDeCaixaForm_Load(object sender, EventArgs e)
        {
            // carrega o ultimo valor de caixa do sistema
            var last = caixa.GetDataByLast();
            if((Convert.ToDouble(last[0]["caixaFundo"]) == 0.0) || (last[0]["caixaFundo"] == null)){
                lbMensagem.Text += "Você não tem fundo adicionado Anteriormente\nAdicione um Fundo de Caixa.";
                txtValorDeApertura.Text = "0,0";
            }
            else
            {
                txtValorDeApertura.Text = last[0]["caixaFundo"].ToString();
            }
            // buscar e adcionar na txtValorDeApertura
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
                if (AberturaDeCaixa.aberturaCaixa(Convert.ToDouble(txtValorDeApertura.Text)))
                {
                    FrenteDeCaixa frente = new FrenteDeCaixa();
                    frente.Show();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

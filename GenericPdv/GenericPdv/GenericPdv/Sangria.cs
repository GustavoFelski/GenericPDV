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
    public partial class Sangria : Form
    {
        DataSetGnPdvTableAdapters.SangriaTableAdapter sangria = new DataSetGnPdvTableAdapters.SangriaTableAdapter();
        DataSetGnPdvTableAdapters.CaixaTableAdapter caixa = new DataSetGnPdvTableAdapters.CaixaTableAdapter();
        int id;

        public Sangria(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txtNovoValor.Text) > Convert.ToDouble(caixa.GetDataByLast()[0]["caixaValorDinheiro"]) || Convert.ToDouble(txtNovoValor.Text) < 0)
                {
                    Alerta alerta = new Alerta("É aceito apenas valores maiores que 0 e menos que o valor em caixa.");
                    alerta.ShowDialog();
                    txtNovoValor.Text = "";
                    txtNovoValor.Focus();
                }
                else
                {
                    sangria.InsertQuery(
                        id, 
                        DateTime.Now,
                        Convert.ToDouble(txtNovoValor.Text),
                        Convert.ToInt32(caixa.GetDataByLast()[0]["idCaixa"]));
                    caixa.UpdateValorDinheiro(
                        Convert.ToDouble(caixa.GetDataByLast()[0]["caixaValorDinheiro"]) - (Convert.ToDouble(txtNovoValor.Text)),
                        Convert.ToInt32(caixa.GetDataByLast()[0]["idCaixa"]));
                    Alerta alerta = new Alerta("valor atualizado.");
                    alerta.ShowDialog();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Alerta alerta = new Alerta("erro:" + ex.Message);
                alerta.ShowDialog();
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Sangria_Load(object sender, EventArgs e)
        {
            txtCaixa.Text = string.Format("{0,-10:C}", Convert.ToDouble(caixa.GetDataByLast()[0]["caixaValorDinheiro"]));
        }
    }
}

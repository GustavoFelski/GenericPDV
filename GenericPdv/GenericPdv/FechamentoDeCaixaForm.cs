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
    public partial class FechamentoDeCaixaForm : Form
    {
        DataSetGnPdvTableAdapters.FechamentoTableAdapter fechamento = new DataSetGnPdvTableAdapters.FechamentoTableAdapter();
        DataSetGnPdvTableAdapters.CaixaTableAdapter caixa = new DataSetGnPdvTableAdapters.CaixaTableAdapter();
        DataSetGnPdvTableAdapters.FechamentoSangriaTableAdapter sangria = new DataSetGnPdvTableAdapters.FechamentoSangriaTableAdapter();
        public FechamentoDeCaixaForm()
        {
            InitializeComponent();
        }

        private void FechamentoDeCaixaForm_Load(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            string[] itens = new string[6];
            double total = 0;
            // mostrar o periodo
            lbPeriodo.Text = "Fechamento de "+ DateTime.Parse(caixa.GetDataByLast()[0]["caixaAbertura"].ToString()).ToString("dd/MM/yyyy ") +" das " + DateTime.Parse(caixa.GetDataByLast()[0]["caixaAbertura"].ToString()).ToString("hh:mm tt") + " até as " + DateTime.Now.ToString("hh:mm tt") + ".";
            // inserir falores no caixa
            caixa.UpdateQueryFechamento(DateTime.Now, Convert.ToDouble(caixa.GetDataByLast()[0]["caixaValorDinheiro"]), Convert.ToInt32(caixa.GetDataByLast()[0]["idCaixa"]));
            // mostrar resultado das vendas na datagrid
            try
            {
                dataGridView1.DataSource = fechamento.GetData(
                    DateTime.Today.Day,
                    DateTime.Today.Month,
                    DateTime.Today.Year
                    );

                // apresentar sangria
                dataGridView2.DataSource = sangria.GetDataSandria(DateTime.Today.Day, DateTime.Today.Month, DateTime.Today.Year);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            itens[0] = string.Format("{0,-10:C}", Convert.ToDouble(caixa.GetDataByLast()[0]["caixaValorDinheiro"]));
            total += Convert.ToDouble(caixa.GetDataByLast()[0]["caixaValorDinheiro"]);
            itens[1] = string.Format("{0,-10:C}", Convert.ToDouble(caixa.GetDataByLast()[0]["caixaValorCartaoCredito"]));
            total += Convert.ToDouble(caixa.GetDataByLast()[0]["caixaValorCartaoCredito"]);
            itens[2] = string.Format("{0,-10:C}", Convert.ToDouble(caixa.GetDataByLast()[0]["caixaValorCartaoDebito"]));
            total += Convert.ToDouble(caixa.GetDataByLast()[0]["caixaValorCartaoDebito"]);
            itens[3] = string.Format("{0,-10:C}", total);
            itens[4] = string.Format("{0,-10:C}",  Convert.ToDouble(caixa.GetDataByLast()[0]["caixaValorAbertura"]));

            double totalSangria = 0;
            for (int i = 0; i < Convert.ToUInt32(dataGridView2.Rows.Count); i++)
            {
                totalSangria += Convert.ToDouble(dataGridView2[1, i].Value);
            }
            
            itens[5] = string.Format("{0,-10:C}", totalSangria);

            for (int i = 0; i < 6; i++)
            {
                item.SubItems.Add(itens[i]);
            }
            listView1.Items.Add(item);
        }
    }
}

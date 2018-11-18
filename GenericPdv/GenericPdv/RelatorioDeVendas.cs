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
    public partial class RelatorioDeVendas : Form
    {
        DataSetGnPdvTableAdapters.FechamentoTableAdapter fechamento = new DataSetGnPdvTableAdapters.FechamentoTableAdapter();
        DataSetGnPdvTableAdapters.CaixaTableAdapter caixa = new DataSetGnPdvTableAdapters.CaixaTableAdapter();
        DateTime dataIncio, dataFim;
        string Html;
        ListViewItem item = new ListViewItem();
        string[] itens = new string[6];
        string Vendedor;
        bool consultaComVendedor;
        public RelatorioDeVendas(DateTime inicio, DateTime fim, string vendedor, bool tipo)
        {
            dataIncio = inicio;
            dataFim = fim;
            consultaComVendedor = tipo;
            Vendedor = vendedor;
            InitializeComponent();
        }

        private void RelatorioDeVendas_Load(object sender, EventArgs e)
        {
            lbPeriodo.Text = "Fechamento de " + 
                DateTime.Parse(dataIncio.ToString()).ToString("dd/MM/yyyy ") +
                " até " + DateTime.Parse(dataFim.ToString()).ToString("dd/MM/yyyy ") + ".";

            if (consultaComVendedor)
            {
                dataGridView1.DataSource = fechamento.GetDataByFunc(dataIncio, dataFim, Vendedor);
            }
            else
            {
                dataGridView1.DataSource = fechamento.GetData(dataIncio, dataFim);
            }

        }
    }
}

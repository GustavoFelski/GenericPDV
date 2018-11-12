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
        DateTime dataIncio, dataFim;
        int idVendedor;
        public RelatorioDeVendas(DateTime inicio, DateTime fim, int vendedor)
        {
            dataIncio = inicio;
            dataFim = fim;
            idVendedor = vendedor;
            InitializeComponent();
        }

        private void RelatorioDeVendas_Load(object sender, EventArgs e)
        {
            DataSetGnPdvTableAdapters.CaixaTableAdapter caixa = new DataSetGnPdvTableAdapters.CaixaTableAdapter();
            lbPeriodo.Text = "Fechamento de " + DateTime.Parse(dataIncio.ToString()).ToString("dd/MM/yyyy ") +" até " + DateTime.Parse(dataFim.ToString()).ToString("dd/MM/yyyy ") + ".";

            //dataGridView1.DataSource = fechamento.GetData(
            //        DateTime.Today.Day,
            //        DateTime.Today.Month,
            //        DateTime.Today.Year
            //        );

        }
    }
}

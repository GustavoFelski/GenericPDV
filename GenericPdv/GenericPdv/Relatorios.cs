using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericPdv
{
    public partial class Relatorios : UserControl
    {
        public Relatorios()
        {
            InitializeComponent();
        }



        private void Relatorios_Load(object sender, EventArgs e)
        {

        }

        private void btPesquisarVendas_Click(object sender, EventArgs e)
        {

            RelatorioDeVendas relatorio = new RelatorioDeVendas(dateTimeInicio.Value, dateTimeFim.Value, 1 );
        }


    }
}

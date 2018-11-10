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
    public partial class ListFuncionario : UserControl
    {
        public ListFuncionario()
        {
            InitializeComponent();
        }

        DataSetGnPdvTableAdapters.FuncionariosCargoTableAdapter func = new DataSetGnPdvTableAdapters.FuncionariosCargoTableAdapter();
        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.funcionariosCargoTableAdapter.Fill(this.dataSetGnPdv.FuncionariosCargo);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.funcionariosCargoTableAdapter.FillBy(this.dataSetGnPdv.FuncionariosCargo, funcNomeToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void ListFuncionario_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = func.GetData();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
           

            CadastroDeFuncionario cadastroDeFuncionario = new CadastroDeFuncionario(false, 1);

        }
    }
}

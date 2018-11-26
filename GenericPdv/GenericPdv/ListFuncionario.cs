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
        int id = 1;

        DataSetGnPdvTableAdapters.funcionarioCargoTableAdapter func = new DataSetGnPdvTableAdapters.funcionarioCargoTableAdapter();

        private void ListFuncionario_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = func.GetData();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            CadastroDeFuncionario cadastroDeFuncionario = new CadastroDeFuncionario(false, id, this);
            cadastroDeFuncionario.ShowDialog();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            }
            catch (Exception ex)
            {
                Alerta alerta = new Alerta("Nenhuma linha selecionada.");
                alerta.ShowDialog();
            }
        }
    }
}

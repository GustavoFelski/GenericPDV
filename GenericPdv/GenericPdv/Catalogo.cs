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
    public partial class Catalogo : UserControl
    {
        int id = 1;
        public Catalogo()
        {
            InitializeComponent();
        }
        DataSetGnPdvTableAdapters.ProdutoTableAdapter produto = new DataSetGnPdvTableAdapters.ProdutoTableAdapter();

        private void fillByIdToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.produtoTableAdapter.FillById(this.dataSetGnPdv.Produto, ((int)(System.Convert.ChangeType(idToolStripTextBox.Text, typeof(int)))));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void Catalogo_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = produto.GetData();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            CadastroDeProduto cadastro = new CadastroDeProduto(false, id, this);
            cadastro.ShowDialog();

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

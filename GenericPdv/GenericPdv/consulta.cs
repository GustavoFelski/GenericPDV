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
    public partial class consulta : Form
    {
        public consulta()
        {
            InitializeComponent();
        }
        DataSetGnPdvTableAdapters.ProdutoTableAdapter produto = new DataSetGnPdvTableAdapters.ProdutoTableAdapter();

        private void btClouse_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtPesquisaNome.Text) && string.IsNullOrEmpty(txtPesquisaId.Text))
                {
                    Alerta alerta = new Alerta("erro");
                    alerta.ShowDialog();
                }
                else
                {
                    // pesquisa por Id 
                    if (string.IsNullOrEmpty(txtPesquisaNome.Text) && !string.IsNullOrEmpty(txtPesquisaId.Text))
                    {
                        try { 
                        dataGridView1.DataSource = produto.GetDataById(Convert.ToInt32(txtPesquisaId.Text));
                        }
                        catch (Exception ex)
                        {
                            Alerta alerta = new Alerta("Produto não encontrado");
                            alerta.ShowDialog();
                        }
                    }
                    // pesquisa por Nome
                    else
                    {
                        try
                        {
                            dataGridView1.DataSource = produto.GetDataByName(txtPesquisaNome.Text);
                        }
                        catch (Exception ex){
                            Alerta alerta = new Alerta("Produto não encontrado");
                            alerta.ShowDialog();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Alerta alerta = new Alerta("erro:" + ex.Message);
                alerta.ShowDialog();
            }
        }
        private void txtPesquisaId_TextChanged(object sender, EventArgs e)
        {
            txtPesquisaNome.Enabled = false;
        }

        private void txtPesquisaNome_TextChanged(object sender, EventArgs e)
        {
            txtPesquisaId.Enabled = false;
        }

        private void consulta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Escape")
            {
                this.Close();
            }
            if(e.KeyCode.ToString() == "Enter")
            {
                btConsulta_Click(sender, e);
            }

        }
    }
}

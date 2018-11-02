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
            if (string.IsNullOrEmpty(txtPesquisa.Text)) { return; }
            try
            {
                var prod = produto.GetDataById(Convert.ToInt32(txtPesquisa.Text));
                txtCodigo.Text = (prod[0]["idProduto"].ToString());
                txtBarras.Text = (prod[0]["prodCodBarras"].ToString());
                txtNome.Text = (prod[0]["prodNome"].ToString());
                txtMarca.Text = (prod[0]["prodMarca"].ToString());
                txtValorDe.Text = (prod[0]["prodVenda"].ToString());
                txtValorPor.Text = (prod[0]["prodDesconto"].ToString());
                txtDataFim.Text = (prod[0]["prodDataFim"].ToString());
                txtPesquisa.Focus();
                txtPesquisa.Text = "";
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

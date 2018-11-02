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
        DataSetGnPdvTableAdapters.FuncionarioTableAdapter funcionario = new DataSetGnPdvTableAdapters.FuncionarioTableAdapter();
        DataSetGnPdvTableAdapters.SangriaTableAdapter sangria = new DataSetGnPdvTableAdapters.SangriaTableAdapter();
        public double valorCaixa { get; set; }
        string usuario;
        int id;

        public Sangria(string usuario, int id)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.id = id;
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            //criar mensagem de confirmação
            try
            {
                sangria.InsertQuery(id , DateTime.Now, Convert.ToDouble(txtNovoValor.Text));
                AberturaDeCaixa.valorDeCaixa = Convert.ToDouble(txtNovoValor.Text);
                MessageBox.Show("Valor Atualizado");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btClouse_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Sangria_Load(object sender, EventArgs e)
        {
            
            try
            {
                var san = sangria.GetData();
                txtCaixa.Text = AberturaDeCaixa.valorDeCaixa.ToString();
                lbUsuario.Text = usuario;
                lbData.Text = DateTime.Now.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

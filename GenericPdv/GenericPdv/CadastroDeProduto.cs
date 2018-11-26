using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GenericPdv
{
    public partial class CadastroDeProduto : Form
    {
        bool tipoDeAbertura;
        int id;
        Catalogo catalogoA;

        public CadastroDeProduto(bool tipo, int idSelecionado, Catalogo catalogo)
        {
            id = idSelecionado;
            tipoDeAbertura = tipo;
            InitializeComponent();
            catalogoA = catalogo;
        }

        DataSetGnPdvTableAdapters.ProdutoTableAdapter produto = new DataSetGnPdvTableAdapters.ProdutoTableAdapter();
        
        #region conversão de moeda
        // conversão de moeda
        private void RetornarMascara(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.Text = double.Parse(txt.Text).ToString("C2");
        }
        private void TirarMascara(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.Text = txt.Text.Replace("R$", "").Trim();
        }
        private void ApenasValorNumerico(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txt.Text.Contains(','));
                }
                else
                    e.Handled = true;
            }
        }
        private void AplicarEventos(TextBox txt)
        {
            txt.Enter += TirarMascara;
            txt.Leave += RetornarMascara;
            txt.KeyPress += ApenasValorNumerico;
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            if (tipoDeAbertura)
            {
                //Design

                btSalvar.Enabled = true;
                btDeletar.Visible = true;
                BtCancelar.Enabled = false;
                btNovo.Enabled = false;

                textId.Enabled = false;
                textNome.Enabled = true;
                textCodBarra.Enabled = true;
                textCodForne.Enabled = true;
                textMarca.Enabled = true;
                textQuantidade.Enabled = true;
                ckbStatus.Enabled = true;
                mkbCusto.Enabled = true;
                mkbVenda.Enabled = true;

                mkbPromocao.Enabled = true;
                dtpInicio.Enabled = true;
                dtpFim.Enabled = true;

                var last = produto.GetDataByLastProd();
                textId.Text = (Convert.ToInt32(last[0]["idProduto"]) + 1).ToString();
                textNome.Text = "";
                textCodBarra.Text = "";
                textCodForne.Text = "";
                textMarca.Text = "";
                textQuantidade.Text = "";
                ckbStatus.Checked = true;
                mkbCusto.Text = "";
                mkbVenda.Text = "";

                mkbPromocao.Text = "";
                dtpInicio.Text = "";
                dtpFim.Text = "";
                // logica

            }
            else
            {
                btSalvar.Enabled = true;
                btDeletar.Visible = true;
                BtCancelar.Enabled = true;
                btNovo.Visible = false;

                textId.Enabled = false;
                textNome.Enabled = true;
                textCodBarra.Enabled = true;
                textCodForne.Enabled = true;
                textMarca.Enabled = true;
                textQuantidade.Enabled = true;
                ckbStatus.Enabled = true;
                mkbCusto.Enabled = true;
                mkbVenda.Enabled = true;

                mkbPromocao.Enabled = true;
                dtpInicio.Enabled = true;
                dtpFim.Enabled = true;


                // Terminar isso aqui 
                var temp = produto.GetDataById(id);
                textId.Text = Convert.ToString(temp[0]["idProduto"]);
                textNome.Text = Convert.ToString(temp[0]["prodNome"]);
                textCodBarra.Text = Convert.ToString(temp[0]["prodCodBarras"]);
                textCodForne.Text = Convert.ToString(temp[0]["prodCodFonecedor"]);
                textMarca.Text = Convert.ToString(temp[0]["prodMarca"]);
                textQuantidade.Text = Convert.ToString(temp[0]["prodQuantidade"]);
                ckbStatus.Checked = Convert.ToBoolean(temp[0]["prodStatus"]);
                mkbCusto.Text = Convert.ToString(temp[0]["prodCusto"]);
                mkbVenda.Text = Convert.ToString(temp[0]["prodVenda"]);
                mkbPromocao.Text = Convert.ToString(temp[0]["prodDesconto"]);
                dtpInicio.Text = Convert.ToString(temp[0]["prodDataInicio"]);
                dtpFim.Text = Convert.ToString(temp[0]["prodDataFim"]);
            }
        
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            //Design
            btSalvar.Enabled = true;
            btDeletar.Enabled = false;
            BtCancelar.Enabled = true;
            btNovo.Enabled = false;

            textId.Enabled = true;
            textNome.Enabled = true;
            textCodBarra.Enabled = true;
            textCodForne.Enabled = true;
            textMarca.Enabled = true;
            textQuantidade.Enabled = true;
            ckbStatus.Enabled = true;
            mkbCusto.Enabled = true;
            mkbVenda.Enabled = true;
            
            mkbPromocao.Enabled = true;
            dtpInicio.Enabled = true;
            dtpInicio.Enabled = true;

            textId.Text = "";
            textNome.Text = "";
            textCodBarra.Text = "";
            textCodForne.Text = "";
            textMarca.Text = "";
            textQuantidade.Text = "";
            ckbStatus.Enabled = true;
            mkbCusto.Text = "";
            mkbVenda.Text = "";
            
            mkbPromocao.Text = "";
            dtpInicio.Text = "";
            dtpFim.Text = "";

            //Logica
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            //Design
            btSalvar.Enabled = false;
            btDeletar.Enabled = false;
            BtCancelar.Enabled = false;
            btNovo.Enabled = true;

            textId.Enabled = false;
            textNome.Enabled = false;
            textCodBarra.Enabled = false;
            textCodForne.Enabled = false;
            textMarca.Enabled = false;
            textQuantidade.Enabled = false;
            ckbStatus.Enabled = false;
            mkbCusto.Enabled = false;
            mkbVenda.Enabled = false;
            
            mkbPromocao.Enabled = false;
            dtpInicio.Enabled = false;
            dtpInicio.Enabled = false;

            textId.Text = "";
            textNome.Text = "";
            textCodBarra.Text = "";
            textCodForne.Text = "";
            textMarca.Text = "";
            textQuantidade.Text = "";
            ckbStatus.Enabled = false;
            mkbCusto.Text = "";
            mkbVenda.Text = "";
            
            mkbPromocao.Text = "";
            dtpInicio.Text = "";
            dtpFim.Text = "";

            //Logica
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            //Design
            btSalvar.Enabled = false;
            btDeletar.Enabled = false;
            BtCancelar.Enabled = false;
            btNovo.Enabled = true;

            textId.Enabled = false;
            textNome.Enabled = false;
            textCodBarra.Enabled = false;
            textCodForne.Enabled = false;
            textMarca.Enabled = false;
            textQuantidade.Enabled = false;
            ckbStatus.Enabled = false;
            mkbCusto.Enabled = false;
            mkbVenda.Enabled = false;
            
            mkbPromocao.Enabled = false;
            dtpInicio.Enabled = false;
            dtpFim.Enabled = false;

            //Logica
            if (tipoDeAbertura)
            {
                //se novo cadastro
                try
                {
                    produto.InsertQueryProd(
                        Convert.ToInt32(textId.Text),
                        textNome.Text,
                        Convert.ToDouble(mkbVenda.Text),
                        Convert.ToDouble(mkbCusto.Text),
                        Convert.ToDateTime(dtpInicio.Value),
                        Convert.ToInt32(textQuantidade.Text),
                        Convert.ToDouble(mkbPromocao.Text),
                        Convert.ToDateTime(dtpFim.Value),
                        textCodBarra.Text,
                        textMarca.Text,
                        textCodForne.Text,
                        ckbStatus.Checked);
                    catalogoA.dataGridView1.DataSource = produto.GetData();
                    //Design
                    textId.Text = "";
                    textNome.Text = "";
                    textCodBarra.Text = "";
                    textCodForne.Text = "";
                    textMarca.Text = "";
                    textQuantidade.Text = "";
                    ckbStatus.Enabled = false;
                    mkbCusto.Text = "";
                    mkbVenda.Text = "";

                    mkbPromocao.Text = "";
                    dtpInicio.Text = "";
                    dtpFim.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            else
            {
                bool status;
                if (ckbStatus.Checked)
                {
                    status = true;
                }else
                {
                    status = false;
                }

                produto.UpdateProd(
                    Convert.ToInt32(textId.Text),
                    textNome.Text,
                    Convert.ToDouble(mkbVenda.Text),
                    Convert.ToDouble(mkbCusto.Text),
                    Convert.ToDateTime(dtpInicio.Value),
                    Convert.ToInt32(textQuantidade.Text),
                    Convert.ToDouble(mkbPromocao.Text),
                    Convert.ToDateTime(dtpFim.Value),
                    textCodBarra.Text,
                    textMarca.Text,
                    textCodForne.Text,
                    status
                    );

                Alerta alerta = new Alerta("Alteração concluida.");
                alerta.ShowDialog();
                catalogoA.dataGridView1.DataSource = produto.GetData();
                this.Dispose();
            }
        }

        private void btDeletar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja excluir este produto?\nVocê pode Apenas desabilitalo.", "Cuidado!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Alerta alerta = new Alerta("Operação Concluida");
                produto.DeleteProd(Convert.ToInt32(textId.Text));
                catalogoA.dataGridView1.DataSource = produto.GetData();
                alerta.ShowDialog();
                this.Dispose();
            }
            else
            {
                Alerta alerta = new Alerta("Operação cancelada.");
                alerta.ShowDialog();
            }
        }

        private void CadastroDeProduto_FormClosing(object sender, FormClosingEventArgs e)
        {
            catalogoA.dataGridView1.DataSource = produto.GetData();
            this.Dispose();
        }
    }
}
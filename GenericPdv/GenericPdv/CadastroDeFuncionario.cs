using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace GenericPdv
{
    public partial class CadastroDeFuncionario : Form
    {
        DataSetGnPdvTableAdapters.FuncionarioTableAdapter funcionario = new DataSetGnPdvTableAdapters.FuncionarioTableAdapter();
        
        bool tipoDeAbertura;
        int id;
        ListFuncionario func;

        public CadastroDeFuncionario(bool tipo, int idSelecionado, ListFuncionario ionario)
        {
            InitializeComponent();
            id = idSelecionado;
            tipoDeAbertura = tipo;
            func = ionario;

        }

        private void CadastroDeFuncionario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSetGnPdv.Cargo'. Você pode movê-la ou removê-la conforme necessário.
            this.cargoTableAdapter.Fill(this.dataSetGnPdv.Cargo);

            if (tipoDeAbertura)
            {
                btSalvar.Enabled = false;
                btDeletar.Enabled = false;
                btDeletar.Visible = false;
                btNovo.Enabled = true;
                BtCancelar.Enabled = false;

                textId.Enabled = false;
                textNome.Enabled = false;
                textEmail.Enabled = false;
                mkbTelefone.Enabled = false;
                cbbCargo.Enabled = false;
                textAcesso.Enabled = false;
                cbbStatus.Enabled = false;
                ckbReset.Enabled = false;

                //MessageBox.Show(Convert.ToString(Convert.ToInt32(funcionario.GetDataByLast()[0]["idFuncionario"]) + 1));
                textId.Text = (Convert.ToString(Convert.ToInt32(funcionario.GetDataByLast()[0]["idFuncionario"]) + 1));
                textNome.Text = "";
                textEmail.Text = "";
                mkbTelefone.Text = "";
                cbbCargo.SelectedItem = "";
                textAcesso.Text = "";
                cbbStatus.SelectedItem = 1;

            }
            else
            {
                btSalvar.Enabled = true;
                btDeletar.Enabled = true;
                btNovo.Visible = false;
                btNovo.Enabled = false;
                BtCancelar.Enabled = true;

                var temp = funcionario.GetDataBy1(this.id);
                textId.Text = temp[0]["idFuncionario"].ToString();
                textNome.Text = temp[0]["funcNome"].ToString();
                textEmail.Text = temp[0]["funcEmail"].ToString();
                mkbTelefone.Text = temp[0]["funcTelefone"].ToString();
                cbbCargo.SelectedIndex = Convert.ToInt32(temp[0]["idCargo"]);
                textAcesso.Text = temp[0]["funcAliase"].ToString();
                cbbStatus.SelectedIndex = Convert.ToInt32(Convert.ToBoolean(temp[0]["funcStatus"]));
                ckbReset.Checked = Convert.ToBoolean(temp[0]["funcReset"]);

            }
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            //design
            btSalvar.Enabled = true;
            btNovo.Enabled = false;
            BtCancelar.Enabled = true;

            textId.Enabled = false;
            textNome.Enabled = true;
            textEmail.Enabled = true;
            mkbTelefone.Enabled = true;
            cbbCargo.Enabled = true;
            textAcesso.Enabled = true;
            cbbStatus.Enabled = true;
            ckbReset.Enabled = false;
            ckbReset.Checked = true;

            textId.Text = (Convert.ToString(Convert.ToInt32(funcionario.GetDataByLast()[0]["idFuncionario"]) + 1));
            textNome.Text = "";
            textEmail.Text = "";
            mkbTelefone.Text = "";
            cbbCargo.SelectedItem = "";
            textAcesso.Text = "";
            cbbStatus.SelectedItem = 1;

        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            //Design
            btSalvar.Enabled = false;
            btDeletar.Enabled = false;
            btNovo.Enabled = true;
            BtCancelar.Enabled = false;

            textId.Enabled = false;
            textNome.Enabled = false;
            textEmail.Enabled = false;
            mkbTelefone.Enabled = false;
            cbbCargo.Enabled = false;
            textAcesso.Enabled = false;
            cbbStatus.Enabled = false;
            ckbReset.Enabled = false;


            textId.Text = "";
            textNome.Text = "";
            textEmail.Text = "";
            mkbTelefone.Text = "";
            cbbCargo.Text = "";
            ckbReset.Checked = false;


        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            //Design
            //Logica
            if (tipoDeAbertura)
            {
                string email = textEmail.Text;
                Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

                if (!rg.IsMatch(email))
                {
                    Alerta alerta = new Alerta("Email não valido!");
                    textEmail.Focus();
                    textEmail.Text = "";
                    alerta.ShowDialog();
                }
                else
                {
                    MessageBox.Show(cbbCargo.SelectedIndex.ToString());
                    string str;
                    if(cbbCargo.SelectedIndex == 0)
                    {
                        str = GerarHashMd5("ADM123");
                    }
                    else
                    {
                        str = "";
                    }


                    try
                    {


                        funcionario.InsertQuery(
                            
                            Convert.ToInt32(cbbCargo.SelectedIndex),
                            textNome.Text,
                            mkbTelefone.Text,
                            str,
                            true,
                            Convert.ToBoolean(cbbStatus.SelectedIndex),
                            textEmail.Text,
                            textAcesso.Text
                            );
                        btSalvar.Enabled = false;
                        btDeletar.Enabled = false;
                        btNovo.Enabled = true;
                        BtCancelar.Enabled = false;

                        textId.Enabled = false;
                        textNome.Enabled = false;
                        textEmail.Enabled = false;
                        mkbTelefone.Enabled = false;
                        cbbCargo.Enabled = false;
                        textAcesso.Enabled = false;
                        cbbStatus.Enabled = false;
                        ckbReset.Enabled = false;

                        //Design

                        textId.Text = "";
                        textNome.Text = "";
                        textEmail.Text = "";
                        mkbTelefone.Text = "";
                        cbbCargo.Text = "";
                        ckbReset.Checked = false;
                        textAcesso.Text = "";
                    }
                    catch (Exception ex)
                    {
                        Alerta alerta = new Alerta("Por Favor Preencha todos os campos para realizar o cadastro");
                        alerta.ShowDialog();
                    }
                }
            }
            else
            {

                try
                {
                    funcionario.UpdateFuncionario(
                    Convert.ToInt32(cbbCargo.SelectedIndex),
                    textNome.Text,
                    mkbTelefone.Text,
                    null,
                    true,
                    Convert.ToBoolean(cbbStatus.SelectedIndex),
                    textEmail.Text,
                    textAcesso.Text,
                    Convert.ToInt32(textId.Text)
                );
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                this.Dispose();
            }
            // func.dataGridView1.DataSource = funcionario.GetData();
        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Realmente Deletar os dados deste Usuario?\nVocê pode apenas Desabilita-lo", "Cuidado", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //Logica
                funcionario.DeleteQuery(Convert.ToInt32(textId.Text));
                Alerta alerta = new Alerta("Funcionario Deletado");
                func.dataGridView1.DataSource = funcionario.GetData();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Operação cancelada com sucesso.");
            }
        }

        public static string GerarHashMd5(string input)
        {
            MD5 md5Hash = MD5.Create();
            // Converter a String para array de bytes, que é como a biblioteca trabalha.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Cria-se um StringBuilder para recompôr a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop para formatar cada byte como uma String em hexadecimal
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }
    }
}

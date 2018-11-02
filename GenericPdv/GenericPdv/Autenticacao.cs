using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace GenericPdv
{
    public partial class Autenticacao : Form
    {
        public Autenticacao()
        {
            InitializeComponent();
        }

        private bool nome = false;
        private bool Senha = false;
        DataSetGnPdvTableAdapters.FuncionarioTableAdapter func = new DataSetGnPdvTableAdapters.FuncionarioTableAdapter();
        AberturaDeCaixaForm aberturaDeCaixa = new AberturaDeCaixaForm();
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

        private void Autenticacao_Load(object sender, EventArgs e)
        {
            aberturaDeCaixa.Close();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textNome_Leave(object sender, EventArgs e)
        {
            var temp = func.GetDataByAliase(textNome.Text);
            try
            {
                if (textNome.Text.ToUpper() == temp[0]["funcAliase"].ToString().ToUpper())
                {
                    nome = true;
                    if (temp[0]["funcSenha"].ToString() == "")
                    {
                        MessageBox.Show("para este usuario ainda não cadastrado");
                        novaSenha nova = new novaSenha(temp[0]["funcAliase"].ToString());
                        nova.Show();
                    }
                }
                else
                {
                    label1.Text += " (erro usuario)";
                    textNome.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textSenha_Leave(object sender, EventArgs e)
        {
            
            var temp = func.GetDataByAliase(textNome.Text);
            //textSenha Converter para md5
            if (temp[0]["funcSenha"].ToString() == GerarHashMd5(textSenha.Text))
            {
                Senha = true;
            }
            else
            {
                label2.Text += " (erro senha)";
            }
        }

        private void btAcessar_Click(object sender, EventArgs e)
        {
            var temp = func.GetDataByAliase(textNome.Text);

            if (Senha == true && nome == true)
            {
                this.Hide();
                switch (temp[0]["idCargo"].ToString())
                {
                case "0":
                    {
                        AutenticacaoDeFuncionario.funcLogado = textNome.Text;
                        AutenticacaoDeFuncionario.Date = DateTime.Now;
                        AutenticacaoDeFuncionario.idFuncionario = Convert.ToInt32(temp[0]["idCargo"]);
                        Admin admin = new Admin();
                        admin.Show();
                    }
                    break;

                case "1":
                    {
                        AutenticacaoDeFuncionario.funcLogado = textNome.Text;
                        AutenticacaoDeFuncionario.Date = DateTime.Now;
                        AutenticacaoDeFuncionario.idFuncionario = Convert.ToInt32(temp[0]["idCargo"]);
                        aberturaDeCaixa.Show();
                    }
                    break;

                case "2":
                    {
                        AutenticacaoDeFuncionario.funcLogado = textNome.Text;
                        AutenticacaoDeFuncionario.Date = DateTime.Now;
                        AutenticacaoDeFuncionario.idFuncionario = Convert.ToInt32(temp[0]["idCargo"]);
                        // Abrir tela de admin com restrições
                        Admin admin = new Admin();
                        admin.Show();
                    }
                    break;
                default:
                    {
                        MessageBox.Show("erro de cargo");this.Show();
                    }
                    break;
                }
            }
        }
    }
}

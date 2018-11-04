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
    public partial class AutenticacaoValidacao : Form
    {
        int contexto;
        public AutenticacaoValidacao(int contexto)
        {
            this.contexto = contexto;
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
            
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textNome_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textNome.Text)) { label1.Text += "*"; }
            else
            {
                var temp = func.GetDataByAliase(textNome.Text);
                try
                {
                    if (textNome.Text.ToUpper() == temp[0]["funcAliase"].ToString().ToUpper())
                    {
                        nome = true;
                        if ((temp[0]["funcSenha"].ToString() == ""))
                        {
                            Alerta alerta = new Alerta("Você ainda não tem uma senha cadastrada.\nPor favor entre uma nova senha.");
                            alerta.ShowDialog();
                            novaSenha nova = new novaSenha(temp[0]["funcAliase"].ToString());
                            nova.ShowDialog();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Alerta alerta = new Alerta("Usuário não encontrado.");
                    alerta.ShowDialog();
                    textNome.Focus();
                    textNome.Text = "";
                }
            }
        }

        private void textSenha_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textSenha.Text)) { label2.Text += "*"; }
            else
            {
                var temp = func.GetDataByAliase(textNome.Text);
                //textSenha Converter para md5
                if (temp[0]["funcSenha"].ToString() == GerarHashMd5(textSenha.Text))
                {
                    Senha = true;
                }
                else
                {
                    Alerta alerta = new Alerta("Erro na senha");
                    alerta.ShowDialog();
                    textSenha.Text = "";
                    textSenha.Focus();
                }
            }
        }

        private void btAcessar_Click(object sender, EventArgs e)
        {
            bool liberar = true;
            if (string.IsNullOrEmpty(textNome.Text)) { liberar = false; textNome.Focus(); }
            if (string.IsNullOrEmpty(textNome.Text)) { liberar = false; textSenha.Focus(); }
            if (liberar)
            {
                var temp = func.GetDataByAliase(textNome.Text);

                if (Senha == true && nome == true)
                {
                    switch (temp[0]["idCargo"].ToString())
                    {
                        case "0":
                            {
                                switch (contexto)
                                {
                                    //Trocar de usuário
                                    case 1:
                                        //AutenticacaoDeFuncionario.funcLogado = textNome.Text;
                                        //AutenticacaoDeFuncionario.Date = DateTime.Now;
                                        //AutenticacaoDeFuncionario.idFuncionario = Convert.ToInt32(temp[0]["idCargo"]);
                                        break;
                                    //Sandria
                                    case 2:
                                        Sangria sangria = new Sangria( Convert.ToInt32(temp[0]["idFuncionario"]));
                                        sangria.ShowDialog();
                                        break;
                                    //Fechamento
                                    case 3:
                                        // chamar tela de confirmação
                                            // se sim 
                                            FechamentoDeCaixaForm fechamento = new FechamentoDeCaixaForm();
                                            fechamento.ShowDialog();
                                            // fechar a frente de caixa ao fechar essa tela
                                        // se não voltar a frente de Caixa
                                        break;
                                }
                            }
                            break;
                        case "1":
                            {
                                switch (contexto)
                                {
                                    //Trocar de usuário
                                    case 1: break;
                                    //Sandria
                                    case 2:
                                        Sangria sangria = new Sangria(Convert.ToInt32(temp[0]["idFuncionario"]));
                                        sangria.ShowDialog();
                                        break;
                                    //Fechamento
                                    case 3:
                                        // chamar tela de confirmação
                                            // se sim 
                                            FechamentoDeCaixaForm fechamento = new FechamentoDeCaixaForm();
                                            fechamento.ShowDialog();
                                            // fechar a frente de caixa ao fechar essa tela
                                        // se não voltar a frente de caixa
                                        break;
                                }
                            }
                            break;

                        case "2":
                            {
                                switch (contexto)
                                {
                                    //Trocar de usuário
                                    case 1: break;
                                }
                            }
                            break;
                    }
                }
            }
            else
            {
                Alerta alerta = new Alerta("Você preencher todos os campos.");
                alerta.ShowDialog();
                textNome.Focus();
            }

        }
    }
}

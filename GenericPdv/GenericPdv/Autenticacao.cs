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

        public bool RespConfirmacao;
        private bool nome = false;
        private bool Senha = false;
        DataSetGnPdvTableAdapters.FuncionarioTableAdapter func = new DataSetGnPdvTableAdapters.FuncionarioTableAdapter();
        DataSetGnPdvTableAdapters.CaixaTableAdapter caixa = new DataSetGnPdvTableAdapters.CaixaTableAdapter();

        public Autenticacao()
        {
            InitializeComponent();
        }

        // encriptar senha
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
            if (string.IsNullOrEmpty(textNome.Text)) { liberar = false; textSenha.Focus();  }
            if (liberar)
            {
                var temp = func.GetDataByAliase(textNome.Text);

                if (Senha == true && nome == true)
                {
                    this.Hide();
                    AutenticacaoDeFuncionario.funcLogado = textNome.Text;
                    AutenticacaoDeFuncionario.Date = DateTime.Now;
                    AutenticacaoDeFuncionario.idFuncionario = Convert.ToInt32(temp[0]["idFuncionario"]);
                    AutenticacaoDeFuncionario.idCargo = Convert.ToInt32(temp[0]["idCargo"]);
                    switch (temp[0]["idCargo"].ToString())
                    {
                        case "0":
                            {
                                //Verificar se o caixa ja foi fechado anteriormente

                                if (string.IsNullOrEmpty(caixa.GetDataByLast()[0]["caixaFechamento"].ToString()))
                                {
                                    Alerta alerta = new Alerta("Existe um fechamento ainda aberto.");
                                    alerta.ShowDialog();
                                    Sangria sangria = new Sangria(Convert.ToInt32(temp[0]["idFuncionario"]));
                                    sangria.ShowDialog();
                                    FechamentoDeCaixaForm fechamento = new FechamentoDeCaixaForm();
                                    fechamento.ShowDialog();
                                }
                                AberturaDeCaixaForm aberturaDeCaixa = new AberturaDeCaixaForm();
                                aberturaDeCaixa.Show();
                                Admin admin = new Admin(true);
                                admin.Show();
                            }
                            break;
                        case "1":
                            {
                                //Verificar se o caixa ja foi fechado anteriormente
                                //MessageBox.Show(caixa.GetDataByLast()[0]["caixaFechamento"].ToString());
                                if (string.IsNullOrEmpty(caixa.GetDataByLast()[0]["caixaFechamento"].ToString()))
                                {
                                    Alerta alerta = new Alerta("Existe um fechamento ainda aberto.");
                                    alerta.ShowDialog();
                                    Sangria sangria = new Sangria(Convert.ToInt32(temp[0]["idFuncionario"]));
                                    sangria.ShowDialog();
                                    FechamentoDeCaixaForm fechamento = new FechamentoDeCaixaForm();
                                    fechamento.ShowDialog();
                                }
                                AberturaDeCaixaForm aberturaDeCaixa = new AberturaDeCaixaForm();
                                aberturaDeCaixa.Show();

                            }
                            break;

                        case "2":
                            {
                                // Abrir tela de admin com restrições
                                Admin admin = new Admin(false);
                                admin.Show();
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

        private void btRecuperar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textNome.Text))
            {
                Alerta alerta = new Alerta("Entre o nome de acesso para proceguir.");
                alerta.ShowDialog();
                textNome.Focus();

            }else
            {
                var temp = func.GetDataByAliase(textNome.Text);
                if (Convert.ToInt32(temp[0]["idCargo"]) == 1 || Convert.ToInt32(temp[0]["idCargo"]) == 2)
                {

                    if (MessageBox.Show("Sua senha atual será apagada e necessita da autorização do administrador para Cadastrar uma nova senha, deseja continuar?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        func.UpdateQuerySenha(null, false, textNome.Text);
                        Alerta alerta = new Alerta("Operação realizada com sucesso.");
                        alerta.ShowDialog();

                    }
                    else
                    {
                        textNome.Text = "";
                        textNome.Focus();
                    }
                }
                else {

                    // fazer depois uma logica para recuperar a senha do admin
                    if (MessageBox.Show("Sua senha atual voltará a senha padrão do sistema deseja continuar?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        func.UpdateQuerySenha(GerarHashMd5("ADM123"), false, textNome.Text);
                        Alerta alerta = new Alerta("Operação realizada com sucesso.");
                        alerta.ShowDialog();
                    }
                    else
                    {
                        textNome.Text = "";
                        textNome.Focus();
                    }
                }
            }
        }

        private void lbAjuda_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {  
            Reprodutor ajuda = new Reprodutor(@"C:\Users\Dokahviin\source\repos\GenericPdv\GenericPdv\Ajuda\login.mp4");
            ajuda.Show();
        }


    }
}

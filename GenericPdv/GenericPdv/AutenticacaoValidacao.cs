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
                                    
                                    case 1:
                                        #region Trocar de usuário - incompleto
                                        //qual era o cargo do usuário anterior logado?
                                        //qual o cargo de quem pretende logar?

                                        //admim para admim
                                        if (AutenticacaoDeFuncionario.idCargo == 0)
                                        {
                                            AutenticacaoDeFuncionario.funcLogado = textNome.Text;
                                            AutenticacaoDeFuncionario.Date = DateTime.Now;
                                            AutenticacaoDeFuncionario.idFuncionario = Convert.ToInt32(temp[0]["idFuncionario"]);
                                        }
                                        //admim para caixa
                                        if(AutenticacaoDeFuncionario.idCargo == 1)
                                        {
                                            // fecha frente de caixa
                                            AutenticacaoDeFuncionario.funcLogado = textNome.Text;
                                            AutenticacaoDeFuncionario.Date = DateTime.Now;
                                            AutenticacaoDeFuncionario.idFuncionario = Convert.ToInt32(temp[0]["idFuncionario"]);

                                            //abre a frente de caixa
                                            // verificar se o caixa foi aberto anteriormente, se sim
                                            FrenteDeCaixa caixa = new FrenteDeCaixa();
                                            caixa.Show();
                                            // se não apresentar abertura 


                                            //abre a tela de administrador
                                            Admin admin = new Admin(true);
                                            admin.Show();
                                        }
                                        //admim para estoquista
                                        if (AutenticacaoDeFuncionario.idCargo == 2)
                                        {
                                            //fecha a tela de caixa
                                            //fecha tela de admin
                                            AutenticacaoDeFuncionario.funcLogado = textNome.Text;
                                            AutenticacaoDeFuncionario.Date = DateTime.Now;
                                            AutenticacaoDeFuncionario.idFuncionario = Convert.ToInt32(temp[0]["idFuncionario"]);

                                            //Abre deta de admin tipo 2
                                            Admin estoquista = new Admin(false);
                                            estoquista.Show();
                                        }
                                        #endregion 
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
                                            Sangria sangria1 = new Sangria(Convert.ToInt32(temp[0]["idFuncionario"]));
                                            sangria1.Show();
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
                                    case 1:
                                        #region Trocar de usuário incompleto
                                        //qual era o cargo do usuário anterior logado?
                                        //qual o cargo de quem pretende logar?

                                        //caixa para admim
                                        if (AutenticacaoDeFuncionario.idCargo == 0)
                                        {
                                            // fecha frente de caixa
                                            // atualiza dados de acesso
                                            AutenticacaoDeFuncionario.funcLogado = textNome.Text;
                                            AutenticacaoDeFuncionario.Date = DateTime.Now;
                                            AutenticacaoDeFuncionario.idFuncionario = Convert.ToInt32(temp[0]["idFuncionario"]);

                                            // abre frente de caixa
                                            FrenteDeCaixa caixa = new FrenteDeCaixa();
                                            caixa.Show();
                                            // abre tela de admin tipo 1 
                                            Admin admin = new Admin(true);
                                            admin.Show();
                                        }

                                        //caixa para caixa
                                        if (AutenticacaoDeFuncionario.idCargo == 1)
                                        {
                                            // fechar caixa
                                            AutenticacaoDeFuncionario.funcLogado = textNome.Text;
                                            AutenticacaoDeFuncionario.Date = DateTime.Now;
                                            AutenticacaoDeFuncionario.idFuncionario = Convert.ToInt32(temp[0]["idFuncionario"]);

                                            FrenteDeCaixa caixa = new FrenteDeCaixa();
                                            caixa.Show();
                                        }
                                        //caixa para estoquista
                                        if (AutenticacaoDeFuncionario.idCargo == 2)
                                        {
                                            //fecha a tela de caixa
                                            //fecha tela de admin
                                            AutenticacaoDeFuncionario.funcLogado = textNome.Text;
                                            AutenticacaoDeFuncionario.Date = DateTime.Now;
                                            AutenticacaoDeFuncionario.idFuncionario = Convert.ToInt32(temp[0]["idFuncionario"]);

                                            //Abre deta de admin tipo 2
                                            Admin estoquista = new Admin(false);
                                            estoquista.Show();
                                        }
                                        #endregion 
                                        break;
                                    //Sandria
                                    case 2:
                                        Sangria sangria = new Sangria(Convert.ToInt32(temp[0]["idFuncionario"]));
                                        sangria.ShowDialog();
                                        break;
                                    //Fechamento
                                    case 3:
                                        // chamar tela de confirmação
                                        // se sim 
                                        {
                                            Sangria sangria1 = new Sangria(Convert.ToInt32(temp[0]["idFuncionario"]));
                                            sangria1.ShowDialog();
                                            
                                            FechamentoDeCaixaForm fechamento = new FechamentoDeCaixaForm();
                                            fechamento.ShowDialog();
                                        }
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
                                    case 1:
                                        #region Trocar de usuário incompleto
                                        //qual era o cargo do usuário anterior logado?
                                        //qual o cargo de quem pretende logar?

                                        //estoquista para admim
                                        if (AutenticacaoDeFuncionario.idCargo == 0)
                                        {
                                            // fecha fecha admin tipo 2
                                            // atualiza dados de acesso
                                            AutenticacaoDeFuncionario.funcLogado = textNome.Text;
                                            AutenticacaoDeFuncionario.Date = DateTime.Now;
                                            AutenticacaoDeFuncionario.idFuncionario = Convert.ToInt32(temp[0]["idFuncionario"]);

                                            // abre frente de caixa
                                            FrenteDeCaixa caixa = new FrenteDeCaixa();
                                            caixa.Show();
                                            // abre tela de admin tipo 1 
                                            Admin admin = new Admin(true);
                                            admin.Show();
                                        }

                                        //estoquista para caixa
                                        if (AutenticacaoDeFuncionario.idCargo == 1)
                                        {
                                            // fechar admin tipo 2
                                            // atualiza dados de acesso
                                            AutenticacaoDeFuncionario.funcLogado = textNome.Text;
                                            AutenticacaoDeFuncionario.Date = DateTime.Now;
                                            AutenticacaoDeFuncionario.idFuncionario = Convert.ToInt32(temp[0]["idFuncionario"]);
                                            // abrir frente de caixa
                                            // verificar se o caixa ja foi aberto anteriormente
                                            // se sim
                                            FrenteDeCaixa caixa = new FrenteDeCaixa();
                                            caixa.Show();
                                            // se não 
                                            // apresentar abertura de caixa

                                        }
                                        //caixa para estoquista
                                        if (AutenticacaoDeFuncionario.idCargo == 2)
                                        {
                                            //fecha a tela de caixa
                                            // atualiza dados de acesso
                                            AutenticacaoDeFuncionario.funcLogado = textNome.Text;
                                            AutenticacaoDeFuncionario.Date = DateTime.Now;
                                            AutenticacaoDeFuncionario.idFuncionario = Convert.ToInt32(temp[0]["idFuncionario"]);

                                            //Abre deta de admin tipo 2
                                            Admin estoquista = new Admin(false);
                                            estoquista.Show();
                                        }
                                        #endregion 
                                        break;
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

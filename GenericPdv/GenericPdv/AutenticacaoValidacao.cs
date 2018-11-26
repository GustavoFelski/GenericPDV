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
        FrenteDeCaixa frente;
        Admin admin;
        int contexto;
        public AutenticacaoValidacao(int contexto, FrenteDeCaixa caixa, Admin ad)
        {
            this.contexto = contexto;
            InitializeComponent();
            this.frente = caixa;
            this.admin = ad;
        }
        private bool nome = false;
        private bool Senha = false;
        DataSetGnPdvTableAdapters.FuncionarioTableAdapter func = new DataSetGnPdvTableAdapters.FuncionarioTableAdapter();
        DataSetGnPdvTableAdapters.CaixaTableAdapter caixaTable = new DataSetGnPdvTableAdapters.CaixaTableAdapter();
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

                //MessageBox.Show("estou logando com: " + temp[0]["idCargo"].ToString() + " sou do cargo: "+ AutenticacaoDeFuncionario.idCargo.ToString());
                if (Senha == true && nome == true)
                {
                    
                    switch (temp[0]["idCargo"].ToString())
                    {
                        // indo para admin
                        case "0":
                            {
                                switch (contexto)
                                {
                                    
                                    case 1:
                                        #region Trocar de usuário - incompleto
                                        //qual era o cargo do usuário anterior logado?
                                        //qual o cargo de quem pretende logar?

                                        //Sou admim e estou indo para admim
                                        if (AutenticacaoDeFuncionario.idCargo == 0)
                                        {
                                            //fecha a tela de caixa
                                            frente.Dispose();
                                            frente.Close();

                                            AutenticacaoDeFuncionario.funcLogado = textNome.Text;
                                            AutenticacaoDeFuncionario.Date = DateTime.Now;
                                            AutenticacaoDeFuncionario.idFuncionario = Convert.ToInt32(temp[0]["idFuncionario"]);
                                            AutenticacaoDeFuncionario.idCargo = Convert.ToInt32(temp[0]["idCargo"]);

                                            FrenteDeCaixa caixa = new FrenteDeCaixa();
                                            caixa.Show();
                                        }
                                        //sou caixa e estou indo para admin
                                        if(AutenticacaoDeFuncionario.idCargo == 1)
                                        {
                                            // fecha frente de caixa
                                            frente.Dispose();
                                            frente.Close();
                                            AutenticacaoDeFuncionario.funcLogado = textNome.Text;
                                            AutenticacaoDeFuncionario.Date = DateTime.Now;
                                            AutenticacaoDeFuncionario.idFuncionario = Convert.ToInt32(temp[0]["idFuncionario"]);
                                            AutenticacaoDeFuncionario.idCargo = Convert.ToInt32(temp[0]["idCargo"]);

                                            FrenteDeCaixa caixa = new FrenteDeCaixa();
                                            caixa.Show();
                                            //abre a tela de administrador
                                            Admin admin = new Admin(true);
                                            admin.Show();
                                        }
                                        //sou estoquista estou indo para admin
                                        if (AutenticacaoDeFuncionario.idCargo == 2)
                                        {
                                            //fecha tela de admin
                                            admin.Dispose();
                                            admin.Close();
                                            AutenticacaoDeFuncionario.funcLogado = textNome.Text;
                                            AutenticacaoDeFuncionario.Date = DateTime.Now;
                                            AutenticacaoDeFuncionario.idFuncionario = Convert.ToInt32(temp[0]["idFuncionario"]);
                                            AutenticacaoDeFuncionario.idCargo = Convert.ToInt32(temp[0]["idCargo"]);
                                            //Abre deta de admin 
                                            Admin estoquista = new Admin(true);
                                            estoquista.Show();
                                            if (string.IsNullOrEmpty(caixaTable.GetDataByLast()[0]["caixaFechamento"].ToString()))
                                            {
                                                Alerta alerta = new Alerta("Existe um fechamento ainda aberto.");
                                                alerta.ShowDialog();
                                                Sangria sangria2 = new Sangria(Convert.ToInt32(temp[0]["idFuncionario"]));
                                                sangria2.ShowDialog();
                                                FechamentoDeCaixaForm fechamentoTela = new FechamentoDeCaixaForm();
                                                fechamentoTela.ShowDialog();
                                                AberturaDeCaixaForm abertura = new AberturaDeCaixaForm();
                                                abertura.Show();
                                            }
                                            else
                                            {
                                                FrenteDeCaixa caixa = new FrenteDeCaixa();
                                                caixa.Show();
                                            }

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
                        // indo para caixa
                        case "1":
                            {
                                switch (contexto)
                                {
                                    case 1:
                                        #region Trocar de usuário incompleto
                                        //qual era o cargo do usuário anterior logado?
                                        //qual o cargo de quem pretende logar?

                                        //eu sou admin indo para o caixa
                                        if (AutenticacaoDeFuncionario.idCargo == 0)
                                        {
                                            // fecha frente de caixa
                                            frente.Dispose();
                                            frente.Close();
                                            // fechar o admin
                                            admin.Dispose();
                                            admin.Close();

                                            // atualiza dados de acesso
                                            AutenticacaoDeFuncionario.funcLogado = textNome.Text;
                                            AutenticacaoDeFuncionario.Date = DateTime.Now;
                                            AutenticacaoDeFuncionario.idFuncionario = Convert.ToInt32(temp[0]["idFuncionario"]);
                                            AutenticacaoDeFuncionario.idCargo = Convert.ToInt32(temp[0]["idCargo"]);
                                            if (string.IsNullOrEmpty(caixaTable.GetDataByLast()[0]["caixaFechamento"].ToString()))
                                            {
                                                Alerta alerta = new Alerta("Existe um fechamento ainda aberto.");
                                                alerta.ShowDialog();
                                                Sangria sangria2 = new Sangria(Convert.ToInt32(temp[0]["idFuncionario"]));
                                                sangria2.ShowDialog();
                                                FechamentoDeCaixaForm fechamentoTela = new FechamentoDeCaixaForm();
                                                fechamentoTela.ShowDialog();
                                                AberturaDeCaixaForm abertura = new AberturaDeCaixaForm();
                                                abertura.Show();
                                            }
                                            else
                                            {
                                                FrenteDeCaixa caixa = new FrenteDeCaixa();
                                                caixa.Show();
                                            }
                                        }
                                        //eu sou o caixa e estou indo para caixa
                                        if (AutenticacaoDeFuncionario.idCargo == 1)
                                        {
                                            // fechar caixa
                                            frente.Dispose();
                                            frente.Close();

                                            AutenticacaoDeFuncionario.funcLogado = textNome.Text;
                                            AutenticacaoDeFuncionario.Date = DateTime.Now;
                                            AutenticacaoDeFuncionario.idFuncionario = Convert.ToInt32(temp[0]["idFuncionario"]);
                                            AutenticacaoDeFuncionario.idCargo = Convert.ToInt32(temp[0]["idCargo"]);
                                            FrenteDeCaixa caixa = new FrenteDeCaixa();
                                            caixa.Show();
                                        }
                                        // eu sou o estoquista e estou idndo para caixa
                                        if (AutenticacaoDeFuncionario.idCargo == 2)
                                        {
                                            // fechar admin tipo 2
                                            admin.Dispose();
                                            admin.Close();
                                            // atualiza dados de acesso
                                            AutenticacaoDeFuncionario.funcLogado = textNome.Text;
                                            AutenticacaoDeFuncionario.Date = DateTime.Now;
                                            AutenticacaoDeFuncionario.idFuncionario = Convert.ToInt32(temp[0]["idFuncionario"]);
                                            AutenticacaoDeFuncionario.idCargo = Convert.ToInt32(temp[0]["idCargo"]);
                                            // abrir frente de caixa
                                            // verificar se o caixa ja foi aberto anteriormente
                                            if (string.IsNullOrEmpty(caixaTable.GetDataByLast()[0]["caixaFechamento"].ToString()))
                                            {
                                                Alerta alerta = new Alerta("Existe um fechamento ainda aberto.");
                                                alerta.ShowDialog();
                                                Sangria sangria2 = new Sangria(Convert.ToInt32(temp[0]["idFuncionario"]));
                                                sangria2.ShowDialog();
                                                FechamentoDeCaixaForm fechamentoTela = new FechamentoDeCaixaForm();
                                                fechamentoTela.ShowDialog();
                                                AberturaDeCaixaForm abertura = new AberturaDeCaixaForm();
                                                abertura.Show();
                                            }
                                            else
                                            {
                                                FrenteDeCaixa caixa = new FrenteDeCaixa();
                                                caixa.Show();
                                            }
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
                        // indo para estoquista
                        case "2":
                            {
                                switch (contexto)
                                {
                                    //Trocar de usuário
                                    case 1:
                                        #region Trocar de usuário incompleto
                                        //qual era o cargo do usuário anterior logado?
                                        //qual o cargo de quem pretende logar?

                                        //eu sou admin indo para estoquista
                                        if (AutenticacaoDeFuncionario.idCargo == 0)
                                        {
                                            // fecha admin
                                            admin.Dispose();
                                            admin.Close();

                                            frente.Dispose();
                                            frente.Close();

                                            // atualiza dados de acesso
                                            AutenticacaoDeFuncionario.funcLogado = textNome.Text;
                                            AutenticacaoDeFuncionario.Date = DateTime.Now;
                                            AutenticacaoDeFuncionario.idFuncionario = Convert.ToInt32(temp[0]["idFuncionario"]);
                                            AutenticacaoDeFuncionario.idCargo = Convert.ToInt32(temp[0]["idCargo"]);
                                            // abre tela de admin tipo 1 
                                            Admin admin2 = new Admin(false);
                                            admin2.Show();
                                        }

                                        //Sou caixa indo para estoquista
                                        if (AutenticacaoDeFuncionario.idCargo == 1)
                                        {
                                            //fechar o caixa
                                            frente.Dispose();
                                            frente.Close();
                                            // atualiza dados de acesso
                                            AutenticacaoDeFuncionario.funcLogado = textNome.Text;
                                            AutenticacaoDeFuncionario.Date = DateTime.Now;
                                            AutenticacaoDeFuncionario.idFuncionario = Convert.ToInt32(temp[0]["idFuncionario"]);
                                            AutenticacaoDeFuncionario.idCargo = Convert.ToInt32(temp[0]["idCargo"]);
                                            //abrir tela do estoquista
                                            Admin admin = new Admin(false);
                                            admin.Show();
                                        }
                                        
                                        //Sou estoquista indo para estoquista
                                        if (AutenticacaoDeFuncionario.idCargo == 2)
                                        {
                                            // atualiza dados de acesso
                                            AutenticacaoDeFuncionario.funcLogado = textNome.Text;
                                            AutenticacaoDeFuncionario.Date = DateTime.Now;
                                            AutenticacaoDeFuncionario.idFuncionario = Convert.ToInt32(temp[0]["idFuncionario"]);
                                            AutenticacaoDeFuncionario.idCargo = Convert.ToInt32(temp[0]["idCargo"]);
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

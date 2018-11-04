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
    public partial class novaSenha : Form
    {
        public novaSenha()
        {
            InitializeComponent();
        }

        private void novaSenha_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
        DataSetGnPdvTableAdapters.FuncionarioTableAdapter func = new DataSetGnPdvTableAdapters.FuncionarioTableAdapter();
        public string usuario { get; set; }

        public novaSenha(string variavel)
        {
            InitializeComponent();
            usuario = variavel;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            { textBox1.Focus(); }
            else
            {
                string aux1, aux2;
                aux1 = GerarHashMd5(textBox1.Text);
                aux2 = GerarHashMd5(textBox2.Text);
                if (aux1 == aux2)
                {
                    func.UpdateQuerySenha(aux1, false, usuario);
                    Alerta alerta = new Alerta("Senha Cadastrada.");
                    alerta.ShowDialog();
                    this.Close();
                }
                else
                {
                    Alerta alerta = new Alerta("Senhas não Conferem.");
                    alerta.ShowDialog();
                    textBox1.Focus();
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
            }
        }
    }
}

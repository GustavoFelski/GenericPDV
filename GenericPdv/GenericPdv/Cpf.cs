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
    public partial class Cpf : Form
    {
        public string cpfCli = "";
        public Cpf()
        {
            InitializeComponent();
            mkbCpf.Focus();
        }

        public bool Valida(string cpf)
        {

            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;

            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11) { return false; }
            tempCpf = cpf.Substring(0, 9);
            soma = 0;
            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            }
            resto = soma % 11;
            if (resto < 2) { resto = 0; }
            else { resto = 11 - resto; }
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
            {
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            }
            resto = soma % 11;
            if (resto < 2) { resto = 0; }
            else { resto = 11 - resto; }
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }

        private void btValidar_Click(object sender, EventArgs e)
        {
            if (Valida(mkbCpf.Text))
            {
                cpfCli = mkbCpf.Text;
                this.Close();
            }
            else
            {
                lbCPF.Visible = true;
                lbCPF.Text = "- Não Valido.";
                mkbCpf.Text = "";
                mkbCpf.Focus();
            }
        }

        private void Cpf_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode.ToString() == "Escape")
            {
                this.Close();
            }
        }
    }
}

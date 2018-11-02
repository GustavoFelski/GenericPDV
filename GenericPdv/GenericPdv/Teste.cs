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
    public partial class Teste : Form
    {
        string[,] itensLista;
        
        public Teste(string[,] itens)
        {

            itensLista = itens;
            InitializeComponent();
            
        }

        private void Teste_Load(object sender, EventArgs e)
        {
            int linha = itensLista.Length / 6;


            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j <= 5; j++)
                {
                    try
                    {
                        lbTeste.Text += itensLista[i,j].ToString() + "\n"; 

                        //Convert.ToInt32(listPagamentos.Items[i].SubItems[3].Text), Convert.ToDouble(listPagamentos.Items[i].SubItems[5].Text), Convert.ToInt32(listPagamentos.Items[i].SubItems[4].Text), Convert.ToInt32(listPagamentos.Items[i].SubItems[1].Text), Convert.ToInt32(LastId));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

        }
    }
}

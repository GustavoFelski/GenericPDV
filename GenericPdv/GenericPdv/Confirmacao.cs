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
    public partial class Confirmacao : Form
    {
        Form instanciaDoForm;


        public Confirmacao(string mensagem, Form form)
        {
            instanciaDoForm = form;
            InitializeComponent();
            lbMensagem.Text = mensagem;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            
            //instanciaDoForm.RespConfirmacao = true;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
        }
    }
}

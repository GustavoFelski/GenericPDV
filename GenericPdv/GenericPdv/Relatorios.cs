using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GenericPdv
{
    public partial class Relatorios : UserControl
    {
        bool tipo = false;
        DataSetGnPdvTableAdapters.FuncionarioTableAdapter funcionario = new DataSetGnPdvTableAdapters.FuncionarioTableAdapter();
        SqlConnection sqlCon = null;
        private string strCon = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=GNPDVBD;Data Source=DOKAHVIIN-NOTE\SQLEXPRESS";
        SqlDataAdapter adaptadorFuncionario;

        public Relatorios()
        {
            InitializeComponent();
        }

        private void Relatorios_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Convert.ToInt32(funcionario.ScalarQuery()); i++)
            {
                cbbVendedor.Items.Add(funcionario.GetData()[i]["funcAliase"].ToString());
            }
        }

        private void btPesquisarVendas_Click(object sender, EventArgs e)
        {
            RelatorioDeVendas relatorio = new RelatorioDeVendas(dateTimeInicio.Value, dateTimeFim.Value, cbbVendedor.Text , tipo);
            relatorio.Show();
        }

        private void cbbVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbbVendedor.Text))
            {
                tipo = false;
            }
            else
                tipo = true;
        }

        private void cbbVendedor_MouseClick(object sender, MouseEventArgs e)
        {
            

            //try
            //{
            //    sqlCon = new SqlConnection(strCon);
            //    adaptadorFuncionario = new SqlDataAdapter("SELECT * FROM Funcionario", sqlCon);
            //    DataTable tFunc = new DataTable();
            //    MessageBox.Show(tFunc.);

            //    for (int i = 0; i < tFunc.Rows.Count; i++)
            //    {
            //        cbbVendedor.Items.Add(tFunc.Rows[i]["funcAlise"].ToString());
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.funcionarioTableAdapter.Fill(this.dataSetGnPdv.Funcionario);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}

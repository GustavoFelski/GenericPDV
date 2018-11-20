using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronPdf;
using System.IO;

namespace GenericPdv
{
    public partial class FechamentoDeCaixaForm : Form
    {
        DataSetGnPdvTableAdapters.FechamentoTableAdapter fechamento = new DataSetGnPdvTableAdapters.FechamentoTableAdapter();
        DataSetGnPdvTableAdapters.CaixaTableAdapter caixa = new DataSetGnPdvTableAdapters.CaixaTableAdapter();
        DataSetGnPdvTableAdapters.FechamentoSangriaTableAdapter sangria = new DataSetGnPdvTableAdapters.FechamentoSangriaTableAdapter();
        string Html;
        ListViewItem item = new ListViewItem();
        string[] itens = new string[6];
        public FechamentoDeCaixaForm()
        {
            InitializeComponent();
        }

        private void FechamentoDeCaixaForm_Load(object sender, EventArgs e)
        {
            double total = 0;
            // mostrar o periodo
            lbPeriodo.Text = "Fechamento de "+ DateTime.Parse(caixa.GetDataByLast()[0]["caixaAbertura"].ToString()).ToString("dd/MM/yyyy ") +" das " + DateTime.Parse(caixa.GetDataByLast()[0]["caixaAbertura"].ToString()).ToString("hh:mm tt") + " até as " + DateTime.Now.ToString("hh:mm tt") + ".";
            // inserir falores no caixa
            caixa.UpdateQueryFechamento(DateTime.Now,
                Convert.ToDouble(caixa.GetDataByLast()[0]["caixaValorDinheiro"]),
                Convert.ToInt32(caixa.GetDataByLast()[0]["idCaixa"]));
            // mostrar resultado das vendas na datagrid
            try
            {
                dataGridView1.DataSource = fechamento.GetData(
                    Convert.ToDateTime(caixa.GetDataByLast()[0]["caixaAbertura"]),
                    Convert.ToDateTime(caixa.GetDataByLast()[0]["caixaFechamento"])
                    );

                // apresentar sangria
                dataGridView2.DataSource = sangria.GetDataSandria(
                    Convert.ToDateTime(caixa.GetDataByLast()[0]["caixaAbertura"]),
                    Convert.ToDateTime(caixa.GetDataByLast()[0]["caixaFechamento"])
                    );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            itens[0] = string.Format("{0,-10:C}", Convert.ToDouble(caixa.GetDataByLast()[0]["caixaValorDinheiro"]));
            total += Convert.ToDouble(caixa.GetDataByLast()[0]["caixaValorDinheiro"]);
            itens[1] = string.Format("{0,-10:C}", Convert.ToDouble(caixa.GetDataByLast()[0]["caixaValorCartaoCredito"]));
            total += Convert.ToDouble(caixa.GetDataByLast()[0]["caixaValorCartaoCredito"]);
            itens[2] = string.Format("{0,-10:C}", Convert.ToDouble(caixa.GetDataByLast()[0]["caixaValorCartaoDebito"]));
            total += Convert.ToDouble(caixa.GetDataByLast()[0]["caixaValorCartaoDebito"]);
            itens[3] = string.Format("{0,-10:C}", total);
            itens[4] = string.Format("{0,-10:C}",  Convert.ToDouble(caixa.GetDataByLast()[0]["caixaValorAbertura"]));

            double totalSangria = 0;

            for (int i = 0; i < Convert.ToUInt32(dataGridView2.Rows.Count); i++)
            {                
                totalSangria += Convert.ToDouble(dataGridView2[1, i].Value);
            }

            itens[5] = string.Format("{0,-10:C}", totalSangria);
            
            for (int i = 0; i < 6; i++)
            {
                item.SubItems.Add(itens[i]);
            }
            listView1.Items.Add(item);
        }

        private void btExporte_Click(object sender, EventArgs e)
        {
            
            string Template = GetTemplate(@"C:\Users\Dokahviin\source\repos\GenericPdv\GenericPdv\FechamentoCaixa.html");
            CabecalhoFechamento();
            this.Html += "<table>";
            CriaLinhaFechamento("Dinheiro", item.SubItems[1].Text);
            CriaLinhaFechamento("Debito", item.SubItems[3].Text);
            CriaLinhaFechamento("Credito", item.SubItems[2].Text);
            CriaLinhaFechamento("Valor total", item.SubItems[4].Text);
            CriaLinhaFechamento("Valor de Abertura", item.SubItems[5].Text);
            CriaLinhaFechamento("Total de Sangria", item.SubItems[6].Text);
            this.Html += "</table>";

            var DocumentoFinal = Template.Replace("{CORPO}", Html);
            string repositorio = @"C:\Users\Dokahviin\source\repos\GenericPdv\GenericPdv\Relatorios\Relatorio_" + DateTime.Now.ToString("dd-MM-yyyy")+".pdf";
            GeraPdf(DocumentoFinal,repositorio, 1);
            // retornar para autenticação
            this.Dispose();
        }

        private string GetTemplate(string Caminho)
        {
            return File.ReadAllText(Caminho);  
        }

        private void CabecalhoFechamento()
        {
            var Imagem = File.ReadAllBytes(@"C:\Users\Dokahviin\source\repos\GenericPdv\GenericPdv\Logo.png");
            var ImagemBase64 = ("data:image/png;base64," + Convert.ToBase64String(Imagem));
            this.Html += "<div class='TextoCentralizado'> <img src='" + ImagemBase64 + "'> <br> " +
                "Fechamento de Caixa - " + DateTime.Now + " </div>";
        }

        private void CriaLinhaFechamento(string Campo, string Valor)
        {
            this.Html += "<tr><th class='AlinhaEsquerda'>" + Campo + "</th> <th class='AlinhaEsquerda'>" + string.Format("{0:C}", Valor) + " </th></tr>";
        }

        public static void GeraPdf(string Html, string Caminho, int Tipo)
        {
            var Gerador = new IronPdf.HtmlToPdf();

            if (Tipo == 1)
            {
                Gerador.PrintOptions.SetCustomPaperSizeinMilimeters(80, 200);
            }
            Gerador.PrintOptions.MarginLeft = 5;
            Gerador.PrintOptions.MarginRight = 5;
            Gerador.PrintOptions.MarginTop = 5;
            Gerador.PrintOptions.MarginBottom = 5;
            try
            {
                Gerador.RenderHtmlAsPdf(Html).SaveAs(Caminho);
                System.Diagnostics.Process.Start(Caminho);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

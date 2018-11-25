using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using IronPdf;

namespace GenericPdv
{
    public partial class RelatorioDeVendas : Form
    {
        DataSetGnPdvTableAdapters.FechamentoTableAdapter fechamento = new DataSetGnPdvTableAdapters.FechamentoTableAdapter();
        DataSetGnPdvTableAdapters.CaixaTableAdapter caixa = new DataSetGnPdvTableAdapters.CaixaTableAdapter();
        DataSetGnPdvTableAdapters.relatorioProdutosTableAdapter itensProdutos = new DataSetGnPdvTableAdapters.relatorioProdutosTableAdapter();
        DataSetGnPdvTableAdapters.ItensDaVendaTableAdapter itensVenda = new DataSetGnPdvTableAdapters.ItensDaVendaTableAdapter();
        DateTime dataIncio, dataFim;
        string Html;
        ListViewItem item = new ListViewItem();
        string[] itens = new string[6];
        string Vendedor;
        bool consultaComVendedor;
        double total;
        public RelatorioDeVendas(DateTime inicio, DateTime fim, string vendedor, bool tipo)
        {
            dataIncio = inicio;
            dataFim = fim;
            consultaComVendedor = tipo;
            Vendedor = vendedor;
            InitializeComponent();
        }

        private void RelatorioDeVendas_Load(object sender, EventArgs e)
        {
            lbPeriodo.Text = "Fechamento de " +
                DateTime.Parse(dataIncio.ToString()).ToString("dd/MM/yyyy ") +
                " até " + DateTime.Parse(dataFim.ToString()).ToString("dd/MM/yyyy ") + ".";
            

            if (consultaComVendedor)
            {
                dataGridView1.DataSource = fechamento.GetDataByFunc(dataIncio, dataFim, Vendedor);
            }
            else
            {
                dataGridView1.DataSource = fechamento.GetData(dataIncio, dataFim);
            }

            
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id;
                id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                dataGridView2.DataSource = itensProdutos.GetData(id);

            }
            catch (Exception ex)
            {
                Alerta alerta = new Alerta("Nenhuma linha selecionada.");
                alerta.ShowDialog();
            }
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            string Template = GetTemplate(@"C:\Users\Dokahviin\source\repos\GenericPdv\GenericPdv\Relatorio.html");
            CabecalhoFechamento();
            total = 0;
                //Cabeçario da tabela
                for (int i = 0; i < dataGridView1.Rows.Count; i++) {
                this.Html += "<table>";
                    this.Html += "<th class='AlinhaEsquerda'>" + 
                        DateTime.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()).ToString("dd/MM/yyyy ") + " | "+
                        dataGridView1.Rows[i].Cells[0].Value.ToString() + " | " +
                        dataGridView1.Rows[i].Cells[1].Value.ToString() +
                        "</th>";

                        //itens da tabela 
                        this.Html += 
                            " <tr>" +
                                "<th class='AlinhaEsquerda'> COD PROD</th>" +
                                "<th class='AlinhaEsquerda'> DESCRIÇÃO</th>" +
                                "<th class='AlinhaEsquerda'> QTD</th>" +
                                "<th class='AlinhaEsquerda'> VALOR UNI (R$)</th>" +
                                "<th class='AlinhaEsquerda'> SUB TOTAL (R$)</th>" +
                            "</tr>";
                this.Html += "<tr>";
                int k = 0;
                try
                {
                    
                    while (itensVenda.GetData(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value))[0]["idVenda"].ToString() == dataGridView1.Rows[i].Cells[0].Value.ToString()) {
                        string qqr = itensVenda.GetData(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value))[k]["idItens"].ToString();
                        k++;
                    }
                }
                catch (Exception ex)
                {
                    
                }
                //MessageBox.Show(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value.ToString()).ToString());
                //int aux = Convert.ToInt32(itensVenda.GetDataByQtdItens(177));

                for (int j = 0; j < k; j++)
                {
                    this.Html += "<tr>" +
                    "<td> " + itensProdutos.GetData(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value))[j]["idProduto"].ToString() + "</td>" +
                    "<td> " + itensProdutos.GetData(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value))[j]["prodNome"].ToString() + "</td>" +
                    "<td> " + itensProdutos.GetData(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value))[j]["itensQtd"].ToString() + "</td>" +
                    "<td> " + itensProdutos.GetData(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value))[j]["itensSubTotal"].ToString() + "</td>" +
                    "<td> " + itensProdutos.GetData(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value))[j]["itensValorUni"].ToString() + "</td>" +
                    "</tr>";
                }

                this.Html +=
                        "<tr>" +
                            "<th> TOTAL " + string.Format("{0,-10:C}", Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value)) +
                        "</tr>";
                this.Html += "</table>";
                this.Html += "<br>";
                total += Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
            }
            this.Html += "<h3> TOTAL " + string.Format("{0,-10:C}", total) + "</H3 >";

            var DocumentoFinal = Template.Replace("{CORPO}", Html);
            string repositorio = @"C:\Users\Dokahviin\source\repos\GenericPdv\GenericPdv\Relatorios\Relatorio_" + DateTime.Now.ToString("dd-MM-yyyy") + ".pdf";
            GeraPdf(DocumentoFinal, repositorio, 1);

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
                "Relatório de vendas de " + DateTime.Parse(dataIncio.ToString()).ToString("dd/MM/yyyy ") +
                " até " + DateTime.Parse(dataFim.ToString()).ToString("dd/MM/yyyy ") + "</div>";
        }

        private void Rodape(){

        }


        private void CriaLinha(string Campo, string Valor)
        {
            this.Html += "<tr><th class='AlinhaEsquerda'>" + Campo + "</th> <th class='AlinhaEsquerda'>" + string.Format("{0:C}", Valor) + " </th></tr>";
        }

        public static void GeraPdf(string Html, string Caminho, int Tipo)
        {
            var Gerador = new IronPdf.HtmlToPdf();

            if (Tipo == 1)
            {
                Gerador.PrintOptions.SetCustomPaperSizeinMilimeters(200, 200);
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

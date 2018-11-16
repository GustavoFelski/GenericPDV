using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using IronPdf;

namespace WindowsFormsApp1
{
    class Relatorio
    {
        private string Html;

        public double Dinheiro;
        public double Debito;
        public double Credito;
        public double Abertura;
        public double Sangria;

        public Relatorio(double RDinheiro, double RDebito, double RCredito, double RAbertura, double RSangria) {
            Dinheiro = RDinheiro;
            Debito = RDebito;
            Abertura = RAbertura;
            Sangria = RSangria;
        }
    
        //Le um arquivo Html e retorna seu conteudo
        private string GetTemplate(string Caminho)
        {
            return File.ReadAllText(Caminho);
        }

        //Cria uma linha do relatorio de fechamento de caixa
        private void CriaLinhaFechamento(string Campo, double Valor)
        {
            this.Html += "<tr><th class='AlinhaEsquerda'>" + Campo +"</th> <th class='AlinhaEsquerda'>"+ string.Format("{0:C}", Valor) + " </th></tr>";
        }

        //Gera o cabecalho do relatório de venda
        private void CabecalhoFechamento()
        {
            var Imagem       = File.ReadAllBytes("Logo.png");
            var ImagemBase64 = ("data:image/png;base64," + Convert.ToBase64String(Imagem)); 
            this.Html += "<div class='TextoCentralizado'> <img src='"+ImagemBase64+"'> <br> " +
                "Fechamento de Caixa - "+ DateTime.Now +" </div>";
        }


        //Gera o Relatório de fechamento de caixa
        public void GeraFechamentoCaixa(double Dinheiro, double Debito, double Credito, double Abertura, double Sangria)
        {
            string Template   = GetTemplate(@"C:\Users\Gabriel Alves\source\repos\WindowsFormsApp1\WindowsFormsApp1\FechamentoCaixa.html");
            double ValorCaixa = Dinheiro + Abertura - Sangria;
            CabecalhoFechamento();
            this.Html += "<table>";
            CriaLinhaFechamento("Dinheiro", Dinheiro);
            CriaLinhaFechamento("Debito", Debito);
            CriaLinhaFechamento("Credito", Credito);
            CriaLinhaFechamento("Valor de Abertura", Abertura);
            CriaLinhaFechamento("Total de Sangria", Sangria);
            CriaLinhaFechamento("Valor em Caixa", ValorCaixa);
            this.Html += "</table>";

            var DocumentoFinal = Template.Replace("{CORPO}", Html);

            GeraPdf(DocumentoFinal, "C:\\Relatorio.pdf", 1);
        }

        private void CabecalhoCupom(string Vendedor)
        {
            var Imagem = File.ReadAllBytes("Logo.png");
            var ImagemBase64 = ("data:image/png;base64," + Convert.ToBase64String(Imagem));
            this.Html += "<div class='TextoCentralizado'> <img src='" + ImagemBase64 + "'> <br> " +
                "EMPRESA LTDA <br>" +
                "Rua Fantasia, 207, Jardim Fantasia <br>" +
                "Nome da Cidade - SP <br>" +
                "CNPJ 74.946.184/0001 - 13 <br>" +
                "IE - 474.736.830.546";
            this.Html += "---------------------------------------------------------------------------------";
            this.Html += "Vendedor: " + Vendedor; this.Html += "<br> <br>";
            this.Html += "Data de Compra: " + DateTime.Now;
            this.Html += "<div class='Centralizado'>DOCUMENTO SEM VALOR FISCAL</div>";
            this.Html += "</div>";
        }
        
        public void GeraCupomVenda(Array ProdutosVendidos, string Vendedor)
        {
            string Template = GetTemplate(@"C:\Users\Gabriel Alves\source\repos\WindowsFormApp1\WindowformsApp1\FechamentoCaixa.html");
            CabecalhoCupom(Vendedor);
            foreach (Array Produto in ProdutosVendidos)
            {

            }
        }

        //Gera o Pdf. Parametro Tipo dita o tipo (0 - A4, 1 - Cupom)
        public static void GeraPdf(string Html, string Caminho, int Tipo)
        {
            var Gerador = new IronPdf.HtmlToPdf();

            if (Tipo == 1)
            {
                Gerador.PrintOptions.SetCustomPaperSizeinMilimeters(80, 200);
            }
            Gerador.PrintOptions.MarginLeft   = 5;
            Gerador.PrintOptions.MarginRight  = 5;
            Gerador.PrintOptions.MarginTop    = 5;
            Gerador.PrintOptions.MarginBottom = 5;

            Gerador.RenderHtmlAsPdf(Html).SaveAs(Caminho);
            System.Diagnostics.Process.Start(@"c:\relatorio.pdf");
            Environment.Exit(0);
        }

    }
}

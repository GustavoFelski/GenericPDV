using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;// A BIBLIOTECA DE ENTRADA E SAIDA DE ARQUIVOS
using iTextSharp;//E A BIBLIOTECA ITEXTSHARP E SUAS EXTENÇÕES
using iTextSharp.text;//ESTENSAO 1 (TEXT)
using iTextSharp.text.pdf;//ESTENSAO 2 (PDF)

namespace GenericPdv
{
    class Impressao
    {
        DataSetGnPdvTableAdapters.PagamentoTableAdapter pagamento = new DataSetGnPdvTableAdapters.PagamentoTableAdapter();
        DataSetGnPdvTableAdapters.VendaTableAdapter venda = new DataSetGnPdvTableAdapters.VendaTableAdapter();
        DataSetGnPdvTableAdapters.ItensDaVendaTableAdapter itensVenda = new DataSetGnPdvTableAdapters.ItensDaVendaTableAdapter();

        public void imprimir(string[,] itens, string cpf, double ValorTotal) {
            //CONFIGURA DA PAGINA
            

            Document doc = new Document(PageSize.A4);//criando e estipulando o tipo da folha usada
            doc.SetMargins(40, 40, 40, 80);//estibulando o espaçamento das margens que queremos
            doc.AddCreationDate();//adicionando as configuracoes

            //caminho onde sera criado o pdf + nome desejado
            //OBS: o nome sempre deve ser terminado com .pdf
            string caminho = @"C:\test.pdf";

            //criando o arquivo pdf embranco, passando como parametro a variavel                
            //doc criada acima e a variavel caminho 
            //tambem criada acima.
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));

            doc.Open();


            //criando uma string vazia
            string dados = "";

            //criando a variavel para paragrafo
            Paragraph paragrafo = new Paragraph(dados, new Font(Font.NORMAL, 9));

            //etipulando o alinhamneto
            paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
            //Alinhamento Justificado
            //adicioando texto
            // Adcionar dados da empresa (pesquisar em arquivo de configuração)
            // por enquanto so criar dados ficticios
            paragrafo.Add("EMPRESA LTDA\n");
            paragrafo.Add("Rua Fantasia,207, Jardim Fantasia\n");
            paragrafo.Add("Nome da Cidade - SP\n");
            paragrafo.Add("CNPJ 74.946.184/0001-13\n");
            paragrafo.Add("IE - 474.736.830.546\n");
            for(int i = 0; i<= 48; i++)
            {
                paragrafo.Add("-");
                if(i == 48) { paragrafo.Add("\n"); }
            }

            // dados do vendedor
            paragrafo.Add("Vendedor:"+AutenticacaoDeFuncionario.funcLogado+"\n");
            // dados do cliente
            paragrafo.Add(cpf+"\n");
            // data e hora da compra
            paragrafo.Add("Data de compra" + DateTime.Now+"\n");
            // não fiscal
            for (int i = 0; i <= 48; i++)
            {
                paragrafo.Add("-");
                if (i == 48) { paragrafo.Add("\n"); }
            }
            paragrafo.Add("--CUPOM NÃO FISCAL--\n");
            // cabeçario do comprovante 
            for (int i = 0; i <= 48; i++)
            {
                paragrafo.Add("-");
                if (i == 48) { paragrafo.Add("\n"); }
            }
            paragrafo.Add("ITEM | COD | DESC | QTD | VAL.UNI. | SUBTOTAL \n");
            // imprimir lista de produtos
            int linha = itens.Length / 6;

            for (int i = 0; i < linha; i++)
            {
                try
                {
                    paragrafo.Add(itens[i,0] + "|" + itens[i, 1] + "|" + itens[i, 2] + "|" + itens[i, 3] + "|" + itens[i, 4] + "|" + itens[i, 5] +"\n");    
                }
                catch (Exception ex)
                {
                     
                }
            }
            // imprimir total da venda
            paragrafo.Alignment = Element.ALIGN_LEFT;
            paragrafo.Add("Valor Total da Compra: "+ValorTotal.ToString()+"\n");

            //acidionado paragrafo ao documento
            doc.Add(paragrafo);
            //fechando documento para que seja salva as alteraçoes.
            doc.Close();
        }
    }
}

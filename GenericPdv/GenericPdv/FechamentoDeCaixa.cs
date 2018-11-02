using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPdv
{
    class FechamentoDeCaixa
    {
        // trazer relatorio de Vendas
        // Calculo de vendas por credito/ debito
        // update na tabela caixa
        DataSetGnPdvTableAdapters.VendaTableAdapter venda = new DataSetGnPdvTableAdapters.VendaTableAdapter();
        DataSetGnPdvTableAdapters.CaixaTableAdapter caixa = new DataSetGnPdvTableAdapters.CaixaTableAdapter();
        double valorCredito;
        double valorDebito;
        double valorDeCaixa;


        public void updateFechamento(double valorDeFundo)
        {

            // valorDecaixa - fundoDeCaixa(100 teste)
            valorDeCaixa -= valorDeFundo;
            // valor de fechamento
            // data de fechamento 

            caixa.UpdateQueryFechamento(valorCredito, DateTime.Now, valorDeCaixa, valorDeFundo, valorDebito, Convert.ToInt32(caixa.GetDataByLast()[0]["idVenda"]));
        }
        private double[] SomaValores()
        {
            double[] valores = new double[3];
            //pegar o ultimo inserti da data atual 
            var ultimaData = caixa.GetData();


            //pegar todas as vendas relacionadas a esta data 
            //Somar todos os valores de credioto, debito e dinheiro total
            // salvar os valores no vetor


            return valores;
        }  

    }
}

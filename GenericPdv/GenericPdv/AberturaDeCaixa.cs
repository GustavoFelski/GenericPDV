using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPdv
{
    public static class AberturaDeCaixa
    {

        private static DataSetGnPdvTableAdapters.CaixaTableAdapter caixa = new DataSetGnPdvTableAdapters.CaixaTableAdapter();
        public static DateTime abertura { get; set; }
        public static double valorDeCaixa { get; set; } // para valores de dinheiro 
        private static double valorCredito { get; set; } // não misturar os valores de cartão, apenas somalos 
        private static double valorDebito { get; set; }
        public static int idCaixa { get; set; }

        // posso usar esses metodos para sandria tbm apenas para o dinheiro
        public static void adcionarValor(double dinheiro /*double debito, double credito*/)
        {
            valorDeCaixa += dinheiro;
            //valorDebito += debito;
            //valorCredito += credito;
        }
        public static void removerValor(double valor)
        {
            valorDeCaixa -= valor;
        }
        // para o cartão apenas update no valor de cartão

        public static bool aberturaCaixa(double fundoDeCaixa)
        {
            //abre o caixa caso aja um valor de caixa
            
            var lastFundo = caixa.GetDataByLast();
            if (fundoDeCaixa >= 0.0)
            {
                valorCredito = 0.0;
                valorDebito = 0.0;
                valorDeCaixa = fundoDeCaixa;
                idCaixa = Convert.ToInt32(caixa.GetData()[0]["idCaixa"]);
                caixa.InsertQueryAbertura(DateTime.Now, fundoDeCaixa);
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}

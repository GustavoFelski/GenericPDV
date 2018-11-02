using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPdv
{
    static class AutenticacaoDeFuncionario
    {
        private static DataSetGnPdvTableAdapters.FuncionarioTableAdapter funcionario = new DataSetGnPdvTableAdapters.FuncionarioTableAdapter();

        public static string funcLogado { get; set; }
        public static DateTime Date { get; set; }
        public static int idFuncionario { get; set; }

    }
}

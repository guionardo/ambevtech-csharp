using Heranca.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Implementacoes
{
    internal class ProcessadorCsv : IProcessador
    {
        public string Processar(string input)
        {
            if (input.Contains(','))
            {
                return "CSV OK";
            }
            return "CSV INVÁLIDO";
        }
    }
}

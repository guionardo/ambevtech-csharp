using Heranca.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Implementacoes
{
    internal class ProcessadorJson : IProcessador
    {
        public string Processar(string input)
        {
            if (input.StartsWith("{") && input.EndsWith("}"))
            {
                return "JSON OK";
            }
            return "JSON INVÁLIDO";
        }
    }
}

using Heranca.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Implementacoes
{
    internal class RetornadorParaPasta : IRetornador
    {
        private string _pasta;

        public RetornadorParaPasta(string pasta)
        {
            _pasta = pasta;
        }
        public void Retornar(string conteudo)
        {
            var nomeArquivo = Path.Join(_pasta, "retorno.txt");
            File.WriteAllText(nomeArquivo, conteudo);
        }
    }
}

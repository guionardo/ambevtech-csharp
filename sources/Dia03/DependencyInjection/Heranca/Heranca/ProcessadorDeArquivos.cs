using Heranca.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class ProcessadorDeArquivos
    {
        private IProcessador _processador;
        private IRetornador _retornador;
        private string _conteudo;
        private string _resultado;

        public ProcessadorDeArquivos(IProcessador processador, IRetornador retornador)
        {
            _processador = processador;
            _retornador = retornador;

        }
        public void Receber(string arquivo)
        {
            _conteudo = File.ReadAllText(arquivo);
        }

        public void Processar()
        {
            _resultado = _processador.Processar(_conteudo);
        }

        public void Retornar()
        {
            _retornador.Retornar(_resultado);
        }
    }
}

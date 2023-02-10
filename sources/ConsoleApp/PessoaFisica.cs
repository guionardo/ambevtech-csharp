using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class PessoaFisica: Pessoa
    {
        public PessoaFisica(string nome) : base(nome) {
            _ativo = true;
        }
        
    }
}

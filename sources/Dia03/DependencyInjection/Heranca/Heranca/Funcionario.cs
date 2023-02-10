using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Funcionario:Pessoa
    {
        public string Matricula { get; set; }

        public override void Imprimir()
        {
            Console.WriteLine($"{Nome} {Codigo} {Matricula}");
        }
    }
}

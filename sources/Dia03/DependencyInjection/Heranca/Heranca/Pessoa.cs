using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public string Codigo { get; set; }

        public virtual void Imprimir()
        {
            Console.WriteLine($"{Nome} {Codigo}");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_02_ConfigClass.SCOPES
{
    public class ClassScopes
    {

        public ClassScopes(string nome)
        {
            Nome = nome;
        }
        public string Nome { get; private set; }

        public void Print()
        {
            Console.WriteLine($"Nome: {Nome} Status: {Status}");
        }

        private int Id { get; set; }

        protected bool Debug;

        static void Enviar()
        {
            Console.WriteLine($"Enviar mensagem: {Status}");
        }

        public static string Status = "";
    }

    public class SubClassScopes : ClassScopes
    {
        public SubClassScopes(string nome) : base(nome) { }

        public int Key { get; set; }
        public void Escrever()
        {
            Console.WriteLine($"Nome: {Nome} Key {Key}  Debug {Debug}");
        }
    }
}

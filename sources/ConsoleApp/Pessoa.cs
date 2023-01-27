using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Pessoa
    {
        string _nome;
        int _idade;
        protected bool _ativo;

        //DateTime DataNascimento()
        //{
        //    return DateTime.Now.Subtract(TimeSpan.FromDays(365 * idade));
        //}

        public DateTime DataNascimento
        {
            get => DateTime.Now.Subtract(TimeSpan.FromDays(365 * _idade));
            set
            {
                _idade = (int)(DateTime.Now - value).TotalDays / 365;
            }
        }

        public int Idade
        {
            get => _idade;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(_idade), "Idade deve ser positiva ou zero");
                _idade = value;
            }
        }
        
        /// <summary>
        /// Instanciar Pessoa
        /// </summary>
        /// <param name="nome">Nome da pessoa</param>
        /// <param name="idade">Idade da pessoa</param>
        public Pessoa(string nome, int idade)
        {
            _nome = nome;
            _idade = idade;
        }

        public Pessoa(string nome)
        {
            _nome = nome;
            _idade = 0;
        }

        public void Imprimir()
        {
            Console.WriteLine(_nome + " " + _idade);
        }

        public void AdicionarAnos(int anos)
        {
            _idade = _idade + anos;
        }

        public string NomeMaiusculo()
        {
            return _nome.ToUpper();
        }

        public void EmailSent(bool success)
        {
            Console.WriteLine("Email foi?", success);
        }

        public static Pessoa operator +(Pessoa p1, Pessoa p2) => new Pessoa(p1._nome + "_" + p2._nome);
    }
}

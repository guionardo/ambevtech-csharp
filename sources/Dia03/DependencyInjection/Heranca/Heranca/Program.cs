// See https://aka.ms/new-console-template for more information
using Heranca;
using Heranca.Implementacoes;
using Heranca.Interfaces;

internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");

        //var p = new Pessoa
        //{
        //    Nome = "Guionardo",
        //    Codigo = "1"
        //};

        //var f = new Funcionario
        //{
        //    Nome = "Zé",
        //    Codigo = "2",
        //    Matricula = "3"
        //};

        //p.Imprimir();
        //f.Imprimir();

        var jsonProc = new ProcessadorJson();
        var csvProc=new ProcessadorCsv();

        var pastaRet = new RetornadorParaPasta(".");

        var processador = new ProcessadorDeArquivos(csvProc, pastaRet);

        File.WriteAllText("origem.json", "{ }");
        processador.Receber("origem.json");
        processador.Processar();
        processador.Retornar();
    }
}
// See https://aka.ms/new-console-template for more information
using ConsoleApp;
using System.Security.Cryptography;

Console.WriteLine("Hello, World!");

var pessoa = new Pessoa("Guionardo", 45);
//var pessoa2 = new Pessoa("Zé");


Console.WriteLine(pessoa.Idade);
Console.WriteLine(pessoa.DataNascimento);

pessoa.Imprimir();

//pessoa.AdicionarAnos(10);

//pessoa.Imprimir();
//pessoa2.Imprimir();

var sender = new EmailSender(pessoa.EmailSent);
sender.Send("CURSO DE CSHARP");

var p1 = new Pessoa("Gui");
var p2 = new Pessoa("João");
var p3 = p1 + p2;

p3.Imprimir();

var pf = new PessoaFisica("Guionardo");
pf.Imprimir();

object o = pf;


// See https://aka.ms/new-console-template for more information
Console.WriteLine("Escopo");

var soma = true;

int Soma(byte numeros)
{
    var soma = 0;
    for(var n = 1; n <= numeros; n++)
    {
        soma += n;
    }
    return soma;
}

Console.WriteLine("Soma(40)=" + Soma(40));
Console.WriteLine(soma);

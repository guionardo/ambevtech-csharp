// See https://aka.ms/new-console-template for more information
Console.WriteLine("Closure!");

Func<int, int> CriarMultiplicador(int multiplicador)
{
    int funcMultiplicador(int valor)
    {
        return valor * multiplicador;
    }
    return funcMultiplicador;
}

var dobro = CriarMultiplicador(2);
var triplo = CriarMultiplicador(3);

Console.WriteLine("Dobro de 2 = " + dobro(2));
Console.WriteLine("Triplo de 2 = " + triplo(2));


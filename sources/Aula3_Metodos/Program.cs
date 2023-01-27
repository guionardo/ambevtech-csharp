// See https://aka.ms/new-console-template for more information
using System.Runtime.Intrinsics;

Console.WriteLine("Calculadora!");


///
/// Função simples com retorno
/// 
float Soma(float valor1, float valor2)
{
    return valor1 + valor2;
}

///
/// Função com declaração de corpo reduzido
/// 
float Subtracao(float valor1, float valor2) => valor1 - valor2;

float Multiplicacao(float valor1, float valor2) => valor1 * valor2;

float Divisao(float valor1, float valor2) => valor1 / valor2;

var opcoes = new Dictionary<string, Func<float, float, float>>
{
    {"+",Soma },
    {"-",Subtracao },
    {"*",Multiplicacao },
    {"/",Divisao }
};

string? InputText(string label)
{
    Console.Write(label);
    return Console.ReadLine();
}
float InputFloat(string label)
{
    while (true)
    {
        var text = InputText(label);
        if (!string.IsNullOrWhiteSpace(text))
        {
            if (float.TryParse(text, out var f))
            {
                return f;
            }
        }
    }
}
while (true)
{
    var operacao = InputText("Informe a operação [+, -, *, /] ou deixe vazio para sair");
    if (string.IsNullOrWhiteSpace(operacao))
    {
        Console.WriteLine("Saindo!");
        break;
    }
    if (opcoes.TryGetValue(operacao.ToString(), out var funcao))
    {
        var v1 = InputFloat("Valor 1 ");
        var v2 = InputFloat("Valor 2 ");
        var resultado = funcao(v1, v2);
        if (Double.IsInfinity(resultado))
        {
            Console.WriteLine("OPERAÇÃO TENDE AO INFINITO");
        }
        else
        {
            Console.WriteLine($"{v1} {operacao} {v2} = {resultado}");
        }
    }
    else
    {
        Console.WriteLine("Operação inválida");
    }
}
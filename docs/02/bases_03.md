# Bases da linguagem

## Métodos

De forma geral, métodos são ações, sequências de comandos para o processamento de informações.
Os métodos podem receber argumentos na forma de variáveis, e retornar ou não informação.

No contexto deste treinamento, vamos classificar os métodos em dois tipos:

Actions
: Método que não retorna valor
  <pre>
  <code>
  void ActionQueNaoRetornaValor(string nomeDaPessoa) {
    Console.WriteLine(nomeDaPessoa, " passou por aqui");
  }
  </code>
  </pre>

*void* é uma palavra reservada que significa vazio, e nesse contexto indica que o método não tem nenhum retorno.

!!! warning "Atenção"
    Não confundir *void* com *null*, que representa um valor nulo, um ponteiro que não aponta para nenhuma região de memória.

Entre os parênteses, indicamos os argumentos que o método receberá. No exemplo, primeiro indicamos o tipo (string) e em seguida, o nome do argumento (nomeDaPessoa).

Functions
: Método que retorna valor
  <pre>
  <code>
  int FunctionQueRetornaValor(int n1, int n2) {
    return n1 + n2;
  }
  </code>
  </pre>
  
## Delegates

O conceito de delegates vem da ideia de usar métodos com a mesma assinatura. Para definir a assinatura de um delegate, usamos [Action](https://learn.microsoft.com/pt-br/dotnet/api/system.action-1?view=net-7.0) e [Func](https://learn.microsoft.com/pt-br/dotnet/api/system.func-1?view=net-7.0).

As actions, que são métodos sem retornos podem ser assinadas como demonstrado no exemplo abaixo:

```csharp
// Definimos a variável actionString, que pode receber um método 
Action<string> actionString;
// Atribuimos nossa action à variável
actionString = ActionQueNaoRetornaValor; 

actionString("Guionardo")

// Definimos nova action
void SegundaActionSemRetorno(string saudacao) {
    Console.WriteLine("Dito: ", saudacao);
}
// Atribuimos nossa nova action à mesma variável
actionString = SegundaActionSemRetorno;

actionString("BOM DIA")
```

```bash
Guionardo passou por aqui
Dito: BOM DIA
```

Quando precisamos definir assinaturas de functions, usamos o seguinte:

```csharp

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

// Definimos uma variável que pode receber uma função com dois argumentos float e um retorno float. 
Func<float,float,float> CalculateFunction;

CalculateFuncion = Soma;

var resultado = CalculateFunction(4.3, 3.2);  // resultado = 7.5




```

## Escopo

No C#, o escopo de execução estão delimitados pelos blocos de comandos ```{ }```.

Então, variáveis que são criadas dentro de um escopo são destruídas após o fechamento deste.

Atenção para variáveis que criam instâncias de objetos e são retornadas para uso em outros escopos. Nesse caso, entra em ação a contagem de referência desses dados em memória e o *garbage collector* faz a limpeza periodicamente dos objetos criados e sem referência em seções de código ativo.

## Closures

Closures são funções que retornam outras funções, com comportamento modificado.

Na criação das funções, podem ser injetadas variáveis com valores específicos que serão utilizados durante a execução.

```csharp
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
```

```bash
Dobro de 2 = 4
Triplo de 2 = 6
```

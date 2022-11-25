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
    Console.WriteLine(nome, " passou por aqui");
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
// Definimos funcTesteString que pode receber uma function com dois parâmetros (string e int) e um retorno bool. 
Func<string,int,bool> funcTesteString;



```


## Escopo

## Herança

## Namespaces

## Generics

## Interfaces

## Records
# Bases da linguagem

## Tipos de Referência ([Reference Types](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/reference-types))

Os tipos de referência são _ponteiros_ para os dados, e ao contrário dos _value types_, durante a atribuição, passagem por parâmetro ou retorno de função, somente o endereço do dado é transmitido.

### [Strings](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/reference-types#the-string-type)

Tipo que representa uma sequência de zero ou mais caracteres Unicode.

!!! warning "Atenção"
Strings são imutáveis. Após a criação de um string, seu conteúdo não pode ser alterado.
Isso significa que a concatenação de strings a uma mesma variável pode ser bastante custosa em termos de consumo de memória e deve ser levada em consideração durante a construção dos programas.

## [Encapsulamento](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/object-oriented/#encapsulation)

Este é o primeiro pilar ou princípio da Programação Orientada a Objeto. Agregamos informações dentro de um contexto que façam sentido no seu conjunto. Neste contexto, a agregação une valores e comportamentos, e para isso precisamos definir os membros de um tipo que está sendo definido:

Fields
: Variáveis declaradas no escopo do objeto.

Constants
: Informações imutáveis, definidas em tempo de compilação.

Properties
: Métodos de leitura (_get_) e escrita (_set_) dos valores do tipo, propiciando um tratamento e validação das informações dos _fields_, além de promover proteção aos valores armazenados.

Methods
: Ações/funções sobre os valores do tipo.

Constructors
: Métodos especiais, utilizados para criar a instância do tipo e inicializar seus valores.

Events
: Métodos especiais, referências para métodos de outras classes, utilizados para notificação de ocorrências.

Finalizers
: Métodos especiais, que são chamados quando o objeto está sendo destruído e é necessária alguma liberação de recursos de forma manual. Raramente utilizados.

Operators
: Métodos para sobrecarregar operadores ([_operator overloading_](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/operator-overloading)), modificando operações aritméticas, lógicas e comparativas.

Tipos Aninhados
: Tipos que são utilizados apenas dentro do contexto do objeto.

## Acessibiidade

Os membros dos objetos precisam de uma definição de acesso, para que se garanta a integridade dos valores. Dessa maneira, temos os seguintes modificadores:

public
: Acessível por qualquer código que consuma o objeto

protected
: Acessível apenas pelos objetos cujos tipos herdem do tipo atual

internal
: Acessível apenas pelos códigos que pertençam ao mesmo _namespace_ do tipo.

private
: Acessível apenas por código do próprio tipo.

## Classes

## [Escolhendo entre _class_ e _struct_](https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/choosing-between-class-and-struct)

!!! info "Quando usar structs?"
Considere usar uma struct ao invés de uma classe se as instâncias do tipo forem pequenas e de vida curta, ou forem comumente embutidas em outros objetos

!!! warning "Quando não usar structs?"
Evite definir uma struct caso o tipo não tenha todas essas características:

    * Representa logicamente um valor simples, similar aos tipos primitivos.
    * Tem um tamanho de instância de até 16 bytes.
    * É imutável.
    * Não precisa ser [_unboxed_](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/boxing-and-unboxing) frequentemente.


## Métodos

## Escopo

## Herança

## Namespaces

## Generics

## Interfaces

## Records

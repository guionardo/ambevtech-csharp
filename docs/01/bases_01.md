# Bases da linguagem

## Tipos de dados

!!! note "Atenção"
    Em C#, tudo é objeto, mesmo um byte.

## Tipos primitivos [value types](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-types)

Variáveis de tipo de valor (*value type*) contém a instância do tipo. Por padrão, ao ser atribuído, passado como argumento para um método, ou retornando como resultado de um método, os valores são copiados.

### [Números inteiros](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types)

| Tipo   | Range                                                  | Tamanho (bits) | .Net type      |
|--------|--------------------------------------------------------|----------------|----------------|
| sbyte  | -128 a 127                                             | 8              | System.SByte   |
| byte   | 0 a 255                                                | 8              | System.Byte    |
| short  | -32768 a 32767                                         | 16             | System.Int16   |
| ushort | 0 a 65535                                              | 16             | System.UInt16  |
| int    | -2,147,483,648 a 2,147,483,647                         | 32             | System.Int32   |
| uint   | 0 a 4,294,967,295                                      | 32             | System.UInt32  |
| long   | -9,223,372,036,854,775,808 a 9,223,372,036,854,775,807 | 64             | System.Int64   |
| ulong  | 0 a 18,446,744,073,709,551,615                         | 64             | System.UInt64  |
| nint   | Depende da plataforma (computado em runtime)           | 32/64          | System.IntPtr  |
| nuint  | Depende da plataforma (computado em runtime)           | 32/64          | System.UIntPtr |

### [Números de ponto flutuante](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types)

| Tipo    | Range aproximado       | Precisão (dígitos) | Tamanho (bytes) | .Net type      |
|---------|------------------------|--------------------|-----------------|----------------|
| float   | ±1.5E−45 a ±3.4E38    | ~6-9               | 4               | System.Single  |
| double  | ±5.0E−324 a ±1.7E308  | ~15-17             | 8               | System.Double  |
| decimal | ±1.0E-28 a ±7.9228E28 | 28-29              | 16              | System.Decimal |

### [Boolean](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool)

| Tipo  | Valores           |
|-------|-------------------|
| bool  | true, false       |
| bool? | true, false, null |

### [Char](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/char)

| Tipo | Range            | Tamanho (bits) | .Net type   |
|------|------------------|----------------|-------------|
| char | U+0000 a U+FFFF | 16             | System.Char |

### [Enum](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/enum)

Enumeração, ou uma forma de criar um tipo com constantes definidas, associadas a um tipo inteiro.

```csharp
enum Estacoes
{
    Primavera,
    Verao,
    Outono,
    Inverno
}
```

```csharp
enum HTTPStatus: ushort
{
    OK = 200,
    Created = 201,
    Accepted = 202,
    BadRequest = 400,
    NotFound = 404
}
```


### [Struct](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/struct)

Struct (de structure) é um tipo de valor que encapsula dados de tipos variados e funcionalidade relacionada. Há uma aparente semelhança com as classes que serão vistas adiante.

```csharp
public struct Coords
{
    public Coords(double x, double y)
    {
        X = x;
        Y = y;
    }

    public double X { get; }
    public double Y { get; }

    public override string ToString() => $"({X}, {Y})";
}
```








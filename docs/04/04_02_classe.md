# Classe de configuração

Para manter as variáveis de configuração organizadas, podemos agrupá-las em uma classe especializada em ler e validar os dados que precisamos.

Inicialmente, vamos desenvolver usando código nativo, explícito para a função que desejamos. Mais tarde, vamos abordar as opções que o aspnet oferece.

## Contexto

Consideremos que nossa aplicação tem algumas configurações específicas:

| Variável | Descrição | Tipo | Validação |
|----------|-----------|-------|-----|
| DB_CONNECTION_STRING| String de Conexão ao banco de dados |string|Deve iniciar com "mongodb://"|
| MAX_CONNECTED_USERS | Número máximo de usuários | int |Deve ser um inteiro entre 10 e 1000 |
| DEBUG | Flag para geração de informações de debug | bool | True deve ser representado por "1"|

Para tanto, criaremos uma classe que receberá estes dados:

```csharp
    public record ConfigClass
    {
        public string DbConnectionString { get; }
        public int MaxConnectedUsers { get; }
        public bool Debug { get; }

        public ConfigClass()
        {
            DbConnectionString = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING");
            MaxConnectedUsers = int.Parse(Environment.GetEnvironmentVariable("MAX_CONNECTED_USERS"));
            Debug = Environment.GetEnvironmentVariable("DEBUG") == "1";
        }

    }
```

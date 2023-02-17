# Configurações

Nossos sistemas devem ser flexíveis para se adequar aos diversos ambientes onde eles serão utilizados.

*[TTFA]:The Twelve-Factor App

Dessa forma, segundo as boas práticas do [The Twelve-Factor App](https://12factor.net/config), as configurações são tudo que varia entre os *deploys*, incluindo:

* Recursos para bases de dados, serviços de cache, filas, etc.
* Credenciais para serviços externos (APIs, WebServices, etc)
* Valores de uso no deploy (informações como nome do ambiente, flags para modificação de comportamento, etc)

Uma violação dessa regra do TTFA é o uso de constantes no código para armazenar estas configurações. Ela exige que haja uma estrita separação entre configuração e código.

O TTFA recomenda que sejam utilizadas **variáveis de ambiente** do sistema operacional para que as configurações sejam informadas à nossa aplicação.

O uso de arquivos de configuração também pode ser utilizado, desde que seu conteúdo não sofra mudança entre *deploys*, como por exemplo uma configuração de endpoints.

As aplicações DotNet tem por padrão usar arquivos appsettings.json, como no exemplo abaixo:

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  }
}
```

## Variáveis de ambiente

*[env]:Environment Variable
*[envs]:Environment Variables

No nosso contexto, vamos nos ater ao uso de variáveis de ambiente e classes de configuração personalizadas para a nossa aplicação. Do inglês *environment variable*, costumamos chamar essas variáveis de *env* pra facilitar.

Um tipo especial de env é a que contém dados sensíveis, como *string* de conexão com um banco de dados ou *broker* de mensageria, ou uma credencial de acesso a um serviço externo. Essas envs, chamamos de *secrets*.

## Envs em ambiente de desenvolvimento

As IDE´s de desenvolvimento, como o Visual Studio, Rider, e até editores mais simples possibilitam que sejam disponibilizadas as envs durante a execução e debug da nossa aplicação. Para isso podemos armazenar essas informações em arquivos específicos.

O aspnet propõe como arquivo default o *launchSettings.json* que fica na pasta *Properties* do projeto em execução.

Um exemplo desse arquivo:

```json
{
  "profiles": {
    "EnvironmentSampleProject": {
      "commandName": "Project",
      "dotnetRunMessages": true,
      "environmentVariables": {
        "DOTNET_ENVIRONMENT": "Development",
        "AMBIENTE": "desenvolvimento"
      }
    }
  }
}
```

No que nos interessa, é o objeto *environmentVariables* que contém um dicionário de nomes de variáveis e seus conteúdos que serão utilizados na aplicação. Neste exemplo, durante a execução, a variável de ambiente *DOTNET_ENVIRONMENT* terá o valor *Development*.

Outra forma, não tão comum no ambiente dotnet, é o uso de arquivos *.env* na raiz do projeto com as variáveis no formato simples CHAVE=VALOR.

``` ini
DOTNET_ENVIRONMENT=Development
AMBIENTE=desenvolvimento
```

Estes arquivos .env não são lidos automaticamente pelas IDE´s, mas através de plugins podemos conseguir o mesmo efeito.

Tanto o arquivo launchSettings.json quanto o .env nunca devem ser incluídos nos commits para evitar que secrets sejam vazadas.

## Acessando uma *env* em C\#

O namespace Environment nos disponibiliza o método GetEnvironmentVariable, que utilizaremos para acessar a informação.

```csharp
var ambiente = Environment.GetEnvironmentVariable("AMBIENTE");
Console.Writeline(ambiente);

// desenvolvimento
```

!!! warning "Atenção"
    O retorno da função GetEnvironmentVariable é uma *string nulável*, que significa que caso a variável de ambiente não esteja definida, o retorno será *null*. Validação é importante!

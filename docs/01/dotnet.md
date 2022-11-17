---
title: My Document
summary: A brief description of my document.
authors:
    - Waylan Limberg
    - Tom Christie
date: 2018-07-10
some_url: https://example.com
---
# DotNet e C-Sharp

## SDK e Runtime

*[SDK]: Software Development Kit
*[Runtime]: .NET runtime, plataforma de execução das aplicações dotnet.

O *SDK* disponibiliza os recursos necessários ao desenvolvimento: compilação, testes e outras funções.

Já os *runtimes* são bibliotecas de execução das aplicações.

Via de regra, SDK são utilizados no desenvolvimento, e runtimes são utilizados no *deploy*.

Podemos verificar o tamanho das imagens docker de SDK´s e runtimes com o comando abaixo: 

```bash
❯ docker images
REPOSITORY                        TAG       IMAGE ID       CREATED      SIZE
mcr.microsoft.com/dotnet/sdk      7.0       3088c542a3e1   2 days ago   761MB
mcr.microsoft.com/dotnet/sdk      6.0       28bed156717a   2 days ago   737MB
mcr.microsoft.com/dotnet/aspnet   7.0       637559a1ee8b   2 days ago   212MB
mcr.microsoft.com/dotnet/aspnet   6.0       ab511e11221a   2 days ago   208MB
```

??? "Como obter as imagens docker"
    docker pull mcr.microsoft.com/dotnet/aspnet:7.0

    docker pull mcr.microsoft.com/dotnet/sdk:7.0

    docker pull mcr.microsoft.com/dotnet/aspnet:6.0
    
    docker pull mcr.microsoft.com/dotnet/sdk:6.0


A partir da linha de comando, podemos verificar o que foi instalado no passo de setup, para podermos começar a desenvolver nossos projetos em C#.

```bash
❯ dotnet --info
.NET SDK (reflecting any global.json):
 Version:   6.0.403
 Commit:    2bc18bf292

Runtime Environment:
 OS Name:     ubuntu
 OS Version:  20.04
 OS Platform: Linux
 RID:         ubuntu.20.04-x64
 Base Path:   /usr/share/dotnet/sdk/6.0.403/

global.json file:
  Not found

Host:
  Version:      6.0.11
  Architecture: x64
  Commit:       943474ca16

.NET SDKs installed:
  6.0.403 [/usr/share/dotnet/sdk]

.NET runtimes installed:
  Microsoft.AspNetCore.App 6.0.11 [/usr/share/dotnet/shared/Microsoft.AspNetCore.App]
  Microsoft.NETCore.App 6.0.11 [/usr/share/dotnet/shared/Microsoft.NETCore.App]

Download .NET:
  https://aka.ms/dotnet-download

Learn about .NET Runtimes and SDKs:
  https://aka.ms/dotnet/runtimes-sdk-info
```

No ambiente do exemplo, temos o **SDK 6.0.403** e os runtime **AspNetCore e NetCore 6.0.11**.
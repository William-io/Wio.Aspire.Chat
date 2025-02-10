# Wio.Aspire.Chat

## Descrição
`Wio.Aspire.Chat` é um projeto de chat que utiliza inteligência artificial para gerar respostas automáticas. Ele integra um modelo de machine learning Hugging Face e fornece uma interface de chat interativa.

## Pré-requisitos
- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
## Configuração do Ambiente

1. **Clone o repositório**:
    ```bash
    git clone https://github.com/seu-usuario/Wio.Aspire.Chat.git
    cd Wio.Aspire.Chat
    ```

2. **Restaure os pacotes NuGet**:
    ```bash
    dotnet restore
    ```

## Execução do Projeto

1. **Compile o projeto**:
    ```bash
    dotnet build
    ```

2. **Execute a aplicação**:
    ```bash
    dotnet run no visual studio: Start Debugg
    ```

## Estrutura do Projeto

- `Wio.Aspire.Chat.AppHost`: Contém o ponto de entrada da aplicação.
- `Wio.Aspire.Chat.Web`: Contém os componentes front-end e a interface de chat.
- `Wio.Aspire.Chat.ApiService`: Contém a lógica de API e serviços backend.

## Funcionalidades

- **Chat Interativo**: Interface de chat que permite enviar e receber mensagens.
- **Integração com AI**: Utiliza um modelo Hugging Face para gerar respostas automáticas.

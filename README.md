# Gerenciamento de Pessoas

## Descrição
Este projeto é uma aplicação Windows Forms desenvolvida em C# que se conecta a um banco de dados MySQL para gerenciar dados de pessoas. O projeto utiliza listas flexíveis para armazenar e manipular objetos de uma classe `People` e realiza operações de CRUD (Create, Read, Update, Delete) no banco de dados.

## Funcionalidades
- Conexão com o banco de dados MySQL.
- Uso de listas flexíveis para manipulação de dados.
- Interface gráfica desenvolvida com Windows Forms.
- CRUD de dados de pessoas.
- Exibição e edição de dados através da interface gráfica.

## Requisitos
- .NET Framework 4.7.2 ou superior.
- MySQL Server.
- MySQL Connector/NET (disponível via NuGet).

## Estrutura do Projeto
- `PessoaForm.cs`: Classe que representa uma pessoa com os atributos `Index`, `UserId`, `FirstName`, `LastName`, `Sex`, `Email`, `Phone`, `DateOfBirth`, `JobTitle`.
- `SearchForm.cs`: Formulário para pesquisa.
- `Program.cs`: Ponto de entrada da aplicação.


## Instalação
1. Clone o repositório:
    ```sh
    git clone https://github.com/seu-usuario/gerenciamento-de-pessoas.git
    cd gerenciamento-de-pessoas
    ```

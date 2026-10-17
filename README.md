# LH-Pets

Web API desenvolvida em **ASP.NET Core com C#** para a empresa fictícia LH-Pets, que cadastra clientes e seus animais de estimação.

Nesta etapa, os dados ficam armazenados **apenas em memória** (`List<T>`). Por isso, **todos os dados são perdidos quando a aplicação é reiniciada**.

## Tecnologias utilizadas

- C#
- .NET 10 / ASP.NET Core Web API (Controllers)
- Swagger (Swashbuckle.AspNetCore) para testes interativos
- Visual Studio Code
- Git e GitHub

## Estrutura do projeto

```
LH-Pets/
├── Controllers/
│   ├── ClientesController.cs   # endpoints de clientes
│   └── PetsController.cs       # endpoints de pets
├── Data/
│   └── DadosEmMemoria.cs       # listas compartilhadas de clientes e pets
├── Models/
│   ├── Cliente.cs
│   └── Pet.cs
├── Properties/
│   └── launchSettings.json
├── appsettings.json
├── appsettings.Development.json
├── LH-Pets.csproj
├── Program.cs
├── README.md
└── .gitignore
```

## Como executar

Pré-requisito: [.NET SDK 10](https://dotnet.microsoft.com/download) instalado.

```bash
git clone https://github.com/dns-1337/LH-Pets-API.git
cd LH-Pets-API
dotnet run
```

Depois, acesse o Swagger no navegador:

```
http://localhost:5038/swagger
```

## Endpoints

| Método | Rota | Descrição | Respostas |
|---|---|---|---|
| GET | `/api/clientes` | Lista todos os clientes | 200 |
| POST | `/api/clientes` | Cadastra um cliente | 201 |
| GET | `/api/pets` | Lista todos os pets | 200 |
| POST | `/api/pets` | Cadastra um pet vinculado a um cliente | 201, ou 404 se o cliente não existir |
| GET | `/api/pets/cliente/{clienteId}` | Lista os pets de um cliente | 200 (lista vazia se não houver pets) |

### Exemplo: cadastrar cliente

```json
{
  "nome": "Maria Silva",
  "cpf": "123.456.789-00",
  "email": "maria@email.com"
}
```

### Exemplo: cadastrar pet

```json
{
  "nome": "Rex",
  "especie": "Cachorro",
  "raca": "Labrador",
  "clienteId": 1
}
```

O `Id` de clientes e pets é gerado automaticamente pela API.

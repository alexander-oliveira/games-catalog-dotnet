# Games Catalog API v1

Este projeto tem como objetivo a manipulação de dados referentes a títulos de jogos eletrônicos.

## Utilização

```bash
cd GamesCatalogAPI
dotnet run
```

## Tecnologias

- .NET 5 SDK
- SQL Server Express

## Requisições

- GET /api/v1/games
- GET /api/v1/games/{id}
- PUT /api/v1/games/{id}
- PATCH /api/v1/games/{id}/price/{price}
- DELETE /api/v1/games/{id}
- POST /api/v1/games

## Entidade

```json
{
    "id" : "Guid",
    "name" : "string",
    "producer" : "string",
    "price" : "double"
}
```
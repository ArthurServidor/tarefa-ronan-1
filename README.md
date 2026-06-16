# API de Produtos

API REST desenvolvida em ASP.NET Core 8 para gerenciamento de produtos armazenados em um banco de dados MySQL hospedado no Google Cloud.

## Tecnologias Utilizadas

- ASP.NET Core 8
- Entity Framework Core
- MySQL
- Pomelo.EntityFrameworkCore.MySql
- Swagger/OpenAPI
- DotNetEnv

---

## Estrutura do Projeto

```text
Controllers/
├── ProdutoController.cs

Infrastructure/
├── AppDbContext.cs

Produto/
├── Produto.cs

Services/
├── ProdutoServices.cs

Program.cs
```

---

## Banco de Dados

A aplicação utiliza a seguinte tabela:

```sql
CREATE TABLE IF NOT EXISTS produtos (
    id          INT AUTO_INCREMENT PRIMARY KEY,
    nome        VARCHAR(100) NOT NULL,
    descricao   TEXT,
    preco       DECIMAL(10,2) NOT NULL,
    categoria   VARCHAR(50),
    criado_em   DATETIME DEFAULT CURRENT_TIMESTAMP
);
```

---

## Configuração

Criar um arquivo `.env` na raiz do projeto:

```env
CONNECTION_STRING=Server=IP_DO_BANCO;Port=3306;Database=nome_banco;Uid=USUARIO;Pwd=SENHA;
```

Exemplo:

```env
CONNECTION_STRING=Server=99.99.99.999;Port=3306;Database=app_projeto;Uid=root;Pwd=123456;
```

---

## Instalação

Restaurar os pacotes:

```bash
dotnet restore
```

Executar a aplicação:

```bash
dotnet run
```

---

## Swagger

Após iniciar a aplicação, acessar:

```text
http://localhost:5000
```

ou

```text
https://localhost:5001
```

A interface Swagger será carregada automaticamente.

---

## Endpoints

### Listar Produtos

```http
GET /api/produtos
```

Retorna todos os produtos cadastrados.

---

### Criar Produto

```http
POST /api/produtos
```

Body:

```json
{
  "nome": "Notebook",
  "descricao": "Notebook Gamer",
  "preco": 4500.0,
  "categoria": "Eletrônicos"
}
```

---

### Excluir Produto

```http
DELETE /api/produtos/{id}
```

Exemplo:

```http
DELETE /api/produtos/1
```

---

## Objetivo

Este projeto foi desenvolvido com fins acadêmicos para demonstrar a integração entre uma API ASP.NET Core e um banco de dados MySQL hospedado em nuvem, utilizando Entity Framework Core para persistência dos dados e Swagger para documentação da API.

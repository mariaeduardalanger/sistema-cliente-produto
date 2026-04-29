
# SistemaEstagio 🚀

Sistema web para gestão simplificada de clientes e produtos, desenvolvido com **ASP.NET Core MVC + Entity Framework Core + SQLite**.

## 📌 Sobre o Projeto
O **SistemaEstagio** é uma aplicação CRUD para cadastro e gerenciamento de clientes e produtos, com relacionamento entre eles e persistência em banco de dados.

## ✨ Funcionalidades
- Cadastro de clientes
- Edição e exclusão de clientes
- Cadastro de produtos
- Controle e gerenciamento de produtos
- Relacionamento entre clientes e produtos
- Interface web com ASP.NET MVC
- Banco de dados SQLite integrado

## 🛠 Tecnologias Utilizadas
- C#
- ASP.NET Core MVC (.NET 8)
- Entity Framework Core
- SQLite
- Razor Pages / Bootstrap

## 📂 Estrutura do Projeto
```bash
SistemaEstagio/
├── Controllers/
├── Models/
├── Views/
├── Data/
├── Migrations/
└── Program.cs
````

## ▶️ Como Executar o Projeto

### 1. Clone o repositório

```bash
git clone https://github.com/seuusuario/SistemaEstagio.git
```

### 2. Entre na pasta do projeto

```bash
cd SistemaEstagio
```

### 3. Restaure os pacotes

```bash
dotnet restore
```

### 4. Rode as migrations (se necessário)

```bash
dotnet ef database update
```

### 5. Execute o projeto

```bash
dotnet run
```

Acesse:

```bash
https://localhost:5001
```

## 🗄 Banco de Dados

O projeto utiliza SQLite:

```bash
Data/app.db
```

Connection String:

```csharp
Data Source=Data/app.db
```

## 📸 Funcionalidades do Sistema

* Página inicial com painel de navegação
* Gestão de Clientes
* Controle de Produtos
* Operações CRUD completas

## 🔮 Melhorias Futuras

* Sistema de autenticação
* Dashboard com métricas
* Controle de estoque avançado
* Deploy em nuvem
* API para integração externa

## 👨‍💻 Autor

Desenvolvido por Maria Eduarda.


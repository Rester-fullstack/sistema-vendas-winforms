# 🛒 Sistema de Vendas

Aplicação desktop desenvolvida em **C#** com **Windows Forms** para gerenciamento de clientes, produtos e vendas, utilizando **SQL Server** como banco de dados.

O sistema permite cadastrar clientes e produtos, registrar vendas e visualizar os dados por meio de uma interface gráfica simples e organizada.

---

## 🚀 Funcionalidades

### 👥 Clientes

- Cadastro de clientes
- Edição de clientes
- Exclusão de clientes
- Consulta de clientes

### 📦 Produtos

- Cadastro de produtos
- Atualização de produtos
- Exclusão de produtos
- Controle de estoque

### 💰 Vendas

- Registro de vendas
- Associação entre cliente e produto
- Controle da quantidade vendida
- Registro da data da venda

### 📊 Interface

- DataGridView para listagem
- Navegação entre telas
- Interface desktop intuitiva

---

# 🛠️ Tecnologias Utilizadas

- C#
- .NET Framework
- Windows Forms (WinForms)
- SQL Server / LocalDB
- ADO.NET
- Visual Studio

---

# 🏗️ Arquitetura

```text
Windows Forms
      │
      ▼
ADO.NET
      │
      ▼
SQL Server
```

---

# 📂 Estrutura do Projeto

```text
sistema-vendas-winforms
│
├── Properties
│
├── FormCliente.cs
├── FormProduto.cs
├── FormVenda.cs
├── FormMenu.cs
│
├── SqlConnectionFactory.cs
├── Program.cs
├── App.config
│
├── SistemaVendasWinForms.csproj
└── README.md
```

---

# ▶️ Como executar

Clone o repositório

```bash
git clone https://github.com/Rester-fullstack/sistema-vendas-winforms.git
```

Entre na pasta

```bash
cd sistema-vendas-winforms
```

Abra o projeto no Visual Studio.

Configure a string de conexão no arquivo:

```
App.config
```

Execute a aplicação pressionando **F5**.

---

# 🗄️ Banco de Dados

O sistema utiliza SQL Server.

Principais tabelas:

- Clientes
- Produtos
- Vendas

---

# 📸 Screenshots

Adicione imagens como:

- Menu principal
- Cadastro de clientes
- Cadastro de produtos
- Registro de vendas

---

# 📚 Objetivos do Projeto

Este projeto foi desenvolvido para praticar:

- Desenvolvimento Desktop
- Windows Forms
- Programação em C#
- SQL Server
- ADO.NET
- CRUD completo
- Manipulação de banco de dados

---

# 🔮 Melhorias Futuras

- Controle de usuários
- Relatórios em PDF
- Dashboard de vendas
- Exportação para Excel
- Gráficos
- Controle financeiro
- Entity Framework Core

---

# 👩‍💻 Desenvolvedora

**Ester da Costa Batista**

Desenvolvedora Full Stack

### Tecnologias

- C#
- .NET
- ASP.NET Core
- React
- SQL Server
- Entity Framework Core

GitHub:

https://github.com/Rester-fullstack

LinkedIn:

https://www.linkedin.com/in/ester-da-costa-batista-929500295

---

# 📄 Licença

Projeto desenvolvido para fins de estudo e portfólio.

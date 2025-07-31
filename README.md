# 🛒 Sistema de Vendas com WinForms + SQL Server

Este é um sistema de vendas desktop desenvolvido com **C#**, **WinForms** e **SQL Server**.  
Ele permite realizar **cadastro de clientes, produtos e vendas** com conexão a banco de dados real.

---

## 🎯 Funcionalidades

- ✅ Cadastro de **Clientes** (Nome, Email, Telefone)
- ✅ Cadastro de **Produtos** (Nome, Preço, Estoque)
- ✅ Registro de **Vendas** (Cliente, Produto, Quantidade)
- ✅ Visualização de dados com `DataGridView`
- ✅ Integração com banco de dados SQL Server usando `SqlConnection`

---

## 🛠️ Tecnologias Usadas

- **C#**
- **Windows Forms (WinForms)**
- **SQL Server (LocalDB)**
- **ADO.NET**
- **Visual Studio**

---

## 💽 Estrutura do Banco de Dados

### Tabelas:

sql
CREATE TABLE Clientes (
    Id INT PRIMARY KEY IDENTITY,
    Nome NVARCHAR(100),
    Email NVARCHAR(100),
    Telefone NVARCHAR(20)
);

CREATE TABLE Produtos (
    Id INT PRIMARY KEY IDENTITY,
    Nome NVARCHAR(100),
    Preco DECIMAL(10,2),
    Estoque INT
);

CREATE TABLE Vendas (
    Id INT PRIMARY KEY IDENTITY,
    ClienteId INT FOREIGN KEY REFERENCES Clientes(Id),
    ProdutoId INT FOREIGN KEY REFERENCES Produtos(Id),
    Quantidade INT,
    DataVenda DATETIME DEFAULT GETDATE()
);

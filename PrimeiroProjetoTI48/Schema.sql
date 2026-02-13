
CREATE DATABASE VendasDB;
GO

USE VendasDB;
GO

CREATE TABLE Cliente (
    Id INT IDENTITY PRIMARY KEY,
    Nome NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) NOT NULL,
    Telefone NVARCHAR(20),
    Tipo NVARCHAR(20) NOT NULL
        CONSTRAINT DF_Cliente_Tipo DEFAULT 'user',
    CONSTRAINT CK_Cliente_Tipo CHECK (Tipo IN ('user', 'admin'))
);
GO

CREATE TABLE Produto (
    Id INT IDENTITY PRIMARY KEY,
    Nome NVARCHAR(100) NOT NULL,
    Custo DECIMAL(10,2) NOT NULL
);
GO

CREATE TABLE Venda (
    Id INT IDENTITY PRIMARY KEY,
    ClienteId INT NOT NULL,
    DataVenda DATETIME NOT NULL DEFAULT GETDATE(),

    CONSTRAINT FK_Venda_Cliente
        FOREIGN KEY (ClienteId) REFERENCES Cliente(Id)
);
GO

CREATE TABLE ItemVenda (
    Id INT IDENTITY PRIMARY KEY,
    VendaId INT NOT NULL,
    ProdutoId INT NOT NULL,
    Quantidade INT NOT NULL,
    Desconto DECIMAL(10,2) DEFAULT 0,
    Total DECIMAL(10,2) NOT NULL,

    CONSTRAINT FK_ItemVenda_Venda
        FOREIGN KEY (VendaId) REFERENCES Venda(Id),

    CONSTRAINT FK_ItemVenda_Produto
        FOREIGN KEY (ProdutoId) REFERENCES Produto(Id)
);
GO

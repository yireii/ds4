CREATE DATABASE SkincareDB;

USE SkincareDB;

CREATE TABLE TiposDePiel (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(50) NOT NULL,
    Descripcion NVARCHAR(250) NOT NULL
);

CREATE TABLE Productos (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    TipoDePielId INT FOREIGN KEY REFERENCES TiposDePiel(Id),
    Categoria NVARCHAR(50) NOT NULL, -- Económica o Premium
    Precio DECIMAL(10, 2),
    LugarDeCompra NVARCHAR(250)
);

CREATE TABLE Rutinas (
    Id INT PRIMARY KEY IDENTITY(1,1),
    TipoDePielId INT FOREIGN KEY REFERENCES TiposDePiel(Id),
    Categoria NVARCHAR(50) NOT NULL, -- Económica o Premium
    FechaCreacion DATETIME DEFAULT GETDATE()
);
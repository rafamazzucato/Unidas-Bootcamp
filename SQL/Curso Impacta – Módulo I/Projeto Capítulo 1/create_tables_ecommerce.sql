CREATE TABLE Perfil(
	Id int IDENTITY(1,1) PRIMARY KEY,
	Nome varchar(50) NOT NULL,
);

CREATE TABLE Usuario(
	Id int IDENTITY(1,1) PRIMARY KEY,
	Nome varchar(50) NOT NULL,
	Email varchar(30) NOT NULL,
	Login varchar(30) NOT NULL,
	Senha varchar(30) NOT NULL,
	Ativo bit NOT NULL DEFAULT 0,
	DataModificacao datetime NOT NULL,
	IdPerfil int NOT NULL,
	CONSTRAINT FK_Usuario_Perfil FOREIGN KEY (IdPerfil)
    REFERENCES Perfil(Id)
);

CREATE TABLE Produto(
	Id int IDENTITY(1,1) PRIMARY KEY,
	Nome varchar(50) NOT NULL,
	Preco numeric(14,2) NOT NULL,
	Descricao varchar(100) NOT NULL,
	Ativo bit NOT NULL DEFAULT 0,
	DataModificacao datetime NOT NULL,
	IdUsuario int NOT NULL,
	CONSTRAINT FK_Produto_Usuario FOREIGN KEY (IdUsuario)
    REFERENCES Usuario(Id)
);

CREATE TABLE Estoque(
	Id int IDENTITY(1,1) PRIMARY KEY,
	Quantidade int NOT NULL,
	DataModificacao datetime NOT NULL,
	IdProduto int NOT NULL,
	CONSTRAINT FK_Estoque_Produto FOREIGN KEY (IdProduto)
    REFERENCES Produto(Id)
);
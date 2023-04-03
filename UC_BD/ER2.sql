--DDL
CREATE DATABASE RpgBdBet9
GO

USE RpgBdBet9
GO

CREATE TABLE Usuarios(
	IdUsuario INT PRIMARY KEY IDENTITY,
	Email VARCHAR(100) UNIQUE NOT NULL,
	Senha VARCHAR(255) NOT NULL
)
GO	


CREATE TABLE Classes (
	IdClasse INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(50) UNIQUE NOT NULL,
	Descricao VARCHAR(255)
)
GO

CREATE TABLE Personagens(
	IdPersonagem INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(30) UNIQUE NOT NULL,
	IdUsuario INT UNIQUE FOREIGN KEY REFERENCES Usuarios(IdUsuario),
	IdClasse INT FOREIGN KEY REFERENCES Classes(IdClasse)
)
GO

CREATE TABLE Habilidades (
	IdHabilidade INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(50) UNIQUE NOT NULL, 
	Descricao VARCHAR(255)
)
GO

CREATE TABLE ClassesHabilidades(
	IdClasse INT FOREIGN KEY REFERENCES Classes(IdClasse),
	IdHabilidade INT FOREIGN KEY REFERENCES Habilidades(IdHabilidade)
)
GO

--DML

INSERT INTO Usuarios VALUES ('viniciuspiinhal@gmail.com', 12345678)
INSERT INTO Classes VALUES ('Barbaro', 'Descricao da classe Mago')
INSERT INTO Habilidades VALUES ('Lança Mortal', 'Descricao da lanca mortal'),('Escudo Supremo', 'Descricao do Escudo Supremo')
INSERT INTO Personagens VALUES ('Deubug', 1, 1)
INSERT INTO ClassesHabilidades VALUES (1, 1), (1, 2)

INSERT INTO Usuarios VALUES ('viniciuspiinhal1@gmail.com', 12345678)
INSERT INTO Classes VALUES ('Monge', 'Descricao da Classe Monge')
INSERT INTO Habilidades VALUES ('Recuperarl life', 'Descricao Recuperar Life')
INSERT INTO Personagens VALUES ('DeubugDeMonge', 1, 2)
INSERT INTO ClassesHabilidades VALUES (2, 2), (2, 3)

UPDATE Usuarios
SET SENHA = 'ABCDEF'
WHERE IdUsuario	= 2

--DQL

SELECT * FROM Usuarios
SELECT * FROM Classes
SELECT * FROM Habilidades

SELECT * FROM Usuarios
SELECT IdUsuario, Email FROM Usuarios
SELECT IdUsuario, Email FROM Usuarios WHERE IdUsuario = 1

SELECT * FROM Personagens
JOIN Usuarios
ON Personagens.IdUsuario = Usuarios.IdUsuario

SELECT Personagens.Nome 'Personagem', Usuarios.Email FROM Personagens
JOIN Usuarios
ON Personagens.IdUsuario = Usuarios.IdUsuario

SELECT P.Nome 'Personagem', U.Email FROM Personagens P
JOIN Usuarios U
ON P.IdUsuario = U.IdUsuario

CREATE DATABASE ExemploJoin
GO

USE ExemploJoin
GO

CREATE TABLE NomeA(
	Nome VARCHAR(50) NOT NULL
)
GO

CREATE TABLE NomeB(
	Nome VARCHAR(50) NOT NULL
)
GO

INSERT INTO NomeA VALUES ('Mayra', 'Vinicius')
INSERT INTO NomeB VALUES ('Hercule', 'Maria', 'Edson', 'Elaine')

SELECT * FROM NomeA
INNER JOIN NomeB
ON NomeA.Nome = NomeB.Nome

SELECT * FROM NomeA
LEFT JOIN NomeB
ON NomeA.nome = NomeB.Nome

SELECT * FROM NomeA
RIGHT JOIN NomeB
ON NomeA.Nome = NomeB.Nome

SELECT * FROM NomeA
FULL OUTER JOIN NomeB
ON NomeA.Nome = NomeB.Nome

SELECT * FROM NomeA
FULL OUTER JOIN NomeB
ON NomeA.Nome = NomeB.Nome
WHERE NomeA.Nome IS NULL

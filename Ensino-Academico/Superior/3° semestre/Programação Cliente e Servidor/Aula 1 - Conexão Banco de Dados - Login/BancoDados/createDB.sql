-- CRIANDO O BANCO DE DADOS
CREATE DATABASE METODISTA;

-- ABRINDO/USANDO O BANCO DE DADOS
USE METODISTA;

-- CRIANDO A TABELA DE USUARIOS
CREATE TABLE TAB_USUARIOS (
	USUARIO		VARCHAR(20),
    SENHA		VARCHAR(20),
    PRIMARY KEY (USUARIO,SENHA)
);

-- INSERINDO DOIS USUARIOS NA TABELA
INSERT INTO TAB_USUARIOS (USUARIO, SENHA) VALUES ('WALLACE', '123');
INSERT INTO TAB_USUARIOS (USUARIO, SENHA) VALUES ("THAMARA", "124");
INSERT INTO TAB_USUARIOS (USUARIO, SENHA) VALUES ("ERICK", "125");
INSERT INTO TAB_USUARIOS (USUARIO, SENHA) VALUES ("VITOR", "126");
INSERT INTO TAB_USUARIOS (USUARIO, SENHA) VALUES ("JULIA", "127");
INSERT INTO TAB_USUARIOS (USUARIO, SENHA) VALUES ("NICOLAS", "128");

-- OLHANDO O INTERNO DA TABELA (O QUE TEM NA TABELA)
SELECT * FROM TAB_USUARIOS;

-- DELETANDO UM REGISTRO NA TABELA
DELETE FROM TAB_USUARIOS WHERE USUARIO = 'MARIA' AND SENHA = '124';



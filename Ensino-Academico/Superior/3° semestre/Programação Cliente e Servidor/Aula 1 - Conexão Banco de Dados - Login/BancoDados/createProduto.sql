-- criando a tabela categoria
CREATE TABLE CATEGORIA (
	CODIGO		VARCHAR(5)		NOT NULL,
    NOMECATE	VARCHAR(200)	NOT NULL,
    primary key (CODIGO)
);

-- inserindo os dados na tabela categoria
INSERT INTO CATEGORIA (CODIGO, NOMECATE) VALUES ('100','TINTAS');
INSERT INTO CATEGORIA (CODIGO, NOMECATE) VALUES ('200','PRÉ PINTURA');
INSERT INTO CATEGORIA (CODIGO, NOMECATE) VALUES ('300','IMPERMEABILIZANTES');
INSERT INTO CATEGORIA (CODIGO, NOMECATE) VALUES ('400','MARCENARIA E FERRAMENTAS');
INSERT INTO CATEGORIA (CODIGO, NOMECATE) VALUES ('500','SOLVENTES');
INSERT INTO CATEGORIA (CODIGO, NOMECATE) VALUES ('600','ACESSÓRIOS');

-- criando a tabela produto
CREATE TABLE PRODUTOS (
	CODIGO		VARCHAR(5)		NOT NULL,
    CODCATE		VARCHAR(5)		NOT NULL,
    NOMEPRODUTO	VARCHAR(200)	NOT NULL,
    PRIMARY KEY (CODIGO)
);

-- inserindo os dados na tabela produtos
INSERT INTO PRODUTOS (CODIGO, CODCATE, NOMEPRODUTO) VALUES ('10','100','PAREDE E TETO');
INSERT INTO PRODUTOS (CODIGO, CODCATE, NOMEPRODUTO) VALUES ('11','100','AZULEJOS');
INSERT INTO PRODUTOS (CODIGO, CODCATE, NOMEPRODUTO) VALUES ('12','100','GESSO');

-- criando a tabela precoProduto
CREATE TABLE PRECOPRODUTO (
	CODIGO		VARCHAR(5)		NOT NULL,
	CODPROD		VARCHAR(5)		NOT NULL,
    NOMEITEM	VARCHAR(200)	NOT NULL,
    PRECO		DOUBLE,
    PRIMARY KEY (CODIGO)    
);

-- inserindo os dados na tabela precoproduto
INSERT INTO PRECOPRODUTO (CODIGO, CODPROD, NOMEITEM, PRECO) VALUES ('30','10','PISO BRANCO','279.98');
INSERT INTO PRECOPRODUTO (CODIGO, CODPROD, NOMEITEM, PRECO) VALUES ('31','10','TINTA ACRILICA FOSCO BRANCO LUMINOSA','224.10');
INSERT INTO PRECOPRODUTO (CODIGO, CODPROD, NOMEITEM, PRECO) VALUES ('32','10','TINTA ACRILICA FOSCO BRANCO RENDE SUPER','337.50');

INSERT INTO PRECOPRODUTO (CODIGO, CODPROD, NOMEITEM, PRECO) VALUES ('33','11','TINTA ESMALTE EPOXI BASE AGUA MULTISSUPERFICIES SUVINIL','77.45');
INSERT INTO PRECOPRODUTO (CODIGO, CODPROD, NOMEITEM, PRECO) VALUES ('34','11','EPOXI RENOVA AZULEJO BRILHANTE BASE AGUA BRANCO CORAL','347.40');



/*Criando base de dados escola*/
CREATE DATABASE escola
USE escola
/*Criando tabela cursos*/
CREATE TABLE cursos (
    id INT PRIMARY KEY,
    nome_curso VARCHAR(50) UNIQUE,
    preco_curso int
);
/*Criando tabelas escola*/
CREATE TABLE escola (
	id INT PRIMARY KEY,
    nome_escola VARCHAR(50) UNIQUE,
    curso VARCHAR(50),
    CONSTRAINT fk_curso FOREIGN KEY (curso) REFERENCES cursos(nome_curso)
);
/*Criando tabelas alunos*/
CREATE TABLE alunos (
    id INT PRIMARY KEY,
    nome VARCHAR(30),
    curso VARCHAR(50),
    CONSTRAINT fk_cursoaluno FOREIGN KEY (curso) REFERENCES cursos(nome_curso),
    escola VARCHAR(50),
    CONSTRAINT fk_escola FOREIGN KEY (escola) REFERENCES escola(nome_escola)
);
/*Inserindo valores e atribuindo dados da chave estrangeira*/
INSERT INTO cursos (id, nome_curso, preco_curso) VALUES (1, 'Administração', 440);
INSERT INTO escola (id, nome_escola, curso) VALUES (1, 'Escola Barbara de Araujo', 'Administração');
INSERT INTO alunos (id, nome, curso, escola) VALUES (1, 'Erick', 'Administração', 'Escola Barbara de Araujo');

INSERT INTO cursos (id, nome_curso, preco_curso) VALUES (2, 'Teatro', 260);
INSERT INTO escola (id, nome_escola, curso) VALUES (2, 'Escola Silva Sousa', 'Teatro');
INSERT INTO alunos (id, nome, curso, escola) VALUES (2, 'Thamara', 'Teatro', 'Escola Silva Sousa');

INSERT INTO cursos (id, nome_curso, preco_curso) VALUES (3, 'Engenharia de Produção', 855);
INSERT INTO escola (id, nome_escola, curso) VALUES (3, 'Escola Silva Bezerra', 'Engenharia de Produção');
INSERT INTO alunos (id, nome, curso, escola) VALUES (3, 'Victor', 'Engenharia de Produção', 'Escola Silva Bezerra');

INSERT INTO cursos (id, nome_curso, preco_curso) VALUES (4, 'Paleontologia', 575);
INSERT INTO escola (id, nome_escola, curso) VALUES (4, 'Escola Santos Ribeiro', 'Paleontologia');
INSERT INTO alunos (id, nome, curso, escola) VALUES (4, 'Wallace', 'Paleontologia', 'Escola Santos Ribeiro');

INSERT INTO cursos (id, nome_curso, preco_curso) VALUES (5, 'Gestão da Tecnologia da Informação', 710);
INSERT INTO escola (id, nome_escola, curso) VALUES (5, 'Escola Roger de Oliveira', 'Gestão da Tecnologia da Informação');
INSERT INTO alunos (id, nome, curso, escola) VALUES (5, 'Nicolas', 'Gestão da Tecnologia da Informação', 'Escola Roger de Oliveira');

INSERT INTO cursos (id, nome_curso, preco_curso) VALUES (6, 'Biologia', 915);
INSERT INTO escola (id, nome_escola, curso) VALUES (6, 'Escola Vecchione Romero', 'Biologia');
INSERT INTO alunos (id, nome, curso, escola) VALUES (6, 'Julia', 'Biologia', 'Escola Vecchione Romero');

/*Exibindo dados da tabela*/
select * from cursos;
select * from escola;
select * from alunos;

-- Exibindo dados da tabela cursos com ROUND
SELECT 
    id, 
    nome_curso AS "Curso", 
    ROUND(preco_curso, 2) AS "Preço Arredondado"
FROM cursos;

-- Exibindo dados da tabela escola
SELECT 
    id AS "ID da Escola", 
    nome_escola AS "Nome da Escola", 
    curso AS "Curso Oferecido"
FROM escola;

-- Exibindo dados da tabela alunos com JOIN e funções ALIAS e ROUND
SELECT 
    a.id AS "ID do Aluno", 
    a.nome AS "Nome do Aluno", 
    a.curso AS "Curso do Aluno", 
    e.nome_escola AS "Escola do Aluno", 
    ROUND(c.preco_curso, 2) AS "Preço do Curso"
FROM alunos a
JOIN escola e ON a.escola = e.nome_escola
JOIN cursos c ON a.curso = c.nome_curso;

-- Calculando o número de alunos por curso, agrupando os dados por curso
SELECT 
    curso AS "Curso", 
    COUNT(id) AS "Número de Alunos"
FROM alunos
GROUP BY curso; -- Agrupa os registros por curso

-- Filtrando os cursos que possuem mais de um aluno matriculado
SELECT 
    curso AS "Curso", 
    COUNT(id) AS "Número de Alunos"
FROM alunos
GROUP BY curso -- Agrupa os registros por curso
HAVING COUNT(id) > 1; -- Exibe apenas os grupos com mais de 1 aluno

-- Calculando o preço médio dos cursos e ordenando os resultados por preço médio em ordem decrescente
SELECT 
    c.nome_curso AS "Curso", 
    AVG(c.preco_curso) AS "Preço Médio"
FROM cursos c
GROUP BY c.nome_curso -- Agrupa os registros por curso
ORDER BY AVG(c.preco_curso) DESC; -- Ordena os cursos pelo preço médio em ordem decrescente

-- Comandos utilizando AND, OR e NOT
-- Exibindo cursos com preço maior que 500 AND menos de 900
SELECT 
    id, 
    nome_curso AS "Curso", 
    ROUND(preco_curso, 2) AS "Preço Arredondado"
FROM cursos
WHERE preco_curso > 500 AND preco_curso < 900;

-- Exibindo alunos que estão matriculados em cursos de "Biologia" OR "Teatro"
SELECT 
    a.id AS "ID do Aluno", 
    a.nome AS "Nome do Aluno", 
    a.curso AS "Curso do Aluno", 
    e.nome_escola AS "Escola do Aluno"
FROM alunos a
JOIN escola e ON a.escola = e.nome_escola
WHERE a.curso = 'Biologia' OR a.curso = 'Teatro';

-- Excluindo cursos com preço superior a 800 usando NOT
SELECT 
    id, 
    nome_curso AS "Curso", 
    ROUND(preco_curso, 2) AS "Preço Arredondado"
FROM cursos
WHERE NOT (preco_curso > 800);

-- Filtrando escolas que oferecem cursos com preço menor que 500 OR mais de 800
SELECT 
    e.id AS "ID da Escola", 
    e.nome_escola AS "Nome da Escola", 
    e.curso AS "Curso Oferecido"
FROM escola e
JOIN cursos c ON e.curso = c.nome_curso
WHERE c.preco_curso < 500 OR c.preco_curso > 800;

-- Exibindo alunos que não pertencem à escola "Escola Santos Ribeiro"
SELECT 
    a.id AS "ID do Aluno", 
    a.nome AS "Nome do Aluno", 
    a.curso AS "Curso do Aluno", 
    a.escola AS "Escola"
FROM alunos a
WHERE NOT (a.escola = 'Escola Santos Ribeiro');

-- Exibindo Calculo da variância em um conjunto de linhas na tabela cursos no item preco_curso com VARIANCE.
SELECT VARIANCE(preco_curso) AS variancia FROM cursos;

-- Utilizando Lower e Upper para visualizanos nome dos alunos em diferentes tamanhos
SELECT LOWER(nome) AS nome_minusculo FROM alunos;
SELECT UPPER(nome) AS nome_maiusculo FROM alunos;

-- Criando novo banco de dados Matricula e inserindo tabela NovosAlunos
CREATE DATABASE MATRICULA;
USE MATRICULA

CREATE TABLE NovosAlunos(
	id INT PRIMARY KEY,
    nome_novo_aluno VARCHAR(50) UNIQUE,
    nasc VARCHAR(12)
);
-- Inserindo valores na tabela NovosAlunos
INSERT INTO NovosAlunos (id, nome_novo_aluno, nasc) VALUES (7, 'William', '12-06-2003');
INSERT INTO NovosAlunos (id, nome_novo_aluno, nasc) VALUES (8, 'Aline', '27-01-2002');

-- Inserindo formatação de Data no campo nasc
SELECT 
    id, 
    TO_DATE(nasc, 'DD-MM-YYYY') AS data_formatada,
    nome_novo_aluno
FROM NovosAlunos;











	






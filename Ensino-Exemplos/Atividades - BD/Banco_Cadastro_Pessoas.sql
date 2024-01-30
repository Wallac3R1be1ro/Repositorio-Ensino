
/*Criando uma nova tabela com duas chaves estrangeiras*/
create table pessoas_assistencia_cursos (
		id int not null auto_increment,
        data date,
        idpessoas int,
        idcursos int,
        primary key (id),
        foreign key (idpessoas) references pessoas(id),
        foreign key (idcursos) references cursos(idcursos)
) default charset = utf8;

/*Definindo a data de começo de curso ao aluno de id='1' que faz o curso de id='2' */
insert into pessoas_assistencia_cursos values
(default, '2014-03-01', '1', '2');

select * from pessoas_assistencia_cursos;

/*Exibindo os campos do aluno com os valores adicionados acima e pelas duas chaves estrangeiras*/
select * from pessoas p
join pessoas_assistencia_cursos a
on p.id = a.idpessoas;





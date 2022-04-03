use db_banco;
create table Pessoa (
    id integer AUTO_INCREMENT,
    nome VARCHAR(50),
    cpf VARCHAR(11),
    primary key(id)
);

insert into Pessoa (nome,cpf)values ( 'Lara',  '12345678912');
insert into Pessoa (nome,cpf)values ( 'Leandro',  '12345678911');
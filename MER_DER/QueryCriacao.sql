create database AtelieViviSystem;

create table Clientes(
	CPF char(11) Primary Key not null,
	Nome varchar(20) not null,
	Sobrenome varchar(20) not null,
	Logradouro varchar(20) not null,
	Complemento varchar(20) not null,
	Rua varchar(50) not null,
	Bairro varchar(20) not null,
	Numero varchar(5) not null,
	RG char(9) not null Unique,
	Celular char(11) not null Unique,
	User_Insta varchar(20) not null,
	Id_Cidade int not null
);

create table Cidades(
	Id_cidade int Primary Key not null,
	Cidade varchar(20) not null,
	Id_Estado int not null
);

create table Estados(
	Id_estado int Primary Key not null Identity(1,1),
	Estado char(2) not null,
);

create table Locacoes(
	Id_Locacao int Primary Key not null Identity(1,1),
	Data_Locacao date not null,
	Horario_Locacao time not null,
	Nome_Aniversariante varchar(20) not null,
	Sobrenome_Aniversariante varchar(20) not null,
	Tema varchar(20) not null,
	Logradouro varchar(20) not null,
	Complemento varchar(20) not null,
	Rua varchar(50) not null,
	Bairro varchar(20) not null,
	Numero varchar(5) not null,
	Id_Cidade int not null,
	CPF_cliente char(11) not null,
);

alter table locacoes
add constraint FK_Cidades_Locacoes
Foreign Key (Id_Cidade)
References Cidades (Id_Cidade);

alter table locacoes
add constraint FK_Clientes_Locacoes
Foreign Key (CPF_Cliente)
References Clientes (Cpf);

alter table clientes
add constraint FK_Cidades_Clientes
Foreign Key (Id_Cidade)
References Cidades (Id_Cidade);

alter table Cidades
add constraint FK_Estados_Cidades
Foreign Key (Id_Estado)
References Estados (Id_estado);

insert into Estados (Estado) values ('SP');
insert into Cidades (Id_cidade, Cidade, Id_Estado) values (1, 'Nova Odessa', 1), (2, 'Sumaré', 1), (3, 'Americana', 1);

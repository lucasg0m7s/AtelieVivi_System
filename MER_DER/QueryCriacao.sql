create database AtelieViviSystem;

use AtelieViviSystem;

create table Clientes(
	CPF char(11) Primary Key not null,
	Nome varchar(20) not null,
	Sobrenome varchar(20) not null,
	Logradouro varchar(20) not null,
	Complemento varchar(20) not null,
	Rua varchar(20) not null,
	Bairro varchar(20) not null,
	Numero int not null,
	RG char(9) not null,
	Celular char(11) not null,
	User_Insta varchar(20) not null,
	Id_Cidade int not null
);
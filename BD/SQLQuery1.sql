CREATE DATABASE EJERCICIO
USE EJERCICIO

CREATE TABLE USUARIO(
USUARIO VARCHAR(50) PRIMARY KEY,
CONTRASE�A VARCHAR(50),
ROLL VARCHAR(50)
);

INSERT INTO Usuario VALUES ('Gaby2826','1','administrador')
INSERT INTO Usuario VALUES ('Adonai10','2','usuario')
INSERT INTO Usuario VALUES ('Raul28','3','secretaria')
INSERT INTO Usuario VALUES ('Estefany74','4','administrador')

CREATE TABLE CLIENTES(
nombre varchar(50),
apellido varchar(50),
correo varchar(50),
edad int,
usuario varchar(50),
contrase�a varchar(50),
roll varchar(50))

select *from CLIENTES
select *from Usuario
CREATE DATABASE GESTIONPEDIDO

CREATE TABLE CLIENTE (
IDCLIENTE INT IDENTITY (1,1) NOT NULL,
NOMBRE NVARCHAR (50) NOT NULL,
APELLIDO NVARCHAR (50) NOT NULL,
CORREO NVARCHAR (20) NULL,
TELEFONO NVARCHAR (50) NULL,
DIRECCION NVARCHAR (50) NOT NULL,
PRIMARY KEY (IDCLIENTE),
);

CREATE TABLE PEDIDO (
IDPEDIDO INT IDENTITY (1,1) NOT NULL,
IDCLIENTE INT NOT NULL,
FECHA DATETIME NOT NULL,
TOTAL MONEY NOT NULL,
ESTADO NVARCHAR (20) NOT NULL,
PRIMARY KEY (IDPEDIDO),
FOREIGN KEY (IDCLIENTE) REFERENCES CLIENTE (IDCLIENTE)
);


insert into cliente values('Pedro' ,'Fernandez','pedro@gmail.com','+59172979377','B. San Mateo');
insert into cliente values('Adrián' ,'Pérez' ,'adrian@gmail.com','+59161234567' ,'B. Las Panosas');
insert into cliente values('Belén','González' ,'belen@gmail.com','+59173456789' ,'B. Trigal');
insert into cliente values('Ana' ,'Rodríguez' ,'ana@gmail.com','+59169876543' ,'B. La Loma');
insert into cliente values('Bruno' ,'López' ,'bruno@gmail.com','+59176213456' ,'B. Senac');

SELECT * FROM CLIENTE


insert into pedido values (1,'2022-01-09 12:47:29', '100', 'Cancelado');
insert into pedido values (2,'2022-01-12 11:34:09', '450', 'Cancelado');
insert into pedido values (3,'2022-01-10 09:27:20', '300', 'Cancelado');
insert into pedido values (4,'2022-01-08 08:10:29', '678', 'Cancelado');
insert into pedido values (5,'2022-01-06 12:36:59', '206', 'Pendiente');

SELECT * FROM PEDIDO

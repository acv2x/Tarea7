CREATE DATABASE Tarea7
GO
USE Tarea7

CREATE TABLE Personas (
ID int IDENTITY Primary Key not null, 
Cedula nvarchar(50) UNIQUE not null, 
Nombre nvarchar(50),
Apellido nvarchar(50),
Fecha_Nacimiento nvarchar(50),
Signo_Zodiacal nvarchar(50),
Vacuna_Recibida nvarchar(50),
Provincia nvarchar(50),
Primera_Dosis nvarchar(50),
Segunda_Dosis nvarchar(50) default 'No'
)

CREATE TABLE Vacunas(
ID int IDENTITY Primary Key not null, 
Marca nvarchar(50) not null, 
)

CREATE TABLE Provincias(
ID int IDENTITY Primary Key not null,
Provincia nvarchar(50)
)
CREATE TABLE SignosZodiacales(
ID int IDENTITY Primary Key not null, 
Signo nvarchar(50)
)

INSERT INTO SignosZodiacales (Signo) values ('Capricornio')
SELECT * FROM Personas



SELECT * FROM Provincias





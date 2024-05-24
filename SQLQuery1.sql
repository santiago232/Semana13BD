CREATE TABLE carrera(
      id int primary key identity,
	  nombre varchar(40) not null
)

insert into carrera(nombre) values ('Ingeneria')
insert into carrera(nombre) values ('Administracion')

SELECT *
from carrera

SELECT a.id, a.nombres, a.apellidos, a.carnet, a.telefono, a.idCarrera, c.nombre as nombreCarrera FROM Alumno a JOIN Carrera c ON a.idCarrera = c.id
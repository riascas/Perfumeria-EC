USE DBPerfumeria_Cosmos

go

Insert into USUARIO (DNI, Nombre, Apellido, Correo, Estado) values
('35623652', 'Ruth', 'Iascas', 'riascas@cosmos.com.ar', 1),
('25369875', 'Rodrigo', 'Gomez', 'rgomez@cosmos.com.ar', 1),
('32568745', 'Carla', 'Avila', 'cavila@cosmos.com.ar', 1),
('33652145', 'Ignacio', 'Vazquez', 'ivazquez@cosmos.com.ar', 1)

go
select * from Rol
select * from USUARIO
select * from EMPLEADO

go

insert into EMPLEADO (FKUsuario, FKRol, NombreUsuario, Clave) values
(2, 2, 'riascas', '123456'),
(3, 3, 'rgomez', '123456'),
(4, 4, 'cavila', '123456'),
(5, 5, 'ivazquez', '123456')

select * from PERMISO
USE DBPerfumeria_Cosmos

select * from Rol

select * from PERMISO

insert into PERMISO(FKRol,NombreMenu)values 
(1,'iconoEmpleado'),
(1,'iconoABM'),
(1,'iconoVenta'),
(1,'iconoCompra'),
(1,'iconoCliente'),
(1,'iconoProveedor'),
(1,'iconoReporte')


insert into Rol(Descripcion) values
('Administrador local'),
('Gerente'),
('Vendedor'),
('Encargado de Stock')

insert into PERMISO(FKRol,NombreMenu)values 
(2,'iconoEmpleado'),
(2,'iconoABM'),
(2,'iconoVenta'),
(2,'iconoCliente')

insert into PERMISO(FKRol,NombreMenu)values 
(3,'iconoCliente'),
(3,'iconoReporte')

insert into PERMISO(FKRol,NombreMenu)values 
(4,'iconoVenta'),
(4,'iconoCliente')

insert into PERMISO(FKRol,NombreMenu)values 
(5,'iconoABM'),
(5,'iconoCompra'),
(5,'iconoProveedor')
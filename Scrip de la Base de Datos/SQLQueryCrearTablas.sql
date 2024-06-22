use DBPerfumeria_Cosmos
go

create table Rol(
IDRol int primary key identity,
Descripcion varchar (50),
FechaRegistro datetime default getdate())

go

create table PERMISO(
IDPermiso int primary key identity,
FKRol int references Rol(IDRol),
NombreMenu varchar (100),
FechaRegistro datetime default getdate())

go

create table USUARIO(
IDUsuario int primary key identity,
DNI varchar (50),
Nombre varchar (100),
Apellido varchar (100),
Correo varchar (50),
Estado bit,
FechaRegistro datetime default getdate())

go

create table EMPLEADO(
IDEmpleado int primary key identity,
FKUsuario int references USUARIO(IDUsuario),
FKRol int references Rol(IDRol),
NombreUsuario varchar (50),
Clave varchar (50))

go

create table PROVEEDOR(
IDProveedor int primary key identity,
FKUsuario int references USUARIO(IDUsuario),
Documento varchar (50),
RozonSocial varchar (50),
Telefono varchar (50))

go

create table CLIENTE(
IDCliente int primary key identity,
NumContacto varchar (50),
FKUsuario int references USUARIO(IDUsuario))

go

create table COMPRA(
IDCompra int primary key identity,
FKEmpleado int references EMPLEADO(IDEmpleado),
FKProveedor int references PROVEEDOR(IDProveedor),
TipoDocumento varchar (50),
NumeroDocumento varchar (50),
MontoTotal decimal(10,2),
FechaRegistro datetime default getdate())

go

create table CATEGORIA(
IDCategoria int primary key identity,
Descripcion varchar (100),
Estado bit,
FechaRegistro datetime default getdate())

go

create table PRODUCTO(
IDProducto int primary key identity,
FKCategoria int references CATEGORIA(IDCategoria),
Codigo varchar (50),
Nombre varchar (50),
Descripcion varchar (50),
Stock int not null default 0,
StockMinimo int not null default 0,
PrecioCompra decimal (10,2) default 0,
PrecioVenta decimal (10,2) default 0,
Estado bit,
FechaRegistro datetime default getdate())

go

create table DETALLE_COMPRA(
IDDetalleCompra int primary key identity,
FKCompra int references Compra(IDCompra),
FKProducto int references Producto(IDProducto),
PrecioCompra decimal (10,2) default 0,
PrecioVenta decimal (10,2) default 0,
Cantidad int,
Total decimal (10,2),
FechaRegistro datetime default getdate())

go

create table VENTA(
IDVenta int primary key identity,
FKEmpleado int references EMPLEADO(IDEmpleado),
FKCliente int references CLIENTE(IDCliente),
TipoDocumento varchar (50),
NumeroDocumento varchar (50),
DNICliente varchar (50),
NombreCliente varchar (100),
ApellidoCliente varchar (100),
MontoTotal decimal(10,2),
FechaRegistro datetime default getdate())

go

create table DETALLE_VENTA(
IDDetalleventa int primary key identity,
FKVenta int references VENTA(IDVenta),
FKProducto int references Producto(IDProducto),
PrecioVenta decimal (10,2) default 0,
Cantidad int,
SubTotal decimal (10,2),
FechaRegistro datetime default getdate())
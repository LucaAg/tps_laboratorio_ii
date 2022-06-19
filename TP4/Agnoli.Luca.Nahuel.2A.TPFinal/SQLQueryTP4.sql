Create database IMA_SUCURSALES;
GO
use IMA_SUCURSALES;
GO
create table sucursales(
id int identity,
localidad varchar(40) not null,
numeroTelefono float not null,
direccion varchar(40) not null
)

insert into sucursales (localidad,numeroTelefono,direccion) values
('Pilar', 42578698, 'Loma Negra 598'),
('Avellaneda', 45123697, 'Av. Libertador 517'),
('Berazategui', 48569423, 'Calle 16 1587'),
('Quilmes', 42572627, 'Alvear 745'),
('Wilde', 46589749, 'Piedra Buena 52'),
('Don Bosco', 46484749, 'Nicaragua 35');

select id as ID, localidad as Localidad, numeroTelefono as Telefono, direccion as Direccion from sucursales;

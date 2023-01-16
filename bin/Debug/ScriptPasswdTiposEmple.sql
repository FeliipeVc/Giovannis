-- BORRAR DATOS
DELETE FROM Pedidos;
DELETE FROM Menu;
DELETE FROM Notificaciones;
DELETE FROM Fichajes;
DELETE FROM Entrantes;
DELETE FROM Empleados;
DELETE FROM Pizzas;
DELETE FROM Stock;
DELETE FROM Tiendas;
DELETE FROM Refrescos;
DELETE FROM Proveedores;
DELETE FROM Clientes;



-- INSERTAR DATOS
--TABLA CLIENTE
INSERT INTO Clientes(id_cliente, cliente_nombre, cliente_apellido,cliente_fecha_nac,cliente_email) VALUES ('1','Jorge','Cremades','2000-12-12','jorge@gmail.com');
INSERT INTO Clientes(id_cliente, cliente_nombre, cliente_apellido,cliente_fecha_nac,cliente_email) VALUES ('2','Alberto','Mayo','2001-04-05','alberto@gmail.com');
INSERT INTO Clientes(id_cliente, cliente_nombre, cliente_apellido,cliente_fecha_nac,cliente_email) VALUES ('3','César','Fraile','2002-08-02','cesar@gmail.com');
INSERT INTO Clientes(id_cliente, cliente_nombre, cliente_apellido,cliente_fecha_nac,cliente_email) VALUES ('4','Hugo','Magallanes','2000-12-12','hugo@gmail.com');
INSERT INTO Clientes(id_cliente, cliente_nombre, cliente_apellido,cliente_fecha_nac,cliente_email) VALUES ('5','Aitor','Delgado','2003-06-20','aitor@gmail.com');
INSERT INTO Clientes(id_cliente, cliente_nombre, cliente_apellido,cliente_fecha_nac,cliente_email) VALUES ('6','Nuria','Ruiz','1953-12-31','nuria@gmail.com');
INSERT INTO Clientes(id_cliente, cliente_nombre, cliente_apellido,cliente_fecha_nac,cliente_email) VALUES ('7','Cristina','Cantos','1963-01-15','cristina@gmail.com');
INSERT INTO Clientes(id_cliente, cliente_nombre, cliente_apellido,cliente_fecha_nac,cliente_email) VALUES ('8','Claudia','Cremades','1975-08-07','claudia@gmail.com');
INSERT INTO Clientes(id_cliente, cliente_nombre, cliente_apellido,cliente_fecha_nac,cliente_email) VALUES ('9','Carmen','González','1984-07-06','carmen@gmail.com');
INSERT INTO Clientes(id_cliente, cliente_nombre, cliente_apellido,cliente_fecha_nac,cliente_email) VALUES ('10','Águeda','Fuertes','2002-03-02','agueda@gmail.com');

-- Tabla proveedores
INSERT INTO Proveedores (id_proveedor, proveedor_nombre) VALUES('1', 'Garcia Vaquero');
INSERT INTO Proveedores (id_proveedor, proveedor_nombre) VALUES('2', 'Enzos formaggio');
INSERT INTO Proveedores (id_proveedor, proveedor_nombre) VALUES('3', 'Vincenzos Impasto');
INSERT INTO Proveedores (id_proveedor, proveedor_nombre) VALUES('4', 'Kali');
INSERT INTO Proveedores (id_proveedor, proveedor_nombre) VALUES('5', 'Pepe el agricultor');
INSERT INTO Proveedores (id_proveedor, proveedor_nombre) VALUES('6', 'Masas mama');
INSERT INTO Proveedores (id_proveedor, proveedor_nombre) VALUES('7', 'Wicked sauce');
INSERT INTO Proveedores (id_proveedor, proveedor_nombre) VALUES('8', 'Pour another one');
INSERT INTO Proveedores (id_proveedor, proveedor_nombre) VALUES('9', 'Felipes pruveedor');
INSERT INTO Proveedores (id_proveedor, proveedor_nombre) VALUES('10', 'Quesos palazuelo');

-- Tabla Refrescos
INSERT INTO Refrescos (id_refresco, refresco_nombre) VALUES('1', 'Coca-cola');
INSERT INTO Refrescos (id_refresco, refresco_nombre) VALUES('2', 'Fanta de naranja');
INSERT INTO Refrescos (id_refresco, refresco_nombre) VALUES('3', 'Cerveza');
INSERT INTO Refrescos (id_refresco, refresco_nombre) VALUES('4', 'Kas');
INSERT INTO Refrescos (id_refresco, refresco_nombre) VALUES('5', 'Trina');
INSERT INTO Refrescos (id_refresco, refresco_nombre) VALUES('6', 'Zumo de naranja');
INSERT INTO Refrescos (id_refresco, refresco_nombre) VALUES('7', 'Agua mineral');
INSERT INTO Refrescos (id_refresco, refresco_nombre) VALUES('8', 'Sprite');
INSERT INTO Refrescos (id_refresco, refresco_nombre) VALUES('9', 'Fanta de limón');
INSERT INTO Refrescos (id_refresco, refresco_nombre) VALUES('10', 'Mountain Dew');


-- Tabla Tiendas
INSERT INTO Tiendas (id_tienda, tienda_nombre, tienda_direccion) VALUES('1', 'Vaguada', 'Avd monforte de lemos');
INSERT INTO Tiendas (id_tienda, tienda_nombre, tienda_direccion) VALUES('2', 'Plaza Rio', 'Avd manzanares');
INSERT INTO Tiendas (id_tienda, tienda_nombre, tienda_direccion) VALUES('3', 'Plaza Norte', 'Pl del comercio');
INSERT INTO Tiendas (id_tienda, tienda_nombre, tienda_direccion) VALUES('4', 'Ferial Plaza', 'Avd eduardo');
INSERT INTO Tiendas (id_tienda, tienda_nombre, tienda_direccion) VALUES('5', 'Isla Azul', 'C/ Calderilla');
INSERT INTO Tiendas (id_tienda, tienda_nombre, tienda_direccion) VALUES('6', 'Sambil', 'C/Mondragón');
INSERT INTO Tiendas (id_tienda, tienda_nombre, tienda_direccion) VALUES('7', 'Parque Sur', 'Avd Gran Bretaña');
INSERT INTO Tiendas (id_tienda, tienda_nombre, tienda_direccion) VALUES('8', 'X Madrid', 'C/ Oslo');
INSERT INTO Tiendas (id_tienda, tienda_nombre, tienda_direccion) VALUES('9', 'Fuencarral', 'C/ Fuencaral');
INSERT INTO Tiendas (id_tienda, tienda_nombre, tienda_direccion) VALUES('10', 'Gran Plaza', 'Majadahonda');

-- Tabla Stock
INSERT INTO Stock (id_ingrediente, stock_nombre, stock_cantidad, id_proveedor) VALUES('1', 'jamón', '100', '1');
INSERT INTO Stock (id_ingrediente, stock_nombre, stock_cantidad, id_proveedor) VALUES('2', 'mozzarella', '400', '2');
INSERT INTO Stock (id_ingrediente, stock_nombre, stock_cantidad, id_proveedor) VALUES('3', 'bacon', '100', '3');
INSERT INTO Stock (id_ingrediente, stock_nombre, stock_cantidad, id_proveedor) VALUES('4', 'tomate', '300', '4');
INSERT INTO Stock (id_ingrediente, stock_nombre, stock_cantidad, id_proveedor) VALUES('5', 'salsa bbq', '200', '5');
INSERT INTO Stock (id_ingrediente, stock_nombre, stock_cantidad, id_proveedor) VALUES('6', 'pepperoni', '120', '6');
INSERT INTO Stock (id_ingrediente, stock_nombre, stock_cantidad, id_proveedor) VALUES('7', 'pollo', '220', '7');
INSERT INTO Stock (id_ingrediente, stock_nombre, stock_cantidad, id_proveedor) VALUES('8', 'carne', '100', '8');
INSERT INTO Stock (id_ingrediente, stock_nombre, stock_cantidad, id_proveedor) VALUES('9', 'chedar', '400', '9');
INSERT INTO Stock (id_ingrediente, stock_nombre, stock_cantidad, id_proveedor) VALUES('10', 'jamón serrano', '50', '10');


-- Tabla pizzas
INSERT INTO Pizzas (id_pizzas, pizza_ingrediente1, pizza_ingrediente2, pizza_ingrediente3, pizza_nombre, pizza_desc) VALUES('1', '4', '1', '2', 'Jamón & Queso', 'Deliciosa pizza de jamón y queso, todo un clásico');
INSERT INTO Pizzas (id_pizzas, pizza_ingrediente1, pizza_ingrediente2, pizza_ingrediente3, pizza_nombre, pizza_desc) VALUES('2', '4', '3', '2', 'Bacon & Queso', 'Una combinación que siempre gusta delicioso bacon crispy y nuestro mejor queso');
INSERT INTO Pizzas (id_pizzas, pizza_ingrediente1, pizza_ingrediente2, pizza_ingrediente3, pizza_nombre, pizza_desc) VALUES('3', '4', '7', '2', 'Pollo & Queso', 'Una pizza repleta de ENERGuIA');
INSERT INTO Pizzas (id_pizzas, pizza_ingrediente1, pizza_ingrediente2, pizza_ingrediente3, pizza_nombre, pizza_desc) VALUES('4', '4', '8', '3', 'BBQ', 'Una combinación exquisita de nuestras salsas y mejores carnes');
INSERT INTO Pizzas (id_pizzas, pizza_ingrediente1, pizza_ingrediente2, pizza_ingrediente3, pizza_nombre, pizza_desc) VALUES('5', '4', '2', '9', '2 Quesos', 'Salsa chedar y nuestra mozzarella mas fresca, a veces no ha que complicarse');
INSERT INTO Pizzas (id_pizzas, pizza_ingrediente1, pizza_ingrediente2, pizza_ingrediente3, pizza_nombre, pizza_desc) VALUES('6', '4', '10', '2', 'Ibérica', 'Sientete como un auténtico macho ibérico, viva España');
INSERT INTO Pizzas (id_pizzas, pizza_ingrediente1, pizza_ingrediente2, pizza_ingrediente3, pizza_nombre, pizza_desc) VALUES('7', '4', '8', '2', 'Lagsana', 'Lagsana en una pizza? pues sí y te parecerá increible el resultado');
INSERT INTO Pizzas (id_pizzas, pizza_ingrediente1, pizza_ingrediente2, pizza_ingrediente3, pizza_nombre, pizza_desc) VALUES('8', '4', '8', '2', 'Pepperoni', 'Todo un hito, nuestro pepperoni picante te dejará sin palabras');
INSERT INTO Pizzas (id_pizzas, pizza_ingrediente1, pizza_ingrediente2, pizza_ingrediente3, pizza_nombre, pizza_desc) VALUES('9', '4', '2', '2', 'Margarita', 'Perfectamente simple');
INSERT INTO Pizzas (id_pizzas, pizza_ingrediente1, pizza_ingrediente2, pizza_ingrediente3, pizza_nombre, pizza_desc) VALUES('10', '4', '9', '3', 'Bacon Xtreme', 'Para los amantes del bacon y de lo extremo');


--TABLA EMPLEADOS
INSERT INTO Empleados(id_empleado,empleado_password,empleado_nombre,empleado_apellidos,empleado_dni,empleado_fecha_nac,id_tienda,empleado_tipo,empleado_salario,empleado_bloqueado)VALUES('1','RoBla','Robert','Blanaru','95165432Q','2002-09-24','1','3',200.34,0);
INSERT INTO Empleados(id_empleado,empleado_password,empleado_nombre,empleado_apellidos,empleado_dni,empleado_fecha_nac,id_tienda,empleado_tipo,empleado_salario,empleado_bloqueado)VALUES('2','SaCa','Sandra','Cabeza','12398764L','1995-11-05','1','2',336.62,0);
INSERT INTO Empleados(id_empleado,empleado_password,empleado_nombre,empleado_apellidos,empleado_dni,empleado_fecha_nac,id_tienda,empleado_tipo,empleado_salario,empleado_bloqueado)VALUES('3','AnMa','Andrea','Martínez','75315998W','2003-08-26','1','3',227.32,0);
INSERT INTO Empleados(id_empleado,empleado_password,empleado_nombre,empleado_apellidos,empleado_dni,empleado_fecha_nac,id_tienda,empleado_tipo,empleado_salario,empleado_bloqueado)VALUES('4','MaIs','María Isabel','López','14736958A','2001-04-17','1','2',545.65,0);
INSERT INTO Empleados(id_empleado,empleado_password,empleado_nombre,empleado_apellidos,empleado_dni,empleado_fecha_nac,id_tienda,empleado_tipo,empleado_salario,empleado_bloqueado)VALUES('5','OsCa','Oscar','Cañellas','64973164Y','1996-05-13','1','2',686.35,0);
INSERT INTO Empleados(id_empleado,empleado_password,empleado_nombre,empleado_apellidos,empleado_dni,empleado_fecha_nac,id_tienda,empleado_tipo,empleado_salario,empleado_bloqueado)VALUES('6','FeMa','Fernando','Martín','95641258B','2012-12-27','1','1',874.49,0);
INSERT INTO Empleados(id_empleado,empleado_password,empleado_nombre,empleado_apellidos,empleado_dni,empleado_fecha_nac,id_tienda,empleado_tipo,empleado_salario,empleado_bloqueado)VALUES('7','DaMa','David','Martinez','62195487R','1990-09-13','1','1',992.15,0);
INSERT INTO Empleados(id_empleado,empleado_password,empleado_nombre,empleado_apellidos,empleado_dni,empleado_fecha_nac,id_tienda,empleado_tipo,empleado_salario,empleado_bloqueado)VALUES('8','NiCa','Nicolás','Cañellas','12645391S','1989-02-03','1','1',1024.69,0);
INSERT INTO Empleados(id_empleado,empleado_password,empleado_nombre,empleado_apellidos,empleado_dni,empleado_fecha_nac,id_tienda,empleado_tipo,empleado_salario,empleado_bloqueado)VALUES('9','IvMa','Iván','Martín','12531269U','1983-07-04','1','1',1563.93,0);
INSERT INTO Empleados(id_empleado,empleado_password,empleado_nombre,empleado_apellidos,empleado_dni,empleado_fecha_nac,id_tienda,empleado_tipo,empleado_salario,empleado_bloqueado)VALUES('10','SeGa','Sergio','García','15264823V','2004-10-01','1','2',1456.12,0);


--TABLA ENTRANTES
INSERT INTO Entrantes(id_entrante, entrante_ingrediente, entrante_salsa, entrante_nombre) VALUES ('1','2','4','Affetti');
INSERT INTO Entrantes(id_entrante, entrante_ingrediente, entrante_salsa, entrante_nombre) VALUES ('2','1','5','Focaccia');
INSERT INTO Entrantes(id_entrante, entrante_ingrediente, entrante_salsa, entrante_nombre) VALUES ('3','4','6','Burrata e pesto');
INSERT INTO Entrantes(id_entrante, entrante_ingrediente, entrante_salsa, entrante_nombre) VALUES ('4','8','2','Stromboli');
INSERT INTO Entrantes(id_entrante, entrante_ingrediente, entrante_salsa, entrante_nombre) VALUES ('5','8','2','Carpaccio');
INSERT INTO Entrantes(id_entrante, entrante_ingrediente, entrante_salsa, entrante_nombre) VALUES ('6','10','2','Pane aglio');
INSERT INTO Entrantes(id_entrante, entrante_ingrediente, entrante_salsa, entrante_nombre) VALUES ('7','9','2','Fondutta piemonttesse');
INSERT INTO Entrantes(id_entrante, entrante_ingrediente, entrante_salsa, entrante_nombre) VALUES ('8','9','2','Piadine');
INSERT INTO Entrantes(id_entrante, entrante_ingrediente, entrante_salsa, entrante_nombre) VALUES ('9','9','2','Patate Salmone');
INSERT INTO Entrantes(id_entrante, entrante_ingrediente, entrante_salsa, entrante_nombre) VALUES ('10','9','4','Provolone al Forno');


--TABLA FICHAJES
INSERT INTO Fichajes(id_fichaje, id_empleado, hora_entrada, hora_salida) VALUES ('1','1','2022-10-12 08:30:03','2022-10-12 17:30:03');
INSERT INTO Fichajes(id_fichaje, id_empleado, hora_entrada, hora_salida) VALUES ('2','2','2022-10-12 08:28:29','2022-10-12 17:28:29');
INSERT INTO Fichajes(id_fichaje, id_empleado, hora_entrada, hora_salida) VALUES ('3','3','2022-10-12 08:34:59','2022-10-12 17:34:59');
INSERT INTO Fichajes(id_fichaje, id_empleado, hora_entrada, hora_salida) VALUES ('4','4','2022-10-12 08:31:02','2022-10-12 17:31:02');
INSERT INTO Fichajes(id_fichaje, id_empleado, hora_entrada, hora_salida) VALUES ('5','5','2022-10-12 08:45:15','2022-10-12 17:39:19');
INSERT INTO Fichajes(id_fichaje, id_empleado, hora_entrada, hora_salida) VALUES ('6','6','2022-10-12 17:30:03','2022-10-12 22:30:35');
INSERT INTO Fichajes(id_fichaje, id_empleado, hora_entrada, hora_salida) VALUES ('7','7','2022-10-12 17:28:29','2022-10-12 22:36:41');
INSERT INTO Fichajes(id_fichaje, id_empleado, hora_entrada, hora_salida) VALUES ('8','8','2022-10-12 17:34:59','2022-10-12 22:31:26');
INSERT INTO Fichajes(id_fichaje, id_empleado, hora_entrada, hora_salida) VALUES ('9','9','2022-10-12 17:31:02','2022-10-12 22:32:16');
INSERT INTO Fichajes(id_fichaje, id_empleado, hora_entrada, hora_salida) VALUES ('10','10','2022-10-12 17:39:15','2022-10-12 22:32:15');


--TABLA NOTIFICACIONES
INSERT INTO Notificaciones(id_emisor,id_remitente,mensaje) VALUES ('1','2','Mi hombre, te tocan horas extras');
INSERT INTO Notificaciones(id_emisor,id_remitente,mensaje) VALUES ('2','3','¿Te faltó lechuga en el pedido de ese cliente?');
INSERT INTO Notificaciones(id_emisor,id_remitente,mensaje) VALUES ('3','6','Buen trabajo por hoy!');
INSERT INTO Notificaciones(id_emisor,id_remitente,mensaje) VALUES ('4','8','Ve a cubrir el puesto de tu compañero');
INSERT INTO Notificaciones(id_emisor,id_remitente,mensaje) VALUES ('5','10','¿Se nos ha acabado la lechuga?');
INSERT INTO Notificaciones(id_emisor,id_remitente,mensaje) VALUES ('6','9','Revisa las cajas');
INSERT INTO Notificaciones(id_emisor,id_remitente,mensaje) VALUES ('7','1','Atiende a la mesa 5');
INSERT INTO Notificaciones(id_emisor,id_remitente,mensaje) VALUES ('8','7','Haz algo mi man');
INSERT INTO Notificaciones(id_emisor,id_remitente,mensaje) VALUES ('9','4','Falta de imaginación 1');
INSERT INTO Notificaciones(id_emisor,id_remitente,mensaje) VALUES ('10','3','Cosa de rellenar');


--TABLA MENU
INSERT INTO Menu(id_menu,menu_precio,id_pizza,id_entrante,id_refresco) VALUES ('1',15.40,'1','1','1');
INSERT INTO Menu(id_menu,menu_precio,id_pizza,id_entrante,id_refresco) VALUES ('2',15.40,'1','1','3');
INSERT INTO Menu(id_menu,menu_precio,id_pizza,id_entrante,id_refresco) VALUES ('3',15.40,'1','1','5');
INSERT INTO Menu(id_menu,menu_precio,id_pizza,id_entrante,id_refresco) VALUES ('4',15.40,'1','1','6');
INSERT INTO Menu(id_menu,menu_precio,id_pizza,id_entrante,id_refresco) VALUES ('5',15.40,'1','1','1');
INSERT INTO Menu(id_menu,menu_precio,id_pizza,id_entrante,id_refresco) VALUES ('6',15.40,'1','1','9');
INSERT INTO Menu(id_menu,menu_precio,id_pizza,id_entrante,id_refresco) VALUES ('7',15.40,'1','1','10');
INSERT INTO Menu(id_menu,menu_precio,id_pizza,id_entrante,id_refresco) VALUES ('8',15.40,'1','1','2');
INSERT INTO Menu(id_menu,menu_precio,id_pizza,id_entrante,id_refresco) VALUES ('9',15.40,'1','1','5');
INSERT INTO Menu(id_menu,menu_precio,id_pizza,id_entrante,id_refresco) VALUES ('10',15.40,'1','1','7');

--TABLA PEDIDOS
INSERT INTO Pedidos(id_pedido,id_menu,id_empleado,id_tienda,id_cliente,pedido_precio,pedido_fecha) VALUES ('1','2','1','2','1',13.14,'2020-12-10 14:24:12');
INSERT INTO Pedidos(id_pedido,id_menu,id_empleado,id_tienda,id_cliente,pedido_precio,pedido_fecha) VALUES ('2','3','2','1','1',15.23,'2020-12-16 14:24:12');
INSERT INTO Pedidos(id_pedido,id_menu,id_empleado,id_tienda,id_cliente,pedido_precio,pedido_fecha) VALUES ('3','6','3','4','1',9.99,'2021-01-17 14:24:12');
INSERT INTO Pedidos(id_pedido,id_menu,id_empleado,id_tienda,id_cliente,pedido_precio,pedido_fecha) VALUES ('4','10','9','10','1',42.97,'2021-05-04 14:24:12');
INSERT INTO Pedidos(id_pedido,id_menu,id_empleado,id_tienda,id_cliente,pedido_precio,pedido_fecha) VALUES ('5','9','7','2','1',26.5,'2021-06-21 14:24:12');
INSERT INTO Pedidos(id_pedido,id_menu,id_empleado,id_tienda,id_cliente,pedido_precio,pedido_fecha) VALUES ('6','3','5','1','1',19.25,'2021-09-13 14:24:12');
INSERT INTO Pedidos(id_pedido,id_menu,id_empleado,id_tienda,id_cliente,pedido_precio,pedido_fecha) VALUES ('7','2','6','10','1',69.99,'2022-02-12 14:24:12');
INSERT INTO Pedidos(id_pedido,id_menu,id_empleado,id_tienda,id_cliente,pedido_precio,pedido_fecha) VALUES ('8','1','1','7','1',51.23,'2022-04-08 14:24:12');
INSERT INTO Pedidos(id_pedido,id_menu,id_empleado,id_tienda,id_cliente,pedido_precio,pedido_fecha) VALUES ('9','5','3','9','1',20.14,'2022-06-10 14:24:12');
INSERT INTO Pedidos(id_pedido,id_menu,id_empleado,id_tienda,id_cliente,pedido_precio,pedido_fecha) VALUES ('10','7','2','3','1',14.25,'2022-08-24 14:24:12');


using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Giovannis.Modelos.Clases;
using Giovannis.Modelos.Excepciones;
using Giovannis.Modelos.Menu;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Giovannis.Modelos.BBDD
{
    public class Consultas : Connector
    {
        public List<List<string>> selectAll(string tabla)
        {
            List<List<string>> pedidos = new List<List<string>>();

            if (this.abrir())
            {
                try
                {
                    string query = $"SELECT * FROM {tabla}";

                    this.comando = new SqlCommand(query, this.conexion);
                    this.registros = comando.ExecuteReader();

                    while (registros.Read())
                    {
                        List<string> fila = new List<string>();
                        for (int i = 0; i < registros.FieldCount; i++)
                        {
                            fila.Add(registros.GetValue(i).ToString());
                        }
                        pedidos.Add(fila);

                    }
                    registros.Close();
                    this.cerrar();
                    return pedidos;
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    conexion.Close();
                    return null;
                }
            }
            else
            {
                MessageBox.Show("Error al conectar con la BBDD");
                throw new ConnectionException("No se pudo realizar la conexión");
            }
        }

        public List<List<string>> selectPizzas(string id)
        {
            List<List<string>> pedidos = new List<List<string>>();

            if (this.abrir())
            {
                try
                {
                    string query = $"SELECT * FROM Pizzas WHERE id_pizzas LIKE '{id}'";

                    this.comando = new SqlCommand(query, this.conexion);
                    this.registros = comando.ExecuteReader();

                    while (registros.Read())
                    {
                        List<string> fila = new List<string>();
                        for (int i = 0; i < registros.FieldCount; i++)
                        {
                            fila.Add(registros.GetValue(i).ToString());
                        }
                        pedidos.Add(fila);

                    }
                    registros.Close();
                    this.cerrar();
                    return pedidos;
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    conexion.Close();
                    return null;
                }
            }
            else
            {
                MessageBox.Show("Error al conectar con la BBDD");
                throw new ConnectionException("No se pudo realizar la conexión");
            }
        }
        public int devuelvoTipo(string nUsuario, string passwd)
        {

            int tipo = -1;

            if (this.abrir())
            {
                try
                {
                    string query = $"SELECT empleado_tipo FROM Empleados WHERE empleado_dni LIKE '{nUsuario}' AND empleado_password LIKE '{passwd}'";

                    this.comando = new SqlCommand(query, this.conexion);
                    this.registros = comando.ExecuteReader();

                    while (registros.Read())
                    {
                        List<string> fila = new List<string>();
                        for (int i = 0; i < registros.FieldCount; i++)
                        {
                           tipo = int.Parse(registros.GetValue(i).ToString());
                        }
                       

                    }
                    registros.Close();
                    this.cerrar();
                    return tipo;
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    conexion.Close();
                    return -1;
                }
            }
            else
            {
                MessageBox.Show("Error al conectar con la BBDD");
                throw new ConnectionException("No se pudo realizar la conexión");
            }
        }
        public int existeEmpleado(string nUsuario)
        {

            int marca = -1;

            if (this.abrir())
            {
                try
                {
                    string query = $"SELECT COUNT(*) FROM Empleados WHERE empleado_dni LIKE '{nUsuario}'";

                    this.comando = new SqlCommand(query, this.conexion);
                    this.registros = comando.ExecuteReader();

                    while (registros.Read())
                    {
                        for (int i = 0; i < registros.FieldCount; i++)
                        {
                            marca = int.Parse(registros.GetValue(i).ToString());
                        }


                    }
                    registros.Close();
                    this.cerrar();
                    return marca;
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    conexion.Close();
                    return -1;
                }
            }
            else
            {
                MessageBox.Show("Error al conectar con la BBDD");
                throw new ConnectionException("No se pudo realizar la conexión");
            }
        }
        public int devuelvoPassword(string nUsuario, string passwd)
        {

            int marcador = -1;

            if (this.abrir())
            {
                try
                {
                    string query = $"SELECT COUNT(*) FROM Empleados WHERE empleado_dni LIKE '{nUsuario}' AND empleado_password LIKE '{passwd}'";

                    this.comando = new SqlCommand(query, this.conexion);
                    this.registros = comando.ExecuteReader();

                    while (registros.Read())
                    {

                        for (int i = 0; i < registros.FieldCount; i++)
                        {
                            marcador = int.Parse(registros.GetValue(i).ToString());
                        }


                    }


                    registros.Close();
                    this.cerrar();
                    return marcador;
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    conexion.Close();
                    return -1;
                }
            }
            else
            {
                MessageBox.Show("Error al conectar con la BBDD");
                throw new ConnectionException("No se pudo realizar la conexión");
            }
        }

        public List<List<string>> selectMenus()
        {
            List<List<string>> menus = new List<List<string>>();

            if (this.abrir())
            {
                try
                {
                    string query = $"SELECT p.pizza_nombre, s.stock_nombre, s2.stock_nombre, s3.stock_nombre, m.menu_precio, p.pizza_desc, m.id_menu FROM Pizzas p JOIN Stock s on p.pizza_ingrediente1 = s.id_ingrediente JOIN Stock s2 on p.pizza_ingrediente2 = s2.id_ingrediente JOIN Stock s3 on p.pizza_ingrediente3 = s3.id_ingrediente JOIN Menu m on m.id_pizza = p.id_pizzas";

                    this.comando = new SqlCommand(query, this.conexion);
                    this.registros = comando.ExecuteReader();

                    while (registros.Read())
                    {
                        List<string> fila = new List<string>();
                        for (int i = 0; i < registros.FieldCount; i++)
                        {
                            fila.Add(registros.GetValue(i).ToString());
                        }
                        menus.Add(fila);

                    }
                    registros.Close();
                    this.cerrar();
                    return menus;
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    conexion.Close();
                    return null;
                }
            }
            else
            {
                MessageBox.Show("Error al conectar con la BBDD");
                throw new ConnectionException("No se pudo realizar la conexión");
            }
        }
        public List<List<string>> selectPedidos()
        {
            List<List<string>> pedidos = new List<List<string>>();

            if (this.abrir())
            {
                try
                {
                    string query = $"SELECT pe.id_pedido, pe.pedido_fecha, ti.tienda_nombre, em.empleado_nombre, cl.cliente_nombre, pi.pizza_nombre, pe.pedido_precio FROM Pedidos pe JOIN Tiendas ti on pe.id_tienda = ti.id_tienda JOIN Empleados em on pe.id_empleado = em.id_empleado JOIN Clientes cl on pe.id_cliente = cl.id_cliente JOIN Pizzas pi on pe.id_menu = pi.id_pizzas";
                    this.comando = new SqlCommand(query, this.conexion);
                    this.registros = comando.ExecuteReader();

                    while (registros.Read())
                    {
                        List<string> fila = new List<string>();
                        for (int i = 0; i < registros.FieldCount; i++)
                        {
                            fila.Add(registros.GetValue(i).ToString());
                        }
                        pedidos.Add(fila);

                    }
                    registros.Close();
                    this.cerrar();
                    return pedidos;
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    conexion.Close();
                    return null;
                }
            }
            else
            {
                MessageBox.Show("Error al conectar con la BBDD");
                throw new ConnectionException("No se pudo realizar la conexión");
            }
        }
        public List<List<string>> selectStock()
        {
            List<List<string>> menus = new List<List<string>>();

            if (this.abrir())
            {
                try
                {
                    string query = $"SELECT s.stock_cantidad, s.stock_nombre, p.proveedor_nombre FROM Stock s JOIN Proveedores p on s.id_proveedor = p.id_proveedor";

                    this.comando = new SqlCommand(query, this.conexion);
                    this.registros = comando.ExecuteReader();

                    while (registros.Read())
                    {
                        List<string> fila = new List<string>();
                        for (int i = 0; i < registros.FieldCount; i++)
                        {
                            fila.Add(registros.GetValue(i).ToString());
                        }
                        menus.Add(fila);

                    }
                    registros.Close();
                    this.cerrar();
                    return menus;
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    conexion.Close();
                    return null;
                }
            }
            else
            {
                MessageBox.Show("Error al conectar con la BBDD");
                throw new ConnectionException("No se pudo realizar la conexión");
            }
        }

        public void modificar_proveedor(String viejo, String nuevo) {

            if (this.abrir())
            {
                try
                {
                    string query = $"UPDATE Proveedores SET proveedor_nombre = '{nuevo}' WHERE proveedor_nombre LIKE '{viejo}'";

                    this.comando = new SqlCommand(query, this.conexion);
                    this.registros = comando.ExecuteReader();

           
                    registros.Close();
                    this.cerrar();
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    conexion.Close();
                }
            }
            else
            {
                MessageBox.Show("Error al conectar con la BBDD");
                throw new ConnectionException("No se pudo realizar la conexión");
            }

        }

        public int existePizza(string nombre)
        {

            int marca = -1;

            if (this.abrir())
            {
                try
                {
                    string query = $"SELECT COUNT(*) FROM Pizzas WHERE pizza_nombre LIKE '{nombre}'";

                    this.comando = new SqlCommand(query, this.conexion);
                    this.registros = comando.ExecuteReader();

                    while (registros.Read())
                    {
                        for (int i = 0; i < registros.FieldCount; i++)
                        {
                            marca = int.Parse(registros.GetValue(i).ToString());
                        }


                    }
                    registros.Close();
                    this.cerrar();
                    return marca;
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    conexion.Close();
                    return -1;
                }
            }
            else
            {
                MessageBox.Show("Error al conectar con la BBDD");
                throw new ConnectionException("No se pudo realizar la conexión");
            }
        }

        public void modificar_pedido(String nuevo, String viejo)
        {

            if (this.abrir())
            {
                try
                {
                    string query = $"UPDATE Pedidos SET id_menu = (SELECT id_pizzas FROM Pizzas WHERE pizza_nombre LIKE '{nuevo}') , pedido_precio = (SELECT me.menu_precio FROM Menu me JOIN Pizzas pi on me.id_pizza = pi.id_pizzas WHERE pi.pizza_nombre LIKE '{nuevo}')  WHERE id_pedido LIKE '{viejo}'";

                    this.comando = new SqlCommand(query, this.conexion);
                    this.registros = comando.ExecuteReader();


                    registros.Close();
                    this.cerrar();
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    conexion.Close();
                }
            }
            else
            {
                MessageBox.Show("Error al conectar con la BBDD");
                throw new ConnectionException("No se pudo realizar la conexión");
            }

        }

        public List<List<string>> selectHorarios()
        {
            List<List<string>> menus = new List<List<string>>();

            if (this.abrir())
            {
                try
                {
                    string query = $"SELECT e.empleado_nombre, e.id_empleado, f.hora_entrada, f.hora_salida FROM Empleados e JOIN Fichajes f on e.id_empleado = f.id_empleado";

                    this.comando = new SqlCommand(query, this.conexion);
                    this.registros = comando.ExecuteReader();

                    while (registros.Read())
                    {
                        List<string> fila = new List<string>();
                        for (int i = 0; i < registros.FieldCount; i++)
                        {
                            fila.Add(registros.GetValue(i).ToString());
                        }
                        menus.Add(fila);

                    }
                    registros.Close();
                    this.cerrar();
                    return menus;
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    conexion.Close();
                    return null;
                }
            }
            else
            {
                MessageBox.Show("Error al conectar con la BBDD");
                throw new ConnectionException("No se pudo realizar la conexión");
            }
        }

        public void modificar_cantidad_stock(String ing, int n)
        {

            if (this.abrir())
            {
                try
                {
                    string query = $"UPDATE Stock SET stock_cantidad = CAST(stock_cantidad AS int) + {n} WHERE stock_nombre LIKE '{ing}'";

                    this.comando = new SqlCommand(query, this.conexion);
                    this.registros = comando.ExecuteReader();
                    registros.Close();
                    this.cerrar();
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    conexion.Close();
                }
            }
            else
            {
                MessageBox.Show("Error al conectar con la BBDD");
                throw new ConnectionException("No se pudo realizar la conexión");
            }

        }

        public int existeIng(string nombre)
        {

            int marca = -1;

            if (this.abrir())
            {
                try
                {
                    string query = $"SELECT COUNT(*) FROM Stock WHERE stock_nombre LIKE '{nombre}'";

                    this.comando = new SqlCommand(query, this.conexion);
                    this.registros = comando.ExecuteReader();

                    while (registros.Read())
                    {
                        for (int i = 0; i < registros.FieldCount; i++)
                        {
                            marca = int.Parse(registros.GetValue(i).ToString());
                        }


                    }
                    registros.Close();
                    this.cerrar();
                    return marca;
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    conexion.Close();
                    return -1;
                }
            }
            else
            {
                MessageBox.Show("Error al conectar con la BBDD");
                throw new ConnectionException("No se pudo realizar la conexión");
            }
        }
        public void modificar_Menu(String nuevoTitulo, String ing1, String ing2, String ing3, String descripcion, String precio, String id, String viejoTitulo)
        {

            if (this.abrir())
            {
                try
                {
                    string query = $"UPDATE Pizzas SET pizza_nombre = '{nuevoTitulo}', pizza_ingrediente1 = (SELECT id_ingrediente FROM Stock WHERE stock_nombre LIKE '{ing1}'), pizza_ingrediente2 = (SELECT id_ingrediente FROM Stock WHERE stock_nombre LIKE '{ing2}'), pizza_ingrediente3 = (SELECT id_ingrediente FROM Stock WHERE stock_nombre LIKE '{ing3}'), pizza_desc = '{descripcion}' WHERE pizza_nombre LIKE '{viejoTitulo}'";
                    this.comando = new SqlCommand(query, this.conexion);
                    this.registros = comando.ExecuteReader();
                    registros.Close();

                    string query2 = $"UPDATE Menu SET menu_precio = CAST('{precio}' AS NUMERIC(7,2)) WHERE id_pizza LIKE '{id}'";
                    this.comando = new SqlCommand(query2, this.conexion);
                    this.registros = comando.ExecuteReader();
                    registros.Close();

                    this.cerrar();
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    conexion.Close();
                }
            }
            else
            {
                MessageBox.Show("Error al conectar con la BBDD");
                throw new ConnectionException("No se pudo realizar la conexión");
            }
        }

        public List<List<string>> selectNotificaciones(String dni)
        {
            List<List<string>> notis = new List<List<string>>();

            if (this.abrir())
            {
                try
                {
                    string query = $"SELECT empleado_nombre, mensaje FROM Notificaciones n JOIN Empleados e on e.id_empleado = n.id_emisor WHERE id_remitente LIKE (SELECT id_empleado FROM Empleados WHERE empleado_dni LIKE '{dni}')";

                    this.comando = new SqlCommand(query, this.conexion);
                    this.registros = comando.ExecuteReader();

                    while (registros.Read())
                    {
                        List<string> fila = new List<string>();
                        for (int i = 0; i < registros.FieldCount; i++)
                        {
                            fila.Add(registros.GetValue(i).ToString());
                        }
                        notis.Add(fila);

                    }
                    registros.Close();
                    this.cerrar();
                    return notis;
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    conexion.Close();
                    return null;
                }
            }
            else
            {
                MessageBox.Show("Error al conectar con la BBDD");
                throw new ConnectionException("No se pudo realizar la conexión");
            }
        }
        public List<List<string>> selectGerentes()
        {
            List<List<string>> gerentes = new List<List<string>>();

            if (this.abrir())
            {
                try
                {
                    string query = $"SELECT empleado_nombre FROM Empleados WHERE empleado_tipo LIKE '2' OR empleado_tipo LIKE '3'";

                    this.comando = new SqlCommand(query, this.conexion);
                    this.registros = comando.ExecuteReader();

                    while (registros.Read())
                    {
                        List<string> fila = new List<string>();
                        for (int i = 0; i < registros.FieldCount; i++)
                        {
                            fila.Add(registros.GetValue(i).ToString());
                        }
                        gerentes.Add(fila);

                    }
                    registros.Close();
                    this.cerrar();
                    return gerentes;
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    conexion.Close();
                    return null;
                }
            }
            else
            {
                MessageBox.Show("Error al conectar con la BBDD");
                throw new ConnectionException("No se pudo realizar la conexión");
            }
        }

        public String selectIdDni(String dni)
        {
            String aux = "";

            if (this.abrir())
            {
                try
                {
                    string query = $"SELECT id_empleado FROM Empleados WHERE empleado_dni LIKE '{dni}'";

                    this.comando = new SqlCommand(query, this.conexion);
                    this.registros = comando.ExecuteReader();

                    while (registros.Read())
                    {
                        List<string> fila = new List<string>();
                        for (int i = 0; i < registros.FieldCount; i++)
                        {
                            fila.Add(registros.GetValue(i).ToString());
                        }
                        aux = fila[0];

                    }
                    registros.Close();
                    this.cerrar();
                    return aux;
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    conexion.Close();
                    return null;
                }
            }
            else
            {
                MessageBox.Show("Error al conectar con la BBDD");
                throw new ConnectionException("No se pudo realizar la conexión");
            }
        }

        public String selectIdStock(String nombre)
        {
            String aux = "";

            if (this.abrir())
            {
                try
                {
                    string query = $"SELECT id_ingrediente FROM Stock WHERE stock_nombre LIKE '{nombre}'";

                    this.comando = new SqlCommand(query, this.conexion);
                    this.registros = comando.ExecuteReader();

                    while (registros.Read())
                    {
                        List<string> fila = new List<string>();
                        for (int i = 0; i < registros.FieldCount; i++)
                        {
                            fila.Add(registros.GetValue(i).ToString());
                        }
                        aux = fila[0];

                    }
                    registros.Close();
                    this.cerrar();
                    return aux;
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    conexion.Close();
                    return null;
                }
            }
            else
            {
                MessageBox.Show("Error al conectar con la BBDD");
                throw new ConnectionException("No se pudo realizar la conexión");
            }
        }

        public String selectIdProveedor(String nombre)
        {
            String aux = "";

            if (this.abrir())
            {
                try
                {
                    string query = $"SELECT id_proveedor FROM Proveedores WHERE proveedor_nombre LIKE '{nombre}'";

                    this.comando = new SqlCommand(query, this.conexion);
                    this.registros = comando.ExecuteReader();

                    while (registros.Read())
                    {
                        List<string> fila = new List<string>();
                        for (int i = 0; i < registros.FieldCount; i++)
                        {
                            fila.Add(registros.GetValue(i).ToString());
                        }
                        aux = fila[0];

                    }
                    registros.Close();
                    this.cerrar();
                    return aux;
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    conexion.Close();
                    return null;
                }
            }
            else
            {
                MessageBox.Show("Error al conectar con la BBDD");
                throw new ConnectionException("No se pudo realizar la conexión");
            }
        }

        public String selectIdNombre(String nombre)
        {
            String aux = "";

            if (this.abrir())
            {
                try
                {
                    string query = $"SELECT id_empleado FROM Empleados WHERE empleado_nombre LIKE '{nombre}'";

                    this.comando = new SqlCommand(query, this.conexion);
                    this.registros = comando.ExecuteReader();

                    while (registros.Read())
                    {
                        List<string> fila = new List<string>();
                        for (int i = 0; i < registros.FieldCount; i++)
                        {
                            fila.Add(registros.GetValue(i).ToString());
                        }
                        aux = fila[0];

                    }
                    registros.Close();
                    this.cerrar();
                    return aux;
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    conexion.Close();
                    return null;
                }
            }
            else
            {
                MessageBox.Show("Error al conectar con la BBDD");
                throw new ConnectionException("No se pudo realizar la conexión");
            }
        }

        public void mandarNotificacion(String dni, String nombre, String mensaje)  
        {

            if (this.abrir())
            {
                try
                {
                    string query = $"INSERT INTO Notificaciones(id_emisor, id_remitente, mensaje) VALUES ('{dni}', '{nombre}', '{mensaje}')";
                    this.comando = new SqlCommand(query, this.conexion);
                    this.registros = comando.ExecuteReader();
                    registros.Close();

                    this.cerrar();
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    conexion.Close();
                }
            }
            else
            {
                MessageBox.Show("Error al conectar con la BBDD");
                throw new ConnectionException("No se pudo realizar la conexión");
            }
        }


        public void borrar_proveedor(String proveedor)
        {

            if (this.abrir())
            {
                try
                {
                    string query = $"DELETE FROM Proveedores WHERE proveedor_nombre LIKE '{proveedor}'";
                    this.comando = new SqlCommand(query, this.conexion);
                    this.registros = comando.ExecuteReader();
                    registros.Close();
                    this.cerrar();
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    conexion.Close();
                }
            }
            else
            {
                MessageBox.Show("Error al conectar con la BBDD");
                throw new ConnectionException("No se pudo realizar la conexión");
            }
        }

        public void borrar_proveedor_stock(String proveedor)
        {

            if (this.abrir())
            {
                try
                {
                    string query = $"UPDATE Stock SET id_proveedor = 0 WHERE id_proveedor = (SELECT id_proveedor FROM Proveedores WHERE proveedor_nombre LIKE '{proveedor}')";
                    this.comando = new SqlCommand(query, this.conexion);
                    this.registros = comando.ExecuteReader();
                    registros.Close();
                    this.cerrar();
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    conexion.Close();
                }
            }
            else
            {
                MessageBox.Show("Error al conectar con la BBDD");
                throw new ConnectionException("No se pudo realizar la conexión");
            }
        }

        public List<List<string>> selectProveedores()
        {
            List<List<string>> proveedores = new List<List<string>>();

            if (this.abrir())
            {
                try
                {
                    string query = $"SELECT * FROM Proveedores";

                    this.comando = new SqlCommand(query, this.conexion);
                    this.registros = comando.ExecuteReader();

                    while (registros.Read())
                    {
                        List<string> fila = new List<string>();
                        for (int i = 0; i < registros.FieldCount; i++)
                        {
                            fila.Add(registros.GetValue(i).ToString());
                        }
                        proveedores.Add(fila);

                    }
                    registros.Close();
                    this.cerrar();
                    return proveedores;
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    conexion.Close();
                    return null;
                }
            }
            else
            {
                MessageBox.Show("Error al conectar con la BBDD");
                throw new ConnectionException("No se pudo realizar la conexión");
            }
        }

        public void crearProveedor(String id, String nombre)
        {

            if (this.abrir())
            {
                try
                {
                    string query = $"INSERT INTO Proveedores (id_proveedor, proveedor_nombre) VALUES ('{id}', '{nombre}')";
                    this.comando = new SqlCommand(query, this.conexion);
                    this.registros = comando.ExecuteReader();
                    registros.Close();

                    this.cerrar();
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    conexion.Close();
                }
            }
            else
            {
                MessageBox.Show("Error al conectar con la BBDD");
                throw new ConnectionException("No se pudo realizar la conexión");
            }
        }

        public int max_tabla(String name_tabla)
        {
            List<String> ids = new List<String>();
            if (this.abrir())
            {
                try
                {
                    string query = $"SELECT * FROM {name_tabla}";

                    this.comando = new SqlCommand(query, this.conexion);
                    this.registros = comando.ExecuteReader();

                    while (registros.Read())
                    {
                        for (int i = 0; i < registros.FieldCount; i++)
                        {
                            ids.Add(registros.GetValue(0).ToString());
                        }

                    }

                    int max_id = ids.Max(c => int.Parse(c));
                    registros.Close();
                    this.cerrar();
                    return max_id;
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    conexion.Close();
                    return -1;
                }
            }
            else
            {
                MessageBox.Show("Error al conectar con la BBDD");
                throw new ConnectionException("No se pudo realizar la conexión");
            }
        }
        public int addMenu(String ID, String precio)
        {
            if (this.abrir())
            {
                string query = $"INSERT INTO Menu (id_menu, menu_precio, id_pizza, id_entrante, id_refresco) VALUES ('{ID}',CAST('{precio}' AS NUMERIC(7,2)),'{ID}', '1', '1')";
                try
                {
                    this.comando = new SqlCommand(query, this.conexion);
                    int registros = comando.ExecuteNonQuery();
                    this.cerrar();
                    return registros;
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    conexion.Close();
                    return -1;
                }
            }
            else
            {
                MessageBox.Show("Error al conectar con la BBDD");
                throw new ConnectionException("No se pudo realizar la conexión");
            }
        }

        public String devuelveNumeroIngredienteStock(String ing)
        {

            String tipo = "";

            if (this.abrir())
            {
                try
                {
                    string query = $"SELECT id_ingrediente FROM Stock WHERE stock_nombre LIKE '{ing}'";

                    this.comando = new SqlCommand(query, this.conexion);
                    this.registros = comando.ExecuteReader();

                    while (registros.Read())
                    {
                        List<string> fila = new List<string>();
                        for (int i = 0; i < registros.FieldCount; i++)
                        {
                            tipo = (registros.GetValue(i).ToString());
                        }


                    }
                    registros.Close();
                    this.cerrar();
                    return tipo;
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    conexion.Close();
                    return null;
                }
            }
            else
            {
                MessageBox.Show("Error al conectar con la BBDD");
                throw new ConnectionException("No se pudo realizar la conexión");
            }
        }

        public int addPizza(String titulo, String ing1, String ing2, String ing3, String pizzaDesc, String ID)
        {

            if (this.abrir())
            {
                string query = $"INSERT INTO Pizzas (id_pizzas, pizza_ingrediente1, pizza_ingrediente2, pizza_ingrediente3 ,pizza_nombre , pizza_desc) VALUES ('{ID}','{ing1}','{ing2}','{ing3}','{titulo}','{pizzaDesc}')";

                try
                {
                    this.comando = new SqlCommand(query, this.conexion);
                    int registros = comando.ExecuteNonQuery();
                    this.cerrar();
                    return registros;
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    conexion.Close();
                    return -1;
                }
            }
            else
            {
                MessageBox.Show("Error al conectar con la BBDD");
                throw new ConnectionException("No se pudo realizar la conexión");
            }
        }

        public void eliminarMenu(String idMenu, string precio, String idPizza, String idEntrante, String idRefresco, String viejoId)
        {

            if (this.abrir())
            {
                try
                {

                    string query = $"INSERT INTO Menu (id_menu, menu_precio, id_pizza, id_entrante, id_refresco) VALUES ('{idMenu}', CAST('{precio.Replace(',', '.')}' AS NUMERIC(7,2)), '{idPizza}', '{idEntrante}', '{idRefresco}')";
                    this.comando = new SqlCommand(query, this.conexion);
                    this.registros = comando.ExecuteReader();
                    registros.Close();


                    string query2 = $"UPDATE Pedidos SET id_menu = '{idMenu}' WHERE id_pedido IN (SELECT id_pedido FROM Pedidos WHERE id_menu = '{viejoId}')";
                    this.comando = new SqlCommand(query2, this.conexion);
                    this.registros = comando.ExecuteReader();
                    registros.Close();


                    string query3 = $"DELETE FROM Menu WHERE id_menu = '{viejoId}'";
                    this.comando = new SqlCommand(query3, this.conexion);
                    this.registros = comando.ExecuteReader();
                    registros.Close();

                    this.cerrar();

                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    conexion.Close();
                }
            }
            else
            {
                MessageBox.Show("Error al conectar con la BBDD");
                throw new ConnectionException("No se pudo realizar la conexión");
            }
        }

        public void eliminarPizza(String idPizza, String ing1, String ing2, String ing3, String nombre, String desc, String viejoId, String idMenu)
        {

            if (this.abrir())
            {
                try
                {

                    string query = $"INSERT INTO Pizzas (id_pizzas, pizza_ingrediente1, pizza_ingrediente2, pizza_ingrediente3, pizza_nombre, pizza_desc) VALUES('{idPizza}', '{ing1}', '{ing2}', '{ing3}', '{nombre}', '{desc}')";
                    this.comando = new SqlCommand(query, this.conexion);
                    this.registros = comando.ExecuteReader();
                    registros.Close();

                    string query4 = $"UPDATE Menu SET id_pizza = '{idPizza}' WHERE id_menu = '{idMenu}'";
                    this.comando = new SqlCommand(query4, this.conexion);
                    this.registros = comando.ExecuteReader();
                    registros.Close();

                    string query3 = $"DELETE FROM Pizzas WHERE id_pizzas = '{viejoId}'";
                    this.comando = new SqlCommand(query3, this.conexion);
                    this.registros = comando.ExecuteReader();
                    registros.Close();

                    this.cerrar();

                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    conexion.Close();
                }
            }
            else
            {
                MessageBox.Show("Error al conectar con la BBDD");
                throw new ConnectionException("No se pudo realizar la conexión");
            }
        }

        public List<List<string>> selectDatosBorrarMenu(string id)
        {
            List<List<string>> pedidos = new List<List<string>>();

            if (this.abrir())
            {
                try
                {
                    string query = $"SELECT id_pizza, id_entrante, id_refresco FROM Menu WHERE id_menu LIKE '{id}'";

                    this.comando = new SqlCommand(query, this.conexion);
                    this.registros = comando.ExecuteReader();

                    while (registros.Read())
                    {
                        List<string> fila = new List<string>();
                        for (int i = 0; i < registros.FieldCount; i++)
                        {
                            fila.Add(registros.GetValue(i).ToString());
                        }
                        pedidos.Add(fila);

                    }
                    registros.Close();
                    this.cerrar();
                    return pedidos;
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    conexion.Close();
                    return null;
                }
            }
            else
            {
                MessageBox.Show("Error al conectar con la BBDD");
                throw new ConnectionException("No se pudo realizar la conexión");
            }
        }

        public void crearIngrediente(String id, String nombre, String cantidad, String idP)
        {

            if (this.abrir())
            {
                try
                {
                    string query = $"INSERT INTO Stock (id_ingrediente, stock_nombre, stock_cantidad, id_proveedor) VALUES ('{id}', '{nombre}', '{cantidad}', '{idP}')";
                    this.comando = new SqlCommand(query, this.conexion);
                    this.registros = comando.ExecuteReader();
                    registros.Close();

                    this.cerrar();
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    conexion.Close();
                }
            }
            else
            {
                MessageBox.Show("Error al conectar con la BBDD");
                throw new ConnectionException("No se pudo realizar la conexión");
            }
        }

        public void modificarStockAdmin(String nombre, String cantidad, String idProveedor, String id)
        {

            if (this.abrir())
            {
                try
                {


                    string query = $"UPDATE Stock SET stock_nombre = '{nombre}', stock_cantidad = '{cantidad}', id_proveedor = '{idProveedor}' WHERE id_ingrediente LIKE '{id}'";
                    this.comando = new SqlCommand(query, this.conexion);
                    this.registros = comando.ExecuteReader();
                    registros.Close();


                    this.cerrar();

                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    conexion.Close();
                }
            }
            else
            {
                MessageBox.Show("Error al conectar con la BBDD");
                throw new ConnectionException("No se pudo realizar la conexión");
            }
        }


        public void borrar_pedido(String id_pedido)
        {

            if (this.abrir())
            {
                try
                {
                    string query = $"DELETE FROM Pedidos WHERE id_pedido = {id_pedido}";
                    this.comando = new SqlCommand(query, this.conexion);
                    this.registros = comando.ExecuteReader();
                    registros.Close();

                    this.cerrar();
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    conexion.Close();
                }
            }
            else
            {
                MessageBox.Show("Error al conectar con la BBDD");
                throw new ConnectionException("No se pudo realizar la conexión");
            }
        }


        public int addPedido(List<string> campos)
        {
            int id_max = max_tabla("Pedidos");
            int id_pizza = selectId("id_pizzas", "Pizzas", "pizza_nombre", campos[0]);
            int id_empleado = selectId("id_empleado", "Empleados", "empleado_nombre", campos[2]);
            int id_tienda = selectId("id_tienda", "Tiendas", "tienda_nombre", campos[3]);
            int id_cliente = selectId("id_cliente", "Clientes", "cliente_nombre", campos[1]);

            string precio_pedido = select_precio_pizza(campos[0]);
            precio_pedido = precio_pedido.Replace(",", ".");

            if (id_pizza == -1 || id_empleado == -1 || id_tienda == -1 || id_cliente == -1)
            {
                return -2;
            }




            if (this.abrir())
            {
                try
                {
                    // fer :(
                    string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");


                    string query = $"INSERT INTO Pedidos(id_pedido,id_menu,id_empleado,id_tienda,id_cliente,pedido_precio,pedido_fecha) VALUES ('{id_max + 1}','{id_pizza}','{id_empleado}','{id_tienda}','{id_cliente}','{precio_pedido}', '{date}');";
                    try
                    {
                        this.comando = new SqlCommand(query, this.conexion);
                        int registros = comando.ExecuteNonQuery();
                        return registros;
                    }
                    catch (SqlException e)
                    {
                        Console.WriteLine(e.Message);
                        conexion.Close();
                        return -1;
                    }
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    conexion.Close();
                    return -1;
                }
            }
            else
            {
                MessageBox.Show("Error al conectar con la BBDD");
                throw new ConnectionException("No se pudo realizar la conexión");
            }
        }

        public int selectId(string id, string tabla, string t_nombre, string i_nombre)
        {

            int marca = -1;

            if (this.abrir())
            {
                try
                {
                    string query = $"SELECT {id} FROM {tabla} WHERE {t_nombre} LIKE '{i_nombre}'";

                    this.comando = new SqlCommand(query, this.conexion);
                    this.registros = comando.ExecuteReader();

                    while (registros.Read())
                    {
                        for (int i = 0; i < registros.FieldCount; i++)
                        {
                            marca = int.Parse(registros.GetValue(i).ToString());
                        }


                    }
                    registros.Close();
                    this.cerrar();
                    return marca;
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    conexion.Close();
                    return -1;
                }
            }
            else
            {
                MessageBox.Show("Error al conectar con la BBDD");
                throw new ConnectionException("No se pudo realizar la conexión");
            }
        }

        public string select_precio_pizza(string pizza_nombre)
        {

            string marca = "-1";

            if (this.abrir())
            {
                try
                {
                    string query = $"SELECT me.menu_precio FROM Menu me JOIN Pizzas pi on me.id_pizza = pi.id_pizzas WHERE pi.pizza_nombre LIKE '{pizza_nombre}'";

                    this.comando = new SqlCommand(query, this.conexion);
                    this.registros = comando.ExecuteReader();

                    while (registros.Read())
                    {
                        for (int i = 0; i < registros.FieldCount; i++)
                        {

                            marca = registros.GetValue(i).ToString();
                        }


                    }
                    registros.Close();
                    this.cerrar();
                    return marca;
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    conexion.Close();
                    return "-1";
                }
            }
            else
            {
                MessageBox.Show("Error al conectar con la BBDD");
                throw new ConnectionException("No se pudo realizar la conexión");
            }
        }

        public List<string> buscar_empleado(String empleado)
        {
            if (this.abrir())
            {
                try
                {
                    string query = $"SELECT * FROM Empleados WHERE id_empleado LIKE '{empleado}'";
                    this.comando = new SqlCommand(query, this.conexion);
                    this.registros = comando.ExecuteReader();

                    List<string> fila = new List<string>();

                    while (registros.Read())
                    {

                        for (int i = 0; i < registros.FieldCount; i++)
                        {
                            fila.Add(registros.GetValue(i).ToString());
                        }

                    }

                    registros.Close();
                    this.cerrar();
                    return fila;
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    conexion.Close();
                    return null;
                }
            }
            else
            {
                MessageBox.Show("Error al conectar con la BBDD");
                throw new ConnectionException("No se pudo realizar la conexión");
            }
        }

        public void insertar_empleado(String id_empleado, String empleado_password, String empleado_nombre, String empleado_apellidos, String empleado_dni, String empleado_fecha_nac, String id_tienda, String empleado_tipo, String empleado_salario, String empleado_bloqueado)
        {
            if (this.abrir())
            {
                try
                {

                    // QUIEN TOQUE ESTA FUNCION NO VA A VIVIR
                    // NO SABEMOS NI COMO FUNCIONA

                    String[] aux = empleado_fecha_nac.Split(' ')[0].Split('/');
                    String aux2 = aux[2] + "-" + aux[1] + "-" + aux[0];
                    int aux3 = int.Parse(empleado_bloqueado);
                    char aux4 = char.Parse(empleado_tipo);
                    string aux5 = empleado_salario.Replace(',', '.');
                    string date = DateTime.Now.ToString(aux[2] + "-" + aux[1] + "-" + aux[0] + " 00:00:00");
                    string query = $"INSERT INTO Empleados (id_empleado, empleado_password, empleado_nombre, empleado_apellidos, empleado_dni, empleado_fecha_nac, id_tienda, empleado_tipo, empleado_salario, empleado_bloqueado) VALUES ('{id_empleado}' , '{empleado_password}' , '{empleado_nombre}' , '{empleado_apellidos}' , '{empleado_dni}', '{date}' , '{id_tienda}' , '{aux4}' ,CAST('{aux5}' AS NUMERIC(7,2)) , '{aux3}')";
                    this.comando = new SqlCommand(query, this.conexion);
                    this.registros = comando.ExecuteReader();
                    registros.Close();
                    this.cerrar();
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    conexion.Close();
                }

            }
            else
            {
                MessageBox.Show("Error al conectar con la BBDD");
                throw new ConnectionException("No se pudo realizar la conexión");
            }
        }

        public void actualizar_empleado(string viejo, string nuevo)
        {
            if (this.abrir())
            {
                try
                {
                    string query1 = $"UPDATE Fichajes SET id_empleado = '{nuevo}' WHERE id_empleado = '{viejo}'";
                    this.comando = new SqlCommand(query1, this.conexion);
                    this.registros = comando.ExecuteReader();
                    registros.Close();

                    string query2 = $"UPDATE Pedidos SET id_empleado = '{nuevo}' WHERE id_empleado = '{viejo}'";
                    this.comando = new SqlCommand(query2, this.conexion);
                    this.registros = comando.ExecuteReader();
                    registros.Close();

                    string query3 = $"UPDATE Notificaciones SET id_emisor = '{nuevo}' WHERE id_emisor = '{viejo}'";
                    this.comando = new SqlCommand(query3, this.conexion);
                    this.registros = comando.ExecuteReader();
                    registros.Close();

                    string query4 = $"UPDATE Notificaciones SET id_remitente = '{nuevo}' WHERE id_remitente = '{viejo}'";
                    this.comando = new SqlCommand(query4, this.conexion);
                    this.registros = comando.ExecuteReader();
                    registros.Close();

                    this.cerrar();
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    conexion.Close();
                }
            }
            else
            {
                MessageBox.Show("Error al conectar con la BBDD");
                throw new ConnectionException("No se pudo realizar la conexión");
            }
        }

        public void borrar_empleado(string empleado)
        {
            if (this.abrir())
            {
                try
                {
                    string query = $"DELETE Empleados WHERE id_empleado LIKE '{empleado}'";
                    this.comando = new SqlCommand(query, this.conexion);
                    this.registros = comando.ExecuteReader();
                    registros.Close();
                    this.cerrar();
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    conexion.Close();
                }
            }
            else
            {
                MessageBox.Show("Error al conectar con la BBDD");
                throw new ConnectionException("No se pudo realizar la conexión");
            }
        }

        public List<List<string>> selectEmpleados()
        {
            List<List<string>> empleados = new List<List<string>>();

            if (this.abrir())
            {
                try
                {
                    string query = $"SELECT * FROM Empleados";

                    this.comando = new SqlCommand(query, this.conexion);
                    this.registros = comando.ExecuteReader();

                    while (registros.Read())
                    {
                        List<string> fila = new List<string>();
                        for (int i = 0; i < registros.FieldCount; i++)
                        {
                            fila.Add(registros.GetValue(i).ToString());
                        }
                        empleados.Add(fila);

                    }

                    registros.Close();
                    this.cerrar();
                    return empleados;

                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    conexion.Close();
                    return null;
                }

            }
            else
            {
                MessageBox.Show("Error al conectar con la BBDD");
                throw new ConnectionException("No se pudo realizar la conexión");
            }
        }

        public List<List<string>> selectNominas()
        {
            List<List<string>> pedidos = new List<List<string>>();

            if (this.abrir())
            {
                try
                {
                    string query = $"SELECT empleado_nombre, id_empleado, empleado_salario FROM Empleados";

                    this.comando = new SqlCommand(query, this.conexion);
                    this.registros = comando.ExecuteReader();

                    while (registros.Read())
                    {
                        List<string> fila = new List<string>();
                        for (int i = 0; i < registros.FieldCount; i++)
                        {
                            fila.Add(registros.GetValue(i).ToString());
                        }
                        pedidos.Add(fila);

                    }
                    registros.Close();
                    this.cerrar();
                    return pedidos;
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    conexion.Close();
                    return null;
                }
            }
            else
            {
                MessageBox.Show("Error al conectar con la BBDD");
                throw new ConnectionException("No se pudo realizar la conexión");
            }
        }

        public void updateNomina(String id, String cantidad)
        {

            if (this.abrir())
            {
                try
                {

                    

                    string query = $"UPDATE Empleados SET empleado_salario = CAST('{cantidad}' AS DECIMAL(7,2)) WHERE id_empleado = '{id}'";
                    this.comando = new SqlCommand(query, this.conexion);
                    this.registros = comando.ExecuteReader();
                    registros.Close();

                    this.cerrar();

                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    conexion.Close();
                }
            }
            else
            {
                MessageBox.Show("Error al conectar con la BBDD");
                throw new ConnectionException("No se pudo realizar la conexión");
            }
        }


        public void insertar_fichaje(String id, String id_empleado, String entrada, String salida)
        {
            if (this.abrir())
            {
                try
                {

                    string query = $"INSERT INTO Fichajes (id_fichaje, id_empleado, hora_entrada, hora_salida) VALUES ('{id}', '{id_empleado}', '{entrada}', '{salida}')";
                    this.comando = new SqlCommand(query, this.conexion);
                    this.registros = comando.ExecuteReader();
                    registros.Close();
                    this.cerrar();
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    conexion.Close();
                }

            }
            else
            {
                MessageBox.Show("Error al conectar con la BBDD");
                throw new ConnectionException("No se pudo realizar la conexión");
            }
        }

        public String selectIdTienda(String nombre)
        {
            String aux = "";

            if (this.abrir())
            {
                try
                {
                    string query = $"SELECT id_tienda FROM Tiendas WHERE tienda_nombre LIKE '{nombre}'";

                    this.comando = new SqlCommand(query, this.conexion);
                    this.registros = comando.ExecuteReader();

                    while (registros.Read())
                    {
                        List<string> fila = new List<string>();
                        for (int i = 0; i < registros.FieldCount; i++)
                        {
                            fila.Add(registros.GetValue(i).ToString());
                        }
                        aux = fila[0];

                    }
                    registros.Close();
                    this.cerrar();
                    return aux;
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    conexion.Close();
                    return null;
                }
            }
            else
            {
                MessageBox.Show("Error al conectar con la BBDD");
                throw new ConnectionException("No se pudo realizar la conexión");
            }
        }

        public int modificarEntrada(String entrada, String id)
        {
            if (this.abrir())
            {
                try
                {
                    string query = $"UPDATE Fichajes SET hora_entrada = '{entrada}' WHERE id_empleado LIKE '{id}'";

                    this.comando = new SqlCommand(query, this.conexion);
                    this.registros = comando.ExecuteReader();


                    registros.Close();
                    this.cerrar();
                    return 1;
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    conexion.Close();
                    return -1;
                }
            }
            else
            {
                MessageBox.Show("Error al conectar con la BBDD");
                throw new ConnectionException("No se pudo realizar la conexión");
            }
        }

        public int modificarSalida(String salida, String id)
        {
            if (this.abrir())
            {
                try
                {
                    string query = $"UPDATE Fichajes SET hora_salida = '{salida}' WHERE id_empleado LIKE '{id}'";

                    this.comando = new SqlCommand(query, this.conexion);
                    this.registros = comando.ExecuteReader();


                    registros.Close();
                    this.cerrar();
                    return 1;
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    conexion.Close();
                    return -1;
                }
            }
            else
            {
                MessageBox.Show("Error al conectar con la BBDD");
                throw new ConnectionException("No se pudo realizar la conexión");
            }
        }


    }




}

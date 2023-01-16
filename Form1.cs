using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Giovannis.Modelos;
using Giovannis.Modelos.Menu.Gerente;
using Giovannis.Modelos.Menu;
using Giovannis.Modelos.Botoneras.Gerente;
using Giovannis.Modelos.Clases;
using Giovannis.Modelos.Provedores.Gerente;
using Giovannis.Modelos.Provedores.Administrador;
using Giovannis.Modelos.Pedidos.Gerente;
using Giovannis.Modelos.Pedidos.Administrador;
using Giovannis.Modelos.Stock.Gerente;
using Giovannis.Modelos.Stock.Administrador;
using Giovannis.Modelos.Notificaciones.Administrador;
using Giovannis.Modelos.Promociones.Administrador;
using Giovannis.Modelos.Botoneras.Administrador;
using Giovannis.Modelos.Menu.Administrador;
using Giovannis.Modelos.Empleados;
using Giovannis.Modelos.Horarios.Adminstrador;
using Giovannis.Modelos.Empleados.Administrador;
using Giovannis.Modelos.Nominas;
using Giovannis.Modelos.BBDD;

namespace Giovannis
{
    public partial class Form1 : Form
    {

        private String _dni;
        private DateTime _fecha_log;

        public string Dni { get => _dni; set => _dni = value; }
        public DateTime Fecha_log { get => _fecha_log; set => _fecha_log = value; }

        public Form1()
        {
            InitializeComponent();
            Form1 f1 = (Form1)this.FindForm();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            panel_login_inicial.Controls.Add(new Login());

            Promocion.cargar_promociones().ToString();
            this.WindowState = FormWindowState.Maximized;
        }

        public void load_panel(UserControl u) {

            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(u);
        
        }

        public void gerente_cambiar_botonera(UserControl u) {

            this.pnl_botoneras.Controls.Clear();
            this.pnl_botoneras.Controls.Add(u);
             
        }

        public void deslogearse()
        {

           this.pnl_botoneras.Controls.Clear();
           this.panel1.Controls.Clear();
           this.panel1.Controls.Add(new Login());

        }

        public void iniciar_sesion(int tipo, String usuario) {

            this._dni = usuario;


            switch (tipo) {

                case 1:
                    this.panel1.Controls.Clear();
                    this.panel1.Controls.Add(new Menus());
                    this.pnl_botoneras.Controls.Clear();
                    this.pnl_botoneras.Controls.Add(new botonera());
                    
                    break;

                case 2:
                    this.panel1.Controls.Clear();
                    this.panel1.Controls.Add(new Menus_gerente());
                    this.pnl_botoneras.Controls.Clear();
                    this.pnl_botoneras.Controls.Add(new botonera_gerente());
                    break;
                case 3:
                    this.panel1.Controls.Clear();
                    this.panel1.Controls.Add(new Menu_admin());
                    this.pnl_botoneras.Controls.Clear();
                    this.pnl_botoneras.Controls.Add(new botonera_administrador());
                    break;

            }
            
        }

        public void cargar_modificar_proveedor() {

            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(new proveedores_gerente());
        }

        public void cargar_modificar_pedidos()
        {

            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(new pedidos_gerente());
        }

        public void cargar_modificar_pedidos_admin()
        {

            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(new Pedidos_admin());
        }

        public void cargar_modificar_stock() {
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(new stock_gerente());
        }

        public void cargar_modificarPanel_stock_administrador(String nombre, String id, String cantidad)
        {
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(new stock_modificar_administrador(nombre, id,  cantidad));
        }

        public void cargar_modificar_stock_administrador()
        {
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(new stock_administrador());
        }

        public void cargar_modificar_stock_add_administrador()
        {
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(new stock_add_administrador());
        }

        public void cargar_modificar_menus()
        {
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(new Menus_gerente());
        }
        public void cargar_modificar_notificaciones()
        {
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(new notificaciones());
        }

        public void cargar_modificar_notificaciones_admin()
        {
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(new notificaciones_administrador());
        }

        public void cargar_modificar_proveedor_admin()
        {
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(new proveedores_administrador());
        }

        public void cargar_crear_proveedor()
        {
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(new proveedor_administrador_add());
        }

        public void cargar_modificar_promociones_administrador()
        {
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(new promociones_administrador());
        }

        public void cargar_modificar_menus_administrador()
        {
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(new Menu_add());
        }

        public void cargar_empleados_administrador()
        {
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(new empleados_administrador());
        }

        public void cargar_nominas_administrador()
        {
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(new nominas());
        }

        public void fichar() {

            DateTime fecha_exit = DateTime.Now;

            Consultas consulta = new Consultas();

            String id = consulta.selectIdDni(this.Dni);

            String[] aux = this.Fecha_log.ToString().Split(' ');

            String[] fecha = aux[0].Split('/');

            String fh1 = fecha[2] + "-" + fecha[1] + "-" + fecha[0] + " " + aux[1];

            aux = fecha_exit.ToString().Split(' ');
            fecha = aux[0].Split('/');

            String fh2 = fecha[2] + "-" + fecha[1] + "-" + fecha[0] + " " + aux[1];

            consulta.insertar_fichaje((consulta.max_tabla("Fichajes") + 1).ToString(), id, fh1, fh2);

        }

    }
}

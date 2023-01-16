using Giovannis.Modelos.BBDD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giovannis.Modelos.Pedidos.Administrador
{
    public partial class Pedidos_panel_admin : UserControl
    {
        private string _idPedido;
        private string _fechaPedido;
        private string _tienda;
        private string _empleado;
        private string _cliente;
        private string _nomMenu;
        private string _precio;
        public Pedidos_panel_admin()
        {
            InitializeComponent();
            _idPedido = "";
            _fechaPedido = "";
            _tienda = "";
            _empleado = "";
            _cliente = "";
            _nomMenu = "";
            _precio = "";
        }
        public string IdPedido
        {
            get { return _idPedido; }
            set { _idPedido = value; lbl_id_pedido.Text = value; }
        }

        public string FechaPedido
        {
            get { return _fechaPedido; }
            set { _fechaPedido = value; lbl_fecha.Text = value; }
        }
        public string Tienda
        {
            get { return _tienda; }
            set { _tienda = value; lbl_tienda.Text = value; }
        }
        public string Empleado
        {
            get { return _empleado; }
            set { _empleado = value; lbl_empleado.Text = value; }
        }
        public string Cliente
        {
            get { return _cliente; }
            set { _cliente = value; lbl_cliente.Text = value; }
        }
        public string NomMenu
        {
            get { return _nomMenu; }
            set { _nomMenu = value; lbl_nombre_menu.Text = value; }
        }
        public string Precio
        {
            get { return _precio; }
            set { _precio = value; lbl_precio.Text = value; }
        }

        private void bttnDelete_Click(object sender, EventArgs e)
        {
            Form1 f1 = (Form1)this.FindForm();
            Consultas c = new Consultas();
            c.borrar_pedido(this.IdPedido.Split(':')[1].Trim());
            f1.cargar_modificar_pedidos_admin();
            
        }

        private void Pedidos_panel_admin_Load(object sender, EventArgs e)
        {

        }

        private void editar_Click(object sender, EventArgs e)
        {
            Consultas c = new Consultas();
            Form1 f1 = (Form1)this.FindForm();
            String nuevo = "";
            int aux = 0;

            while (aux == 0)
            {

                nuevo = Microsoft.VisualBasic.Interaction.InputBox("Introduce el NUEVO nombre del menú", "Menús", this.NomMenu.Split(':')[1].Trim());
                aux = c.existePizza(nuevo);

                if (aux == 0)
                {
                    MessageBox.Show("OJO PIOJO, NO EXISTE NINGUNA PIZZA CON ESE NOMBRE");
                }

            }

            c.modificar_pedido(nuevo, this.IdPedido.Split(':')[1].Trim());

            f1.cargar_modificar_pedidos_admin();
        }
    }
}

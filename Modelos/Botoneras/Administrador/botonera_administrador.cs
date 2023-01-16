using Giovannis.Modelos.Botoneras.Gerente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giovannis.Modelos.Botoneras.Administrador
{
    public partial class botonera_administrador : UserControl
    {
        public botonera_administrador()
        {
            InitializeComponent();
        }

        private void bto_1_Click(object sender, EventArgs e)
        {
            string variable = bto_1.Text;
            Form1 f1 = (Form1)this.FindForm();

            if (variable == "Menús")
            {
                bto_1.Text = "Pedidos";
                bto_2.Text = "Promociones";
                bto_3.Text = "Stock";
                bto_4.Text = "Proveedores";
                f1.load_panel(new Menu.Administrador.Menu_admin());
            }
            else
            {
                bto_1.Text = "Menús";
                bto_2.Text = "Promociones";
                bto_3.Text = "Stock";
                bto_4.Text = "Proveedores";
                f1.load_panel(new Pedidos.Administrador.Pedidos_admin());
            }
        }

        private void bto_2_Click(object sender, EventArgs e)
        {
            string variable = bto_2.Text;
            Form1 f1 = (Form1)this.FindForm();

            if (variable == "Promociones")
            {
                bto_1.Text = "Menús";
                bto_2.Text = "Pedidos";
                bto_3.Text = "Stock";
                bto_4.Text = "Proveedores";
                f1.load_panel(new Promociones.Administrador.promociones_administrador());

            }
            else
            {
                bto_1.Text = "Menús";
                bto_2.Text = "Promociones";
                bto_3.Text = "Stock";
                bto_4.Text = "Proveedores";
                f1.load_panel(new Pedidos.Administrador.Pedidos_admin());
            }
        }

        private void bto_3_Click(object sender, EventArgs e)
        {
            string variable = bto_3.Text;
            Form1 f1 = (Form1)this.FindForm();

            if (variable == "Promociones")
            {
                bto_1.Text = "Menús";
                bto_2.Text = "Pedidos";
                bto_3.Text = "Stock";
                bto_4.Text = "Proveedores";
                f1.load_panel(new Promociones.Administrador.promociones_administrador());

            }
            else
            {
                bto_1.Text = "Menús";
                bto_2.Text = "Pedidos";
                bto_3.Text = "Promociones";
                bto_4.Text = "Proveedores";
                f1.load_panel(new Stock.Administrador.stock_administrador());
            }
        }

        private void bto_4_Click(object sender, EventArgs e)
        {
            string variable = bto_4.Text;
            Form1 f1 = (Form1)this.FindForm();

            if (variable == "Stock")
            {
                bto_1.Text = "Menús";
                bto_2.Text = "Pedidos";
                bto_3.Text = "Promociones";
                bto_4.Text = "Proveedores";
                f1.load_panel(new Stock.Administrador.stock_administrador());

            }
            else
            {
                bto_1.Text = "Menús";
                bto_2.Text = "Pedidos";
                bto_3.Text = "Promociones";
                bto_4.Text = "Stock";
                f1.load_panel(new Provedores.Administrador.proveedores_administrador());
            }
        }

        private void img_cambio_Click(object sender, EventArgs e)
        {
            Form1 f1 = (Form1)this.FindForm();
            f1.gerente_cambiar_botonera(new botonera_administrador2());
            f1.load_panel(new Horarios.Adminstrador.HorarioAdmin());
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            Form1 f1 = (Form1)this.FindForm();
            f1.deslogearse();
            f1.fichar();
        }
    }
}

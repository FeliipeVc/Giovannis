using Giovannis.Modelos.Notificaciones.Administrador;
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
    public partial class botonera_administrador2 : UserControl
    {
        public botonera_administrador2()
        {
            InitializeComponent();
        }

        private void bto_1_Click(object sender, EventArgs e)
        {
            string variable = bto_1.Text;
            Form1 f1 = (Form1)this.FindForm();

            if (variable == "Horarios")
            {
                bto_1.Text = "Notificaciones";
                bto_2.Text = "Empleados";
                bto_3.Text = "Nominas";
                f1.load_panel(new Horarios.Adminstrador.HorarioAdmin());

            }
            else
            {
                bto_1.Text = "Horarios";
                bto_2.Text = "Empleados";
                bto_3.Text = "Nominas";
                f1.load_panel(new notificaciones_administrador());
            }
        }

        private void bto_2_Click(object sender, EventArgs e)
        {
            string variable = bto_2.Text;
            Form1 f1 = (Form1)this.FindForm();

            if (variable == "Empleados")
            {
                bto_1.Text = "Notificaciones";
                bto_2.Text = "Horarios";
                bto_3.Text = "Nominas";
                f1.load_panel(new Empleados.Administrador.empleados_administrador());

            }
            else
            {
                bto_1.Text = "Notificaciones";
                bto_2.Text = "Empleados";
                bto_3.Text = "Nominas";
                f1.load_panel(new Horarios.Adminstrador.HorarioAdmin());
            }
        }

        private void bto_3_Click(object sender, EventArgs e)
        {
            string variable = bto_3.Text;
            Form1 f1 = (Form1)this.FindForm();

            if (variable == "Nominas")
            {
                bto_1.Text = "Notificaciones";
                bto_2.Text = "Horarios";
                bto_3.Text = "Empleados";
                f1.load_panel(new Nominas.nominas());

            }
            else
            {
                bto_1.Text = "Notificaciones";
                bto_2.Text = "Horarios";
                bto_3.Text = "Nominas";
                f1.load_panel(new notificaciones_administrador());
            }
        }

        private void img_cambio_Click(object sender, EventArgs e)
        {
            Form1 f1 = (Form1)this.FindForm();
            f1.gerente_cambiar_botonera(new botonera_administrador());
            f1.load_panel(new Menu.Administrador.Menu_admin());
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            Form1 f1 = (Form1)this.FindForm();
            f1.deslogearse();
            f1.fichar();
        }
    }
}

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

namespace Giovannis.Modelos.Provedores.Administrador
{
    public partial class proveedor_administrador : UserControl
    {

        private String _nombre;

        public proveedor_administrador()
        {
            InitializeComponent();
        }

        public proveedor_administrador(string nombre)
        {
            _nombre = nombre;
        }
        public string Nombre
        {

            get
            {

                return _nombre;

            }

            set
            {

                _nombre = value; lbl_nombre.Text = value;

            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Consultas c = new Consultas();
            Form1 f1 = (Form1)this.FindForm();

            c.borrar_proveedor_stock(this.Nombre);
            c.borrar_proveedor(this.Nombre);
            f1.cargar_modificar_proveedor_admin();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Consultas c = new Consultas();
            Form1 f1 = (Form1)this.FindForm();

            string a = Microsoft.VisualBasic.Interaction.InputBox("Introduce el NUEVO nombre del proveedor", "Proveedor", this.Nombre);
            c.modificar_proveedor(this.Nombre, a);
            f1.cargar_modificar_proveedor_admin();
        }
    }
}

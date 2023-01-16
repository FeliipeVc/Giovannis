using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Giovannis.Modelos.BBDD;

namespace Giovannis.Modelos.Provedores.Gerente
{
    public partial class proveedor_gerente : UserControl
    {

        private string _nombre;

        public proveedor_gerente()
        {
            InitializeComponent();
            this._nombre = "";
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            Consultas c = new Consultas();
            Form1 f1 = (Form1)this.FindForm();

            string a = Microsoft.VisualBasic.Interaction.InputBox("Introduce el NUEVO nombre del proveedor", "Proveedor", this.Nombre);
            c.modificar_proveedor(this.Nombre, a);
            f1.cargar_modificar_proveedor();

        }
    }
}

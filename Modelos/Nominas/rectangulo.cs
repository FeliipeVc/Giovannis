using Giovannis.Modelos.BBDD;
using Giovannis.Modelos.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giovannis.Modelos.Nominas
{
    public partial class rectangulo : UserControl
    {
        private string _nombre;
        private string _id;
        private double _salario;
        public rectangulo()
        {
            InitializeComponent();
            this._nombre = "";
            this._id = "";
            this._salario = 0;
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; lbl_nombre.Text = value; }
        }

        public string Id
        {
            get { return _id; }
            set { _id=value; lbl_id.Text = value; }
        }

        public Double Salario
        {
            get { return _salario; }
            set { _salario = value; lbl_salario.Text = value.ToString() + "€"; }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            Form1 f1 = (Form1)this.FindForm();
            Consultas c = new Consultas();
            float aux = 0;

            String nuevoSalario = Microsoft.VisualBasic.Interaction.InputBox("Introduce el NUEVO salario del empleado", "Salario", this.Salario.ToString());

            if (!float.TryParse(nuevoSalario, out aux)) {

                MessageBox.Show("Debes introducir un salario");
                return;
            
            }

            if (aux <= 0) {

                MessageBox.Show("Debes introducir un número mayor que 0");
                return;

            }

            nuevoSalario = nuevoSalario.Replace(',', '.');

            c.updateNomina(this.Id.Trim(), nuevoSalario);
            f1.cargar_nominas_administrador();


        }
    }
}

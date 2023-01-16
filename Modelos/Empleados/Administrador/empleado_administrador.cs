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

namespace Giovannis.Modelos.Empleados.Administrador
{
    public partial class empleado_administrador : UserControl
    {
        private string _id;
        private string _nombre;
        private string _apellidos;
        private string _tipo;
        public empleado_administrador()
        {
            InitializeComponent();
            this._id = "";
            this._nombre = "";
            this._apellidos = "";
            this._tipo= "";
        }

        public string Id
        {
            get{
                return _id;
            }

            set
            {
                _id = value; lbl_id_2.Text = value;
            }
        }

        public string Nombre
        {
            get { 
                return _nombre;
            }

            set
            {
                _nombre = value; lbl_nombre_2.Text = value;
            }
        }

        public string Apellidos
        {
            get
            {
                return _apellidos;
            }
            set
            {
                _apellidos = value; lbl_apellidos_2.Text = value;
            }
        }
        
        public string Tipo
        {
            get {
                return _tipo;
            }
            set
            {
                _tipo = value; lbl_tipo_2.Text = value;
            }
        }

        private void bto_borrar_Click(object sender, EventArgs e)
        {
            Consultas consulta = new Consultas();
            List<string> fila = consulta.buscar_empleado(lbl_id_2.Text);
            string nuevo_id = "-"+fila[0];
            consulta.insertar_empleado(nuevo_id, fila[1], fila[2], fila[3], fila[4], fila[5], fila[6], fila[7], fila[8], fila[9]);
            consulta.actualizar_empleado(viejo: fila[0], nuevo: nuevo_id);
            consulta.borrar_empleado(fila[0]);
            Form1 f1 = (Form1)this.FindForm();
            f1.cargar_empleados_administrador();
        }
    }
}

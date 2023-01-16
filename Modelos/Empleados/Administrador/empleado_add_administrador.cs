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
using System.Text.RegularExpressions;

namespace Giovannis.Modelos.Empleados.Administrador
{
    public partial class empleado_add_administrador : UserControl
    {
        public empleado_add_administrador()
        {
            InitializeComponent();
        }

        private void bto_add_Click(object sender, EventArgs e)
        {
            
            Form1 f1 = (Form1)this.FindForm();
            Consultas c = new Consultas();

            int aux_id = c.max_tabla("Empleados") + 1;
            String id = aux_id.ToString();
            String nombre = txt_nombre.Texts;
            String apellidos = txt_apellidos.Texts;
            String dni = txt_dni.Texts;
            String fecha_nac = txt_fecha_nacimiento.Texts;
            String password = txt_password.Texts;
            String salario = txt_salario.Texts;
            String tipo = "";
            String tienda = lst_tienda.Text;
            String bloqueado = "0";

            if (nombre.Length == 0 || apellidos.Length == 0 || dni.Length == 0 || fecha_nac.Length == 0 || password.Length == 0 || salario.Length == 0)
            {
                MessageBox.Show("No puede haber campos vacios");
                return;
            }

            if (lst_tipo.Text == "Normal")
            {
                tipo = "1";
            }

            if (lst_tipo.Text == "Gerente")
            {
                tipo = "2";
            }

            if (lst_tipo.Text == "Administrador")
            {
                tipo = "3";
            }

            if (!Regex.IsMatch(dni, "^[0-9]{8}[A-Z]{1}$"))
            {
                MessageBox.Show("Formato incorrecto del dni");
                return;
            }

            int existe = c.existeEmpleado(dni);

            if (existe == 1)
            {
                MessageBox.Show("Ya existe el empleado");
                return;
            }

            if (!Regex.IsMatch(fecha_nac, "^([0]?[0-9]|[12][0-9]|[3][01])[./-]([0]?[1-9]|[1][0-2])[./-]([0-9]{4}|[0-9]{2})$")){
                MessageBox.Show("Formato de fecha invalido");
                return;
            }

            double aux;
            bool resul = double.TryParse(salario, out aux);

            if (!resul)
            {
                MessageBox.Show("Salario incorrecto");
                return;
            }

            if (aux < 0) {

                MessageBox.Show("El salario no puede ser menor que 0");
                return;

            }

            String id_tiendaa = c.selectIdTienda(tienda);

            c.insertar_empleado(id, password, nombre, apellidos, dni, fecha_nac, id_tiendaa, tipo, salario, bloqueado);
            //String id_empleado, String empleado_password, String empleado_nombre, String empleado_apellidos, String empleado_dni,
            //    String empleado_fecha_nac, String id_tienda, String empleado_tipo, String empleado_salario, String empleado_bloquead

            f1.cargar_empleados_administrador();
        }

        private void populateTienda()
        {
            Consultas c = new Consultas();

            List<List<string>> p = c.selectAll("Tiendas");

            for (int i = 1; i < p.Count; i++)
            {
                this.lst_tienda.Items.Add(p[i][1]);
            }
        }

        private void empleado_add_administrador_Load(object sender, EventArgs e)
        {
            populateTienda();
            lst_tienda.SelectedIndex = 0;
            lst_tipo.SelectedIndex = 0;
        }
    }
}

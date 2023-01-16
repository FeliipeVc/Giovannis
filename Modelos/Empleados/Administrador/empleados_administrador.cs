using Giovannis.Modelos.BBDD;
using Giovannis.Modelos.Pedidos;
using Giovannis.Modelos.Empleados;
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
    public partial class empleados_administrador : UserControl
    {
        public empleados_administrador()
        {
            InitializeComponent();
        }

        private void populateItems()
        {
            Consultas consulta = new Consultas();
            List<List<string>> empleados_lists = consulta.selectEmpleados();
            empleado_administrador[] empleados = new empleado_administrador[empleados_lists.Count];

            for (int i = 0; i < empleados.Length; i++)
            {
                empleados[i] = new empleado_administrador();
                empleados[i].Id = empleados_lists[i][0];
                empleados[i].Nombre = empleados_lists[i][2];
                empleados[i].Apellidos = empleados_lists[i][3];
                string tipo = "";
                if (int.Parse(empleados_lists[i][7]) == 1)
                {
                    tipo = "Normal";
                }

                if (int.Parse(empleados_lists[i][7]) == 2)
                {
                    tipo = "Gerente";
                }

                if (int.Parse(empleados_lists[i][7]) == 3)
                {
                    tipo = "Administrador";
                }

                empleados[i].Tipo = tipo;

                if (flw_pedidos.Controls.Count < 0)
                {

                    flw_pedidos.Controls.Clear();

                }
                else
                {
                    if (int.Parse(empleados[i].Id) > 0)
                    {
                        flw_pedidos.Controls.Add(empleados[i]);
                    }

                }
            }
        }

        private void empleados_administrador_Load(object sender, EventArgs e)
        {
            populateItems();
        }

        private void bto_add_empleado_Click(object sender, EventArgs e)
        {
            flw_pedidos.Controls.Clear();
            flw_pedidos.Controls.Add(new empleado_add_administrador());
            bto_add_empleado.Hide();
        }
    }
}

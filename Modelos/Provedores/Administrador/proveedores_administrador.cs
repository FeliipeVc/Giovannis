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
    public partial class proveedores_administrador : UserControl
    {
        public proveedores_administrador()
        {
            InitializeComponent();
        }


        private void populateItems()
        {
            Consultas consulta = new Consultas();
            List<List<string>> proveedor_admin = consulta.selectAll("Proveedores");
            proveedor_administrador[] p = new proveedor_administrador[proveedor_admin.Count()]; // CAMBIAR POR EL NUMEOR DE NOTIFICACIONES DEL USUARIO


            for (int i = 1; i < p.Length; i++)
            {
                p[i] = new proveedor_administrador();
                p[i].Nombre = proveedor_admin[i][1];

                if (flw_proveedores.Controls.Count < 0)
                {

                    flw_proveedores.Controls.Clear();

                }
                else
                {

                    flw_proveedores.Controls.Add(p[i]);

                }

            }


        }

        private void proveedores_administrador_Load(object sender, EventArgs e)
        {
            populateItems();
        }

        private void bttn_add_Click(object sender, EventArgs e)
        {
            Form1 f1 = (Form1)this.FindForm();

            f1.cargar_crear_proveedor();
        }
    }



}

using Giovannis.Modelos.Notificaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Giovannis.Modelos.Promociones;
using Giovannis.Modelos.Clases;

namespace Giovannis.Modelos.Promociones
{
    public partial class promocion : UserControl
    {
        public promocion()
        {
            InitializeComponent();
        }

        private void populateItems()
        {

            List<Promocion> p = Promocion._promociones;

            promo[] codigos = new promo[p.Count]; // CAMBIAR POR EL NUMEOR DE NOTIFICACIONES DEL USUARIO

            for (int i = 0; i < p.Count; i++)
            {
                codigos[i] = new promo();
                codigos[i].Codigo = p[i].Codigo;
                codigos[i].Estado = p[i].Activo.ToString();
                codigos[i].Porcentaje = p[i].Descuento.ToString();

                if (flw_promociones.Controls.Count < 0)
                {

                    flw_promociones.Controls.Clear();

                }
                else
                {
                    if (codigos[i].Estado == "1")
                        flw_promociones.Controls.Add(codigos[i]);

                }

            }


        }

        private void promocion_Load(object sender, EventArgs e)
        {
            populateItems();
        }
    }
}

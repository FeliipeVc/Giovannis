using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Giovannis.Modelos.Clases;
using Giovannis.Modelos.Promociones;

namespace Giovannis.Modelos.Promociones.Gerente
{
    public partial class promociones_gerente : UserControl
    {
        public promociones_gerente()
        {
            InitializeComponent();
        }

        private void populateItems()
        {

            List<Promocion> p = Promocion._promociones;

            promo_gerente[] codigos = new promo_gerente[p.Count]; // CAMBIAR POR EL NUMEOR DE NOTIFICACIONES DEL USUARIO

            for (int i = 0; i < p.Count; i++)
            {
                codigos[i] = new promo_gerente();
                codigos[i].Codigo = p[i].Codigo;
                codigos[i].Estado = p[i].Activo.ToString();
                codigos[i].Porcentaje = p[i].Descuento.ToString();

                if (codigos[i].Estado == "1")
                {
                    codigos[i].activar();
                }

                if (flw_promociones.Controls.Count < 0)
                {

                    flw_promociones.Controls.Clear();

                }
                else
                {

                    flw_promociones.Controls.Add(codigos[i]);

                }

            }


        }

        //private void promociones_gerente_Load(object sender, EventArgs e)
        //{
        //    populateItems();
        //}

        private void promociones_gerente_Load_1(object sender, EventArgs e)
        {
            populateItems();
        }
    }
}

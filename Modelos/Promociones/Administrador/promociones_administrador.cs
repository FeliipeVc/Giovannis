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
using Giovannis.Modelos.Promociones.Gerente;

namespace Giovannis.Modelos.Promociones.Administrador
{
    public partial class promociones_administrador : UserControl
    {
        public promociones_administrador()
        {
            InitializeComponent();
        }

        private void populateItems()
        {

            List<Promocion> p = Promocion._promociones;

            promocion_administrador[] codigos = new promocion_administrador[p.Count]; // CAMBIAR POR EL NUMEOR DE NOTIFICACIONES DEL USUARIO

            for (int i = 0; i < p.Count; i++)
            {
                codigos[i] = new promocion_administrador();
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

        private void flw_promociones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void promociones_administrador_Load(object sender, EventArgs e)
        {
            populateItems();
        }

        private void bto_add_promocion_Click(object sender, EventArgs e)
        {

            String nuevo_codigo = "";
            String nuevo_descuento = "";

            nuevo_codigo = Microsoft.VisualBasic.Interaction.InputBox("Introduce el nuevo codigo");

            if (nuevo_codigo.Length != 8)
            {
                MessageBox.Show("El codigo tiene que tener 8 caracteres");
                return;
            }

            for (int i = 0; i < Promocion._promociones.Count; i++)
            {
                if (Promocion._promociones[i].Codigo == nuevo_codigo)
                {
                    MessageBox.Show("Ya existe una promocion con ese nombre");
                    return;
                }
            }



            nuevo_descuento = Microsoft.VisualBasic.Interaction.InputBox("Introduce el nuevo descuento");

            int res;
            bool resul = int.TryParse(nuevo_descuento, out res);

            if (resul == true)
            {
                if (res < 0 || res > 100)
                {
                    MessageBox.Show("Porcentaje incorrecto");
                    return;
                }
                else
                {
                    Promocion._promociones.Add(new Promocion(nuevo_codigo, res, 0));
                    Promocion.volcar_promociones(Promocion._promociones);
                    Form1 f1 = (Form1)this.FindForm();
                    f1.cargar_modificar_promociones_administrador();                }
            }
            else
            {
                MessageBox.Show("Tienes que introducir un numero");
                return;
            }
        }
    }
}

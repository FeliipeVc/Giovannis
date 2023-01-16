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

namespace Giovannis.Modelos.Promociones.Administrador
{
    public partial class promocion_administrador : UserControl
    {
        private string _codigo;
        private string _estado;
        private string _porcentaje;
        public promocion_administrador()
        {
            InitializeComponent();
            this._codigo = "";
            this._estado = "";
            this._porcentaje = "";
        }

        public string Codigo
        {

            get
            {

                return _codigo;

            }

            set
            {

                _codigo = value; lbl_codigo.Text = value;

            }

        }

        public string Estado
        {

            get
            {

                return _estado;

            }

            set
            {

                _estado = value; lbl_estado.Text = value;

            }

        }

        public string Porcentaje
        {

            get
            {

                return _porcentaje;

            }

            set
            {

                _porcentaje = value; lbl_porcentaje.Text = value;

            }

        }

        public void activar()
        {
            bto_activar.Checked = true;
        }

        public void desactivar()
        {
            bto_activar.Checked = false;
        }

        private void bto_borrar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Promocion._promociones.Count; i++)
            {
                if (Promocion._promociones[i].Codigo == this.Codigo)
                {
                    Promocion._promociones.Remove(Promocion._promociones[i]);
                    Promocion.volcar_promociones(Promocion._promociones);
                    Form1 f1 = (Form1)this.FindForm();
                    f1.cargar_modificar_promociones_administrador();
                    break;
                }
            }

        }

        private void bto_activar_CheckedChanged(object sender, EventArgs e)
        {
            if (bto_activar.Checked)
            {
                this.Estado = "1";
            }
            else
            {
                this.Estado = "0";
            }

            for (int i = 0; i < Promocion._promociones.Count; i++)
            {
                if (Promocion._promociones[i].Codigo == this.Codigo)
                {
                    Promocion._promociones[i].Activo = int.Parse(this.Estado);
                }
            }

            Promocion.volcar_promociones(Promocion._promociones);
        }

        private void bto_editar_codigo_Click(object sender, EventArgs e)
        {
            String nuevo = "";
            Form1 f1 = (Form1)this.FindForm();
            int cont = 0;
            nuevo = Microsoft.VisualBasic.Interaction.InputBox("Introduce el nuevo codigo");

            if (this.Codigo == nuevo)
            {
                MessageBox.Show("El código tiene que ser distinto");
            } else
            {
                for(int i = 0; i < Promocion._promociones.Count; i++)
                {
                    if (Promocion._promociones[i].Codigo == nuevo)
                    {
                        cont++;
                    }
                }
            }

            if (cont > 0)
            {
                MessageBox.Show("Ese código promocional ya existe ya existe");
            }
            else
            {
                for (int i = 0; i < Promocion._promociones.Count; i++)
                {
                    if (Promocion._promociones[i].Codigo == this.Codigo)
                    {
                        Promocion._promociones[i].Codigo = nuevo;
                        Promocion.volcar_promociones(Promocion._promociones);
                        f1.cargar_modificar_promociones_administrador();
                    }
                }
            }


            
        }

        private void bto_editar_Click(object sender, EventArgs e)
        {
            String nuevo = "";
            Form1 f1 = (Form1)this.FindForm();

            nuevo = Microsoft.VisualBasic.Interaction.InputBox("Introduce el nuevo descuento");
            int res;
            bool resul = int.TryParse(nuevo, out res);

            if (resul == true)
            {
                if (res < 1 || res > 100)
                {
                   MessageBox.Show("Porcentaje incorrecto");
                } else
                {
                    for (int i = 0; i < Promocion._promociones.Count; i++)
                    {
                        if (this.Codigo == Promocion._promociones[i].Codigo)
                        {
                            Promocion._promociones[i].Descuento = res;
                            Promocion.volcar_promociones(Promocion._promociones);
                            f1.cargar_modificar_promociones_administrador();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Tienes que introducir un numero");
            }
        }
    }
}

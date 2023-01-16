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

namespace Giovannis.Modelos.Promociones.Gerente
{
    public partial class promo_gerente : UserControl
    {
        private string _codigo;
        private string _estado;
        private string _porcentaje;

        public promo_gerente()
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
    }
}

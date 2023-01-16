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

namespace Giovannis.Modelos.Stock.Administrador
{
    public partial class ingredientes_administrador : UserControl
    {

        private string _ingrediente;
        private string _cantidad;
        private string _provedor;


        public ingredientes_administrador()
        {
            InitializeComponent();

            this._ingrediente = "";
            this._cantidad = "";
            this._provedor = "";
        }

        public string Ingrediente
        {
            get { return _ingrediente; }
            set { _ingrediente = value; lbl_ingrediente_2.Text = value; }
        }

        public string Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; lbl_cantidad_2.Text = value; }
        }

        public string Provedor
        {
            get { return _provedor; }
            set { _provedor = value; lbl_provedor_2.Text = value; }
        }


        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Consultas c = new Consultas();
            Form1 f1 = (Form1)this.FindForm();

            String id = c.selectIdStock(this.Ingrediente);

            f1.cargar_modificarPanel_stock_administrador(this.Ingrediente, id, this.Cantidad);
        }

        
    }
}

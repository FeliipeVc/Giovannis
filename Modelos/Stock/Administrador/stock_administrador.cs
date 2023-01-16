using Giovannis.Modelos.BBDD;
using Giovannis.Modelos.Stock.Administrador;
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
    public partial class stock_administrador : UserControl
    {
        public stock_administrador()
        {
            InitializeComponent();
        }

        private void populateItems()
        {
            Consultas consulta = new Consultas();
            List<List<string>> stock_lista = consulta.selectStock();
            ingredientes_administrador[] ingrediente = new ingredientes_administrador[stock_lista.Count];

            for (int i = 0; i < ingrediente.Length; i++)
            {
                ingrediente[i] = new ingredientes_administrador();
                ingrediente[i].Cantidad = stock_lista[i][0].ToString();
                ingrediente[i].Ingrediente = stock_lista[i][1];
                ingrediente[i].Provedor = stock_lista[i][2];

                if (flw_stock.Controls.Count < 0)
                {

                    flw_stock.Controls.Clear();

                }
                else
                {

                    flw_stock.Controls.Add(ingrediente[i]);

                }
            }



        }


        private void stock_administrador_Load(object sender, EventArgs e)
        {
            populateItems();
        }

        private void bttn_add_Click(object sender, EventArgs e)
        {
            Form1 f1 = (Form1)this.FindForm();
            f1.cargar_modificar_stock_add_administrador();
        }
    }
}

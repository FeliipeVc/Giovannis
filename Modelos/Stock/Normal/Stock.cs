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

namespace Giovannis.Modelos.Stock
{
    public partial class Stock : UserControl
    {
        public Stock()
        {
            InitializeComponent();
        }

        private void populateItems()
        {
            Consultas consulta = new Consultas();
            List<List<string>> stock_lista = consulta.selectStock();
            Ingredientes[] ingrediente = new Ingredientes[stock_lista.Count];

            for (int i = 0; i < ingrediente.Length; i++)
            {
                ingrediente[i] = new Ingredientes();
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

        private void Stock_Load(object sender, EventArgs e)
        {
            populateItems();
        }
    }
}

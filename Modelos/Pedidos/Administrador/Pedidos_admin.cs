using Giovannis.Modelos.BBDD;
using Giovannis.Modelos.Pedidos.Gerente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giovannis.Modelos.Pedidos.Administrador
{
    public partial class Pedidos_admin : UserControl
    {
        public Pedidos_admin()
        {
            InitializeComponent();
        }
        private void populateItems()
        {
            Consultas consulta = new Consultas();
            List<List<string>> pedidos_lists = consulta.selectPedidos();
            Pedidos_panel_admin [] pedidos = new Pedidos_panel_admin[pedidos_lists.Count];

            for (int i = 0; i < pedidos.Length; i++)
            {
                pedidos[i] = new Pedidos_panel_admin();
                pedidos[i].IdPedido = $"Identificador:  {pedidos_lists[i][0]}";
                pedidos[i].FechaPedido = $"Fecha del pedido:  {pedidos_lists[i][1]}";
                pedidos[i].Tienda = $"Tienda:  {pedidos_lists[i][2]}";
                pedidos[i].Empleado = $"Preparado por:   {pedidos_lists[i][3]}";
                pedidos[i].Cliente = $"Cliente:   {pedidos_lists[i][4]}";
                pedidos[i].NomMenu = $"Nombre menu:   {pedidos_lists[i][5]}";
                pedidos[i].Precio = $"Precio:   {pedidos_lists[i][6]}€";

                if (flw_pedidos.Controls.Count < 0)
                {

                    flw_pedidos.Controls.Clear();

                }
                else
                {

                    flw_pedidos.Controls.Add(pedidos[i]);

                }

            }
        }

        private void Pedidos_admin_Load(object sender, EventArgs e)
        {
            populateItems();
        }

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            Button bttn = (Button)sender;
            bttn.Visible = false;
            flw_pedidos.Controls.Clear();
            flw_pedidos.Controls.Add(new Pedidos_add());
        }
    }
}

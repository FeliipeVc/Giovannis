using Giovannis.Modelos.BBDD;
using Objetos.RJControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giovannis.Modelos.Pedidos.Administrador
{
    public partial class Pedidos_add : UserControl
    {
        public Pedidos_add()
        {
            InitializeComponent();
        }

        private void bttnAdd_Click(object sender, EventArgs e)
        {

            List<string> campos = new List<string>();

            foreach (RJTextBox tb in inputPanel.Controls)
            {
                if (tb.Texts.Trim().Length == 0)
                {
                    MessageBox.Show("Rellena todos los campos");
                    return;
                } else
                {
                    campos.Add(tb.Texts);
                }
                
            }

            

            Consultas c = new Consultas();
            int awns = c.addPedido(campos);

            if (awns == -2)
            {
                MessageBox.Show("Has introducido algún campo incorrecto");
                return;
            }


            Form1 f1 = (Form1)this.FindForm();
            f1.load_panel(new Pedidos_admin());
            Button bttn = (Button)sender;
            bttn.Visible = true;
        }
    }
}

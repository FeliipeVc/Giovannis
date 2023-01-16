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

namespace Giovannis.Modelos.Provedores.Administrador
{
    public partial class proveedor_administrador_add : UserControl
    {
        public proveedor_administrador_add()
        {
            InitializeComponent();
        }

        private void bttn_add_Click(object sender, EventArgs e)
        {

            Consultas c = new Consultas();
            Form1 f1 = (Form1)this.FindForm();
            int aux = 0, i;
            Boolean flag = false;

            if (this.txt_newProveedor.Texts.Length == 0) {

                MessageBox.Show("El nombre del proveedor no puede estar vacío.");
                return;

            }

            List<List<string>> proveedores = c.selectProveedores();

            List<int> lista_aux = new  List<int>();

            for (i = 1; i < proveedores.Count; i++) {

                lista_aux.Add(int.Parse(proveedores[i][0]));

            }

            lista_aux.Sort();

            for (i = 0; i < lista_aux.Count; i++) {

                if (this.txt_newProveedor.Texts == proveedores[i+1][1]) {

                    MessageBox.Show("El nombre del proveedor no puede estar repetido.");
                    return;

                }

                if ((i + 1) != lista_aux[i] && flag == false) {
                    aux = i + 1;
                    flag = true;
                }
            
            }

            if (aux == 0)
            {
                c.crearProveedor((i+1).ToString(), this.txt_newProveedor.Texts);
            }
            else {
                c.crearProveedor(aux.ToString(), this.txt_newProveedor.Texts);
            }

            f1.cargar_modificar_proveedor_admin();

        }
    }
}

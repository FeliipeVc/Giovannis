using Giovannis.Modelos.BBDD;
using Giovannis.Modelos.Menu.Gerente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giovannis.Modelos.Menu.Administrador
{
    public partial class Menu_admin : UserControl
    {
        public Menu_admin()
        {
            InitializeComponent();
        }
        private void populateItems()
        {

            Consultas consulta = new Consultas();
            List<List<string>> menus_lista = consulta.selectMenus();
            Menu_panel_admin[] menus = new Menu_panel_admin[menus_lista.Count]; // CAMBIAR POR EL NUMEOR DE NOTIFICACIONES DEL USUARIO

            for (int i = 0; i < menus.Length; i++)
            {
                if (!menus_lista[i][6].Contains("-"))
                {
                    menus[i] = new Menu_panel_admin();
                    menus[i].Titulo = menus_lista[i][0];
                    menus[i].Ingrediente1 = $"Ingrediente 1:  {menus_lista[i][1]}";
                    menus[i].Ingrediente2 = $"Ingrediente 2:  {menus_lista[i][2]}";
                    menus[i].Ingrediente3 = $"Ingrediente 3:   {menus_lista[i][3]}";
                    menus[i].Precio = $"Precio:  {menus_lista[i][4]}€";
                    menus[i].Descripcion = $"Descripción:\n{menus_lista[i][5]}";
                    menus[i].Id = menus_lista[i][6];
                }


                if (flw_menus.Controls.Count < 0)
                {

                    flw_menus.Controls.Clear();

                }
                else
                {

                    flw_menus.Controls.Add(menus[i]);

                }

            }


        }
        private void Menu_admin_Load(object sender, EventArgs e)
        {
            populateItems();
        }
        private void rjButton2_Click(object sender, EventArgs e)
        {

            Form1 f1 = (Form1)this.FindForm();
            f1.cargar_modificar_menus_administrador();
        }
    }
}

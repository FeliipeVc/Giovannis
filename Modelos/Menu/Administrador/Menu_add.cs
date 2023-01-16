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

namespace Giovannis.Modelos.Menu.Administrador
{
    public partial class Menu_add : UserControl
    {
        public Menu_add()
        {
            InitializeComponent();
        }

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            Consultas c = new Consultas();
            float precio = 0;
            Boolean aux = false;
            String ing1 = "", ing2 = "", ing3 = "";

            if (txtTitulo.Texts.Trim().Length == 0 || txtIng1.Texts.Trim().Length == 0 || txtIng2.Texts.Trim().Length == 0 || txtIng3.Texts.Trim().Length == 0 || txtPrecio.Texts.Trim().Length == 0 || txtDesc.Texts.Trim().Length == 0)
            {
                MessageBox.Show("Rellena todos los campos para poder crear un menú nuevo.");
                return;
            }

            //TRY PARSE AQUI COMO EN STOCK
            aux = float.TryParse(this.txtPrecio.Texts, out precio);

            if (!aux)
            {

                MessageBox.Show("La cantidad introducida tiene que ser un número");
                return;
            }

            if (precio <= 0)
            {

                MessageBox.Show("La cantidad introducida tiene que ser un número mayor o igual que 0");
                return;
            }

            ing1 = c.devuelveNumeroIngredienteStock(txtIng1.Texts);
            if (ing1 == "") {
                MessageBox.Show("No existe el ingrediente1 seleccionado.");
                return;
            }

            ing2 = c.devuelveNumeroIngredienteStock(txtIng2.Texts);
            if (ing2 == "") {
                MessageBox.Show("No existe el ingrediente2 seleccionado.");
                return;
            }

            ing3 = c.devuelveNumeroIngredienteStock(txtIng3.Texts);
            if (ing3 == "") {
                MessageBox.Show("No existe el ingrediente3 seleccionado.");
                return;
            }
               

            //Cojo el maximo ID de la tabla
            int maxIDmenuInt = c.max_tabla("Menu")+1;
             
            c.addPizza(txtTitulo.Texts, ing1.ToString(), ing2.ToString(), ing3.ToString(), txtDesc.Texts, maxIDmenuInt.ToString());
            c.addMenu(maxIDmenuInt.ToString(), precio.ToString().Replace(',', '.'));

            Form1 f1 = (Form1)this.FindForm();
            f1.load_panel(new Menu_admin());
            Button bttn = (Button)sender;
            bttn.Visible = true;
        }
        //private string valIng(string ING)
        //{
            //int aux = 0;
            //Consultas c = new Consultas();
            //aux = c.existeIng(ING);
            //if (aux == 0)
            //{
            //     MessageBox.Show("El ingrediente no existe en la base de datos");
            //}
            
        //return ING;
        //}
        private void lbl_Tienda_Click(object sender, EventArgs e)
        {

        }

        private void lbl_titulo_Click(object sender, EventArgs e)
        {

        }

        private void Menu_add_Load(object sender, EventArgs e)
        {

        }
    }
}

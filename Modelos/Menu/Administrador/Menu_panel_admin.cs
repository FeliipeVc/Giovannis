using Giovannis.Modelos.BBDD;
using Giovannis.Modelos.Menu.Administrador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giovannis.Modelos.Menu.Gerente
{
    public partial class Menu_panel_admin : UserControl
    {

        private string _titulo;
        private string _ingrediente1;
        private string _ingrediente2;
        private string _ingrediente3;
        private string _descripcion;
        private string _precio;
        private string _id;

        public Menu_panel_admin()
        {
            InitializeComponent();
            _titulo = "";
            _ingrediente1 = "";
            _ingrediente2 = "";
            _ingrediente3 = "";
            _descripcion = "";
            _precio = "";
            _id = "";
        }

        public string Titulo
        {

            get
            {

                return _titulo;

            }

            set
            {

                _titulo = value; lbl_titulo.Text = value;

            }

        }
        public string Ingrediente1
        {

            get
            {

                return _ingrediente1;

            }

            set
            {

                _ingrediente1 = value; lbl_ingrediente1.Text = value;

            }

        }

        public string Ingrediente2
        {

            get
            {

                return _ingrediente2;

            }

            set
            {

                _ingrediente2 = value; lbl_ingrediente2.Text = value;

            }

        }

        public string Ingrediente3
        {

            get
            {

                return _ingrediente3;

            }

            set
            {

                _ingrediente3 = value; lbl_ingrediente3.Text = value;

            }

        }

        public string Descripcion
        {

            get
            {

                return _descripcion;

            }

            set
            {

                _descripcion = value; lbl_descripcion.Text = value;

            }

        }

        public string Precio
        {

            get
            {

                return _precio;

            }

            set
            {

                _precio = value; btt_precio.Text = value;

            }

        }

        public string Id { get => _id; set => _id = value; }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 f1 = (Form1)this.FindForm();
            Consultas c = new Consultas();
            String nuevoTitulo = "";
            String nuevaDescripcion = "";
            float nuevoPrecio = 0;
            String ing1 = "", ing2 = "", ing3 = "";


            nuevoTitulo = Microsoft.VisualBasic.Interaction.InputBox("Introduce el NUEVO nombre del menú", "Menús", this.Titulo);

            ing1 = valIng(this.Ingrediente1.Split(':')[1].Trim());
            ing2 = valIng(this.Ingrediente2.Split(':')[1].Trim());
            ing3 = valIng(this.Ingrediente3.Split(':')[1].Trim());

            nuevaDescripcion = Microsoft.VisualBasic.Interaction.InputBox("Introduce el NUEVO nombre del menú", "Menús", this.Descripcion.Split(':')[1].Trim());

            nuevoPrecio = valPrecio(this.Precio.Split(':')[1].Trim());

            c.modificar_Menu(nuevoTitulo, ing1, ing2, ing3, nuevaDescripcion, nuevoPrecio.ToString().Replace(',', '.'), this.Id, this.Titulo);
            f1.load_panel(new Menu.Administrador.Menu_admin());
        }

        private string valIng(string ingrediente)
        {
            int aux = 0;
            Consultas c = new Consultas();
            string ING = "";

            while (aux == 0)
            {
                ING = Microsoft.VisualBasic.Interaction.InputBox("Anota el nuevo INGREDIENTE", "Ingrediente", ingrediente);
                aux = c.existeIng(ING);
                if (aux == 0)
                {
                    MessageBox.Show("El ingrediente no existe en la base de datos");
                }
            }

            return ING;
        }
        private float valPrecio(string precio)
        {

            float numeroBien = 0;
            string numeroMal = "";
            Boolean aux = false;


            while (aux == false)
            {
                numeroMal = Microsoft.VisualBasic.Interaction.InputBox("Anota el nuevo precio", "Precio", precio);
                aux = float.TryParse(numeroMal, out numeroBien);
                if (!aux)
                {
                    MessageBox.Show("Error, el dato introducido no es un número");

                }
            }


            return numeroBien;
        }

        private void bttnDelete_Click(object sender, EventArgs e)
        {
            Form1 f1 = (Form1)this.FindForm();
            Consultas c = new Consultas();

            List<List<string>> aux = c.selectDatosBorrarMenu(this.Id);
            List<List<string>> aux2 = c.selectPizzas(aux[0][0]);


            c.eliminarPizza((int.Parse(aux[0][0]) * -1).ToString(), aux2[0][1], aux2[0][2], aux2[0][3], aux2[0][4], aux2[0][5], aux[0][0], this.Id);
            c.eliminarMenu((int.Parse(this.Id) * -1).ToString(), this.Precio.Split(':')[1].Split('€')[0].Trim(), (int.Parse(aux[0][0]) * -1).ToString(), aux[0][1], aux[0][2], this.Id);
            f1.load_panel(new Menu_admin());
        }


        
    }

}

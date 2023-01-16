﻿using Giovannis.Modelos.BBDD;
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
    public partial class stock_modificar_administrador : UserControl
    {

        private String _nombre;
        private String _id;
        private String _cantidad;

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Id { get => _id; set => _id = value; }
        public string Cantidad { get => _cantidad; set => _cantidad = value; }

        public stock_modificar_administrador(String nombre, String id, string cantidad)
        {
            InitializeComponent();
            this._nombre = nombre;
            this._id = id;
            Cantidad = cantidad;
        }

        private void stock_modificar_administrador_Load(object sender, EventArgs e)
        {
            this.txt_nombre.Texts = this._nombre;
            this.txt_cantidad.Texts = this.Cantidad;
            populateProveedores();
        }

        private void bttn_update_Click(object sender, EventArgs e)
        {
            String nombre = this.txt_nombre.Texts; 
            int cantidad = 0;
            Boolean aux = false;
            String proveedor = this.lst_nombres.Text;

            Form1 f1 = (Form1)this.FindForm();
            Consultas c = new Consultas();

            if (nombre.Trim().Length == 0 || this.txt_cantidad.Texts.Trim().Length == 0 || proveedor.Trim().Length == 0) {

                MessageBox.Show("No puede haber ningún campo vacío");
                return;

            }

            if (c.existeIng(nombre) != 0 && nombre != this.Nombre) {

                MessageBox.Show("Ya existe un ingrediente con ese nombre");
                return;

            }

            aux = int.TryParse(this.txt_cantidad.Texts, out cantidad);

            if (!aux)
            {

                MessageBox.Show("La cantidad introducida tiene que ser un número");
                return;
            }

            if (cantidad < 0)
            {

                MessageBox.Show("La cantidad introducida tiene que ser un número mayor o igual que 0");
                return;
            }

            String idP = c.selectIdProveedor(proveedor);

            c.modificarStockAdmin(nombre, cantidad.ToString(), idP, this.Id);

            f1.cargar_modificar_stock_administrador();

        }

        private void populateProveedores() {

            Consultas c = new Consultas();

            List<List<string>> p = c.selectAll("Proveedores");

            for (int i = 1; i < p.Count; i++) {

                this.lst_nombres.Items.Add(p[i][1]);
            
            }


        }

        
    }
}

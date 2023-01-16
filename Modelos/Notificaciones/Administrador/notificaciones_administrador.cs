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

namespace Giovannis.Modelos.Notificaciones.Administrador
{
    public partial class notificaciones_administrador : UserControl
    {
        public notificaciones_administrador()
        {
            InitializeComponent();
        }

        private void populateItems()
        {
            Form1 f1 = (Form1)this.FindForm();
            Consultas consulta = new Consultas();
            List<List<string>> notificaciones_lista = consulta.selectNotificaciones(f1.Dni);
            notis_administrador[] notificaciones = new notis_administrador[notificaciones_lista.Count]; // CAMBIAR POR EL NUMEOR DE NOTIFICACIONES DEL USUARIO

            for (int i = 0; i < notificaciones.Length; i++)
            {
                notificaciones[i] = new notis_administrador();
                notificaciones[i].Emisor = notificaciones_lista[i][0];
                notificaciones[i].Cuerpo = notificaciones_lista[i][1];
                if (flw_notisP.Controls.Count < 0)
                {

                    flw_notisP.Controls.Clear();

                }
                else
                {

                    flw_notisP.Controls.Add(notificaciones[i]);

                }

            }


        }

        private void populateNombres()
        {
            Consultas consulta = new Consultas();
            List<List<string>> g_lista = consulta.selectGerentes();
            string[] nombres = new string[g_lista.Count]; // CAMBIAR POR EL NUMEOR DE NOTIFICACIONES DEL USUARIO

            for (int i = 0; i < nombres.Length; i++)
            {
                nombres[i] = g_lista[i][0];
                lst_nombres.Items.Add(nombres[i]);

            }
        }

        private void notificaciones_administrador_Load(object sender, EventArgs e)
        {
            populateItems();
            populateNombres();
        }

        private void bttn_enviar_Click(object sender, EventArgs e)
        {
            Form1 f1 = (Form1)this.FindForm();
            String dni = f1.Dni;
            String nombre = lst_nombres.Text;
            String cuerpo = "";

            Consultas consulta = new Consultas();

            if (this.txt_cuerpo.Texts.Length == 0 || nombre.Length == 0)
            {

                MessageBox.Show("Ni el cuerpo del mensaje ni el destinatario pueden estar vacíos.");

            }

            cuerpo = this.txt_cuerpo.Texts;

            consulta.mandarNotificacion(consulta.selectIdDni(dni), consulta.selectIdNombre(nombre), cuerpo);

            f1.cargar_modificar_notificaciones_admin();
        }

        private void btttn_todos_Click(object sender, EventArgs e)
        {
            Form1 f1 = (Form1)this.FindForm();
            String dni = f1.Dni;
            String cuerpo = "";
            Consultas consulta = new Consultas();
            List<List<string>> g_lista = consulta.selectGerentes();


            if (this.txt_cuerpo.Texts.Length == 0)
            {

                MessageBox.Show("El cuerpo del mensaje no puede estar vacío.");

            }

            cuerpo = this.txt_cuerpo.Texts;

            for (int i = 0; i < g_lista.Count; i++) {

                consulta.mandarNotificacion(consulta.selectIdDni(dni), consulta.selectIdNombre(g_lista[i][0]), cuerpo);

            }

            f1.cargar_modificar_notificaciones_admin();
        }
    }
}

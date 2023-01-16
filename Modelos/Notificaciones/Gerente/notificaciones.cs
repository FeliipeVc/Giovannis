using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Giovannis.Modelos.BBDD;
using Giovannis.Modelos.Notificaciones;

namespace Giovannis.Modelos
{
    public partial class notificaciones : UserControl
    {
        public notificaciones()
        {
            InitializeComponent();
        }

        private void populateItems()
        {
            Form1 f1 = (Form1)this.FindForm();
            Consultas consulta = new Consultas();
            List<List<string>> notificaciones_lista = consulta.selectNotificaciones(f1.Dni);
            flw_notis[] notificaciones = new flw_notis[notificaciones_lista.Count]; // CAMBIAR POR EL NUMEOR DE NOTIFICACIONES DEL USUARIO

            for (int i = 0; i < notificaciones.Length; i++)
            {
                notificaciones[i] = new flw_notis();
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

        private void notificaciones_Load(object sender, EventArgs e)
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

            if (this.txt_cuerpo.Texts.Length == 0 || nombre.Length == 0) {

                MessageBox.Show("Ni el cuerpo del mensaje ni el destinatario pueden estar vacíos.");

            }

            cuerpo = this.txt_cuerpo.Texts;

            consulta.mandarNotificacion(consulta.selectIdDni(dni), consulta.selectIdNombre(nombre), cuerpo);

            f1.cargar_modificar_notificaciones();

        }
    }
}

using Giovannis.Modelos.BBDD;
using Giovannis.Modelos.Horarios.Gerente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giovannis.Modelos.Horarios.Adminstrador
{
    public partial class HorarioAdmin : UserControl
    {
        public HorarioAdmin()
        {
            InitializeComponent();
        }

        private void populateItems()
        {
            Consultas consulta = new Consultas();
            List<List<string>> horarios_lista = consulta.selectHorarios();
            EmpleadosAdmin[] empleado = new EmpleadosAdmin[horarios_lista.Count];

            for (int i = 0; i < empleado.Length; i++)
            {

                if (!horarios_lista[i][1].ToString().Contains("-")) {
                    empleado[i] = new EmpleadosAdmin();
                    empleado[i].Nombre = horarios_lista[i][0].Split(' ')[0];
                    empleado[i].ID = horarios_lista[i][1].ToString();
                    empleado[i].Llegada = DateTime.Parse(horarios_lista[i][2]);
                    empleado[i].Salida = DateTime.Parse(horarios_lista[i][3]);
                    empleado[i].TotalTrabajado = Math.Floor((empleado[i].Salida - empleado[i].Llegada).TotalHours);
                    if (flw_Horarios_Admin.Controls.Count < 0)
                    {
                        flw_Horarios_Admin.Controls.Clear();
                    }
                    else
                    {
                        flw_Horarios_Admin.Controls.Add(empleado[i]);
                    }
                }

                
            }
        }

        private void HorarioAdmin_Load(object sender, EventArgs e)
        {
            populateItems();
        }

        private void lbl_horarios_Click(object sender, EventArgs e)
        {

        }

        
    }
}

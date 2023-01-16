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

namespace Giovannis.Modelos.Horarios.Gerente
{
    public partial class Horarios : UserControl
    {
        public Horarios()
        {
            InitializeComponent();
        }
        private void Horarios_Load(object sender, EventArgs e)
        {
            populateItems();
        }

        private void populateItems()
        {
            Consultas consulta = new Consultas();
            List<List<string>> horarios_lista = consulta.selectHorarios();
            Empleados[] empleado = new Empleados[horarios_lista.Count];

            for (int i = 0; i < empleado.Length; i++)
            {

                empleado[i] = new Empleados();
                empleado[i].Nombre = horarios_lista[i][0].Split(' ')[0];
                empleado[i].ID = horarios_lista[i][1].ToString();
                empleado[i].Llegada = DateTime.Parse(horarios_lista[i][2]);
                empleado[i].Salida = DateTime.Parse(horarios_lista[i][3]);
                empleado[i].TotalTrabajado = Math.Floor((empleado[i].Salida - empleado[i].Llegada).TotalHours);
                if(flw_Horarios.Controls.Count < 0)
                {
                    flw_Horarios.Controls.Clear();
                }
                else
                {
                    if (!empleado[i].ID.Contains("-"))
                    {
                        flw_Horarios.Controls.Add(empleado[i]);
                    }
                   
                }
            }
        }
    }
}

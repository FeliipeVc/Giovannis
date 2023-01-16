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
using Giovannis.Modelos.Clases;
using Giovannis.Modelos.Horarios.Gerente;
using Giovannis.Modelos.Promociones;

namespace Giovannis.Modelos.Nominas
{
    public partial class nominas : UserControl
    {
        public nominas()
        {
            InitializeComponent();
        }
        private void nominas_Load(object sender, EventArgs e)
        {
            populateItems();
        }

        private void populateItems()
        {
            
            Consultas consulta = new Consultas();
            //List<string> horarios_lista = consulta.selectNominas();
            

            List<List<string>> horarios_nominas = consulta.selectNominas();
            rectangulo[] nomina = new rectangulo[horarios_nominas.Count];

            for (int i = 0; i < nomina.Length; i++)
            {

                if (!horarios_nominas[i][1].Contains("-"))
                {
                    //empleado[i] = new Empleados();
                    //empleado[i].Nombre = horarios_lista[i];
                    nomina[i] = new rectangulo();
                    nomina[i].Nombre = horarios_nominas[i][0].Split(' ')[0];
                    nomina[i].Id = horarios_nominas[i][1].ToString();
                    nomina[i].Salario = Convert.ToDouble(horarios_nominas[i][2]);
                }
                if (flw_nominas.Controls.Count < 0)
                {
                    flw_nominas.Controls.Clear();
                }
                else
                {
                    flw_nominas.Controls.Add(nomina[i]);
                }
            }
        }
    }
}

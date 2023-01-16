using Giovannis.Modelos.BBDD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

//horaSalida = Microsoft.VisualBasic.Interaction.InputBox("Introduce la hora de salida:","Salida", this.Salida.ToString().Split(':')[1].Trim());
namespace Giovannis.Modelos.Horarios.Adminstrador
{
    public partial class EmpleadosAdmin : UserControl
    {
        private string _nombre;
        private string _id_trabajador;
        private DateTime _llegada;
        private DateTime _salida;
        private double _totalTrabajado; //es la unidad para la resta de fechas


        public EmpleadosAdmin()
        {
            InitializeComponent();

            this._nombre = "";
            this._id_trabajador = "";
            this._llegada = DateTime.Parse("04/05/2022 8:34:01"); //La fecha la sacamos de la bb.dd
            this._salida = DateTime.Now; //Pongo la fecha de ahora como ejemplo
            this._totalTrabajado = 0;

        }
        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; lbl_nombreEmpleado.Text = value; }
        }

        public string ID
        {
            get { return this._id_trabajador; }
            set { this._id_trabajador = value; lbl_Nombre.Text = value; }
        }

        public DateTime Llegada
        {
            get { return this._llegada; }
            set { this._llegada = value; lbl_llegada.Text = value.ToString(); }
        }
        public DateTime Salida
        {
            get { return this._salida; }
            set { this._salida = value; lbl_salida.Text = value.ToString(); }
        }
        public Double TotalTrabajado
        {
            get { return this._totalTrabajado; }
            set { this._totalTrabajado = value; lbl_total.Text = value.ToString(); }
        }

        private void EmpleadosAdmin_Load(object sender, EventArgs e)
        {

        }

        private void lbl_llegada_Click(object sender, EventArgs e)
        {

        }

        private void img_cambio_Click(object sender, EventArgs e)
        {
            Consultas c = new Consultas();
            Form1 f1 = (Form1)this.FindForm();
            string fechaSalida = this.Salida.ToString(),fechaEntrada=this.Llegada.ToString();
            int diaE=0, horaE=0, mesE=0, anioE=0, minE=0, segE=0, diaS=0, mesS=0,anioS=0, horaS=0,minS=0, segS=0;

            fechaEntrada = Microsoft.VisualBasic.Interaction.InputBox("Introduce la hora de entrada:", "Entrada", this.Llegada.ToString());
                if (fechaEntrada == "") return;
                if (!Regex.IsMatch(fechaEntrada, "^([0]?[0-9]|[12][0-9]|[3][01])[./-]([0]?[1-9]|[1][0-2])[./-]([0-9]{4}|[0-9]{2})[ ](?:0?[0-9]|1[0-9]|2[0-3]):[0-5][0-9]:[0-5][0-9]$")) return;
                diaE = Convert.ToInt16(fechaEntrada.Split(' ')[0].Split('/')[0]);
                mesE= Convert.ToInt16(fechaEntrada.Split(' ')[0].Split('/')[1]);
                anioE = Convert.ToInt16(fechaEntrada.Split(' ')[0].Split('/')[2]);
                horaE = Convert.ToInt16(fechaEntrada.Split(' ')[1].Split(':')[0]);
                minE = Convert.ToInt16(fechaEntrada.Split(' ')[1].Split(':')[1]);
                segE = Convert.ToInt16(fechaEntrada.Split(' ')[1].Split(':')[2]);
                int a = validar(diaE, mesE, horaE, minE, segE);
                if (a == -1) return;

            fechaSalida = Microsoft.VisualBasic.Interaction.InputBox("Introduce la hora de salida:", "Salida", this.Salida.ToString());
                if (fechaSalida == "") return;
                if (!Regex.IsMatch(fechaSalida, "^([0]?[0-9]|[12][0-9]|[3][01])[./-]([0]?[1-9]|[1][0-2])[./-]([0-9]{4}|[0-9]{2})[ ](?:0?[0-9]|1[0-9]|2[0-3]):[0-5][0-9]:[0-5][0-9]$")) return;
                diaS = Convert.ToInt16(fechaSalida.Split(' ')[0].Split('/')[0]);
                mesS = Convert.ToInt16(fechaSalida.Split(' ')[0].Split('/')[1]);
                anioS = Convert.ToInt16(fechaSalida.Split(' ')[0].Split('/')[2]);
                horaS = Convert.ToInt16(fechaSalida.Split(' ')[1].Split(':')[0]);
                minS = Convert.ToInt16(fechaSalida.Split(' ')[1].Split(':')[1]);
                segS = Convert.ToInt16(fechaSalida.Split(' ')[1].Split(':')[2]);
                int b=validar(diaS, mesS, horaS, minS, segS);
                if (b == -1) return;
                

            //fechaEntrada = añoE + "-" + mesE + "-" + diaE + " " + horaE + ":" + minE + ":" + segE;
            fechaEntrada = $"{anioE}-{mesE}-{diaE} {horaE}:{minE}:{segE}";
            fechaSalida = $"{anioS}-{mesS}-{diaS} {horaS}:{minS}:{segS}";

            if (c.modificarEntrada(fechaEntrada, this.ID)==1 && c.modificarSalida(fechaSalida, this.ID)==1)
            {
                MessageBox.Show("Horas actualizadas");
                f1.load_panel(new HorarioAdmin());
            }
            else
            {
                MessageBox.Show("Error al actualizar");
            }
        }

        public int validar(int dia, int mes, int hora, int min, int seg)
        {
            if (dia < 1 || dia > 31)
            {
                MessageBox.Show("Error en dia");
                return -1;
            }
            if (mes < 1 || mes > 12)
            {
                MessageBox.Show("Error en mes");
                return -1;
            }
            if (hora < 8 || hora > 19)
            {
                MessageBox.Show("Error horas");
                return -1;
            }
            if (min < 1 || min > 60)
            {
                MessageBox.Show("Error minutos");
                return -1;
            }
            if (seg < 1 || seg > 60)
            {
                MessageBox.Show("Error segundos");
                return -1;
            }
            return 1;
        }
    }
}
using Giovannis.Modelos.BBDD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giovannis.Modelos
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lbl_notificaciones_Click(object sender, EventArgs e)
        {

        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {
            
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Texts;
            string password = txtPassword.Texts;

            Consultas consulta = new Consultas();

            if (usuario.Length == 0)
            {
                MessageBox.Show("Rellena el nombre de usuario");
                return;
            }
            if (password.Length == 0)
            {
                MessageBox.Show("Rellena la contraseña");
                return;
            }
            if (consulta.existeEmpleado(usuario) == 1)
            {
                if (consulta.devuelvoPassword(usuario, password) != 1)
                {
                    if (consulta.devuelvoTipo(usuario, password) == -1)
                    {
                        MessageBox.Show("Usuario/Contraseña inválidos");

                    }
                    //MessageBox.Show("La contraseña no existe con ese usuario.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("El usuario no existe.");
            }

            Form1 f1 = (Form1)this.FindForm();
            f1.iniciar_sesion(consulta.devuelvoTipo(usuario, password), usuario);
            f1.Fecha_log = DateTime.Now;


        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

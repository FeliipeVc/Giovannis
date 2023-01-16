using System.Drawing;

namespace Giovannis.Modelos
{
    partial class Login
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lbl_notificaciones = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsuario = new Objetos.RJControls.RJTextBox();
            this.txtPassword = new Objetos.RJControls.RJTextBox();
            this.pctBox = new System.Windows.Forms.PictureBox();
            this.rjButton1 = new Objetos.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_notificaciones
            // 
            this.lbl_notificaciones.AutoSize = true;
            this.lbl_notificaciones.Font = new System.Drawing.Font("Microsoft Yi Baiti", 45F);
            this.lbl_notificaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.lbl_notificaciones.Location = new System.Drawing.Point(359, 258);
            this.lbl_notificaciones.Name = "lbl_notificaciones";
            this.lbl_notificaciones.Size = new System.Drawing.Size(369, 60);
            this.lbl_notificaciones.TabIndex = 0;
            this.lbl_notificaciones.Text = "Inicio de Sesión";
            this.lbl_notificaciones.Click += new System.EventHandler(this.lbl_notificaciones_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Yi Baiti", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.lblUsuario.Location = new System.Drawing.Point(371, 449);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(115, 38);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Yi Baiti", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.lblPassword.Location = new System.Drawing.Point(371, 578);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(165, 38);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.txtUsuario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(35)))), ((int)(((byte)(22)))));
            this.txtUsuario.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(35)))), ((int)(((byte)(22)))));
            this.txtUsuario.BorderRadius = 13;
            this.txtUsuario.BorderSize = 3;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.txtUsuario.ForeColor = System.Drawing.Color.White;
            this.txtUsuario.Location = new System.Drawing.Point(376, 497);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtUsuario.Multiline = false;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtUsuario.PasswordChar = false;
            this.txtUsuario.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUsuario.PlaceholderText = "";
            this.txtUsuario.Size = new System.Drawing.Size(505, 43);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.Texts = "";
            this.txtUsuario.UnderlinedStyle = false;
            this.txtUsuario._TextChanged += new System.EventHandler(this.rjTextBox1__TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(35)))), ((int)(((byte)(22)))));
            this.txtPassword.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(35)))), ((int)(((byte)(22)))));
            this.txtPassword.BorderRadius = 13;
            this.txtPassword.BorderSize = 3;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(376, 638);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPassword.PasswordChar = true;
            this.txtPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.Size = new System.Drawing.Size(505, 43);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Texts = "";
            this.txtPassword.UnderlinedStyle = false;
            // 
            // pctBox
            // 
            this.pctBox.Image = ((System.Drawing.Image)(resources.GetObject("pctBox.Image")));
            this.pctBox.Location = new System.Drawing.Point(726, 225);
            this.pctBox.Margin = new System.Windows.Forms.Padding(2);
            this.pctBox.Name = "pctBox";
            this.pctBox.Size = new System.Drawing.Size(169, 162);
            this.pctBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctBox.TabIndex = 5;
            this.pctBox.TabStop = false;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 13;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(574, 751);
            this.rjButton1.Margin = new System.Windows.Forms.Padding(2);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(112, 32);
            this.rjButton1.TabIndex = 6;
            this.rjButton1.Text = "Iniciar Sesión";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.pctBox);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lbl_notificaciones);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_notificaciones;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblPassword;
        private Objetos.RJControls.RJTextBox txtUsuario;
        private Objetos.RJControls.RJTextBox txtPassword;
        private System.Windows.Forms.PictureBox pctBox;
        private Objetos.RJControls.RJButton rjButton1;
    }
}

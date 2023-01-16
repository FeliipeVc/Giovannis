namespace Giovannis
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel_login_inicial = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_botoneras = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_login_inicial
            // 
            this.panel_login_inicial.Location = new System.Drawing.Point(0, 0);
            this.panel_login_inicial.Name = "panel_login_inicial";
            this.panel_login_inicial.Size = new System.Drawing.Size(1920, 1080);
            this.panel_login_inicial.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel_login_inicial);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(324, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1596, 1061);
            this.panel1.TabIndex = 6;
            // 
            // pnl_botoneras
            // 
            this.pnl_botoneras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.pnl_botoneras.Location = new System.Drawing.Point(0, 0);
            this.pnl_botoneras.Name = "pnl_botoneras";
            this.pnl_botoneras.Size = new System.Drawing.Size(324, 1080);
            this.pnl_botoneras.TabIndex = 7;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1920, 1061);
            this.Controls.Add(this.pnl_botoneras);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Giovanni\'s";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_login_inicial;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_botoneras;
    }
}


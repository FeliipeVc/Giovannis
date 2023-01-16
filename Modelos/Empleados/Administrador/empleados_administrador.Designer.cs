namespace Giovannis.Modelos.Empleados.Administrador
{
    partial class empleados_administrador
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
            this.flw_pedidos = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.bto_add_empleado = new Objetos.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // flw_pedidos
            // 
            this.flw_pedidos.AutoScroll = false;
            this.flw_pedidos.Location = new System.Drawing.Point(82, 200);
            this.flw_pedidos.Name = "flw_pedidos";
            this.flw_pedidos.Size = new System.Drawing.Size(1450, 881);
            this.flw_pedidos.TabIndex = 11;
            this.flw_pedidos.VerticalScroll.Maximum = 0;
            this.flw_pedidos.AutoScroll = true;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 80.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(62, 37);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(597, 120);
            this.lbl_titulo.TabIndex = 10;
            this.lbl_titulo.Text = "Empleados";
            // 
            // bto_add_empleado
            // 
            this.bto_add_empleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bto_add_empleado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bto_add_empleado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bto_add_empleado.BorderRadius = 10;
            this.bto_add_empleado.BorderSize = 5;
            this.bto_add_empleado.FlatAppearance.BorderSize = 0;
            this.bto_add_empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bto_add_empleado.ForeColor = System.Drawing.Color.Black;
            this.bto_add_empleado.Location = new System.Drawing.Point(1323, 114);
            this.bto_add_empleado.Name = "bto_add_empleado";
            this.bto_add_empleado.Size = new System.Drawing.Size(165, 60);
            this.bto_add_empleado.TabIndex = 12;
            this.bto_add_empleado.Text = "AÑADIR";
            this.bto_add_empleado.TextColor = System.Drawing.Color.Black;
            this.bto_add_empleado.UseVisualStyleBackColor = false;
            this.bto_add_empleado.Click += new System.EventHandler(this.bto_add_empleado_Click);
            // 
            // empleados_administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.Controls.Add(this.bto_add_empleado);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.flw_pedidos);
            this.Name = "empleados_administrador";
            this.Size = new System.Drawing.Size(1596, 1080);
            this.Load += new System.EventHandler(this.empleados_administrador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flw_pedidos;
        private System.Windows.Forms.Label lbl_titulo;
        private Objetos.RJControls.RJButton bto_add_empleado;
    }
}

namespace Giovannis.Modelos.Promociones.Administrador
{
    partial class promociones_administrador
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
            this.lbl_notificaciones = new System.Windows.Forms.Label();
            this.flw_promociones = new System.Windows.Forms.FlowLayoutPanel();
            this.bto_add_promocion = new Objetos.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // lbl_notificaciones
            // 
            this.lbl_notificaciones.AutoSize = true;
            this.lbl_notificaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Bold);
            this.lbl_notificaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.lbl_notificaciones.Location = new System.Drawing.Point(45, 52);
            this.lbl_notificaciones.Name = "lbl_notificaciones";
            this.lbl_notificaciones.Size = new System.Drawing.Size(689, 120);
            this.lbl_notificaciones.TabIndex = 3;
            this.lbl_notificaciones.Text = "Promociones";
            // 
            // flw_promociones
            // 
            this.flw_promociones.AutoScroll = false;
            this.flw_promociones.Location = new System.Drawing.Point(82, 200);
            this.flw_promociones.Name = "flw_promociones";
            this.flw_promociones.Size = new System.Drawing.Size(1450, 787);
            this.flw_promociones.TabIndex = 4;
            this.flw_promociones.Paint += new System.Windows.Forms.PaintEventHandler(this.flw_promociones_Paint);
            this.flw_promociones.VerticalScroll.Maximum = 0;
            this.flw_promociones.AutoScroll = true;
            // 
            // bto_add_promocion
            // 
            this.bto_add_promocion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bto_add_promocion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bto_add_promocion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bto_add_promocion.BorderRadius = 10;
            this.bto_add_promocion.BorderSize = 5;
            this.bto_add_promocion.FlatAppearance.BorderSize = 0;
            this.bto_add_promocion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bto_add_promocion.ForeColor = System.Drawing.Color.Black;
            this.bto_add_promocion.Location = new System.Drawing.Point(1323, 114);
            this.bto_add_promocion.Name = "bto_add_promocion";
            this.bto_add_promocion.Size = new System.Drawing.Size(165, 60);
            this.bto_add_promocion.TabIndex = 5;
            this.bto_add_promocion.Text = "AÑADIR";
            this.bto_add_promocion.TextColor = System.Drawing.Color.Black;
            this.bto_add_promocion.UseVisualStyleBackColor = false;
            this.bto_add_promocion.Click += new System.EventHandler(this.bto_add_promocion_Click);
            // 
            // promociones_administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.Controls.Add(this.bto_add_promocion);
            this.Controls.Add(this.flw_promociones);
            this.Controls.Add(this.lbl_notificaciones);
            this.Name = "promociones_administrador";
            this.Size = new System.Drawing.Size(1596, 1080);
            this.Load += new System.EventHandler(this.promociones_administrador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_notificaciones;
        private System.Windows.Forms.FlowLayoutPanel flw_promociones;
        private Objetos.RJControls.RJButton bto_add_promocion;
    }
}

namespace Giovannis.Modelos.Promociones.Administrador
{
    partial class promocion_administrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(promocion_administrador));
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.bto_editar_codigo = new Objetos.RJControls.RJButton();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.bto_activar = new Objetos.RJControls.RJToggleButton();
            this.lbl_cod = new System.Windows.Forms.Label();
            this.bto_editar = new System.Windows.Forms.PictureBox();
            this.bto_borrar = new System.Windows.Forms.PictureBox();
            this.lbl_descuento = new System.Windows.Forms.Label();
            this.lbl_porcentaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bto_editar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bto_borrar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Font = new System.Drawing.Font("Microsoft Yi Baiti", 30F);
            this.lbl_codigo.ForeColor = System.Drawing.Color.White;
            this.lbl_codigo.Location = new System.Drawing.Point(134, 25);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(341, 40);
            this.lbl_codigo.TabIndex = 6;
            this.lbl_codigo.Text = "(Código Promocional)";
            // 
            // bto_editar_codigo
            // 
            this.bto_editar_codigo.BackColor = System.Drawing.Color.LimeGreen;
            this.bto_editar_codigo.BackgroundColor = System.Drawing.Color.LimeGreen;
            this.bto_editar_codigo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bto_editar_codigo.BorderRadius = 20;
            this.bto_editar_codigo.BorderSize = 0;
            this.bto_editar_codigo.FlatAppearance.BorderSize = 0;
            this.bto_editar_codigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bto_editar_codigo.ForeColor = System.Drawing.Color.White;
            this.bto_editar_codigo.Location = new System.Drawing.Point(466, 25);
            this.bto_editar_codigo.Name = "bto_editar_codigo";
            this.bto_editar_codigo.Size = new System.Drawing.Size(150, 40);
            this.bto_editar_codigo.TabIndex = 7;
            this.bto_editar_codigo.Text = "Editar Código";
            this.bto_editar_codigo.TextColor = System.Drawing.Color.White;
            this.bto_editar_codigo.UseVisualStyleBackColor = false;
            this.bto_editar_codigo.Click += new System.EventHandler(this.bto_editar_codigo_Click);
            // 
            // lbl_status
            // 
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Yi Baiti", 30F);
            this.lbl_status.ForeColor = System.Drawing.Color.White;
            this.lbl_status.Location = new System.Drawing.Point(935, 25);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(115, 40);
            this.lbl_status.TabIndex = 9;
            this.lbl_status.Text = "Status:  ";
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Font = new System.Drawing.Font("Microsoft Yi Baiti", 30F);
            this.lbl_estado.ForeColor = System.Drawing.Color.White;
            this.lbl_estado.Location = new System.Drawing.Point(1044, 25);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(99, 40);
            this.lbl_estado.TabIndex = 10;
            this.lbl_estado.Text = "Activo";
            // 
            // bto_activar
            // 
            this.bto_activar.Location = new System.Drawing.Point(1149, 27);
            this.bto_activar.MinimumSize = new System.Drawing.Size(45, 22);
            this.bto_activar.Name = "bto_activar";
            this.bto_activar.OffBackColor = System.Drawing.Color.Gray;
            this.bto_activar.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.bto_activar.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.bto_activar.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.bto_activar.Size = new System.Drawing.Size(80, 40);
            this.bto_activar.TabIndex = 11;
            this.bto_activar.UseVisualStyleBackColor = true;
            this.bto_activar.CheckedChanged += new System.EventHandler(this.bto_activar_CheckedChanged);
            // 
            // lbl_cod
            // 
            this.lbl_cod.AutoSize = true;
            this.lbl_cod.Font = new System.Drawing.Font("Microsoft Yi Baiti", 30F);
            this.lbl_cod.ForeColor = System.Drawing.Color.White;
            this.lbl_cod.Location = new System.Drawing.Point(13, 25);
            this.lbl_cod.Name = "lbl_cod";
            this.lbl_cod.Size = new System.Drawing.Size(124, 40);
            this.lbl_cod.TabIndex = 12;
            this.lbl_cod.Text = "Código:";
            // 
            // bto_editar
            // 
            this.bto_editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bto_editar.Image = ((System.Drawing.Image)(resources.GetObject("bto_editar.Image")));
            this.bto_editar.Location = new System.Drawing.Point(1322, 12);
            this.bto_editar.Name = "bto_editar";
            this.bto_editar.Size = new System.Drawing.Size(76, 65);
            this.bto_editar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bto_editar.TabIndex = 14;
            this.bto_editar.TabStop = false;
            this.bto_editar.Click += new System.EventHandler(this.bto_editar_Click);
            // 
            // bto_borrar
            // 
            this.bto_borrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bto_borrar.Image = ((System.Drawing.Image)(resources.GetObject("bto_borrar.Image")));
            this.bto_borrar.Location = new System.Drawing.Point(1253, 12);
            this.bto_borrar.Name = "bto_borrar";
            this.bto_borrar.Size = new System.Drawing.Size(63, 66);
            this.bto_borrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bto_borrar.TabIndex = 13;
            this.bto_borrar.TabStop = false;
            this.bto_borrar.Click += new System.EventHandler(this.bto_borrar_Click);
            // 
            // lbl_descuento
            // 
            this.lbl_descuento.AutoSize = true;
            this.lbl_descuento.Font = new System.Drawing.Font("Microsoft Yi Baiti", 30F);
            this.lbl_descuento.ForeColor = System.Drawing.Color.White;
            this.lbl_descuento.Location = new System.Drawing.Point(622, 25);
            this.lbl_descuento.Name = "lbl_descuento";
            this.lbl_descuento.Size = new System.Drawing.Size(172, 40);
            this.lbl_descuento.TabIndex = 15;
            this.lbl_descuento.Text = "Descuento:";
            // 
            // lbl_porcentaje
            // 
            this.lbl_porcentaje.AutoSize = true;
            this.lbl_porcentaje.Font = new System.Drawing.Font("Microsoft Yi Baiti", 30F);
            this.lbl_porcentaje.ForeColor = System.Drawing.Color.White;
            this.lbl_porcentaje.Location = new System.Drawing.Point(787, 25);
            this.lbl_porcentaje.Name = "lbl_porcentaje";
            this.lbl_porcentaje.Size = new System.Drawing.Size(124, 40);
            this.lbl_porcentaje.TabIndex = 16;
            this.lbl_porcentaje.Text = "Código:";
            // 
            // promocion_administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.lbl_porcentaje);
            this.Controls.Add(this.lbl_descuento);
            this.Controls.Add(this.bto_editar);
            this.Controls.Add(this.bto_borrar);
            this.Controls.Add(this.lbl_cod);
            this.Controls.Add(this.bto_activar);
            this.Controls.Add(this.lbl_estado);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.bto_editar_codigo);
            this.Controls.Add(this.lbl_codigo);
            this.Name = "promocion_administrador";
            this.Size = new System.Drawing.Size(1400, 90);
            ((System.ComponentModel.ISupportInitialize)(this.bto_editar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bto_borrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_codigo;
        private Objetos.RJControls.RJButton bto_editar_codigo;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_estado;
        private Objetos.RJControls.RJToggleButton bto_activar;
        private System.Windows.Forms.Label lbl_cod;
        private System.Windows.Forms.PictureBox bto_borrar;
        private System.Windows.Forms.PictureBox bto_editar;
        private System.Windows.Forms.Label lbl_descuento;
        private System.Windows.Forms.Label lbl_porcentaje;
    }
}

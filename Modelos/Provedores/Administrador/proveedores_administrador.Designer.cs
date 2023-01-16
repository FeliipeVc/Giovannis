namespace Giovannis.Modelos.Provedores.Administrador
{
    partial class proveedores_administrador
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
            this.flw_proveedores = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_proveedores = new System.Windows.Forms.Label();
            this.bttn_add = new Objetos.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // flw_proveedores
            // 
            this.flw_proveedores.AutoScroll = false;
            this.flw_proveedores.Location = new System.Drawing.Point(82, 200);
            this.flw_proveedores.Name = "flw_proveedores";
            this.flw_proveedores.Size = new System.Drawing.Size(1450, 787);
            this.flw_proveedores.TabIndex = 6;
            this.flw_proveedores.VerticalScroll.Maximum = 0;
            this.flw_proveedores.AutoScroll = true;            // 
            // lbl_proveedores
            // 
            this.lbl_proveedores.AutoSize = true;
            this.lbl_proveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Bold);
            this.lbl_proveedores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.lbl_proveedores.Location = new System.Drawing.Point(62, 37);
            this.lbl_proveedores.Name = "lbl_proveedores";
            this.lbl_proveedores.Size = new System.Drawing.Size(672, 120);
            this.lbl_proveedores.TabIndex = 5;
            this.lbl_proveedores.Text = "Proveedores";
            // 
            // bttn_add
            // 
            this.bttn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bttn_add.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bttn_add.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bttn_add.BorderRadius = 10;
            this.bttn_add.BorderSize = 5;
            this.bttn_add.FlatAppearance.BorderSize = 0;
            this.bttn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_add.ForeColor = System.Drawing.Color.Black;
            this.bttn_add.Location = new System.Drawing.Point(1323, 114);
            this.bttn_add.Name = "bttn_add";
            this.bttn_add.Size = new System.Drawing.Size(165, 60);
            this.bttn_add.TabIndex = 7;
            this.bttn_add.Text = "Añadir";
            this.bttn_add.TextColor = System.Drawing.Color.Black;
            this.bttn_add.UseVisualStyleBackColor = false;
            this.bttn_add.Click += new System.EventHandler(this.bttn_add_Click);
            // 
            // proveedores_administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.Controls.Add(this.bttn_add);
            this.Controls.Add(this.flw_proveedores);
            this.Controls.Add(this.lbl_proveedores);
            this.Name = "proveedores_administrador";
            this.Size = new System.Drawing.Size(1596, 1080);
            this.Load += new System.EventHandler(this.proveedores_administrador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flw_proveedores;
        private System.Windows.Forms.Label lbl_proveedores;
        private Objetos.RJControls.RJButton bttn_add;
    }
}

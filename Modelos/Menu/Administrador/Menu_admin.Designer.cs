namespace Giovannis.Modelos.Menu.Administrador
{
    partial class Menu_admin
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
            this.label16 = new System.Windows.Forms.Label();
            this.flw_menus = new System.Windows.Forms.FlowLayoutPanel();
            this.bttnAdd = new Objetos.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 80.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(62, 37);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(378, 120);
            this.label16.TabIndex = 8;
            this.label16.Text = "Menús";
            // 
            // flw_menus
            // 
            this.flw_menus.AutoScroll = true;
            this.flw_menus.Location = new System.Drawing.Point(82, 200);
            this.flw_menus.Name = "flw_menus";
            this.flw_menus.Size = new System.Drawing.Size(1450, 881);
            this.flw_menus.TabIndex = 9;
            this.flw_menus.AutoScroll = false;
            this.flw_menus.VerticalScroll.Maximum = 0;
            this.flw_menus.AutoScroll = true;
            // 
            // bttnAdd
            // 
            this.bttnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bttnAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bttnAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bttnAdd.BorderRadius = 10;
            this.bttnAdd.BorderSize = 5;
            this.bttnAdd.FlatAppearance.BorderSize = 0;
            this.bttnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAdd.ForeColor = System.Drawing.Color.Black;
            this.bttnAdd.Location = new System.Drawing.Point(1323, 114);
            this.bttnAdd.Name = "bttnAdd";
            this.bttnAdd.Size = new System.Drawing.Size(165, 60);
            this.bttnAdd.TabIndex = 12;
            this.bttnAdd.Text = "Añadir";
            this.bttnAdd.TextColor = System.Drawing.Color.Black;
            this.bttnAdd.UseVisualStyleBackColor = false;
            this.bttnAdd.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // Menu_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.Controls.Add(this.bttnAdd);
            this.Controls.Add(this.flw_menus);
            this.Controls.Add(this.label16);
            this.Name = "Menu_admin";
            this.Size = new System.Drawing.Size(1596, 1080);
            this.Load += new System.EventHandler(this.Menu_admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.FlowLayoutPanel flw_menus;
        private Objetos.RJControls.RJButton bttnAdd;
    }
}

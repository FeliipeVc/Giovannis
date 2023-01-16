namespace Giovannis.Modelos.Stock.Administrador
{
    partial class stock_add_administrador
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
            this.bttn_update = new Objetos.RJControls.RJButton();
            this.lst_nombres = new System.Windows.Forms.ListBox();
            this.lbl_proveedor = new System.Windows.Forms.Label();
            this.txt_cantidad = new Objetos.RJControls.RJTextBox();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.txt_nombre = new Objetos.RJControls.RJTextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_notificaciones
            // 
            this.lbl_notificaciones.AutoSize = true;
            this.lbl_notificaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Bold);
            this.lbl_notificaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.lbl_notificaciones.Location = new System.Drawing.Point(90, 74);
            this.lbl_notificaciones.Name = "lbl_notificaciones";
            this.lbl_notificaciones.Size = new System.Drawing.Size(959, 120);
            this.lbl_notificaciones.TabIndex = 7;
            this.lbl_notificaciones.Text = "Stock Ingredientes";
            // 
            // bttn_update
            // 
            this.bttn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bttn_update.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bttn_update.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bttn_update.BorderRadius = 10;
            this.bttn_update.BorderSize = 5;
            this.bttn_update.FlatAppearance.BorderSize = 0;
            this.bttn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_update.ForeColor = System.Drawing.Color.Black;
            this.bttn_update.Location = new System.Drawing.Point(721, 786);
            this.bttn_update.Name = "bttn_update";
            this.bttn_update.Size = new System.Drawing.Size(165, 50);
            this.bttn_update.TabIndex = 22;
            this.bttn_update.Text = "Añadir";
            this.bttn_update.TextColor = System.Drawing.Color.Black;
            this.bttn_update.UseVisualStyleBackColor = false;
            this.bttn_update.Click += new System.EventHandler(this.bttn_update_Click);
            // 
            // lst_nombres
            // 
            this.lst_nombres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.lst_nombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.lst_nombres.ForeColor = System.Drawing.SystemColors.Info;
            this.lst_nombres.FormattingEnabled = true;
            this.lst_nombres.ItemHeight = 20;
            this.lst_nombres.Location = new System.Drawing.Point(568, 572);
            this.lst_nombres.Name = "lst_nombres";
            this.lst_nombres.Size = new System.Drawing.Size(461, 184);
            this.lst_nombres.TabIndex = 21;
            // 
            // lbl_proveedor
            // 
            this.lbl_proveedor.AutoSize = true;
            this.lbl_proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_proveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.lbl_proveedor.Location = new System.Drawing.Point(705, 519);
            this.lbl_proveedor.Name = "lbl_proveedor";
            this.lbl_proveedor.Size = new System.Drawing.Size(208, 25);
            this.lbl_proveedor.TabIndex = 20;
            this.lbl_proveedor.Text = "Nuevo  Proveedor:";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_cantidad.BorderColor = System.Drawing.Color.Red;
            this.txt_cantidad.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_cantidad.BorderRadius = 10;
            this.txt_cantidad.BorderSize = 2;
            this.txt_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.txt_cantidad.Location = new System.Drawing.Point(568, 423);
            this.txt_cantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cantidad.Multiline = false;
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Padding = new System.Windows.Forms.Padding(7);
            this.txt_cantidad.PasswordChar = false;
            this.txt_cantidad.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.txt_cantidad.PlaceholderText = "";
            this.txt_cantidad.Size = new System.Drawing.Size(461, 31);
            this.txt_cantidad.TabIndex = 19;
            this.txt_cantidad.Texts = "";
            this.txt_cantidad.UnderlinedStyle = false;
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.lbl_cantidad.Location = new System.Drawing.Point(705, 376);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(187, 25);
            this.lbl_cantidad.TabIndex = 18;
            this.lbl_cantidad.Text = "Nueva Cantidad:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_nombre.BorderColor = System.Drawing.Color.Red;
            this.txt_nombre.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_nombre.BorderRadius = 10;
            this.txt_nombre.BorderSize = 2;
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.txt_nombre.Location = new System.Drawing.Point(568, 290);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombre.Multiline = false;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Padding = new System.Windows.Forms.Padding(7);
            this.txt_nombre.PasswordChar = false;
            this.txt_nombre.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.txt_nombre.PlaceholderText = "";
            this.txt_nombre.Size = new System.Drawing.Size(461, 31);
            this.txt_nombre.TabIndex = 17;
            this.txt_nombre.Texts = "";
            this.txt_nombre.UnderlinedStyle = false;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.lbl_nombre.Location = new System.Drawing.Point(705, 246);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(181, 25);
            this.lbl_nombre.TabIndex = 16;
            this.lbl_nombre.Text = "Nuevo  Nombre:";
            // 
            // stock_add_administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.Controls.Add(this.bttn_update);
            this.Controls.Add(this.lst_nombres);
            this.Controls.Add(this.lbl_proveedor);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.lbl_cantidad);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.lbl_notificaciones);
            this.Name = "stock_add_administrador";
            this.Size = new System.Drawing.Size(1596, 1080);
            this.Load += new System.EventHandler(this.stock_add_administrador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_notificaciones;
        private Objetos.RJControls.RJButton bttn_update;
        private System.Windows.Forms.ListBox lst_nombres;
        private System.Windows.Forms.Label lbl_proveedor;
        private Objetos.RJControls.RJTextBox txt_cantidad;
        private System.Windows.Forms.Label lbl_cantidad;
        private Objetos.RJControls.RJTextBox txt_nombre;
        private System.Windows.Forms.Label lbl_nombre;
    }
}

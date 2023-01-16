namespace Giovannis.Modelos.Pedidos.Administrador
{
    partial class Pedidos_panel_admin
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pedidos_panel_admin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.editar = new System.Windows.Forms.PictureBox();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.lbl_empleado = new System.Windows.Forms.Label();
            this.lbl_nombre_menu = new System.Windows.Forms.Label();
            this.lbl_cliente = new System.Windows.Forms.Label();
            this.lbl_tienda = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_id_pedido = new System.Windows.Forms.Label();
            this.bttnDelete = new Objetos.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(62, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(510, 340);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // editar
            // 
            this.editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editar.Image = ((System.Drawing.Image)(resources.GetObject("editar.Image")));
            this.editar.InitialImage = null;
            this.editar.Location = new System.Drawing.Point(1323, 57);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(69, 41);
            this.editar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.editar.TabIndex = 38;
            this.editar.TabStop = false;
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precio.ForeColor = System.Drawing.Color.White;
            this.lbl_precio.Location = new System.Drawing.Point(958, 353);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(64, 24);
            this.lbl_precio.TabIndex = 37;
            this.lbl_precio.Text = "Precio";
            // 
            // lbl_empleado
            // 
            this.lbl_empleado.AutoSize = true;
            this.lbl_empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_empleado.ForeColor = System.Drawing.Color.White;
            this.lbl_empleado.Location = new System.Drawing.Point(958, 212);
            this.lbl_empleado.Name = "lbl_empleado";
            this.lbl_empleado.Size = new System.Drawing.Size(97, 24);
            this.lbl_empleado.TabIndex = 36;
            this.lbl_empleado.Text = "Empleado";
            // 
            // lbl_nombre_menu
            // 
            this.lbl_nombre_menu.AutoSize = true;
            this.lbl_nombre_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_menu.ForeColor = System.Drawing.Color.White;
            this.lbl_nombre_menu.Location = new System.Drawing.Point(958, 304);
            this.lbl_nombre_menu.Name = "lbl_nombre_menu";
            this.lbl_nombre_menu.Size = new System.Drawing.Size(133, 24);
            this.lbl_nombre_menu.TabIndex = 35;
            this.lbl_nombre_menu.Text = "Nombre menú";
            // 
            // lbl_cliente
            // 
            this.lbl_cliente.AutoSize = true;
            this.lbl_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cliente.ForeColor = System.Drawing.Color.White;
            this.lbl_cliente.Location = new System.Drawing.Point(959, 259);
            this.lbl_cliente.Name = "lbl_cliente";
            this.lbl_cliente.Size = new System.Drawing.Size(68, 24);
            this.lbl_cliente.TabIndex = 34;
            this.lbl_cliente.Text = "Cliente";
            // 
            // lbl_tienda
            // 
            this.lbl_tienda.AutoSize = true;
            this.lbl_tienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tienda.ForeColor = System.Drawing.Color.White;
            this.lbl_tienda.Location = new System.Drawing.Point(958, 167);
            this.lbl_tienda.Name = "lbl_tienda";
            this.lbl_tienda.Size = new System.Drawing.Size(69, 24);
            this.lbl_tienda.TabIndex = 33;
            this.lbl_tienda.Text = "Tienda";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.ForeColor = System.Drawing.Color.White;
            this.lbl_fecha.Location = new System.Drawing.Point(958, 122);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(186, 24);
            this.lbl_fecha.TabIndex = 32;
            this.lbl_fecha.Text = "Fecha de realización";
            // 
            // lbl_id_pedido
            // 
            this.lbl_id_pedido.AutoSize = true;
            this.lbl_id_pedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id_pedido.ForeColor = System.Drawing.Color.White;
            this.lbl_id_pedido.Location = new System.Drawing.Point(956, 57);
            this.lbl_id_pedido.Name = "lbl_id_pedido";
            this.lbl_id_pedido.Size = new System.Drawing.Size(291, 31);
            this.lbl_id_pedido.TabIndex = 31;
            this.lbl_id_pedido.Text = "Pedido: Nº(id pedido)";
            // 
            // bttnDelete
            // 
            this.bttnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bttnDelete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bttnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttnDelete.BackgroundImage")));
            this.bttnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttnDelete.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bttnDelete.BorderRadius = 0;
            this.bttnDelete.BorderSize = 0;
            this.bttnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnDelete.FlatAppearance.BorderSize = 0;
            this.bttnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.bttnDelete.ForeColor = System.Drawing.Color.Black;
            this.bttnDelete.Location = new System.Drawing.Point(1313, 107);
            this.bttnDelete.Name = "bttnDelete";
            this.bttnDelete.Size = new System.Drawing.Size(87, 39);
            this.bttnDelete.TabIndex = 39;
            this.bttnDelete.TextColor = System.Drawing.Color.Black;
            this.bttnDelete.UseVisualStyleBackColor = false;
            this.bttnDelete.Click += new System.EventHandler(this.bttnDelete_Click);
            // 
            // Pedidos_panel_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.bttnDelete);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.lbl_precio);
            this.Controls.Add(this.lbl_empleado);
            this.Controls.Add(this.lbl_nombre_menu);
            this.Controls.Add(this.lbl_cliente);
            this.Controls.Add(this.lbl_tienda);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.lbl_id_pedido);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Pedidos_panel_admin";
            this.Size = new System.Drawing.Size(1400, 440);
            this.Load += new System.EventHandler(this.Pedidos_panel_admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox editar;
        private System.Windows.Forms.Label lbl_precio;
        private System.Windows.Forms.Label lbl_empleado;
        private System.Windows.Forms.Label lbl_nombre_menu;
        private System.Windows.Forms.Label lbl_cliente;
        private System.Windows.Forms.Label lbl_tienda;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label lbl_id_pedido;
        private Objetos.RJControls.RJButton bttnDelete;
    }
}

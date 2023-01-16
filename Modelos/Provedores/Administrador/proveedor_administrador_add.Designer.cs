namespace Giovannis.Modelos.Provedores.Administrador
{
    partial class proveedor_administrador_add
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
            this.lbl_proveedores = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_newProveedor = new Objetos.RJControls.RJTextBox();
            this.bttn_add = new Objetos.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // lbl_proveedores
            // 
            this.lbl_proveedores.AutoSize = true;
            this.lbl_proveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Bold);
            this.lbl_proveedores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.lbl_proveedores.Location = new System.Drawing.Point(50, 50);
            this.lbl_proveedores.Name = "lbl_proveedores";
            this.lbl_proveedores.Size = new System.Drawing.Size(672, 120);
            this.lbl_proveedores.TabIndex = 6;
            this.lbl_proveedores.Text = "Proveedores";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.label1.Location = new System.Drawing.Point(512, 446);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Introduce el nombre del NUEVO proveedor:";
            // 
            // txt_newProveedor
            // 
            this.txt_newProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_newProveedor.BorderColor = System.Drawing.Color.Red;
            this.txt_newProveedor.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_newProveedor.BorderRadius = 10;
            this.txt_newProveedor.BorderSize = 2;
            this.txt_newProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_newProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.txt_newProveedor.Location = new System.Drawing.Point(517, 506);
            this.txt_newProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.txt_newProveedor.Multiline = false;
            this.txt_newProveedor.Name = "txt_newProveedor";
            this.txt_newProveedor.Padding = new System.Windows.Forms.Padding(7);
            this.txt_newProveedor.PasswordChar = false;
            this.txt_newProveedor.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.txt_newProveedor.PlaceholderText = "";
            this.txt_newProveedor.Size = new System.Drawing.Size(461, 31);
            this.txt_newProveedor.TabIndex = 8;
            this.txt_newProveedor.Texts = "";
            this.txt_newProveedor.UnderlinedStyle = false;
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
            this.bttn_add.Location = new System.Drawing.Point(670, 567);
            this.bttn_add.Name = "bttn_add";
            this.bttn_add.Size = new System.Drawing.Size(165, 50);
            this.bttn_add.TabIndex = 9;
            this.bttn_add.Text = "Añadir";
            this.bttn_add.TextColor = System.Drawing.Color.Black;
            this.bttn_add.UseVisualStyleBackColor = false;
            this.bttn_add.Click += new System.EventHandler(this.bttn_add_Click);
            // 
            // proveedor_administrador_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.Controls.Add(this.bttn_add);
            this.Controls.Add(this.txt_newProveedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_proveedores);
            this.Name = "proveedor_administrador_add";
            this.Size = new System.Drawing.Size(1596, 1080);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_proveedores;
        private System.Windows.Forms.Label label1;
        private Objetos.RJControls.RJTextBox txt_newProveedor;
        private Objetos.RJControls.RJButton bttn_add;
    }
}

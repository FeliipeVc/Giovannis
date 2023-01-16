namespace Giovannis.Modelos.Pedidos.Administrador
{
    partial class Pedidos_admin
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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.flw_pedidos = new System.Windows.Forms.FlowLayoutPanel();
            this.bttnAdd = new Objetos.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 80.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(62, 37);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(446, 120);
            this.lbl_titulo.TabIndex = 10;
            this.lbl_titulo.Text = "Pedidos";
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
            this.bttnAdd.Location = new System.Drawing.Point(1318, 115);
            this.bttnAdd.Name = "bttnAdd";
            this.bttnAdd.Size = new System.Drawing.Size(165, 60);
            this.bttnAdd.TabIndex = 13;
            this.bttnAdd.Text = "Añadir";
            this.bttnAdd.TextColor = System.Drawing.Color.Black;
            this.bttnAdd.UseVisualStyleBackColor = false;
            this.bttnAdd.Click += new System.EventHandler(this.bttnAdd_Click);
            // 
            // Pedidos_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.Controls.Add(this.bttnAdd);
            this.Controls.Add(this.flw_pedidos);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "Pedidos_admin";
            this.Size = new System.Drawing.Size(1596, 1080);
            this.Load += new System.EventHandler(this.Pedidos_admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.FlowLayoutPanel flw_pedidos;
        private Objetos.RJControls.RJButton bttnAdd;
    }
}

namespace Giovannis.Modelos.Nominas
{
    partial class rectangulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rectangulo));
            this.lbl_n = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_salario = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_n
            // 
            this.lbl_n.AutoSize = true;
            this.lbl_n.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_n.Font = new System.Drawing.Font("Microsoft Yi Baiti", 26F);
            this.lbl_n.ForeColor = System.Drawing.Color.White;
            this.lbl_n.Location = new System.Drawing.Point(17, 27);
            this.lbl_n.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_n.Name = "lbl_n";
            this.lbl_n.Size = new System.Drawing.Size(118, 35);
            this.lbl_n.TabIndex = 0;
            this.lbl_n.Text = "Nombre:";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft Yi Baiti", 26F);
            this.lbl_nombre.ForeColor = System.Drawing.Color.White;
            this.lbl_nombre.Location = new System.Drawing.Point(130, 27);
            this.lbl_nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(90, 35);
            this.lbl_nombre.TabIndex = 1;
            this.lbl_nombre.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 26F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(307, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Yi Baiti", 26F);
            this.lbl_id.ForeColor = System.Drawing.Color.White;
            this.lbl_id.Location = new System.Drawing.Point(360, 27);
            this.lbl_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(90, 35);
            this.lbl_id.TabIndex = 3;
            this.lbl_id.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Yi Baiti", 26F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(571, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 35);
            this.label2.TabIndex = 4;
            this.label2.Text = "Salario:";
            // 
            // lbl_salario
            // 
            this.lbl_salario.AutoSize = true;
            this.lbl_salario.Font = new System.Drawing.Font("Microsoft Yi Baiti", 26F);
            this.lbl_salario.ForeColor = System.Drawing.Color.White;
            this.lbl_salario.Location = new System.Drawing.Point(682, 27);
            this.lbl_salario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_salario.Name = "lbl_salario";
            this.lbl_salario.Size = new System.Drawing.Size(90, 35);
            this.lbl_salario.TabIndex = 5;
            this.lbl_salario.Text = "label3";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1288, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // rectangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbl_salario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.lbl_n);
            this.Name = "rectangulo";
            this.Size = new System.Drawing.Size(1400, 90);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_n;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_salario;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

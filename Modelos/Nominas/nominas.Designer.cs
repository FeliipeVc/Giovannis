namespace Giovannis.Modelos.Nominas
{
    partial class nominas
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
            this.flw_nominas = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_nominas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flw_nominas
            // 
            this.flw_nominas.AutoScroll = true;
            this.flw_nominas.Location = new System.Drawing.Point(82, 200);
            this.flw_nominas.Name = "flw_nominas";
            this.flw_nominas.Size = new System.Drawing.Size(1450, 787);
            this.flw_nominas.TabIndex = 4;
            // 
            // lbl_nominas
            // 
            this.lbl_nominas.AutoSize = true;
            this.lbl_nominas.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Bold);
            this.lbl_nominas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.lbl_nominas.Location = new System.Drawing.Point(62, 37);
            this.lbl_nominas.Name = "lbl_nominas";
            this.lbl_nominas.Size = new System.Drawing.Size(481, 120);
            this.lbl_nominas.TabIndex = 5;
            this.lbl_nominas.Text = "Nominas";
            // 
            // nominas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.Controls.Add(this.lbl_nominas);
            this.Controls.Add(this.flw_nominas);
            this.Name = "nominas";
            this.Size = new System.Drawing.Size(1596, 1080);
            this.Load += new System.EventHandler(this.nominas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flw_nominas;
        private System.Windows.Forms.Label lbl_nominas;
    }
}

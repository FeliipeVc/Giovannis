﻿namespace Giovannis.Modelos.Horarios.Adminstrador
{
    partial class HorarioAdmin
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
            this.flw_Horarios_Admin = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_horarios = new System.Windows.Forms.Label();
            this.lbl_hSalida = new System.Windows.Forms.Label();
            this.lbl_NyC = new System.Windows.Forms.Label();
            this.lbl_hEntrada = new System.Windows.Forms.Label();
            this.lbl_TotalHoras = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flw_Horarios_Admin
            //
            
            this.flw_Horarios_Admin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flw_Horarios_Admin.AutoScroll = false;
            this.flw_Horarios_Admin.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flw_Horarios_Admin.Location = new System.Drawing.Point(52, 244);
            this.flw_Horarios_Admin.Margin = new System.Windows.Forms.Padding(2);
            this.flw_Horarios_Admin.Name = "flw_Horarios_Admin";
            this.flw_Horarios_Admin.Size = new System.Drawing.Size(1450, 681);
            this.flw_Horarios_Admin.TabIndex = 1;
            this.flw_Horarios_Admin.WrapContents = false;
            this.flw_Horarios_Admin.VerticalScroll.Maximum = 0;
            this.flw_Horarios_Admin.AutoScroll = true;

            // 
            // lbl_horarios
            // 
            this.lbl_horarios.AutoSize = true;
            this.lbl_horarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Bold);
            this.lbl_horarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.lbl_horarios.Location = new System.Drawing.Point(62, 37);
            this.lbl_horarios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_horarios.Name = "lbl_horarios";
            this.lbl_horarios.Size = new System.Drawing.Size(884, 120);
            this.lbl_horarios.TabIndex = 0;
            this.lbl_horarios.Text = "Horarios y turnos";
            this.lbl_horarios.Click += new System.EventHandler(this.lbl_horarios_Click);
            // 
            // lbl_hSalida
            // 
            this.lbl_hSalida.AutoSize = true;
            this.lbl_hSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hSalida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.lbl_hSalida.Location = new System.Drawing.Point(970, 198);
            this.lbl_hSalida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_hSalida.Name = "lbl_hSalida";
            this.lbl_hSalida.Size = new System.Drawing.Size(162, 31);
            this.lbl_hSalida.TabIndex = 4;
            this.lbl_hSalida.Text = "Hora salida";
            // 
            // lbl_NyC
            // 
            this.lbl_NyC.AutoSize = true;
            this.lbl_NyC.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NyC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.lbl_NyC.Location = new System.Drawing.Point(52, 198);
            this.lbl_NyC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_NyC.Name = "lbl_NyC";
            this.lbl_NyC.Size = new System.Drawing.Size(233, 31);
            this.lbl_NyC.TabIndex = 5;
            this.lbl_NyC.Text = "Nombre y código";
            // 
            // lbl_hEntrada
            // 
            this.lbl_hEntrada.AutoSize = true;
            this.lbl_hEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hEntrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.lbl_hEntrada.Location = new System.Drawing.Point(570, 198);
            this.lbl_hEntrada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_hEntrada.Name = "lbl_hEntrada";
            this.lbl_hEntrada.Size = new System.Drawing.Size(184, 31);
            this.lbl_hEntrada.TabIndex = 6;
            this.lbl_hEntrada.Text = "Hora entrada";
            // 
            // lbl_TotalHoras
            // 
            this.lbl_TotalHoras.AutoSize = true;
            this.lbl_TotalHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalHoras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.lbl_TotalHoras.Location = new System.Drawing.Point(1316, 198);
            this.lbl_TotalHoras.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TotalHoras.Name = "lbl_TotalHoras";
            this.lbl_TotalHoras.Size = new System.Drawing.Size(161, 31);
            this.lbl_TotalHoras.TabIndex = 7;
            this.lbl_TotalHoras.Text = "Total horas";
            // 
            // HorarioAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.Controls.Add(this.lbl_TotalHoras);
            this.Controls.Add(this.lbl_hEntrada);
            this.Controls.Add(this.lbl_NyC);
            this.Controls.Add(this.lbl_hSalida);
            this.Controls.Add(this.lbl_horarios);
            this.Controls.Add(this.flw_Horarios_Admin);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HorarioAdmin";
            this.Size = new System.Drawing.Size(1596, 1080);
            this.Load += new System.EventHandler(this.HorarioAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flw_Horarios_Admin;
        private System.Windows.Forms.Label lbl_horarios;
        private System.Windows.Forms.Label lbl_hSalida;
        private System.Windows.Forms.Label lbl_NyC;
        private System.Windows.Forms.Label lbl_hEntrada;
        private System.Windows.Forms.Label lbl_TotalHoras;
    }
}

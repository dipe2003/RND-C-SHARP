﻿namespace RND {
    partial class Inicio {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.panelMinimizado = new System.Windows.Forms.Panel();
            this.pictureBoxSalir = new System.Windows.Forms.PictureBox();
            this.pictureBoxAyuda = new System.Windows.Forms.PictureBox();
            this.pictureBoxAccesoMenu = new System.Windows.Forms.PictureBox();
            this.panelLateralIzquierdo = new System.Windows.Forms.Panel();
            this.buttonPicos = new System.Windows.Forms.Button();
            this.buttonSorteoFechas = new System.Windows.Forms.Button();
            this.buttonSorteoNumeros = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelRND = new System.Windows.Forms.Label();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.labelInicio = new System.Windows.Forms.Label();
            this.panelMinimizado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAyuda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccesoMenu)).BeginInit();
            this.panelLateralIzquierdo.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMinimizado
            // 
            this.panelMinimizado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(4)))), ((int)(((byte)(72)))));
            this.panelMinimizado.Controls.Add(this.labelInicio);
            this.panelMinimizado.Controls.Add(this.pictureBoxSalir);
            this.panelMinimizado.Controls.Add(this.pictureBoxAyuda);
            this.panelMinimizado.Controls.Add(this.pictureBoxAccesoMenu);
            this.panelMinimizado.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMinimizado.Location = new System.Drawing.Point(0, 0);
            this.panelMinimizado.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panelMinimizado.Name = "panelMinimizado";
            this.panelMinimizado.Size = new System.Drawing.Size(102, 1062);
            this.panelMinimizado.TabIndex = 2;
            // 
            // pictureBoxSalir
            // 
            this.pictureBoxSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSalir.Image = global::RND.Properties.Resources.exit_button_bg;
            this.pictureBoxSalir.Location = new System.Drawing.Point(12, 978);
            this.pictureBoxSalir.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBoxSalir.Name = "pictureBoxSalir";
            this.pictureBoxSalir.Size = new System.Drawing.Size(84, 70);
            this.pictureBoxSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSalir.TabIndex = 1;
            this.pictureBoxSalir.TabStop = false;
            this.pictureBoxSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // pictureBoxAyuda
            // 
            this.pictureBoxAyuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAyuda.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAyuda.Image")));
            this.pictureBoxAyuda.Location = new System.Drawing.Point(12, 864);
            this.pictureBoxAyuda.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBoxAyuda.Name = "pictureBoxAyuda";
            this.pictureBoxAyuda.Size = new System.Drawing.Size(84, 70);
            this.pictureBoxAyuda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAyuda.TabIndex = 1;
            this.pictureBoxAyuda.TabStop = false;
            this.pictureBoxAyuda.Click += new System.EventHandler(this.buttonAyuda_Click);
            // 
            // pictureBoxAccesoMenu
            // 
            this.pictureBoxAccesoMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAccesoMenu.Image = global::RND.Properties.Resources.dado_random;
            this.pictureBoxAccesoMenu.Location = new System.Drawing.Point(12, 92);
            this.pictureBoxAccesoMenu.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBoxAccesoMenu.Name = "pictureBoxAccesoMenu";
            this.pictureBoxAccesoMenu.Size = new System.Drawing.Size(84, 70);
            this.pictureBoxAccesoMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAccesoMenu.TabIndex = 1;
            this.pictureBoxAccesoMenu.TabStop = false;
            this.pictureBoxAccesoMenu.Click += new System.EventHandler(this.pictureBoxAccesoMenu_Click);
            // 
            // panelLateralIzquierdo
            // 
            this.panelLateralIzquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(4)))), ((int)(((byte)(72)))));
            this.panelLateralIzquierdo.Controls.Add(this.buttonPicos);
            this.panelLateralIzquierdo.Controls.Add(this.buttonSorteoFechas);
            this.panelLateralIzquierdo.Controls.Add(this.buttonSorteoNumeros);
            this.panelLateralIzquierdo.Controls.Add(this.panelLogo);
            this.panelLateralIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateralIzquierdo.Location = new System.Drawing.Point(102, 0);
            this.panelLateralIzquierdo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panelLateralIzquierdo.Name = "panelLateralIzquierdo";
            this.panelLateralIzquierdo.Size = new System.Drawing.Size(0, 1062);
            this.panelLateralIzquierdo.TabIndex = 3;
            // 
            // buttonPicos
            // 
            this.buttonPicos.BackColor = System.Drawing.Color.Transparent;
            this.buttonPicos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPicos.FlatAppearance.BorderSize = 0;
            this.buttonPicos.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPicos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPicos.ForeColor = System.Drawing.Color.White;
            this.buttonPicos.Image = global::RND.Properties.Resources.Water_Tower_48px;
            this.buttonPicos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPicos.Location = new System.Drawing.Point(18, 590);
            this.buttonPicos.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonPicos.Name = "buttonPicos";
            this.buttonPicos.Size = new System.Drawing.Size(364, 106);
            this.buttonPicos.TabIndex = 3;
            this.buttonPicos.Text = "Picos de Agua";
            this.buttonPicos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPicos.UseVisualStyleBackColor = false;
            this.buttonPicos.Click += new System.EventHandler(this.buttonPicos_Click);
            // 
            // buttonSorteoFechas
            // 
            this.buttonSorteoFechas.BackColor = System.Drawing.Color.Transparent;
            this.buttonSorteoFechas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSorteoFechas.FlatAppearance.BorderSize = 0;
            this.buttonSorteoFechas.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSorteoFechas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSorteoFechas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSorteoFechas.ForeColor = System.Drawing.Color.White;
            this.buttonSorteoFechas.Image = global::RND.Properties.Resources.rnd_date_button_bg;
            this.buttonSorteoFechas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSorteoFechas.Location = new System.Drawing.Point(18, 472);
            this.buttonSorteoFechas.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonSorteoFechas.Name = "buttonSorteoFechas";
            this.buttonSorteoFechas.Size = new System.Drawing.Size(364, 106);
            this.buttonSorteoFechas.TabIndex = 3;
            this.buttonSorteoFechas.Text = "Fechas";
            this.buttonSorteoFechas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSorteoFechas.UseVisualStyleBackColor = false;
            this.buttonSorteoFechas.Click += new System.EventHandler(this.buttonSorteoFechas_Click);
            // 
            // buttonSorteoNumeros
            // 
            this.buttonSorteoNumeros.BackColor = System.Drawing.Color.Transparent;
            this.buttonSorteoNumeros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSorteoNumeros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSorteoNumeros.FlatAppearance.BorderSize = 0;
            this.buttonSorteoNumeros.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSorteoNumeros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSorteoNumeros.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSorteoNumeros.ForeColor = System.Drawing.Color.White;
            this.buttonSorteoNumeros.Image = ((System.Drawing.Image)(resources.GetObject("buttonSorteoNumeros.Image")));
            this.buttonSorteoNumeros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSorteoNumeros.Location = new System.Drawing.Point(18, 354);
            this.buttonSorteoNumeros.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonSorteoNumeros.Name = "buttonSorteoNumeros";
            this.buttonSorteoNumeros.Size = new System.Drawing.Size(364, 106);
            this.buttonSorteoNumeros.TabIndex = 3;
            this.buttonSorteoNumeros.Text = "Números";
            this.buttonSorteoNumeros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSorteoNumeros.UseVisualStyleBackColor = false;
            this.buttonSorteoNumeros.Click += new System.EventHandler(this.buttonSorteoNumeros_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBoxLogo);
            this.panelLogo.Controls.Add(this.labelRND);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(0, 230);
            this.panelLogo.TabIndex = 2;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::RND.Properties.Resources.dado_random;
            this.pictureBoxLogo.Location = new System.Drawing.Point(18, 48);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(182, 152);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 1;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelRND
            // 
            this.labelRND.AutoSize = true;
            this.labelRND.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelRND.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRND.ForeColor = System.Drawing.Color.White;
            this.labelRND.Location = new System.Drawing.Point(196, 74);
            this.labelRND.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelRND.Name = "labelRND";
            this.labelRND.Size = new System.Drawing.Size(159, 69);
            this.labelRND.TabIndex = 0;
            this.labelRND.Text = "RND";
            this.labelRND.Click += new System.EventHandler(this.labelRND_Click);
            // 
            // panelContenido
            // 
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(102, 0);
            this.panelContenido.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(1606, 1062);
            this.panelContenido.TabIndex = 4;
            // 
            // labelInicio
            // 
            this.labelInicio.AutoSize = true;
            this.labelInicio.ForeColor = System.Drawing.Color.White;
            this.labelInicio.Location = new System.Drawing.Point(29, 184);
            this.labelInicio.Name = "labelInicio";
            this.labelInicio.Size = new System.Drawing.Size(62, 25);
            this.labelInicio.TabIndex = 2;
            this.labelInicio.Text = "Inicio";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1708, 1062);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelLateralIzquierdo);
            this.Controls.Add(this.panelMinimizado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelMinimizado.ResumeLayout(false);
            this.panelMinimizado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAyuda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccesoMenu)).EndInit();
            this.panelLateralIzquierdo.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMinimizado;
        private System.Windows.Forms.Panel panelLateralIzquierdo;
        private System.Windows.Forms.Button buttonSorteoFechas;
        private System.Windows.Forms.Button buttonSorteoNumeros;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelRND;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.PictureBox pictureBoxAccesoMenu;
        private System.Windows.Forms.PictureBox pictureBoxAyuda;
        private System.Windows.Forms.PictureBox pictureBoxSalir;
        private System.Windows.Forms.Button buttonPicos;
        private System.Windows.Forms.Label labelInicio;
    }
}


namespace RND {
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkOrdenados = new System.Windows.Forms.CheckBox();
            this.chkRango = new System.Windows.Forms.CheckBox();
            this.chkDuplicados = new System.Windows.Forms.CheckBox();
            this.grupoTipoSorteo = new System.Windows.Forms.GroupBox();
            this.radioDiaSemana = new System.Windows.Forms.RadioButton();
            this.radioMes = new System.Windows.Forms.RadioButton();
            this.radioLado = new System.Windows.Forms.RadioButton();
            this.radioPersonalizado = new System.Windows.Forms.RadioButton();
            this.radioUE = new System.Windows.Forms.RadioButton();
            this.radioCloracion = new System.Windows.Forms.RadioButton();
            this.radioGenerica = new System.Windows.Forms.RadioButton();
            this.txtRango = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtTope = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInicio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.grupoTipoSorteo.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Opciones";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.grupoTipoSorteo);
            this.panel1.Location = new System.Drawing.Point(26, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 409);
            this.panel1.TabIndex = 2;
            // 
            // chkOrdenados
            // 
            this.chkOrdenados.AutoSize = true;
            this.chkOrdenados.Location = new System.Drawing.Point(57, 157);
            this.chkOrdenados.Name = "chkOrdenados";
            this.chkOrdenados.Size = new System.Drawing.Size(123, 17);
            this.chkOrdenados.TabIndex = 5;
            this.chkOrdenados.Text = "Numeros Ordenados";
            this.chkOrdenados.UseVisualStyleBackColor = true;
            this.chkOrdenados.CheckedChanged += new System.EventHandler(this.chkOrdenados_CheckedChanged);
            // 
            // chkRango
            // 
            this.chkRango.AutoSize = true;
            this.chkRango.Location = new System.Drawing.Point(57, 112);
            this.chkRango.Name = "chkRango";
            this.chkRango.Size = new System.Drawing.Size(92, 17);
            this.chkRango.TabIndex = 4;
            this.chkRango.Text = "Utilizar Rango";
            this.chkRango.UseVisualStyleBackColor = true;
            this.chkRango.CheckedChanged += new System.EventHandler(this.chkRango_CheckedChanged);
            // 
            // chkDuplicados
            // 
            this.chkDuplicados.AutoSize = true;
            this.chkDuplicados.Location = new System.Drawing.Point(57, 133);
            this.chkDuplicados.Name = "chkDuplicados";
            this.chkDuplicados.Size = new System.Drawing.Size(116, 17);
            this.chkDuplicados.TabIndex = 4;
            this.chkDuplicados.Text = "Permitir Duplicados";
            this.chkDuplicados.UseVisualStyleBackColor = true;
            this.chkDuplicados.CheckedChanged += new System.EventHandler(this.chkDuplicados_CheckedChanged);
            // 
            // grupoTipoSorteo
            // 
            this.grupoTipoSorteo.Controls.Add(this.radioDiaSemana);
            this.grupoTipoSorteo.Controls.Add(this.radioMes);
            this.grupoTipoSorteo.Controls.Add(this.radioLado);
            this.grupoTipoSorteo.Controls.Add(this.radioPersonalizado);
            this.grupoTipoSorteo.Controls.Add(this.radioUE);
            this.grupoTipoSorteo.Controls.Add(this.radioCloracion);
            this.grupoTipoSorteo.Controls.Add(this.radioGenerica);
            this.grupoTipoSorteo.Location = new System.Drawing.Point(18, 205);
            this.grupoTipoSorteo.Name = "grupoTipoSorteo";
            this.grupoTipoSorteo.Size = new System.Drawing.Size(200, 189);
            this.grupoTipoSorteo.TabIndex = 0;
            this.grupoTipoSorteo.TabStop = false;
            this.grupoTipoSorteo.Text = "Sorteos";
            // 
            // radioDiaSemana
            // 
            this.radioDiaSemana.AutoSize = true;
            this.radioDiaSemana.Location = new System.Drawing.Point(17, 142);
            this.radioDiaSemana.Name = "radioDiaSemana";
            this.radioDiaSemana.Size = new System.Drawing.Size(71, 17);
            this.radioDiaSemana.TabIndex = 3;
            this.radioDiaSemana.TabStop = true;
            this.radioDiaSemana.Text = "Dia (1...7)";
            this.radioDiaSemana.UseVisualStyleBackColor = true;
            this.radioDiaSemana.CheckedChanged += new System.EventHandler(this.radioDiaSemana_CheckedChanged);
            // 
            // radioMes
            // 
            this.radioMes.AutoSize = true;
            this.radioMes.Location = new System.Drawing.Point(17, 118);
            this.radioMes.Name = "radioMes";
            this.radioMes.Size = new System.Drawing.Size(81, 17);
            this.radioMes.TabIndex = 2;
            this.radioMes.TabStop = true;
            this.radioMes.Text = "Mes (1...12)";
            this.radioMes.UseVisualStyleBackColor = true;
            this.radioMes.CheckedChanged += new System.EventHandler(this.radioMes_CheckedChanged);
            // 
            // radioLado
            // 
            this.radioLado.AutoSize = true;
            this.radioLado.Location = new System.Drawing.Point(17, 94);
            this.radioLado.Name = "radioLado";
            this.radioLado.Size = new System.Drawing.Size(130, 17);
            this.radioLado.TabIndex = 1;
            this.radioLado.TabStop = true;
            this.radioLado.Text = "Lado (1: Izq. / 2: Der.)";
            this.radioLado.UseVisualStyleBackColor = true;
            this.radioLado.CheckedChanged += new System.EventHandler(this.radioLado_CheckedChanged);
            // 
            // radioPersonalizado
            // 
            this.radioPersonalizado.AutoSize = true;
            this.radioPersonalizado.Location = new System.Drawing.Point(17, 166);
            this.radioPersonalizado.Name = "radioPersonalizado";
            this.radioPersonalizado.Size = new System.Drawing.Size(91, 17);
            this.radioPersonalizado.TabIndex = 0;
            this.radioPersonalizado.TabStop = true;
            this.radioPersonalizado.Text = "Personalizado";
            this.radioPersonalizado.UseVisualStyleBackColor = true;
            this.radioPersonalizado.CheckedChanged += new System.EventHandler(this.radioPersonalizado_CheckedChanged);
            // 
            // radioUE
            // 
            this.radioUE.AutoSize = true;
            this.radioUE.Location = new System.Drawing.Point(17, 70);
            this.radioUE.Name = "radioUE";
            this.radioUE.Size = new System.Drawing.Size(49, 17);
            this.radioUE.TabIndex = 0;
            this.radioUE.TabStop = true;
            this.radioUE.Text = "U.E. ";
            this.radioUE.UseVisualStyleBackColor = true;
            this.radioUE.CheckedChanged += new System.EventHandler(this.radioUE_CheckedChanged);
            // 
            // radioCloracion
            // 
            this.radioCloracion.AutoSize = true;
            this.radioCloracion.Location = new System.Drawing.Point(17, 46);
            this.radioCloracion.Name = "radioCloracion";
            this.radioCloracion.Size = new System.Drawing.Size(105, 17);
            this.radioCloracion.TabIndex = 0;
            this.radioCloracion.TabStop = true;
            this.radioCloracion.Text = "Control Cloracion";
            this.radioCloracion.UseVisualStyleBackColor = true;
            this.radioCloracion.CheckedChanged += new System.EventHandler(this.radioCloracion_CheckedChanged);
            // 
            // radioGenerica
            // 
            this.radioGenerica.AutoSize = true;
            this.radioGenerica.Location = new System.Drawing.Point(17, 22);
            this.radioGenerica.Name = "radioGenerica";
            this.radioGenerica.Size = new System.Drawing.Size(97, 17);
            this.radioGenerica.TabIndex = 0;
            this.radioGenerica.TabStop = true;
            this.radioGenerica.Text = "E.coli Generica";
            this.radioGenerica.UseVisualStyleBackColor = true;
            this.radioGenerica.CheckedChanged += new System.EventHandler(this.radioGenerica_CheckedChanged);
            // 
            // txtRango
            // 
            this.txtRango.Location = new System.Drawing.Point(57, 86);
            this.txtRango.Name = "txtRango";
            this.txtRango.Size = new System.Drawing.Size(137, 20);
            this.txtRango.TabIndex = 3;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(57, 59);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(137, 20);
            this.txtCantidad.TabIndex = 3;
            // 
            // txtTope
            // 
            this.txtTope.Location = new System.Drawing.Point(57, 33);
            this.txtTope.Name = "txtTope";
            this.txtTope.Size = new System.Drawing.Size(137, 20);
            this.txtTope.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Rango";
            // 
            // txtInicio
            // 
            this.txtInicio.Location = new System.Drawing.Point(57, 7);
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Size = new System.Drawing.Size(137, 20);
            this.txtInicio.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(19, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tope";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inicio";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtResultado);
            this.panel3.Location = new System.Drawing.Point(277, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 409);
            this.panel3.TabIndex = 5;
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.SystemColors.Window;
            this.txtResultado.Location = new System.Drawing.Point(22, 29);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(182, 365);
            this.txtResultado.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(274, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Numeros Generados";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(397, 470);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(100, 28);
            this.btnGenerar.TabIndex = 7;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(278, 470);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 8;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtInicio);
            this.panel2.Controls.Add(this.chkOrdenados);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.chkRango);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.chkDuplicados);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtRango);
            this.panel2.Controls.Add(this.txtTope);
            this.panel2.Controls.Add(this.txtCantidad);
            this.panel2.Location = new System.Drawing.Point(18, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 182);
            this.panel2.TabIndex = 6;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 523);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inicio";
            this.Text = "RND: Numeros Aleatorios";
            this.panel1.ResumeLayout(false);
            this.grupoTipoSorteo.ResumeLayout(false);
            this.grupoTipoSorteo.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtTope;
        private System.Windows.Forms.TextBox txtInicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grupoTipoSorteo;
        private System.Windows.Forms.RadioButton radioPersonalizado;
        private System.Windows.Forms.RadioButton radioUE;
        private System.Windows.Forms.RadioButton radioCloracion;
        private System.Windows.Forms.RadioButton radioGenerica;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioDiaSemana;
        private System.Windows.Forms.RadioButton radioMes;
        private System.Windows.Forms.RadioButton radioLado;
        private System.Windows.Forms.CheckBox chkOrdenados;
        private System.Windows.Forms.CheckBox chkDuplicados;
        private System.Windows.Forms.CheckBox chkRango;
        private System.Windows.Forms.TextBox txtRango;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
    }
}


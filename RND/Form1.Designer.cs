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
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtInicio = new System.Windows.Forms.TextBox();
            this.chkVerificacion = new System.Windows.Forms.CheckBox();
            this.chkOrdenados = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkRango = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkDuplicados = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCantVerificacion = new System.Windows.Forms.TextBox();
            this.txtRango = new System.Windows.Forms.TextBox();
            this.txtTope = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.grupoTipoSorteo = new System.Windows.Forms.GroupBox();
            this.radioDiaSemana = new System.Windows.Forms.RadioButton();
            this.radioMes = new System.Windows.Forms.RadioButton();
            this.radioLado = new System.Windows.Forms.RadioButton();
            this.radioPersonalizado = new System.Windows.Forms.RadioButton();
            this.radioUE = new System.Windows.Forms.RadioButton();
            this.radioCloracion = new System.Windows.Forms.RadioButton();
            this.radioGenerica = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtResultadoVerificacion = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.barraMenu = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sorteosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemPersonalizado = new System.Windows.Forms.ToolStripMenuItem();
            this.itemGenerica = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCloracion = new System.Windows.Forms.ToolStripMenuItem();
            this.itemUE = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemLado = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemMes = new System.Windows.Forms.ToolStripMenuItem();
            this.itemDiaSemana = new System.Windows.Forms.ToolStripMenuItem();
            this.itemNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grupoTipoSorteo.SuspendLayout();
            this.panel3.SuspendLayout();
            this.barraMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Opciones";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.grupoTipoSorteo);
            this.panel1.Location = new System.Drawing.Point(26, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 452);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtInicio);
            this.panel2.Controls.Add(this.chkVerificacion);
            this.panel2.Controls.Add(this.chkOrdenados);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.chkRango);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.chkDuplicados);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtCantVerificacion);
            this.panel2.Controls.Add(this.txtRango);
            this.panel2.Controls.Add(this.txtTope);
            this.panel2.Controls.Add(this.txtCantidad);
            this.panel2.Location = new System.Drawing.Point(18, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 233);
            this.panel2.TabIndex = 6;
            // 
            // txtInicio
            // 
            this.txtInicio.Location = new System.Drawing.Point(70, 7);
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Size = new System.Drawing.Size(124, 20);
            this.txtInicio.TabIndex = 1;
            // 
            // chkVerificacion
            // 
            this.chkVerificacion.AutoSize = true;
            this.chkVerificacion.Location = new System.Drawing.Point(70, 207);
            this.chkVerificacion.Name = "chkVerificacion";
            this.chkVerificacion.Size = new System.Drawing.Size(112, 17);
            this.chkVerificacion.TabIndex = 5;
            this.chkVerificacion.Text = "Inlcuir Verificacion";
            this.chkVerificacion.UseVisualStyleBackColor = true;
            this.chkVerificacion.CheckedChanged += new System.EventHandler(this.chkVerificacion_CheckedChanged);
            // 
            // chkOrdenados
            // 
            this.chkOrdenados.AutoSize = true;
            this.chkOrdenados.Location = new System.Drawing.Point(70, 184);
            this.chkOrdenados.Name = "chkOrdenados";
            this.chkOrdenados.Size = new System.Drawing.Size(123, 17);
            this.chkOrdenados.TabIndex = 5;
            this.chkOrdenados.Text = "Numeros Ordenados";
            this.chkOrdenados.UseVisualStyleBackColor = true;
            this.chkOrdenados.CheckedChanged += new System.EventHandler(this.chkOrdenados_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inicio";
            // 
            // chkRango
            // 
            this.chkRango.AutoSize = true;
            this.chkRango.Location = new System.Drawing.Point(70, 139);
            this.chkRango.Name = "chkRango";
            this.chkRango.Size = new System.Drawing.Size(92, 17);
            this.chkRango.TabIndex = 4;
            this.chkRango.Text = "Utilizar Rango";
            this.chkRango.UseVisualStyleBackColor = true;
            this.chkRango.CheckedChanged += new System.EventHandler(this.chkRango_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(32, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tope";
            // 
            // chkDuplicados
            // 
            this.chkDuplicados.AutoSize = true;
            this.chkDuplicados.Location = new System.Drawing.Point(70, 160);
            this.chkDuplicados.Name = "chkDuplicados";
            this.chkDuplicados.Size = new System.Drawing.Size(116, 17);
            this.chkDuplicados.TabIndex = 4;
            this.chkDuplicados.Text = "Permitir Duplicados";
            this.chkDuplicados.UseVisualStyleBackColor = true;
            this.chkDuplicados.CheckedChanged += new System.EventHandler(this.chkDuplicados_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cantidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Verificacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Rango";
            // 
            // txtCantVerificacion
            // 
            this.txtCantVerificacion.Enabled = false;
            this.txtCantVerificacion.Location = new System.Drawing.Point(70, 113);
            this.txtCantVerificacion.Name = "txtCantVerificacion";
            this.txtCantVerificacion.Size = new System.Drawing.Size(124, 20);
            this.txtCantVerificacion.TabIndex = 3;
            // 
            // txtRango
            // 
            this.txtRango.Enabled = false;
            this.txtRango.Location = new System.Drawing.Point(70, 86);
            this.txtRango.Name = "txtRango";
            this.txtRango.Size = new System.Drawing.Size(124, 20);
            this.txtRango.TabIndex = 3;
            // 
            // txtTope
            // 
            this.txtTope.Location = new System.Drawing.Point(70, 33);
            this.txtTope.Name = "txtTope";
            this.txtTope.Size = new System.Drawing.Size(124, 20);
            this.txtTope.TabIndex = 2;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(70, 59);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(124, 20);
            this.txtCantidad.TabIndex = 3;
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
            this.grupoTipoSorteo.Location = new System.Drawing.Point(18, 250);
            this.grupoTipoSorteo.Name = "grupoTipoSorteo";
            this.grupoTipoSorteo.Size = new System.Drawing.Size(200, 192);
            this.grupoTipoSorteo.TabIndex = 0;
            this.grupoTipoSorteo.TabStop = false;
            this.grupoTipoSorteo.Text = "Sorteos";
            // 
            // radioDiaSemana
            // 
            this.radioDiaSemana.AutoSize = true;
            this.radioDiaSemana.Location = new System.Drawing.Point(17, 142);
            this.radioDiaSemana.Name = "radioDiaSemana";
            this.radioDiaSemana.Size = new System.Drawing.Size(128, 17);
            this.radioDiaSemana.TabIndex = 3;
            this.radioDiaSemana.Text = "Dia de Semana (1...7)";
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
            this.radioLado.Text = "Lado (1: Izq. / 2: Der.)";
            this.radioLado.UseVisualStyleBackColor = true;
            this.radioLado.CheckedChanged += new System.EventHandler(this.radioLado_CheckedChanged);
            // 
            // radioPersonalizado
            // 
            this.radioPersonalizado.AutoSize = true;
            this.radioPersonalizado.Checked = true;
            this.radioPersonalizado.Location = new System.Drawing.Point(17, 168);
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
            this.radioGenerica.Text = "E.coli Generica";
            this.radioGenerica.UseVisualStyleBackColor = true;
            this.radioGenerica.CheckedChanged += new System.EventHandler(this.radioGenerica_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtResultadoVerificacion);
            this.panel3.Controls.Add(this.txtResultado);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(277, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 409);
            this.panel3.TabIndex = 5;
            // 
            // txtResultadoVerificacion
            // 
            this.txtResultadoVerificacion.BackColor = System.Drawing.SystemColors.Window;
            this.txtResultadoVerificacion.Location = new System.Drawing.Point(14, 283);
            this.txtResultadoVerificacion.Multiline = true;
            this.txtResultadoVerificacion.Name = "txtResultadoVerificacion";
            this.txtResultadoVerificacion.ReadOnly = true;
            this.txtResultadoVerificacion.Size = new System.Drawing.Size(190, 115);
            this.txtResultadoVerificacion.TabIndex = 0;
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.SystemColors.Window;
            this.txtResultado.Location = new System.Drawing.Point(14, 11);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(190, 246);
            this.txtResultado.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Verificacion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(288, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Numeros Generados";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(397, 460);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(84, 28);
            this.btnGenerar.TabIndex = 7;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(291, 462);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(86, 28);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // barraMenu
            // 
            this.barraMenu.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.barraMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.sorteosToolStripMenuItem});
            this.barraMenu.Location = new System.Drawing.Point(0, 0);
            this.barraMenu.Name = "barraMenu";
            this.barraMenu.Size = new System.Drawing.Size(519, 27);
            this.barraMenu.TabIndex = 9;
            this.barraMenu.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemNuevo,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(67, 23);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            this.archivoToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // sorteosToolStripMenuItem
            // 
            this.sorteosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemPersonalizado,
            this.itemGenerica,
            this.itemCloracion,
            this.itemUE,
            this.ItemLado,
            this.ItemMes,
            this.itemDiaSemana});
            this.sorteosToolStripMenuItem.Name = "sorteosToolStripMenuItem";
            this.sorteosToolStripMenuItem.Size = new System.Drawing.Size(67, 23);
            this.sorteosToolStripMenuItem.Text = "&Sorteos";
            this.sorteosToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // itemPersonalizado
            // 
            this.itemPersonalizado.Name = "itemPersonalizado";
            this.itemPersonalizado.Size = new System.Drawing.Size(213, 24);
            this.itemPersonalizado.Text = "&Personalizado";
            this.itemPersonalizado.Click += new System.EventHandler(this.itemPersonalizado_Click);
            // 
            // itemGenerica
            // 
            this.itemGenerica.Name = "itemGenerica";
            this.itemGenerica.Size = new System.Drawing.Size(213, 24);
            this.itemGenerica.Text = "E.coli &Generica";
            this.itemGenerica.Click += new System.EventHandler(this.itemGenerica_Click);
            // 
            // itemCloracion
            // 
            this.itemCloracion.Name = "itemCloracion";
            this.itemCloracion.Size = new System.Drawing.Size(213, 24);
            this.itemCloracion.Text = "Control de &Cloracion";
            this.itemCloracion.Click += new System.EventHandler(this.itemCloracion_Click);
            // 
            // itemUE
            // 
            this.itemUE.Name = "itemUE";
            this.itemUE.Size = new System.Drawing.Size(213, 24);
            this.itemUE.Text = "&U.E.";
            this.itemUE.Click += new System.EventHandler(this.itemUE_Click);
            // 
            // ItemLado
            // 
            this.ItemLado.Name = "ItemLado";
            this.ItemLado.Size = new System.Drawing.Size(213, 24);
            this.ItemLado.Text = "&Lado (1: Izq. / 2: Der,)";
            this.ItemLado.Click += new System.EventHandler(this.ItemLado_Click);
            // 
            // ItemMes
            // 
            this.ItemMes.Name = "ItemMes";
            this.ItemMes.Size = new System.Drawing.Size(213, 24);
            this.ItemMes.Text = "&Mes (1...12)";
            this.ItemMes.Click += new System.EventHandler(this.ItemMes_Click);
            // 
            // itemDiaSemana
            // 
            this.itemDiaSemana.Name = "itemDiaSemana";
            this.itemDiaSemana.Size = new System.Drawing.Size(213, 24);
            this.itemDiaSemana.Text = "&Dia de Semana (1...7)";
            this.itemDiaSemana.Click += new System.EventHandler(this.itemDiaSemana_Click);
            // 
            // itemNuevo
            // 
            this.itemNuevo.Name = "itemNuevo";
            this.itemNuevo.Size = new System.Drawing.Size(169, 24);
            this.itemNuevo.Text = "&Nuevo";
            this.itemNuevo.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(166, 6);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 511);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.barraMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.barraMenu;
            this.Name = "Inicio";
            this.Text = "RND: Numeros Aleatorios";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grupoTipoSorteo.ResumeLayout(false);
            this.grupoTipoSorteo.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.barraMenu.ResumeLayout(false);
            this.barraMenu.PerformLayout();
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
        private System.Windows.Forms.RadioButton radioUE;
        private System.Windows.Forms.RadioButton radioCloracion;
        private System.Windows.Forms.RadioButton radioGenerica;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.RadioButton radioDiaSemana;
        private System.Windows.Forms.RadioButton radioMes;
        private System.Windows.Forms.RadioButton radioLado;
        private System.Windows.Forms.CheckBox chkOrdenados;
        private System.Windows.Forms.CheckBox chkDuplicados;
        private System.Windows.Forms.CheckBox chkRango;
        private System.Windows.Forms.TextBox txtRango;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioPersonalizado;
        private System.Windows.Forms.CheckBox chkVerificacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCantVerificacion;
        private System.Windows.Forms.TextBox txtResultadoVerificacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MenuStrip barraMenu;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sorteosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemPersonalizado;
        private System.Windows.Forms.ToolStripMenuItem itemGenerica;
        private System.Windows.Forms.ToolStripMenuItem itemCloracion;
        private System.Windows.Forms.ToolStripMenuItem itemUE;
        private System.Windows.Forms.ToolStripMenuItem ItemLado;
        private System.Windows.Forms.ToolStripMenuItem ItemMes;
        private System.Windows.Forms.ToolStripMenuItem itemDiaSemana;
        private System.Windows.Forms.ToolStripMenuItem itemNuevo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}


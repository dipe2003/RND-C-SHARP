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
            this.itemNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sorteosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemPersonalizado = new System.Windows.Forms.ToolStripMenuItem();
            this.itemGenerica = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCloracion = new System.Windows.Forms.ToolStripMenuItem();
            this.itemUE = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemLado = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemMes = new System.Windows.Forms.ToolStripMenuItem();
            this.itemDiaSemana = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4 = new System.Windows.Forms.Panel();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conVerificacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinVerificacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grupoTipoSorteo.SuspendLayout();
            this.panel3.SuspendLayout();
            this.barraMenu.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Opciones";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.grupoTipoSorteo);
            this.panel1.Location = new System.Drawing.Point(35, 59);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 566);
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
            this.panel2.Location = new System.Drawing.Point(24, 14);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 287);
            this.panel2.TabIndex = 6;
            // 
            // txtInicio
            // 
            this.txtInicio.Location = new System.Drawing.Point(93, 9);
            this.txtInicio.Margin = new System.Windows.Forms.Padding(4);
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Size = new System.Drawing.Size(164, 22);
            this.txtInicio.TabIndex = 1;
            // 
            // chkVerificacion
            // 
            this.chkVerificacion.AutoSize = true;
            this.chkVerificacion.Location = new System.Drawing.Point(93, 255);
            this.chkVerificacion.Margin = new System.Windows.Forms.Padding(4);
            this.chkVerificacion.Name = "chkVerificacion";
            this.chkVerificacion.Size = new System.Drawing.Size(144, 21);
            this.chkVerificacion.TabIndex = 5;
            this.chkVerificacion.Text = "Inlcuir Verificacion";
            this.chkVerificacion.UseVisualStyleBackColor = true;
            this.chkVerificacion.CheckedChanged += new System.EventHandler(this.chkVerificacion_CheckedChanged);
            // 
            // chkOrdenados
            // 
            this.chkOrdenados.AutoSize = true;
            this.chkOrdenados.Location = new System.Drawing.Point(93, 226);
            this.chkOrdenados.Margin = new System.Windows.Forms.Padding(4);
            this.chkOrdenados.Name = "chkOrdenados";
            this.chkOrdenados.Size = new System.Drawing.Size(162, 21);
            this.chkOrdenados.TabIndex = 5;
            this.chkOrdenados.Text = "Numeros Ordenados";
            this.chkOrdenados.UseVisualStyleBackColor = true;
            this.chkOrdenados.CheckedChanged += new System.EventHandler(this.chkOrdenados_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inicio";
            // 
            // chkRango
            // 
            this.chkRango.AutoSize = true;
            this.chkRango.Location = new System.Drawing.Point(93, 171);
            this.chkRango.Margin = new System.Windows.Forms.Padding(4);
            this.chkRango.Name = "chkRango";
            this.chkRango.Size = new System.Drawing.Size(119, 21);
            this.chkRango.TabIndex = 4;
            this.chkRango.Text = "Utilizar Rango";
            this.chkRango.UseVisualStyleBackColor = true;
            this.chkRango.CheckedChanged += new System.EventHandler(this.chkRango_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(43, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tope";
            // 
            // chkDuplicados
            // 
            this.chkDuplicados.AutoSize = true;
            this.chkDuplicados.Location = new System.Drawing.Point(93, 197);
            this.chkDuplicados.Margin = new System.Windows.Forms.Padding(4);
            this.chkDuplicados.Name = "chkDuplicados";
            this.chkDuplicados.Size = new System.Drawing.Size(152, 21);
            this.chkDuplicados.TabIndex = 4;
            this.chkDuplicados.Text = "Permitir Duplicados";
            this.chkDuplicados.UseVisualStyleBackColor = true;
            this.chkDuplicados.CheckedChanged += new System.EventHandler(this.chkDuplicados_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cantidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 143);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Verificacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 110);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Rango";
            // 
            // txtCantVerificacion
            // 
            this.txtCantVerificacion.Enabled = false;
            this.txtCantVerificacion.Location = new System.Drawing.Point(93, 139);
            this.txtCantVerificacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantVerificacion.Name = "txtCantVerificacion";
            this.txtCantVerificacion.Size = new System.Drawing.Size(164, 22);
            this.txtCantVerificacion.TabIndex = 3;
            // 
            // txtRango
            // 
            this.txtRango.Enabled = false;
            this.txtRango.Location = new System.Drawing.Point(93, 106);
            this.txtRango.Margin = new System.Windows.Forms.Padding(4);
            this.txtRango.Name = "txtRango";
            this.txtRango.Size = new System.Drawing.Size(164, 22);
            this.txtRango.TabIndex = 3;
            // 
            // txtTope
            // 
            this.txtTope.Location = new System.Drawing.Point(93, 41);
            this.txtTope.Margin = new System.Windows.Forms.Padding(4);
            this.txtTope.Name = "txtTope";
            this.txtTope.Size = new System.Drawing.Size(164, 22);
            this.txtTope.TabIndex = 2;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(93, 73);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(164, 22);
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
            this.grupoTipoSorteo.Location = new System.Drawing.Point(24, 308);
            this.grupoTipoSorteo.Margin = new System.Windows.Forms.Padding(4);
            this.grupoTipoSorteo.Name = "grupoTipoSorteo";
            this.grupoTipoSorteo.Padding = new System.Windows.Forms.Padding(4);
            this.grupoTipoSorteo.Size = new System.Drawing.Size(267, 236);
            this.grupoTipoSorteo.TabIndex = 0;
            this.grupoTipoSorteo.TabStop = false;
            this.grupoTipoSorteo.Text = "Sorteos";
            // 
            // radioDiaSemana
            // 
            this.radioDiaSemana.AutoSize = true;
            this.radioDiaSemana.Location = new System.Drawing.Point(23, 175);
            this.radioDiaSemana.Margin = new System.Windows.Forms.Padding(4);
            this.radioDiaSemana.Name = "radioDiaSemana";
            this.radioDiaSemana.Size = new System.Drawing.Size(168, 21);
            this.radioDiaSemana.TabIndex = 3;
            this.radioDiaSemana.Text = "Dia de Semana (1...7)";
            this.radioDiaSemana.UseVisualStyleBackColor = true;
            this.radioDiaSemana.CheckedChanged += new System.EventHandler(this.radioDiaSemana_CheckedChanged);
            // 
            // radioMes
            // 
            this.radioMes.AutoSize = true;
            this.radioMes.Location = new System.Drawing.Point(23, 145);
            this.radioMes.Margin = new System.Windows.Forms.Padding(4);
            this.radioMes.Name = "radioMes";
            this.radioMes.Size = new System.Drawing.Size(105, 21);
            this.radioMes.TabIndex = 2;
            this.radioMes.Text = "Mes (1...12)";
            this.radioMes.UseVisualStyleBackColor = true;
            this.radioMes.CheckedChanged += new System.EventHandler(this.radioMes_CheckedChanged);
            // 
            // radioLado
            // 
            this.radioLado.AutoSize = true;
            this.radioLado.Location = new System.Drawing.Point(23, 116);
            this.radioLado.Margin = new System.Windows.Forms.Padding(4);
            this.radioLado.Name = "radioLado";
            this.radioLado.Size = new System.Drawing.Size(168, 21);
            this.radioLado.TabIndex = 1;
            this.radioLado.Text = "Lado (1: Izq. / 2: Der.)";
            this.radioLado.UseVisualStyleBackColor = true;
            this.radioLado.CheckedChanged += new System.EventHandler(this.radioLado_CheckedChanged);
            // 
            // radioPersonalizado
            // 
            this.radioPersonalizado.AutoSize = true;
            this.radioPersonalizado.Checked = true;
            this.radioPersonalizado.Location = new System.Drawing.Point(23, 207);
            this.radioPersonalizado.Margin = new System.Windows.Forms.Padding(4);
            this.radioPersonalizado.Name = "radioPersonalizado";
            this.radioPersonalizado.Size = new System.Drawing.Size(119, 21);
            this.radioPersonalizado.TabIndex = 0;
            this.radioPersonalizado.TabStop = true;
            this.radioPersonalizado.Text = "Personalizado";
            this.radioPersonalizado.UseVisualStyleBackColor = true;
            this.radioPersonalizado.CheckedChanged += new System.EventHandler(this.radioPersonalizado_CheckedChanged);
            // 
            // radioUE
            // 
            this.radioUE.AutoSize = true;
            this.radioUE.Location = new System.Drawing.Point(23, 86);
            this.radioUE.Margin = new System.Windows.Forms.Padding(4);
            this.radioUE.Name = "radioUE";
            this.radioUE.Size = new System.Drawing.Size(60, 21);
            this.radioUE.TabIndex = 0;
            this.radioUE.Text = "U.E. ";
            this.radioUE.UseVisualStyleBackColor = true;
            this.radioUE.CheckedChanged += new System.EventHandler(this.radioUE_CheckedChanged);
            // 
            // radioCloracion
            // 
            this.radioCloracion.AutoSize = true;
            this.radioCloracion.Location = new System.Drawing.Point(23, 57);
            this.radioCloracion.Margin = new System.Windows.Forms.Padding(4);
            this.radioCloracion.Name = "radioCloracion";
            this.radioCloracion.Size = new System.Drawing.Size(157, 21);
            this.radioCloracion.TabIndex = 0;
            this.radioCloracion.Text = "Control de Cloracion";
            this.radioCloracion.UseVisualStyleBackColor = true;
            this.radioCloracion.CheckedChanged += new System.EventHandler(this.radioCloracion_CheckedChanged);
            // 
            // radioGenerica
            // 
            this.radioGenerica.AutoSize = true;
            this.radioGenerica.Location = new System.Drawing.Point(23, 27);
            this.radioGenerica.Margin = new System.Windows.Forms.Padding(4);
            this.radioGenerica.Name = "radioGenerica";
            this.radioGenerica.Size = new System.Drawing.Size(125, 21);
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
            this.panel3.Location = new System.Drawing.Point(369, 59);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(293, 503);
            this.panel3.TabIndex = 5;
            // 
            // txtResultadoVerificacion
            // 
            this.txtResultadoVerificacion.BackColor = System.Drawing.SystemColors.Window;
            this.txtResultadoVerificacion.Location = new System.Drawing.Point(19, 348);
            this.txtResultadoVerificacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtResultadoVerificacion.Multiline = true;
            this.txtResultadoVerificacion.Name = "txtResultadoVerificacion";
            this.txtResultadoVerificacion.ReadOnly = true;
            this.txtResultadoVerificacion.Size = new System.Drawing.Size(252, 141);
            this.txtResultadoVerificacion.TabIndex = 0;
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.SystemColors.Window;
            this.txtResultado.Location = new System.Drawing.Point(19, 14);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(4);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(252, 302);
            this.txtResultado.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 324);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Verificacion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(384, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Numeros Generados";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(159, 8);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(112, 34);
            this.btnGenerar.TabIndex = 7;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(18, 8);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(115, 34);
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
            this.barraMenu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.barraMenu.Size = new System.Drawing.Size(687, 28);
            this.barraMenu.TabIndex = 9;
            this.barraMenu.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemNuevo,
            this.imprimirToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            this.archivoToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // itemNuevo
            // 
            this.itemNuevo.Name = "itemNuevo";
            this.itemNuevo.Size = new System.Drawing.Size(181, 26);
            this.itemNuevo.Text = "&Nuevo";
            this.itemNuevo.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
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
            this.sorteosToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.sorteosToolStripMenuItem.Text = "&Sorteos";
            this.sorteosToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // itemPersonalizado
            // 
            this.itemPersonalizado.Name = "itemPersonalizado";
            this.itemPersonalizado.Size = new System.Drawing.Size(225, 26);
            this.itemPersonalizado.Text = "&Personalizado";
            this.itemPersonalizado.Click += new System.EventHandler(this.itemPersonalizado_Click);
            // 
            // itemGenerica
            // 
            this.itemGenerica.Name = "itemGenerica";
            this.itemGenerica.Size = new System.Drawing.Size(225, 26);
            this.itemGenerica.Text = "E.coli &Generica";
            this.itemGenerica.Click += new System.EventHandler(this.itemGenerica_Click);
            // 
            // itemCloracion
            // 
            this.itemCloracion.Name = "itemCloracion";
            this.itemCloracion.Size = new System.Drawing.Size(225, 26);
            this.itemCloracion.Text = "Control de &Cloracion";
            this.itemCloracion.Click += new System.EventHandler(this.itemCloracion_Click);
            // 
            // itemUE
            // 
            this.itemUE.Name = "itemUE";
            this.itemUE.Size = new System.Drawing.Size(225, 26);
            this.itemUE.Text = "&U.E.";
            this.itemUE.Click += new System.EventHandler(this.itemUE_Click);
            // 
            // ItemLado
            // 
            this.ItemLado.Name = "ItemLado";
            this.ItemLado.Size = new System.Drawing.Size(225, 26);
            this.ItemLado.Text = "&Lado (1: Izq. / 2: Der,)";
            this.ItemLado.Click += new System.EventHandler(this.ItemLado_Click);
            // 
            // ItemMes
            // 
            this.ItemMes.Name = "ItemMes";
            this.ItemMes.Size = new System.Drawing.Size(225, 26);
            this.ItemMes.Text = "&Mes (1...12)";
            this.ItemMes.Click += new System.EventHandler(this.ItemMes_Click);
            // 
            // itemDiaSemana
            // 
            this.itemDiaSemana.Name = "itemDiaSemana";
            this.itemDiaSemana.Size = new System.Drawing.Size(225, 26);
            this.itemDiaSemana.Text = "&Dia de Semana (1...7)";
            this.itemDiaSemana.Click += new System.EventHandler(this.itemDiaSemana_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnSalir);
            this.panel4.Controls.Add(this.btnGenerar);
            this.panel4.Location = new System.Drawing.Point(369, 574);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(293, 51);
            this.panel4.TabIndex = 10;
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conVerificacionToolStripMenuItem,
            this.sinVerificacionToolStripMenuItem});
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.imprimirToolStripMenuItem.Text = "&Imprimir";
            // 
            // conVerificacionToolStripMenuItem
            // 
            this.conVerificacionToolStripMenuItem.Name = "conVerificacionToolStripMenuItem";
            this.conVerificacionToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.conVerificacionToolStripMenuItem.Text = "Con Verificacion";
            this.conVerificacionToolStripMenuItem.Click += new System.EventHandler(this.conVerificacionToolStripMenuItem_Click);
            // 
            // sinVerificacionToolStripMenuItem
            // 
            this.sinVerificacionToolStripMenuItem.Name = "sinVerificacionToolStripMenuItem";
            this.sinVerificacionToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.sinVerificacionToolStripMenuItem.Text = "Sin Verificacion";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 645);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.barraMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.barraMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
            this.panel4.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conVerificacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinVerificacionToolStripMenuItem;
    }
}


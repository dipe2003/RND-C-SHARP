namespace RND.Views.Sorteos {
    partial class SorteoNumeros {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnGuardarPDF = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.grupoTipoSorteo = new System.Windows.Forms.GroupBox();
            this.radioLado = new System.Windows.Forms.RadioButton();
            this.radioHaccp = new System.Windows.Forms.RadioButton();
            this.radioPersonalizado = new System.Windows.Forms.RadioButton();
            this.radioUE = new System.Windows.Forms.RadioButton();
            this.radioCloracion = new System.Windows.Forms.RadioButton();
            this.radioGenerica = new System.Windows.Forms.RadioButton();
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
            this.dateTimePickerFechaSorteo = new System.Windows.Forms.DateTimePicker();
            this.labelFechaSorteo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridNumeros = new System.Windows.Forms.DataGridView();
            this.dataGridVerificacion = new System.Windows.Forms.DataGridView();
            this.groupBoxOpciones = new System.Windows.Forms.GroupBox();
            this.panelBotones.SuspendLayout();
            this.grupoTipoSorteo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNumeros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVerificacion)).BeginInit();
            this.groupBoxOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBotones
            // 
            this.panelBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBotones.Controls.Add(this.btnGuardarPDF);
            this.panelBotones.Controls.Add(this.btnCerrar);
            this.panelBotones.Controls.Add(this.btnGenerar);
            this.panelBotones.Location = new System.Drawing.Point(307, 565);
            this.panelBotones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(402, 49);
            this.panelBotones.TabIndex = 15;
            // 
            // btnGuardarPDF
            // 
            this.btnGuardarPDF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGuardarPDF.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(2)))), ((int)(((byte)(123)))));
            this.btnGuardarPDF.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuardarPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarPDF.Location = new System.Drawing.Point(7, 7);
            this.btnGuardarPDF.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarPDF.Name = "btnGuardarPDF";
            this.btnGuardarPDF.Size = new System.Drawing.Size(120, 34);
            this.btnGuardarPDF.TabIndex = 7;
            this.btnGuardarPDF.Text = "Exportar";
            this.btnGuardarPDF.UseVisualStyleBackColor = false;
            this.btnGuardarPDF.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(2)))), ((int)(((byte)(123)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(273, 7);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(120, 34);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGenerar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(2)))), ((int)(((byte)(123)))));
            this.btnGenerar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Location = new System.Drawing.Point(140, 7);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(120, 34);
            this.btnGenerar.TabIndex = 7;
            this.btnGenerar.Text = "Sortear";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.BtnGenerar_Click);
            // 
            // grupoTipoSorteo
            // 
            this.grupoTipoSorteo.Controls.Add(this.radioLado);
            this.grupoTipoSorteo.Controls.Add(this.radioHaccp);
            this.grupoTipoSorteo.Controls.Add(this.radioPersonalizado);
            this.grupoTipoSorteo.Controls.Add(this.radioUE);
            this.grupoTipoSorteo.Controls.Add(this.radioCloracion);
            this.grupoTipoSorteo.Controls.Add(this.radioGenerica);
            this.grupoTipoSorteo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grupoTipoSorteo.Location = new System.Drawing.Point(16, 341);
            this.grupoTipoSorteo.Margin = new System.Windows.Forms.Padding(4);
            this.grupoTipoSorteo.Name = "grupoTipoSorteo";
            this.grupoTipoSorteo.Padding = new System.Windows.Forms.Padding(4);
            this.grupoTipoSorteo.Size = new System.Drawing.Size(284, 218);
            this.grupoTipoSorteo.TabIndex = 0;
            this.grupoTipoSorteo.TabStop = false;
            this.grupoTipoSorteo.Text = "Sorteos";
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
            this.radioLado.CheckedChanged += new System.EventHandler(this.RadioLado_CheckedChanged);
            // 
            // radioHaccp
            // 
            this.radioHaccp.AutoSize = true;
            this.radioHaccp.Location = new System.Drawing.Point(23, 151);
            this.radioHaccp.Margin = new System.Windows.Forms.Padding(4);
            this.radioHaccp.Name = "radioHaccp";
            this.radioHaccp.Size = new System.Drawing.Size(75, 21);
            this.radioHaccp.TabIndex = 0;
            this.radioHaccp.Text = "HACCP";
            this.radioHaccp.UseVisualStyleBackColor = true;
            this.radioHaccp.CheckedChanged += new System.EventHandler(this.RadioHaccpCheckedChanged);
            // 
            // radioPersonalizado
            // 
            this.radioPersonalizado.AutoSize = true;
            this.radioPersonalizado.Checked = true;
            this.radioPersonalizado.Location = new System.Drawing.Point(23, 180);
            this.radioPersonalizado.Margin = new System.Windows.Forms.Padding(4);
            this.radioPersonalizado.Name = "radioPersonalizado";
            this.radioPersonalizado.Size = new System.Drawing.Size(119, 21);
            this.radioPersonalizado.TabIndex = 0;
            this.radioPersonalizado.TabStop = true;
            this.radioPersonalizado.Text = "Personalizado";
            this.radioPersonalizado.UseVisualStyleBackColor = true;
            this.radioPersonalizado.CheckedChanged += new System.EventHandler(this.RadioPersonalizado_CheckedChanged);
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
            this.radioUE.CheckedChanged += new System.EventHandler(this.RadioUE_CheckedChanged);
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
            this.radioCloracion.CheckedChanged += new System.EventHandler(this.RadioCloracion_CheckedChanged);
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
            this.radioGenerica.CheckedChanged += new System.EventHandler(this.RadioGenerica_CheckedChanged);
            // 
            // txtInicio
            // 
            this.txtInicio.Location = new System.Drawing.Point(105, 22);
            this.txtInicio.Margin = new System.Windows.Forms.Padding(4);
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Size = new System.Drawing.Size(164, 22);
            this.txtInicio.TabIndex = 1;
            // 
            // chkVerificacion
            // 
            this.chkVerificacion.AutoSize = true;
            this.chkVerificacion.Location = new System.Drawing.Point(105, 268);
            this.chkVerificacion.Margin = new System.Windows.Forms.Padding(4);
            this.chkVerificacion.Name = "chkVerificacion";
            this.chkVerificacion.Size = new System.Drawing.Size(144, 21);
            this.chkVerificacion.TabIndex = 5;
            this.chkVerificacion.Text = "Inlcuir Verificacion";
            this.chkVerificacion.UseVisualStyleBackColor = true;
            this.chkVerificacion.CheckedChanged += new System.EventHandler(this.ChkVerificacion_CheckedChanged);
            // 
            // chkOrdenados
            // 
            this.chkOrdenados.AutoSize = true;
            this.chkOrdenados.Location = new System.Drawing.Point(105, 240);
            this.chkOrdenados.Margin = new System.Windows.Forms.Padding(4);
            this.chkOrdenados.Name = "chkOrdenados";
            this.chkOrdenados.Size = new System.Drawing.Size(162, 21);
            this.chkOrdenados.TabIndex = 5;
            this.chkOrdenados.Text = "Numeros Ordenados";
            this.chkOrdenados.UseVisualStyleBackColor = true;
            this.chkOrdenados.CheckedChanged += new System.EventHandler(this.ChkOrdenados_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inicio";
            // 
            // chkRango
            // 
            this.chkRango.AutoSize = true;
            this.chkRango.Location = new System.Drawing.Point(105, 184);
            this.chkRango.Margin = new System.Windows.Forms.Padding(4);
            this.chkRango.Name = "chkRango";
            this.chkRango.Size = new System.Drawing.Size(119, 21);
            this.chkRango.TabIndex = 4;
            this.chkRango.Text = "Utilizar Rango";
            this.chkRango.UseVisualStyleBackColor = true;
            this.chkRango.CheckedChanged += new System.EventHandler(this.ChkRango_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(54, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tope";
            // 
            // chkDuplicados
            // 
            this.chkDuplicados.AutoSize = true;
            this.chkDuplicados.Location = new System.Drawing.Point(105, 210);
            this.chkDuplicados.Margin = new System.Windows.Forms.Padding(4);
            this.chkDuplicados.Name = "chkDuplicados";
            this.chkDuplicados.Size = new System.Drawing.Size(152, 21);
            this.chkDuplicados.TabIndex = 4;
            this.chkDuplicados.Text = "Permitir Duplicados";
            this.chkDuplicados.UseVisualStyleBackColor = true;
            this.chkDuplicados.CheckedChanged += new System.EventHandler(this.ChkDuplicados_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cantidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 156);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Verificacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 123);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Rango";
            // 
            // txtCantVerificacion
            // 
            this.txtCantVerificacion.Enabled = false;
            this.txtCantVerificacion.Location = new System.Drawing.Point(105, 152);
            this.txtCantVerificacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantVerificacion.Name = "txtCantVerificacion";
            this.txtCantVerificacion.Size = new System.Drawing.Size(164, 22);
            this.txtCantVerificacion.TabIndex = 3;
            // 
            // txtRango
            // 
            this.txtRango.Enabled = false;
            this.txtRango.Location = new System.Drawing.Point(105, 119);
            this.txtRango.Margin = new System.Windows.Forms.Padding(4);
            this.txtRango.Name = "txtRango";
            this.txtRango.Size = new System.Drawing.Size(164, 22);
            this.txtRango.TabIndex = 3;
            // 
            // txtTope
            // 
            this.txtTope.Location = new System.Drawing.Point(105, 54);
            this.txtTope.Margin = new System.Windows.Forms.Padding(4);
            this.txtTope.Name = "txtTope";
            this.txtTope.Size = new System.Drawing.Size(164, 22);
            this.txtTope.TabIndex = 2;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(105, 86);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(164, 22);
            this.txtCantidad.TabIndex = 3;
            // 
            // dateTimePickerFechaSorteo
            // 
            this.dateTimePickerFechaSorteo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaSorteo.Location = new System.Drawing.Point(157, 12);
            this.dateTimePickerFechaSorteo.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerFechaSorteo.Name = "dateTimePickerFechaSorteo";
            this.dateTimePickerFechaSorteo.Size = new System.Drawing.Size(143, 22);
            this.dateTimePickerFechaSorteo.TabIndex = 16;
            // 
            // labelFechaSorteo
            // 
            this.labelFechaSorteo.AutoSize = true;
            this.labelFechaSorteo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaSorteo.Location = new System.Drawing.Point(13, 15);
            this.labelFechaSorteo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFechaSorteo.Name = "labelFechaSorteo";
            this.labelFechaSorteo.Size = new System.Drawing.Size(118, 18);
            this.labelFechaSorteo.TabIndex = 11;
            this.labelFechaSorteo.Text = "Fecha de Sorteo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(511, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Verificacion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(304, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Numeros Sorteados:";
            // 
            // dataGridNumeros
            // 
            this.dataGridNumeros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridNumeros.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridNumeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNumeros.Location = new System.Drawing.Point(307, 32);
            this.dataGridNumeros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridNumeros.Name = "dataGridNumeros";
            this.dataGridNumeros.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridNumeros.RowTemplate.Height = 24;
            this.dataGridNumeros.Size = new System.Drawing.Size(198, 527);
            this.dataGridNumeros.TabIndex = 26;
            // 
            // dataGridVerificacion
            // 
            this.dataGridVerificacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridVerificacion.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridVerificacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVerificacion.Location = new System.Drawing.Point(511, 32);
            this.dataGridVerificacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridVerificacion.Name = "dataGridVerificacion";
            this.dataGridVerificacion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridVerificacion.RowTemplate.Height = 24;
            this.dataGridVerificacion.Size = new System.Drawing.Size(198, 527);
            this.dataGridVerificacion.TabIndex = 27;
            // 
            // groupBoxOpciones
            // 
            this.groupBoxOpciones.Controls.Add(this.txtInicio);
            this.groupBoxOpciones.Controls.Add(this.chkRango);
            this.groupBoxOpciones.Controls.Add(this.txtTope);
            this.groupBoxOpciones.Controls.Add(this.label4);
            this.groupBoxOpciones.Controls.Add(this.label7);
            this.groupBoxOpciones.Controls.Add(this.label3);
            this.groupBoxOpciones.Controls.Add(this.label1);
            this.groupBoxOpciones.Controls.Add(this.txtCantidad);
            this.groupBoxOpciones.Controls.Add(this.txtRango);
            this.groupBoxOpciones.Controls.Add(this.chkVerificacion);
            this.groupBoxOpciones.Controls.Add(this.chkDuplicados);
            this.groupBoxOpciones.Controls.Add(this.txtCantVerificacion);
            this.groupBoxOpciones.Controls.Add(this.label5);
            this.groupBoxOpciones.Controls.Add(this.chkOrdenados);
            this.groupBoxOpciones.Location = new System.Drawing.Point(16, 44);
            this.groupBoxOpciones.Name = "groupBoxOpciones";
            this.groupBoxOpciones.Size = new System.Drawing.Size(284, 299);
            this.groupBoxOpciones.TabIndex = 28;
            this.groupBoxOpciones.TabStop = false;
            this.groupBoxOpciones.Text = "Opciones";
            // 
            // SorteoNumeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(720, 630);
            this.Controls.Add(this.groupBoxOpciones);
            this.Controls.Add(this.dataGridVerificacion);
            this.Controls.Add(this.grupoTipoSorteo);
            this.Controls.Add(this.dataGridNumeros);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePickerFechaSorteo);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelFechaSorteo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SorteoNumeros";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sorteo de Numeros";
            this.panelBotones.ResumeLayout(false);
            this.grupoTipoSorteo.ResumeLayout(false);
            this.grupoTipoSorteo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNumeros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVerificacion)).EndInit();
            this.groupBoxOpciones.ResumeLayout(false);
            this.groupBoxOpciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.TextBox txtInicio;
        private System.Windows.Forms.CheckBox chkVerificacion;
        private System.Windows.Forms.CheckBox chkOrdenados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkRango;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkDuplicados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCantVerificacion;
        private System.Windows.Forms.TextBox txtRango;
        private System.Windows.Forms.TextBox txtTope;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.GroupBox grupoTipoSorteo;
        private System.Windows.Forms.RadioButton radioLado;
        private System.Windows.Forms.RadioButton radioPersonalizado;
        private System.Windows.Forms.RadioButton radioUE;
        private System.Windows.Forms.RadioButton radioCloracion;
        private System.Windows.Forms.RadioButton radioGenerica;
        private System.Windows.Forms.Button btnGuardarPDF;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaSorteo;
        private System.Windows.Forms.Label labelFechaSorteo;
        private System.Windows.Forms.RadioButton radioHaccp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridNumeros;
        private System.Windows.Forms.DataGridView dataGridVerificacion;
        private System.Windows.Forms.GroupBox groupBoxOpciones;
    }
}
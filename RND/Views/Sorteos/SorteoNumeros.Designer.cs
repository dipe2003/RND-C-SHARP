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
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnGuardarPDF = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridVerificacion = new System.Windows.Forms.DataGridView();
            this.dataGridNumeros = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.grupoTipoSorteo = new System.Windows.Forms.GroupBox();
            this.radioLado = new System.Windows.Forms.RadioButton();
            this.radioHaccp = new System.Windows.Forms.RadioButton();
            this.radioPersonalizado = new System.Windows.Forms.RadioButton();
            this.radioUE = new System.Windows.Forms.RadioButton();
            this.radioCloracion = new System.Windows.Forms.RadioButton();
            this.radioGenerica = new System.Windows.Forms.RadioButton();
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
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerFechaSorteo = new System.Windows.Forms.DateTimePicker();
            this.labelFechaSorteo = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVerificacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNumeros)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.grupoTipoSorteo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnGuardarPDF);
            this.panel4.Controls.Add(this.btnCerrar);
            this.panel4.Controls.Add(this.btnGenerar);
            this.panel4.Location = new System.Drawing.Point(244, 481);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(377, 40);
            this.panel4.TabIndex = 15;
            // 
            // btnGuardarPDF
            // 
            this.btnGuardarPDF.Location = new System.Drawing.Point(262, 7);
            this.btnGuardarPDF.Name = "btnGuardarPDF";
            this.btnGuardarPDF.Size = new System.Drawing.Size(103, 28);
            this.btnGuardarPDF.TabIndex = 7;
            this.btnGuardarPDF.Text = "Guardar";
            this.btnGuardarPDF.UseVisualStyleBackColor = true;
            this.btnGuardarPDF.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(14, 7);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(103, 28);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(143, 7);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(103, 28);
            this.btnGenerar.TabIndex = 7;
            this.btnGenerar.Text = "Sortear";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.BtnGenerar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Numeros Sorteados:";
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dataGridVerificacion);
            this.panel3.Controls.Add(this.dataGridNumeros);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(244, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(377, 432);
            this.panel3.TabIndex = 13;
            // 
            // dataGridVerificacion
            // 
            this.dataGridVerificacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridVerificacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVerificacion.Location = new System.Drawing.Point(197, 22);
            this.dataGridVerificacion.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridVerificacion.Name = "dataGridVerificacion";
            this.dataGridVerificacion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridVerificacion.RowTemplate.Height = 24;
            this.dataGridVerificacion.Size = new System.Drawing.Size(168, 399);
            this.dataGridVerificacion.TabIndex = 27;
            // 
            // dataGridNumeros
            // 
            this.dataGridNumeros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridNumeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNumeros.Location = new System.Drawing.Point(14, 19);
            this.dataGridNumeros.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridNumeros.Name = "dataGridNumeros";
            this.dataGridNumeros.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridNumeros.RowTemplate.Height = 24;
            this.dataGridNumeros.Size = new System.Drawing.Size(168, 402);
            this.dataGridNumeros.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(197, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Verificacion";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(10, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 477);
            this.panel1.TabIndex = 12;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.grupoTipoSorteo);
            this.panel5.Location = new System.Drawing.Point(17, 274);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(201, 194);
            this.panel5.TabIndex = 7;
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
            this.grupoTipoSorteo.Location = new System.Drawing.Point(4, 3);
            this.grupoTipoSorteo.Name = "grupoTipoSorteo";
            this.grupoTipoSorteo.Size = new System.Drawing.Size(189, 186);
            this.grupoTipoSorteo.TabIndex = 0;
            this.grupoTipoSorteo.TabStop = false;
            this.grupoTipoSorteo.Text = "Sorteos";
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
            this.radioLado.CheckedChanged += new System.EventHandler(this.RadioLado_CheckedChanged);
            // 
            // radioHaccp
            // 
            this.radioHaccp.AutoSize = true;
            this.radioHaccp.Location = new System.Drawing.Point(17, 123);
            this.radioHaccp.Name = "radioHaccp";
            this.radioHaccp.Size = new System.Drawing.Size(61, 17);
            this.radioHaccp.TabIndex = 0;
            this.radioHaccp.Text = "HACCP";
            this.radioHaccp.UseVisualStyleBackColor = true;
            this.radioHaccp.CheckedChanged += new System.EventHandler(this.RadioHaccpCheckedChanged);
            // 
            // radioPersonalizado
            // 
            this.radioPersonalizado.AutoSize = true;
            this.radioPersonalizado.Checked = true;
            this.radioPersonalizado.Location = new System.Drawing.Point(17, 146);
            this.radioPersonalizado.Name = "radioPersonalizado";
            this.radioPersonalizado.Size = new System.Drawing.Size(91, 17);
            this.radioPersonalizado.TabIndex = 0;
            this.radioPersonalizado.TabStop = true;
            this.radioPersonalizado.Text = "Personalizado";
            this.radioPersonalizado.UseVisualStyleBackColor = true;
            this.radioPersonalizado.CheckedChanged += new System.EventHandler(this.RadioPersonalizado_CheckedChanged);
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
            this.radioUE.CheckedChanged += new System.EventHandler(this.RadioUE_CheckedChanged);
            // 
            // radioCloracion
            // 
            this.radioCloracion.AutoSize = true;
            this.radioCloracion.Location = new System.Drawing.Point(17, 46);
            this.radioCloracion.Name = "radioCloracion";
            this.radioCloracion.Size = new System.Drawing.Size(120, 17);
            this.radioCloracion.TabIndex = 0;
            this.radioCloracion.Text = "Control de Cloracion";
            this.radioCloracion.UseVisualStyleBackColor = true;
            this.radioCloracion.CheckedChanged += new System.EventHandler(this.RadioCloracion_CheckedChanged);
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
            this.radioGenerica.CheckedChanged += new System.EventHandler(this.RadioGenerica_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.panel2.Location = new System.Drawing.Point(17, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 250);
            this.panel2.TabIndex = 6;
            // 
            // txtInicio
            // 
            this.txtInicio.Location = new System.Drawing.Point(69, 26);
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Size = new System.Drawing.Size(124, 20);
            this.txtInicio.TabIndex = 1;
            // 
            // chkVerificacion
            // 
            this.chkVerificacion.AutoSize = true;
            this.chkVerificacion.Location = new System.Drawing.Point(69, 226);
            this.chkVerificacion.Name = "chkVerificacion";
            this.chkVerificacion.Size = new System.Drawing.Size(112, 17);
            this.chkVerificacion.TabIndex = 5;
            this.chkVerificacion.Text = "Inlcuir Verificacion";
            this.chkVerificacion.UseVisualStyleBackColor = true;
            this.chkVerificacion.CheckedChanged += new System.EventHandler(this.ChkVerificacion_CheckedChanged);
            // 
            // chkOrdenados
            // 
            this.chkOrdenados.AutoSize = true;
            this.chkOrdenados.Location = new System.Drawing.Point(69, 203);
            this.chkOrdenados.Name = "chkOrdenados";
            this.chkOrdenados.Size = new System.Drawing.Size(123, 17);
            this.chkOrdenados.TabIndex = 5;
            this.chkOrdenados.Text = "Numeros Ordenados";
            this.chkOrdenados.UseVisualStyleBackColor = true;
            this.chkOrdenados.CheckedChanged += new System.EventHandler(this.ChkOrdenados_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inicio";
            // 
            // chkRango
            // 
            this.chkRango.AutoSize = true;
            this.chkRango.Location = new System.Drawing.Point(69, 158);
            this.chkRango.Name = "chkRango";
            this.chkRango.Size = new System.Drawing.Size(92, 17);
            this.chkRango.TabIndex = 4;
            this.chkRango.Text = "Utilizar Rango";
            this.chkRango.UseVisualStyleBackColor = true;
            this.chkRango.CheckedChanged += new System.EventHandler(this.ChkRango_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(31, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tope";
            // 
            // chkDuplicados
            // 
            this.chkDuplicados.AutoSize = true;
            this.chkDuplicados.Location = new System.Drawing.Point(69, 179);
            this.chkDuplicados.Name = "chkDuplicados";
            this.chkDuplicados.Size = new System.Drawing.Size(116, 17);
            this.chkDuplicados.TabIndex = 4;
            this.chkDuplicados.Text = "Permitir Duplicados";
            this.chkDuplicados.UseVisualStyleBackColor = true;
            this.chkDuplicados.CheckedChanged += new System.EventHandler(this.ChkDuplicados_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cantidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Verificacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Rango";
            // 
            // txtCantVerificacion
            // 
            this.txtCantVerificacion.Enabled = false;
            this.txtCantVerificacion.Location = new System.Drawing.Point(69, 132);
            this.txtCantVerificacion.Name = "txtCantVerificacion";
            this.txtCantVerificacion.Size = new System.Drawing.Size(124, 20);
            this.txtCantVerificacion.TabIndex = 3;
            // 
            // txtRango
            // 
            this.txtRango.Enabled = false;
            this.txtRango.Location = new System.Drawing.Point(69, 105);
            this.txtRango.Name = "txtRango";
            this.txtRango.Size = new System.Drawing.Size(124, 20);
            this.txtRango.TabIndex = 3;
            // 
            // txtTope
            // 
            this.txtTope.Location = new System.Drawing.Point(69, 52);
            this.txtTope.Name = "txtTope";
            this.txtTope.Size = new System.Drawing.Size(124, 20);
            this.txtTope.TabIndex = 2;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(69, 78);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(124, 20);
            this.txtCantidad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Opciones";
            // 
            // dateTimePickerFechaSorteo
            // 
            this.dateTimePickerFechaSorteo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaSorteo.Location = new System.Drawing.Point(121, 12);
            this.dateTimePickerFechaSorteo.Name = "dateTimePickerFechaSorteo";
            this.dateTimePickerFechaSorteo.Size = new System.Drawing.Size(108, 20);
            this.dateTimePickerFechaSorteo.TabIndex = 16;
            // 
            // labelFechaSorteo
            // 
            this.labelFechaSorteo.AutoSize = true;
            this.labelFechaSorteo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaSorteo.Location = new System.Drawing.Point(16, 12);
            this.labelFechaSorteo.Name = "labelFechaSorteo";
            this.labelFechaSorteo.Size = new System.Drawing.Size(97, 15);
            this.labelFechaSorteo.TabIndex = 11;
            this.labelFechaSorteo.Text = "Fecha de Sorteo";
            // 
            // SorteoNumeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(636, 532);
            this.Controls.Add(this.dateTimePickerFechaSorteo);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelFechaSorteo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(510, 570);
            this.Name = "SorteoNumeros";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sorteo de Numeros";
            this.TopMost = true;
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVerificacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNumeros)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.grupoTipoSorteo.ResumeLayout(false);
            this.grupoTipoSorteo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridVerificacion;
        private System.Windows.Forms.DataGridView dataGridNumeros;
        private System.Windows.Forms.Button btnGuardarPDF;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaSorteo;
        private System.Windows.Forms.Label labelFechaSorteo;
        private System.Windows.Forms.RadioButton radioHaccp;
    }
}
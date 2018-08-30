namespace RND.Views {
    partial class SorteoFechas {
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
            this.fechaInicio = new System.Windows.Forms.DateTimePicker();
            this.fechaTope = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnSortear = new System.Windows.Forms.Button();
            this.dataGridFechas = new System.Windows.Forms.DataGridView();
            this.chkDomingos = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkOrdenados = new System.Windows.Forms.CheckBox();
            this.chkDuplicados = new System.Windows.Forms.CheckBox();
            this.grupoTipoSorteo = new System.Windows.Forms.GroupBox();
            this.radioPersonalizado = new System.Windows.Forms.RadioButton();
            this.radioMes = new System.Windows.Forms.RadioButton();
            this.radioDiaSemana = new System.Windows.Forms.RadioButton();
            this.groupBoxOpciones = new System.Windows.Forms.GroupBox();
            this.dateTimePickerFechaSorteo = new System.Windows.Forms.DateTimePicker();
            this.labelFechaSorteo = new System.Windows.Forms.Label();
            this.panelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFechas)).BeginInit();
            this.grupoTipoSorteo.SuspendLayout();
            this.groupBoxOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // fechaInicio
            // 
            this.fechaInicio.Location = new System.Drawing.Point(10, 56);
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.Size = new System.Drawing.Size(257, 22);
            this.fechaInicio.TabIndex = 0;
            // 
            // fechaTope
            // 
            this.fechaTope.Location = new System.Drawing.Point(10, 110);
            this.fechaTope.Name = "fechaTope";
            this.fechaTope.Size = new System.Drawing.Size(257, 22);
            this.fechaTope.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(10, 166);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(256, 22);
            this.txtCantidad.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(308, 19);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Fechas Sorteadas:";
            // 
            // panelBotones
            // 
            this.panelBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBotones.Controls.Add(this.btnCerrar);
            this.panelBotones.Controls.Add(this.btnSortear);
            this.panelBotones.Location = new System.Drawing.Point(307, 565);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(383, 51);
            this.panelBotones.TabIndex = 18;
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(2)))), ((int)(((byte)(123)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(220, 8);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(145, 34);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnSortear
            // 
            this.btnSortear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(2)))), ((int)(((byte)(123)))));
            this.btnSortear.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSortear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortear.Location = new System.Drawing.Point(9, 8);
            this.btnSortear.Margin = new System.Windows.Forms.Padding(4);
            this.btnSortear.Name = "btnSortear";
            this.btnSortear.Size = new System.Drawing.Size(151, 34);
            this.btnSortear.TabIndex = 7;
            this.btnSortear.Text = "Sortear";
            this.btnSortear.UseVisualStyleBackColor = false;
            this.btnSortear.Click += new System.EventHandler(this.btnSortear_Click);
            // 
            // dataGridFechas
            // 
            this.dataGridFechas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridFechas.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridFechas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFechas.Location = new System.Drawing.Point(307, 44);
            this.dataGridFechas.Name = "dataGridFechas";
            this.dataGridFechas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridFechas.RowTemplate.Height = 24;
            this.dataGridFechas.Size = new System.Drawing.Size(383, 515);
            this.dataGridFechas.TabIndex = 25;
            // 
            // chkDomingos
            // 
            this.chkDomingos.AutoSize = true;
            this.chkDomingos.Location = new System.Drawing.Point(43, 204);
            this.chkDomingos.Margin = new System.Windows.Forms.Padding(4);
            this.chkDomingos.Name = "chkDomingos";
            this.chkDomingos.Size = new System.Drawing.Size(134, 21);
            this.chkDomingos.TabIndex = 19;
            this.chkDomingos.Text = "Inlcuir Domingos";
            this.chkDomingos.UseVisualStyleBackColor = true;
            this.chkDomingos.CheckedChanged += new System.EventHandler(this.chkDomingos_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Fecha Inicio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Fecha Tope:";
            // 
            // chkOrdenados
            // 
            this.chkOrdenados.AutoSize = true;
            this.chkOrdenados.Location = new System.Drawing.Point(42, 262);
            this.chkOrdenados.Margin = new System.Windows.Forms.Padding(4);
            this.chkOrdenados.Name = "chkOrdenados";
            this.chkOrdenados.Size = new System.Drawing.Size(151, 21);
            this.chkOrdenados.TabIndex = 23;
            this.chkOrdenados.Text = "Fechas Ordenadas";
            this.chkOrdenados.UseVisualStyleBackColor = true;
            this.chkOrdenados.CheckedChanged += new System.EventHandler(this.chkOrdenados_CheckedChanged);
            // 
            // chkDuplicados
            // 
            this.chkDuplicados.AutoSize = true;
            this.chkDuplicados.Location = new System.Drawing.Point(42, 233);
            this.chkDuplicados.Margin = new System.Windows.Forms.Padding(4);
            this.chkDuplicados.Name = "chkDuplicados";
            this.chkDuplicados.Size = new System.Drawing.Size(152, 21);
            this.chkDuplicados.TabIndex = 22;
            this.chkDuplicados.Text = "Permitir Duplicados";
            this.chkDuplicados.UseVisualStyleBackColor = true;
            this.chkDuplicados.CheckedChanged += new System.EventHandler(this.chkDuplicados_CheckedChanged);
            // 
            // grupoTipoSorteo
            // 
            this.grupoTipoSorteo.Controls.Add(this.radioPersonalizado);
            this.grupoTipoSorteo.Controls.Add(this.radioMes);
            this.grupoTipoSorteo.Controls.Add(this.radioDiaSemana);
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
            // radioPersonalizado
            // 
            this.radioPersonalizado.AutoSize = true;
            this.radioPersonalizado.Checked = true;
            this.radioPersonalizado.Location = new System.Drawing.Point(41, 120);
            this.radioPersonalizado.Margin = new System.Windows.Forms.Padding(4);
            this.radioPersonalizado.Name = "radioPersonalizado";
            this.radioPersonalizado.Size = new System.Drawing.Size(119, 21);
            this.radioPersonalizado.TabIndex = 0;
            this.radioPersonalizado.TabStop = true;
            this.radioPersonalizado.Text = "Personalizado";
            this.radioPersonalizado.UseVisualStyleBackColor = true;
            this.radioPersonalizado.CheckedChanged += new System.EventHandler(this.radioPersonalizado_CheckedChanged);
            // 
            // radioMes
            // 
            this.radioMes.AutoSize = true;
            this.radioMes.Location = new System.Drawing.Point(41, 91);
            this.radioMes.Margin = new System.Windows.Forms.Padding(4);
            this.radioMes.Name = "radioMes";
            this.radioMes.Size = new System.Drawing.Size(107, 21);
            this.radioMes.TabIndex = 0;
            this.radioMes.Text = "Mes del Año";
            this.radioMes.UseVisualStyleBackColor = true;
            this.radioMes.CheckedChanged += new System.EventHandler(this.radioMes_CheckedChanged);
            // 
            // radioDiaSemana
            // 
            this.radioDiaSemana.AutoSize = true;
            this.radioDiaSemana.Location = new System.Drawing.Point(41, 61);
            this.radioDiaSemana.Margin = new System.Windows.Forms.Padding(4);
            this.radioDiaSemana.Name = "radioDiaSemana";
            this.radioDiaSemana.Size = new System.Drawing.Size(141, 21);
            this.radioDiaSemana.TabIndex = 0;
            this.radioDiaSemana.Text = "Dia de la Semana";
            this.radioDiaSemana.UseVisualStyleBackColor = true;
            this.radioDiaSemana.CheckedChanged += new System.EventHandler(this.radioDiaSemana_CheckedChanged);
            // 
            // groupBoxOpciones
            // 
            this.groupBoxOpciones.Controls.Add(this.chkOrdenados);
            this.groupBoxOpciones.Controls.Add(this.label4);
            this.groupBoxOpciones.Controls.Add(this.txtCantidad);
            this.groupBoxOpciones.Controls.Add(this.label1);
            this.groupBoxOpciones.Controls.Add(this.chkDuplicados);
            this.groupBoxOpciones.Controls.Add(this.fechaTope);
            this.groupBoxOpciones.Controls.Add(this.label2);
            this.groupBoxOpciones.Controls.Add(this.chkDomingos);
            this.groupBoxOpciones.Controls.Add(this.fechaInicio);
            this.groupBoxOpciones.Location = new System.Drawing.Point(16, 44);
            this.groupBoxOpciones.Name = "groupBoxOpciones";
            this.groupBoxOpciones.Size = new System.Drawing.Size(284, 291);
            this.groupBoxOpciones.TabIndex = 26;
            this.groupBoxOpciones.TabStop = false;
            this.groupBoxOpciones.Text = "Opciones";
            // 
            // dateTimePickerFechaSorteo
            // 
            this.dateTimePickerFechaSorteo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaSorteo.Location = new System.Drawing.Point(157, 15);
            this.dateTimePickerFechaSorteo.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerFechaSorteo.Name = "dateTimePickerFechaSorteo";
            this.dateTimePickerFechaSorteo.Size = new System.Drawing.Size(143, 22);
            this.dateTimePickerFechaSorteo.TabIndex = 25;
            // 
            // labelFechaSorteo
            // 
            this.labelFechaSorteo.AutoSize = true;
            this.labelFechaSorteo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaSorteo.Location = new System.Drawing.Point(13, 18);
            this.labelFechaSorteo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFechaSorteo.Name = "labelFechaSorteo";
            this.labelFechaSorteo.Size = new System.Drawing.Size(118, 18);
            this.labelFechaSorteo.TabIndex = 24;
            this.labelFechaSorteo.Text = "Fecha de Sorteo";
            // 
            // SorteoFechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(720, 630);
            this.Controls.Add(this.dateTimePickerFechaSorteo);
            this.Controls.Add(this.labelFechaSorteo);
            this.Controls.Add(this.groupBoxOpciones);
            this.Controls.Add(this.grupoTipoSorteo);
            this.Controls.Add(this.dataGridFechas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panelBotones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SorteoFechas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sorteo de Fechas";
            this.panelBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFechas)).EndInit();
            this.grupoTipoSorteo.ResumeLayout(false);
            this.grupoTipoSorteo.PerformLayout();
            this.groupBoxOpciones.ResumeLayout(false);
            this.groupBoxOpciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker fechaInicio;
        private System.Windows.Forms.DateTimePicker fechaTope;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnSortear;
        private System.Windows.Forms.CheckBox chkDomingos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkDuplicados;
        private System.Windows.Forms.CheckBox chkOrdenados;
        private System.Windows.Forms.GroupBox grupoTipoSorteo;
        private System.Windows.Forms.RadioButton radioPersonalizado;
        private System.Windows.Forms.RadioButton radioMes;
        private System.Windows.Forms.RadioButton radioDiaSemana;
        private System.Windows.Forms.DataGridView dataGridFechas;
        private System.Windows.Forms.GroupBox groupBoxOpciones;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaSorteo;
        private System.Windows.Forms.Label labelFechaSorteo;
    }
}
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnSortear = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridFechas = new System.Windows.Forms.DataGridView();
            this.chkDomingos = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkOrdenados = new System.Windows.Forms.CheckBox();
            this.chkDuplicados = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grupoTipoSorteo = new System.Windows.Forms.GroupBox();
            this.radioPersonalizado = new System.Windows.Forms.RadioButton();
            this.radioMes = new System.Windows.Forms.RadioButton();
            this.radioDiaSemana = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFechas)).BeginInit();
            this.panel1.SuspendLayout();
            this.grupoTipoSorteo.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // fechaInicio
            // 
            this.fechaInicio.Location = new System.Drawing.Point(14, 39);
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.Size = new System.Drawing.Size(200, 22);
            this.fechaInicio.TabIndex = 0;
            // 
            // fechaTope
            // 
            this.fechaTope.Location = new System.Drawing.Point(14, 100);
            this.fechaTope.Name = "fechaTope";
            this.fechaTope.Size = new System.Drawing.Size(200, 22);
            this.fechaTope.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 141);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(13, 162);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(200, 22);
            this.txtCantidad.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(292, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Fechas Sorteadas:";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnCerrar);
            this.panel4.Controls.Add(this.btnSortear);
            this.panel4.Location = new System.Drawing.Point(295, 415);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(283, 51);
            this.panel4.TabIndex = 18;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(156, 8);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(115, 34);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnSortear
            // 
            this.btnSortear.Location = new System.Drawing.Point(9, 8);
            this.btnSortear.Margin = new System.Windows.Forms.Padding(4);
            this.btnSortear.Name = "btnSortear";
            this.btnSortear.Size = new System.Drawing.Size(112, 34);
            this.btnSortear.TabIndex = 7;
            this.btnSortear.Text = "Sortear";
            this.btnSortear.UseVisualStyleBackColor = true;
            this.btnSortear.Click += new System.EventHandler(this.btnSortear_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dataGridFechas);
            this.panel3.Location = new System.Drawing.Point(295, 35);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(283, 373);
            this.panel3.TabIndex = 16;
            // 
            // dataGridFechas
            // 
            this.dataGridFechas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridFechas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFechas.Location = new System.Drawing.Point(9, 14);
            this.dataGridFechas.Name = "dataGridFechas";
            this.dataGridFechas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridFechas.RowTemplate.Height = 24;
            this.dataGridFechas.Size = new System.Drawing.Size(262, 344);
            this.dataGridFechas.TabIndex = 25;
            // 
            // chkDomingos
            // 
            this.chkDomingos.AutoSize = true;
            this.chkDomingos.Location = new System.Drawing.Point(13, 205);
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
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Fecha Inicio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Fecha Tope:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkOrdenados);
            this.panel1.Controls.Add(this.chkDuplicados);
            this.panel1.Controls.Add(this.chkDomingos);
            this.panel1.Controls.Add(this.fechaInicio);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.fechaTope);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtCantidad);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(26, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 294);
            this.panel1.TabIndex = 22;
            // 
            // chkOrdenados
            // 
            this.chkOrdenados.AutoSize = true;
            this.chkOrdenados.Location = new System.Drawing.Point(12, 263);
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
            this.chkDuplicados.Location = new System.Drawing.Point(12, 234);
            this.chkDuplicados.Margin = new System.Windows.Forms.Padding(4);
            this.chkDuplicados.Name = "chkDuplicados";
            this.chkDuplicados.Size = new System.Drawing.Size(152, 21);
            this.chkDuplicados.TabIndex = 22;
            this.chkDuplicados.Text = "Permitir Duplicados";
            this.chkDuplicados.UseVisualStyleBackColor = true;
            this.chkDuplicados.CheckedChanged += new System.EventHandler(this.chkDuplicados_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Opciones";
            // 
            // grupoTipoSorteo
            // 
            this.grupoTipoSorteo.Controls.Add(this.radioPersonalizado);
            this.grupoTipoSorteo.Controls.Add(this.radioMes);
            this.grupoTipoSorteo.Controls.Add(this.radioDiaSemana);
            this.grupoTipoSorteo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grupoTipoSorteo.Location = new System.Drawing.Point(13, 4);
            this.grupoTipoSorteo.Margin = new System.Windows.Forms.Padding(4);
            this.grupoTipoSorteo.Name = "grupoTipoSorteo";
            this.grupoTipoSorteo.Padding = new System.Windows.Forms.Padding(4);
            this.grupoTipoSorteo.Size = new System.Drawing.Size(199, 119);
            this.grupoTipoSorteo.TabIndex = 0;
            this.grupoTipoSorteo.TabStop = false;
            this.grupoTipoSorteo.Text = "Sorteos";
            // 
            // radioPersonalizado
            // 
            this.radioPersonalizado.AutoSize = true;
            this.radioPersonalizado.Checked = true;
            this.radioPersonalizado.Location = new System.Drawing.Point(23, 86);
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
            this.radioMes.Location = new System.Drawing.Point(23, 57);
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
            this.radioDiaSemana.Location = new System.Drawing.Point(23, 27);
            this.radioDiaSemana.Margin = new System.Windows.Forms.Padding(4);
            this.radioDiaSemana.Name = "radioDiaSemana";
            this.radioDiaSemana.Size = new System.Drawing.Size(141, 21);
            this.radioDiaSemana.TabIndex = 0;
            this.radioDiaSemana.Text = "Dia de la Semana";
            this.radioDiaSemana.UseVisualStyleBackColor = true;
            this.radioDiaSemana.CheckedChanged += new System.EventHandler(this.radioDiaSemana_CheckedChanged);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.grupoTipoSorteo);
            this.panel5.Location = new System.Drawing.Point(26, 334);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(229, 132);
            this.panel5.TabIndex = 24;
            // 
            // SorteoFechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 482);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SorteoFechas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sorteo de Fechas";
            this.TopMost = true;
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFechas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grupoTipoSorteo.ResumeLayout(false);
            this.grupoTipoSorteo.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker fechaInicio;
        private System.Windows.Forms.DateTimePicker fechaTope;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnSortear;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox chkDomingos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkDuplicados;
        private System.Windows.Forms.CheckBox chkOrdenados;
        private System.Windows.Forms.GroupBox grupoTipoSorteo;
        private System.Windows.Forms.RadioButton radioPersonalizado;
        private System.Windows.Forms.RadioButton radioMes;
        private System.Windows.Forms.RadioButton radioDiaSemana;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridFechas;
    }
}
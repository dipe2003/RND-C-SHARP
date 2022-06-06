namespace RND.Views.Sorteos {
    partial class SorteoPicos {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            this.chkOrdenados = new System.Windows.Forms.CheckBox();
            this.chkDuplicados = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.dateTimePickerFechaSorteo = new System.Windows.Forms.DateTimePicker();
            this.labelFechaSorteo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridSectores = new System.Windows.Forms.DataGridView();
            this.dataGridPicosSorteados = new System.Windows.Forms.DataGridView();
            this.groupBoxOpciones = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAyuda = new System.Windows.Forms.Button();
            this.buttonConfiguracion = new System.Windows.Forms.Button();
            this.checkBoxAnularSeleccion = new System.Windows.Forms.CheckBox();
            this.panelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSectores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPicosSorteados)).BeginInit();
            this.groupBoxOpciones.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBotones
            // 
            this.panelBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBotones.Controls.Add(this.btnGuardarPDF);
            this.panelBotones.Controls.Add(this.btnCerrar);
            this.panelBotones.Controls.Add(this.btnGenerar);
            this.panelBotones.Location = new System.Drawing.Point(261, 487);
            this.panelBotones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(536, 40);
            this.panelBotones.TabIndex = 15;
            // 
            // btnGuardarPDF
            // 
            this.btnGuardarPDF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGuardarPDF.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(2)))), ((int)(((byte)(123)))));
            this.btnGuardarPDF.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuardarPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPDF.Location = new System.Drawing.Point(89, 5);
            this.btnGuardarPDF.Name = "btnGuardarPDF";
            this.btnGuardarPDF.Size = new System.Drawing.Size(109, 28);
            this.btnGuardarPDF.TabIndex = 7;
            this.btnGuardarPDF.Text = "Exportar";
            this.btnGuardarPDF.UseVisualStyleBackColor = false;
            this.btnGuardarPDF.Click += new System.EventHandler(this.ButtonGuardarPDF_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(2)))), ((int)(((byte)(123)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(337, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(109, 28);
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
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(213, 5);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(109, 28);
            this.btnGenerar.TabIndex = 7;
            this.btnGenerar.Text = "Sortear";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.BtnGenerar_Click);
            // 
            // chkOrdenados
            // 
            this.chkOrdenados.AutoSize = true;
            this.chkOrdenados.Location = new System.Drawing.Point(77, 88);
            this.chkOrdenados.Name = "chkOrdenados";
            this.chkOrdenados.Size = new System.Drawing.Size(75, 20);
            this.chkOrdenados.TabIndex = 5;
            this.chkOrdenados.Text = "Ordenar";
            this.chkOrdenados.UseVisualStyleBackColor = true;
            this.chkOrdenados.CheckedChanged += new System.EventHandler(this.ChkOrdenados_CheckedChanged);
            // 
            // chkDuplicados
            // 
            this.chkDuplicados.AutoSize = true;
            this.chkDuplicados.Location = new System.Drawing.Point(77, 57);
            this.chkDuplicados.Name = "chkDuplicados";
            this.chkDuplicados.Size = new System.Drawing.Size(143, 20);
            this.chkDuplicados.TabIndex = 3;
            this.chkDuplicados.Text = "Permitir Duplicados";
            this.chkDuplicados.UseVisualStyleBackColor = true;
            this.chkDuplicados.CheckedChanged += new System.EventHandler(this.ChkDuplicados_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(77, 20);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(143, 22);
            this.txtCantidad.TabIndex = 2;
            // 
            // dateTimePickerFechaSorteo
            // 
            this.dateTimePickerFechaSorteo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFechaSorteo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaSorteo.Location = new System.Drawing.Point(124, 9);
            this.dateTimePickerFechaSorteo.Name = "dateTimePickerFechaSorteo";
            this.dateTimePickerFechaSorteo.Size = new System.Drawing.Size(127, 22);
            this.dateTimePickerFechaSorteo.TabIndex = 16;
            // 
            // labelFechaSorteo
            // 
            this.labelFechaSorteo.AutoSize = true;
            this.labelFechaSorteo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaSorteo.Location = new System.Drawing.Point(10, 12);
            this.labelFechaSorteo.Name = "labelFechaSorteo";
            this.labelFechaSorteo.Size = new System.Drawing.Size(107, 16);
            this.labelFechaSorteo.TabIndex = 11;
            this.labelFechaSorteo.Text = "Fecha de Sorteo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(445, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Sorteo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(258, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Sectores";
            // 
            // dataGridSectores
            // 
            this.dataGridSectores.AllowUserToAddRows = false;
            this.dataGridSectores.AllowUserToDeleteRows = false;
            this.dataGridSectores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridSectores.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridSectores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSectores.Location = new System.Drawing.Point(261, 36);
            this.dataGridSectores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridSectores.Name = "dataGridSectores";
            this.dataGridSectores.ReadOnly = true;
            this.dataGridSectores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridSectores.RowTemplate.Height = 24;
            this.dataGridSectores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSectores.Size = new System.Drawing.Size(182, 447);
            this.dataGridSectores.TabIndex = 26;
            // 
            // dataGridPicosSorteados
            // 
            this.dataGridPicosSorteados.AllowUserToAddRows = false;
            this.dataGridPicosSorteados.AllowUserToDeleteRows = false;
            this.dataGridPicosSorteados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridPicosSorteados.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridPicosSorteados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPicosSorteados.Location = new System.Drawing.Point(447, 36);
            this.dataGridPicosSorteados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridPicosSorteados.Name = "dataGridPicosSorteados";
            this.dataGridPicosSorteados.ReadOnly = true;
            this.dataGridPicosSorteados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridPicosSorteados.RowTemplate.Height = 24;
            this.dataGridPicosSorteados.Size = new System.Drawing.Size(350, 447);
            this.dataGridPicosSorteados.TabIndex = 27;
            // 
            // groupBoxOpciones
            // 
            this.groupBoxOpciones.Controls.Add(this.checkBoxAnularSeleccion);
            this.groupBoxOpciones.Controls.Add(this.label4);
            this.groupBoxOpciones.Controls.Add(this.txtCantidad);
            this.groupBoxOpciones.Controls.Add(this.chkDuplicados);
            this.groupBoxOpciones.Controls.Add(this.chkOrdenados);
            this.groupBoxOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxOpciones.Location = new System.Drawing.Point(12, 36);
            this.groupBoxOpciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxOpciones.Name = "groupBoxOpciones";
            this.groupBoxOpciones.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxOpciones.Size = new System.Drawing.Size(239, 145);
            this.groupBoxOpciones.TabIndex = 0;
            this.groupBoxOpciones.TabStop = false;
            this.groupBoxOpciones.Text = "Opciones";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonAyuda);
            this.panel1.Controls.Add(this.buttonConfiguracion);
            this.panel1.Location = new System.Drawing.Point(7, 487);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 40);
            this.panel1.TabIndex = 30;
            // 
            // buttonAyuda
            // 
            this.buttonAyuda.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonAyuda.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(2)))), ((int)(((byte)(123)))));
            this.buttonAyuda.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAyuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAyuda.Location = new System.Drawing.Point(125, 5);
            this.buttonAyuda.Name = "buttonAyuda";
            this.buttonAyuda.Size = new System.Drawing.Size(107, 28);
            this.buttonAyuda.TabIndex = 7;
            this.buttonAyuda.Text = "Ayuda";
            this.buttonAyuda.UseVisualStyleBackColor = false;
            // 
            // buttonConfiguracion
            // 
            this.buttonConfiguracion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonConfiguracion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(2)))), ((int)(((byte)(123)))));
            this.buttonConfiguracion.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfiguracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfiguracion.Location = new System.Drawing.Point(12, 5);
            this.buttonConfiguracion.Name = "buttonConfiguracion";
            this.buttonConfiguracion.Size = new System.Drawing.Size(106, 28);
            this.buttonConfiguracion.TabIndex = 7;
            this.buttonConfiguracion.Text = "Configuracion";
            this.buttonConfiguracion.UseVisualStyleBackColor = false;
            this.buttonConfiguracion.Click += new System.EventHandler(this.buttonConfiguracion_Click);
            // 
            // checkBoxAnularSeleccion
            // 
            this.checkBoxAnularSeleccion.AutoSize = true;
            this.checkBoxAnularSeleccion.Location = new System.Drawing.Point(77, 119);
            this.checkBoxAnularSeleccion.Name = "checkBoxAnularSeleccion";
            this.checkBoxAnularSeleccion.Size = new System.Drawing.Size(127, 20);
            this.checkBoxAnularSeleccion.TabIndex = 6;
            this.checkBoxAnularSeleccion.Text = "Anular Seleccion";
            this.checkBoxAnularSeleccion.UseVisualStyleBackColor = true;
            this.checkBoxAnularSeleccion.CheckedChanged += new System.EventHandler(this.checkBoxAnularSeleccion_CheckedChanged);
            // 
            // SorteoPicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBoxOpciones);
            this.Controls.Add(this.dataGridPicosSorteados);
            this.Controls.Add(this.dataGridSectores);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePickerFechaSorteo);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelFechaSorteo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SorteoPicos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sorteo de Numeros";
            this.panelBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSectores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPicosSorteados)).EndInit();
            this.groupBoxOpciones.ResumeLayout(false);
            this.groupBoxOpciones.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.CheckBox chkOrdenados;
        private System.Windows.Forms.CheckBox chkDuplicados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnGuardarPDF;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaSorteo;
        private System.Windows.Forms.Label labelFechaSorteo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridSectores;
        private System.Windows.Forms.DataGridView dataGridPicosSorteados;
        private System.Windows.Forms.GroupBox groupBoxOpciones;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonConfiguracion;
        private System.Windows.Forms.Button buttonAyuda;
        private System.Windows.Forms.CheckBox checkBoxAnularSeleccion;
    }
}
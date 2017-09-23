namespace RND.Printing {
    partial class PrintForm {
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalASortear = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblVerificacion = new System.Windows.Forms.Label();
            this.chkOrdenados = new System.Windows.Forms.CheckBox();
            this.chkRango = new System.Windows.Forms.CheckBox();
            this.chkDuplicados = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtRango = new System.Windows.Forms.Label();
            this.txtInicio = new System.Windows.Forms.Label();
            this.txtTotalSorteo = new System.Windows.Forms.Label();
            this.txtTope = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTipoSorteo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.Label();
            this.imprimirSorteo = new System.Drawing.Printing.PrintDocument();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridNumeros = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridVerificacion = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNumeros)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVerificacion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Sorteo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Inicio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tope:";
            // 
            // lblTotalASortear
            // 
            this.lblTotalASortear.AutoSize = true;
            this.lblTotalASortear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalASortear.Location = new System.Drawing.Point(18, 100);
            this.lblTotalASortear.Name = "lblTotalASortear";
            this.lblTotalASortear.Size = new System.Drawing.Size(123, 17);
            this.lblTotalASortear.TabIndex = 0;
            this.lblTotalASortear.Text = "Total a Sortear:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Sorteo:";
            // 
            // lblVerificacion
            // 
            this.lblVerificacion.AutoSize = true;
            this.lblVerificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerificacion.Location = new System.Drawing.Point(5, 5);
            this.lblVerificacion.Name = "lblVerificacion";
            this.lblVerificacion.Size = new System.Drawing.Size(151, 17);
            this.lblVerificacion.TabIndex = 0;
            this.lblVerificacion.Text = "Sorteo Verificacion:";
            // 
            // chkOrdenados
            // 
            this.chkOrdenados.AutoSize = true;
            this.chkOrdenados.Location = new System.Drawing.Point(296, 99);
            this.chkOrdenados.Margin = new System.Windows.Forms.Padding(4);
            this.chkOrdenados.Name = "chkOrdenados";
            this.chkOrdenados.Size = new System.Drawing.Size(162, 21);
            this.chkOrdenados.TabIndex = 8;
            this.chkOrdenados.Text = "Numeros Ordenados";
            this.chkOrdenados.UseVisualStyleBackColor = true;
            // 
            // chkRango
            // 
            this.chkRango.AutoSize = true;
            this.chkRango.Location = new System.Drawing.Point(296, 27);
            this.chkRango.Margin = new System.Windows.Forms.Padding(4);
            this.chkRango.Name = "chkRango";
            this.chkRango.Size = new System.Drawing.Size(119, 21);
            this.chkRango.TabIndex = 6;
            this.chkRango.Text = "Utilizar Rango";
            this.chkRango.UseVisualStyleBackColor = true;
            // 
            // chkDuplicados
            // 
            this.chkDuplicados.AutoSize = true;
            this.chkDuplicados.Location = new System.Drawing.Point(296, 62);
            this.chkDuplicados.Margin = new System.Windows.Forms.Padding(4);
            this.chkDuplicados.Name = "chkDuplicados";
            this.chkDuplicados.Size = new System.Drawing.Size(152, 21);
            this.chkDuplicados.TabIndex = 7;
            this.chkDuplicados.Text = "Permitir Duplicados";
            this.chkDuplicados.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtRango);
            this.panel1.Controls.Add(this.chkOrdenados);
            this.panel1.Controls.Add(this.chkRango);
            this.panel1.Controls.Add(this.chkDuplicados);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblTotalASortear);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtInicio);
            this.panel1.Controls.Add(this.txtTotalSorteo);
            this.panel1.Controls.Add(this.txtTope);
            this.panel1.Location = new System.Drawing.Point(24, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 136);
            this.panel1.TabIndex = 9;
            // 
            // txtRango
            // 
            this.txtRango.AutoSize = true;
            this.txtRango.Location = new System.Drawing.Point(422, 28);
            this.txtRango.Name = "txtRango";
            this.txtRango.Size = new System.Drawing.Size(45, 17);
            this.txtRango.TabIndex = 9;
            this.txtRango.Text = "rango";
            // 
            // txtInicio
            // 
            this.txtInicio.AutoSize = true;
            this.txtInicio.Location = new System.Drawing.Point(145, 31);
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Size = new System.Drawing.Size(104, 17);
            this.txtInicio.TabIndex = 0;
            this.txtInicio.Text = "inicio de sorteo";
            // 
            // txtTotalSorteo
            // 
            this.txtTotalSorteo.AutoSize = true;
            this.txtTotalSorteo.Location = new System.Drawing.Point(145, 100);
            this.txtTotalSorteo.Name = "txtTotalSorteo";
            this.txtTotalSorteo.Size = new System.Drawing.Size(96, 17);
            this.txtTotalSorteo.TabIndex = 0;
            this.txtTotalSorteo.Text = "total a sortear";
            // 
            // txtTope
            // 
            this.txtTope.AutoSize = true;
            this.txtTope.Location = new System.Drawing.Point(145, 66);
            this.txtTope.Name = "txtTope";
            this.txtTope.Size = new System.Drawing.Size(100, 17);
            this.txtTope.TabIndex = 0;
            this.txtTope.Text = "tope de sorteo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Opciones:";
            // 
            // txtTipoSorteo
            // 
            this.txtTipoSorteo.AutoSize = true;
            this.txtTipoSorteo.Location = new System.Drawing.Point(169, 9);
            this.txtTipoSorteo.Name = "txtTipoSorteo";
            this.txtTipoSorteo.Size = new System.Drawing.Size(95, 17);
            this.txtTipoSorteo.TabIndex = 0;
            this.txtTipoSorteo.Text = "tipo de sorteo";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(317, 9);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(57, 17);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha:";
            // 
            // txtFecha
            // 
            this.txtFecha.AutoSize = true;
            this.txtFecha.Location = new System.Drawing.Point(407, 9);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(107, 17);
            this.txtFecha.TabIndex = 0;
            this.txtFecha.Text = "fecha de sorteo";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(449, 618);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(113, 33);
            this.btnImprimir.TabIndex = 10;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridNumeros);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(24, 218);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(287, 394);
            this.panel2.TabIndex = 11;
            // 
            // dataGridNumeros
            // 
            this.dataGridNumeros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridNumeros.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridNumeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNumeros.Location = new System.Drawing.Point(12, 25);
            this.dataGridNumeros.Name = "dataGridNumeros";
            this.dataGridNumeros.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridNumeros.RowTemplate.Height = 24;
            this.dataGridNumeros.Size = new System.Drawing.Size(260, 357);
            this.dataGridNumeros.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridVerificacion);
            this.panel3.Controls.Add(this.lblVerificacion);
            this.panel3.Location = new System.Drawing.Point(320, 218);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(242, 394);
            this.panel3.TabIndex = 12;
            // 
            // dataGridVerificacion
            // 
            this.dataGridVerificacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridVerificacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVerificacion.Location = new System.Drawing.Point(12, 25);
            this.dataGridVerificacion.Name = "dataGridVerificacion";
            this.dataGridVerificacion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridVerificacion.RowTemplate.Height = 24;
            this.dataGridVerificacion.Size = new System.Drawing.Size(213, 357);
            this.dataGridVerificacion.TabIndex = 28;
            // 
            // PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 674);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtTipoSorteo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "PrintForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Imprimir Sorteo";
            this.Shown += new System.EventHandler(this.PrintForm_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNumeros)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVerificacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalASortear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblVerificacion;
        private System.Windows.Forms.CheckBox chkOrdenados;
        private System.Windows.Forms.CheckBox chkRango;
        private System.Windows.Forms.CheckBox chkDuplicados;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtTipoSorteo;
        private System.Windows.Forms.Label txtInicio;
        private System.Windows.Forms.Label txtTope;
        private System.Windows.Forms.Label txtTotalSorteo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label txtFecha;
        private System.Drawing.Printing.PrintDocument imprimirSorteo;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label txtRango;
        private System.Windows.Forms.DataGridView dataGridNumeros;
        private System.Windows.Forms.DataGridView dataGridVerificacion;
    }
}
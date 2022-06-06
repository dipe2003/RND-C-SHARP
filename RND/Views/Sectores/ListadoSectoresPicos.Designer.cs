
namespace RND.Views.Sectores {
    partial class ListadoSectoresPicos {
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewListadoPicosSectores = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.buttonNuevoSector = new System.Windows.Forms.Button();
            this.buttonNuevoPico = new System.Windows.Forms.Button();
            this.buttonEditarSector = new System.Windows.Forms.Button();
            this.buttonEditarPico = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListadoPicosSectores)).BeginInit();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(26, 23);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1458, 973);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelTitulo);
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1713, 148);
            this.panel2.TabIndex = 1;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Liberation Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(32, 48);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(717, 53);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "LISTA DE SECTORES Y PICOS";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewListadoPicosSectores);
            this.panel1.Location = new System.Drawing.Point(6, 166);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1135, 808);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewListadoPicosSectores
            // 
            this.dataGridViewListadoPicosSectores.AllowUserToAddRows = false;
            this.dataGridViewListadoPicosSectores.AllowUserToDeleteRows = false;
            this.dataGridViewListadoPicosSectores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewListadoPicosSectores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewListadoPicosSectores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListadoPicosSectores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewListadoPicosSectores.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewListadoPicosSectores.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridViewListadoPicosSectores.Name = "dataGridViewListadoPicosSectores";
            this.dataGridViewListadoPicosSectores.ReadOnly = true;
            this.dataGridViewListadoPicosSectores.RowHeadersWidth = 82;
            this.dataGridViewListadoPicosSectores.Size = new System.Drawing.Size(1135, 808);
            this.dataGridViewListadoPicosSectores.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Location = new System.Drawing.Point(1153, 166);
            this.panel3.Margin = new System.Windows.Forms.Padding(6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(290, 808);
            this.panel3.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.buttonCerrar, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.buttonNuevoSector, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonNuevoPico, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonEditarSector, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonEditarPico, 0, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 796);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Location = new System.Drawing.Point(6, 382);
            this.buttonCerrar.Margin = new System.Windows.Forms.Padding(6);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(274, 85);
            this.buttonCerrar.TabIndex = 2;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // buttonNuevoSector
            // 
            this.buttonNuevoSector.Location = new System.Drawing.Point(6, 6);
            this.buttonNuevoSector.Margin = new System.Windows.Forms.Padding(6);
            this.buttonNuevoSector.Name = "buttonNuevoSector";
            this.buttonNuevoSector.Size = new System.Drawing.Size(274, 85);
            this.buttonNuevoSector.TabIndex = 0;
            this.buttonNuevoSector.Text = "Nuevo Sector";
            this.buttonNuevoSector.UseVisualStyleBackColor = true;
            this.buttonNuevoSector.Click += new System.EventHandler(this.buttonNuevoSector_Click);
            // 
            // buttonNuevoPico
            // 
            this.buttonNuevoPico.Location = new System.Drawing.Point(6, 103);
            this.buttonNuevoPico.Margin = new System.Windows.Forms.Padding(6);
            this.buttonNuevoPico.Name = "buttonNuevoPico";
            this.buttonNuevoPico.Size = new System.Drawing.Size(274, 85);
            this.buttonNuevoPico.TabIndex = 0;
            this.buttonNuevoPico.Text = "Nuevo Pico";
            this.buttonNuevoPico.UseVisualStyleBackColor = true;
            this.buttonNuevoPico.Click += new System.EventHandler(this.buttonNuevoPico_Click);
            // 
            // buttonEditarSector
            // 
            this.buttonEditarSector.Location = new System.Drawing.Point(6, 200);
            this.buttonEditarSector.Margin = new System.Windows.Forms.Padding(6);
            this.buttonEditarSector.Name = "buttonEditarSector";
            this.buttonEditarSector.Size = new System.Drawing.Size(274, 85);
            this.buttonEditarSector.TabIndex = 0;
            this.buttonEditarSector.Text = "Editar Sector";
            this.buttonEditarSector.UseVisualStyleBackColor = true;
            this.buttonEditarSector.Click += new System.EventHandler(this.buttonEditarSector_Click);
            // 
            // buttonEditarPico
            // 
            this.buttonEditarPico.Location = new System.Drawing.Point(6, 297);
            this.buttonEditarPico.Margin = new System.Windows.Forms.Padding(6);
            this.buttonEditarPico.Name = "buttonEditarPico";
            this.buttonEditarPico.Size = new System.Drawing.Size(274, 73);
            this.buttonEditarPico.TabIndex = 0;
            this.buttonEditarPico.Text = "Editar Pico";
            this.buttonEditarPico.UseVisualStyleBackColor = true;
            this.buttonEditarPico.Click += new System.EventHandler(this.buttonEditarPico_Click);
            // 
            // ListadoSectoresPicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1506, 1019);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "ListadoSectoresPicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListadoSectoresPicos";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListadoPicosSectores)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewListadoPicosSectores;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonNuevoSector;
        private System.Windows.Forms.Button buttonNuevoPico;
        private System.Windows.Forms.Button buttonEditarSector;
        private System.Windows.Forms.Button buttonEditarPico;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button buttonCerrar;
    }
}
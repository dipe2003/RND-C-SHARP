
namespace RND.Views.Picos {
    partial class NuevoPico {
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
            this.textBoxNombrePico = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.comboBoxSectores = new System.Windows.Forms.ComboBox();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNumeroPico = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxNombrePico
            // 
            this.textBoxNombrePico.Location = new System.Drawing.Point(63, 292);
            this.textBoxNombrePico.Name = "textBoxNombrePico";
            this.textBoxNombrePico.Size = new System.Drawing.Size(458, 31);
            this.textBoxNombrePico.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre del Pico";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(316, 354);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(205, 52);
            this.buttonGuardar.TabIndex = 7;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(63, 354);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(205, 52);
            this.buttonCancelar.TabIndex = 6;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // comboBoxSectores
            // 
            this.comboBoxSectores.FormattingEnabled = true;
            this.comboBoxSectores.Location = new System.Drawing.Point(63, 87);
            this.comboBoxSectores.Name = "comboBoxSectores";
            this.comboBoxSectores.Size = new System.Drawing.Size(458, 33);
            this.comboBoxSectores.TabIndex = 8;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(58, 48);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(193, 25);
            this.label.TabIndex = 9;
            this.label.Text = "Seleccionar Sector";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numero de Pico";
            // 
            // textBoxNumeroPico
            // 
            this.textBoxNumeroPico.Location = new System.Drawing.Point(63, 183);
            this.textBoxNumeroPico.Name = "textBoxNumeroPico";
            this.textBoxNumeroPico.Size = new System.Drawing.Size(458, 31);
            this.textBoxNumeroPico.TabIndex = 5;
            // 
            // NuevoPico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 449);
            this.Controls.Add(this.label);
            this.Controls.Add(this.comboBoxSectores);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.textBoxNumeroPico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNombrePico);
            this.Controls.Add(this.label1);
            this.Name = "NuevoPico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NuevoPico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxNombrePico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.ComboBox comboBoxSectores;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNumeroPico;
    }
}
using PicosSectores.Clases;
using PicosSectores.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RND.Views.Picos {
    public partial class NuevoPico : Form {

        ControladorSectores cSectores = new ControladorSectores();
        ControladorPicos cPicos = new ControladorPicos();
        List<Sector> sectores;
        Sector sectorSeleccionado;
        IActualizable FormularioPadreActualizable;

        public NuevoPico(IActualizable formularioPadreActualizable) {
            InitializeComponent();
            this.sectores = cSectores.ListarSectores(true);
            comboBoxSectores.DataSource = sectores;
            comboBoxSectores.DisplayMember = "Nombre";
            comboBoxSectores.SelectedItem = comboBoxSectores.Items[0];
            sectorSeleccionado = comboBoxSectores.Items[0] as Sector;
            FormularioPadreActualizable = formularioPadreActualizable;
        }

        private void buttonCancelar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e) {
            int numeroPico = -1;
            string nombrePico = string.Empty;

            int.TryParse(textBoxNumeroPico.Text.Trim(), out numeroPico);
            if (!string.IsNullOrEmpty(textBoxNombrePico.Text) && textBoxNombrePico.Text.Length > 0) {
                nombrePico = textBoxNombrePico.Text.Trim();
            }

            sectorSeleccionado = (Sector)comboBoxSectores.SelectedItem;
                        
            if (sectores.Any(s => s.ExistePico(numeroPico)))  {
                MessageBox.Show($"El numero de pico {numeroPico} ya existe.");
            }else if(nombrePico.Length == 0) {
                MessageBox.Show("El nombre no es valido.");
            } else {
                if(cPicos.CrearPico(numeroPico, nombrePico, sectorSeleccionado.Id) != null){
                    MessageBox.Show($"El pico {nombrePico} del sector {sectorSeleccionado.Nombre} fue creado.");
                    FormularioPadreActualizable.ActualizarContenido();
                    this.Close();
                }
            }
        }
    }
}

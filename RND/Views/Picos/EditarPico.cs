using PicosSectores.Clases;
using PicosSectores.Controladores;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace RND.Views.Picos {
    public partial class EditarPico : Form {

        ControladorSectores cSectores = new ControladorSectores();
        ControladorPicos cPicos = new ControladorPicos();
        List<Sector> sectores;
        int idPicoSeleccionado;
        int numeroPico = -1;
        string nombrePico = string.Empty;
        Pico picoSeleccionado;
        Sector sectorSeleccionado;

        IActualizable FormularioPadreActualizable;

        public EditarPico() {
            InitializeComponent();
        }

        public EditarPico(int idPico, IActualizable formularioPadreActualizable) {
            InitializeComponent();
            this.idPicoSeleccionado = idPico;
            CargarDatos();
            FormularioPadreActualizable = formularioPadreActualizable;
        }

        private void CargarDatos() {
            sectores = cSectores.ListarSectores(true);
            picoSeleccionado = sectores.Where(s => s.ExistePico(idPicoSeleccionado)).First().FindPico(idPicoSeleccionado);
            sectorSeleccionado = picoSeleccionado.Sector;
            CargarSectores();

            textBoxNombrePico.Text = picoSeleccionado.Nombre;
            textBoxNumeroPico.Text = picoSeleccionado.Id.ToString();
        }

        private void CargarSectores() {
            comboBoxSectores.DataSource = sectores;
            comboBoxSectores.DisplayMember = "Nombre";
            comboBoxSectores.SelectedItem = picoSeleccionado.Sector;
        }

        private void buttonCancelar_Click(object sender, System.EventArgs e) {
            this.Close();
        }

        private void buttonGuardar_Click(object sender, System.EventArgs e) {
            sectorSeleccionado = (Sector)comboBoxSectores.SelectedItem;
            int.TryParse(textBoxNumeroPico.Text.Trim(), out numeroPico);
            if (!string.IsNullOrEmpty(textBoxNombrePico.Text) && textBoxNombrePico.Text.Length > 0) {
                nombrePico = textBoxNombrePico.Text.Trim();
            } else {
                MessageBox.Show("El nombre no es valido.");
                return;
            }
            if (numeroPico != picoSeleccionado.Id) {
                if (sectores.Any(s => s.ExistePico(numeroPico))) {
                    MessageBox.Show($"El numero de pico {numeroPico} ya existe.");
                }
            }
            GuardarCambioDePico();
            FormularioPadreActualizable.ActualizarContenido();
        }

        private void GuardarCambioDePico() {
            if (cPicos.EditarPico(picoSeleccionado.Id, numeroPico, nombrePico, picoSeleccionado.Sector.Id, sectorSeleccionado.Id) > 0) {
                MessageBox.Show($"El pico {nombrePico} del sector {sectorSeleccionado.Nombre} fue actualizado.");
                this.Close();
            }
        }

        private void buttonEliminar_Click(object sender, System.EventArgs e) {
            if (MessageBox.Show("Se eliminará el pico seleccionado. Esta acción no se puede deshacer.", "Eliminar?", MessageBoxButtons.OKCancel) == DialogResult.OK) {
                if (cPicos.EliminarPico(picoSeleccionado.Id) > 0) {
                    MessageBox.Show($"El pico {picoSeleccionado.Id} fue eliminado.");
                    FormularioPadreActualizable.ActualizarContenido();
                    this.Close();
                } else {
                    MessageBox.Show("Ocurrió un error. No se pudo eliminar el pico.");
                }
            }
        }
    }
}

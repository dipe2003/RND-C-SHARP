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

namespace RND.Views.Sectores {
    public partial class EditarSector : Form {

        ControladorSectores cSectores = new ControladorSectores();
        List<Sector> sectores;
        int idSectorSeleccionado;
        Sector sectorSeleccionado;
        IActualizable FormularioPadreActualizable;

        public EditarSector() {
            InitializeComponent();
            CargarDatos();
        }

        public EditarSector(int idSectorSeleccionado, IActualizable formularioPadreActualizable) {
            InitializeComponent();
            this.idSectorSeleccionado = idSectorSeleccionado;
            CargarDatos();
            FormularioPadreActualizable = formularioPadreActualizable;
        }

        private void CargarDatos() {
            sectores = cSectores.ListarSectores();
            this.sectorSeleccionado = sectores.Find(s => s.Id == idSectorSeleccionado);
            textBoxNombreSector.Text = sectorSeleccionado.Nombre;
        }

        private void buttonCancelar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(textBoxNombreSector.Text) && textBoxNombreSector.Text.Length > 0) {
                string nombre = (textBoxNombreSector.Text).Trim();
                if (sectores.Any(s => s.Nombre.ToLower().Equals(nombre.ToLower()))) {
                    MessageBox.Show($"Ya existe el Sector {nombre}.");
                } else {
                    if (cSectores.EditarSector(sectorSeleccionado.Id, nombre) >0) {
                        MessageBox.Show($"El sector {nombre} fue creado exitosamente.");
                        FormularioPadreActualizable.ActualizarContenido();
                        this.Close();
                    } else {
                        MessageBox.Show($"Ocurrió un error al intentar crear el Sector {nombre}.");
                    }
                }
            } else {
                MessageBox.Show("El nombre no es correcto.");
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Se eliminará el sector seleccionado. Esta acción no se puede deshacer.\n" +
                "Los picos asociados tambien seran elminados.", "Eliminar?", MessageBoxButtons.OKCancel) == DialogResult.OK) {
                if (cSectores.EliminarSector(sectorSeleccionado.Id) > 0) {
                    MessageBox.Show($"El sector {sectorSeleccionado.Nombre} fue eliminado.");
                    FormularioPadreActualizable.ActualizarContenido();
                    this.Close();
                } else {
                    MessageBox.Show("Ocurrió un error. No se pudo eliminar el sector.");
                }
            }
        }
    }
}

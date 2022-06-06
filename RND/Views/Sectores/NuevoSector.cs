using PicosSectores.Clases;
using PicosSectores.Controladores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RND.Views.Sectores {
    public partial class NuevoSector : Form {
        private ControladorSectores cSectores = new ControladorSectores();
        List<Sector> sectores;
        IActualizable FormularioPadreActualizable;

        public NuevoSector(IActualizable formularioPadreActualizable) {
            InitializeComponent();
            sectores = cSectores.ListarSectores();
            FormularioPadreActualizable = formularioPadreActualizable;
        }

        private void buttonGuardar_Click(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(textBoxNombreSector.Text) && textBoxNombreSector.Text.Length > 0) {
                string nombre = (textBoxNombreSector.Text).Trim();
                if (sectores.Any(s => s.Nombre.ToLower().Equals(nombre.ToLower()))) {
                    MessageBox.Show($"Ya existe el Sector {nombre}.");
                } else {
                    if (cSectores.CrearSector(nombre) != null) {
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


        private void buttonCancelar_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}

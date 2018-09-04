using RND.Clases;
using RND.Views;
using RND.Views.Ayuda;
using RND.Views.Sorteos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RND {
    public partial class Inicio:Form {
        public Inicio() {
            InitializeComponent();
            Form formulario = new AyudaGeneral();
            ManejadorMenu.AgregarFormularioEnPanel(panelContenido, formulario);
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e) {
            Form nuevo = new AcercaDeAplicacion();
            nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void buttonSorteoNumeros_Click(object sender, EventArgs e) {
            Form nuevo = new SorteoNumeros();
            ManejadorMenu.AgregarFormularioEnPanel(panelContenido, nuevo);
            ManejadorMenu.CambiarPanelMenu(panelLateralIzquierdo, panelContenido);
        }

        private void buttonSorteoFechas_Click(object sender, EventArgs e) {
            Form nuevo = new SorteoFechas();
            ManejadorMenu.AgregarFormularioEnPanel(panelContenido, nuevo);
            ManejadorMenu.CambiarPanelMenu(panelLateralIzquierdo, panelContenido);
        }

        private void buttonSalir_Click(object sender, EventArgs e) {
            ManejadorMenu.CerrarAplicacion();
        }

        private void labelRND_Click(object sender, EventArgs e) {
            new AcercaDeAplicacion().ShowDialog();
            ManejadorMenu.CambiarPanelMenu(panelLateralIzquierdo, panelContenido);
        }

        private void pictureBoxAccesoMenu_Click(object sender, EventArgs e) {
            ManejadorMenu.CambiarPanelMenu(panelLateralIzquierdo, panelContenido);
        }

        private void buttonAyuda_Click(object sender, EventArgs e) {
            String nombre = ManejadorMenu.ObtenerNombreFormularioAbierto(panelContenido);
            Form formulario;
            switch(nombre) {
                case "SorteoNumeros":
                    formulario = new AyudaSorteoNumeros();
                    ManejadorMenu.AgregarFormularioEnPanel(panelContenido, formulario);
                    break;

                case "SorteoFechas":
                    formulario = new AyudaSorteoFechas();
                    ManejadorMenu.AgregarFormularioEnPanel(panelContenido, formulario);
                    break;

                default:
                    formulario = new AyudaGeneral();
                    ManejadorMenu.AgregarFormularioEnPanel(panelContenido, formulario);
                    break;
            }
        }
    }
}

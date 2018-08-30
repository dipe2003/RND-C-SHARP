using RND.Clases;
using RND.Views;
using RND.Views.Sorteos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RND {
    public partial class Inicio :Form {
        public Inicio() {
            InitializeComponent();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e) {
            Form nuevo = new AcercaDeAplicacion();
            nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void buttonSorteoNumeros_Click(object sender, EventArgs e) {
            Form nuevo = new SorteoNumeros();
            ManejadorMenu.AgregarFormularioEnPanel(panelContenido, nuevo);
        }

        private void buttonSorteoFechas_Click(object sender, EventArgs e) {
            Form nuevo = new SorteoFechas();
            ManejadorMenu.AgregarFormularioEnPanel(panelContenido, nuevo);
        }

        private void buttonSalir_Click(object sender, EventArgs e) {
            ManejadorMenu.CerrarAplicacion();
        }

        private void labelRND_Click(object sender, EventArgs e) {
            new AcercaDeAplicacion().ShowDialog();
        }
    }
}

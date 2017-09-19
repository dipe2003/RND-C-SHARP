using RND.Clases;
using RND.Printing;
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

        private void AbirSorteoNumeros(object sender, EventArgs e) {
            Form nuevo = new SorteoNumeros();
            nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void AbrirSorteoFechas(object sender, EventArgs e) {
            Form nuevo = new SorteoFechas();
            nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void SalirApp(object sender, EventArgs e) {
            Application.Exit();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e) {
            Form nuevo = new AcercaDeAplicacion();
            nuevo.MdiParent = this;
            nuevo.Show();
        }
    }
}

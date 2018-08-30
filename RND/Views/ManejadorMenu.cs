using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RND.Views {
    static class ManejadorMenu {

        public static void AgregarFormularioEnPanel(Panel panel, Form formulario) {
            if(panel.Controls.Count!=0) panel.Controls.Clear();
            formulario.Dock = DockStyle.Fill;
            formulario.TopLevel = false;
            panel.Controls.Add(formulario);
            formulario.Show();
        }

        public static void CerrarAplicacion() {
            DialogResult res = MessageBox.Show("Estás seguro que quieres salir?", "Salir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == DialogResult.Yes) Application.Exit();
        }

    }
}

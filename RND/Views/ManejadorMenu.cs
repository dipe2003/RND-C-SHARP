using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RND.Views {
    static class ManejadorMenu {

        /// <summary>
        /// Agrega el formulario indicado en el panel seleccionado.
        /// Si existe otro formulario en el panel primero es removido.
        /// </summary>
        /// <param name="panel"></param>
        /// <param name="formulario"></param>
        public static void AgregarFormularioEnPanel(Panel panel, Form formulario) {
            if(panel.Controls.Count!=0) panel.Controls.Clear();
            formulario.Dock = DockStyle.Fill;
            formulario.TopLevel = false;
            panel.Controls.Add(formulario);
            formulario.Show();
        }

        /// <summary>
        /// Pide confirmacion y cierra la aplicacion si corresponde.
        /// </summary>
        public static void CerrarAplicacion() {
            DialogResult res = MessageBox.Show("Estás seguro que quieres salir?", "Salir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == DialogResult.Yes) Application.Exit();
        }

        /// <summary>
        /// Revela el panel de Menu y bloquea el panel indicado.
        /// </summary>
        /// <param name="panelMenu"></param>
        /// <param name="panelParaBloquear"></param>
        /// <param name="ancho"></param>
        public static void CambiarPanelMenu(Panel panelMenu, Panel panelParaBloquear, int ancho = 200) {
            if(panelMenu.Width == 0) {
                panelMenu.Width = ancho;
                panelParaBloquear.Enabled = false;
            } else {
                panelMenu.Width = 0;
                panelParaBloquear.Enabled = true;
            }
        }

        public static string ObtenerNombreFormularioAbierto(Panel panel) {
            if(panel.Controls.Count!=0) {
                return panel.Controls[0].Name;
            }
            return "";
        }
    }
}

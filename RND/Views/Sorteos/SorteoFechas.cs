using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RND.Views {
    public partial class SorteoFechas :Form {
        public SorteoFechas() {
            InitializeComponent();
        }

        private bool IncluirDomingos = false;
        private Random gen = new Random();

        private DateTime RandomDay() {
            DateTime start = new DateTime(1995, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(gen.Next(range));
        }

        private DateTime FechaInicio;
        private DateTime FechaTope;
        private int Cantidad;

        #region Opciones de Sorteo      
        private void chkDomingos_CheckedChanged(object sender, EventArgs e) {
            if(chkDomingos.Checked) {
                IncluirDomingos = true;
            } else {
                IncluirDomingos = false;
            }
        }

        /// <summary>
        /// Parsea los valores string ingresados al valor numerico correspondiente.
        /// Muestra cuadro de mensaje ante error.
        /// <return>True: si los valores son correctos, False de lo contrario.</return>
        /// </summary>
        private bool ObtenerParametrosNumericos() {
            try {
                if(this.txtCantidad.Enabled) Cantidad = int.Parse(this.txtCantidad.Text);                
            } catch(Exception ex) when(ex is FormatException || ex is NullReferenceException) {
                MostrarMensajeError(ex);
                return false;
            } catch(Exception ex) {
                MostrarMensajeError(ex);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Muestra un mesaje de error por valores no correctos.
        /// </summary>
        /// <param name="ex"></param>
        private void MostrarMensajeError(Exception ex) {
            MessageBox.Show("Faltan datos o los valores ingresados no son correctos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            System.Console.WriteLine("Error: " + ex.Message);
        }
        #endregion
    }
}

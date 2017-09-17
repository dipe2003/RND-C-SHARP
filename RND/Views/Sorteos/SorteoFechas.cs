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

        private Random rand = new Random();

        private bool IncluirDomingos = false;
        private bool PermitirDuplicados = false;
        private bool ResultadoOrdenado = false;

        private DateTime FechaInicio;
        private DateTime FechaTope;
        private int Cantidad;

        private DateTime[] Resultado;

        #region Opciones de Sorteo  

        /// <summary>
        /// Parsea los valores string ingresados al valor numerico correspondiente.
        /// Muestra cuadro de mensaje ante error.
        /// <return>True: si los valores son correctos, False de lo contrario.</return>
        /// </summary>
        private bool ObtenerParametrosNumericos() {
            try {
                if(this.txtCantidad.Enabled) Cantidad = int.Parse(this.txtCantidad.Text);
                FechaInicio = this.fechaInicio.Value;
                FechaTope = this.fechaTope.Value;
                PermitirDuplicados = this.chkDuplicados.Checked;
                IncluirDomingos = this.chkDomingos.Checked;
                ResultadoOrdenado = this.chkOrdenados.Checked;
            } catch(Exception ex) when(ex is FormatException || ex is NullReferenceException) {
                MostrarMensajeError(ex);
                return false;
            } catch(Exception ex) {
                MostrarMensajeError(ex);
                return false;
            }
            return true;
        }
        #endregion
        #region Metodos
        /// <summary>
        /// Muestra un mesaje de error por valores no correctos.
        /// </summary>
        /// <param name="ex"></param>
        private void MostrarMensajeError(Exception ex) {
            MessageBox.Show("Faltan datos o los valores ingresados no son correctos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            System.Console.WriteLine("Error: " + ex.Message);
        }

        /// <summary>
        /// Comprueba que el rango de fecha sea suficiente para el total a sortear.
        /// </summary>
        /// <param name="cantidad"></param>
        /// <param name="fechaInicio"></param>
        /// <param name="fechaTope"></param>
        /// <returns></returns>
        private bool ComprobarLimiteSorteo(int cantidad, DateTime fechaInicio, DateTime fechaTope) {
            int diferencia = fechaInicio.Day - fechaTope.Day;
            if(cantidad >= diferencia) {
                return false;
            }
            return true;
        }

        private DateTime RandomDay(DateTime fechaInicio, DateTime fechaTope, bool incluirDomingo) {
            int range = (fechaTope - fechaInicio).Days;
            DateTime dia = fechaInicio.AddDays(rand.Next(range));
            if(!incluirDomingo) {
                while(dia.DayOfWeek == DayOfWeek.Sunday) {
                    dia = fechaInicio.AddDays(rand.Next(range));
                }
            }
            return fechaInicio.AddDays(rand.Next(range));
        }

        /// <summary>
        /// Genera una string de los numeros indicados y los muestra en al cuadro de texto.
        /// </summary>
        /// <param name="Resultado"></param>
        /// <param name="ordenados"></param>
        /// <param name="contenedor"></param>
        private void MostrarResultado(List<DateTime> Resultado, bool ordenados, TextBox contenedor) {
            contenedor.Clear();
            string resultado = string.Empty;
            DateTime[] arr = new DateTime[Resultado.Count];
            if(ordenados) {
                Resultado.Sort();
            }
            foreach(DateTime fecha in Resultado) {
                resultado += fecha.ToShortDateString();
                if(Resultado.IndexOf(fecha) == Resultado.Count()) {
                    resultado += ".";
                } else {
                    resultado += System.Environment.NewLine;
                }
            }
            contenedor.Text = resultado;
        }

        #endregion

        private void btnSortear_Click(object sender, EventArgs e) {
            if(ObtenerParametrosNumericos()) {
                if(!ComprobarLimiteSorteo(Cantidad, FechaInicio, FechaTope)) {
                    MessageBox.Show("No se pueden sortear " + Cantidad.ToString() + " dias en el rango seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    Resultado = new DateTime[Cantidad];
                    for(int i = 0; i < Cantidad; i++) {
                        DateTime sorteo = RandomDay(FechaInicio, FechaTope, IncluirDomingos);
                        if(!PermitirDuplicados) {
                            while(Resultado.Contains(sorteo)) {
                                sorteo = RandomDay(FechaInicio, FechaTope, IncluirDomingos);
                            }
                        }
                        Resultado[i] = sorteo;
                    }
                    MostrarResultado(Resultado.ToList<DateTime>(), false, this.txtResultado);
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}

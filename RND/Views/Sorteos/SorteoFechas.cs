using RND.Clases;
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

        private EnumSorteo SorteoPredefinido = EnumSorteo.PERSONALIZADO;
        private EnumDiaSpanish[] DiasSemana = {
                EnumDiaSpanish.DOMINGO,
                EnumDiaSpanish.LUNES,
                EnumDiaSpanish.MARTES,
                EnumDiaSpanish.MIERCOLES,
                EnumDiaSpanish.JUEVES,
                EnumDiaSpanish.VIERNES,
                EnumDiaSpanish.SABADO
        };
        private EnumMesSpanish[] MesesAnio = {
                EnumMesSpanish.ENERO,
                EnumMesSpanish.FEBRERO,
                EnumMesSpanish.MARZO,
                EnumMesSpanish.ABRIL,
                EnumMesSpanish.MAYO,
                EnumMesSpanish.JUNIO,
                EnumMesSpanish.JULIO,
                EnumMesSpanish.AGOSTO,
                EnumMesSpanish.SETIEMBRE,
                EnumMesSpanish.OCTUBRE,
                EnumMesSpanish.NOVIEMBRE,
                EnumMesSpanish.DICIEMBRE
        };

        private Random rand = new Random();

        private bool IncluirDomingos = false;
        private bool PermitirDuplicados = false;
        private bool ResultadoOrdenado = false;

        private DateTime FechaInicio;
        private DateTime FechaTope;
        private int Cantidad;

        private DateTime[] Resultado;

        #region Metodos
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

        /// <summary>
        /// Comprueba que el rango de fecha sea suficiente para el total a sortear.
        /// </summary>
        /// <param name="cantidad"></param>
        /// <param name="fechaInicio"></param>
        /// <param name="fechaTope"></param>
        /// <returns></returns>
        private bool ComprobarLimiteSorteo(int cantidad, DateTime fechaInicio, DateTime fechaTope) {
            int diferencia = fechaTope.Subtract(fechaInicio).Days;
            if(cantidad >= diferencia) {
                return false;
            }
            return true;
        }

        private DateTime RandomDay(DateTime fechaInicio, DateTime fechaTope, bool incluirDomingo) {
            int range = (fechaTope - fechaInicio).Days;
            DateTime dia = fechaInicio.AddDays(rand.Next(range));
            if(!incluirDomingo) {
                while(dia.DayOfWeek.Equals(DayOfWeek.Sunday)) {
                    dia = fechaInicio.AddDays(rand.Next(range));
                } while(dia.DayOfWeek.Equals(DayOfWeek.Sunday)) ;
            }
            return dia;
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
            if(ordenados) {
                Resultado.Sort();
            }
            foreach(DateTime fecha in Resultado) {
                resultado += Resultado.IndexOf(fecha) + 1 + ") " + fecha.ToShortDateString();
                if(Resultado.IndexOf(fecha) == Resultado.Count()) {
                    resultado += ".";
                } else {
                    resultado += System.Environment.NewLine;
                }
            }
            contenedor.Text = resultado;
        }

        /// <summary>
        /// Genera una string de los numeros indicados y los muestra en al cuadro de texto.
        /// </summary>
        /// <param name="Resultado"></param>
        /// <param name="ordenados"></param>
        /// <param name="contenedor"></param>
        private void MostrarResultado(string Resultado, bool ordenados, TextBox contenedor) {
            contenedor.Clear();
            Resultado += "." + System.Environment.NewLine;
            contenedor.Text = Resultado;
        }

        private void SortearPersonalizado() {
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
                    MostrarResultado(Resultado.ToList<DateTime>(), ResultadoOrdenado, this.txtResultado);
                    //ArmarTabla(Resultado.ToList<DateTime>());
                }
            }
        }

        private void SortearDiaSemana() {
            Sorteo sorteo = new Personalizado { Inicio = 0, Tope = 6, Cantidad = 1 };
            sorteo.SortearNumeros();
            if(!IncluirDomingos) {
                while(sorteo.Resultado.Contains(0)) {
                    sorteo.Resultado.Clear();
                    sorteo.SortearNumeros();
                }
            }
            MostrarResultado(DiasSemana[sorteo.Resultado.FirstOrDefault()].ToString(), false, this.txtResultado);
        }

        private void SortearMesAnio() {
            Sorteo sorteo = new Personalizado { Inicio = 0, Tope = 11, Cantidad = 1 };
            sorteo.SortearNumeros();
            MostrarResultado(MesesAnio[sorteo.Resultado.FirstOrDefault()].ToString(), false, this.txtResultado);
        }

        //private void ArmarTabla(List<DateTime> fechasSorteadas) {
        //    this.dataGridFechas.Columns.Add("colNum", "Num");
        //    this.dataGridFechas.Columns.Add("colFecha", "Fecha");
        //    //this.dataGridFechas.Rows[num].Cells[0].Value = "Num";
        //    //this.dataGridFechas.Rows[num].Cells[0].Value = "Fecha";
        //    foreach(DateTime fecha in fechasSorteadas) {
        //        int num = this.dataGridFechas.Rows.Add();
        //        this.dataGridFechas.Rows[num].Cells[fechasSorteadas.IndexOf(fecha) + 1].Value = fechasSorteadas.IndexOf(fecha) + 1;
        //        this.dataGridFechas.Rows[num].Cells[fechasSorteadas.IndexOf(fecha) + 1].Value = fecha.ToShortDateString();
        //    }
        //}
        #endregion

        private void btnSortear_Click(object sender, EventArgs e) {
            switch(SorteoPredefinido) {
                case EnumSorteo.DIA_SEMANA:
                    SortearDiaSemana();
                    break;
                case EnumSorteo.MES_ANIO:
                    SortearMesAnio();
                    break;
                case EnumSorteo.PERSONALIZADO:
                    SortearPersonalizado();
                    break;
                default:
                    break;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e) {
            this.Close();
        }

        #region Predefinidos
        private void radioDiaSemana_CheckedChanged(object sender, EventArgs e) {
            this.SorteoPredefinido = EnumSorteo.DIA_SEMANA;

            //desactivar controles de personalizado
            this.fechaInicio.Enabled = false;
            this.fechaTope.Enabled = false;

            this.txtCantidad.Text = "1";
            this.txtCantidad.Enabled = false;

            this.chkDomingos.Enabled = true;
            this.chkDuplicados.Enabled = false;
            this.chkOrdenados.Enabled = false;
        }

        private void radioMes_CheckedChanged(object sender, EventArgs e) {
            this.SorteoPredefinido = EnumSorteo.MES_ANIO;

            //desactivar controles de personalizado
            this.fechaInicio.Enabled = false;
            this.fechaTope.Enabled = false;

            this.txtCantidad.Text = "1";
            this.txtCantidad.Enabled = false;

            this.chkDomingos.Enabled = false;
            this.chkDuplicados.Enabled = false;
            this.chkOrdenados.Enabled = false;
        }

        private void radioPersonalizado_CheckedChanged(object sender, EventArgs e) {
            this.SorteoPredefinido = EnumSorteo.PERSONALIZADO;

            //desactivar controles de personalizado
            this.fechaInicio.Enabled = true;
            this.fechaTope.Enabled = true;

            this.txtCantidad.Text = string.Empty;
            this.txtCantidad.Enabled = true;

            this.chkDomingos.Enabled = true;
            this.chkDuplicados.Enabled = true;
            this.chkOrdenados.Enabled = true;
        }


        #endregion

        #region Opciones
        private void chkDomingos_CheckedChanged(object sender, EventArgs e) {
            if(chkDomingos.Checked) {
                this.IncluirDomingos = true;
            } else {
                this.IncluirDomingos = false;
            }
        }

        private void chkDuplicados_CheckedChanged(object sender, EventArgs e) {
            if(chkDuplicados.Checked) {
                this.PermitirDuplicados = true;
            } else {
                this.PermitirDuplicados = false;
            }
        }

        private void chkOrdenados_CheckedChanged(object sender, EventArgs e) {
            if(chkOrdenados.Checked) {
                this.ResultadoOrdenado = true;
            } else {
                this.ResultadoOrdenado = false;
            }
        }
        #endregion

    }
}

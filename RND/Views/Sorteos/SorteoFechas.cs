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

        /// <summary>
        /// Genera una fecha al azar entre la fecha inicio y fecha tope.
        /// Permite especificar si se incluyen los domingos.
        /// </summary>
        /// <param name="fechaInicio"></param>
        /// <param name="fechaTope"></param>
        /// <param name="incluirDomingo"></param>
        /// <returns></returns>
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
        /// Genera una string de los numeros indicados y los muestra en el datagrid.
        /// </summary>
        /// <param name="Resultado"></param>
        /// <param name="ordenados"></param>
        /// <param name="contenedor"></param>
        private void MostrarResultado(List<DateTime> Resultado, bool ordenados) {
            if(ordenados) {
                Resultado.Sort();
            }
            List<string> lista = new List<string>();
            foreach(DateTime fecha in Resultado) {
                lista.Add(fecha.ToShortDateString());
            }
            VistaTabla.LlenarTabla(lista, "#", "Fechas", this.dataGridFechas);
        }

        /// <summary>
        /// Genera una lista de fechas al azar.
        /// </summary>
        private void SortearPersonalizado() {
            if(ObtenerParametrosNumericos()) {
                if(!ComprobarLimiteSorteo(Cantidad, FechaInicio, FechaTope)) {
                    MessageBox.Show("No se pueden sortear " + Cantidad.ToString() + " dias en el rango seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    List<DateTime> Resultado = new List<DateTime>();
                    for(int i = 0; i < Cantidad; i++) {
                        DateTime sorteo = RandomDay(FechaInicio, FechaTope, IncluirDomingos);
                        if(!PermitirDuplicados) {
                            while(Resultado.Contains(sorteo)) {
                                sorteo = RandomDay(FechaInicio, FechaTope, IncluirDomingos);
                            }
                        }
                        Resultado.Add(sorteo);
                    }
                    MostrarResultado(Resultado, ResultadoOrdenado);
                }
            }
        }
        /// <summary>
        /// Genera un numero al azar y le asigna un dia de la semana.
        /// </summary>
        private void SortearDiaSemana() {
            Sorteo sorteo = new Personalizado { Inicio = 0, Tope = 6, Cantidad = 1 };
            sorteo.SortearNumeros();
            if(!IncluirDomingos) {
                while(sorteo.Resultado.Contains(0)) {
                    sorteo.Resultado.Clear();
                    sorteo.SortearNumeros();
                }
            }
            List<string> lista = new List<string>();
            lista.Add(DiasSemana[sorteo.Resultado.FirstOrDefault()].ToString());
            VistaTabla.LlenarTabla(lista, "#", "Dia", this.dataGridFechas);            
        }

        /// <summary>
        /// Genera un numero al azar y le asigna un mes de año
        /// </summary>
        private void SortearMesAnio() {
            Sorteo sorteo = new Personalizado { Inicio = 0, Tope = 11, Cantidad = 1 };
            sorteo.SortearNumeros();
            List<string> lista = new List<string>();
            lista.Add(MesesAnio[sorteo.Resultado.FirstOrDefault()].ToString());
            VistaTabla.LlenarTabla(lista, "#", "Mes", this.dataGridFechas);
        }
        

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

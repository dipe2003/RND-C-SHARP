using RND.Clases;
using RND.Clases.PdfText;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RND.Views {
    public partial class SorteoFechas:Form {
        public SorteoFechas() {
            InitializeComponent();
            FechaSorteo = DateTime.Today;
        }

        private EnumSorteo SorteoPredefinido = EnumSorteo.PERSONALIZADO;
        private EnumDiaSpanish[] DiasSemana = Enum.GetValues(typeof(EnumDiaSpanish)).Cast<EnumDiaSpanish>().ToArray();
        private EnumMesSpanish[] MesesAnio = Enum.GetValues(typeof(EnumMesSpanish)).Cast<EnumMesSpanish>().ToArray();
        private Random rand = new Random();

        private bool IncluirDomingos = false;
        private bool PermitirDuplicados = false;
        private bool ResultadoOrdenado = false;

        private DateTime FechaInicio;
        private DateTime FechaTope;
        private int Cantidad;

        private DateTime FechaSorteo = new DateTime();

        List<string> FechasSorteadas = new List<string>();

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
            FechasSorteadas = ConvertirLista(Resultado);
            VistaTabla.LlenarTabla(FechasSorteadas, "#", "Fechas", this.dataGridFechas);
        }


        private List<string> ConvertirLista(List<DateTime> listaOrigen) {
            List<string> lista = new List<string>();
            foreach(DateTime fecha in listaOrigen) {
                lista.Add(fecha.ToShortDateString());
            }
            return lista;
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
        /// Genera una lista de fechas al azar dentro de las semanas seleccionadas.
        /// </summary>
        private void SortearDiasPorSemana() {
            if(ObtenerParametrosNumericos()) {
                if(!ComprobarLimiteSorteo(Cantidad, FechaInicio, FechaTope) && Cantidad > 3) {
                    MessageBox.Show("No se pueden sortear " + Cantidad.ToString() + " dias en el rango seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }else if(FechaInicio.DayOfWeek != DayOfWeek.Sunday || FechaTope.DayOfWeek != DayOfWeek.Saturday) {
                    MessageBox.Show("No se pueden sortear " + Cantidad.ToString() + " dias en las semanas Selccionadas. \n" +
                        "Cada semana debe comenzar en Domingo y finalizar en Sábado." , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    List<DateTime> Resultado = new List<DateTime>();
                    Dictionary<int, List<DateTime>> SemanasDisponibles = ObtenerSemanasDisponibles(FechaInicio, FechaTope);

                    for(int i = 0; i < SemanasDisponibles.Count; i++) {
                        for(int a = 0; a < Cantidad; a++) {
                            DateTime sorteo = RandomDay(SemanasDisponibles.ElementAt(i).Value.First(), SemanasDisponibles.ElementAt(i).Value.Last(), IncluirDomingos);
                            if(!PermitirDuplicados) {
                                while(Resultado.Contains(sorteo)) {
                                    sorteo = RandomDay(SemanasDisponibles.ElementAt(i).Value.First(), SemanasDisponibles.ElementAt(i).Value.Last(), IncluirDomingos);
                                }
                            }
                            Resultado.Add(sorteo);
                        }
                    }
                    MostrarResultado(Resultado, ResultadoOrdenado);
                }
            }
        }

        /// <summary>
        /// Obtiene el numero de semana de la fecha indicada. Primer dia de la semana Domingo.
        /// </summary>
        /// <param name="fecha"></param>
        /// <returns></returns>
        private int ObtenerNumeroSemana(DateTime fecha) {
            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(fecha, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Sunday);
        }

        /// <summary>
        /// Obtiene un diccionario con indice equivalente al numero de la semana del  año
        /// </summary>
        /// <param name="fechaDesde"></param>
        /// <param name="fechaHasta"></param>
        /// <returns></returns>
        private Dictionary<int, List<DateTime>> ObtenerSemanasDisponibles(DateTime fechaDesde, DateTime fechaHasta) {
            Dictionary<int, List<DateTime>> SemanasDisponibles = new Dictionary<int, List<DateTime>>();
            int semanaInicio = ObtenerNumeroSemana(fechaDesde);
            int semanaTope = ObtenerNumeroSemana(fechaHasta);
            int totalDias = fechaHasta.Subtract(FechaInicio).Days;

            for(int i = semanaInicio; i <= semanaTope; i++) {
                List<DateTime> diasSemana = new List<DateTime>();
                for(int j = 0; j <= totalDias; j++) {
                    DateTime fechaAnalizada = fechaDesde.AddDays(j);
                    if(ObtenerNumeroSemana(fechaAnalizada) == i) {
                        diasSemana.Add(fechaAnalizada);
                    }
                }
                SemanasDisponibles.Add(i, diasSemana);
            }
            return SemanasDisponibles;
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
            FechasSorteadas.Add(DiasSemana[sorteo.Resultado.FirstOrDefault()].ToString());
            VistaTabla.LlenarTabla(FechasSorteadas, "#", "Dia", this.dataGridFechas);
        }

        /// <summary>
        /// Genera un numero al azar y le asigna un mes de año
        /// </summary>
        private void SortearMesAnio() {
            Sorteo sorteo = new Personalizado { Inicio = 0, Tope = 11, Cantidad = 1 };
            sorteo.SortearNumeros();
            FechasSorteadas.Add(MesesAnio[sorteo.Resultado.FirstOrDefault()].ToString());
            VistaTabla.LlenarTabla(FechasSorteadas, "#", "Mes", this.dataGridFechas);
        }


        #endregion

        private void btnSortear_Click(object sender, EventArgs e) {
            if(FechasSorteadas.Any()) FechasSorteadas.Clear();
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
                case EnumSorteo.DIAS_POR_SEMANA:
                    SortearDiasPorSemana();
                    break;
                default:
                    break;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void CambiarEstadoRadioButtons(bool duplicados = false, bool ordenados = false, bool domingos = false) {
            this.chkDuplicados.Checked = duplicados;
            this.chkOrdenados.Checked = ordenados;
            this.chkDomingos.Checked = domingos;
        }

        private void CambiarHabilitacionControles(bool inicio = false, bool tope = false, bool cantidad = false) {
            this.fechaInicio.Enabled = inicio;
            this.fechaTope.Enabled = tope;
            this.txtCantidad.Enabled = cantidad;
        }

        #region Predefinidos
        private void radioDiaSemana_CheckedChanged(object sender, EventArgs e) {
            this.SorteoPredefinido = EnumSorteo.DIA_SEMANA;

            //desactivar controles de personalizado
            CambiarHabilitacionControles();
            this.txtCantidad.Text = "1";
            CambiarEstadoRadioButtons(domingos: true);
        }

        private void radioMes_CheckedChanged(object sender, EventArgs e) {
            this.SorteoPredefinido = EnumSorteo.MES_ANIO;

            //desactivar controles de personalizado
            CambiarHabilitacionControles();
            this.txtCantidad.Text = "1";
            CambiarEstadoRadioButtons();
        }

        private void radioPersonalizado_CheckedChanged(object sender, EventArgs e) {
            this.SorteoPredefinido = EnumSorteo.PERSONALIZADO;

            //desactivar controles de personalizado
            CambiarHabilitacionControles(true, true, true);
            this.txtCantidad.Text = string.Empty;
            CambiarEstadoRadioButtons(true, true, true);
        }

        private void radioDiaPorSemana_CheckedChanged(object sender, EventArgs e) {
            this.SorteoPredefinido = EnumSorteo.DIAS_POR_SEMANA;

            // desactivar controles para sorteo seleccionado
            CambiarHabilitacionControles(inicio: true, tope: true, cantidad: true);
            this.txtCantidad.Text = string.Empty;
            CambiarEstadoRadioButtons(duplicados: false, ordenados: true, domingos: false);
        }

        #endregion

        #region Opciones
        private void chkDomingos_CheckedChanged(object sender, EventArgs e) {
            IncluirDomingos = (sender as CheckBox).Checked;
        }

        private void chkDuplicados_CheckedChanged(object sender, EventArgs e) {
            PermitirDuplicados = (sender as CheckBox).Checked;
        }

        private void chkOrdenados_CheckedChanged(object sender, EventArgs e) {
            ResultadoOrdenado = (sender as CheckBox).Checked;
        }
        #endregion

        private void btnGuardarPDF_Click(object sender, EventArgs e) {
            if(FechasSorteadas != null && FechasSorteadas.Any()) {
                SaveFileDialog dialogoDestino = new SaveFileDialog();
                dialogoDestino.Filter = "Archivo PDF (Portable Document Format)|*.pdf";
                StringBuilder strNombre = new StringBuilder();
                strNombre.Append(SorteoPredefinido.ToString())
                .Append(" ")
                .Append(FechaSorteo.ToShortDateString().Replace('/', '.'));
                dialogoDestino.FileName = strNombre.ToString();
                DialogResult resultado = dialogoDestino.ShowDialog();

                if(resultado == DialogResult.OK) {
                    this.Cursor = Cursors.WaitCursor;
                    string strFechaInicio = FechaInicio.ToShortDateString();
                    string strFechaTope = FechaTope.ToShortDateString();
                    string strTituloSorteo = SorteoPredefinido.ToString();
                    // Ajustar titulos segun tipo de sorteo
                    if(SorteoPredefinido == EnumSorteo.DIA_SEMANA || SorteoPredefinido == EnumSorteo.MES_ANIO) {
                        strFechaInicio = "---";
                        strFechaTope = "---";
                        strTituloSorteo = SorteoPredefinido != EnumSorteo.MES_ANIO ? "DIA DE LA SEMANA" : "MES DEL AÑO";
                    } else { 
                        strTituloSorteo = "DIAS POR SEMANA";
                    }
                    string destino = dialogoDestino.FileName;
                    ControladorPDF pdf = new ControladorPDF();
                    pdf.GuardarSorteoFechas(destino, "Sorteo: " + strTituloSorteo, FechaSorteo.ToShortDateString(),
                        strFechaInicio, strFechaTope, IncluirDomingos, FechasSorteadas);
                }
            } else {
                System.Windows.Forms.MessageBox.Show("No se ha realizado ningún sorteo.", "?", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
            }
            this.Cursor = Cursors.Default;
        }
    }
}

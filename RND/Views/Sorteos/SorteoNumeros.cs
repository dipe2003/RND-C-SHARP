using RND.Clases;
using RND.Clases.PdfText;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RND.Views.Sorteos {
    public partial class SorteoNumeros:Form {
        public SorteoNumeros() {
            InitializeComponent();
            FechaSorteo = DateTime.Today;
        }

        /*
        * Propiedades / Variables
        */
        private bool UtilizarRango = false;
        private bool IncluirVerificacion = false;
        private bool PermitirDuplicados = false;
        private bool OrdenarResultado = false;

        private int Inicio;
        private int Tope;
        private int Cantidad;
        private int CantidadVerificacion;
        private double Rango;

        private EnumSorteo SorteoPredefinido = EnumSorteo.PERSONALIZADO;

        private Sorteo SorteoGenerico;

        private DateTime FechaSorteo = new DateTime();

        /*
         * Botones
         */
        private void BtnCerrar_Click(object sender, EventArgs e) {
            this.Close();
        }

        /// <summary>
        /// Genera el sorteo con los parametros seleccionados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnGenerar_Click(object sender, EventArgs e) {
            // obtener los parametros numericos y continuar si son correctos.
            FechaSorteo = dateTimePickerFechaSorteo.Value;
            if(ObtenerParametrosNumericos()) {
                // vaciar los cuadros de resultados
                if(!ComprobarLimiteSorteo(Cantidad, Inicio, Tope)) {
                    MessageBox.Show("No se pueden sortear " + Cantidad.ToString() + " numeros en el rango seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    try {
                        switch(SorteoPredefinido) {
                            case EnumSorteo.GENERICA:
                                SorteoGenerico = new Generica {
                                    Inicio = Inicio,
                                    Tope = Tope,
                                    Rango = Rango
                                };
                                SorteoGenerico.SortearNumeros();
                                Cantidad = (SorteoGenerico as Generica).Cantidad;
                                VistaTabla.MostrarResultado(SorteoGenerico.Resultado, OrdenarResultado, this.dataGridNumeros);
                                break;
                            case EnumSorteo.PERSONALIZADO:
                                SorteoGenerico = new Personalizado {
                                    Inicio = Inicio,
                                    Tope = Tope,
                                    PermitirDuplicados = PermitirDuplicados
                                };
                                if(UtilizarRango) {
                                    (SorteoGenerico as Personalizado).Rango = Rango;
                                    (SorteoGenerico as Personalizado).UsarRango = true;
                                } else {
                                    (SorteoGenerico as Personalizado).Cantidad = Cantidad;
                                }
                                SorteoGenerico.SortearNumeros();
                                VistaTabla.MostrarResultado(SorteoGenerico.Resultado, OrdenarResultado, this.dataGridNumeros);
                                if(IncluirVerificacion) {
                                    (SorteoGenerico as Personalizado).CantidadVerificacion = CantidadVerificacion;
                                    (SorteoGenerico as Personalizado).SortearNumerosVerificacion();
                                    VistaTabla.MostrarResultado((SorteoGenerico as Personalizado).ResultadoVerificacion, OrdenarResultado, this.dataGridVerificacion);
                                }
                                break;

                            case EnumSorteo.HACCP:
                                SorteoGenerico = new Haccp {
                                    Inicio = Inicio,
                                    Tope = Tope,
                                    Cantidad = Cantidad,
                                    CantidadVerificacion = CantidadVerificacion
                                };
                                SorteoGenerico.SortearNumeros();
                                VistaTabla.MostrarResultado(SorteoGenerico.Resultado, OrdenarResultado, this.dataGridNumeros);
                                if(IncluirVerificacion) {
                                    (SorteoGenerico as Haccp).CantidadVerificacion = CantidadVerificacion;
                                    (SorteoGenerico as Haccp).SortearNumerosVerificacion();
                                    VistaTabla.MostrarResultado((SorteoGenerico as Haccp).ResultadoVerificacion, OrdenarResultado, this.dataGridVerificacion);
                                }
                                break;

                            // default cubre los sorteos restantes UE, Cloracion, Lado
                            default:
                                SorteoGenerico = new Personalizado {
                                    Inicio = Inicio,
                                    Tope = Tope,
                                    Cantidad = Cantidad,
                                    PermitirDuplicados = false,
                                    UsarRango = false
                                };
                                SorteoGenerico.SortearNumeros();
                                VistaTabla.MostrarResultado(SorteoGenerico.Resultado, OrdenarResultado, this.dataGridNumeros);
                                break;
                        }
                    } catch(Exception ex) {
                        MostrarMensajeError(ex);
                    }
                }
            }
        }

        #region Sorteos Predefinidos (radio buttons)
        //Botones de Opcion (radio buttons): seleccion de tipo de sorteo.

        private void RadioPersonalizado_CheckedChanged(object sender, EventArgs e) {
            if(this.radioPersonalizado.Checked) {
                this.SorteoPredefinido = EnumSorteo.PERSONALIZADO;

                // radio buttons
                CambiarEstadoRadioButtons();
                CambiarHabilitacionRadioButtons(true, true, true, true);

                // valores predefinidos
                VaciarCuadrosTexto();

                // habiilitar/deshabilitar controles
                // campos de ingreso de texto
                CambiarHabilitacionCuadroTexto(inicio: true, tope: true, cantidad: true);
            }
        }

        void RadioHaccpCheckedChanged(object sender, EventArgs e) {
            if((sender as RadioButton).Checked) {
                this.SorteoPredefinido = EnumSorteo.HACCP;

                // radio buttons
                CambiarEstadoRadioButtons(verificacion: true);
                CambiarHabilitacionRadioButtons();

                // valores predefinidos
                VaciarCuadrosTexto();
                txtInicio.Text = "1";
                Inicio = 1;

                // habilitar/deshabilitar controles
                // campos de ingreso de texto
                CambiarHabilitacionCuadroTexto(tope: true, verificacion: true, cantidad: true);
            }
        }

        private void VaciarCuadrosTexto() {
            this.txtInicio.Text = string.Empty;
            this.txtTope.Text = string.Empty;
            this.txtCantidad.Text = string.Empty;
            this.txtRango.Text = string.Empty;
            this.txtCantVerificacion.Text = string.Empty;
        }

        private void CambiarEstadoRadioButtons(bool duplicados = false, bool ordenados = false, bool verificacion = false, bool rango = false) {
            this.chkDuplicados.Checked = duplicados;
            this.chkOrdenados.Checked = ordenados;
            this.chkVerificacion.Checked = verificacion;
            this.chkRango.Checked = rango;
        }

        private void CambiarHabilitacionRadioButtons(bool duplicados = false, bool ordenados = false, bool verificacion = false, bool rango = false) {
            this.chkDuplicados.Enabled = duplicados;
            this.chkOrdenados.Enabled = ordenados;
            this.chkVerificacion.Enabled = verificacion;
            this.chkRango.Enabled = rango;
        }

        private void CambiarHabilitacionCuadroTexto(bool inicio = false, bool tope = false, bool rango = false, bool verificacion = false,
            bool cantidad = false) {
            this.txtInicio.Enabled = inicio;
            this.txtTope.Enabled = tope;
            this.txtRango.Enabled = rango;
            this.txtCantVerificacion.Enabled = verificacion;
            this.txtCantidad.Enabled = cantidad;
        }

        private void RadioLado_CheckedChanged(object sender, EventArgs e) {
            if(radioLado.Checked) {
                this.SorteoPredefinido = EnumSorteo.LADO;
                // habiilitar/deshabilitar controles
                // campos de ingreso de texto
                CambiarHabilitacionCuadroTexto();

                // radio buttons
                CambiarEstadoRadioButtons();
                CambiarHabilitacionRadioButtons();

                // valores predefinidos
                VaciarCuadrosTexto();

                this.txtInicio.Text = "1";
                Inicio = 1;
                this.txtTope.Text = "2";
                Tope = 2;
                this.txtCantidad.Text = "1";
                Cantidad = 1;
            }
        }

        private void RadioUE_CheckedChanged(object sender, EventArgs e) {
            if(this.radioUE.Checked) {
                this.SorteoPredefinido = EnumSorteo.UE;
                // habiilitar/deshabilitar controles
                // campos de ingreso de texto
                CambiarHabilitacionCuadroTexto(tope: true, cantidad: true);

                // valores predefinidos
                VaciarCuadrosTexto();
                this.txtInicio.Text = "1";
                Inicio = 1;

                // checks predefinidos
                CambiarEstadoRadioButtons(ordenados: true);
                CambiarHabilitacionRadioButtons();
            }
        }

        private void RadioCloracion_CheckedChanged(object sender, EventArgs e) {
            if(this.radioCloracion.Checked) {
                this.SorteoPredefinido = EnumSorteo.CLORACION;
                // habiilitar/deshabilitar controles
                // campos de ingreso de texto
                CambiarHabilitacionCuadroTexto(tope: true, cantidad: true);

                // radio buttons
                CambiarEstadoRadioButtons();
                CambiarHabilitacionRadioButtons();

                // valores predefinidos
                VaciarCuadrosTexto();
                this.txtInicio.Text = "0";
                Inicio = 0;
            }
        }

        private void RadioGenerica_CheckedChanged(object sender, EventArgs e) {
            if(this.radioGenerica.Checked) {
                this.SorteoPredefinido = EnumSorteo.GENERICA;
                // habiilitar/deshabilitar controles
                // campos de ingreso de texto
                CambiarHabilitacionCuadroTexto(tope: true, rango: true);

                // radio buttons
                CambiarEstadoRadioButtons(ordenados: true, rango: true);
                CambiarHabilitacionRadioButtons();

                // valores predefinidos
                VaciarCuadrosTexto();

                this.txtInicio.Text = "1";
                Inicio = 1;
            }
        }
        #endregion

        #region Opciones de Sorteo
        // habilita opciones adicionales para los sorteos

        private void ChkRango_CheckedChanged(object sender, EventArgs e) {
            UtilizarRango = (sender as CheckBox).Checked;
            if(!UtilizarRango) {
                this.txtRango.Enabled = false;
                this.chkDuplicados.Enabled = true;
                this.txtCantidad.Enabled = true;
            } else {
                this.txtRango.Enabled = true;
                this.chkDuplicados.Enabled = false;
                this.txtCantidad.Enabled = false;
            }
        }

        private void ChkDuplicados_CheckedChanged(object sender, EventArgs e) {
            PermitirDuplicados = (sender as CheckBox).Checked;
        }

        private void ChkOrdenados_CheckedChanged(object sender, EventArgs e) {
            OrdenarResultado = (sender as CheckBox).Checked;
        }

        private void ChkVerificacion_CheckedChanged(object sender, EventArgs e) {
            IncluirVerificacion = (sender as CheckBox).Checked;
            if(!IncluirVerificacion) {
                this.txtCantVerificacion.Enabled = false;
            } else {
                this.txtCantVerificacion.Enabled = true;
            }
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Comprueba que el rango de fecha sea suficiente para el total a sortear.
        /// </summary>
        /// <param name="cantidad"></param>
        /// <param name="fechaInicio"></param>
        /// <param name="fechaTope"></param>
        /// <returns></returns>
        private bool ComprobarLimiteSorteo(int cantidad, int numeroInicio, int numeroTope) {
            int diferencia = numeroTope - numeroInicio;
            if(cantidad > diferencia) {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Parsea los valores string ingresados al valor numerico correspondiente.
        /// Muestra cuadro de mensaje ante error.
        /// <return>True: si los valores son correctos, False de lo contrario.</return>
        /// </summary>
        private bool ObtenerParametrosNumericos() {
            try {
                if(this.txtInicio.Enabled) Inicio = int.Parse(this.txtInicio.Text);
                if(this.txtTope.Enabled) Tope = int.Parse(this.txtTope.Text);
                if(this.txtRango.Enabled) Rango = double.Parse(this.txtRango.Text);
                if(this.txtCantidad.Enabled) Cantidad = int.Parse(this.txtCantidad.Text);
                if(this.txtCantVerificacion.Enabled) CantidadVerificacion = int.Parse(this.txtCantVerificacion.Text);
            } catch(FormatException ex) {
                MostrarMensajeError(ex);
                return false;
            } catch(NullReferenceException ex) {
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

        private void BtnImprimir_Click(object sender, EventArgs e) {
            if(SorteoGenerico != null && SorteoGenerico.Resultado.Any()) {
                SaveFileDialog dialogoDestino = new SaveFileDialog();
                dialogoDestino.Filter = "Archivo PDF (Portable Document Format)|*.pdf";
                StringBuilder strNombre = new StringBuilder();
                strNombre.Append(SorteoPredefinido.ToString())
                .Append(" ")
                .Append(FechaSorteo.ToShortDateString().Replace('/', '.'));
                dialogoDestino.FileName = strNombre.ToString();
                DialogResult resultado = dialogoDestino.ShowDialog();

                if(resultado == DialogResult.OK) {
                    string destino = dialogoDestino.FileName;
                    List<int> verificacion;
                    if(SorteoGenerico is Personalizado) {
                        verificacion = chkVerificacion.Checked ? (SorteoGenerico as Personalizado).ResultadoVerificacion : new List<int>();
                    } else {
                        verificacion = (SorteoGenerico as Haccp).ResultadoVerificacion;
                    }
                    ControladorPDF pdf = new ControladorPDF();
                    string rango = chkRango.Checked ? rango = Rango.ToString() : rango = "N/A";
                    pdf.GuardarDocumento(destino, "Sorteo: " + SorteoPredefinido.ToString(), FechaSorteo.ToShortDateString(),
                        SorteoGenerico.Inicio.ToString(), SorteoGenerico.Tope.ToString(), rango,
                        SorteoGenerico.Resultado, verificacion);
                }
            } else {
                System.Windows.Forms.MessageBox.Show("No se ha realizado ningún sorteo.", "?", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
            }
        }
    }
}

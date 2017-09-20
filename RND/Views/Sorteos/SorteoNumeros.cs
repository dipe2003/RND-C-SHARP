using RND.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RND.Views.Sorteos {
    public partial class SorteoNumeros :Form {
        public SorteoNumeros() {
            InitializeComponent();
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

        /*
         * Botones
         */
        private void btnCerrar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnGenerar_Click(object sender, EventArgs e) {
            // obtener los parametros numericos y continuar si son correctos.
            if(ObtenerParametrosNumericos()) {
                // vaciar los cuadros de resultados
                if(!ComprobarLimiteSorteo(Cantidad, Inicio, Tope)) {
                    MessageBox.Show("No se pueden sortear " + Cantidad.ToString() + " numeros en el rango seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    //Sorteo sorteo;
                    Sorteo SorteoGenerico;
                    try {
                        switch(SorteoPredefinido) {
                            case EnumSorteo.GENERICA:
                                SorteoGenerico = new Generica();
                                SorteoGenerico.Inicio = Inicio;
                                SorteoGenerico.Tope = Tope;
                                ((Generica)(SorteoGenerico)).Rango = Rango;
                                SorteoGenerico.SortearNumeros();
                                MostrarResultado(SorteoGenerico.Resultado, OrdenarResultado, this.dataGridNumeros);
                                break;
                            case EnumSorteo.PERSONALIZADO:
                                Personalizado SorteoPersonalizado = new Personalizado();
                                SorteoPersonalizado.Inicio = Inicio;
                                SorteoPersonalizado.Tope = Tope;
                                SorteoPersonalizado.PermitirDuplicados = PermitirDuplicados;
                                if(UtilizarRango) {
                                    SorteoPersonalizado.Rango = Rango;
                                    SorteoPersonalizado.UsarRango = true;
                                } else {
                                    SorteoPersonalizado.Cantidad = Cantidad;
                                }
                                SorteoPersonalizado.SortearNumeros();
                                MostrarResultado(SorteoPersonalizado.Resultado, OrdenarResultado, this.dataGridNumeros);
                                if(IncluirVerificacion) {
                                    SorteoPersonalizado.CantidadVerificacion = CantidadVerificacion;
                                    SorteoPersonalizado.SortearNumerosVerificacion();
                                    MostrarResultado(SorteoPersonalizado.ResultadoVerificacion, OrdenarResultado, this.dataGridVerificacion);
                                }
                                break;
                            // default cubre los sorteos restantes UE, Cloracion, Lado
                            default:
                                SorteoGenerico = new Personalizado();
                                SorteoGenerico.Inicio = Inicio;
                                SorteoGenerico.Tope = Tope;
                                ((Personalizado)(SorteoGenerico)).Cantidad = Cantidad;
                                ((Personalizado)(SorteoGenerico)).PermitirDuplicados = false;
                                ((Personalizado)(SorteoGenerico)).UsarRango = false;
                                SorteoGenerico.SortearNumeros();
                                MostrarResultado(SorteoGenerico.Resultado, OrdenarResultado, this.dataGridNumeros);
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

        private void radioPersonalizado_CheckedChanged(object sender, EventArgs e) {
            if(this.radioPersonalizado.Checked) {
                this.SorteoPredefinido = EnumSorteo.PERSONALIZADO;

                // radio buttons
                this.chkDuplicados.Checked = false;
                this.chkOrdenados.Checked = false;
                this.chkVerificacion.Checked = false;
                this.chkRango.Checked = false;

                this.chkDuplicados.Enabled = true;
                this.chkOrdenados.Enabled = true;
                this.chkVerificacion.Enabled = true;
                this.chkRango.Enabled = true;

                // valores predefinidos
                this.txtInicio.Text = string.Empty;
                this.txtTope.Text = string.Empty;
                this.txtCantidad.Text = string.Empty;
                this.txtRango.Text = string.Empty;
                this.txtCantVerificacion.Text = string.Empty;

                // habiilitar/deshabilitar controles
                // campos de ingreso de texto
                this.txtInicio.Enabled = true;
                this.txtTope.Enabled = true;
                this.txtCantidad.Enabled = true;
                this.txtRango.Enabled = false;
                this.txtCantVerificacion.Enabled = false;
            }
        }
        
        private void radioLado_CheckedChanged(object sender, EventArgs e) {
            if(this.radioLado.Checked) {
                this.SorteoPredefinido = EnumSorteo.LADO;
                // habiilitar/deshabilitar controles
                // campos de ingreso de texto
                this.txtInicio.Enabled = false;
                this.txtTope.Enabled = false;
                this.txtRango.Enabled = false;
                this.txtCantVerificacion.Enabled = false;

                // radio buttons
                this.chkOrdenados.Enabled = false;
                this.chkVerificacion.Enabled = false;
                this.chkRango.Enabled = false;

                // valores predefinidos
                this.txtInicio.Text = "1";
                Inicio = 1;
                this.txtTope.Text = "2";
                Tope = 2;
                this.txtCantidad.Text = "1";
                Cantidad = 1;
                this.txtRango.Text = string.Empty;
                this.txtCantVerificacion.Text = string.Empty;

                // checks predefinidos
                this.chkOrdenados.Checked = false;
                this.chkDuplicados.Checked = false;
                this.chkVerificacion.Checked = false;
                this.chkRango.Checked = false;

                this.chkDuplicados.Enabled = false;
                this.txtCantidad.Enabled = false;
            }
        }

        private void radioUE_CheckedChanged(object sender, EventArgs e) {
            if(this.radioUE.Checked) {
                this.SorteoPredefinido = EnumSorteo.UE;
                // habiilitar/deshabilitar controles
                // campos de ingreso de texto
                this.txtInicio.Enabled = false;
                this.txtTope.Enabled = true;
                this.txtCantidad.Enabled = true;
                this.txtRango.Enabled = false;
                this.txtCantVerificacion.Enabled = false;

                // radio buttons                
                this.chkOrdenados.Enabled = false;
                this.chkVerificacion.Enabled = false;
                this.chkRango.Enabled = false;

                // valores predefinidos
                this.txtInicio.Text = "1";
                Inicio = 1;
                this.txtTope.Text = string.Empty;
                this.txtCantidad.Text = string.Empty;
                this.txtRango.Text = string.Empty;
                this.txtCantVerificacion.Text = string.Empty;

                // checks predefinidos
                this.chkOrdenados.Checked = true;
                this.chkDuplicados.Checked = false;
                this.chkVerificacion.Checked = false;
                this.chkRango.Checked = false;

                this.chkDuplicados.Enabled = false;
            }
        }

        private void radioCloracion_CheckedChanged(object sender, EventArgs e) {
            if(this.radioCloracion.Checked) {
                this.SorteoPredefinido = EnumSorteo.CLORACION;
                // habiilitar/deshabilitar controles
                // campos de ingreso de texto
                this.txtInicio.Enabled = false;
                this.txtTope.Enabled = true;
                this.txtCantidad.Enabled = true;
                this.txtRango.Enabled = false;
                this.txtCantVerificacion.Enabled = false;

                // radio buttons
                this.chkOrdenados.Enabled = false;
                this.chkVerificacion.Enabled = false;
                this.chkRango.Enabled = false;

                // valores predefinidos
                this.txtInicio.Text = "0";
                Inicio = 0;
                this.txtTope.Text = string.Empty;
                this.txtCantidad.Text = string.Empty;
                this.txtRango.Text = string.Empty;
                this.txtCantVerificacion.Text = string.Empty;

                // checks predefinidos
                this.chkOrdenados.Checked = false;
                this.chkVerificacion.Checked = false;
                this.chkRango.Checked = false;
                this.chkDuplicados.Checked = false;

                this.chkDuplicados.Enabled = false;
            }
        }

        private void radioGenerica_CheckedChanged(object sender, EventArgs e) {
            if(this.radioGenerica.Checked) {
                this.SorteoPredefinido = EnumSorteo.GENERICA;
                // habiilitar/deshabilitar controles
                // campos de ingreso de texto
                this.txtInicio.Enabled = false;
                this.txtTope.Enabled = true;
                this.txtCantidad.Enabled = false;
                this.txtRango.Enabled = true;
                this.txtCantVerificacion.Enabled = false;

                // radio buttons
                this.chkVerificacion.Enabled = false;
                this.chkRango.Enabled = false;
                this.chkOrdenados.Enabled = false;

                // valores predefinidos
                this.txtInicio.Text = "1";
                Inicio = 1;
                this.txtTope.Text = string.Empty;
                this.txtCantidad.Text = string.Empty;
                this.txtRango.Text = string.Empty;
                this.txtCantVerificacion.Text = string.Empty;

                // checks predefinidos
                this.chkOrdenados.Checked = true;
                this.chkVerificacion.Checked = false;
                this.chkRango.Checked = true;
                this.chkDuplicados.Checked = false;

                this.chkDuplicados.Enabled = false;
            }
        }
        #endregion

        #region Opciones de Sorteo
        // habilita opciones adicionales para los sorteos

        private void chkRango_CheckedChanged(object sender, EventArgs e) {
            if(!this.chkRango.Checked) {
                UtilizarRango = false;
                this.txtRango.Enabled = false;
                this.chkDuplicados.Enabled = true;
                this.txtCantidad.Enabled = true;
            } else {
                UtilizarRango = true;
                this.txtRango.Enabled = true;
                this.chkDuplicados.Enabled = false;
                this.txtCantidad.Enabled = false;
            }
        }

        private void chkDuplicados_CheckedChanged(object sender, EventArgs e) {
            if(!this.chkDuplicados.Checked) {
                PermitirDuplicados = false;
            } else {
                PermitirDuplicados = true;
            }
        }

        private void chkOrdenados_CheckedChanged(object sender, EventArgs e) {
            if(!this.chkOrdenados.Checked) {
                OrdenarResultado = false;
            } else {
                OrdenarResultado = true;
            }
        }

        private void chkVerificacion_CheckedChanged(object sender, EventArgs e) {
            if(!this.chkVerificacion.Checked) {
                IncluirVerificacion = false;
                this.txtCantVerificacion.Enabled = false;
            } else {
                IncluirVerificacion = true;
                this.txtCantVerificacion.Enabled = true;
            }
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Genera una string de los numeros indicados y los muestra en al cuadro de texto.
        /// </summary>
        /// <param name="Resultado"></param>
        /// <param name="ordenados"></param>
        /// <param name="contenedor"></param>
        private void MostrarResultado(List<int> Resultado, bool ordenados, DataGridView tabla) {
            if(ordenados) {
                Resultado.Sort();
            }
            List<string> lista = new List<string>();
            foreach(int numero in Resultado) {
                lista.Add(numero.ToString());
            }
            VistaTabla.LlenarTabla(lista, "#", "Numero", tabla);
        }

        /// <summary>
        /// Comprueba que el rango de fecha sea suficiente para el total a sortear.
        /// </summary>
        /// <param name="cantidad"></param>
        /// <param name="fechaInicio"></param>
        /// <param name="fechaTope"></param>
        /// <returns></returns>
        private bool ComprobarLimiteSorteo(int cantidad, int numeroInicio, int numeroTope) {
            int diferencia = numeroTope - numeroInicio;
            if(cantidad >= diferencia) {
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

        /*
         * Barra de Menu
         */
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e) {
            switch(SorteoPredefinido) {
                case EnumSorteo.GENERICA:
                    this.radioGenerica.Checked = true;
                    break;
                case EnumSorteo.CLORACION:
                    this.radioCloracion.Checked = true;
                    break;
                case EnumSorteo.UE:
                    this.radioUE.Checked = true;
                    break;
                case EnumSorteo.LADO:
                    this.radioLado.Checked = true;
                    break;
                case EnumSorteo.PERSONALIZADO:
                    this.radioPersonalizado.Checked = true;
                    break;
                default:
                    break;
            }
        }

    }
}

using RND.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RND {
    public partial class Inicio : Form {
        public Inicio() {
            InitializeComponent();
        }

        /*
         * Propiedades / Variables
         */
        private bool UtilizarRango = false;
        private bool IncluirVerificacion = false;
        private bool PermitirDuplicados = false;
        private bool OrdenarResultado = false;

        private EnumSorteo SorteoPredefinido = EnumSorteo.PERSONALIZADO;

        /*
         * Botones
         */
        private void btnSalir_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnGenerar_Click(object sender, EventArgs e) {
            // vaciar los cuadros de resultados
            this.txtResultado.Clear();
            this.txtResultadoVerificacion.Clear();
            //Sorteo sorteo;
            switch(SorteoPredefinido) {
                case EnumSorteo.GENERICA:
                    try {
                        Generica SorteoGenerica = new Generica();
                        SorteoGenerica.Inicio = int.Parse(this.txtInicio.Text);
                        SorteoGenerica.Tope = int.Parse(this.txtTope.Text);
                        SorteoGenerica.Rango = double.Parse(this.txtRango.Text);
                        SorteoGenerica.SortearNumeros();
                        MostrarResultado(SorteoGenerica.Resultado, OrdenarResultado, this.txtResultado);
                    } catch(FormatException ex) {
                        MessageBox.Show("Faltan datos o los valores ingresados no son correctos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        System.Console.WriteLine("Error: " + ex.Message);
                    } catch(NullReferenceException ex) {
                        MessageBox.Show("Faltan datos o los valores ingresados no son correctos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        System.Console.WriteLine("Error: " + ex.Message);
                    } catch(ArgumentException ex) {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        System.Console.WriteLine("Error: " + ex.Message + ex.InnerException);
                    }
                    break;
                case EnumSorteo.CLORACION:
                    try {
                        Personalizado SorteoCloracion = new Personalizado();
                        SorteoCloracion.Inicio = int.Parse(this.txtInicio.Text);
                        SorteoCloracion.Tope = int.Parse(this.txtTope.Text);
                        SorteoCloracion.Cantidad = int.Parse(this.txtCantidad.Text);
                        SorteoCloracion.PermitirDuplicados = false;
                        SorteoCloracion.UsarRango = false;
                        SorteoCloracion.SortearNumeros();
                        MostrarResultado(SorteoCloracion.Resultado, OrdenarResultado, this.txtResultado);
                    } catch(FormatException ex) {
                        MessageBox.Show("Faltan datos o los valores ingresados no son correctos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        System.Console.WriteLine("Error: " + ex.Message);
                    } catch(NullReferenceException ex) {
                        MessageBox.Show("Faltan datos o los valores ingresados no son correctos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        System.Console.WriteLine("Error: " + ex.Message);
                    } catch(ArgumentException ex) {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        System.Console.WriteLine("Error: " + ex.Message);
                    }
                    break;
                case EnumSorteo.UE:
                    break;
                case EnumSorteo.DIA_SEMANA:
                    try {
                        Personalizado SorteoDia = new Personalizado();
                        SorteoDia.Inicio = int.Parse(this.txtInicio.Text);
                        SorteoDia.Tope = int.Parse(this.txtTope.Text);
                        SorteoDia.Cantidad = int.Parse(this.txtCantidad.Text);
                        SorteoDia.PermitirDuplicados = false;
                        SorteoDia.UsarRango = false;
                        SorteoDia.SortearNumeros();
                        MostrarResultado(SorteoDia.Resultado, OrdenarResultado, this.txtResultado);
                    } catch(FormatException ex) {
                        MessageBox.Show("Faltan datos o los valores ingresados no son correctos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        System.Console.WriteLine("Error: " + ex.Message);
                    } catch(NullReferenceException ex) {
                        MessageBox.Show("Faltan datos o los valores ingresados no son correctos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        System.Console.WriteLine("Error: " + ex.Message);
                    } catch(ArgumentException ex) {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        System.Console.WriteLine("Error: " + ex.Message);
                    }
                    break;
                case EnumSorteo.MES_ANIO:
                    try {
                        Personalizado SorteoMes = new Personalizado();
                        SorteoMes.Inicio = int.Parse(this.txtInicio.Text);
                        SorteoMes.Tope = int.Parse(this.txtTope.Text);
                        SorteoMes.Cantidad = int.Parse(this.txtCantidad.Text);
                        SorteoMes.PermitirDuplicados = false;
                        SorteoMes.UsarRango = false;
                        SorteoMes.SortearNumeros();
                        MostrarResultado(SorteoMes.Resultado, OrdenarResultado, this.txtResultado);
                    } catch(FormatException ex) {
                        MessageBox.Show("Faltan datos o los valores ingresados no son correctos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        System.Console.WriteLine("Error: " + ex.Message);
                    } catch(NullReferenceException ex) {
                        MessageBox.Show("Faltan datos o los valores ingresados no son correctos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        System.Console.WriteLine("Error: " + ex.Message);
                    } catch(ArgumentException ex) {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        System.Console.WriteLine("Error: " + ex.Message);
                    }
                    break;
                case EnumSorteo.LADO:
                    Personalizado sorteo = new Personalizado();
                    sorteo.Inicio = int.Parse(this.txtInicio.Text);
                    sorteo.Tope = int.Parse(this.txtTope.Text);
                    sorteo.Cantidad = int.Parse(this.txtCantidad.Text);
                    sorteo.PermitirDuplicados = false;
                    sorteo.UsarRango = false;
                    sorteo.SortearNumeros();
                    MostrarResultado(sorteo.Resultado, OrdenarResultado, this.txtResultado);
                    break;
                case EnumSorteo.PERSONALIZADO:
                    try {
                        Personalizado SorteoPersonalizado = new Personalizado();
                        SorteoPersonalizado.Inicio = int.Parse(this.txtInicio.Text);
                        SorteoPersonalizado.Tope = int.Parse(this.txtTope.Text);
                        SorteoPersonalizado.Cantidad = int.Parse(this.txtCantidad.Text);
                        SorteoPersonalizado.PermitirDuplicados = PermitirDuplicados;
                        if(UtilizarRango) {
                            SorteoPersonalizado.Rango = double.Parse(this.txtRango.Text);
                            SorteoPersonalizado.UsarRango = true;
                        }
                        SorteoPersonalizado.SortearNumeros();
                        MostrarResultado(SorteoPersonalizado.Resultado, OrdenarResultado, this.txtResultado);
                        if(IncluirVerificacion) {
                            SorteoPersonalizado.CantidadVerificacion = int.Parse(this.txtCantVerificacion.Text);
                            SorteoPersonalizado.SortearNumerosVerificacion();
                            MostrarResultado(SorteoPersonalizado.ResultadoVerificacion, OrdenarResultado, this.txtResultadoVerificacion);
                        }
                    } catch(FormatException ex) {
                        MessageBox.Show("Faltan datos o los valores ingresados no son correctos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        System.Console.WriteLine("Error: " + ex.Message);
                    } catch(NullReferenceException ex) {
                        MessageBox.Show("Faltan datos o los valores ingresados no son correctos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        System.Console.WriteLine("Error: " + ex.Message);
                    } catch(ArgumentException ex) {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        System.Console.WriteLine("Error: " + ex.Message);
                    }
                    break;
                default:
                    break;
            }
        }

        /*
         * Botones de Opcion (radio buttons): seleccion de tipo de sorteo.
         */

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


        private void radioDiaSemana_CheckedChanged(object sender, EventArgs e) {
            if(this.radioDiaSemana.Checked) {
                this.SorteoPredefinido = EnumSorteo.DIA_SEMANA;
                // habiilitar/deshabilitar controles
                // campos de ingreso de texto
                this.txtInicio.Enabled = false;
                this.txtTope.Enabled = false;
                this.txtCantidad.Enabled = true;
                this.txtRango.Enabled = false;
                this.txtCantVerificacion.Enabled = false;

                // radio buttons
                this.chkOrdenados.Enabled = false;
                this.chkVerificacion.Enabled = false;
                this.chkRango.Enabled = false;

                // valores predefinidos
                this.txtInicio.Text = "1";
                this.txtTope.Text = "7";
                this.txtCantidad.Text = string.Empty;
                this.txtRango.Text = string.Empty;
                this.txtCantVerificacion.Text = string.Empty;

                // checks predefinidos
                this.chkOrdenados.Checked = false;
                this.chkDuplicados.Checked = false;
                this.chkVerificacion.Checked = false;
                this.chkRango.Checked = false;

                this.chkDuplicados.Enabled = false;
            }
        }

        private void radioMes_CheckedChanged(object sender, EventArgs e) {
            if(this.radioMes.Checked) {
                this.SorteoPredefinido = EnumSorteo.MES_ANIO;
                // habiilitar/deshabilitar controles
                // campos de ingreso de texto
                this.txtInicio.Enabled = false;
                this.txtTope.Enabled = false;
                this.txtCantidad.Enabled = true;
                this.txtRango.Enabled = false;
                this.txtCantVerificacion.Enabled = false;

                // radio buttons                
                this.chkOrdenados.Enabled = false;
                this.chkVerificacion.Enabled = false;
                this.chkRango.Enabled = false;

                // valores predefinidos
                this.txtInicio.Text = "1";
                this.txtTope.Text = "12";
                this.txtCantidad.Text = string.Empty;
                this.txtRango.Text = string.Empty;
                this.txtCantVerificacion.Text = string.Empty;

                // checks predefinidos
                this.chkOrdenados.Checked = false;
                this.chkDuplicados.Checked = false;
                this.chkVerificacion.Checked = false;
                this.chkRango.Checked = false;

                this.chkDuplicados.Enabled = false;
            }
        }

        private void radioLado_CheckedChanged(object sender, EventArgs e) {
            if(this.radioLado.Checked) {
                this.SorteoPredefinido = EnumSorteo.LADO;
                // habiilitar/deshabilitar controles
                // campos de ingreso de texto
                this.txtInicio.Enabled = false;
                this.txtTope.Enabled = false;
                this.txtCantidad.Enabled = false;
                this.txtRango.Enabled = false;
                this.txtCantVerificacion.Enabled = false;

                // radio buttons
                this.chkOrdenados.Enabled = false;
                this.chkVerificacion.Enabled = false;
                this.chkRango.Enabled = false;

                // valores predefinidos
                this.txtInicio.Text = "1";
                this.txtTope.Text = "2";
                this.txtCantidad.Text = "1";
                this.txtRango.Text = string.Empty;
                this.txtCantVerificacion.Text = string.Empty;

                // checks predefinidos
                this.chkOrdenados.Checked = false;
                this.chkDuplicados.Checked = false;
                this.chkVerificacion.Checked = false;
                this.chkRango.Checked = false;

                this.chkDuplicados.Enabled = false;
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

        /*
         * Botones de Opcion (check buttons): habilita opciones adicionales para sorteos.
         */
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

        /*
         * Metodos
         */


        /// <summary>
        /// Genera una string de los numeros indicados y los muestra en al cuadro de texto.
        /// </summary>
        /// <param name="Resultado"></param>
        /// <param name="ordenados"></param>
        /// <param name="contenedor"></param>
        private void MostrarResultado(List<int> Resultado, bool ordenados, TextBox contenedor) {
            contenedor.Clear();
            string resultado = string.Empty;
            int[] arr = new int[Resultado.Count];
            arr = Resultado.ToArray();
            if(ordenados) {
                int pos;
                int num;
                for(int i = 0; i < arr.Length; i++) {
                    num = arr[i];
                    pos = i;

                    while(pos > 0 && arr[pos - 1] > num) {
                        arr[pos] = arr[pos - 1];
                        pos = pos - 1;
                    }
                    arr[pos] = num;
                }
            }
            for(int i = 0; i < arr.Length; i++) {
                resultado = resultado + arr[i].ToString();
                int sig = i + 1;
                if(sig >= arr.Length) {
                    resultado = resultado + ".";
                } else {
                    resultado = resultado + ", ";
                }
            }
            contenedor.Text = resultado;
        }
    }
}

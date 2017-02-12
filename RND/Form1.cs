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

        private static Random aleatorio = new Random();

        private double valorRango;

        private int inicio;
        private int tope;
        private int cantidad;

        private bool mostrarOrdenados = false;
        private bool permitirDuplicados = false;
        private bool utilizarRango = false;

        /*
         * Botones
         */ 
        private void btnSalir_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnGenerar_Click(object sender, EventArgs e) {
            if(!ComprobarDatosIngresados()) {
                MessageBox.Show("Error: Faltan datos o no son correctos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else {
                List<int> sorteo = new List<int>();
                // si no se selecciono sorteo de generica
                if(!radioGenerica.Checked && !chkRango.Checked) {
                    sorteo = SortearNumero(inicio, tope, cantidad, permitirDuplicados);
                } else {
                    /*
                     * cociente = tope / rango
                     * la parte entera del cociente es el primer numero de la cantidad
                     * la parte decimal si > 0 se suma a cantidad
                     */
                    double cociente;
                    cociente = tope / valorRango;
                    cantidad = (int)cociente;
                    double resto = (cociente - (int)cociente);
                    if(resto > 0) cantidad++;
                    this.txtCantidad.Text = cantidad.ToString();

                    // sortear por intervalo 1-300 / 301 - 600 / 601 - xxx
                    for(int i = 1; i <= cantidad; i++) {
                        inicio = (i - 1) * (int)valorRango + 1;
                        if(tope < i * (int)valorRango) {
                            sorteo.AddRange(SortearNumero(inicio, tope, 1, permitirDuplicados));
                        } else {
                            sorteo.AddRange(SortearNumero(inicio, (i * (int)valorRango), 1, permitirDuplicados));
                        }
                    }
                }
                MostrarResultado(sorteo, mostrarOrdenados, txtResultado);
            }
        }

        /*
         * Botones de radio: sorteos predefinidos
         */ 

        private void radioGenerica_CheckedChanged(object sender, EventArgs e) {
            this.txtInicio.Text = "1";
            this.txtCantidad.Text = "1";

            this.txtInicio.Enabled = false;
            this.txtCantidad.Enabled = false;

            this.txtTope.Enabled = true;
            this.txtResultado.Text = "";

            this.chkDuplicados.Enabled = false;
            this.chkOrdenados.Enabled = false;
            this.chkOrdenados.Checked = true;

            this.chkRango.Checked = true;
            this.chkRango.Enabled = false;
            this.txtRango.Text = "300";
            this.txtRango.Enabled = true;
        }

        private void radioPersonalizado_CheckedChanged(object sender, EventArgs e) {
            this.txtInicio.Text = "";
            this.txtCantidad.Text = "";
            this.txtTope.Text = "";
            this.txtResultado.Text = "";
            this.txtInicio.Enabled = true;
            this.txtInicio.Enabled = true;
            this.txtCantidad.Enabled = true;
            this.txtTope.Enabled = true;
            this.chkDuplicados.Enabled = true;
            this.chkOrdenados.Enabled = true;
            this.chkOrdenados.Checked = false;
            this.chkDuplicados.Checked = false;

            this.chkRango.Checked = false;
            this.chkRango.Enabled = true;
            this.txtRango.Text = "-";
            this.txtRango.Enabled = false;
        }

        private void radioCloracion_CheckedChanged(object sender, EventArgs e) {
            this.txtInicio.Text = "0";
            this.txtCantidad.Text = "6";
            this.txtCantidad.Enabled = true;
            this.txtResultado.Text = "";
            this.txtInicio.Enabled = false;

            this.chkRango.Checked = false;
            this.chkRango.Enabled = false;
            this.txtRango.Text = "-";
            this.txtRango.Enabled = false;
        }

        private void radioUE_CheckedChanged(object sender, EventArgs e) {
            this.txtInicio.Text = "1";
            this.txtCantidad.Text = "";
            this.txtTope.Text = "";
            this.txtResultado.Text = "";
            this.txtInicio.Enabled = false;
            this.txtCantidad.Enabled = true;
            this.txtTope.Enabled = true;
            this.chkDuplicados.Enabled = false;
            this.permitirDuplicados = false;

            this.chkRango.Checked = false;
            this.chkRango.Enabled = false;
            this.txtRango.Text = "-";
            this.txtRango.Enabled = false;
        }

        private void radioLado_CheckedChanged(object sender, EventArgs e) {
            this.txtInicio.Text = "1";
            this.txtCantidad.Text = "1";
            this.txtTope.Text = "2";
            this.txtResultado.Text = "";
            this.permitirDuplicados = false;
            this.mostrarOrdenados = false;

            this.txtCantidad.Enabled = false;
            this.txtInicio.Enabled = false;
            this.txtTope.Enabled = false;
            this.chkDuplicados.Enabled = false;
            this.chkOrdenados.Enabled = false;

            this.chkRango.Checked = false;
            this.chkRango.Enabled = false;
            this.txtRango.Text = "-";
            this.txtRango.Enabled = false;
        }

        private void radioMes_CheckedChanged(object sender, EventArgs e) {
            this.txtInicio.Text = "1";
            this.txtTope.Text = "12";
            this.txtResultado.Text = "";

            this.txtInicio.Enabled = false;
            this.txtCantidad.Enabled = true;
            this.txtTope.Enabled = false;
            this.chkDuplicados.Enabled = true;
            this.chkOrdenados.Enabled = true;

            this.chkRango.Checked = false;
            this.chkRango.Enabled = false;
            this.txtRango.Text = "-";
            this.txtRango.Enabled = false;
        }

        private void radioDiaSemana_CheckedChanged(object sender, EventArgs e) {
            this.txtInicio.Text = "1";
            this.txtTope.Text = "7";
            this.txtResultado.Text = "";

            this.txtInicio.Enabled = false;
            this.txtCantidad.Enabled = true;
            this.txtTope.Enabled = false;
            this.chkDuplicados.Enabled = true;
            this.chkOrdenados.Enabled = true;

            this.chkRango.Checked = false;
            this.chkRango.Enabled = false;
            this.txtRango.Text = "-";
            this.txtRango.Enabled = false;
        }

        // CheckButtons: opciones de sorteos
        private void chkDuplicados_CheckedChanged(object sender, EventArgs e) {
            if(permitirDuplicados) {
                permitirDuplicados = false;
            } else {
                permitirDuplicados = true;
            }
        }

        private void chkOrdenados_CheckedChanged(object sender, EventArgs e) {
            if(mostrarOrdenados) {
                mostrarOrdenados = false;
            } else {
                mostrarOrdenados = true;
            }
        }

        private void chkRango_CheckedChanged(object sender, EventArgs e) {
            if(utilizarRango) {
                utilizarRango = false;
                this.txtRango.Enabled = false;
                this.txtCantidad.Enabled = true;
                this.txtCantidad.Text = "0";
            } else {
                utilizarRango = true;
                this.txtRango.Enabled = true;
                this.txtCantidad.Enabled = false;
                this.txtCantidad.Text = "-";
            }
        }

        /*
         * Metodos
         */ 
         /// <summary>
         /// Genera numeros aleatoris dentro del rango especificado.
         /// Pueden ser unicos o no.
         /// </summary>
         /// <param name="min"></param>
         /// <param name="max"></param>
         /// <param name="Cantidad"></param>
         /// <param name="duplicado"></param>
         /// <returns>Retorna una lista con los numeros enteros generados, de lo contrario una lista vacia.</returns>
        private List<int> SortearNumero(int min, int max, int Cantidad, bool duplicado) {
            List<int> sorteo = new List<int>();
            if(!duplicado) {
                for(int i = 0; i < Cantidad; i++) {
                    int numero;
                    do {
                        numero = aleatorio.Next((max - min + 1)) + min;
                    } while(sorteo.Contains(numero));
                    sorteo.Add(numero);
                }
            } else {
                for(int i = 0; i < Cantidad; i++) {
                    int numero = aleatorio.Next((max - min + 1)) + min;
                    sorteo.Add(numero);
                }
            }
            return sorteo;
        }

        /// <summary>
        /// Genera una string de los numeros indicados y los muestra en al cuadro de texto.
        /// </summary>
        /// <param name="Resultado"></param>
        /// <param name="ordenados"></param>
        /// <param name="contenedor"></param>
        private void MostrarResultado(List<int> Resultado, bool ordenados, TextBox contenedor) {
            string resultado = "";
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

        /// <summary>
        /// Comprueba que los datos ingresados sean correctos para generar los numeros aleatorios.
        /// </summary>
        /// <returns></returns>
        private bool ComprobarDatosIngresados() {
            if(this.txtCantidad.Text.Length == 0 || this.txtInicio.Text.Length == 0 ||
                    this.txtTope.Text.Length == 0) {
                return false;
            } else {
                try {
                    inicio = int.Parse(this.txtInicio.Text);
                    tope = int.Parse(this.txtTope.Text);
                    if(!chkRango.Checked) {
                        cantidad = int.Parse(this.txtCantidad.Text);
                        if(inicio < 0 || tope < 0 || tope < inicio || cantidad < 0 || inicio == tope) {
                            return false;
                        }
                    } else {
                        valorRango = double.Parse(this.txtRango.Text);
                        if(inicio < 0 || tope < 0 || tope < inicio || inicio == tope || valorRango <= 0) {
                            return false;
                        }
                    }
                } catch(FormatException ex) {
                    System.Console.WriteLine("Error: " + ex.Message);
                    return false;
                } catch(NullReferenceException ex) {
                    System.Console.WriteLine("Error: " + ex.Message);
                    return false;
                }
                return true;
            }
        }
    }

}
